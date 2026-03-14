


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
/// PasswordAuthConfig
/// </summary>
[DataContract(Name = "PasswordAuthConfig")]
public class PasswordAuthConfig : IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PasswordAuthConfig" /> class.
    /// </summary>
    [JsonConstructor]
    protected PasswordAuthConfig() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="PasswordAuthConfig" /> class.
    /// </summary>
    /// <param name="enabled">Whether password auth is enabled (required).</param>
    /// <param name="password">Auth password (required).</param>
    public PasswordAuthConfig(bool enabled = false, string password = null)
    {
        this.Enabled = enabled;
        // to ensure "password" is required (not null)
        ArgumentNullException.ThrowIfNull(password);
        this.Password = password;
    }

    /// <summary>
    /// Whether password auth is enabled
    /// </summary>
    /// <value>Whether password auth is enabled</value>
    [JsonPropertyName("enabled")]
    public bool Enabled { get; set; }

    /// <summary>
    /// Auth password
    /// </summary>
    /// <value>Auth password</value>
    [JsonPropertyName("password")]
    public string Password { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class PasswordAuthConfig {\n");
        sb.Append("  Enabled: ").Append(Enabled).Append("\n");
        sb.Append("  Password: ").Append(Password).Append("\n");
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