


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
/// IngressPortAllocationRequestPortRange
/// </summary>
[DataContract(Name = "IngressPortAllocationRequestPortRange")]
public class IngressPortAllocationRequestPortRange : IValidatableObject
{
    /// <summary>
    /// The protocol accepted by the port range
    /// </summary>
    /// <value>The protocol accepted by the port range</value>
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
    /// The protocol accepted by the port range
    /// </summary>
    /// <value>The protocol accepted by the port range</value>
    /*
    <example>tcp</example>
    */
    [JsonPropertyName("protocol")]
    public ProtocolEnum Protocol { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="IngressPortAllocationRequestPortRange" /> class.
    /// </summary>
    [JsonConstructor]
    protected IngressPortAllocationRequestPortRange() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="IngressPortAllocationRequestPortRange" /> class.
    /// </summary>
    /// <param name="start">The starting port of the range of forwarded ports (required).</param>
    /// <param name="end">The ending port of the range of forwarded ports (required).</param>
    /// <param name="protocol">The protocol accepted by the port range (required).</param>
    public IngressPortAllocationRequestPortRange(int start = 0, int end = 0, ProtocolEnum protocol = default)
    {
        this.Start = start;
        this.End = end;
        this.Protocol = protocol;
    }

    /// <summary>
    /// The starting port of the range of forwarded ports
    /// </summary>
    /// <value>The starting port of the range of forwarded ports</value>
    /*
    <example>80</example>
    */
    [JsonPropertyName("start")]
    public int Start { get; set; }

    /// <summary>
    /// The ending port of the range of forwarded ports
    /// </summary>
    /// <value>The ending port of the range of forwarded ports</value>
    /*
    <example>320</example>
    */
    [JsonPropertyName("end")]
    public int End { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class IngressPortAllocationRequestPortRange {\n");
        sb.Append("  Start: ").Append(Start).Append("\n");
        sb.Append("  End: ").Append(End).Append("\n");
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