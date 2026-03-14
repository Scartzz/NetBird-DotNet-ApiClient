


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
/// Represents a SCIM IDP integration
/// </summary>
[DataContract(Name = "ScimIntegration")]
public class ScimIntegration : IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ScimIntegration" /> class.
    /// </summary>
    [JsonConstructor]
    protected ScimIntegration() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ScimIntegration" /> class.
    /// </summary>
    /// <param name="id">The unique identifier for the integration (required).</param>
    /// <param name="enabled">Indicates whether the integration is enabled (required).</param>
    /// <param name="provider">Name of the SCIM identity provider (required).</param>
    /// <param name="groupPrefixes">List of start_with string patterns for groups to sync (required).</param>
    /// <param name="userGroupPrefixes">List of start_with string patterns for groups which users to sync (required).</param>
    /// <param name="authToken">SCIM API token (full on creation, masked otherwise) (required).</param>
    /// <param name="lastSyncedAt">Timestamp of when the integration was last synced (required).</param>
    public ScimIntegration(long id = 0, bool enabled = false, string provider = null, List<string> groupPrefixes = null, List<string> userGroupPrefixes = null, string authToken = null, DateTimeOffset lastSyncedAt = default)
    {
        this.Id = id;
        this.Enabled = enabled;
        // to ensure "provider" is required (not null)
        ArgumentNullException.ThrowIfNull(provider);
        this.Provider = provider;
        // to ensure "groupPrefixes" is required (not null)
        ArgumentNullException.ThrowIfNull(groupPrefixes);
        this.GroupPrefixes = groupPrefixes;
        // to ensure "userGroupPrefixes" is required (not null)
        ArgumentNullException.ThrowIfNull(userGroupPrefixes);
        this.UserGroupPrefixes = userGroupPrefixes;
        // to ensure "authToken" is required (not null)
        ArgumentNullException.ThrowIfNull(authToken);
        this.AuthToken = authToken;
        this.LastSyncedAt = lastSyncedAt;
    }

    /// <summary>
    /// The unique identifier for the integration
    /// </summary>
    /// <value>The unique identifier for the integration</value>
    /*
    <example>123</example>
    */
    [JsonPropertyName("id")]
    public long Id { get; set; }

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
    /// Name of the SCIM identity provider
    /// </summary>
    /// <value>Name of the SCIM identity provider</value>
    [JsonPropertyName("provider")]
    public string Provider { get; set; }

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
    /// SCIM API token (full on creation, masked otherwise)
    /// </summary>
    /// <value>SCIM API token (full on creation, masked otherwise)</value>
    /*
    <example>nbs_abc***********************************</example>
    */
    [JsonPropertyName("auth_token")]
    public string AuthToken { get; set; }

    /// <summary>
    /// Timestamp of when the integration was last synced
    /// </summary>
    /// <value>Timestamp of when the integration was last synced</value>
    /*
    <example>2023-05-15T10:30:00Z</example>
    */
    [JsonPropertyName("last_synced_at")]
    public DateTimeOffset LastSyncedAt { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class ScimIntegration {\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Enabled: ").Append(Enabled).Append("\n");
        sb.Append("  Provider: ").Append(Provider).Append("\n");
        sb.Append("  GroupPrefixes: ").Append(GroupPrefixes).Append("\n");
        sb.Append("  UserGroupPrefixes: ").Append(UserGroupPrefixes).Append("\n");
        sb.Append("  AuthToken: ").Append(AuthToken).Append("\n");
        sb.Append("  LastSyncedAt: ").Append(LastSyncedAt).Append("\n");
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