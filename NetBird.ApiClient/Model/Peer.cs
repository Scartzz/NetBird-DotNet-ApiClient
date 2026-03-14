


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
/// Peer
/// </summary>
[DataContract(Name = "Peer")]
public class Peer : IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Peer" /> class.
    /// </summary>
    [JsonConstructor]
    protected Peer() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="Peer" /> class.
    /// </summary>
    /// <param name="id">Peer ID (required).</param>
    /// <param name="name">Peer&#39;s hostname (required).</param>
    /// <param name="createdAt">Peer creation date (UTC) (required).</param>
    /// <param name="ip">Peer&#39;s IP address (required).</param>
    /// <param name="connectionIp">Peer&#39;s public connection IP address (required).</param>
    /// <param name="connected">Peer to Management connection status (required).</param>
    /// <param name="lastSeen">Last time peer connected to Netbird&#39;s management service (required).</param>
    /// <param name="os">Peer&#39;s operating system and version (required).</param>
    /// <param name="kernelVersion">Peer&#39;s operating system kernel version (required).</param>
    /// <param name="geonameId">Unique identifier from the GeoNames database for a specific geographical location. (required).</param>
    /// <param name="varVersion">Peer&#39;s daemon or cli version (required).</param>
    /// <param name="groups">Groups that the peer belongs to (required).</param>
    /// <param name="sshEnabled">Indicates whether SSH server is enabled on this peer (required).</param>
    /// <param name="userId">User ID of the user that enrolled this peer (required).</param>
    /// <param name="hostname">Hostname of the machine (required).</param>
    /// <param name="uiVersion">Peer&#39;s desktop UI version (required).</param>
    /// <param name="dnsLabel">Peer&#39;s DNS label is the parsed peer name for domain resolution. It is used to form an FQDN by appending the account&#39;s domain to the peer label. e.g. peer-dns-label.netbird.cloud (required).</param>
    /// <param name="loginExpirationEnabled">Indicates whether peer login expiration has been enabled or not (required).</param>
    /// <param name="loginExpired">Indicates whether peer&#39;s login expired or not (required).</param>
    /// <param name="lastLogin">Last time this peer performed log in (authentication). E.g., user authenticated. (required).</param>
    /// <param name="inactivityExpirationEnabled">Indicates whether peer inactivity expiration has been enabled or not (required).</param>
    /// <param name="approvalRequired">(Cloud only) Indicates whether peer needs approval (required).</param>
    /// <param name="disapprovalReason">(Cloud only) Reason why the peer requires approval.</param>
    /// <param name="countryCode">2-letter ISO 3166-1 alpha-2 code that represents the country (required).</param>
    /// <param name="cityName">Commonly used English name of the city (required).</param>
    /// <param name="serialNumber">System serial number (required).</param>
    /// <param name="extraDnsLabels">Extra DNS labels added to the peer (required).</param>
    /// <param name="ephemeral">Indicates whether the peer is ephemeral or not (required).</param>
    /// <param name="localFlags">localFlags.</param>
    public Peer(string id = null, string name = null, DateTimeOffset createdAt = default, string ip = null, string connectionIp = null, bool connected = false, DateTimeOffset lastSeen = default, string os = null, string kernelVersion = null, int geonameId = 0, string varVersion = null, List<GroupMinimum> groups = null, bool sshEnabled = false, string userId = null, string hostname = null, string uiVersion = null, string dnsLabel = null, bool loginExpirationEnabled = false, bool loginExpired = false, DateTimeOffset lastLogin = default, bool inactivityExpirationEnabled = false, bool approvalRequired = false, string disapprovalReason = null, string countryCode = null, string cityName = null, string serialNumber = null, List<string> extraDnsLabels = null, bool ephemeral = false, PeerLocalFlags localFlags = null)
    {
        // to ensure "id" is required (not null)
        ArgumentNullException.ThrowIfNull(id);
        this.Id = id;
        // to ensure "name" is required (not null)
        ArgumentNullException.ThrowIfNull(name);
        this.Name = name;
        this.CreatedAt = createdAt;
        // to ensure "ip" is required (not null)
        ArgumentNullException.ThrowIfNull(ip);
        this.Ip = ip;
        // to ensure "connectionIp" is required (not null)
        ArgumentNullException.ThrowIfNull(connectionIp);
        this.ConnectionIp = connectionIp;
        this.Connected = connected;
        this.LastSeen = lastSeen;
        // to ensure "os" is required (not null)
        ArgumentNullException.ThrowIfNull(os);
        this.Os = os;
        // to ensure "kernelVersion" is required (not null)
        ArgumentNullException.ThrowIfNull(kernelVersion);
        this.KernelVersion = kernelVersion;
        this.GeonameId = geonameId;
        // to ensure "varVersion" is required (not null)
        ArgumentNullException.ThrowIfNull(varVersion);
        this.VarVersion = varVersion;
        // to ensure "groups" is required (not null)
        ArgumentNullException.ThrowIfNull(groups);
        this.Groups = groups;
        this.SshEnabled = sshEnabled;
        // to ensure "userId" is required (not null)
        ArgumentNullException.ThrowIfNull(userId);
        this.UserId = userId;
        // to ensure "hostname" is required (not null)
        ArgumentNullException.ThrowIfNull(hostname);
        this.Hostname = hostname;
        // to ensure "uiVersion" is required (not null)
        ArgumentNullException.ThrowIfNull(uiVersion);
        this.UiVersion = uiVersion;
        // to ensure "dnsLabel" is required (not null)
        ArgumentNullException.ThrowIfNull(dnsLabel);
        this.DnsLabel = dnsLabel;
        this.LoginExpirationEnabled = loginExpirationEnabled;
        this.LoginExpired = loginExpired;
        this.LastLogin = lastLogin;
        this.InactivityExpirationEnabled = inactivityExpirationEnabled;
        this.ApprovalRequired = approvalRequired;
        // to ensure "countryCode" is required (not null)
        ArgumentNullException.ThrowIfNull(countryCode);
        this.CountryCode = countryCode;
        // to ensure "cityName" is required (not null)
        ArgumentNullException.ThrowIfNull(cityName);
        this.CityName = cityName;
        // to ensure "serialNumber" is required (not null)
        ArgumentNullException.ThrowIfNull(serialNumber);
        this.SerialNumber = serialNumber;
        // to ensure "extraDnsLabels" is required (not null)
        ArgumentNullException.ThrowIfNull(extraDnsLabels);
        this.ExtraDnsLabels = extraDnsLabels;
        this.Ephemeral = ephemeral;
        this.DisapprovalReason = disapprovalReason;
        this.LocalFlags = localFlags;
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
    /// Peer creation date (UTC)
    /// </summary>
    /// <value>Peer creation date (UTC)</value>
    /*
    <example>2023-05-05T09:00:35.477782Z</example>
    */
    [JsonPropertyName("created_at")]
    public DateTimeOffset CreatedAt { get; set; }

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
    /// Peer&#39;s public connection IP address
    /// </summary>
    /// <value>Peer&#39;s public connection IP address</value>
    /*
    <example>35.64.0.1</example>
    */
    [JsonPropertyName("connection_ip")]
    public string ConnectionIp { get; set; }

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
    /// Peer&#39;s operating system and version
    /// </summary>
    /// <value>Peer&#39;s operating system and version</value>
    /*
    <example>Darwin 13.2.1</example>
    */
    [JsonPropertyName("os")]
    public string Os { get; set; }

    /// <summary>
    /// Peer&#39;s operating system kernel version
    /// </summary>
    /// <value>Peer&#39;s operating system kernel version</value>
    /*
    <example>23.2.0</example>
    */
    [JsonPropertyName("kernel_version")]
    public string KernelVersion { get; set; }

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
    /// Peer&#39;s daemon or cli version
    /// </summary>
    /// <value>Peer&#39;s daemon or cli version</value>
    /*
    <example>0.14.0</example>
    */
    [JsonPropertyName("version")]
    public string VarVersion { get; set; }

    /// <summary>
    /// Groups that the peer belongs to
    /// </summary>
    /// <value>Groups that the peer belongs to</value>
    [JsonPropertyName("groups")]
    public List<GroupMinimum> Groups { get; set; }

    /// <summary>
    /// Indicates whether SSH server is enabled on this peer
    /// </summary>
    /// <value>Indicates whether SSH server is enabled on this peer</value>
    /*
    <example>true</example>
    */
    [JsonPropertyName("ssh_enabled")]
    public bool SshEnabled { get; set; }

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
    /// Hostname of the machine
    /// </summary>
    /// <value>Hostname of the machine</value>
    /*
    <example>stage-host-1</example>
    */
    [JsonPropertyName("hostname")]
    public string Hostname { get; set; }

    /// <summary>
    /// Peer&#39;s desktop UI version
    /// </summary>
    /// <value>Peer&#39;s desktop UI version</value>
    /*
    <example>0.14.0</example>
    */
    [JsonPropertyName("ui_version")]
    public string UiVersion { get; set; }

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
    /// Indicates whether peer login expiration has been enabled or not
    /// </summary>
    /// <value>Indicates whether peer login expiration has been enabled or not</value>
    /*
    <example>false</example>
    */
    [JsonPropertyName("login_expiration_enabled")]
    public bool LoginExpirationEnabled { get; set; }

    /// <summary>
    /// Indicates whether peer&#39;s login expired or not
    /// </summary>
    /// <value>Indicates whether peer&#39;s login expired or not</value>
    /*
    <example>false</example>
    */
    [JsonPropertyName("login_expired")]
    public bool LoginExpired { get; set; }

    /// <summary>
    /// Last time this peer performed log in (authentication). E.g., user authenticated.
    /// </summary>
    /// <value>Last time this peer performed log in (authentication). E.g., user authenticated.</value>
    /*
    <example>2023-05-05T09:00:35.477782Z</example>
    */
    [JsonPropertyName("last_login")]
    public DateTimeOffset LastLogin { get; set; }

    /// <summary>
    /// Indicates whether peer inactivity expiration has been enabled or not
    /// </summary>
    /// <value>Indicates whether peer inactivity expiration has been enabled or not</value>
    /*
    <example>false</example>
    */
    [JsonPropertyName("inactivity_expiration_enabled")]
    public bool InactivityExpirationEnabled { get; set; }

    /// <summary>
    /// (Cloud only) Indicates whether peer needs approval
    /// </summary>
    /// <value>(Cloud only) Indicates whether peer needs approval</value>
    /*
    <example>true</example>
    */
    [JsonPropertyName("approval_required")]
    public bool ApprovalRequired { get; set; }

    /// <summary>
    /// (Cloud only) Reason why the peer requires approval
    /// </summary>
    /// <value>(Cloud only) Reason why the peer requires approval</value>
    [JsonPropertyName("disapproval_reason")]
    public string DisapprovalReason { get; set; }

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
    /// System serial number
    /// </summary>
    /// <value>System serial number</value>
    /*
    <example>C02XJ0J0JGH7</example>
    */
    [JsonPropertyName("serial_number")]
    public string SerialNumber { get; set; }

    /// <summary>
    /// Extra DNS labels added to the peer
    /// </summary>
    /// <value>Extra DNS labels added to the peer</value>
    [JsonPropertyName("extra_dns_labels")]
    public List<string> ExtraDnsLabels { get; set; }

    /// <summary>
    /// Indicates whether the peer is ephemeral or not
    /// </summary>
    /// <value>Indicates whether the peer is ephemeral or not</value>
    /*
    <example>false</example>
    */
    [JsonPropertyName("ephemeral")]
    public bool Ephemeral { get; set; }

    /// <summary>
    /// Gets or Sets LocalFlags
    /// </summary>
    [JsonPropertyName("local_flags")]
    public PeerLocalFlags LocalFlags { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class Peer {\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
        sb.Append("  Ip: ").Append(Ip).Append("\n");
        sb.Append("  ConnectionIp: ").Append(ConnectionIp).Append("\n");
        sb.Append("  Connected: ").Append(Connected).Append("\n");
        sb.Append("  LastSeen: ").Append(LastSeen).Append("\n");
        sb.Append("  Os: ").Append(Os).Append("\n");
        sb.Append("  KernelVersion: ").Append(KernelVersion).Append("\n");
        sb.Append("  GeonameId: ").Append(GeonameId).Append("\n");
        sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
        sb.Append("  Groups: ").Append(Groups).Append("\n");
        sb.Append("  SshEnabled: ").Append(SshEnabled).Append("\n");
        sb.Append("  UserId: ").Append(UserId).Append("\n");
        sb.Append("  Hostname: ").Append(Hostname).Append("\n");
        sb.Append("  UiVersion: ").Append(UiVersion).Append("\n");
        sb.Append("  DnsLabel: ").Append(DnsLabel).Append("\n");
        sb.Append("  LoginExpirationEnabled: ").Append(LoginExpirationEnabled).Append("\n");
        sb.Append("  LoginExpired: ").Append(LoginExpired).Append("\n");
        sb.Append("  LastLogin: ").Append(LastLogin).Append("\n");
        sb.Append("  InactivityExpirationEnabled: ").Append(InactivityExpirationEnabled).Append("\n");
        sb.Append("  ApprovalRequired: ").Append(ApprovalRequired).Append("\n");
        sb.Append("  DisapprovalReason: ").Append(DisapprovalReason).Append("\n");
        sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
        sb.Append("  CityName: ").Append(CityName).Append("\n");
        sb.Append("  SerialNumber: ").Append(SerialNumber).Append("\n");
        sb.Append("  ExtraDnsLabels: ").Append(ExtraDnsLabels).Append("\n");
        sb.Append("  Ephemeral: ").Append(Ephemeral).Append("\n");
        sb.Append("  LocalFlags: ").Append(LocalFlags).Append("\n");
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