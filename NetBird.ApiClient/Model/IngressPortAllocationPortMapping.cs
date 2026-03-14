


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
/// IngressPortAllocationPortMapping
/// </summary>
[DataContract(Name = "IngressPortAllocationPortMapping")]
public class IngressPortAllocationPortMapping : IValidatableObject
{
    /// <summary>
    /// Protocol accepted by the ports
    /// </summary>
    /// <value>Protocol accepted by the ports</value>
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
    /// Protocol accepted by the ports
    /// </summary>
    /// <value>Protocol accepted by the ports</value>
    /*
    <example>tcp</example>
    */
    [JsonPropertyName("protocol")]
    public ProtocolEnum Protocol { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="IngressPortAllocationPortMapping" /> class.
    /// </summary>
    [JsonConstructor]
    protected IngressPortAllocationPortMapping() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="IngressPortAllocationPortMapping" /> class.
    /// </summary>
    /// <param name="translatedStart">The starting port of the translated range of forwarded ports (required).</param>
    /// <param name="translatedEnd">The ending port of the translated range of forwarded ports (required).</param>
    /// <param name="ingressStart">The starting port of the range of ingress ports mapped to the forwarded ports (required).</param>
    /// <param name="ingressEnd">The ending port of the range of ingress ports mapped to the forwarded ports (required).</param>
    /// <param name="protocol">Protocol accepted by the ports (required).</param>
    public IngressPortAllocationPortMapping(int translatedStart = 0, int translatedEnd = 0, int ingressStart = 0, int ingressEnd = 0, ProtocolEnum protocol = default)
    {
        this.TranslatedStart = translatedStart;
        this.TranslatedEnd = translatedEnd;
        this.IngressStart = ingressStart;
        this.IngressEnd = ingressEnd;
        this.Protocol = protocol;
    }

    /// <summary>
    /// The starting port of the translated range of forwarded ports
    /// </summary>
    /// <value>The starting port of the translated range of forwarded ports</value>
    /*
    <example>80</example>
    */
    [JsonPropertyName("translated_start")]
    public int TranslatedStart { get; set; }

    /// <summary>
    /// The ending port of the translated range of forwarded ports
    /// </summary>
    /// <value>The ending port of the translated range of forwarded ports</value>
    /*
    <example>320</example>
    */
    [JsonPropertyName("translated_end")]
    public int TranslatedEnd { get; set; }

    /// <summary>
    /// The starting port of the range of ingress ports mapped to the forwarded ports
    /// </summary>
    /// <value>The starting port of the range of ingress ports mapped to the forwarded ports</value>
    /*
    <example>1080</example>
    */
    [JsonPropertyName("ingress_start")]
    public int IngressStart { get; set; }

    /// <summary>
    /// The ending port of the range of ingress ports mapped to the forwarded ports
    /// </summary>
    /// <value>The ending port of the range of ingress ports mapped to the forwarded ports</value>
    /*
    <example>1320</example>
    */
    [JsonPropertyName("ingress_end")]
    public int IngressEnd { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class IngressPortAllocationPortMapping {\n");
        sb.Append("  TranslatedStart: ").Append(TranslatedStart).Append("\n");
        sb.Append("  TranslatedEnd: ").Append(TranslatedEnd).Append("\n");
        sb.Append("  IngressStart: ").Append(IngressStart).Append("\n");
        sb.Append("  IngressEnd: ").Append(IngressEnd).Append("\n");
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