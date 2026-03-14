


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
/// NetworkRouter
/// </summary>
[DataContract(Name = "NetworkRouter")]
public class NetworkRouter : IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="NetworkRouter" /> class.
    /// </summary>
    [JsonConstructor]
    protected NetworkRouter() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="NetworkRouter" /> class.
    /// </summary>
    /// <param name="peer">Peer Identifier associated with route. This property can not be set together with &#x60;peer_groups&#x60;.</param>
    /// <param name="peerGroups">Peers Group Identifier associated with route. This property can not be set together with &#x60;peer&#x60;.</param>
    /// <param name="metric">Route metric number. Lowest number has higher priority (required).</param>
    /// <param name="masquerade">Indicate if peer should masquerade traffic to this route&#39;s prefix (required).</param>
    /// <param name="enabled">Network router status (required).</param>
    /// <param name="id">Network Router Id (required).</param>
    public NetworkRouter(string peer = null, List<string> peerGroups = null, int metric = 0, bool masquerade = false, bool enabled = false, string id = null)
    {
        this.Metric = metric;
        this.Masquerade = masquerade;
        this.Enabled = enabled;
        // to ensure "id" is required (not null)
        ArgumentNullException.ThrowIfNull(id);
        this.Id = id;
        this.Peer = peer;
        this.PeerGroups = peerGroups;
    }

    /// <summary>
    /// Peer Identifier associated with route. This property can not be set together with &#x60;peer_groups&#x60;
    /// </summary>
    /// <value>Peer Identifier associated with route. This property can not be set together with &#x60;peer_groups&#x60;</value>
    /*
    <example>chacbco6lnnbn6cg5s91</example>
    */
    [JsonPropertyName("peer")]
    public string Peer { get; set; }

    /// <summary>
    /// Peers Group Identifier associated with route. This property can not be set together with &#x60;peer&#x60;
    /// </summary>
    /// <value>Peers Group Identifier associated with route. This property can not be set together with &#x60;peer&#x60;</value>
    [JsonPropertyName("peer_groups")]
    public List<string> PeerGroups { get; set; }

    /// <summary>
    /// Route metric number. Lowest number has higher priority
    /// </summary>
    /// <value>Route metric number. Lowest number has higher priority</value>
    /*
    <example>9999</example>
    */
    [JsonPropertyName("metric")]
    public int Metric { get; set; }

    /// <summary>
    /// Indicate if peer should masquerade traffic to this route&#39;s prefix
    /// </summary>
    /// <value>Indicate if peer should masquerade traffic to this route&#39;s prefix</value>
    /*
    <example>true</example>
    */
    [JsonPropertyName("masquerade")]
    public bool Masquerade { get; set; }

    /// <summary>
    /// Network router status
    /// </summary>
    /// <value>Network router status</value>
    /*
    <example>true</example>
    */
    [JsonPropertyName("enabled")]
    public bool Enabled { get; set; }

    /// <summary>
    /// Network Router Id
    /// </summary>
    /// <value>Network Router Id</value>
    /*
    <example>chacdk86lnnboviihd7g</example>
    */
    [JsonPropertyName("id")]
    public string Id { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class NetworkRouter {\n");
        sb.Append("  Peer: ").Append(Peer).Append("\n");
        sb.Append("  PeerGroups: ").Append(PeerGroups).Append("\n");
        sb.Append("  Metric: ").Append(Metric).Append("\n");
        sb.Append("  Masquerade: ").Append(Masquerade).Append("\n");
        sb.Append("  Enabled: ").Append(Enabled).Append("\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
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
        // Metric (int) maximum
        if (this.Metric > (int)9999)
        {
            yield return new ValidationResult("Invalid value for Metric, must be a value less than or equal to 9999.", new [] { "Metric" });
        }

        // Metric (int) minimum
        if (this.Metric < (int)1)
        {
            yield return new ValidationResult("Invalid value for Metric, must be a value greater than or equal to 1.", new [] { "Metric" });
        }

        yield break;
    }
}