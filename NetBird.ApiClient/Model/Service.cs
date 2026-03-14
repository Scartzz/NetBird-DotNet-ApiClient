


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
/// Service
/// </summary>
[DataContract(Name = "Service")]
public class Service : IValidatableObject
{
    /// <summary>
    /// Service mode. \&quot;http\&quot; for L7 reverse proxy, \&quot;tcp\&quot;/\&quot;udp\&quot;/\&quot;tls\&quot; for L4 passthrough.
    /// </summary>
    /// <value>Service mode. \&quot;http\&quot; for L7 reverse proxy, \&quot;tcp\&quot;/\&quot;udp\&quot;/\&quot;tls\&quot; for L4 passthrough.</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ModeEnum
    {
        /// <summary>
        /// Enum Http for value: http
        /// </summary>
        [EnumMember(Value = "http")]
        Http = 1,

        /// <summary>
        /// Enum Tcp for value: tcp
        /// </summary>
        [EnumMember(Value = "tcp")]
        Tcp = 2,

        /// <summary>
        /// Enum Udp for value: udp
        /// </summary>
        [EnumMember(Value = "udp")]
        Udp = 3,

        /// <summary>
        /// Enum Tls for value: tls
        /// </summary>
        [EnumMember(Value = "tls")]
        Tls = 4
    }


    /// <summary>
    /// Service mode. \&quot;http\&quot; for L7 reverse proxy, \&quot;tcp\&quot;/\&quot;udp\&quot;/\&quot;tls\&quot; for L4 passthrough.
    /// </summary>
    /// <value>Service mode. \&quot;http\&quot; for L7 reverse proxy, \&quot;tcp\&quot;/\&quot;udp\&quot;/\&quot;tls\&quot; for L4 passthrough.</value>
    [JsonPropertyName("mode")]
    public ModeEnum? Mode { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="Service" /> class.
    /// </summary>
    [JsonConstructor]
    protected Service() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="Service" /> class.
    /// </summary>
    /// <param name="id">Service ID (required).</param>
    /// <param name="name">Service name (required).</param>
    /// <param name="domain">Domain for the service (required).</param>
    /// <param name="mode">Service mode. \&quot;http\&quot; for L7 reverse proxy, \&quot;tcp\&quot;/\&quot;udp\&quot;/\&quot;tls\&quot; for L4 passthrough. (default to ModeEnum.Http).</param>
    /// <param name="listenPort">Port the proxy listens on (L4/TLS only).</param>
    /// <param name="proxyCluster">The proxy cluster handling this service (derived from domain).</param>
    /// <param name="targets">List of target backends for this service (required).</param>
    /// <param name="enabled">Whether the service is enabled (required).</param>
    /// <param name="passHostHeader">When true, the original client Host header is passed through to the backend instead of being rewritten to the backend&#39;s address.</param>
    /// <param name="rewriteRedirects">When true, Location headers in backend responses are rewritten to replace the backend address with the public-facing domain.</param>
    /// <param name="auth">auth (required).</param>
    /// <param name="meta">meta (required).</param>
    public Service(string id = null, string name = null, string domain = null, ModeEnum? mode = ModeEnum.Http, int listenPort = 0, string proxyCluster = null, List<ServiceTarget> targets = null, bool enabled = false, bool passHostHeader = false, bool rewriteRedirects = false, ServiceAuthConfig auth = null, ServiceMeta meta = null)
    {
        // to ensure "id" is required (not null)
        ArgumentNullException.ThrowIfNull(id);
        this.Id = id;
        // to ensure "name" is required (not null)
        ArgumentNullException.ThrowIfNull(name);
        this.Name = name;
        // to ensure "domain" is required (not null)
        ArgumentNullException.ThrowIfNull(domain);
        this.Domain = domain;
        // to ensure "targets" is required (not null)
        ArgumentNullException.ThrowIfNull(targets);
        this.Targets = targets;
        this.Enabled = enabled;
        // to ensure "auth" is required (not null)
        ArgumentNullException.ThrowIfNull(auth);
        this.Auth = auth;
        // to ensure "meta" is required (not null)
        ArgumentNullException.ThrowIfNull(meta);
        this.Meta = meta;
        this.Mode = mode;
        this.ListenPort = listenPort;
        this.ProxyCluster = proxyCluster;
        this.PassHostHeader = passHostHeader;
        this.RewriteRedirects = rewriteRedirects;
    }

    /// <summary>
    /// Service ID
    /// </summary>
    /// <value>Service ID</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }

    /// <summary>
    /// Service name
    /// </summary>
    /// <value>Service name</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// Domain for the service
    /// </summary>
    /// <value>Domain for the service</value>
    [JsonPropertyName("domain")]
    public string Domain { get; set; }

    /// <summary>
    /// Port the proxy listens on (L4/TLS only)
    /// </summary>
    /// <value>Port the proxy listens on (L4/TLS only)</value>
    [JsonPropertyName("listen_port")]
    public int ListenPort { get; set; }

    /// <summary>
    /// Whether the listen port was auto-assigned
    /// </summary>
    /// <value>Whether the listen port was auto-assigned</value>
    [JsonPropertyName("port_auto_assigned")]
    public bool PortAutoAssigned { get; private set; }

    /// <summary>
    /// Returns false as PortAutoAssigned should not be serialized given that it's read-only.
    /// </summary>
    /// <returns>false (boolean)</returns>
    public bool ShouldSerializePortAutoAssigned()
    {
        return false;
    }
    /// <summary>
    /// The proxy cluster handling this service (derived from domain)
    /// </summary>
    /// <value>The proxy cluster handling this service (derived from domain)</value>
    /*
    <example>eu.proxy.netbird.io</example>
    */
    [JsonPropertyName("proxy_cluster")]
    public string ProxyCluster { get; set; }

    /// <summary>
    /// List of target backends for this service
    /// </summary>
    /// <value>List of target backends for this service</value>
    [JsonPropertyName("targets")]
    public List<ServiceTarget> Targets { get; set; }

    /// <summary>
    /// Whether the service is enabled
    /// </summary>
    /// <value>Whether the service is enabled</value>
    [JsonPropertyName("enabled")]
    public bool Enabled { get; set; }

    /// <summary>
    /// When true, the original client Host header is passed through to the backend instead of being rewritten to the backend&#39;s address
    /// </summary>
    /// <value>When true, the original client Host header is passed through to the backend instead of being rewritten to the backend&#39;s address</value>
    [JsonPropertyName("pass_host_header")]
    public bool PassHostHeader { get; set; }

    /// <summary>
    /// When true, Location headers in backend responses are rewritten to replace the backend address with the public-facing domain
    /// </summary>
    /// <value>When true, Location headers in backend responses are rewritten to replace the backend address with the public-facing domain</value>
    [JsonPropertyName("rewrite_redirects")]
    public bool RewriteRedirects { get; set; }

    /// <summary>
    /// Gets or Sets Auth
    /// </summary>
    [JsonPropertyName("auth")]
    public ServiceAuthConfig Auth { get; set; }

    /// <summary>
    /// Gets or Sets Meta
    /// </summary>
    [JsonPropertyName("meta")]
    public ServiceMeta Meta { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class Service {\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Domain: ").Append(Domain).Append("\n");
        sb.Append("  Mode: ").Append(Mode).Append("\n");
        sb.Append("  ListenPort: ").Append(ListenPort).Append("\n");
        sb.Append("  PortAutoAssigned: ").Append(PortAutoAssigned).Append("\n");
        sb.Append("  ProxyCluster: ").Append(ProxyCluster).Append("\n");
        sb.Append("  Targets: ").Append(Targets).Append("\n");
        sb.Append("  Enabled: ").Append(Enabled).Append("\n");
        sb.Append("  PassHostHeader: ").Append(PassHostHeader).Append("\n");
        sb.Append("  RewriteRedirects: ").Append(RewriteRedirects).Append("\n");
        sb.Append("  Auth: ").Append(Auth).Append("\n");
        sb.Append("  Meta: ").Append(Meta).Append("\n");
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
        // ListenPort (int) maximum
        if (this.ListenPort > (int)65535)
        {
            yield return new ValidationResult("Invalid value for ListenPort, must be a value less than or equal to 65535.", new [] { "ListenPort" });
        }

        // ListenPort (int) minimum
        if (this.ListenPort < (int)0)
        {
            yield return new ValidationResult("Invalid value for ListenPort, must be a value greater than or equal to 0.", new [] { "ListenPort" });
        }

        yield break;
    }
}