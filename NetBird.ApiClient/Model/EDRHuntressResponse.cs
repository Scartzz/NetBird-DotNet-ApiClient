


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
/// Represents a Huntress EDR integration configuration
/// </summary>
[DataContract(Name = "EDRHuntressResponse")]
public class EDRHuntressResponse : IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EDRHuntressResponse" /> class.
    /// </summary>
    [JsonConstructor]
    protected EDRHuntressResponse() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="EDRHuntressResponse" /> class.
    /// </summary>
    /// <param name="id">The unique numeric identifier for the integration. (required).</param>
    /// <param name="accountId">The identifier of the account this integration belongs to. (required).</param>
    /// <param name="lastSyncedAt">Timestamp of when the integration was last synced. (required).</param>
    /// <param name="createdBy">The user id that created the integration (required).</param>
    /// <param name="createdAt">Timestamp of when the integration was created. (required).</param>
    /// <param name="updatedAt">Timestamp of when the integration was last updated. (required).</param>
    /// <param name="groups">List of groups (required).</param>
    /// <param name="lastSyncedInterval">The devices last sync requirement interval in hours. (required).</param>
    /// <param name="enabled">Indicates whether the integration is enabled (required) (default to true).</param>
    /// <param name="matchAttributes">matchAttributes (required).</param>
    public EDRHuntressResponse(long id = 0, string accountId = null, DateTimeOffset lastSyncedAt = default, string createdBy = null, DateTimeOffset createdAt = default, DateTimeOffset updatedAt = default, List<Group> groups = null, int lastSyncedInterval = 0, bool enabled = true, HuntressMatchAttributes matchAttributes = null)
    {
        this.Id = id;
        // to ensure "accountId" is required (not null)
        ArgumentNullException.ThrowIfNull(accountId);
        this.AccountId = accountId;
        this.LastSyncedAt = lastSyncedAt;
        // to ensure "createdBy" is required (not null)
        ArgumentNullException.ThrowIfNull(createdBy);
        this.CreatedBy = createdBy;
        this.CreatedAt = createdAt;
        this.UpdatedAt = updatedAt;
        // to ensure "groups" is required (not null)
        ArgumentNullException.ThrowIfNull(groups);
        this.Groups = groups;
        this.LastSyncedInterval = lastSyncedInterval;
        this.Enabled = enabled;
        // to ensure "matchAttributes" is required (not null)
        ArgumentNullException.ThrowIfNull(matchAttributes);
        this.MatchAttributes = matchAttributes;
    }

    /// <summary>
    /// The unique numeric identifier for the integration.
    /// </summary>
    /// <value>The unique numeric identifier for the integration.</value>
    /*
    <example>123</example>
    */
    [JsonPropertyName("id")]
    public long Id { get; set; }

    /// <summary>
    /// The identifier of the account this integration belongs to.
    /// </summary>
    /// <value>The identifier of the account this integration belongs to.</value>
    /*
    <example>ch8i4ug6lnn4g9hqv7l0</example>
    */
    [JsonPropertyName("account_id")]
    public string AccountId { get; set; }

    /// <summary>
    /// Timestamp of when the integration was last synced.
    /// </summary>
    /// <value>Timestamp of when the integration was last synced.</value>
    /*
    <example>2023-05-15T10:30:00Z</example>
    */
    [JsonPropertyName("last_synced_at")]
    public DateTimeOffset LastSyncedAt { get; set; }

    /// <summary>
    /// The user id that created the integration
    /// </summary>
    /// <value>The user id that created the integration</value>
    [JsonPropertyName("created_by")]
    public string CreatedBy { get; set; }

    /// <summary>
    /// Timestamp of when the integration was created.
    /// </summary>
    /// <value>Timestamp of when the integration was created.</value>
    /*
    <example>2023-05-15T10:30:00Z</example>
    */
    [JsonPropertyName("created_at")]
    public DateTimeOffset CreatedAt { get; set; }

    /// <summary>
    /// Timestamp of when the integration was last updated.
    /// </summary>
    /// <value>Timestamp of when the integration was last updated.</value>
    /*
    <example>2023-05-16T11:45:00Z</example>
    */
    [JsonPropertyName("updated_at")]
    public DateTimeOffset UpdatedAt { get; set; }

    /// <summary>
    /// List of groups
    /// </summary>
    /// <value>List of groups</value>
    [JsonPropertyName("groups")]
    public List<Group> Groups { get; set; }

    /// <summary>
    /// The devices last sync requirement interval in hours.
    /// </summary>
    /// <value>The devices last sync requirement interval in hours.</value>
    [JsonPropertyName("last_synced_interval")]
    public int LastSyncedInterval { get; set; }

    /// <summary>
    /// Indicates whether the integration is enabled
    /// </summary>
    /// <value>Indicates whether the integration is enabled</value>
    [JsonPropertyName("enabled")]
    public bool Enabled { get; set; }

    /// <summary>
    /// Gets or Sets MatchAttributes
    /// </summary>
    [JsonPropertyName("match_attributes")]
    public HuntressMatchAttributes MatchAttributes { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class EDRHuntressResponse {\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  AccountId: ").Append(AccountId).Append("\n");
        sb.Append("  LastSyncedAt: ").Append(LastSyncedAt).Append("\n");
        sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
        sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
        sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
        sb.Append("  Groups: ").Append(Groups).Append("\n");
        sb.Append("  LastSyncedInterval: ").Append(LastSyncedInterval).Append("\n");
        sb.Append("  Enabled: ").Append(Enabled).Append("\n");
        sb.Append("  MatchAttributes: ").Append(MatchAttributes).Append("\n");
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