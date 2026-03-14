


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
/// AccessiblePeer
/// </summary>
[DataContract(Name = "AccessiblePeer")]
public class AccessiblePeer : IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AccessiblePeer" /> class.
    /// </summary>
    [JsonConstructor]
    protected AccessiblePeer() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="AccessiblePeer" /> class.
    /// </summary>
    /// <param name="id">Peer ID (required).</param>
    /// <param name="name">Peer&#39;s hostname (required).</param>
    /// <param name="ip">Peer&#39;s IP address (required).</param>
    /// <param name="dnsLabel">Peer&#39;s DNS label is the parsed peer name for domain resolution. It is used to form an FQDN by appending the account&#39;s domain to the peer label. e.g. peer-dns-label.netbird.cloud (required).</param>
    /// <param name="userId">User ID of the user that enrolled this peer (required).</param>
    /// <param name="os">Peer&#39;s operating system and version (required).</param>
    /// <param name="countryCode">2-letter ISO 3166-1 alpha-2 code that represents the country (required).</param>
    /// <param name="cityName">Commonly used English name of the city (required).</param>
    /// <param name="geonameId">Unique identifier from the GeoNames database for a specific geographical location. (required).</param>
    /// <param name="connected">Peer to Management connection status (required).</param>
    /// <param name="lastSeen">Last time peer connected to Netbird&#39;s management service (required).</param>
    public AccessiblePeer(string id = null, string name = null, string ip = null, string dnsLabel = null, string userId = null, string os = null, string countryCode = null, string cityName = null, int geonameId = 0, bool connected = false, DateTimeOffset lastSeen = default)
    {
        // to ensure "id" is required (not null)
        ArgumentNullException.ThrowIfNull(id);
        this.Id = id;
        // to ensure "name" is required (not null)
        ArgumentNullException.ThrowIfNull(name);
        this.Name = name;
        // to ensure "ip" is required (not null)
        ArgumentNullException.ThrowIfNull(ip);
        this.Ip = ip;
        // to ensure "dnsLabel" is required (not null)
        ArgumentNullException.ThrowIfNull(dnsLabel);
        this.DnsLabel = dnsLabel;
        // to ensure "userId" is required (not null)
        ArgumentNullException.ThrowIfNull(userId);
        this.UserId = userId;
        // to ensure "os" is required (not null)
        ArgumentNullException.ThrowIfNull(os);
        this.Os = os;
        // to ensure "countryCode" is required (not null)
        ArgumentNullException.ThrowIfNull(countryCode);
        this.CountryCode = countryCode;
        // to ensure "cityName" is required (not null)
        ArgumentNullException.ThrowIfNull(cityName);
        this.CityName = cityName;
        this.GeonameId = geonameId;
        this.Connected = connected;
        this.LastSeen = lastSeen;
    }

    /// <summary>
    /// Peer ID
    /// </summary>
    /// <value>Peer ID</value>
    /*
    <example>chacbco6lnnbn6cg5s90</example>
    */
    [JsonPropertyName("id")]
    public string Id { get; set; }

    /// <summary>
    /// Peer&#39;s hostname
    /// </summary>
    /// <value>Peer&#39;s hostname</value>
    /*
    <example>stage-host-1</example>
    */
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// Peer&#39;s IP address
    /// </summary>
    /// <value>Peer&#39;s IP address</value>
    /*
    <example>10.64.0.1</example>
    */
    [JsonPropertyName("ip")]
    public string Ip { get; set; }

    /// <summary>
    /// Peer&#39;s DNS label is the parsed peer name for domain resolution. It is used to form an FQDN by appending the account&#39;s domain to the peer label. e.g. peer-dns-label.netbird.cloud
    /// </summary>
    /// <value>Peer&#39;s DNS label is the parsed peer name for domain resolution. It is used to form an FQDN by appending the account&#39;s domain to the peer label. e.g. peer-dns-label.netbird.cloud</value>
    /*
    <example>stage-host-1.netbird.cloud</example>
    */
    [JsonPropertyName("dns_label")]
    public string DnsLabel { get; set; }

    /// <summary>
    /// User ID of the user that enrolled this peer
    /// </summary>
    /// <value>User ID of the user that enrolled this peer</value>
    /*
    <example>google-oauth2|277474792786460067937</example>
    */
    [JsonPropertyName("user_id")]
    public string UserId { get; set; }

    /// <summary>
    /// Peer&#39;s operating system and version
    /// </summary>
    /// <value>Peer&#39;s operating system and version</value>
    /*
    <example>linux</example>
    */
    [JsonPropertyName("os")]
    public string Os { get; set; }

    /// <summary>
    /// 2-letter ISO 3166-1 alpha-2 code that represents the country
    /// </summary>
    /// <value>2-letter ISO 3166-1 alpha-2 code that represents the country</value>
    /*
    <example>DE</example>
    */
    [JsonPropertyName("country_code")]
    public string CountryCode { get; set; }

    /// <summary>
    /// Commonly used English name of the city
    /// </summary>
    /// <value>Commonly used English name of the city</value>
    /*
    <example>Berlin</example>
    */
    [JsonPropertyName("city_name")]
    public string CityName { get; set; }

    /// <summary>
    /// Unique identifier from the GeoNames database for a specific geographical location.
    /// </summary>
    /// <value>Unique identifier from the GeoNames database for a specific geographical location.</value>
    /*
    <example>2643743</example>
    */
    [JsonPropertyName("geoname_id")]
    public int GeonameId { get; set; }

    /// <summary>
    /// Peer to Management connection status
    /// </summary>
    /// <value>Peer to Management connection status</value>
    /*
    <example>true</example>
    */
    [JsonPropertyName("connected")]
    public bool Connected { get; set; }

    /// <summary>
    /// Last time peer connected to Netbird&#39;s management service
    /// </summary>
    /// <value>Last time peer connected to Netbird&#39;s management service</value>
    /*
    <example>2023-05-05T10:05:26.420578Z</example>
    */
    [JsonPropertyName("last_seen")]
    public DateTimeOffset LastSeen { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class AccessiblePeer {\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Ip: ").Append(Ip).Append("\n");
        sb.Append("  DnsLabel: ").Append(DnsLabel).Append("\n");
        sb.Append("  UserId: ").Append(UserId).Append("\n");
        sb.Append("  Os: ").Append(Os).Append("\n");
        sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
        sb.Append("  CityName: ").Append(CityName).Append("\n");
        sb.Append("  GeonameId: ").Append(GeonameId).Append("\n");
        sb.Append("  Connected: ").Append(Connected).Append("\n");
        sb.Append("  LastSeen: ").Append(LastSeen).Append("\n");
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