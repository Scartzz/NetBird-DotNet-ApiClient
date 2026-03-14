


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
/// ServiceTarget
/// </summary>
[DataContract(Name = "ServiceTarget")]
public class ServiceTarget : IValidatableObject
{
    /// <summary>
    /// Target type
    /// </summary>
    /// <value>Target type</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TargetTypeEnum
    {
        /// <summary>
        /// Enum Peer for value: peer
        /// </summary>
        [EnumMember(Value = "peer")]
        Peer = 1,

        /// <summary>
        /// Enum Host for value: host
        /// </summary>
        [EnumMember(Value = "host")]
        Host = 2,

        /// <summary>
        /// Enum Domain for value: domain
        /// </summary>
        [EnumMember(Value = "domain")]
        Domain = 3,

        /// <summary>
        /// Enum Subnet for value: subnet
        /// </summary>
        [EnumMember(Value = "subnet")]
        Subnet = 4
    }


    /// <summary>
    /// Target type
    /// </summary>
    /// <value>Target type</value>
    [JsonPropertyName("target_type")]
    public TargetTypeEnum TargetType { get; set; }
    /// <summary>
    /// Protocol to use when connecting to the backend
    /// </summary>
    /// <value>Protocol to use when connecting to the backend</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ProtocolEnum
    {
        /// <summary>
        /// Enum Http for value: http
        /// </summary>
        [EnumMember(Value = "http")]
        Http = 1,

        /// <summary>
        /// Enum Https for value: https
        /// </summary>
        [EnumMember(Value = "https")]
        Https = 2,

        /// <summary>
        /// Enum Tcp for value: tcp
        /// </summary>
        [EnumMember(Value = "tcp")]
        Tcp = 3,

        /// <summary>
        /// Enum Udp for value: udp
        /// </summary>
        [EnumMember(Value = "udp")]
        Udp = 4
    }


    /// <summary>
    /// Protocol to use when connecting to the backend
    /// </summary>
    /// <value>Protocol to use when connecting to the backend</value>
    [JsonPropertyName("protocol")]
    public ProtocolEnum Protocol { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="ServiceTarget" /> class.
    /// </summary>
    [JsonConstructor]
    protected ServiceTarget() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ServiceTarget" /> class.
    /// </summary>
    /// <param name="targetId">Target ID (required).</param>
    /// <param name="targetType">Target type (required).</param>
    /// <param name="path">URL path prefix for this target (HTTP only).</param>
    /// <param name="protocol">Protocol to use when connecting to the backend (required).</param>
    /// <param name="host">Backend ip or domain for this target.</param>
    /// <param name="port">Backend port for this target (required).</param>
    /// <param name="enabled">Whether this target is enabled (required).</param>
    /// <param name="options">options.</param>
    public ServiceTarget(string targetId = null, TargetTypeEnum targetType = default, string path = null, ProtocolEnum protocol = default, string host = null, int port = 0, bool enabled = false, ServiceTargetOptions options = null)
    {
        // to ensure "targetId" is required (not null)
        ArgumentNullException.ThrowIfNull(targetId);
        this.TargetId = targetId;
        this.TargetType = targetType;
        this.Protocol = protocol;
        this.Port = port;
        this.Enabled = enabled;
        this.Path = path;
        this.Host = host;
        this.Options = options;
    }

    /// <summary>
    /// Target ID
    /// </summary>
    /// <value>Target ID</value>
    [JsonPropertyName("target_id")]
    public string TargetId { get; set; }

    /// <summary>
    /// URL path prefix for this target (HTTP only)
    /// </summary>
    /// <value>URL path prefix for this target (HTTP only)</value>
    [JsonPropertyName("path")]
    public string Path { get; set; }

    /// <summary>
    /// Backend ip or domain for this target
    /// </summary>
    /// <value>Backend ip or domain for this target</value>
    [JsonPropertyName("host")]
    public string Host { get; set; }

    /// <summary>
    /// Backend port for this target
    /// </summary>
    /// <value>Backend port for this target</value>
    [JsonPropertyName("port")]
    public int Port { get; set; }

    /// <summary>
    /// Whether this target is enabled
    /// </summary>
    /// <value>Whether this target is enabled</value>
    [JsonPropertyName("enabled")]
    public bool Enabled { get; set; }

    /// <summary>
    /// Gets or Sets Options
    /// </summary>
    [JsonPropertyName("options")]
    public ServiceTargetOptions Options { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class ServiceTarget {\n");
        sb.Append("  TargetId: ").Append(TargetId).Append("\n");
        sb.Append("  TargetType: ").Append(TargetType).Append("\n");
        sb.Append("  Path: ").Append(Path).Append("\n");
        sb.Append("  Protocol: ").Append(Protocol).Append("\n");
        sb.Append("  Host: ").Append(Host).Append("\n");
        sb.Append("  Port: ").Append(Port).Append("\n");
        sb.Append("  Enabled: ").Append(Enabled).Append("\n");
        sb.Append("  Options: ").Append(Options).Append("\n");
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
        // Port (int) maximum
        if (this.Port > (int)65535)
        {
            yield return new ValidationResult("Invalid value for Port, must be a value less than or equal to 65535.", new [] { "Port" });
        }

        // Port (int) minimum
        if (this.Port < (int)1)
        {
            yield return new ValidationResult("Invalid value for Port, must be a value greater than or equal to 1.", new [] { "Port" });
        }

        yield break;
    }
}