


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
/// NetworkRequest
/// </summary>
[DataContract(Name = "NetworkRequest")]
public class NetworkRequest : IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="NetworkRequest" /> class.
    /// </summary>
    [JsonConstructor]
    protected NetworkRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="NetworkRequest" /> class.
    /// </summary>
    /// <param name="name">Network name (required).</param>
    /// <param name="description">Network description.</param>
    public NetworkRequest(string name = null, string description = null)
    {
        // to ensure "name" is required (not null)
        ArgumentNullException.ThrowIfNull(name);
        this.Name = name;
        this.Description = description;
    }

    /// <summary>
    /// Network name
    /// </summary>
    /// <value>Network name</value>
    /*
    <example>Remote Network 1</example>
    */
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// Network description
    /// </summary>
    /// <value>Network description</value>
    /*
    <example>A remote network that needs to be accessed</example>
    */
    [JsonPropertyName("description")]
    public string Description { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class NetworkRequest {\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
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