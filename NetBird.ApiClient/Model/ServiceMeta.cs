


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
/// ServiceMeta
/// </summary>
[DataContract(Name = "ServiceMeta")]
public class ServiceMeta : IValidatableObject
{
    /// <summary>
    /// Current status of the service
    /// </summary>
    /// <value>Current status of the service</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum StatusEnum
    {
        /// <summary>
        /// Enum Pending for value: pending
        /// </summary>
        [EnumMember(Value = "pending")]
        Pending = 1,

        /// <summary>
        /// Enum Active for value: active
        /// </summary>
        [EnumMember(Value = "active")]
        Active = 2,

        /// <summary>
        /// Enum TunnelNotCreated for value: tunnel_not_created
        /// </summary>
        [EnumMember(Value = "tunnel_not_created")]
        TunnelNotCreated = 3,

        /// <summary>
        /// Enum CertificatePending for value: certificate_pending
        /// </summary>
        [EnumMember(Value = "certificate_pending")]
        CertificatePending = 4,

        /// <summary>
        /// Enum CertificateFailed for value: certificate_failed
        /// </summary>
        [EnumMember(Value = "certificate_failed")]
        CertificateFailed = 5,

        /// <summary>
        /// Enum Error for value: error
        /// </summary>
        [EnumMember(Value = "error")]
        Error = 6
    }


    /// <summary>
    /// Current status of the service
    /// </summary>
    /// <value>Current status of the service</value>
    /*
    <example>active</example>
    */
    [JsonPropertyName("status")]
    public StatusEnum Status { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="ServiceMeta" /> class.
    /// </summary>
    [JsonConstructor]
    protected ServiceMeta() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ServiceMeta" /> class.
    /// </summary>
    /// <param name="createdAt">Timestamp when the service was created (required).</param>
    /// <param name="certificateIssuedAt">Timestamp when the certificate was issued (empty if not yet issued).</param>
    /// <param name="status">Current status of the service (required).</param>
    public ServiceMeta(DateTimeOffset createdAt = default, DateTimeOffset certificateIssuedAt = default, StatusEnum status = default)
    {
        this.CreatedAt = createdAt;
        this.Status = status;
        this.CertificateIssuedAt = certificateIssuedAt;
    }

    /// <summary>
    /// Timestamp when the service was created
    /// </summary>
    /// <value>Timestamp when the service was created</value>
    /*
    <example>2024-02-03T10:30:00Z</example>
    */
    [JsonPropertyName("created_at")]
    public DateTimeOffset CreatedAt { get; set; }

    /// <summary>
    /// Timestamp when the certificate was issued (empty if not yet issued)
    /// </summary>
    /// <value>Timestamp when the certificate was issued (empty if not yet issued)</value>
    /*
    <example>2024-02-03T10:35:00Z</example>
    */
    [JsonPropertyName("certificate_issued_at")]
    public DateTimeOffset CertificateIssuedAt { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class ServiceMeta {\n");
        sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
        sb.Append("  CertificateIssuedAt: ").Append(CertificateIssuedAt).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
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