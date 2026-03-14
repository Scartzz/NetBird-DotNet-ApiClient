


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
/// ReverseProxyDomain
/// </summary>
[DataContract(Name = "ReverseProxyDomain")]
public class ReverseProxyDomain : IValidatableObject
{

    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [JsonPropertyName("type")]
    public ReverseProxyDomainType Type { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="ReverseProxyDomain" /> class.
    /// </summary>
    [JsonConstructor]
    protected ReverseProxyDomain() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ReverseProxyDomain" /> class.
    /// </summary>
    /// <param name="id">Domain ID (required).</param>
    /// <param name="domain">Domain name (required).</param>
    /// <param name="validated">Whether the domain has been validated (required).</param>
    /// <param name="type">type (required).</param>
    /// <param name="targetCluster">The proxy cluster this domain is validated against (only for custom domains).</param>
    /// <param name="supportsCustomPorts">Whether the cluster supports binding arbitrary TCP/UDP ports.</param>
    public ReverseProxyDomain(string id = null, string domain = null, bool validated = false, ReverseProxyDomainType type = default, string targetCluster = null, bool supportsCustomPorts = false)
    {
        // to ensure "id" is required (not null)
        ArgumentNullException.ThrowIfNull(id);
        this.Id = id;
        // to ensure "domain" is required (not null)
        ArgumentNullException.ThrowIfNull(domain);
        this.Domain = domain;
        this.Validated = validated;
        this.Type = type;
        this.TargetCluster = targetCluster;
        this.SupportsCustomPorts = supportsCustomPorts;
    }

    /// <summary>
    /// Domain ID
    /// </summary>
    /// <value>Domain ID</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }

    /// <summary>
    /// Domain name
    /// </summary>
    /// <value>Domain name</value>
    [JsonPropertyName("domain")]
    public string Domain { get; set; }

    /// <summary>
    /// Whether the domain has been validated
    /// </summary>
    /// <value>Whether the domain has been validated</value>
    [JsonPropertyName("validated")]
    public bool Validated { get; set; }

    /// <summary>
    /// The proxy cluster this domain is validated against (only for custom domains)
    /// </summary>
    /// <value>The proxy cluster this domain is validated against (only for custom domains)</value>
    [JsonPropertyName("target_cluster")]
    public string TargetCluster { get; set; }

    /// <summary>
    /// Whether the cluster supports binding arbitrary TCP/UDP ports
    /// </summary>
    /// <value>Whether the cluster supports binding arbitrary TCP/UDP ports</value>
    [JsonPropertyName("supports_custom_ports")]
    public bool SupportsCustomPorts { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class ReverseProxyDomain {\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Domain: ").Append(Domain).Append("\n");
        sb.Append("  Validated: ").Append(Validated).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  TargetCluster: ").Append(TargetCluster).Append("\n");
        sb.Append("  SupportsCustomPorts: ").Append(SupportsCustomPorts).Append("\n");
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