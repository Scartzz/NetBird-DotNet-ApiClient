


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
/// NetworkTrafficPolicy
/// </summary>
[DataContract(Name = "NetworkTrafficPolicy")]
public class NetworkTrafficPolicy : IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="NetworkTrafficPolicy" /> class.
    /// </summary>
    [JsonConstructor]
    protected NetworkTrafficPolicy() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="NetworkTrafficPolicy" /> class.
    /// </summary>
    /// <param name="id">ID of the policy that allowed this event. (required).</param>
    /// <param name="name">Name of the policy that allowed this event. (required).</param>
    public NetworkTrafficPolicy(string id = null, string name = null)
    {
        // to ensure "id" is required (not null)
        ArgumentNullException.ThrowIfNull(id);
        this.Id = id;
        // to ensure "name" is required (not null)
        ArgumentNullException.ThrowIfNull(name);
        this.Name = name;
    }

    /// <summary>
    /// ID of the policy that allowed this event.
    /// </summary>
    /// <value>ID of the policy that allowed this event.</value>
    /*
    <example>ch8i4ug6lnn4g9hqv7m0</example>
    */
    [JsonPropertyName("id")]
    public string Id { get; set; }

    /// <summary>
    /// Name of the policy that allowed this event.
    /// </summary>
    /// <value>Name of the policy that allowed this event.</value>
    /*
    <example>All to All</example>
    */
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class NetworkTrafficPolicy {\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
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