


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
/// These parameters control what gets included in the bundle and how it is processed.
/// </summary>
[DataContract(Name = "BundleParameters")]
public class BundleParameters : IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BundleParameters" /> class.
    /// </summary>
    [JsonConstructor]
    protected BundleParameters() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="BundleParameters" /> class.
    /// </summary>
    /// <param name="bundleFor">Whether to generate a bundle for the given timeframe. (required).</param>
    /// <param name="bundleForTime">Time period in minutes for which to generate the bundle. (required).</param>
    /// <param name="logFileCount">Maximum number of log files to include in the bundle. (required).</param>
    /// <param name="anonymize">Whether sensitive data should be anonymized in the bundle. (required).</param>
    public BundleParameters(bool bundleFor = false, int bundleForTime = 0, int logFileCount = 0, bool anonymize = false)
    {
        this.BundleFor = bundleFor;
        this.BundleForTime = bundleForTime;
        this.LogFileCount = logFileCount;
        this.Anonymize = anonymize;
    }

    /// <summary>
    /// Whether to generate a bundle for the given timeframe.
    /// </summary>
    /// <value>Whether to generate a bundle for the given timeframe.</value>
    /*
    <example>true</example>
    */
    [JsonPropertyName("bundle_for")]
    public bool BundleFor { get; set; }

    /// <summary>
    /// Time period in minutes for which to generate the bundle.
    /// </summary>
    /// <value>Time period in minutes for which to generate the bundle.</value>
    /*
    <example>2</example>
    */
    [JsonPropertyName("bundle_for_time")]
    public int BundleForTime { get; set; }

    /// <summary>
    /// Maximum number of log files to include in the bundle.
    /// </summary>
    /// <value>Maximum number of log files to include in the bundle.</value>
    /*
    <example>100</example>
    */
    [JsonPropertyName("log_file_count")]
    public int LogFileCount { get; set; }

    /// <summary>
    /// Whether sensitive data should be anonymized in the bundle.
    /// </summary>
    /// <value>Whether sensitive data should be anonymized in the bundle.</value>
    /*
    <example>false</example>
    */
    [JsonPropertyName("anonymize")]
    public bool Anonymize { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class BundleParameters {\n");
        sb.Append("  BundleFor: ").Append(BundleFor).Append("\n");
        sb.Append("  BundleForTime: ").Append(BundleForTime).Append("\n");
        sb.Append("  LogFileCount: ").Append(LogFileCount).Append("\n");
        sb.Append("  Anonymize: ").Append(Anonymize).Append("\n");
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
        // BundleForTime (int) maximum
        if (this.BundleForTime > (int)5)
        {
            yield return new ValidationResult("Invalid value for BundleForTime, must be a value less than or equal to 5.", new [] { "BundleForTime" });
        }

        // BundleForTime (int) minimum
        if (this.BundleForTime < (int)1)
        {
            yield return new ValidationResult("Invalid value for BundleForTime, must be a value greater than or equal to 1.", new [] { "BundleForTime" });
        }

        // LogFileCount (int) maximum
        if (this.LogFileCount > (int)1000)
        {
            yield return new ValidationResult("Invalid value for LogFileCount, must be a value less than or equal to 1000.", new [] { "LogFileCount" });
        }

        // LogFileCount (int) minimum
        if (this.LogFileCount < (int)1)
        {
            yield return new ValidationResult("Invalid value for LogFileCount, must be a value greater than or equal to 1.", new [] { "LogFileCount" });
        }

        yield break;
    }
}