


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
/// IngressPortAllocationRequest
/// </summary>
[DataContract(Name = "IngressPortAllocationRequest")]
public class IngressPortAllocationRequest : IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="IngressPortAllocationRequest" /> class.
    /// </summary>
    [JsonConstructor]
    protected IngressPortAllocationRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="IngressPortAllocationRequest" /> class.
    /// </summary>
    /// <param name="name">Name of the ingress port allocation (required).</param>
    /// <param name="enabled">Indicates if an ingress port allocation is enabled (required).</param>
    /// <param name="portRanges">List of port ranges that are forwarded by the ingress peer.</param>
    /// <param name="directPort">Direct port allocation.</param>
    public IngressPortAllocationRequest(string name = null, bool enabled = false, List<IngressPortAllocationRequestPortRange> portRanges = null, IngressPortAllocationRequestDirectPort directPort = null)
    {
        // to ensure "name" is required (not null)
        ArgumentNullException.ThrowIfNull(name);
        this.Name = name;
        this.Enabled = enabled;
        this.PortRanges = portRanges;
        this.DirectPort = directPort;
    }

    /// <summary>
    /// Name of the ingress port allocation
    /// </summary>
    /// <value>Name of the ingress port allocation</value>
    /*
    <example>Ingress Port Allocation 1</example>
    */
    [JsonPropertyName("name")]
    public string Name { get; set; }

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
    /// List of port ranges that are forwarded by the ingress peer
    /// </summary>
    /// <value>List of port ranges that are forwarded by the ingress peer</value>
    [JsonPropertyName("port_ranges")]
    public List<IngressPortAllocationRequestPortRange> PortRanges { get; set; }

    /// <summary>
    /// Direct port allocation
    /// </summary>
    /// <value>Direct port allocation</value>
    [JsonPropertyName("direct_port")]
    public IngressPortAllocationRequestDirectPort DirectPort { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class IngressPortAllocationRequest {\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Enabled: ").Append(Enabled).Append("\n");
        sb.Append("  PortRanges: ").Append(PortRanges).Append("\n");
        sb.Append("  DirectPort: ").Append(DirectPort).Append("\n");
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