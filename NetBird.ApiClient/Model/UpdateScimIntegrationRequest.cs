


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
/// Request payload for updating an SCIM IDP integration
/// </summary>
[DataContract(Name = "UpdateScimIntegrationRequest")]
public class UpdateScimIntegrationRequest : IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="UpdateScimIntegrationRequest" /> class.
    /// </summary>
    /// <param name="enabled">Indicates whether the integration is enabled.</param>
    /// <param name="groupPrefixes">List of start_with string patterns for groups to sync.</param>
    /// <param name="userGroupPrefixes">List of start_with string patterns for groups which users to sync.</param>
    public UpdateScimIntegrationRequest(bool enabled = false, List<string> groupPrefixes = null, List<string> userGroupPrefixes = null)
    {
        this.Enabled = enabled;
        this.GroupPrefixes = groupPrefixes;
        this.UserGroupPrefixes = userGroupPrefixes;
    }

    /// <summary>
    /// Indicates whether the integration is enabled
    /// </summary>
    /// <value>Indicates whether the integration is enabled</value>
    /*
    <example>true</example>
    */
    [JsonPropertyName("enabled")]
    public bool Enabled { get; set; }

    /// <summary>
    /// List of start_with string patterns for groups to sync
    /// </summary>
    /// <value>List of start_with string patterns for groups to sync</value>
    /*
    <example>[Engineering, Sales]</example>
    */
    [JsonPropertyName("group_prefixes")]
    public List<string> GroupPrefixes { get; set; }

    /// <summary>
    /// List of start_with string patterns for groups which users to sync
    /// </summary>
    /// <value>List of start_with string patterns for groups which users to sync</value>
    /*
    <example>[Users]</example>
    */
    [JsonPropertyName("user_group_prefixes")]
    public List<string> UserGroupPrefixes { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class UpdateScimIntegrationRequest {\n");
        sb.Append("  Enabled: ").Append(Enabled).Append("\n");
        sb.Append("  GroupPrefixes: ").Append(GroupPrefixes).Append("\n");
        sb.Append("  UserGroupPrefixes: ").Append(UserGroupPrefixes).Append("\n");
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