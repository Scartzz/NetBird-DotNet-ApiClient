


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
/// ServiceTargetOptions
/// </summary>
[DataContract(Name = "ServiceTargetOptions")]
public class ServiceTargetOptions : IValidatableObject
{
    /// <summary>
    /// Controls how the request path is rewritten before forwarding to the backend. Default strips the matched prefix. \&quot;preserve\&quot; keeps the full original request path.
    /// </summary>
    /// <value>Controls how the request path is rewritten before forwarding to the backend. Default strips the matched prefix. \&quot;preserve\&quot; keeps the full original request path.</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum PathRewriteEnum
    {
        /// <summary>
        /// Enum Preserve for value: preserve
        /// </summary>
        [EnumMember(Value = "preserve")]
        Preserve = 1
    }


    /// <summary>
    /// Controls how the request path is rewritten before forwarding to the backend. Default strips the matched prefix. \&quot;preserve\&quot; keeps the full original request path.
    /// </summary>
    /// <value>Controls how the request path is rewritten before forwarding to the backend. Default strips the matched prefix. \&quot;preserve\&quot; keeps the full original request path.</value>
    [JsonPropertyName("path_rewrite")]
    public PathRewriteEnum? PathRewrite { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="ServiceTargetOptions" /> class.
    /// </summary>
    /// <param name="skipTlsVerify">Skip TLS certificate verification for this backend.</param>
    /// <param name="requestTimeout">Per-target response timeout as a Go duration string (e.g. \&quot;30s\&quot;, \&quot;2m\&quot;).</param>
    /// <param name="pathRewrite">Controls how the request path is rewritten before forwarding to the backend. Default strips the matched prefix. \&quot;preserve\&quot; keeps the full original request path..</param>
    /// <param name="customHeaders">Extra headers sent to the backend. Hop-by-hop and proxy-managed headers (Host, Connection, Transfer-Encoding, etc.) are rejected..</param>
    /// <param name="proxyProtocol">Send PROXY Protocol v2 header to this backend (TCP/TLS only).</param>
    /// <param name="sessionIdleTimeout">Idle timeout before a UDP session is reaped, as a Go duration string (e.g. \&quot;30s\&quot;, \&quot;2m\&quot;). Maximum 10m..</param>
    public ServiceTargetOptions(bool skipTlsVerify = false, string requestTimeout = null, PathRewriteEnum? pathRewrite = null, Dictionary<string, string> customHeaders = null, bool proxyProtocol = false, string sessionIdleTimeout = null)
    {
        this.SkipTlsVerify = skipTlsVerify;
        this.RequestTimeout = requestTimeout;
        this.PathRewrite = pathRewrite;
        this.CustomHeaders = customHeaders;
        this.ProxyProtocol = proxyProtocol;
        this.SessionIdleTimeout = sessionIdleTimeout;
    }

    /// <summary>
    /// Skip TLS certificate verification for this backend
    /// </summary>
    /// <value>Skip TLS certificate verification for this backend</value>
    [JsonPropertyName("skip_tls_verify")]
    public bool SkipTlsVerify { get; set; }

    /// <summary>
    /// Per-target response timeout as a Go duration string (e.g. \&quot;30s\&quot;, \&quot;2m\&quot;)
    /// </summary>
    /// <value>Per-target response timeout as a Go duration string (e.g. \&quot;30s\&quot;, \&quot;2m\&quot;)</value>
    [JsonPropertyName("request_timeout")]
    public string RequestTimeout { get; set; }

    /// <summary>
    /// Extra headers sent to the backend. Hop-by-hop and proxy-managed headers (Host, Connection, Transfer-Encoding, etc.) are rejected.
    /// </summary>
    /// <value>Extra headers sent to the backend. Hop-by-hop and proxy-managed headers (Host, Connection, Transfer-Encoding, etc.) are rejected.</value>
    [JsonPropertyName("custom_headers")]
    public Dictionary<string, string> CustomHeaders { get; set; }

    /// <summary>
    /// Send PROXY Protocol v2 header to this backend (TCP/TLS only)
    /// </summary>
    /// <value>Send PROXY Protocol v2 header to this backend (TCP/TLS only)</value>
    [JsonPropertyName("proxy_protocol")]
    public bool ProxyProtocol { get; set; }

    /// <summary>
    /// Idle timeout before a UDP session is reaped, as a Go duration string (e.g. \&quot;30s\&quot;, \&quot;2m\&quot;). Maximum 10m.
    /// </summary>
    /// <value>Idle timeout before a UDP session is reaped, as a Go duration string (e.g. \&quot;30s\&quot;, \&quot;2m\&quot;). Maximum 10m.</value>
    [JsonPropertyName("session_idle_timeout")]
    public string SessionIdleTimeout { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class ServiceTargetOptions {\n");
        sb.Append("  SkipTlsVerify: ").Append(SkipTlsVerify).Append("\n");
        sb.Append("  RequestTimeout: ").Append(RequestTimeout).Append("\n");
        sb.Append("  PathRewrite: ").Append(PathRewrite).Append("\n");
        sb.Append("  CustomHeaders: ").Append(CustomHeaders).Append("\n");
        sb.Append("  ProxyProtocol: ").Append(ProxyProtocol).Append("\n");
        sb.Append("  SessionIdleTimeout: ").Append(SessionIdleTimeout).Append("\n");
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