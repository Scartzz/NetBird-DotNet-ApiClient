


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
/// Request payload for creating or updating a EDR SentinelOne integration
/// </summary>
[DataContract(Name = "EDRSentinelOneRequest")]
public class EDRSentinelOneRequest : IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EDRSentinelOneRequest" /> class.
    /// </summary>
    [JsonConstructor]
    protected EDRSentinelOneRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="EDRSentinelOneRequest" /> class.
    /// </summary>
    /// <param name="apiToken">SentinelOne API token (required).</param>
    /// <param name="apiUrl">The Base URL of SentinelOne API (required).</param>
    /// <param name="groups">The Groups this integrations applies to (required).</param>
    /// <param name="lastSyncedInterval">The devices last sync requirement interval in hours. Minimum value is 24 hours. (required).</param>
    /// <param name="enabled">Indicates whether the integration is enabled (default to true).</param>
    /// <param name="matchAttributes">matchAttributes (required).</param>
    public EDRSentinelOneRequest(string apiToken = null, string apiUrl = null, List<string> groups = null, int lastSyncedInterval = 0, bool enabled = true, SentinelOneMatchAttributes matchAttributes = null)
    {
        // to ensure "apiToken" is required (not null)
        ArgumentNullException.ThrowIfNull(apiToken);
        this.ApiToken = apiToken;
        // to ensure "apiUrl" is required (not null)
        ArgumentNullException.ThrowIfNull(apiUrl);
        this.ApiUrl = apiUrl;
        // to ensure "groups" is required (not null)
        ArgumentNullException.ThrowIfNull(groups);
        this.Groups = groups;
        this.LastSyncedInterval = lastSyncedInterval;
        // to ensure "matchAttributes" is required (not null)
        ArgumentNullException.ThrowIfNull(matchAttributes);
        this.MatchAttributes = matchAttributes;
        this.Enabled = enabled;
    }

    /// <summary>
    /// SentinelOne API token
    /// </summary>
    /// <value>SentinelOne API token</value>
    [JsonPropertyName("api_token")]
    public string ApiToken { get; set; }

    /// <summary>
    /// The Base URL of SentinelOne API
    /// </summary>
    /// <value>The Base URL of SentinelOne API</value>
    [JsonPropertyName("api_url")]
    public string ApiUrl { get; set; }

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
    /// Gets or Sets MatchAttributes
    /// </summary>
    [JsonPropertyName("match_attributes")]
    public SentinelOneMatchAttributes MatchAttributes { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class EDRSentinelOneRequest {\n");
        sb.Append("  ApiToken: ").Append(ApiToken).Append("\n");
        sb.Append("  ApiUrl: ").Append(ApiUrl).Append("\n");
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
        // LastSyncedInterval (int) minimum
        if (this.LastSyncedInterval < (int)24)
        {
            yield return new ValidationResult("Invalid value for LastSyncedInterval, must be a value greater than or equal to 24.", new [] { "LastSyncedInterval" });
        }

        yield break;
    }
}