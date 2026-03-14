


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
/// Request to set up the initial admin user
/// </summary>
[DataContract(Name = "SetupRequest")]
public class SetupRequest : IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SetupRequest" /> class.
    /// </summary>
    [JsonConstructor]
    protected SetupRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="SetupRequest" /> class.
    /// </summary>
    /// <param name="email">Email address for the admin user (required).</param>
    /// <param name="password">Password for the admin user (minimum 8 characters) (required).</param>
    /// <param name="name">Display name for the admin user (defaults to email if not provided) (required).</param>
    public SetupRequest(string email = null, string password = null, string name = null)
    {
        // to ensure "email" is required (not null)
        ArgumentNullException.ThrowIfNull(email);
        this.Email = email;
        // to ensure "password" is required (not null)
        ArgumentNullException.ThrowIfNull(password);
        this.Password = password;
        // to ensure "name" is required (not null)
        ArgumentNullException.ThrowIfNull(name);
        this.Name = name;
    }

    /// <summary>
    /// Email address for the admin user
    /// </summary>
    /// <value>Email address for the admin user</value>
    /*
    <example>admin@example.com</example>
    */
    [JsonPropertyName("email")]
    public string Email { get; set; }

    /// <summary>
    /// Password for the admin user (minimum 8 characters)
    /// </summary>
    /// <value>Password for the admin user (minimum 8 characters)</value>
    /*
    <example>securepassword123</example>
    */
    [JsonPropertyName("password")]
    public string Password { get; set; }

    /// <summary>
    /// Display name for the admin user (defaults to email if not provided)
    /// </summary>
    /// <value>Display name for the admin user (defaults to email if not provided)</value>
    /*
    <example>Admin User</example>
    */
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class SetupRequest {\n");
        sb.Append("  Email: ").Append(Email).Append("\n");
        sb.Append("  Password: ").Append(Password).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
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
        // Password (string) minLength
        if (this.Password is not null && this.Password.Length < 8)
        {
            yield return new ValidationResult("Invalid value for Password, length must be greater than 8.", new [] { "Password" });
        }

        yield break;
    }
}