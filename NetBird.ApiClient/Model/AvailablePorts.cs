


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
/// AvailablePorts
/// </summary>
[DataContract(Name = "AvailablePorts")]
public class AvailablePorts : IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AvailablePorts" /> class.
    /// </summary>
    [JsonConstructor]
    protected AvailablePorts() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="AvailablePorts" /> class.
    /// </summary>
    /// <param name="tcp">Number of available TCP  ports left on the ingress peer (required).</param>
    /// <param name="udp">Number of available UDP ports left on the ingress peer (required).</param>
    public AvailablePorts(int tcp = 0, int udp = 0)
    {
        this.Tcp = tcp;
        this.Udp = udp;
    }

    /// <summary>
    /// Number of available TCP  ports left on the ingress peer
    /// </summary>
    /// <value>Number of available TCP  ports left on the ingress peer</value>
    /*
    <example>45765</example>
    */
    [JsonPropertyName("tcp")]
    public int Tcp { get; set; }

    /// <summary>
    /// Number of available UDP ports left on the ingress peer
    /// </summary>
    /// <value>Number of available UDP ports left on the ingress peer</value>
    /*
    <example>50000</example>
    */
    [JsonPropertyName("udp")]
    public int Udp { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class AvailablePorts {\n");
        sb.Append("  Tcp: ").Append(Tcp).Append("\n");
        sb.Append("  Udp: ").Append(Udp).Append("\n");
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