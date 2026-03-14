


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
/// Request payload for creating a new event streaming integration. Also used as the structure for the PUT request body, but not all fields are applicable for updates (see PUT operation description).
/// </summary>
[DataContract(Name = "CreateIntegrationRequest")]
public class CreateIntegrationRequest : IValidatableObject
{
    /// <summary>
    /// The event streaming platform to integrate with (e.g., \&quot;datadog\&quot;, \&quot;s3\&quot;, \&quot;firehose\&quot;). This field is used for creation. For updates (PUT), this field, if sent, is ignored by the backend.
    /// </summary>
    /// <value>The event streaming platform to integrate with (e.g., \&quot;datadog\&quot;, \&quot;s3\&quot;, \&quot;firehose\&quot;). This field is used for creation. For updates (PUT), this field, if sent, is ignored by the backend.</value>
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
    /// The event streaming platform to integrate with (e.g., \&quot;datadog\&quot;, \&quot;s3\&quot;, \&quot;firehose\&quot;). This field is used for creation. For updates (PUT), this field, if sent, is ignored by the backend.
    /// </summary>
    /// <value>The event streaming platform to integrate with (e.g., \&quot;datadog\&quot;, \&quot;s3\&quot;, \&quot;firehose\&quot;). This field is used for creation. For updates (PUT), this field, if sent, is ignored by the backend.</value>
    /*
    <example>s3</example>
    */
    [JsonPropertyName("platform")]
    public PlatformEnum Platform { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="CreateIntegrationRequest" /> class.
    /// </summary>
    [JsonConstructor]
    protected CreateIntegrationRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="CreateIntegrationRequest" /> class.
    /// </summary>
    /// <param name="platform">The event streaming platform to integrate with (e.g., \&quot;datadog\&quot;, \&quot;s3\&quot;, \&quot;firehose\&quot;). This field is used for creation. For updates (PUT), this field, if sent, is ignored by the backend. (required).</param>
    /// <param name="config">Platform-specific configuration as key-value pairs. For creation, all necessary credentials and settings must be provided. For updates, provide the fields to change or the entire new configuration. (required).</param>
    /// <param name="enabled">Specifies whether the integration is enabled. During creation (POST), this value is sent by the client, but the provided backend manager function &#x60;CreateIntegration&#x60; does not appear to use it directly, so its effect on creation should be verified. During updates (PUT), this field is used to enable or disable the integration. (required).</param>
    public CreateIntegrationRequest(PlatformEnum platform = default, Dictionary<string, string> config = null, bool enabled = false)
    {
        this.Platform = platform;
        // to ensure "config" is required (not null)
        ArgumentNullException.ThrowIfNull(config);
        this.Config = config;
        this.Enabled = enabled;
    }

    /// <summary>
    /// Platform-specific configuration as key-value pairs. For creation, all necessary credentials and settings must be provided. For updates, provide the fields to change or the entire new configuration.
    /// </summary>
    /// <value>Platform-specific configuration as key-value pairs. For creation, all necessary credentials and settings must be provided. For updates, provide the fields to change or the entire new configuration.</value>
    /*
    <example>{bucket_name&#x3D;my-event-logs, region&#x3D;us-east-1, access_key_id&#x3D;AKIA..., secret_access_key&#x3D;YOUR_SECRET_KEY}</example>
    */
    [JsonPropertyName("config")]
    public Dictionary<string, string> Config { get; set; }

    /// <summary>
    /// Specifies whether the integration is enabled. During creation (POST), this value is sent by the client, but the provided backend manager function &#x60;CreateIntegration&#x60; does not appear to use it directly, so its effect on creation should be verified. During updates (PUT), this field is used to enable or disable the integration.
    /// </summary>
    /// <value>Specifies whether the integration is enabled. During creation (POST), this value is sent by the client, but the provided backend manager function &#x60;CreateIntegration&#x60; does not appear to use it directly, so its effect on creation should be verified. During updates (PUT), this field is used to enable or disable the integration.</value>
    /*
    <example>true</example>
    */
    [JsonPropertyName("enabled")]
    public bool Enabled { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class CreateIntegrationRequest {\n");
        sb.Append("  Platform: ").Append(Platform).Append("\n");
        sb.Append("  Config: ").Append(Config).Append("\n");
        sb.Append("  Enabled: ").Append(Enabled).Append("\n");
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