


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
/// Group
/// </summary>
[DataContract(Name = "Group")]
public class Group : IValidatableObject
{
    /// <summary>
    /// How the group was issued (api, integration, jwt)
    /// </summary>
    /// <value>How the group was issued (api, integration, jwt)</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum IssuedEnum
    {
        /// <summary>
        /// Enum Api for value: api
        /// </summary>
        [EnumMember(Value = "api")]
        Api = 1,

        /// <summary>
        /// Enum Integration for value: integration
        /// </summary>
        [EnumMember(Value = "integration")]
        Integration = 2,

        /// <summary>
        /// Enum Jwt for value: jwt
        /// </summary>
        [EnumMember(Value = "jwt")]
        Jwt = 3
    }


    /// <summary>
    /// How the group was issued (api, integration, jwt)
    /// </summary>
    /// <value>How the group was issued (api, integration, jwt)</value>
    /*
    <example>api</example>
    */
    [JsonPropertyName("issued")]
    public IssuedEnum? Issued { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="Group" /> class.
    /// </summary>
    [JsonConstructor]
    protected Group() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="Group" /> class.
    /// </summary>
    /// <param name="id">Group ID (required).</param>
    /// <param name="name">Group Name identifier (required).</param>
    /// <param name="peersCount">Count of peers associated to the group (required).</param>
    /// <param name="resourcesCount">Count of resources associated to the group (required).</param>
    /// <param name="issued">How the group was issued (api, integration, jwt).</param>
    /// <param name="peers">List of peers object (required).</param>
    /// <param name="resources">resources (required).</param>
    public Group(string id = null, string name = null, int peersCount = 0, int resourcesCount = 0, IssuedEnum? issued = null, List<PeerMinimum> peers = null, List<Resource> resources = null)
    {
        // to ensure "id" is required (not null)
        ArgumentNullException.ThrowIfNull(id);
        this.Id = id;
        // to ensure "name" is required (not null)
        ArgumentNullException.ThrowIfNull(name);
        this.Name = name;
        this.PeersCount = peersCount;
        this.ResourcesCount = resourcesCount;
        // to ensure "peers" is required (not null)
        ArgumentNullException.ThrowIfNull(peers);
        this.Peers = peers;
        // to ensure "resources" is required (not null)
        ArgumentNullException.ThrowIfNull(resources);
        this.Resources = resources;
        this.Issued = issued;
    }

    /// <summary>
    /// Group ID
    /// </summary>
    /// <value>Group ID</value>
    /*
    <example>ch8i4ug6lnn4g9hqv7m0</example>
    */
    [JsonPropertyName("id")]
    public string Id { get; set; }

    /// <summary>
    /// Group Name identifier
    /// </summary>
    /// <value>Group Name identifier</value>
    /*
    <example>devs</example>
    */
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// Count of peers associated to the group
    /// </summary>
    /// <value>Count of peers associated to the group</value>
    /*
    <example>2</example>
    */
    [JsonPropertyName("peers_count")]
    public int PeersCount { get; set; }

    /// <summary>
    /// Count of resources associated to the group
    /// </summary>
    /// <value>Count of resources associated to the group</value>
    /*
    <example>5</example>
    */
    [JsonPropertyName("resources_count")]
    public int ResourcesCount { get; set; }

    /// <summary>
    /// List of peers object
    /// </summary>
    /// <value>List of peers object</value>
    [JsonPropertyName("peers")]
    public List<PeerMinimum> Peers { get; set; }

    /// <summary>
    /// Gets or Sets Resources
    /// </summary>
    [JsonPropertyName("resources")]
    public List<Resource> Resources { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class Group {\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  PeersCount: ").Append(PeersCount).Append("\n");
        sb.Append("  ResourcesCount: ").Append(ResourcesCount).Append("\n");
        sb.Append("  Issued: ").Append(Issued).Append("\n");
        sb.Append("  Peers: ").Append(Peers).Append("\n");
        sb.Append("  Resources: ").Append(Resources).Append("\n");
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