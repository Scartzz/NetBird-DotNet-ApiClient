


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
/// Resource
/// </summary>
[DataContract(Name = "Resource")]
public class Resource : IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Resource" /> class.
    /// </summary>
    [JsonConstructor]
    protected Resource() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="Resource" /> class.
    /// </summary>
    /// <param name="id">ID of the resource (required).</param>
    /// <param name="type">Type of the resource (required).</param>
    public Resource(string id = null, ResourceType type = null)
    {
        // to ensure "id" is required (not null)
        ArgumentNullException.ThrowIfNull(id);
        this.Id = id;
        // to ensure "type" is required (not null)
        ArgumentNullException.ThrowIfNull(type);
        this.Type = type;
    }

    /// <summary>
    /// ID of the resource
    /// </summary>
    /// <value>ID of the resource</value>
    /*
    <example>chacdk86lnnboviihd7g</example>
    */
    [JsonPropertyName("id")]
    public string Id { get; set; }

    /// <summary>
    /// Type of the resource
    /// </summary>
    /// <value>Type of the resource</value>
    [JsonPropertyName("type")]
    public ResourceType Type { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class Resource {\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
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