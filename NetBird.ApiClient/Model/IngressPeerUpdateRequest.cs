


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
/// IngressPeerUpdateRequest
/// </summary>
[DataContract(Name = "IngressPeerUpdateRequest")]
public class IngressPeerUpdateRequest : IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="IngressPeerUpdateRequest" /> class.
    /// </summary>
    [JsonConstructor]
    protected IngressPeerUpdateRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="IngressPeerUpdateRequest" /> class.
    /// </summary>
    /// <param name="enabled">Defines if an ingress peer is enabled (required).</param>
    /// <param name="fallback">Defines if an ingress peer can be used as a fallback if no ingress peer can be found in the region of the forwarded peer (required).</param>
    public IngressPeerUpdateRequest(bool enabled = false, bool fallback = false)
    {
        this.Enabled = enabled;
        this.Fallback = fallback;
    }

    /// <summary>
    /// Defines if an ingress peer is enabled
    /// </summary>
    /// <value>Defines if an ingress peer is enabled</value>
    /*
    <example>true</example>
    */
    [JsonPropertyName("enabled")]
    public bool Enabled { get; set; }

    /// <summary>
    /// Defines if an ingress peer can be used as a fallback if no ingress peer can be found in the region of the forwarded peer
    /// </summary>
    /// <value>Defines if an ingress peer can be used as a fallback if no ingress peer can be found in the region of the forwarded peer</value>
    /*
    <example>true</example>
    */
    [JsonPropertyName("fallback")]
    public bool Fallback { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class IngressPeerUpdateRequest {\n");
        sb.Append("  Enabled: ").Append(Enabled).Append("\n");
        sb.Append("  Fallback: ").Append(Fallback).Append("\n");
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