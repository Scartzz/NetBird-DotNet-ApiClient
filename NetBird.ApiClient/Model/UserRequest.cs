


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
/// UserRequest
/// </summary>
[DataContract(Name = "UserRequest")]
public class UserRequest : IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="UserRequest" /> class.
    /// </summary>
    [JsonConstructor]
    protected UserRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="UserRequest" /> class.
    /// </summary>
    /// <param name="role">User&#39;s NetBird account role (required).</param>
    /// <param name="autoGroups">Group IDs to auto-assign to peers registered by this user (required).</param>
    /// <param name="isBlocked">If set to true then user is blocked and can&#39;t use the system (required).</param>
    public UserRequest(string role = null, List<string> autoGroups = null, bool isBlocked = false)
    {
        // to ensure "role" is required (not null)
        ArgumentNullException.ThrowIfNull(role);
        this.Role = role;
        // to ensure "autoGroups" is required (not null)
        ArgumentNullException.ThrowIfNull(autoGroups);
        this.AutoGroups = autoGroups;
        this.IsBlocked = isBlocked;
    }

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
    /// If set to true then user is blocked and can&#39;t use the system
    /// </summary>
    /// <value>If set to true then user is blocked and can&#39;t use the system</value>
    /*
    <example>false</example>
    */
    [JsonPropertyName("is_blocked")]
    public bool IsBlocked { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class UserRequest {\n");
        sb.Append("  Role: ").Append(Role).Append("\n");
        sb.Append("  AutoGroups: ").Append(AutoGroups).Append("\n");
        sb.Append("  IsBlocked: ").Append(IsBlocked).Append("\n");
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