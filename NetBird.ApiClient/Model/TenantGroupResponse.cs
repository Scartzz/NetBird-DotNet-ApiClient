


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
/// TenantGroupResponse
/// </summary>
[DataContract(Name = "TenantGroupResponse")]
public class TenantGroupResponse : IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TenantGroupResponse" /> class.
    /// </summary>
    [JsonConstructor]
    protected TenantGroupResponse() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="TenantGroupResponse" /> class.
    /// </summary>
    /// <param name="id">The Group ID (required).</param>
    /// <param name="role">The Role name (required).</param>
    public TenantGroupResponse(string id = null, string role = null)
    {
        // to ensure "id" is required (not null)
        ArgumentNullException.ThrowIfNull(id);
        this.Id = id;
        // to ensure "role" is required (not null)
        ArgumentNullException.ThrowIfNull(role);
        this.Role = role;
    }

    /// <summary>
    /// The Group ID
    /// </summary>
    /// <value>The Group ID</value>
    /*
    <example>ch8i4ug6lnn4g9hqv7m0</example>
    */
    [JsonPropertyName("id")]
    public string Id { get; set; }

    /// <summary>
    /// The Role name
    /// </summary>
    /// <value>The Role name</value>
    /*
    <example>admin</example>
    */
    [JsonPropertyName("role")]
    public string Role { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class TenantGroupResponse {\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Role: ").Append(Role).Append("\n");
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