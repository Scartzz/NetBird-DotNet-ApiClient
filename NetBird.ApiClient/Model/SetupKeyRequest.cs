


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
/// SetupKeyRequest
/// </summary>
[DataContract(Name = "SetupKeyRequest")]
public class SetupKeyRequest : IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SetupKeyRequest" /> class.
    /// </summary>
    [JsonConstructor]
    protected SetupKeyRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="SetupKeyRequest" /> class.
    /// </summary>
    /// <param name="revoked">Setup key revocation status (required).</param>
    /// <param name="autoGroups">List of group IDs to auto-assign to peers registered with this key (required).</param>
    public SetupKeyRequest(bool revoked = false, List<string> autoGroups = null)
    {
        this.Revoked = revoked;
        // to ensure "autoGroups" is required (not null)
        ArgumentNullException.ThrowIfNull(autoGroups);
        this.AutoGroups = autoGroups;
    }

    /// <summary>
    /// Setup key revocation status
    /// </summary>
    /// <value>Setup key revocation status</value>
    /*
    <example>false</example>
    */
    [JsonPropertyName("revoked")]
    public bool Revoked { get; set; }

    /// <summary>
    /// List of group IDs to auto-assign to peers registered with this key
    /// </summary>
    /// <value>List of group IDs to auto-assign to peers registered with this key</value>
    [JsonPropertyName("auto_groups")]
    public List<string> AutoGroups { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class SetupKeyRequest {\n");
        sb.Append("  Revoked: ").Append(Revoked).Append("\n");
        sb.Append("  AutoGroups: ").Append(AutoGroups).Append("\n");
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