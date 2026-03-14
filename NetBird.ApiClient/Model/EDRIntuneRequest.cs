


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
/// Request payload for creating or updating a EDR Intune integration.
/// </summary>
[DataContract(Name = "EDRIntuneRequest")]
public class EDRIntuneRequest : IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EDRIntuneRequest" /> class.
    /// </summary>
    [JsonConstructor]
    protected EDRIntuneRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="EDRIntuneRequest" /> class.
    /// </summary>
    /// <param name="clientId">The Azure application client id (required).</param>
    /// <param name="tenantId">The Azure tenant id (required).</param>
    /// <param name="secret">The Azure application client secret (required).</param>
    /// <param name="groups">The Groups this integrations applies to (required).</param>
    /// <param name="lastSyncedInterval">The devices last sync requirement interval in hours. Minimum value is 24 hours. (required).</param>
    /// <param name="enabled">Indicates whether the integration is enabled (default to true).</param>
    public EDRIntuneRequest(string clientId = null, string tenantId = null, string secret = null, List<string> groups = null, int lastSyncedInterval = 0, bool enabled = true)
    {
        // to ensure "clientId" is required (not null)
        ArgumentNullException.ThrowIfNull(clientId);
        this.ClientId = clientId;
        // to ensure "tenantId" is required (not null)
        ArgumentNullException.ThrowIfNull(tenantId);
        this.TenantId = tenantId;
        // to ensure "secret" is required (not null)
        ArgumentNullException.ThrowIfNull(secret);
        this.Secret = secret;
        // to ensure "groups" is required (not null)
        ArgumentNullException.ThrowIfNull(groups);
        this.Groups = groups;
        this.LastSyncedInterval = lastSyncedInterval;
        this.Enabled = enabled;
    }

    /// <summary>
    /// The Azure application client id
    /// </summary>
    /// <value>The Azure application client id</value>
    [JsonPropertyName("client_id")]
    public string ClientId { get; set; }

    /// <summary>
    /// The Azure tenant id
    /// </summary>
    /// <value>The Azure tenant id</value>
    [JsonPropertyName("tenant_id")]
    public string TenantId { get; set; }

    /// <summary>
    /// The Azure application client secret
    /// </summary>
    /// <value>The Azure application client secret</value>
    [JsonPropertyName("secret")]
    public string Secret { get; set; }

    /// <summary>
    /// The Groups this integrations applies to
    /// </summary>
    /// <value>The Groups this integrations applies to</value>
    [JsonPropertyName("groups")]
    public List<string> Groups { get; set; }

    /// <summary>
    /// The devices last sync requirement interval in hours. Minimum value is 24 hours.
    /// </summary>
    /// <value>The devices last sync requirement interval in hours. Minimum value is 24 hours.</value>
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
        sb.Append("class EDRIntuneRequest {\n");
        sb.Append("  ClientId: ").Append(ClientId).Append("\n");
        sb.Append("  TenantId: ").Append(TenantId).Append("\n");
        sb.Append("  Secret: ").Append(Secret).Append("\n");
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
        // LastSyncedInterval (int) minimum
        if (this.LastSyncedInterval < (int)24)
        {
            yield return new ValidationResult("Invalid value for LastSyncedInterval, must be a value greater than or equal to 24.", new [] { "LastSyncedInterval" });
        }

        yield break;
    }
}