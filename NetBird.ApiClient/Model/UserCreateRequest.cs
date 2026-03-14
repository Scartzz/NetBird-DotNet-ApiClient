


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
/// UserCreateRequest
/// </summary>
[DataContract(Name = "UserCreateRequest")]
public class UserCreateRequest : IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="UserCreateRequest" /> class.
    /// </summary>
    [JsonConstructor]
    protected UserCreateRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="UserCreateRequest" /> class.
    /// </summary>
    /// <param name="email">User&#39;s Email to send invite to.</param>
    /// <param name="name">User&#39;s full name.</param>
    /// <param name="role">User&#39;s NetBird account role (required).</param>
    /// <param name="autoGroups">Group IDs to auto-assign to peers registered by this user (required).</param>
    /// <param name="isServiceUser">Is true if this user is a service user (required).</param>
    public UserCreateRequest(string email = null, string name = null, string role = null, List<string> autoGroups = null, bool isServiceUser = false)
    {
        // to ensure "role" is required (not null)
        ArgumentNullException.ThrowIfNull(role);
        this.Role = role;
        // to ensure "autoGroups" is required (not null)
        ArgumentNullException.ThrowIfNull(autoGroups);
        this.AutoGroups = autoGroups;
        this.IsServiceUser = isServiceUser;
        this.Email = email;
        this.Name = name;
    }

    /// <summary>
    /// User&#39;s Email to send invite to
    /// </summary>
    /// <value>User&#39;s Email to send invite to</value>
    /*
    <example>demo@netbird.io</example>
    */
    [JsonPropertyName("email")]
    public string Email { get; set; }

    /// <summary>
    /// User&#39;s full name
    /// </summary>
    /// <value>User&#39;s full name</value>
    /*
    <example>Tom Schulz</example>
    */
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// User&#39;s NetBird account role
    /// </summary>
    /// <value>User&#39;s NetBird account role</value>
    /*
    <example>admin</example>
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
    /// Is true if this user is a service user
    /// </summary>
    /// <value>Is true if this user is a service user</value>
    /*
    <example>false</example>
    */
    [JsonPropertyName("is_service_user")]
    public bool IsServiceUser { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class UserCreateRequest {\n");
        sb.Append("  Email: ").Append(Email).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Role: ").Append(Role).Append("\n");
        sb.Append("  AutoGroups: ").Append(AutoGroups).Append("\n");
        sb.Append("  IsServiceUser: ").Append(IsServiceUser).Append("\n");
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