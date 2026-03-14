


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
/// PasswordChangeRequest
/// </summary>
[DataContract(Name = "PasswordChangeRequest")]
public class PasswordChangeRequest : IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PasswordChangeRequest" /> class.
    /// </summary>
    [JsonConstructor]
    protected PasswordChangeRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="PasswordChangeRequest" /> class.
    /// </summary>
    /// <param name="oldPassword">The current password (required).</param>
    /// <param name="newPassword">The new password to set (required).</param>
    public PasswordChangeRequest(string oldPassword = null, string newPassword = null)
    {
        // to ensure "oldPassword" is required (not null)
        ArgumentNullException.ThrowIfNull(oldPassword);
        this.OldPassword = oldPassword;
        // to ensure "newPassword" is required (not null)
        ArgumentNullException.ThrowIfNull(newPassword);
        this.NewPassword = newPassword;
    }

    /// <summary>
    /// The current password
    /// </summary>
    /// <value>The current password</value>
    /*
    <example>currentPassword123</example>
    */
    [JsonPropertyName("old_password")]
    public string OldPassword { get; set; }

    /// <summary>
    /// The new password to set
    /// </summary>
    /// <value>The new password to set</value>
    /*
    <example>newSecurePassword456</example>
    */
    [JsonPropertyName("new_password")]
    public string NewPassword { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class PasswordChangeRequest {\n");
        sb.Append("  OldPassword: ").Append(OldPassword).Append("\n");
        sb.Append("  NewPassword: ").Append(NewPassword).Append("\n");
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