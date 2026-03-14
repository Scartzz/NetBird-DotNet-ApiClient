


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
/// IngressPeer
/// </summary>
[DataContract(Name = "IngressPeer")]
public class IngressPeer : IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="IngressPeer" /> class.
    /// </summary>
    [JsonConstructor]
    protected IngressPeer() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="IngressPeer" /> class.
    /// </summary>
    /// <param name="id">ID of the ingress peer (required).</param>
    /// <param name="peerId">ID of the peer that is used as an ingress peer (required).</param>
    /// <param name="ingressIp">Ingress IP address of the ingress peer where the traffic arrives (required).</param>
    /// <param name="availablePorts">availablePorts (required).</param>
    /// <param name="enabled">Indicates if an ingress peer is enabled (required).</param>
    /// <param name="connected">Indicates if an ingress peer is connected to the management server (required).</param>
    /// <param name="fallback">Indicates if an ingress peer can be used as a fallback if no ingress peer can be found in the region of the forwarded peer (required).</param>
    /// <param name="region">Region of the ingress peer (required).</param>
    public IngressPeer(string id = null, string peerId = null, string ingressIp = null, AvailablePorts availablePorts = null, bool enabled = false, bool connected = false, bool fallback = false, string region = null)
    {
        // to ensure "id" is required (not null)
        ArgumentNullException.ThrowIfNull(id);
        this.Id = id;
        // to ensure "peerId" is required (not null)
        ArgumentNullException.ThrowIfNull(peerId);
        this.PeerId = peerId;
        // to ensure "ingressIp" is required (not null)
        ArgumentNullException.ThrowIfNull(ingressIp);
        this.IngressIp = ingressIp;
        // to ensure "availablePorts" is required (not null)
        ArgumentNullException.ThrowIfNull(availablePorts);
        this.AvailablePorts = availablePorts;
        this.Enabled = enabled;
        this.Connected = connected;
        this.Fallback = fallback;
        // to ensure "region" is required (not null)
        ArgumentNullException.ThrowIfNull(region);
        this.Region = region;
    }

    /// <summary>
    /// ID of the ingress peer
    /// </summary>
    /// <value>ID of the ingress peer</value>
    /*
    <example>ch8i4ug6lnn4g9hqv7m0</example>
    */
    [JsonPropertyName("id")]
    public string Id { get; set; }

    /// <summary>
    /// ID of the peer that is used as an ingress peer
    /// </summary>
    /// <value>ID of the peer that is used as an ingress peer</value>
    /*
    <example>x7p3kqf2rdd8j5zxw4n9</example>
    */
    [JsonPropertyName("peer_id")]
    public string PeerId { get; set; }

    /// <summary>
    /// Ingress IP address of the ingress peer where the traffic arrives
    /// </summary>
    /// <value>Ingress IP address of the ingress peer where the traffic arrives</value>
    /*
    <example>192.34.0.123</example>
    */
    [JsonPropertyName("ingress_ip")]
    public string IngressIp { get; set; }

    /// <summary>
    /// Gets or Sets AvailablePorts
    /// </summary>
    [JsonPropertyName("available_ports")]
    public AvailablePorts AvailablePorts { get; set; }

    /// <summary>
    /// Indicates if an ingress peer is enabled
    /// </summary>
    /// <value>Indicates if an ingress peer is enabled</value>
    /*
    <example>true</example>
    */
    [JsonPropertyName("enabled")]
    public bool Enabled { get; set; }

    /// <summary>
    /// Indicates if an ingress peer is connected to the management server
    /// </summary>
    /// <value>Indicates if an ingress peer is connected to the management server</value>
    /*
    <example>true</example>
    */
    [JsonPropertyName("connected")]
    public bool Connected { get; set; }

    /// <summary>
    /// Indicates if an ingress peer can be used as a fallback if no ingress peer can be found in the region of the forwarded peer
    /// </summary>
    /// <value>Indicates if an ingress peer can be used as a fallback if no ingress peer can be found in the region of the forwarded peer</value>
    /*
    <example>true</example>
    */
    [JsonPropertyName("fallback")]
    public bool Fallback { get; set; }

    /// <summary>
    /// Region of the ingress peer
    /// </summary>
    /// <value>Region of the ingress peer</value>
    /*
    <example>germany</example>
    */
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class IngressPeer {\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  PeerId: ").Append(PeerId).Append("\n");
        sb.Append("  IngressIp: ").Append(IngressIp).Append("\n");
        sb.Append("  AvailablePorts: ").Append(AvailablePorts).Append("\n");
        sb.Append("  Enabled: ").Append(Enabled).Append("\n");
        sb.Append("  Connected: ").Append(Connected).Append("\n");
        sb.Append("  Fallback: ").Append(Fallback).Append("\n");
        sb.Append("  Region: ").Append(Region).Append("\n");
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