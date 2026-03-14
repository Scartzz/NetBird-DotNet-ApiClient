


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
/// NameserverGroup
/// </summary>
[DataContract(Name = "NameserverGroup")]
public class NameserverGroup : IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="NameserverGroup" /> class.
    /// </summary>
    [JsonConstructor]
    protected NameserverGroup() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="NameserverGroup" /> class.
    /// </summary>
    /// <param name="name">Name of nameserver group name (required).</param>
    /// <param name="description">Description of the nameserver group (required).</param>
    /// <param name="nameservers">Nameserver list (required).</param>
    /// <param name="enabled">Nameserver group status (required).</param>
    /// <param name="groups">Distribution group IDs that defines group of peers that will use this nameserver group (required).</param>
    /// <param name="primary">Defines if a nameserver group is primary that resolves all domains. It should be true only if domains list is empty. (required).</param>
    /// <param name="domains">Match domain list. It should be empty only if primary is true. (required).</param>
    /// <param name="searchDomainsEnabled">Search domain status for match domains. It should be true only if domains list is not empty. (required).</param>
    /// <param name="id">Nameserver group ID (required).</param>
    public NameserverGroup(string name = null, string description = null, List<Nameserver> nameservers = null, bool enabled = false, List<string> groups = null, bool primary = false, List<string> domains = null, bool searchDomainsEnabled = false, string id = null)
    {
        // to ensure "name" is required (not null)
        ArgumentNullException.ThrowIfNull(name);
        this.Name = name;
        // to ensure "description" is required (not null)
        ArgumentNullException.ThrowIfNull(description);
        this.Description = description;
        // to ensure "nameservers" is required (not null)
        ArgumentNullException.ThrowIfNull(nameservers);
        this.Nameservers = nameservers;
        this.Enabled = enabled;
        // to ensure "groups" is required (not null)
        ArgumentNullException.ThrowIfNull(groups);
        this.Groups = groups;
        this.Primary = primary;
        // to ensure "domains" is required (not null)
        ArgumentNullException.ThrowIfNull(domains);
        this.Domains = domains;
        this.SearchDomainsEnabled = searchDomainsEnabled;
        // to ensure "id" is required (not null)
        ArgumentNullException.ThrowIfNull(id);
        this.Id = id;
    }

    /// <summary>
    /// Name of nameserver group name
    /// </summary>
    /// <value>Name of nameserver group name</value>
    /*
    <example>Google DNS</example>
    */
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// Description of the nameserver group
    /// </summary>
    /// <value>Description of the nameserver group</value>
    /*
    <example>Google DNS servers</example>
    */
    [JsonPropertyName("description")]
    public string Description { get; set; }

    /// <summary>
    /// Nameserver list
    /// </summary>
    /// <value>Nameserver list</value>
    [JsonPropertyName("nameservers")]
    public List<Nameserver> Nameservers { get; set; }

    /// <summary>
    /// Nameserver group status
    /// </summary>
    /// <value>Nameserver group status</value>
    /*
    <example>true</example>
    */
    [JsonPropertyName("enabled")]
    public bool Enabled { get; set; }

    /// <summary>
    /// Distribution group IDs that defines group of peers that will use this nameserver group
    /// </summary>
    /// <value>Distribution group IDs that defines group of peers that will use this nameserver group</value>
    [JsonPropertyName("groups")]
    public List<string> Groups { get; set; }

    /// <summary>
    /// Defines if a nameserver group is primary that resolves all domains. It should be true only if domains list is empty.
    /// </summary>
    /// <value>Defines if a nameserver group is primary that resolves all domains. It should be true only if domains list is empty.</value>
    /*
    <example>true</example>
    */
    [JsonPropertyName("primary")]
    public bool Primary { get; set; }

    /// <summary>
    /// Match domain list. It should be empty only if primary is true.
    /// </summary>
    /// <value>Match domain list. It should be empty only if primary is true.</value>
    [JsonPropertyName("domains")]
    public List<string> Domains { get; set; }

    /// <summary>
    /// Search domain status for match domains. It should be true only if domains list is not empty.
    /// </summary>
    /// <value>Search domain status for match domains. It should be true only if domains list is not empty.</value>
    /*
    <example>true</example>
    */
    [JsonPropertyName("search_domains_enabled")]
    public bool SearchDomainsEnabled { get; set; }

    /// <summary>
    /// Nameserver group ID
    /// </summary>
    /// <value>Nameserver group ID</value>
    /*
    <example>ch8i4ug6lnn4g9hqv7m0</example>
    */
    [JsonPropertyName("id")]
    public string Id { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class NameserverGroup {\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  Nameservers: ").Append(Nameservers).Append("\n");
        sb.Append("  Enabled: ").Append(Enabled).Append("\n");
        sb.Append("  Groups: ").Append(Groups).Append("\n");
        sb.Append("  Primary: ").Append(Primary).Append("\n");
        sb.Append("  Domains: ").Append(Domains).Append("\n");
        sb.Append("  SearchDomainsEnabled: ").Append(SearchDomainsEnabled).Append("\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
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
        if (this.Name is not null && this.Name.Length > 40)
        {
            yield return new ValidationResult("Invalid value for Name, length must be less than 40.", new [] { "Name" });
        }

        // Name (string) minLength
        if (this.Name is not null && this.Name.Length < 1)
        {
            yield return new ValidationResult("Invalid value for Name, length must be greater than 1.", new [] { "Name" });
        }

        yield break;
    }
}