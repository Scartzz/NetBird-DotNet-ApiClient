


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
/// JobRequest
/// </summary>
[DataContract(Name = "JobRequest")]
public class JobRequest : IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="JobRequest" /> class.
    /// </summary>
    [JsonConstructor]
    protected JobRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="JobRequest" /> class.
    /// </summary>
    /// <param name="workload">workload (required).</param>
    public JobRequest(BundleWorkloadRequest workload = null)
    {
        // to ensure "workload" is required (not null)
        ArgumentNullException.ThrowIfNull(workload);
        this.Workload = workload;
    }

    /// <summary>
    /// Gets or Sets Workload
    /// </summary>
    [JsonPropertyName("workload")]
    public BundleWorkloadRequest Workload { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class JobRequest {\n");
        sb.Append("  Workload: ").Append(Workload).Append("\n");
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