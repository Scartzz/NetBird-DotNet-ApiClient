


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
/// IngressPortAllocationRequestDirectPort
/// </summary>
[DataContract(Name = "IngressPortAllocationRequestDirectPort")]
public class IngressPortAllocationRequestDirectPort : IValidatableObject
{
    /// <summary>
    /// The protocol accepted by the port
    /// </summary>
    /// <value>The protocol accepted by the port</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ProtocolEnum
    {
        /// <summary>
        /// Enum Tcp for value: tcp
        /// </summary>
        [EnumMember(Value = "tcp")]
        Tcp = 1,

        /// <summary>
        /// Enum Udp for value: udp
        /// </summary>
        [EnumMember(Value = "udp")]
        Udp = 2,

        /// <summary>
        /// Enum TcpUdp for value: tcp/udp
        /// </summary>
        [EnumMember(Value = "tcp/udp")]
        TcpUdp = 3
    }


    /// <summary>
    /// The protocol accepted by the port
    /// </summary>
    /// <value>The protocol accepted by the port</value>
    /*
    <example>udp</example>
    */
    [JsonPropertyName("protocol")]
    public ProtocolEnum Protocol { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="IngressPortAllocationRequestDirectPort" /> class.
    /// </summary>
    [JsonConstructor]
    protected IngressPortAllocationRequestDirectPort() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="IngressPortAllocationRequestDirectPort" /> class.
    /// </summary>
    /// <param name="count">The number of ports to be forwarded (required).</param>
    /// <param name="protocol">The protocol accepted by the port (required).</param>
    public IngressPortAllocationRequestDirectPort(int count = 0, ProtocolEnum protocol = default)
    {
        this.Count = count;
        this.Protocol = protocol;
    }

    /// <summary>
    /// The number of ports to be forwarded
    /// </summary>
    /// <value>The number of ports to be forwarded</value>
    /*
    <example>5</example>
    */
    [JsonPropertyName("count")]
    public int Count { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class IngressPortAllocationRequestDirectPort {\n");
        sb.Append("  Count: ").Append(Count).Append("\n");
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