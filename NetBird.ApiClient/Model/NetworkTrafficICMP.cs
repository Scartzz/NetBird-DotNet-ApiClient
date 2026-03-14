


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
/// NetworkTrafficICMP
/// </summary>
[DataContract(Name = "NetworkTrafficICMP")]
public class NetworkTrafficICMP : IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="NetworkTrafficICMP" /> class.
    /// </summary>
    [JsonConstructor]
    protected NetworkTrafficICMP() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="NetworkTrafficICMP" /> class.
    /// </summary>
    /// <param name="type">ICMP type (if applicable). (required).</param>
    /// <param name="code">ICMP code (if applicable). (required).</param>
    public NetworkTrafficICMP(int type = 0, int code = 0)
    {
        this.Type = type;
        this.Code = code;
    }

    /// <summary>
    /// ICMP type (if applicable).
    /// </summary>
    /// <value>ICMP type (if applicable).</value>
    /*
    <example>8</example>
    */
    [JsonPropertyName("type")]
    public int Type { get; set; }

    /// <summary>
    /// ICMP code (if applicable).
    /// </summary>
    /// <value>ICMP code (if applicable).</value>
    /*
    <example>0</example>
    */
    [JsonPropertyName("code")]
    public int Code { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class NetworkTrafficICMP {\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Code: ").Append(Code).Append("\n");
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