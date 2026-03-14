


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
/// Posture check with the kernel version
/// </summary>
[DataContract(Name = "MinKernelVersionCheck")]
public class MinKernelVersionCheck : IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="MinKernelVersionCheck" /> class.
    /// </summary>
    [JsonConstructor]
    protected MinKernelVersionCheck() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="MinKernelVersionCheck" /> class.
    /// </summary>
    /// <param name="minKernelVersion">Minimum acceptable version (required).</param>
    public MinKernelVersionCheck(string minKernelVersion = null)
    {
        // to ensure "minKernelVersion" is required (not null)
        ArgumentNullException.ThrowIfNull(minKernelVersion);
        this.MinKernelVersion = minKernelVersion;
    }

    /// <summary>
    /// Minimum acceptable version
    /// </summary>
    /// <value>Minimum acceptable version</value>
    /*
    <example>6.6.12</example>
    */
    [JsonPropertyName("min_kernel_version")]
    public string MinKernelVersion { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class MinKernelVersionCheck {\n");
        sb.Append("  MinKernelVersion: ").Append(MinKernelVersion).Append("\n");
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