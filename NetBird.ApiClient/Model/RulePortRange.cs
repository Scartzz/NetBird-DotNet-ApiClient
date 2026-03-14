


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
/// Policy rule affected ports range
/// </summary>
[DataContract(Name = "RulePortRange")]
public class RulePortRange : IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="RulePortRange" /> class.
    /// </summary>
    [JsonConstructor]
    protected RulePortRange() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="RulePortRange" /> class.
    /// </summary>
    /// <param name="start">The starting port of the range (required).</param>
    /// <param name="end">The ending port of the range (required).</param>
    public RulePortRange(int start = 0, int end = 0)
    {
        this.Start = start;
        this.End = end;
    }

    /// <summary>
    /// The starting port of the range
    /// </summary>
    /// <value>The starting port of the range</value>
    /*
    <example>80</example>
    */
    [JsonPropertyName("start")]
    public int Start { get; set; }

    /// <summary>
    /// The ending port of the range
    /// </summary>
    /// <value>The ending port of the range</value>
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
        sb.Append("class RulePortRange {\n");
        sb.Append("  Start: ").Append(Start).Append("\n");
        sb.Append("  End: ").Append(End).Append("\n");
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