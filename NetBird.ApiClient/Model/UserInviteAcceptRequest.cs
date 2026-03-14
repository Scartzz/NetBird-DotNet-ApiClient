


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
/// Request to accept an invite and set password
/// </summary>
[DataContract(Name = "UserInviteAcceptRequest")]
public class UserInviteAcceptRequest : IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="UserInviteAcceptRequest" /> class.
    /// </summary>
    [JsonConstructor]
    protected UserInviteAcceptRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="UserInviteAcceptRequest" /> class.
    /// </summary>
    /// <param name="password">The password the user wants to set. Must be at least 8 characters long and contain at least one uppercase letter, one digit, and one special character (any character that is not a letter or digit, including spaces). (required).</param>
    public UserInviteAcceptRequest(string password = null)
    {
        // to ensure "password" is required (not null)
        ArgumentNullException.ThrowIfNull(password);
        this.Password = password;
    }

    /// <summary>
    /// The password the user wants to set. Must be at least 8 characters long and contain at least one uppercase letter, one digit, and one special character (any character that is not a letter or digit, including spaces).
    /// </summary>
    /// <value>The password the user wants to set. Must be at least 8 characters long and contain at least one uppercase letter, one digit, and one special character (any character that is not a letter or digit, including spaces).</value>
    /*
    <example>SecurePass123!</example>
    */
    [JsonPropertyName("password")]
    public string Password { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class UserInviteAcceptRequest {\n");
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
        // Password (string) minLength
        if (this.Password is not null && this.Password.Length < 8)
        {
            yield return new ValidationResult("Invalid value for Password, length must be greater than 8.", new [] { "Password" });
        }

        if (this.Password is not null) {
            // Password (string) pattern
            Regex regexPassword = new Regex(@"^(?=.*[0-9])(?=.*[A-Z])(?=.*[^a-zA-Z0-9]).{8,}$", RegexOptions.CultureInvariant);
            if (!regexPassword.Match(this.Password).Success)
            {
                yield return new ValidationResult("Invalid value for Password, must match a pattern of " + regexPassword, new [] { "Password" });
            }
        }

        yield break;
    }
}