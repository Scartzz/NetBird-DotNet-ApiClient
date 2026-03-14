


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
/// BearerAuthConfig
/// </summary>
[DataContract(Name = "BearerAuthConfig")]
public class BearerAuthConfig : IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BearerAuthConfig" /> class.
    /// </summary>
    [JsonConstructor]
    protected BearerAuthConfig() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="BearerAuthConfig" /> class.
    /// </summary>
    /// <param name="enabled">Whether bearer auth is enabled (required).</param>
    /// <param name="distributionGroups">List of group IDs that can use bearer auth.</param>
    public BearerAuthConfig(bool enabled = false, List<string> distributionGroups = null)
    {
        this.Enabled = enabled;
        this.DistributionGroups = distributionGroups;
    }

    /// <summary>
    /// Whether bearer auth is enabled
    /// </summary>
    /// <value>Whether bearer auth is enabled</value>
    [JsonPropertyName("enabled")]
    public bool Enabled { get; set; }

    /// <summary>
    /// List of group IDs that can use bearer auth
    /// </summary>
    /// <value>List of group IDs that can use bearer auth</value>
    [JsonPropertyName("distribution_groups")]
    public List<string> DistributionGroups { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class BearerAuthConfig {\n");
        sb.Append("  Enabled: ").Append(Enabled).Append("\n");
        sb.Append("  DistributionGroups: ").Append(DistributionGroups).Append("\n");
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