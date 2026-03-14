


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
/// JobResponse
/// </summary>
[DataContract(Name = "JobResponse")]
public class JobResponse : IValidatableObject
{
    /// <summary>
    /// Defines Status
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum StatusEnum
    {
        /// <summary>
        /// Enum Pending for value: pending
        /// </summary>
        [EnumMember(Value = "pending")]
        Pending = 1,

        /// <summary>
        /// Enum Succeeded for value: succeeded
        /// </summary>
        [EnumMember(Value = "succeeded")]
        Succeeded = 2,

        /// <summary>
        /// Enum Failed for value: failed
        /// </summary>
        [EnumMember(Value = "failed")]
        Failed = 3
    }


    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    [JsonPropertyName("status")]
    public StatusEnum Status { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="JobResponse" /> class.
    /// </summary>
    [JsonConstructor]
    protected JobResponse() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="JobResponse" /> class.
    /// </summary>
    /// <param name="id">id (required).</param>
    /// <param name="createdAt">createdAt (required).</param>
    /// <param name="completedAt">completedAt.</param>
    /// <param name="triggeredBy">triggeredBy (required).</param>
    /// <param name="status">status (required).</param>
    /// <param name="failedReason">failedReason.</param>
    /// <param name="workload">workload (required).</param>
    public JobResponse(string id = null, DateTimeOffset createdAt = default, DateTimeOffset completedAt = default, string triggeredBy = null, StatusEnum status = default, string failedReason = null, BundleWorkloadResponse workload = null)
    {
        // to ensure "id" is required (not null)
        ArgumentNullException.ThrowIfNull(id);
        this.Id = id;
        this.CreatedAt = createdAt;
        // to ensure "triggeredBy" is required (not null)
        ArgumentNullException.ThrowIfNull(triggeredBy);
        this.TriggeredBy = triggeredBy;
        this.Status = status;
        // to ensure "workload" is required (not null)
        ArgumentNullException.ThrowIfNull(workload);
        this.Workload = workload;
        this.CompletedAt = completedAt;
        this.FailedReason = failedReason;
    }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets CreatedAt
    /// </summary>
    [JsonPropertyName("created_at")]
    public DateTimeOffset CreatedAt { get; set; }

    /// <summary>
    /// Gets or Sets CompletedAt
    /// </summary>
    [JsonPropertyName("completed_at")]
    public DateTimeOffset CompletedAt { get; set; }

    /// <summary>
    /// Gets or Sets TriggeredBy
    /// </summary>
    [JsonPropertyName("triggered_by")]
    public string TriggeredBy { get; set; }

    /// <summary>
    /// Gets or Sets FailedReason
    /// </summary>
    [JsonPropertyName("failed_reason")]
    public string FailedReason { get; set; }

    /// <summary>
    /// Gets or Sets Workload
    /// </summary>
    [JsonPropertyName("workload")]
    public BundleWorkloadResponse Workload { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class JobResponse {\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
        sb.Append("  CompletedAt: ").Append(CompletedAt).Append("\n");
        sb.Append("  TriggeredBy: ").Append(TriggeredBy).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  FailedReason: ").Append(FailedReason).Append("\n");
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