


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
/// NetworkTrafficEndpoint
/// </summary>
[DataContract(Name = "NetworkTrafficEndpoint")]
public class NetworkTrafficEndpoint : IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="NetworkTrafficEndpoint" /> class.
    /// </summary>
    [JsonConstructor]
    protected NetworkTrafficEndpoint() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="NetworkTrafficEndpoint" /> class.
    /// </summary>
    /// <param name="id">ID of this endpoint (e.g., peer ID or resource ID). (required).</param>
    /// <param name="type">Type of the endpoint object (e.g., UNKNOWN, PEER, HOST_RESOURCE). (required).</param>
    /// <param name="name">Name is the name of the endpoint object (e.g., a peer name). (required).</param>
    /// <param name="geoLocation">geoLocation (required).</param>
    /// <param name="os">Operating system of the peer, if applicable. (required).</param>
    /// <param name="address">IP address (and possibly port) in string form. (required).</param>
    /// <param name="dnsLabel">DNS label/name if available. (required).</param>
    public NetworkTrafficEndpoint(string id = null, string type = null, string name = null, NetworkTrafficLocation geoLocation = null, string os = null, string address = null, string dnsLabel = null)
    {
        // to ensure "id" is required (not null)
        ArgumentNullException.ThrowIfNull(id);
        this.Id = id;
        // to ensure "type" is required (not null)
        ArgumentNullException.ThrowIfNull(type);
        this.Type = type;
        // to ensure "name" is required (not null)
        ArgumentNullException.ThrowIfNull(name);
        this.Name = name;
        // to ensure "geoLocation" is required (not null)
        ArgumentNullException.ThrowIfNull(geoLocation);
        this.GeoLocation = geoLocation;
        // to ensure "os" is required (not null)
        ArgumentNullException.ThrowIfNull(os);
        this.Os = os;
        // to ensure "address" is required (not null)
        ArgumentNullException.ThrowIfNull(address);
        this.Address = address;
        // to ensure "dnsLabel" is required (not null)
        ArgumentNullException.ThrowIfNull(dnsLabel);
        this.DnsLabel = dnsLabel;
    }

    /// <summary>
    /// ID of this endpoint (e.g., peer ID or resource ID).
    /// </summary>
    /// <value>ID of this endpoint (e.g., peer ID or resource ID).</value>
    /*
    <example>ch8i4ug6lnn4g9hqv7m0</example>
    */
    [JsonPropertyName("id")]
    public string Id { get; set; }

    /// <summary>
    /// Type of the endpoint object (e.g., UNKNOWN, PEER, HOST_RESOURCE).
    /// </summary>
    /// <value>Type of the endpoint object (e.g., UNKNOWN, PEER, HOST_RESOURCE).</value>
    /*
    <example>PEER</example>
    */
    [JsonPropertyName("type")]
    public string Type { get; set; }

    /// <summary>
    /// Name is the name of the endpoint object (e.g., a peer name).
    /// </summary>
    /// <value>Name is the name of the endpoint object (e.g., a peer name).</value>
    /*
    <example>My Peer</example>
    */
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets GeoLocation
    /// </summary>
    [JsonPropertyName("geo_location")]
    public NetworkTrafficLocation GeoLocation { get; set; }

    /// <summary>
    /// Operating system of the peer, if applicable.
    /// </summary>
    /// <value>Operating system of the peer, if applicable.</value>
    /*
    <example>Linux</example>
    */
    [JsonPropertyName("os")]
    public string Os { get; set; }

    /// <summary>
    /// IP address (and possibly port) in string form.
    /// </summary>
    /// <value>IP address (and possibly port) in string form.</value>
    /*
    <example>100.64.0.10:51820</example>
    */
    [JsonPropertyName("address")]
    public string Address { get; set; }

    /// <summary>
    /// DNS label/name if available.
    /// </summary>
    /// <value>DNS label/name if available.</value>
    /*
    <example>*.mydomain.com</example>
    */
    [JsonPropertyName("dns_label")]
    public string DnsLabel { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class NetworkTrafficEndpoint {\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  GeoLocation: ").Append(GeoLocation).Append("\n");
        sb.Append("  Os: ").Append(Os).Append("\n");
        sb.Append("  Address: ").Append(Address).Append("\n");
        sb.Append("  DnsLabel: ").Append(DnsLabel).Append("\n");
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