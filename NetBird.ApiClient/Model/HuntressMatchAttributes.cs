


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
[DataContract(Name = "HuntressMatchAttributes")]
public class HuntressMatchAttributes : IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="HuntressMatchAttributes" /> class.
    /// </summary>
    /// <param name="defenderPolicyStatus">Policy status of Defender AV for Managed Antivirus..</param>
    /// <param name="defenderStatus">Status of Defender AV Managed Antivirus..</param>
    /// <param name="defenderSubstatus">Sub-status of Defender AV Managed Antivirus..</param>
    /// <param name="firewallStatus">Status of agent firewall. Can be one of Disabled, Enabled, Pending Isolation, Isolated, Pending Release..</param>
    public HuntressMatchAttributes(string defenderPolicyStatus = null, string defenderStatus = null, string defenderSubstatus = null, string firewallStatus = null)
    {
        this.DefenderPolicyStatus = defenderPolicyStatus;
        this.DefenderStatus = defenderStatus;
        this.DefenderSubstatus = defenderSubstatus;
        this.FirewallStatus = firewallStatus;
    }

    /// <summary>
    /// Policy status of Defender AV for Managed Antivirus.
    /// </summary>
    /// <value>Policy status of Defender AV for Managed Antivirus.</value>
    /*
    <example>Compliant</example>
    */
    [JsonPropertyName("defender_policy_status")]
    public string DefenderPolicyStatus { get; set; }

    /// <summary>
    /// Status of Defender AV Managed Antivirus.
    /// </summary>
    /// <value>Status of Defender AV Managed Antivirus.</value>
    /*
    <example>Healthy</example>
    */
    [JsonPropertyName("defender_status")]
    public string DefenderStatus { get; set; }

    /// <summary>
    /// Sub-status of Defender AV Managed Antivirus.
    /// </summary>
    /// <value>Sub-status of Defender AV Managed Antivirus.</value>
    /*
    <example>Up to date</example>
    */
    [JsonPropertyName("defender_substatus")]
    public string DefenderSubstatus { get; set; }

    /// <summary>
    /// Status of agent firewall. Can be one of Disabled, Enabled, Pending Isolation, Isolated, Pending Release.
    /// </summary>
    /// <value>Status of agent firewall. Can be one of Disabled, Enabled, Pending Isolation, Isolated, Pending Release.</value>
    /*
    <example>Enabled</example>
    */
    [JsonPropertyName("firewall_status")]
    public string FirewallStatus { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class HuntressMatchAttributes {\n");
        sb.Append("  DefenderPolicyStatus: ").Append(DefenderPolicyStatus).Append("\n");
        sb.Append("  DefenderStatus: ").Append(DefenderStatus).Append("\n");
        sb.Append("  DefenderSubstatus: ").Append(DefenderSubstatus).Append("\n");
        sb.Append("  FirewallStatus: ").Append(FirewallStatus).Append("\n");
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