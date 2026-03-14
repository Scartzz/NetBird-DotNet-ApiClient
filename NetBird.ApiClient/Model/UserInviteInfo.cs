


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
/// Public information about an invite
/// </summary>
[DataContract(Name = "UserInviteInfo")]
public class UserInviteInfo : IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="UserInviteInfo" /> class.
    /// </summary>
    [JsonConstructor]
    protected UserInviteInfo() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="UserInviteInfo" /> class.
    /// </summary>
    /// <param name="email">User&#39;s email address (required).</param>
    /// <param name="name">User&#39;s full name (required).</param>
    /// <param name="expiresAt">Invite expiration time (required).</param>
    /// <param name="valid">Whether the invite is still valid (not expired) (required).</param>
    /// <param name="invitedBy">Name of the user who sent the invite (required).</param>
    public UserInviteInfo(string email = null, string name = null, DateTimeOffset expiresAt = default, bool valid = false, string invitedBy = null)
    {
        // to ensure "email" is required (not null)
        ArgumentNullException.ThrowIfNull(email);
        this.Email = email;
        // to ensure "name" is required (not null)
        ArgumentNullException.ThrowIfNull(name);
        this.Name = name;
        this.ExpiresAt = expiresAt;
        this.Valid = valid;
        // to ensure "invitedBy" is required (not null)
        ArgumentNullException.ThrowIfNull(invitedBy);
        this.InvitedBy = invitedBy;
    }

    /// <summary>
    /// User&#39;s email address
    /// </summary>
    /// <value>User&#39;s email address</value>
    /*
    <example>user@example.com</example>
    */
    [JsonPropertyName("email")]
    public string Email { get; set; }

    /// <summary>
    /// User&#39;s full name
    /// </summary>
    /// <value>User&#39;s full name</value>
    /*
    <example>John Doe</example>
    */
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// Invite expiration time
    /// </summary>
    /// <value>Invite expiration time</value>
    /*
    <example>2024-01-25T10:00:00Z</example>
    */
    [JsonPropertyName("expires_at")]
    public DateTimeOffset ExpiresAt { get; set; }

    /// <summary>
    /// Whether the invite is still valid (not expired)
    /// </summary>
    /// <value>Whether the invite is still valid (not expired)</value>
    /*
    <example>true</example>
    */
    [JsonPropertyName("valid")]
    public bool Valid { get; set; }

    /// <summary>
    /// Name of the user who sent the invite
    /// </summary>
    /// <value>Name of the user who sent the invite</value>
    /*
    <example>Admin User</example>
    */
    [JsonPropertyName("invited_by")]
    public string InvitedBy { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class UserInviteInfo {\n");
        sb.Append("  Email: ").Append(Email).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  ExpiresAt: ").Append(ExpiresAt).Append("\n");
        sb.Append("  Valid: ").Append(Valid).Append("\n");
        sb.Append("  InvitedBy: ").Append(InvitedBy).Append("\n");
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