


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
/// Posture Check for binaries exist and are running in the peer’s system
/// </summary>
[DataContract(Name = "ProcessCheck")]
public class ProcessCheck : IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ProcessCheck" /> class.
    /// </summary>
    [JsonConstructor]
    protected ProcessCheck() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ProcessCheck" /> class.
    /// </summary>
    /// <param name="processes">processes (required).</param>
    public ProcessCheck(List<Process> processes = null)
    {
        // to ensure "processes" is required (not null)
        ArgumentNullException.ThrowIfNull(processes);
        this.Processes = processes;
    }

    /// <summary>
    /// Gets or Sets Processes
    /// </summary>
    [JsonPropertyName("processes")]
    public List<Process> Processes { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class ProcessCheck {\n");
        sb.Append("  Processes: ").Append(Processes).Append("\n");
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