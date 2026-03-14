


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
/// CreateSetupKeyRequest
/// </summary>
[DataContract(Name = "CreateSetupKeyRequest")]
public class CreateSetupKeyRequest : IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CreateSetupKeyRequest" /> class.
    /// </summary>
    [JsonConstructor]
    protected CreateSetupKeyRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="CreateSetupKeyRequest" /> class.
    /// </summary>
    /// <param name="name">Setup Key name (required).</param>
    /// <param name="type">Setup key type, one-off for single time usage and reusable (required).</param>
    /// <param name="expiresIn">Expiration time in seconds (required).</param>
    /// <param name="autoGroups">List of group IDs to auto-assign to peers registered with this key (required).</param>
    /// <param name="usageLimit">A number of times this key can be used. The value of 0 indicates the unlimited usage. (required).</param>
    /// <param name="ephemeral">Indicate that the peer will be ephemeral or not.</param>
    /// <param name="allowExtraDnsLabels">Allow extra DNS labels to be added to the peer.</param>
    public CreateSetupKeyRequest(string name = null, string type = null, int expiresIn = 0, List<string> autoGroups = null, int usageLimit = 0, bool ephemeral = false, bool allowExtraDnsLabels = false)
    {
        // to ensure "name" is required (not null)
        ArgumentNullException.ThrowIfNull(name);
        this.Name = name;
        // to ensure "type" is required (not null)
        ArgumentNullException.ThrowIfNull(type);
        this.Type = type;
        this.ExpiresIn = expiresIn;
        // to ensure "autoGroups" is required (not null)
        ArgumentNullException.ThrowIfNull(autoGroups);
        this.AutoGroups = autoGroups;
        this.UsageLimit = usageLimit;
        this.Ephemeral = ephemeral;
        this.AllowExtraDnsLabels = allowExtraDnsLabels;
    }

    /// <summary>
    /// Setup Key name
    /// </summary>
    /// <value>Setup Key name</value>
    /*
    <example>Default key</example>
    */
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// Setup key type, one-off for single time usage and reusable
    /// </summary>
    /// <value>Setup key type, one-off for single time usage and reusable</value>
    /*
    <example>reusable</example>
    */
    [JsonPropertyName("type")]
    public string Type { get; set; }

    /// <summary>
    /// Expiration time in seconds
    /// </summary>
    /// <value>Expiration time in seconds</value>
    /*
    <example>86400</example>
    */
    [JsonPropertyName("expires_in")]
    public int ExpiresIn { get; set; }

    /// <summary>
    /// List of group IDs to auto-assign to peers registered with this key
    /// </summary>
    /// <value>List of group IDs to auto-assign to peers registered with this key</value>
    [JsonPropertyName("auto_groups")]
    public List<string> AutoGroups { get; set; }

    /// <summary>
    /// A number of times this key can be used. The value of 0 indicates the unlimited usage.
    /// </summary>
    /// <value>A number of times this key can be used. The value of 0 indicates the unlimited usage.</value>
    /*
    <example>0</example>
    */
    [JsonPropertyName("usage_limit")]
    public int UsageLimit { get; set; }

    /// <summary>
    /// Indicate that the peer will be ephemeral or not
    /// </summary>
    /// <value>Indicate that the peer will be ephemeral or not</value>
    /*
    <example>true</example>
    */
    [JsonPropertyName("ephemeral")]
    public bool Ephemeral { get; set; }

    /// <summary>
    /// Allow extra DNS labels to be added to the peer
    /// </summary>
    /// <value>Allow extra DNS labels to be added to the peer</value>
    /*
    <example>true</example>
    */
    [JsonPropertyName("allow_extra_dns_labels")]
    public bool AllowExtraDnsLabels { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class CreateSetupKeyRequest {\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  ExpiresIn: ").Append(ExpiresIn).Append("\n");
        sb.Append("  AutoGroups: ").Append(AutoGroups).Append("\n");
        sb.Append("  UsageLimit: ").Append(UsageLimit).Append("\n");
        sb.Append("  Ephemeral: ").Append(Ephemeral).Append("\n");
        sb.Append("  AllowExtraDnsLabels: ").Append(AllowExtraDnsLabels).Append("\n");
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
        // ExpiresIn (int) maximum
        if (this.ExpiresIn > (int)31536000)
        {
            yield return new ValidationResult("Invalid value for ExpiresIn, must be a value less than or equal to 31536000.", new [] { "ExpiresIn" });
        }

        // ExpiresIn (int) minimum
        if (this.ExpiresIn < (int)86400)
        {
            yield return new ValidationResult("Invalid value for ExpiresIn, must be a value greater than or equal to 86400.", new [] { "ExpiresIn" });
        }

        yield break;
    }
}