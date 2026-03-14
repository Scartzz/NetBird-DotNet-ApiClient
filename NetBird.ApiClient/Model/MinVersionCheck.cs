


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
/// Posture check for the version of operating system
/// </summary>
[DataContract(Name = "MinVersionCheck")]
public class MinVersionCheck : IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="MinVersionCheck" /> class.
    /// </summary>
    [JsonConstructor]
    protected MinVersionCheck() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="MinVersionCheck" /> class.
    /// </summary>
    /// <param name="minVersion">Minimum acceptable version (required).</param>
    public MinVersionCheck(string minVersion = null)
    {
        // to ensure "minVersion" is required (not null)
        ArgumentNullException.ThrowIfNull(minVersion);
        this.MinVersion = minVersion;
    }

    /// <summary>
    /// Minimum acceptable version
    /// </summary>
    /// <value>Minimum acceptable version</value>
    /*
    <example>14.3</example>
    */
    [JsonPropertyName("min_version")]
    public string MinVersion { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class MinVersionCheck {\n");
        sb.Append("  MinVersion: ").Append(MinVersion).Append("\n");
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