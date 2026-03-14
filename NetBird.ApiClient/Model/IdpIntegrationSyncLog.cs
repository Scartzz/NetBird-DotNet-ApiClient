


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
/// Represents a synchronization log entry for an integration
/// </summary>
[DataContract(Name = "IdpIntegrationSyncLog")]
public class IdpIntegrationSyncLog : IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="IdpIntegrationSyncLog" /> class.
    /// </summary>
    [JsonConstructor]
    protected IdpIntegrationSyncLog() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="IdpIntegrationSyncLog" /> class.
    /// </summary>
    /// <param name="id">The unique identifier for the sync log (required).</param>
    /// <param name="level">The log level (required).</param>
    /// <param name="timestamp">Timestamp of when the log was created (required).</param>
    /// <param name="message">Log message (required).</param>
    public IdpIntegrationSyncLog(long id = 0, string level = null, DateTimeOffset timestamp = default, string message = null)
    {
        this.Id = id;
        // to ensure "level" is required (not null)
        ArgumentNullException.ThrowIfNull(level);
        this.Level = level;
        this.Timestamp = timestamp;
        // to ensure "message" is required (not null)
        ArgumentNullException.ThrowIfNull(message);
        this.Message = message;
    }

    /// <summary>
    /// The unique identifier for the sync log
    /// </summary>
    /// <value>The unique identifier for the sync log</value>
    /*
    <example>123</example>
    */
    [JsonPropertyName("id")]
    public long Id { get; set; }

    /// <summary>
    /// The log level
    /// </summary>
    /// <value>The log level</value>
    /*
    <example>info</example>
    */
    [JsonPropertyName("level")]
    public string Level { get; set; }

    /// <summary>
    /// Timestamp of when the log was created
    /// </summary>
    /// <value>Timestamp of when the log was created</value>
    /*
    <example>2023-05-15T10:30:00Z</example>
    */
    [JsonPropertyName("timestamp")]
    public DateTimeOffset Timestamp { get; set; }

    /// <summary>
    /// Log message
    /// </summary>
    /// <value>Log message</value>
    /*
    <example>Successfully synchronized users and groups</example>
    */
    [JsonPropertyName("message")]
    public string Message { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class IdpIntegrationSyncLog {\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Level: ").Append(Level).Append("\n");
        sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
        sb.Append("  Message: ").Append(Message).Append("\n");
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