


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
/// Response for bypassed peer operations.
/// </summary>
[DataContract(Name = "BypassResponse")]
public class BypassResponse : IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BypassResponse" /> class.
    /// </summary>
    [JsonConstructor]
    protected BypassResponse() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="BypassResponse" /> class.
    /// </summary>
    /// <param name="peerId">The ID of the bypassed peer. (required).</param>
    public BypassResponse(string peerId = null)
    {
        // to ensure "peerId" is required (not null)
        ArgumentNullException.ThrowIfNull(peerId);
        this.PeerId = peerId;
    }

    /// <summary>
    /// The ID of the bypassed peer.
    /// </summary>
    /// <value>The ID of the bypassed peer.</value>
    /*
    <example>chacbco6lnnbn6cg5s91</example>
    */
    [JsonPropertyName("peer_id")]
    public string PeerId { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class BypassResponse {\n");
        sb.Append("  PeerId: ").Append(PeerId).Append("\n");
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