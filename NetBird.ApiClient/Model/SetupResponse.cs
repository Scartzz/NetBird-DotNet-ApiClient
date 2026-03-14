


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
/// Response after successful instance setup
/// </summary>
[DataContract(Name = "SetupResponse")]
public class SetupResponse : IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SetupResponse" /> class.
    /// </summary>
    [JsonConstructor]
    protected SetupResponse() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="SetupResponse" /> class.
    /// </summary>
    /// <param name="userId">The ID of the created user (required).</param>
    /// <param name="email">Email address of the created user (required).</param>
    public SetupResponse(string userId = null, string email = null)
    {
        // to ensure "userId" is required (not null)
        ArgumentNullException.ThrowIfNull(userId);
        this.UserId = userId;
        // to ensure "email" is required (not null)
        ArgumentNullException.ThrowIfNull(email);
        this.Email = email;
    }

    /// <summary>
    /// The ID of the created user
    /// </summary>
    /// <value>The ID of the created user</value>
    /*
    <example>abc123def456</example>
    */
    [JsonPropertyName("user_id")]
    public string UserId { get; set; }

    /// <summary>
    /// Email address of the created user
    /// </summary>
    /// <value>Email address of the created user</value>
    /*
    <example>admin@example.com</example>
    */
    [JsonPropertyName("email")]
    public string Email { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class SetupResponse {\n");
        sb.Append("  UserId: ").Append(UserId).Append("\n");
        sb.Append("  Email: ").Append(Email).Append("\n");
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