


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
/// UserPermissions
/// </summary>
[DataContract(Name = "UserPermissions")]
public class UserPermissions : IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="UserPermissions" /> class.
    /// </summary>
    [JsonConstructor]
    protected UserPermissions() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="UserPermissions" /> class.
    /// </summary>
    /// <param name="isRestricted">Indicates whether this User&#39;s Peers view is restricted (required).</param>
    /// <param name="modules">modules (required).</param>
    public UserPermissions(bool isRestricted = false, Dictionary<string, Dictionary<string, bool>> modules = null)
    {
        this.IsRestricted = isRestricted;
        // to ensure "modules" is required (not null)
        ArgumentNullException.ThrowIfNull(modules);
        this.Modules = modules;
    }

    /// <summary>
    /// Indicates whether this User&#39;s Peers view is restricted
    /// </summary>
    /// <value>Indicates whether this User&#39;s Peers view is restricted</value>
    [JsonPropertyName("is_restricted")]
    public bool IsRestricted { get; set; }

    /// <summary>
    /// Gets or Sets Modules
    /// </summary>
    /*
    <example>{networks&#x3D;{read&#x3D;true, create&#x3D;false, update&#x3D;false, delete&#x3D;false}, peers&#x3D;{read&#x3D;false, create&#x3D;false, update&#x3D;false, delete&#x3D;false}}</example>
    */
    [JsonPropertyName("modules")]
    public Dictionary<string, Dictionary<string, bool>> Modules { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class UserPermissions {\n");
        sb.Append("  IsRestricted: ").Append(IsRestricted).Append("\n");
        sb.Append("  Modules: ").Append(Modules).Append("\n");
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