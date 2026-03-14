


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
/// IngressPortAllocation
/// </summary>
[DataContract(Name = "IngressPortAllocation")]
public class IngressPortAllocation : IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="IngressPortAllocation" /> class.
    /// </summary>
    [JsonConstructor]
    protected IngressPortAllocation() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="IngressPortAllocation" /> class.
    /// </summary>
    /// <param name="id">ID of the ingress port allocation (required).</param>
    /// <param name="name">Name of the ingress port allocation (required).</param>
    /// <param name="ingressPeerId">ID of the ingress peer that forwards the ports (required).</param>
    /// <param name="region">Region of the ingress peer (required).</param>
    /// <param name="enabled">Indicates if an ingress port allocation is enabled (required).</param>
    /// <param name="ingressIp">Ingress IP address of the ingress peer where the traffic arrives (required).</param>
    /// <param name="portRangeMappings">List of port ranges that are allowed to be used by the ingress peer (required).</param>
    public IngressPortAllocation(string id = null, string name = null, string ingressPeerId = null, string region = null, bool enabled = false, string ingressIp = null, List<IngressPortAllocationPortMapping> portRangeMappings = null)
    {
        // to ensure "id" is required (not null)
        ArgumentNullException.ThrowIfNull(id);
        this.Id = id;
        // to ensure "name" is required (not null)
        ArgumentNullException.ThrowIfNull(name);
        this.Name = name;
        // to ensure "ingressPeerId" is required (not null)
        ArgumentNullException.ThrowIfNull(ingressPeerId);
        this.IngressPeerId = ingressPeerId;
        // to ensure "region" is required (not null)
        ArgumentNullException.ThrowIfNull(region);
        this.Region = region;
        this.Enabled = enabled;
        // to ensure "ingressIp" is required (not null)
        ArgumentNullException.ThrowIfNull(ingressIp);
        this.IngressIp = ingressIp;
        // to ensure "portRangeMappings" is required (not null)
        ArgumentNullException.ThrowIfNull(portRangeMappings);
        this.PortRangeMappings = portRangeMappings;
    }

    /// <summary>
    /// ID of the ingress port allocation
    /// </summary>
    /// <value>ID of the ingress port allocation</value>
    /*
    <example>ch8i4ug6lnn4g9hqv7m0</example>
    */
    [JsonPropertyName("id")]
    public string Id { get; set; }

    /// <summary>
    /// Name of the ingress port allocation
    /// </summary>
    /// <value>Name of the ingress port allocation</value>
    /*
    <example>Ingress Peer Allocation 1</example>
    */
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// ID of the ingress peer that forwards the ports
    /// </summary>
    /// <value>ID of the ingress peer that forwards the ports</value>
    /*
    <example>x7p3kqf2rdd8j5zxw4n9</example>
    */
    [JsonPropertyName("ingress_peer_id")]
    public string IngressPeerId { get; set; }

    /// <summary>
    /// Region of the ingress peer
    /// </summary>
    /// <value>Region of the ingress peer</value>
    /*
    <example>germany</example>
    */
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>
    /// Indicates if an ingress port allocation is enabled
    /// </summary>
    /// <value>Indicates if an ingress port allocation is enabled</value>
    /*
    <example>true</example>
    */
    [JsonPropertyName("enabled")]
    public bool Enabled { get; set; }

    /// <summary>
    /// Ingress IP address of the ingress peer where the traffic arrives
    /// </summary>
    /// <value>Ingress IP address of the ingress peer where the traffic arrives</value>
    /*
    <example>192.34.0.123</example>
    */
    [JsonPropertyName("ingress_ip")]
    public string IngressIp { get; set; }

    /// <summary>
    /// List of port ranges that are allowed to be used by the ingress peer
    /// </summary>
    /// <value>List of port ranges that are allowed to be used by the ingress peer</value>
    [JsonPropertyName("port_range_mappings")]
    public List<IngressPortAllocationPortMapping> PortRangeMappings { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class IngressPortAllocation {\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  IngressPeerId: ").Append(IngressPeerId).Append("\n");
        sb.Append("  Region: ").Append(Region).Append("\n");
        sb.Append("  Enabled: ").Append(Enabled).Append("\n");
        sb.Append("  IngressIp: ").Append(IngressIp).Append("\n");
        sb.Append("  PortRangeMappings: ").Append(PortRangeMappings).Append("\n");
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