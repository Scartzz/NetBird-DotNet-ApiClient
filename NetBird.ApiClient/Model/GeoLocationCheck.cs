


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
/// Posture check for geo location
/// </summary>
[DataContract(Name = "GeoLocationCheck")]
public class GeoLocationCheck : IValidatableObject
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
    /// Initializes a new instance of the <see cref="GeoLocationCheck" /> class.
    /// </summary>
    [JsonConstructor]
    protected GeoLocationCheck() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="GeoLocationCheck" /> class.
    /// </summary>
    /// <param name="locations">List of geo locations to which the policy applies (required).</param>
    /// <param name="action">Action to take upon policy match (required).</param>
    public GeoLocationCheck(List<Location> locations = null, ActionEnum action = default)
    {
        // to ensure "locations" is required (not null)
        ArgumentNullException.ThrowIfNull(locations);
        this.Locations = locations;
        this.Action = action;
    }

    /// <summary>
    /// List of geo locations to which the policy applies
    /// </summary>
    /// <value>List of geo locations to which the policy applies</value>
    [JsonPropertyName("locations")]
    public List<Location> Locations { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class GeoLocationCheck {\n");
        sb.Append("  Locations: ").Append(Locations).Append("\n");
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