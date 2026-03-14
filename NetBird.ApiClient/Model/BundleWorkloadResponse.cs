


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
/// BundleWorkloadResponse
/// </summary>
[DataContract(Name = "BundleWorkloadResponse")]
public class BundleWorkloadResponse : IValidatableObject
{

    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [JsonPropertyName("type")]
    public WorkloadType Type { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="BundleWorkloadResponse" /> class.
    /// </summary>
    [JsonConstructor]
    protected BundleWorkloadResponse() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="BundleWorkloadResponse" /> class.
    /// </summary>
    /// <param name="type">type (required).</param>
    /// <param name="parameters">parameters (required).</param>
    /// <param name="result">result (required).</param>
    public BundleWorkloadResponse(WorkloadType type = default, BundleParameters parameters = null, BundleResult result = null)
    {
        this.Type = type;
        // to ensure "parameters" is required (not null)
        ArgumentNullException.ThrowIfNull(parameters);
        this.Parameters = parameters;
        // to ensure "result" is required (not null)
        ArgumentNullException.ThrowIfNull(result);
        this.Result = result;
    }

    /// <summary>
    /// Gets or Sets Parameters
    /// </summary>
    [JsonPropertyName("parameters")]
    public BundleParameters Parameters { get; set; }

    /// <summary>
    /// Gets or Sets Result
    /// </summary>
    [JsonPropertyName("result")]
    public BundleResult Result { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class BundleWorkloadResponse {\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Parameters: ").Append(Parameters).Append("\n");
        sb.Append("  Result: ").Append(Result).Append("\n");
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