


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
/// Network
/// </summary>
[DataContract(Name = "Network")]
public class Network : IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Network" /> class.
    /// </summary>
    [JsonConstructor]
    protected Network() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="Network" /> class.
    /// </summary>
    /// <param name="name">Network name (required).</param>
    /// <param name="description">Network description.</param>
    /// <param name="id">Network ID (required).</param>
    /// <param name="routers">List of router IDs associated with the network (required).</param>
    /// <param name="routingPeersCount">Count of routing peers associated with the network (required).</param>
    /// <param name="resources">List of network resource IDs associated with the network (required).</param>
    /// <param name="policies">List of policy IDs associated with the network (required).</param>
    public Network(string name = null, string description = null, string id = null, List<string> routers = null, int routingPeersCount = 0, List<string> resources = null, List<string> policies = null)
    {
        // to ensure "name" is required (not null)
        ArgumentNullException.ThrowIfNull(name);
        this.Name = name;
        // to ensure "id" is required (not null)
        ArgumentNullException.ThrowIfNull(id);
        this.Id = id;
        // to ensure "routers" is required (not null)
        ArgumentNullException.ThrowIfNull(routers);
        this.Routers = routers;
        this.RoutingPeersCount = routingPeersCount;
        // to ensure "resources" is required (not null)
        ArgumentNullException.ThrowIfNull(resources);
        this.Resources = resources;
        // to ensure "policies" is required (not null)
        ArgumentNullException.ThrowIfNull(policies);
        this.Policies = policies;
        this.Description = description;
    }

    /// <summary>
    /// Network name
    /// </summary>
    /// <value>Network name</value>
    /*
    <example>Remote Network 1</example>
    */
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// Network description
    /// </summary>
    /// <value>Network description</value>
    /*
    <example>A remote network that needs to be accessed</example>
    */
    [JsonPropertyName("description")]
    public string Description { get; set; }

    /// <summary>
    /// Network ID
    /// </summary>
    /// <value>Network ID</value>
    /*
    <example>chacdk86lnnboviihd7g</example>
    */
    [JsonPropertyName("id")]
    public string Id { get; set; }

    /// <summary>
    /// List of router IDs associated with the network
    /// </summary>
    /// <value>List of router IDs associated with the network</value>
    [JsonPropertyName("routers")]
    public List<string> Routers { get; set; }

    /// <summary>
    /// Count of routing peers associated with the network
    /// </summary>
    /// <value>Count of routing peers associated with the network</value>
    /*
    <example>2</example>
    */
    [JsonPropertyName("routing_peers_count")]
    public int RoutingPeersCount { get; set; }

    /// <summary>
    /// List of network resource IDs associated with the network
    /// </summary>
    /// <value>List of network resource IDs associated with the network</value>
    [JsonPropertyName("resources")]
    public List<string> Resources { get; set; }

    /// <summary>
    /// List of policy IDs associated with the network
    /// </summary>
    /// <value>List of policy IDs associated with the network</value>
    [JsonPropertyName("policies")]
    public List<string> Policies { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class Network {\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Routers: ").Append(Routers).Append("\n");
        sb.Append("  RoutingPeersCount: ").Append(RoutingPeersCount).Append("\n");
        sb.Append("  Resources: ").Append(Resources).Append("\n");
        sb.Append("  Policies: ").Append(Policies).Append("\n");
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