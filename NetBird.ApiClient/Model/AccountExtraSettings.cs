


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
/// AccountExtraSettings
/// </summary>
[DataContract(Name = "AccountExtraSettings")]
public class AccountExtraSettings : IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AccountExtraSettings" /> class.
    /// </summary>
    [JsonConstructor]
    protected AccountExtraSettings() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="AccountExtraSettings" /> class.
    /// </summary>
    /// <param name="peerApprovalEnabled">(Cloud only) Enables or disables peer approval globally. If enabled, all peers added will be in pending state until approved by an admin. (required).</param>
    /// <param name="userApprovalRequired">Enables manual approval for new users joining via domain matching. When enabled, users are blocked with pending approval status until explicitly approved by an admin. (required).</param>
    /// <param name="networkTrafficLogsEnabled">Enables or disables network traffic logging. If enabled, all network traffic events from peers will be stored. (required).</param>
    /// <param name="networkTrafficLogsGroups">Limits traffic logging to these groups. If unset all peers are enabled. (required).</param>
    /// <param name="networkTrafficPacketCounterEnabled">Enables or disables network traffic packet counter. If enabled, network packets and their size will be counted and reported. (This can have an slight impact on performance) (required).</param>
    public AccountExtraSettings(bool peerApprovalEnabled = false, bool userApprovalRequired = false, bool networkTrafficLogsEnabled = false, List<string> networkTrafficLogsGroups = null, bool networkTrafficPacketCounterEnabled = false)
    {
        this.PeerApprovalEnabled = peerApprovalEnabled;
        this.UserApprovalRequired = userApprovalRequired;
        this.NetworkTrafficLogsEnabled = networkTrafficLogsEnabled;
        // to ensure "networkTrafficLogsGroups" is required (not null)
        ArgumentNullException.ThrowIfNull(networkTrafficLogsGroups);
        this.NetworkTrafficLogsGroups = networkTrafficLogsGroups;
        this.NetworkTrafficPacketCounterEnabled = networkTrafficPacketCounterEnabled;
    }

    /// <summary>
    /// (Cloud only) Enables or disables peer approval globally. If enabled, all peers added will be in pending state until approved by an admin.
    /// </summary>
    /// <value>(Cloud only) Enables or disables peer approval globally. If enabled, all peers added will be in pending state until approved by an admin.</value>
    /*
    <example>true</example>
    */
    [JsonPropertyName("peer_approval_enabled")]
    public bool PeerApprovalEnabled { get; set; }

    /// <summary>
    /// Enables manual approval for new users joining via domain matching. When enabled, users are blocked with pending approval status until explicitly approved by an admin.
    /// </summary>
    /// <value>Enables manual approval for new users joining via domain matching. When enabled, users are blocked with pending approval status until explicitly approved by an admin.</value>
    /*
    <example>false</example>
    */
    [JsonPropertyName("user_approval_required")]
    public bool UserApprovalRequired { get; set; }

    /// <summary>
    /// Enables or disables network traffic logging. If enabled, all network traffic events from peers will be stored.
    /// </summary>
    /// <value>Enables or disables network traffic logging. If enabled, all network traffic events from peers will be stored.</value>
    /*
    <example>true</example>
    */
    [JsonPropertyName("network_traffic_logs_enabled")]
    public bool NetworkTrafficLogsEnabled { get; set; }

    /// <summary>
    /// Limits traffic logging to these groups. If unset all peers are enabled.
    /// </summary>
    /// <value>Limits traffic logging to these groups. If unset all peers are enabled.</value>
    [JsonPropertyName("network_traffic_logs_groups")]
    public List<string> NetworkTrafficLogsGroups { get; set; }

    /// <summary>
    /// Enables or disables network traffic packet counter. If enabled, network packets and their size will be counted and reported. (This can have an slight impact on performance)
    /// </summary>
    /// <value>Enables or disables network traffic packet counter. If enabled, network packets and their size will be counted and reported. (This can have an slight impact on performance)</value>
    /*
    <example>true</example>
    */
    [JsonPropertyName("network_traffic_packet_counter_enabled")]
    public bool NetworkTrafficPacketCounterEnabled { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class AccountExtraSettings {\n");
        sb.Append("  PeerApprovalEnabled: ").Append(PeerApprovalEnabled).Append("\n");
        sb.Append("  UserApprovalRequired: ").Append(UserApprovalRequired).Append("\n");
        sb.Append("  NetworkTrafficLogsEnabled: ").Append(NetworkTrafficLogsEnabled).Append("\n");
        sb.Append("  NetworkTrafficLogsGroups: ").Append(NetworkTrafficLogsGroups).Append("\n");
        sb.Append("  NetworkTrafficPacketCounterEnabled: ").Append(NetworkTrafficPacketCounterEnabled).Append("\n");
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