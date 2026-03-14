


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
/// Zone
/// </summary>
[DataContract(Name = "Zone")]
public class Zone : IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Zone" /> class.
    /// </summary>
    [JsonConstructor]
    protected Zone() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="Zone" /> class.
    /// </summary>
    /// <param name="name">Zone name identifier (required).</param>
    /// <param name="domain">Zone domain (FQDN) (required).</param>
    /// <param name="enabled">Zone status (default to true).</param>
    /// <param name="enableSearchDomain">Enable this zone as a search domain (required).</param>
    /// <param name="distributionGroups">Group IDs that defines groups of peers that will resolve this zone (required).</param>
    /// <param name="id">Zone ID (required).</param>
    /// <param name="records">DNS records associated with this zone (required).</param>
    public Zone(string name = null, string domain = null, bool enabled = true, bool enableSearchDomain = false, List<string> distributionGroups = null, string id = null, List<DNSRecord> records = null)
    {
        // to ensure "name" is required (not null)
        ArgumentNullException.ThrowIfNull(name);
        this.Name = name;
        // to ensure "domain" is required (not null)
        ArgumentNullException.ThrowIfNull(domain);
        this.Domain = domain;
        this.EnableSearchDomain = enableSearchDomain;
        // to ensure "distributionGroups" is required (not null)
        ArgumentNullException.ThrowIfNull(distributionGroups);
        this.DistributionGroups = distributionGroups;
        // to ensure "id" is required (not null)
        ArgumentNullException.ThrowIfNull(id);
        this.Id = id;
        // to ensure "records" is required (not null)
        ArgumentNullException.ThrowIfNull(records);
        this.Records = records;
        this.Enabled = enabled;
    }

    /// <summary>
    /// Zone name identifier
    /// </summary>
    /// <value>Zone name identifier</value>
    /*
    <example>Office Zone</example>
    */
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// Zone domain (FQDN)
    /// </summary>
    /// <value>Zone domain (FQDN)</value>
    /*
    <example>example.com</example>
    */
    [JsonPropertyName("domain")]
    public string Domain { get; set; }

    /// <summary>
    /// Zone status
    /// </summary>
    /// <value>Zone status</value>
    [JsonPropertyName("enabled")]
    public bool Enabled { get; set; }

    /// <summary>
    /// Enable this zone as a search domain
    /// </summary>
    /// <value>Enable this zone as a search domain</value>
    /*
    <example>false</example>
    */
    [JsonPropertyName("enable_search_domain")]
    public bool EnableSearchDomain { get; set; }

    /// <summary>
    /// Group IDs that defines groups of peers that will resolve this zone
    /// </summary>
    /// <value>Group IDs that defines groups of peers that will resolve this zone</value>
    [JsonPropertyName("distribution_groups")]
    public List<string> DistributionGroups { get; set; }

    /// <summary>
    /// Zone ID
    /// </summary>
    /// <value>Zone ID</value>
    /*
    <example>ch8i4ug6lnn4g9hqv7m0</example>
    */
    [JsonPropertyName("id")]
    public string Id { get; set; }

    /// <summary>
    /// DNS records associated with this zone
    /// </summary>
    /// <value>DNS records associated with this zone</value>
    [JsonPropertyName("records")]
    public List<DNSRecord> Records { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class Zone {\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Domain: ").Append(Domain).Append("\n");
        sb.Append("  Enabled: ").Append(Enabled).Append("\n");
        sb.Append("  EnableSearchDomain: ").Append(EnableSearchDomain).Append("\n");
        sb.Append("  DistributionGroups: ").Append(DistributionGroups).Append("\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Records: ").Append(Records).Append("\n");
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
        // Name (string) maxLength
        if (this.Name is not null && this.Name.Length > 255)
        {
            yield return new ValidationResult("Invalid value for Name, length must be less than 255.", new [] { "Name" });
        }

        // Name (string) minLength
        if (this.Name is not null && this.Name.Length < 1)
        {
            yield return new ValidationResult("Invalid value for Name, length must be greater than 1.", new [] { "Name" });
        }

        yield break;
    }
}