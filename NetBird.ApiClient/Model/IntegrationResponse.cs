


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
/// Represents an event streaming integration.
/// </summary>
[DataContract(Name = "IntegrationResponse")]
public class IntegrationResponse : IValidatableObject
{
    /// <summary>
    /// The event streaming platform.
    /// </summary>
    /// <value>The event streaming platform.</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum PlatformEnum
    {
        /// <summary>
        /// Enum Datadog for value: datadog
        /// </summary>
        [EnumMember(Value = "datadog")]
        Datadog = 1,

        /// <summary>
        /// Enum S3 for value: s3
        /// </summary>
        [EnumMember(Value = "s3")]
        S3 = 2,

        /// <summary>
        /// Enum Firehose for value: firehose
        /// </summary>
        [EnumMember(Value = "firehose")]
        Firehose = 3,

        /// <summary>
        /// Enum GenericHttp for value: generic_http
        /// </summary>
        [EnumMember(Value = "generic_http")]
        GenericHttp = 4
    }


    /// <summary>
    /// The event streaming platform.
    /// </summary>
    /// <value>The event streaming platform.</value>
    /*
    <example>datadog</example>
    */
    [JsonPropertyName("platform")]
    public PlatformEnum? Platform { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="IntegrationResponse" /> class.
    /// </summary>
    /// <param name="id">The unique numeric identifier for the integration..</param>
    /// <param name="accountId">The identifier of the account this integration belongs to..</param>
    /// <param name="enabled">Whether the integration is currently active..</param>
    /// <param name="platform">The event streaming platform..</param>
    /// <param name="createdAt">Timestamp of when the integration was created..</param>
    /// <param name="updatedAt">Timestamp of when the integration was last updated..</param>
    /// <param name="config">Configuration for the integration. Sensitive keys (like API keys, secret keys) are masked with &#39;****&#39; in responses, as indicated by the GetIntegration handler logic..</param>
    public IntegrationResponse(long id = 0, string accountId = null, bool enabled = false, PlatformEnum? platform = null, DateTimeOffset createdAt = default, DateTimeOffset updatedAt = default, Dictionary<string, string> config = null)
    {
        this.Id = id;
        this.AccountId = accountId;
        this.Enabled = enabled;
        this.Platform = platform;
        this.CreatedAt = createdAt;
        this.UpdatedAt = updatedAt;
        this.Config = config;
    }

    /// <summary>
    /// The unique numeric identifier for the integration.
    /// </summary>
    /// <value>The unique numeric identifier for the integration.</value>
    /*
    <example>123</example>
    */
    [JsonPropertyName("id")]
    public long Id { get; set; }

    /// <summary>
    /// The identifier of the account this integration belongs to.
    /// </summary>
    /// <value>The identifier of the account this integration belongs to.</value>
    /*
    <example>acc_abcdef123456</example>
    */
    [JsonPropertyName("account_id")]
    public string AccountId { get; set; }

    /// <summary>
    /// Whether the integration is currently active.
    /// </summary>
    /// <value>Whether the integration is currently active.</value>
    /*
    <example>true</example>
    */
    [JsonPropertyName("enabled")]
    public bool Enabled { get; set; }

    /// <summary>
    /// Timestamp of when the integration was created.
    /// </summary>
    /// <value>Timestamp of when the integration was created.</value>
    /*
    <example>2023-05-15T10:30:00Z</example>
    */
    [JsonPropertyName("created_at")]
    public DateTimeOffset CreatedAt { get; set; }

    /// <summary>
    /// Timestamp of when the integration was last updated.
    /// </summary>
    /// <value>Timestamp of when the integration was last updated.</value>
    /*
    <example>2023-05-16T11:45:00Z</example>
    */
    [JsonPropertyName("updated_at")]
    public DateTimeOffset UpdatedAt { get; set; }

    /// <summary>
    /// Configuration for the integration. Sensitive keys (like API keys, secret keys) are masked with &#39;****&#39; in responses, as indicated by the GetIntegration handler logic.
    /// </summary>
    /// <value>Configuration for the integration. Sensitive keys (like API keys, secret keys) are masked with &#39;****&#39; in responses, as indicated by the GetIntegration handler logic.</value>
    /*
    <example>{api_key&#x3D;****, site&#x3D;datadoghq.com, region&#x3D;us-east-1}</example>
    */
    [JsonPropertyName("config")]
    public Dictionary<string, string> Config { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class IntegrationResponse {\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  AccountId: ").Append(AccountId).Append("\n");
        sb.Append("  Enabled: ").Append(Enabled).Append("\n");
        sb.Append("  Platform: ").Append(Platform).Append("\n");
        sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
        sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
        sb.Append("  Config: ").Append(Config).Append("\n");
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
        // Id (long) minimum
        if (this.Id < (long)0)
        {
            yield return new ValidationResult("Invalid value for Id, must be a value greater than or equal to 0.", new [] { "Id" });
        }

        yield break;
    }
}