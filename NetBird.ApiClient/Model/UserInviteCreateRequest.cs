


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
/// Request to create a user invite link
/// </summary>
[DataContract(Name = "UserInviteCreateRequest")]
public class UserInviteCreateRequest : IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="UserInviteCreateRequest" /> class.
    /// </summary>
    [JsonConstructor]
    protected UserInviteCreateRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="UserInviteCreateRequest" /> class.
    /// </summary>
    /// <param name="email">User&#39;s email address (required).</param>
    /// <param name="name">User&#39;s full name (required).</param>
    /// <param name="role">User&#39;s NetBird account role (required).</param>
    /// <param name="autoGroups">Group IDs to auto-assign to peers registered by this user (required).</param>
    /// <param name="expiresIn">Invite expiration time in seconds (default 72 hours).</param>
    public UserInviteCreateRequest(string email = null, string name = null, string role = null, List<string> autoGroups = null, int expiresIn = 0)
    {
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
        this.ExpiresIn = expiresIn;
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
    /// Invite expiration time in seconds (default 72 hours)
    /// </summary>
    /// <value>Invite expiration time in seconds (default 72 hours)</value>
    /*
    <example>259200</example>
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
        sb.Append("class UserInviteCreateRequest {\n");
        sb.Append("  Email: ").Append(Email).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Role: ").Append(Role).Append("\n");
        sb.Append("  AutoGroups: ").Append(AutoGroups).Append("\n");
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
        yield break;
    }
}