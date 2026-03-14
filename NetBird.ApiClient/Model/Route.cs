


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
/// Route
/// </summary>
[DataContract(Name = "Route")]
public class Route : IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Route" /> class.
    /// </summary>
    [JsonConstructor]
    protected Route() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="Route" /> class.
    /// </summary>
    /// <param name="description">Route description (required).</param>
    /// <param name="networkId">Route network identifier, to group HA routes (required).</param>
    /// <param name="enabled">Route status (required).</param>
    /// <param name="peer">Peer Identifier associated with route. This property can not be set together with &#x60;peer_groups&#x60;.</param>
    /// <param name="peerGroups">Peers Group Identifier associated with route. This property can not be set together with &#x60;peer&#x60;.</param>
    /// <param name="network">Network range in CIDR format, Conflicts with domains.</param>
    /// <param name="domains">Domain list to be dynamically resolved. Max of 32 domains can be added per route configuration. Conflicts with network.</param>
    /// <param name="metric">Route metric number. Lowest number has higher priority (required).</param>
    /// <param name="masquerade">Indicate if peer should masquerade traffic to this route&#39;s prefix (required).</param>
    /// <param name="groups">Group IDs containing routing peers (required).</param>
    /// <param name="keepRoute">Indicate if the route should be kept after a domain doesn&#39;t resolve that IP anymore (required).</param>
    /// <param name="accessControlGroups">Access control group identifier associated with route..</param>
    /// <param name="skipAutoApply">Indicate if this exit node route (0.0.0.0/0) should skip auto-application for client routing.</param>
    /// <param name="id">Route Id (required).</param>
    /// <param name="networkType">Network type indicating if it is a domain route or a IPv4/IPv6 route (required).</param>
    public Route(string description = null, string networkId = null, bool enabled = false, string peer = null, List<string> peerGroups = null, string network = null, List<string> domains = null, int metric = 0, bool masquerade = false, List<string> groups = null, bool keepRoute = false, List<string> accessControlGroups = null, bool skipAutoApply = false, string id = null, string networkType = null)
    {
        // to ensure "description" is required (not null)
        ArgumentNullException.ThrowIfNull(description);
        this.Description = description;
        // to ensure "networkId" is required (not null)
        ArgumentNullException.ThrowIfNull(networkId);
        this.NetworkId = networkId;
        this.Enabled = enabled;
        this.Metric = metric;
        this.Masquerade = masquerade;
        // to ensure "groups" is required (not null)
        ArgumentNullException.ThrowIfNull(groups);
        this.Groups = groups;
        this.KeepRoute = keepRoute;
        // to ensure "id" is required (not null)
        ArgumentNullException.ThrowIfNull(id);
        this.Id = id;
        // to ensure "networkType" is required (not null)
        ArgumentNullException.ThrowIfNull(networkType);
        this.NetworkType = networkType;
        this.Peer = peer;
        this.PeerGroups = peerGroups;
        this.Network = network;
        this.Domains = domains;
        this.AccessControlGroups = accessControlGroups;
        this.SkipAutoApply = skipAutoApply;
    }

    /// <summary>
    /// Route description
    /// </summary>
    /// <value>Route description</value>
    /*
    <example>My first route</example>
    */
    [JsonPropertyName("description")]
    public string Description { get; set; }

    /// <summary>
    /// Route network identifier, to group HA routes
    /// </summary>
    /// <value>Route network identifier, to group HA routes</value>
    /*
    <example>Route 1</example>
    */
    [JsonPropertyName("network_id")]
    public string NetworkId { get; set; }

    /// <summary>
    /// Route status
    /// </summary>
    /// <value>Route status</value>
    /*
    <example>true</example>
    */
    [JsonPropertyName("enabled")]
    public bool Enabled { get; set; }

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
    /// Network range in CIDR format, Conflicts with domains
    /// </summary>
    /// <value>Network range in CIDR format, Conflicts with domains</value>
    /*
    <example>10.64.0.0/24</example>
    */
    [JsonPropertyName("network")]
    public string Network { get; set; }

    /// <summary>
    /// Domain list to be dynamically resolved. Max of 32 domains can be added per route configuration. Conflicts with network
    /// </summary>
    /// <value>Domain list to be dynamically resolved. Max of 32 domains can be added per route configuration. Conflicts with network</value>
    [JsonPropertyName("domains")]
    public List<string> Domains { get; set; }

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
    /// Group IDs containing routing peers
    /// </summary>
    /// <value>Group IDs containing routing peers</value>
    [JsonPropertyName("groups")]
    public List<string> Groups { get; set; }

    /// <summary>
    /// Indicate if the route should be kept after a domain doesn&#39;t resolve that IP anymore
    /// </summary>
    /// <value>Indicate if the route should be kept after a domain doesn&#39;t resolve that IP anymore</value>
    /*
    <example>true</example>
    */
    [JsonPropertyName("keep_route")]
    public bool KeepRoute { get; set; }

    /// <summary>
    /// Access control group identifier associated with route.
    /// </summary>
    /// <value>Access control group identifier associated with route.</value>
    [JsonPropertyName("access_control_groups")]
    public List<string> AccessControlGroups { get; set; }

    /// <summary>
    /// Indicate if this exit node route (0.0.0.0/0) should skip auto-application for client routing
    /// </summary>
    /// <value>Indicate if this exit node route (0.0.0.0/0) should skip auto-application for client routing</value>
    /*
    <example>false</example>
    */
    [JsonPropertyName("skip_auto_apply")]
    public bool SkipAutoApply { get; set; }

    /// <summary>
    /// Route Id
    /// </summary>
    /// <value>Route Id</value>
    /*
    <example>chacdk86lnnboviihd7g</example>
    */
    [JsonPropertyName("id")]
    public string Id { get; set; }

    /// <summary>
    /// Network type indicating if it is a domain route or a IPv4/IPv6 route
    /// </summary>
    /// <value>Network type indicating if it is a domain route or a IPv4/IPv6 route</value>
    /*
    <example>IPv4</example>
    */
    [JsonPropertyName("network_type")]
    public string NetworkType { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class Route {\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  NetworkId: ").Append(NetworkId).Append("\n");
        sb.Append("  Enabled: ").Append(Enabled).Append("\n");
        sb.Append("  Peer: ").Append(Peer).Append("\n");
        sb.Append("  PeerGroups: ").Append(PeerGroups).Append("\n");
        sb.Append("  Network: ").Append(Network).Append("\n");
        sb.Append("  Domains: ").Append(Domains).Append("\n");
        sb.Append("  Metric: ").Append(Metric).Append("\n");
        sb.Append("  Masquerade: ").Append(Masquerade).Append("\n");
        sb.Append("  Groups: ").Append(Groups).Append("\n");
        sb.Append("  KeepRoute: ").Append(KeepRoute).Append("\n");
        sb.Append("  AccessControlGroups: ").Append(AccessControlGroups).Append("\n");
        sb.Append("  SkipAutoApply: ").Append(SkipAutoApply).Append("\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  NetworkType: ").Append(NetworkType).Append("\n");
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
        // NetworkId (string) maxLength
        if (this.NetworkId is not null && this.NetworkId.Length > 40)
        {
            yield return new ValidationResult("Invalid value for NetworkId, length must be less than 40.", new [] { "NetworkId" });
        }

        // NetworkId (string) minLength
        if (this.NetworkId is not null && this.NetworkId.Length < 1)
        {
            yield return new ValidationResult("Invalid value for NetworkId, length must be greater than 1.", new [] { "NetworkId" });
        }

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