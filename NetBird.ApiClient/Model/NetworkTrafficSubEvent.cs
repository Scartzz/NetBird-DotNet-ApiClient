


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
/// NetworkTrafficSubEvent
/// </summary>
[DataContract(Name = "NetworkTrafficSubEvent")]
public class NetworkTrafficSubEvent : IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="NetworkTrafficSubEvent" /> class.
    /// </summary>
    [JsonConstructor]
    protected NetworkTrafficSubEvent() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="NetworkTrafficSubEvent" /> class.
    /// </summary>
    /// <param name="type">Type of the event (e.g., TYPE_UNKNOWN, TYPE_START, TYPE_END, TYPE_DROP). (required).</param>
    /// <param name="timestamp">Timestamp of the event as sent by the peer. (required).</param>
    public NetworkTrafficSubEvent(string type = null, DateTimeOffset timestamp = default)
    {
        // to ensure "type" is required (not null)
        ArgumentNullException.ThrowIfNull(type);
        this.Type = type;
        this.Timestamp = timestamp;
    }

    /// <summary>
    /// Type of the event (e.g., TYPE_UNKNOWN, TYPE_START, TYPE_END, TYPE_DROP).
    /// </summary>
    /// <value>Type of the event (e.g., TYPE_UNKNOWN, TYPE_START, TYPE_END, TYPE_DROP).</value>
    /*
    <example>TYPE_START</example>
    */
    [JsonPropertyName("type")]
    public string Type { get; set; }

    /// <summary>
    /// Timestamp of the event as sent by the peer.
    /// </summary>
    /// <value>Timestamp of the event as sent by the peer.</value>
    /*
    <example>2025-03-20T16:23:58.125+00:00</example>
    */
    [JsonPropertyName("timestamp")]
    public DateTimeOffset Timestamp { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class NetworkTrafficSubEvent {\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
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