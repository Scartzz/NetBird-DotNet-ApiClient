


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
/// Represents a Intune EDR integration configuration
/// </summary>
[DataContract(Name = "EDRIntuneResponse")]
public class EDRIntuneResponse : IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EDRIntuneResponse" /> class.
    /// </summary>
    [JsonConstructor]
    protected EDRIntuneResponse() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="EDRIntuneResponse" /> class.
    /// </summary>
    /// <param name="id">The unique numeric identifier for the integration. (required).</param>
    /// <param name="accountId">The identifier of the account this integration belongs to. (required).</param>
    /// <param name="lastSyncedAt">Timestamp of when the integration was last synced. (required).</param>
    /// <param name="createdBy">The user id that created the integration (required).</param>
    /// <param name="createdAt">Timestamp of when the integration was created. (required).</param>
    /// <param name="updatedAt">Timestamp of when the integration was last updated. (required).</param>
    /// <param name="clientId">The Azure application client id (required).</param>
    /// <param name="tenantId">The Azure tenant id (required).</param>
    /// <param name="groups">List of groups (required).</param>
    /// <param name="lastSyncedInterval">The devices last sync requirement interval in hours. (required).</param>
    /// <param name="enabled">Indicates whether the integration is enabled (required).</param>
    public EDRIntuneResponse(long id = 0, string accountId = null, DateTimeOffset lastSyncedAt = default, string createdBy = null, DateTimeOffset createdAt = default, DateTimeOffset updatedAt = default, string clientId = null, string tenantId = null, List<Group> groups = null, int lastSyncedInterval = 0, bool enabled = false)
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
        // to ensure "clientId" is required (not null)
        ArgumentNullException.ThrowIfNull(clientId);
        this.ClientId = clientId;
        // to ensure "tenantId" is required (not null)
        ArgumentNullException.ThrowIfNull(tenantId);
        this.TenantId = tenantId;
        // to ensure "groups" is required (not null)
        ArgumentNullException.ThrowIfNull(groups);
        this.Groups = groups;
        this.LastSyncedInterval = lastSyncedInterval;
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
    <example>acc_abcdef123456</example>
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
    /// The Azure application client id
    /// </summary>
    /// <value>The Azure application client id</value>
    /*
    <example>acc_abcdef123456</example>
    */
    [JsonPropertyName("client_id")]
    public string ClientId { get; set; }

    /// <summary>
    /// The Azure tenant id
    /// </summary>
    /// <value>The Azure tenant id</value>
    /*
    <example>acc_abcdef123456</example>
    */
    [JsonPropertyName("tenant_id")]
    public string TenantId { get; set; }

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
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class EDRIntuneResponse {\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  AccountId: ").Append(AccountId).Append("\n");
        sb.Append("  LastSyncedAt: ").Append(LastSyncedAt).Append("\n");
        sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
        sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
        sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
        sb.Append("  ClientId: ").Append(ClientId).Append("\n");
        sb.Append("  TenantId: ").Append(TenantId).Append("\n");
        sb.Append("  Groups: ").Append(Groups).Append("\n");
        sb.Append("  LastSyncedInterval: ").Append(LastSyncedInterval).Append("\n");
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
        // Id (long) minimum
        if (this.Id < (long)0)
        {
            yield return new ValidationResult("Invalid value for Id, must be a value greater than or equal to 0.", new [] { "Id" });
        }

        yield break;
    }
}