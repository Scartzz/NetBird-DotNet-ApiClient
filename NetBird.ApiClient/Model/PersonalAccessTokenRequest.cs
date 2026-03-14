


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Text.Json.Serialization;


using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = NetBird.ApiClient.Client.OpenAPIDateConverter;

namespace NetBird.ApiClient.Model;

/// <summary>
/// PersonalAccessTokenRequest
/// </summary>
[DataContract(Name = "PersonalAccessTokenRequest")]
public class PersonalAccessTokenRequest : IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PersonalAccessTokenRequest" /> class.
    /// </summary>
    [JsonConstructor]
    protected PersonalAccessTokenRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="PersonalAccessTokenRequest" /> class.
    /// </summary>
    /// <param name="name">Name of the token (required).</param>
    /// <param name="expiresIn">Expiration in days (required).</param>
    public PersonalAccessTokenRequest(string name = null, int expiresIn = 0)
    {
        // to ensure "name" is required (not null)
        ArgumentNullException.ThrowIfNull(name);
        this.Name = name;
        this.ExpiresIn = expiresIn;
    }

    /// <summary>
    /// Name of the token
    /// </summary>
    /// <value>Name of the token</value>
    /*
    <example>My first token</example>
    */
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// Expiration in days
    /// </summary>
    /// <value>Expiration in days</value>
    /*
    <example>30</example>
    */
    [JsonPropertyName("expires_in")]
    public int ExpiresIn { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class PersonalAccessTokenRequest {\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  ExpiresIn: ").Append(ExpiresIn).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }

    /// <summary>
    /// Returns the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public virtual string ToJson()
    {
        return JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
    }

    /// <summary>
    /// To validate all properties of the instance
    /// </summary>
    /// <param name="validationContext">Validation context</param>
    /// <returns>Validation Result</returns>
    IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
    {
        // ExpiresIn (int) maximum
        if (this.ExpiresIn > (int)365)
        {
            yield return new ValidationResult("Invalid value for ExpiresIn, must be a value less than or equal to 365.", new [] { "ExpiresIn" });
        }

        // ExpiresIn (int) minimum
        if (this.ExpiresIn < (int)1)
        {
            yield return new ValidationResult("Invalid value for ExpiresIn, must be a value greater than or equal to 1.", new [] { "ExpiresIn" });
        }

        yield break;
    }
}