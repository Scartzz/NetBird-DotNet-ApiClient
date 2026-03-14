


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
/// A user invite
/// </summary>
[DataContract(Name = "UserInvite")]
public class UserInvite : IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="UserInvite" /> class.
    /// </summary>
    [JsonConstructor]
    protected UserInvite() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="UserInvite" /> class.
    /// </summary>
    /// <param name="id">Invite ID (required).</param>
    /// <param name="email">User&#39;s email address (required).</param>
    /// <param name="name">User&#39;s full name (required).</param>
    /// <param name="role">User&#39;s NetBird account role (required).</param>
    /// <param name="autoGroups">Group IDs to auto-assign to peers registered by this user (required).</param>
    /// <param name="expiresAt">Invite expiration time (required).</param>
    /// <param name="createdAt">Invite creation time (required).</param>
    /// <param name="expired">Whether the invite has expired (required).</param>
    /// <param name="inviteToken">The invite link to be shared with the user. Only returned when the invite is created or regenerated..</param>
    public UserInvite(string id = null, string email = null, string name = null, string role = null, List<string> autoGroups = null, DateTimeOffset expiresAt = default, DateTimeOffset createdAt = default, bool expired = false, string inviteToken = null)
    {
        // to ensure "id" is required (not null)
        ArgumentNullException.ThrowIfNull(id);
        this.Id = id;
        // to ensure "email" is required (not null)
        ArgumentNullException.ThrowIfNull(email);
        this.Email = email;
        // to ensure "name" is required (not null)
        ArgumentNullException.ThrowIfNull(name);
        this.Name = name;
        // to ensure "role" is required (not null)
        ArgumentNullException.ThrowIfNull(role);
        this.Role = role;
        // to ensure "autoGroups" is required (not null)
        ArgumentNullException.ThrowIfNull(autoGroups);
        this.AutoGroups = autoGroups;
        this.ExpiresAt = expiresAt;
        this.CreatedAt = createdAt;
        this.Expired = expired;
        this.InviteToken = inviteToken;
    }

    /// <summary>
    /// Invite ID
    /// </summary>
    /// <value>Invite ID</value>
    /*
    <example>d5p7eedra0h0lt6f59hg</example>
    */
    [JsonPropertyName("id")]
    public string Id { get; set; }

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
    /// User&#39;s NetBird account role
    /// </summary>
    /// <value>User&#39;s NetBird account role</value>
    /*
    <example>user</example>
    */
    [JsonPropertyName("role")]
    public string Role { get; set; }

    /// <summary>
    /// Group IDs to auto-assign to peers registered by this user
    /// </summary>
    /// <value>Group IDs to auto-assign to peers registered by this user</value>
    [JsonPropertyName("auto_groups")]
    public List<string> AutoGroups { get; set; }

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
    /// Invite creation time
    /// </summary>
    /// <value>Invite creation time</value>
    /*
    <example>2024-01-22T10:00:00Z</example>
    */
    [JsonPropertyName("created_at")]
    public DateTimeOffset CreatedAt { get; set; }

    /// <summary>
    /// Whether the invite has expired
    /// </summary>
    /// <value>Whether the invite has expired</value>
    /*
    <example>false</example>
    */
    [JsonPropertyName("expired")]
    public bool Expired { get; set; }

    /// <summary>
    /// The invite link to be shared with the user. Only returned when the invite is created or regenerated.
    /// </summary>
    /// <value>The invite link to be shared with the user. Only returned when the invite is created or regenerated.</value>
    /*
    <example>nbi_Xk5Lz9mP2vQwRtYu1aN3bC4dE5fGh0ABC123</example>
    */
    [JsonPropertyName("invite_token")]
    public string InviteToken { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class UserInvite {\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Email: ").Append(Email).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Role: ").Append(Role).Append("\n");
        sb.Append("  AutoGroups: ").Append(AutoGroups).Append("\n");
        sb.Append("  ExpiresAt: ").Append(ExpiresAt).Append("\n");
        sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
        sb.Append("  Expired: ").Append(Expired).Append("\n");
        sb.Append("  InviteToken: ").Append(InviteToken).Append("\n");
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