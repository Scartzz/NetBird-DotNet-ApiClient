


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
/// NetworkResourceRequest
/// </summary>
[DataContract(Name = "NetworkResourceRequest")]
public class NetworkResourceRequest : IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="NetworkResourceRequest" /> class.
    /// </summary>
    [JsonConstructor]
    protected NetworkResourceRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="NetworkResourceRequest" /> class.
    /// </summary>
    /// <param name="name">Network resource name (required).</param>
    /// <param name="description">Network resource description.</param>
    /// <param name="address">Network resource address (either a direct host like 1.1.1.1 or 1.1.1.1/32, or a subnet like 192.168.178.0/24, or domains like example.com and *.example.com) (required).</param>
    /// <param name="enabled">Network resource status (required).</param>
    /// <param name="groups">Group IDs containing the resource (required).</param>
    public NetworkResourceRequest(string name = null, string description = null, string address = null, bool enabled = false, List<string> groups = null)
    {
        // to ensure "name" is required (not null)
        ArgumentNullException.ThrowIfNull(name);
        this.Name = name;
        // to ensure "address" is required (not null)
        ArgumentNullException.ThrowIfNull(address);
        this.Address = address;
        this.Enabled = enabled;
        // to ensure "groups" is required (not null)
        ArgumentNullException.ThrowIfNull(groups);
        this.Groups = groups;
        this.Description = description;
    }

    /// <summary>
    /// Network resource name
    /// </summary>
    /// <value>Network resource name</value>
    /*
    <example>Remote Resource 1</example>
    */
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// Network resource description
    /// </summary>
    /// <value>Network resource description</value>
    /*
    <example>A remote resource inside network 1</example>
    */
    [JsonPropertyName("description")]
    public string Description { get; set; }

    /// <summary>
    /// Network resource address (either a direct host like 1.1.1.1 or 1.1.1.1/32, or a subnet like 192.168.178.0/24, or domains like example.com and *.example.com)
    /// </summary>
    /// <value>Network resource address (either a direct host like 1.1.1.1 or 1.1.1.1/32, or a subnet like 192.168.178.0/24, or domains like example.com and *.example.com)</value>
    /*
    <example>1.1.1.1</example>
    */
    [JsonPropertyName("address")]
    public string Address { get; set; }

    /// <summary>
    /// Network resource status
    /// </summary>
    /// <value>Network resource status</value>
    /*
    <example>true</example>
    */
    [JsonPropertyName("enabled")]
    public bool Enabled { get; set; }

    /// <summary>
    /// Group IDs containing the resource
    /// </summary>
    /// <value>Group IDs containing the resource</value>
    [JsonPropertyName("groups")]
    public List<string> Groups { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class NetworkResourceRequest {\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  Address: ").Append(Address).Append("\n");
        sb.Append("  Enabled: ").Append(Enabled).Append("\n");
        sb.Append("  Groups: ").Append(Groups).Append("\n");
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