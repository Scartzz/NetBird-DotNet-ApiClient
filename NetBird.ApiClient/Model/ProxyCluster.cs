


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
/// A proxy cluster represents a group of proxy nodes serving the same address
/// </summary>
[DataContract(Name = "ProxyCluster")]
public class ProxyCluster : IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ProxyCluster" /> class.
    /// </summary>
    [JsonConstructor]
    protected ProxyCluster() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ProxyCluster" /> class.
    /// </summary>
    /// <param name="address">Cluster address used for CNAME targets (required).</param>
    /// <param name="connectedProxies">Number of proxy nodes connected in this cluster (required).</param>
    public ProxyCluster(string address = null, int connectedProxies = 0)
    {
        // to ensure "address" is required (not null)
        ArgumentNullException.ThrowIfNull(address);
        this.Address = address;
        this.ConnectedProxies = connectedProxies;
    }

    /// <summary>
    /// Cluster address used for CNAME targets
    /// </summary>
    /// <value>Cluster address used for CNAME targets</value>
    /*
    <example>eu.proxy.netbird.io</example>
    */
    [JsonPropertyName("address")]
    public string Address { get; set; }

    /// <summary>
    /// Number of proxy nodes connected in this cluster
    /// </summary>
    /// <value>Number of proxy nodes connected in this cluster</value>
    /*
    <example>3</example>
    */
    [JsonPropertyName("connected_proxies")]
    public int ConnectedProxies { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class ProxyCluster {\n");
        sb.Append("  Address: ").Append(Address).Append("\n");
        sb.Append("  ConnectedProxies: ").Append(ConnectedProxies).Append("\n");
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