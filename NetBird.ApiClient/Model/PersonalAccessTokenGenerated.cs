


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
/// PersonalAccessTokenGenerated
/// </summary>
[DataContract(Name = "PersonalAccessTokenGenerated")]
public class PersonalAccessTokenGenerated : IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PersonalAccessTokenGenerated" /> class.
    /// </summary>
    [JsonConstructor]
    protected PersonalAccessTokenGenerated() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="PersonalAccessTokenGenerated" /> class.
    /// </summary>
    /// <param name="plainToken">Plain text representation of the generated token (required).</param>
    /// <param name="personalAccessToken">personalAccessToken (required).</param>
    public PersonalAccessTokenGenerated(string plainToken = null, PersonalAccessToken personalAccessToken = null)
    {
        // to ensure "plainToken" is required (not null)
        ArgumentNullException.ThrowIfNull(plainToken);
        this.PlainToken = plainToken;
        // to ensure "personalAccessToken" is required (not null)
        ArgumentNullException.ThrowIfNull(personalAccessToken);
        this.PersonalAccessToken = personalAccessToken;
    }

    /// <summary>
    /// Plain text representation of the generated token
    /// </summary>
    /// <value>Plain text representation of the generated token</value>
    /*
    <example>2023-05-02T14:48:20.465+00:00</example>
    */
    [JsonPropertyName("plain_token")]
    public string PlainToken { get; set; }

    /// <summary>
    /// Gets or Sets PersonalAccessToken
    /// </summary>
    [JsonPropertyName("personal_access_token")]
    public PersonalAccessToken PersonalAccessToken { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class PersonalAccessTokenGenerated {\n");
        sb.Append("  PlainToken: ").Append(PlainToken).Append("\n");
        sb.Append("  PersonalAccessToken: ").Append(PersonalAccessToken).Append("\n");
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
        yield break;
    }
}