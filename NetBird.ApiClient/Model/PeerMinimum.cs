


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
/// PeerMinimum
/// </summary>
[DataContract(Name = "PeerMinimum")]
public class PeerMinimum : IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PeerMinimum" /> class.
    /// </summary>
    [JsonConstructor]
    protected PeerMinimum() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="PeerMinimum" /> class.
    /// </summary>
    /// <param name="id">Peer ID (required).</param>
    /// <param name="name">Peer&#39;s hostname (required).</param>
    public PeerMinimum(string id = null, string name = null)
    {
        // to ensure "id" is required (not null)
        ArgumentNullException.ThrowIfNull(id);
        this.Id = id;
        // to ensure "name" is required (not null)
        ArgumentNullException.ThrowIfNull(name);
        this.Name = name;
    }

    /// <summary>
    /// Peer ID
    /// </summary>
    /// <value>Peer ID</value>
    /*
    <example>chacbco6lnnbn6cg5s90</example>
    */
    [JsonPropertyName("id")]
    public string Id { get; set; }

    /// <summary>
    /// Peer&#39;s hostname
    /// </summary>
    /// <value>Peer&#39;s hostname</value>
    /*
    <example>stage-host-1</example>
    */
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class PeerMinimum {\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
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