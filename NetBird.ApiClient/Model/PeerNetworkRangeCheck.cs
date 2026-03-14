


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
/// Posture check for allow or deny access based on peer local network addresses
/// </summary>
[DataContract(Name = "PeerNetworkRangeCheck")]
public class PeerNetworkRangeCheck : IValidatableObject
{
    /// <summary>
    /// Action to take upon policy match
    /// </summary>
    /// <value>Action to take upon policy match</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ActionEnum
    {
        /// <summary>
        /// Enum Allow for value: allow
        /// </summary>
        [EnumMember(Value = "allow")]
        Allow = 1,

        /// <summary>
        /// Enum Deny for value: deny
        /// </summary>
        [EnumMember(Value = "deny")]
        Deny = 2
    }


    /// <summary>
    /// Action to take upon policy match
    /// </summary>
    /// <value>Action to take upon policy match</value>
    /*
    <example>allow</example>
    */
    [JsonPropertyName("action")]
    public ActionEnum Action { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="PeerNetworkRangeCheck" /> class.
    /// </summary>
    [JsonConstructor]
    protected PeerNetworkRangeCheck() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="PeerNetworkRangeCheck" /> class.
    /// </summary>
    /// <param name="ranges">List of peer network ranges in CIDR notation (required).</param>
    /// <param name="action">Action to take upon policy match (required).</param>
    public PeerNetworkRangeCheck(List<string> ranges = null, ActionEnum action = default)
    {
        // to ensure "ranges" is required (not null)
        ArgumentNullException.ThrowIfNull(ranges);
        this.Ranges = ranges;
        this.Action = action;
    }

    /// <summary>
    /// List of peer network ranges in CIDR notation
    /// </summary>
    /// <value>List of peer network ranges in CIDR notation</value>
    /*
    <example>[192.168.1.0/24, 10.0.0.0/8, 2001:db8:1234:1a00::/56]</example>
    */
    [JsonPropertyName("ranges")]
    public List<string> Ranges { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class PeerNetworkRangeCheck {\n");
        sb.Append("  Ranges: ").Append(Ranges).Append("\n");
        sb.Append("  Action: ").Append(Action).Append("\n");
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