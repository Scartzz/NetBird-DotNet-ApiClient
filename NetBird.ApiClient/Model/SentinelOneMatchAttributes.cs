


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
/// Attribute conditions to match when approving agents
/// </summary>
[DataContract(Name = "SentinelOneMatchAttributes")]
public class SentinelOneMatchAttributes : IValidatableObject
{
    /// <summary>
    /// The current network connectivity status of the device
    /// </summary>
    /// <value>The current network connectivity status of the device</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum NetworkStatusEnum
    {
        /// <summary>
        /// Enum Connected for value: connected
        /// </summary>
        [EnumMember(Value = "connected")]
        Connected = 1,

        /// <summary>
        /// Enum Disconnected for value: disconnected
        /// </summary>
        [EnumMember(Value = "disconnected")]
        Disconnected = 2,

        /// <summary>
        /// Enum Quarantined for value: quarantined
        /// </summary>
        [EnumMember(Value = "quarantined")]
        Quarantined = 3
    }


    /// <summary>
    /// The current network connectivity status of the device
    /// </summary>
    /// <value>The current network connectivity status of the device</value>
    [JsonPropertyName("network_status")]
    public NetworkStatusEnum? NetworkStatus { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="SentinelOneMatchAttributes" /> class.
    /// </summary>
    /// <param name="activeThreats">The maximum allowed number of active threats on the agent.</param>
    /// <param name="encryptedApplications">Whether disk encryption is enabled on the agent.</param>
    /// <param name="firewallEnabled">Whether the agent firewall is enabled.</param>
    /// <param name="infected">Whether the agent is currently flagged as infected.</param>
    /// <param name="isActive">Whether the agent has been recently active and reporting.</param>
    /// <param name="isUpToDate">Whether the agent is running the latest available version.</param>
    /// <param name="networkStatus">The current network connectivity status of the device.</param>
    /// <param name="operationalState">The current operational state of the agent.</param>
    public SentinelOneMatchAttributes(int activeThreats = 0, bool encryptedApplications = false, bool firewallEnabled = false, bool infected = false, bool isActive = false, bool isUpToDate = false, NetworkStatusEnum? networkStatus = null, string operationalState = null)
    {
        this.ActiveThreats = activeThreats;
        this.EncryptedApplications = encryptedApplications;
        this.FirewallEnabled = firewallEnabled;
        this.Infected = infected;
        this.IsActive = isActive;
        this.IsUpToDate = isUpToDate;
        this.NetworkStatus = networkStatus;
        this.OperationalState = operationalState;
    }

    /// <summary>
    /// The maximum allowed number of active threats on the agent
    /// </summary>
    /// <value>The maximum allowed number of active threats on the agent</value>
    /*
    <example>0</example>
    */
    [JsonPropertyName("active_threats")]
    public int ActiveThreats { get; set; }

    /// <summary>
    /// Whether disk encryption is enabled on the agent
    /// </summary>
    /// <value>Whether disk encryption is enabled on the agent</value>
    [JsonPropertyName("encrypted_applications")]
    public bool EncryptedApplications { get; set; }

    /// <summary>
    /// Whether the agent firewall is enabled
    /// </summary>
    /// <value>Whether the agent firewall is enabled</value>
    [JsonPropertyName("firewall_enabled")]
    public bool FirewallEnabled { get; set; }

    /// <summary>
    /// Whether the agent is currently flagged as infected
    /// </summary>
    /// <value>Whether the agent is currently flagged as infected</value>
    [JsonPropertyName("infected")]
    public bool Infected { get; set; }

    /// <summary>
    /// Whether the agent has been recently active and reporting
    /// </summary>
    /// <value>Whether the agent has been recently active and reporting</value>
    [JsonPropertyName("is_active")]
    public bool IsActive { get; set; }

    /// <summary>
    /// Whether the agent is running the latest available version
    /// </summary>
    /// <value>Whether the agent is running the latest available version</value>
    [JsonPropertyName("is_up_to_date")]
    public bool IsUpToDate { get; set; }

    /// <summary>
    /// The current operational state of the agent
    /// </summary>
    /// <value>The current operational state of the agent</value>
    [JsonPropertyName("operational_state")]
    public string OperationalState { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class SentinelOneMatchAttributes {\n");
        sb.Append("  ActiveThreats: ").Append(ActiveThreats).Append("\n");
        sb.Append("  EncryptedApplications: ").Append(EncryptedApplications).Append("\n");
        sb.Append("  FirewallEnabled: ").Append(FirewallEnabled).Append("\n");
        sb.Append("  Infected: ").Append(Infected).Append("\n");
        sb.Append("  IsActive: ").Append(IsActive).Append("\n");
        sb.Append("  IsUpToDate: ").Append(IsUpToDate).Append("\n");
        sb.Append("  NetworkStatus: ").Append(NetworkStatus).Append("\n");
        sb.Append("  OperationalState: ").Append(OperationalState).Append("\n");
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