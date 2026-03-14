


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
/// PolicyMinimum
/// </summary>
[DataContract(Name = "PolicyMinimum")]
public class PolicyMinimum : IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PolicyMinimum" /> class.
    /// </summary>
    [JsonConstructor]
    protected PolicyMinimum() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="PolicyMinimum" /> class.
    /// </summary>
    /// <param name="name">Policy name identifier (required).</param>
    /// <param name="description">Policy friendly description.</param>
    /// <param name="enabled">Policy status (required).</param>
    public PolicyMinimum(string name = null, string description = null, bool enabled = false)
    {
        // to ensure "name" is required (not null)
        ArgumentNullException.ThrowIfNull(name);
        this.Name = name;
        this.Enabled = enabled;
        this.Description = description;
    }

    /// <summary>
    /// Policy name identifier
    /// </summary>
    /// <value>Policy name identifier</value>
    /*
    <example>ch8i4ug6lnn4g9hqv7mg</example>
    */
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// Policy friendly description
    /// </summary>
    /// <value>Policy friendly description</value>
    /*
    <example>This is a default policy that allows connections between all the resources</example>
    */
    [JsonPropertyName("description")]
    public string Description { get; set; }

    /// <summary>
    /// Policy status
    /// </summary>
    /// <value>Policy status</value>
    /*
    <example>true</example>
    */
    [JsonPropertyName("enabled")]
    public bool Enabled { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class PolicyMinimum {\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  Enabled: ").Append(Enabled).Append("\n");
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