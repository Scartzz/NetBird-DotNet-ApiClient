


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
/// GroupRequest
/// </summary>
[DataContract(Name = "GroupRequest")]
public class GroupRequest : IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="GroupRequest" /> class.
    /// </summary>
    [JsonConstructor]
    protected GroupRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="GroupRequest" /> class.
    /// </summary>
    /// <param name="name">Group name identifier (required).</param>
    /// <param name="peers">List of peers ids.</param>
    /// <param name="resources">resources.</param>
    public GroupRequest(string name = null, List<string> peers = null, List<Resource> resources = null)
    {
        // to ensure "name" is required (not null)
        ArgumentNullException.ThrowIfNull(name);
        this.Name = name;
        this.Peers = peers;
        this.Resources = resources;
    }

    /// <summary>
    /// Group name identifier
    /// </summary>
    /// <value>Group name identifier</value>
    /*
    <example>devs</example>
    */
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// List of peers ids
    /// </summary>
    /// <value>List of peers ids</value>
    [JsonPropertyName("peers")]
    public List<string> Peers { get; set; }

    /// <summary>
    /// Gets or Sets Resources
    /// </summary>
    [JsonPropertyName("resources")]
    public List<Resource> Resources { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class GroupRequest {\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Peers: ").Append(Peers).Append("\n");
        sb.Append("  Resources: ").Append(Resources).Append("\n");
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