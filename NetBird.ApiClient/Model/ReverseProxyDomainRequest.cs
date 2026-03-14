


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
/// ReverseProxyDomainRequest
/// </summary>
[DataContract(Name = "ReverseProxyDomainRequest")]
public class ReverseProxyDomainRequest : IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ReverseProxyDomainRequest" /> class.
    /// </summary>
    [JsonConstructor]
    protected ReverseProxyDomainRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ReverseProxyDomainRequest" /> class.
    /// </summary>
    /// <param name="domain">Domain name (required).</param>
    /// <param name="targetCluster">The proxy cluster this domain should be validated against (required).</param>
    public ReverseProxyDomainRequest(string domain = null, string targetCluster = null)
    {
        // to ensure "domain" is required (not null)
        ArgumentNullException.ThrowIfNull(domain);
        this.Domain = domain;
        // to ensure "targetCluster" is required (not null)
        ArgumentNullException.ThrowIfNull(targetCluster);
        this.TargetCluster = targetCluster;
    }

    /// <summary>
    /// Domain name
    /// </summary>
    /// <value>Domain name</value>
    [JsonPropertyName("domain")]
    public string Domain { get; set; }

    /// <summary>
    /// The proxy cluster this domain should be validated against
    /// </summary>
    /// <value>The proxy cluster this domain should be validated against</value>
    [JsonPropertyName("target_cluster")]
    public string TargetCluster { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class ReverseProxyDomainRequest {\n");
        sb.Append("  Domain: ").Append(Domain).Append("\n");
        sb.Append("  TargetCluster: ").Append(TargetCluster).Append("\n");
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