


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
/// PolicyRuleMinimum
/// </summary>
[DataContract(Name = "PolicyRuleMinimum")]
public class PolicyRuleMinimum : IValidatableObject
{
    /// <summary>
    /// Policy rule accept or drops packets
    /// </summary>
    /// <value>Policy rule accept or drops packets</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ActionEnum
    {
        /// <summary>
        /// Enum Accept for value: accept
        /// </summary>
        [EnumMember(Value = "accept")]
        Accept = 1,

        /// <summary>
        /// Enum Drop for value: drop
        /// </summary>
        [EnumMember(Value = "drop")]
        Drop = 2
    }


    /// <summary>
    /// Policy rule accept or drops packets
    /// </summary>
    /// <value>Policy rule accept or drops packets</value>
    /*
    <example>accept</example>
    */
    [JsonPropertyName("action")]
    public ActionEnum Action { get; set; }
    /// <summary>
    /// Policy rule type of the traffic
    /// </summary>
    /// <value>Policy rule type of the traffic</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ProtocolEnum
    {
        /// <summary>
        /// Enum All for value: all
        /// </summary>
        [EnumMember(Value = "all")]
        All = 1,

        /// <summary>
        /// Enum Tcp for value: tcp
        /// </summary>
        [EnumMember(Value = "tcp")]
        Tcp = 2,

        /// <summary>
        /// Enum Udp for value: udp
        /// </summary>
        [EnumMember(Value = "udp")]
        Udp = 3,

        /// <summary>
        /// Enum Icmp for value: icmp
        /// </summary>
        [EnumMember(Value = "icmp")]
        Icmp = 4,

        /// <summary>
        /// Enum NetbirdSsh for value: netbird-ssh
        /// </summary>
        [EnumMember(Value = "netbird-ssh")]
        NetbirdSsh = 5
    }


    /// <summary>
    /// Policy rule type of the traffic
    /// </summary>
    /// <value>Policy rule type of the traffic</value>
    /*
    <example>tcp</example>
    */
    [JsonPropertyName("protocol")]
    public ProtocolEnum Protocol { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="PolicyRuleMinimum" /> class.
    /// </summary>
    [JsonConstructor]
    protected PolicyRuleMinimum() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="PolicyRuleMinimum" /> class.
    /// </summary>
    /// <param name="name">Policy rule name identifier (required).</param>
    /// <param name="description">Policy rule friendly description.</param>
    /// <param name="enabled">Policy rule status (required).</param>
    /// <param name="action">Policy rule accept or drops packets (required).</param>
    /// <param name="bidirectional">Define if the rule is applicable in both directions, sources, and destinations. (required).</param>
    /// <param name="protocol">Policy rule type of the traffic (required).</param>
    /// <param name="ports">Policy rule affected ports.</param>
    /// <param name="portRanges">Policy rule affected ports ranges list.</param>
    /// <param name="authorizedGroups">Map of user group ids to a list of local users.</param>
    public PolicyRuleMinimum(string name = null, string description = null, bool enabled = false, ActionEnum action = default, bool bidirectional = false, ProtocolEnum protocol = default, List<string> ports = null, List<RulePortRange> portRanges = null, Dictionary<string, List<string>> authorizedGroups = null)
    {
        // to ensure "name" is required (not null)
        ArgumentNullException.ThrowIfNull(name);
        this.Name = name;
        this.Enabled = enabled;
        this.Action = action;
        this.Bidirectional = bidirectional;
        this.Protocol = protocol;
        this.Description = description;
        this.Ports = ports;
        this.PortRanges = portRanges;
        this.AuthorizedGroups = authorizedGroups;
    }

    /// <summary>
    /// Policy rule name identifier
    /// </summary>
    /// <value>Policy rule name identifier</value>
    /*
    <example>Default</example>
    */
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// Policy rule friendly description
    /// </summary>
    /// <value>Policy rule friendly description</value>
    /*
    <example>This is a default rule that allows connections between all the resources</example>
    */
    [JsonPropertyName("description")]
    public string Description { get; set; }

    /// <summary>
    /// Policy rule status
    /// </summary>
    /// <value>Policy rule status</value>
    /*
    <example>true</example>
    */
    [JsonPropertyName("enabled")]
    public bool Enabled { get; set; }

    /// <summary>
    /// Define if the rule is applicable in both directions, sources, and destinations.
    /// </summary>
    /// <value>Define if the rule is applicable in both directions, sources, and destinations.</value>
    /*
    <example>true</example>
    */
    [JsonPropertyName("bidirectional")]
    public bool Bidirectional { get; set; }

    /// <summary>
    /// Policy rule affected ports
    /// </summary>
    /// <value>Policy rule affected ports</value>
    [JsonPropertyName("ports")]
    public List<string> Ports { get; set; }

    /// <summary>
    /// Policy rule affected ports ranges list
    /// </summary>
    /// <value>Policy rule affected ports ranges list</value>
    [JsonPropertyName("port_ranges")]
    public List<RulePortRange> PortRanges { get; set; }

    /// <summary>
    /// Map of user group ids to a list of local users
    /// </summary>
    /// <value>Map of user group ids to a list of local users</value>
    [JsonPropertyName("authorized_groups")]
    public Dictionary<string, List<string>> AuthorizedGroups { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class PolicyRuleMinimum {\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  Enabled: ").Append(Enabled).Append("\n");
        sb.Append("  Action: ").Append(Action).Append("\n");
        sb.Append("  Bidirectional: ").Append(Bidirectional).Append("\n");
        sb.Append("  Protocol: ").Append(Protocol).Append("\n");
        sb.Append("  Ports: ").Append(Ports).Append("\n");
        sb.Append("  PortRanges: ").Append(PortRanges).Append("\n");
        sb.Append("  AuthorizedGroups: ").Append(AuthorizedGroups).Append("\n");
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