


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
/// Nameserver
/// </summary>
[DataContract(Name = "Nameserver")]
public class Nameserver : IValidatableObject
{
    /// <summary>
    /// Nameserver Type
    /// </summary>
    /// <value>Nameserver Type</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum NsTypeEnum
    {
        /// <summary>
        /// Enum Udp for value: udp
        /// </summary>
        [EnumMember(Value = "udp")]
        Udp = 1
    }


    /// <summary>
    /// Nameserver Type
    /// </summary>
    /// <value>Nameserver Type</value>
    /*
    <example>udp</example>
    */
    [JsonPropertyName("ns_type")]
    public NsTypeEnum NsType { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="Nameserver" /> class.
    /// </summary>
    [JsonConstructor]
    protected Nameserver() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="Nameserver" /> class.
    /// </summary>
    /// <param name="ip">Nameserver IP (required).</param>
    /// <param name="nsType">Nameserver Type (required).</param>
    /// <param name="port">Nameserver Port (required).</param>
    public Nameserver(string ip = null, NsTypeEnum nsType = default, int port = 0)
    {
        // to ensure "ip" is required (not null)
        ArgumentNullException.ThrowIfNull(ip);
        this.Ip = ip;
        this.NsType = nsType;
        this.Port = port;
    }

    /// <summary>
    /// Nameserver IP
    /// </summary>
    /// <value>Nameserver IP</value>
    /*
    <example>8.8.8.8</example>
    */
    [JsonPropertyName("ip")]
    public string Ip { get; set; }

    /// <summary>
    /// Nameserver Port
    /// </summary>
    /// <value>Nameserver Port</value>
    /*
    <example>53</example>
    */
    [JsonPropertyName("port")]
    public int Port { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class Nameserver {\n");
        sb.Append("  Ip: ").Append(Ip).Append("\n");
        sb.Append("  NsType: ").Append(NsType).Append("\n");
        sb.Append("  Port: ").Append(Port).Append("\n");
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