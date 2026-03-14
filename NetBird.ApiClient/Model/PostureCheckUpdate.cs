


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
/// PostureCheckUpdate
/// </summary>
[DataContract(Name = "PostureCheckUpdate")]
public class PostureCheckUpdate : IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PostureCheckUpdate" /> class.
    /// </summary>
    [JsonConstructor]
    protected PostureCheckUpdate() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="PostureCheckUpdate" /> class.
    /// </summary>
    /// <param name="name">Posture check name identifier (required).</param>
    /// <param name="description">Posture check friendly description (required).</param>
    /// <param name="checks">checks.</param>
    public PostureCheckUpdate(string name = null, string description = null, Checks checks = null)
    {
        // to ensure "name" is required (not null)
        ArgumentNullException.ThrowIfNull(name);
        this.Name = name;
        // to ensure "description" is required (not null)
        ArgumentNullException.ThrowIfNull(description);
        this.Description = description;
        this.Checks = checks;
    }

    /// <summary>
    /// Posture check name identifier
    /// </summary>
    /// <value>Posture check name identifier</value>
    /*
    <example>Default</example>
    */
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// Posture check friendly description
    /// </summary>
    /// <value>Posture check friendly description</value>
    /*
    <example>This checks if the peer is running required NetBird&#39;s version</example>
    */
    [JsonPropertyName("description")]
    public string Description { get; set; }

    /// <summary>
    /// Gets or Sets Checks
    /// </summary>
    [JsonPropertyName("checks")]
    public Checks Checks { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class PostureCheckUpdate {\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  Checks: ").Append(Checks).Append("\n");
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