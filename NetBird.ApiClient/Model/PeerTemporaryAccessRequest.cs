


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
/// PeerTemporaryAccessRequest
/// </summary>
[DataContract(Name = "PeerTemporaryAccessRequest")]
public class PeerTemporaryAccessRequest : IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PeerTemporaryAccessRequest" /> class.
    /// </summary>
    [JsonConstructor]
    protected PeerTemporaryAccessRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="PeerTemporaryAccessRequest" /> class.
    /// </summary>
    /// <param name="name">Peer&#39;s hostname (required).</param>
    /// <param name="wgPubKey">Peer&#39;s WireGuard public key (required).</param>
    /// <param name="rules">List of temporary access rules (required).</param>
    public PeerTemporaryAccessRequest(string name = null, string wgPubKey = null, List<string> rules = null)
    {
        // to ensure "name" is required (not null)
        ArgumentNullException.ThrowIfNull(name);
        this.Name = name;
        // to ensure "wgPubKey" is required (not null)
        ArgumentNullException.ThrowIfNull(wgPubKey);
        this.WgPubKey = wgPubKey;
        // to ensure "rules" is required (not null)
        ArgumentNullException.ThrowIfNull(rules);
        this.Rules = rules;
    }

    /// <summary>
    /// Peer&#39;s hostname
    /// </summary>
    /// <value>Peer&#39;s hostname</value>
    /*
    <example>temp-host-1</example>
    */
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// Peer&#39;s WireGuard public key
    /// </summary>
    /// <value>Peer&#39;s WireGuard public key</value>
    /*
    <example>n0r3pL4c3h0ld3rK3y&#x3D;&#x3D;</example>
    */
    [JsonPropertyName("wg_pub_key")]
    public string WgPubKey { get; set; }

    /// <summary>
    /// List of temporary access rules
    /// </summary>
    /// <value>List of temporary access rules</value>
    [JsonPropertyName("rules")]
    public List<string> Rules { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class PeerTemporaryAccessRequest {\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  WgPubKey: ").Append(WgPubKey).Append("\n");
        sb.Append("  Rules: ").Append(Rules).Append("\n");
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