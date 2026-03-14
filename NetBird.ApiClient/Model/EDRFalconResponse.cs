


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
/// Represents a Falcon EDR integration
/// </summary>
[DataContract(Name = "EDRFalconResponse")]
public class EDRFalconResponse : IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EDRFalconResponse" /> class.
    /// </summary>
    [JsonConstructor]
    protected EDRFalconResponse() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="EDRFalconResponse" /> class.
    /// </summary>
    /// <param name="id">The unique numeric identifier for the integration. (required).</param>
    /// <param name="accountId">The identifier of the account this integration belongs to. (required).</param>
    /// <param name="lastSyncedAt">Timestamp of when the integration was last synced. (required).</param>
    /// <param name="createdBy">The user id that created the integration (required).</param>
    /// <param name="createdAt">Timestamp of when the integration was created. (required).</param>
    /// <param name="updatedAt">Timestamp of when the integration was last updated. (required).</param>
    /// <param name="cloudId">CrowdStrike cloud identifier (required).</param>
    /// <param name="groups">List of groups (required).</param>
    /// <param name="ztaScoreThreshold">The minimum Zero Trust Assessment score required for agent approval (0-100) (required).</param>
    /// <param name="enabled">Indicates whether the integration is enabled (required).</param>
    public EDRFalconResponse(long id = 0, string accountId = null, DateTimeOffset lastSyncedAt = default, string createdBy = null, DateTimeOffset createdAt = default, DateTimeOffset updatedAt = default, string cloudId = null, List<Group> groups = null, int ztaScoreThreshold = 0, bool enabled = false)
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
        // to ensure "cloudId" is required (not null)
        ArgumentNullException.ThrowIfNull(cloudId);
        this.CloudId = cloudId;
        // to ensure "groups" is required (not null)
        ArgumentNullException.ThrowIfNull(groups);
        this.Groups = groups;
        this.ZtaScoreThreshold = ztaScoreThreshold;
        this.Enabled = enabled;
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
    /// CrowdStrike cloud identifier
    /// </summary>
    /// <value>CrowdStrike cloud identifier</value>
    [JsonPropertyName("cloud_id")]
    public string CloudId { get; set; }

    /// <summary>
    /// List of groups
    /// </summary>
    /// <value>List of groups</value>
    [JsonPropertyName("groups")]
    public List<Group> Groups { get; set; }

    /// <summary>
    /// The minimum Zero Trust Assessment score required for agent approval (0-100)
    /// </summary>
    /// <value>The minimum Zero Trust Assessment score required for agent approval (0-100)</value>
    [JsonPropertyName("zta_score_threshold")]
    public int ZtaScoreThreshold { get; set; }

    /// <summary>
    /// Indicates whether the integration is enabled
    /// </summary>
    /// <value>Indicates whether the integration is enabled</value>
    [JsonPropertyName("enabled")]
    public bool Enabled { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class EDRFalconResponse {\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  AccountId: ").Append(AccountId).Append("\n");
        sb.Append("  LastSyncedAt: ").Append(LastSyncedAt).Append("\n");
        sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
        sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
        sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
        sb.Append("  CloudId: ").Append(CloudId).Append("\n");
        sb.Append("  Groups: ").Append(Groups).Append("\n");
        sb.Append("  ZtaScoreThreshold: ").Append(ZtaScoreThreshold).Append("\n");
        sb.Append("  Enabled: ").Append(Enabled).Append("\n");
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