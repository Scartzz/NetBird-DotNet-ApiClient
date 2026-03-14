


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
/// PeerLocalFlags
/// </summary>
[DataContract(Name = "PeerLocalFlags")]
public class PeerLocalFlags : IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PeerLocalFlags" /> class.
    /// </summary>
    /// <param name="rosenpassEnabled">Indicates whether Rosenpass is enabled on this peer.</param>
    /// <param name="rosenpassPermissive">Indicates whether Rosenpass is in permissive mode or not.</param>
    /// <param name="serverSshAllowed">Indicates whether SSH access this peer is allowed or not.</param>
    /// <param name="disableClientRoutes">Indicates whether client routes are disabled on this peer or not.</param>
    /// <param name="disableServerRoutes">Indicates whether server routes are disabled on this peer or not.</param>
    /// <param name="disableDns">Indicates whether DNS management is disabled on this peer or not.</param>
    /// <param name="disableFirewall">Indicates whether firewall management is disabled on this peer or not.</param>
    /// <param name="blockLanAccess">Indicates whether LAN access is blocked on this peer when used as a routing peer.</param>
    /// <param name="blockInbound">Indicates whether inbound traffic is blocked on this peer.</param>
    /// <param name="lazyConnectionEnabled">Indicates whether lazy connection is enabled on this peer.</param>
    public PeerLocalFlags(bool rosenpassEnabled = false, bool rosenpassPermissive = false, bool serverSshAllowed = false, bool disableClientRoutes = false, bool disableServerRoutes = false, bool disableDns = false, bool disableFirewall = false, bool blockLanAccess = false, bool blockInbound = false, bool lazyConnectionEnabled = false)
    {
        this.RosenpassEnabled = rosenpassEnabled;
        this.RosenpassPermissive = rosenpassPermissive;
        this.ServerSshAllowed = serverSshAllowed;
        this.DisableClientRoutes = disableClientRoutes;
        this.DisableServerRoutes = disableServerRoutes;
        this.DisableDns = disableDns;
        this.DisableFirewall = disableFirewall;
        this.BlockLanAccess = blockLanAccess;
        this.BlockInbound = blockInbound;
        this.LazyConnectionEnabled = lazyConnectionEnabled;
    }

    /// <summary>
    /// Indicates whether Rosenpass is enabled on this peer
    /// </summary>
    /// <value>Indicates whether Rosenpass is enabled on this peer</value>
    /*
    <example>true</example>
    */
    [JsonPropertyName("rosenpass_enabled")]
    public bool RosenpassEnabled { get; set; }

    /// <summary>
    /// Indicates whether Rosenpass is in permissive mode or not
    /// </summary>
    /// <value>Indicates whether Rosenpass is in permissive mode or not</value>
    /*
    <example>false</example>
    */
    [JsonPropertyName("rosenpass_permissive")]
    public bool RosenpassPermissive { get; set; }

    /// <summary>
    /// Indicates whether SSH access this peer is allowed or not
    /// </summary>
    /// <value>Indicates whether SSH access this peer is allowed or not</value>
    /*
    <example>true</example>
    */
    [JsonPropertyName("server_ssh_allowed")]
    public bool ServerSshAllowed { get; set; }

    /// <summary>
    /// Indicates whether client routes are disabled on this peer or not
    /// </summary>
    /// <value>Indicates whether client routes are disabled on this peer or not</value>
    /*
    <example>false</example>
    */
    [JsonPropertyName("disable_client_routes")]
    public bool DisableClientRoutes { get; set; }

    /// <summary>
    /// Indicates whether server routes are disabled on this peer or not
    /// </summary>
    /// <value>Indicates whether server routes are disabled on this peer or not</value>
    /*
    <example>false</example>
    */
    [JsonPropertyName("disable_server_routes")]
    public bool DisableServerRoutes { get; set; }

    /// <summary>
    /// Indicates whether DNS management is disabled on this peer or not
    /// </summary>
    /// <value>Indicates whether DNS management is disabled on this peer or not</value>
    /*
    <example>false</example>
    */
    [JsonPropertyName("disable_dns")]
    public bool DisableDns { get; set; }

    /// <summary>
    /// Indicates whether firewall management is disabled on this peer or not
    /// </summary>
    /// <value>Indicates whether firewall management is disabled on this peer or not</value>
    /*
    <example>false</example>
    */
    [JsonPropertyName("disable_firewall")]
    public bool DisableFirewall { get; set; }

    /// <summary>
    /// Indicates whether LAN access is blocked on this peer when used as a routing peer
    /// </summary>
    /// <value>Indicates whether LAN access is blocked on this peer when used as a routing peer</value>
    /*
    <example>false</example>
    */
    [JsonPropertyName("block_lan_access")]
    public bool BlockLanAccess { get; set; }

    /// <summary>
    /// Indicates whether inbound traffic is blocked on this peer
    /// </summary>
    /// <value>Indicates whether inbound traffic is blocked on this peer</value>
    /*
    <example>false</example>
    */
    [JsonPropertyName("block_inbound")]
    public bool BlockInbound { get; set; }

    /// <summary>
    /// Indicates whether lazy connection is enabled on this peer
    /// </summary>
    /// <value>Indicates whether lazy connection is enabled on this peer</value>
    /*
    <example>false</example>
    */
    [JsonPropertyName("lazy_connection_enabled")]
    public bool LazyConnectionEnabled { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class PeerLocalFlags {\n");
        sb.Append("  RosenpassEnabled: ").Append(RosenpassEnabled).Append("\n");
        sb.Append("  RosenpassPermissive: ").Append(RosenpassPermissive).Append("\n");
        sb.Append("  ServerSshAllowed: ").Append(ServerSshAllowed).Append("\n");
        sb.Append("  DisableClientRoutes: ").Append(DisableClientRoutes).Append("\n");
        sb.Append("  DisableServerRoutes: ").Append(DisableServerRoutes).Append("\n");
        sb.Append("  DisableDns: ").Append(DisableDns).Append("\n");
        sb.Append("  DisableFirewall: ").Append(DisableFirewall).Append("\n");
        sb.Append("  BlockLanAccess: ").Append(BlockLanAccess).Append("\n");
        sb.Append("  BlockInbound: ").Append(BlockInbound).Append("\n");
        sb.Append("  LazyConnectionEnabled: ").Append(LazyConnectionEnabled).Append("\n");
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