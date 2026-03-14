


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
/// DNSSettings
/// </summary>
[DataContract(Name = "DNSSettings")]
public class DNSSettings : IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DNSSettings" /> class.
    /// </summary>
    [JsonConstructor]
    protected DNSSettings() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="DNSSettings" /> class.
    /// </summary>
    /// <param name="disabledManagementGroups">Groups whose DNS management is disabled (required).</param>
    public DNSSettings(List<string> disabledManagementGroups = null)
    {
        // to ensure "disabledManagementGroups" is required (not null)
        ArgumentNullException.ThrowIfNull(disabledManagementGroups);
        this.DisabledManagementGroups = disabledManagementGroups;
    }

    /// <summary>
    /// Groups whose DNS management is disabled
    /// </summary>
    /// <value>Groups whose DNS management is disabled</value>
    [JsonPropertyName("disabled_management_groups")]
    public List<string> DisabledManagementGroups { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class DNSSettings {\n");
        sb.Append("  DisabledManagementGroups: ").Append(DisabledManagementGroups).Append("\n");
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