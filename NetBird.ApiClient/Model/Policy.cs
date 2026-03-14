


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
/// Policy
/// </summary>
[DataContract(Name = "Policy")]
public class Policy : IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Policy" /> class.
    /// </summary>
    [JsonConstructor]
    protected Policy() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="Policy" /> class.
    /// </summary>
    /// <param name="name">Policy name identifier (required).</param>
    /// <param name="description">Policy friendly description.</param>
    /// <param name="enabled">Policy status (required).</param>
    /// <param name="id">Policy ID.</param>
    /// <param name="sourcePostureChecks">Posture checks ID&#39;s applied to policy source groups (required).</param>
    /// <param name="rules">Policy rule object for policy UI editor (required).</param>
    public Policy(string name = null, string description = null, bool enabled = false, string id = null, List<string> sourcePostureChecks = null, List<PolicyRule> rules = null)
    {
        // to ensure "name" is required (not null)
        ArgumentNullException.ThrowIfNull(name);
        this.Name = name;
        this.Enabled = enabled;
        // to ensure "sourcePostureChecks" is required (not null)
        ArgumentNullException.ThrowIfNull(sourcePostureChecks);
        this.SourcePostureChecks = sourcePostureChecks;
        // to ensure "rules" is required (not null)
        ArgumentNullException.ThrowIfNull(rules);
        this.Rules = rules;
        this.Description = description;
        this.Id = id;
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
    /// Policy ID
    /// </summary>
    /// <value>Policy ID</value>
    /*
    <example>ch8i4ug6lnn4g9hqv7mg</example>
    */
    [JsonPropertyName("id")]
    public string Id { get; set; }

    /// <summary>
    /// Posture checks ID&#39;s applied to policy source groups
    /// </summary>
    /// <value>Posture checks ID&#39;s applied to policy source groups</value>
    [JsonPropertyName("source_posture_checks")]
    public List<string> SourcePostureChecks { get; set; }

    /// <summary>
    /// Policy rule object for policy UI editor
    /// </summary>
    /// <value>Policy rule object for policy UI editor</value>
    [JsonPropertyName("rules")]
    public List<PolicyRule> Rules { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class Policy {\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  Enabled: ").Append(Enabled).Append("\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  SourcePostureChecks: ").Append(SourcePostureChecks).Append("\n");
        sb.Append("  Rules: ").Append(Rules).Append("\n");
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