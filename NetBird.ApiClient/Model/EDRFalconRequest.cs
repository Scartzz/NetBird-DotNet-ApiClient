


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
/// Request payload for creating or updating a EDR Falcon integration
/// </summary>
[DataContract(Name = "EDRFalconRequest")]
public class EDRFalconRequest : IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EDRFalconRequest" /> class.
    /// </summary>
    [JsonConstructor]
    protected EDRFalconRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="EDRFalconRequest" /> class.
    /// </summary>
    /// <param name="clientId">CrowdStrike API client ID (required).</param>
    /// <param name="secret">CrowdStrike API client secret (required).</param>
    /// <param name="cloudId">CrowdStrike cloud identifier (e.g., \&quot;us-1\&quot;, \&quot;us-2\&quot;, \&quot;eu-1\&quot;) (required).</param>
    /// <param name="groups">The Groups this integration applies to (required).</param>
    /// <param name="ztaScoreThreshold">The minimum Zero Trust Assessment score required for agent approval (0-100) (required).</param>
    /// <param name="enabled">Indicates whether the integration is enabled (default to true).</param>
    public EDRFalconRequest(string clientId = null, string secret = null, string cloudId = null, List<string> groups = null, int ztaScoreThreshold = 0, bool enabled = true)
    {
        // to ensure "clientId" is required (not null)
        ArgumentNullException.ThrowIfNull(clientId);
        this.ClientId = clientId;
        // to ensure "secret" is required (not null)
        ArgumentNullException.ThrowIfNull(secret);
        this.Secret = secret;
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
    /// CrowdStrike API client ID
    /// </summary>
    /// <value>CrowdStrike API client ID</value>
    [JsonPropertyName("client_id")]
    public string ClientId { get; set; }

    /// <summary>
    /// CrowdStrike API client secret
    /// </summary>
    /// <value>CrowdStrike API client secret</value>
    [JsonPropertyName("secret")]
    public string Secret { get; set; }

    /// <summary>
    /// CrowdStrike cloud identifier (e.g., \&quot;us-1\&quot;, \&quot;us-2\&quot;, \&quot;eu-1\&quot;)
    /// </summary>
    /// <value>CrowdStrike cloud identifier (e.g., \&quot;us-1\&quot;, \&quot;us-2\&quot;, \&quot;eu-1\&quot;)</value>
    [JsonPropertyName("cloud_id")]
    public string CloudId { get; set; }

    /// <summary>
    /// The Groups this integration applies to
    /// </summary>
    /// <value>The Groups this integration applies to</value>
    [JsonPropertyName("groups")]
    public List<string> Groups { get; set; }

    /// <summary>
    /// The minimum Zero Trust Assessment score required for agent approval (0-100)
    /// </summary>
    /// <value>The minimum Zero Trust Assessment score required for agent approval (0-100)</value>
    /*
    <example>75</example>
    */
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
        sb.Append("class EDRFalconRequest {\n");
        sb.Append("  ClientId: ").Append(ClientId).Append("\n");
        sb.Append("  Secret: ").Append(Secret).Append("\n");
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
        // ZtaScoreThreshold (int) maximum
        if (this.ZtaScoreThreshold > (int)100)
        {
            yield return new ValidationResult("Invalid value for ZtaScoreThreshold, must be a value less than or equal to 100.", new [] { "ZtaScoreThreshold" });
        }

        // ZtaScoreThreshold (int) minimum
        if (this.ZtaScoreThreshold < (int)0)
        {
            yield return new ValidationResult("Invalid value for ZtaScoreThreshold, must be a value greater than or equal to 0.", new [] { "ZtaScoreThreshold" });
        }

        yield break;
    }
}