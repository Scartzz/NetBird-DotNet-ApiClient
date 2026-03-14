


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
/// ProxyAccessLog
/// </summary>
[DataContract(Name = "ProxyAccessLog")]
public class ProxyAccessLog : IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ProxyAccessLog" /> class.
    /// </summary>
    [JsonConstructor]
    protected ProxyAccessLog() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ProxyAccessLog" /> class.
    /// </summary>
    /// <param name="id">Unique identifier for the access log entry (required).</param>
    /// <param name="serviceId">ID of the service that handled the request (required).</param>
    /// <param name="timestamp">Timestamp when the request was made (required).</param>
    /// <param name="method">HTTP method of the request (required).</param>
    /// <param name="host">Host header of the request (required).</param>
    /// <param name="path">Path of the request (required).</param>
    /// <param name="durationMs">Duration of the request in milliseconds (required).</param>
    /// <param name="statusCode">HTTP status code returned (required).</param>
    /// <param name="sourceIp">Source IP address of the request.</param>
    /// <param name="reason">Reason for the request result (e.g., authentication failure).</param>
    /// <param name="userId">ID of the authenticated user, if applicable.</param>
    /// <param name="authMethodUsed">Authentication method used (e.g., password, pin, oidc).</param>
    /// <param name="countryCode">Country code from geolocation.</param>
    /// <param name="cityName">City name from geolocation.</param>
    /// <param name="bytesUpload">Bytes uploaded (request body size) (required).</param>
    /// <param name="bytesDownload">Bytes downloaded (response body size) (required).</param>
    /// <param name="protocol">Protocol type: http, tcp, or udp.</param>
    public ProxyAccessLog(string id = null, string serviceId = null, DateTimeOffset timestamp = default, string method = null, string host = null, string path = null, int durationMs = 0, int statusCode = 0, string sourceIp = null, string reason = null, string userId = null, string authMethodUsed = null, string countryCode = null, string cityName = null, long bytesUpload = 0, long bytesDownload = 0, string protocol = null)
    {
        // to ensure "id" is required (not null)
        ArgumentNullException.ThrowIfNull(id);
        this.Id = id;
        // to ensure "serviceId" is required (not null)
        ArgumentNullException.ThrowIfNull(serviceId);
        this.ServiceId = serviceId;
        this.Timestamp = timestamp;
        // to ensure "method" is required (not null)
        ArgumentNullException.ThrowIfNull(method);
        this.Method = method;
        // to ensure "host" is required (not null)
        ArgumentNullException.ThrowIfNull(host);
        this.Host = host;
        // to ensure "path" is required (not null)
        ArgumentNullException.ThrowIfNull(path);
        this.Path = path;
        this.DurationMs = durationMs;
        this.StatusCode = statusCode;
        this.BytesUpload = bytesUpload;
        this.BytesDownload = bytesDownload;
        this.SourceIp = sourceIp;
        this.Reason = reason;
        this.UserId = userId;
        this.AuthMethodUsed = authMethodUsed;
        this.CountryCode = countryCode;
        this.CityName = cityName;
        this.Protocol = protocol;
    }

    /// <summary>
    /// Unique identifier for the access log entry
    /// </summary>
    /// <value>Unique identifier for the access log entry</value>
    /*
    <example>ch8i4ug6lnn4g9hqv7m0</example>
    */
    [JsonPropertyName("id")]
    public string Id { get; set; }

    /// <summary>
    /// ID of the service that handled the request
    /// </summary>
    /// <value>ID of the service that handled the request</value>
    /*
    <example>ch8i4ug6lnn4g9hqv7m0</example>
    */
    [JsonPropertyName("service_id")]
    public string ServiceId { get; set; }

    /// <summary>
    /// Timestamp when the request was made
    /// </summary>
    /// <value>Timestamp when the request was made</value>
    /*
    <example>2024-01-31T15:30:00Z</example>
    */
    [JsonPropertyName("timestamp")]
    public DateTimeOffset Timestamp { get; set; }

    /// <summary>
    /// HTTP method of the request
    /// </summary>
    /// <value>HTTP method of the request</value>
    /*
    <example>GET</example>
    */
    [JsonPropertyName("method")]
    public string Method { get; set; }

    /// <summary>
    /// Host header of the request
    /// </summary>
    /// <value>Host header of the request</value>
    /*
    <example>example.com</example>
    */
    [JsonPropertyName("host")]
    public string Host { get; set; }

    /// <summary>
    /// Path of the request
    /// </summary>
    /// <value>Path of the request</value>
    /*
    <example>users</example>
    */
    [JsonPropertyName("path")]
    public string Path { get; set; }

    /// <summary>
    /// Duration of the request in milliseconds
    /// </summary>
    /// <value>Duration of the request in milliseconds</value>
    /*
    <example>150</example>
    */
    [JsonPropertyName("duration_ms")]
    public int DurationMs { get; set; }

    /// <summary>
    /// HTTP status code returned
    /// </summary>
    /// <value>HTTP status code returned</value>
    /*
    <example>200</example>
    */
    [JsonPropertyName("status_code")]
    public int StatusCode { get; set; }

    /// <summary>
    /// Source IP address of the request
    /// </summary>
    /// <value>Source IP address of the request</value>
    /*
    <example>192.168.1.100</example>
    */
    [JsonPropertyName("source_ip")]
    public string SourceIp { get; set; }

    /// <summary>
    /// Reason for the request result (e.g., authentication failure)
    /// </summary>
    /// <value>Reason for the request result (e.g., authentication failure)</value>
    /*
    <example>Authentication failed</example>
    */
    [JsonPropertyName("reason")]
    public string Reason { get; set; }

    /// <summary>
    /// ID of the authenticated user, if applicable
    /// </summary>
    /// <value>ID of the authenticated user, if applicable</value>
    /*
    <example>user-123</example>
    */
    [JsonPropertyName("user_id")]
    public string UserId { get; set; }

    /// <summary>
    /// Authentication method used (e.g., password, pin, oidc)
    /// </summary>
    /// <value>Authentication method used (e.g., password, pin, oidc)</value>
    /*
    <example>oidc</example>
    */
    [JsonPropertyName("auth_method_used")]
    public string AuthMethodUsed { get; set; }

    /// <summary>
    /// Country code from geolocation
    /// </summary>
    /// <value>Country code from geolocation</value>
    /*
    <example>US</example>
    */
    [JsonPropertyName("country_code")]
    public string CountryCode { get; set; }

    /// <summary>
    /// City name from geolocation
    /// </summary>
    /// <value>City name from geolocation</value>
    /*
    <example>San Francisco</example>
    */
    [JsonPropertyName("city_name")]
    public string CityName { get; set; }

    /// <summary>
    /// Bytes uploaded (request body size)
    /// </summary>
    /// <value>Bytes uploaded (request body size)</value>
    /*
    <example>1024</example>
    */
    [JsonPropertyName("bytes_upload")]
    public long BytesUpload { get; set; }

    /// <summary>
    /// Bytes downloaded (response body size)
    /// </summary>
    /// <value>Bytes downloaded (response body size)</value>
    /*
    <example>8192</example>
    */
    [JsonPropertyName("bytes_download")]
    public long BytesDownload { get; set; }

    /// <summary>
    /// Protocol type: http, tcp, or udp
    /// </summary>
    /// <value>Protocol type: http, tcp, or udp</value>
    /*
    <example>http</example>
    */
    [JsonPropertyName("protocol")]
    public string Protocol { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class ProxyAccessLog {\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  ServiceId: ").Append(ServiceId).Append("\n");
        sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
        sb.Append("  Method: ").Append(Method).Append("\n");
        sb.Append("  Host: ").Append(Host).Append("\n");
        sb.Append("  Path: ").Append(Path).Append("\n");
        sb.Append("  DurationMs: ").Append(DurationMs).Append("\n");
        sb.Append("  StatusCode: ").Append(StatusCode).Append("\n");
        sb.Append("  SourceIp: ").Append(SourceIp).Append("\n");
        sb.Append("  Reason: ").Append(Reason).Append("\n");
        sb.Append("  UserId: ").Append(UserId).Append("\n");
        sb.Append("  AuthMethodUsed: ").Append(AuthMethodUsed).Append("\n");
        sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
        sb.Append("  CityName: ").Append(CityName).Append("\n");
        sb.Append("  BytesUpload: ").Append(BytesUpload).Append("\n");
        sb.Append("  BytesDownload: ").Append(BytesDownload).Append("\n");
        sb.Append("  Protocol: ").Append(Protocol).Append("\n");
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