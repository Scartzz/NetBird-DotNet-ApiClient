


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
/// Instance status information
/// </summary>
[DataContract(Name = "InstanceStatus")]
public class InstanceStatus : IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="InstanceStatus" /> class.
    /// </summary>
    [JsonConstructor]
    protected InstanceStatus() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="InstanceStatus" /> class.
    /// </summary>
    /// <param name="setupRequired">Indicates whether the instance requires initial setup (required).</param>
    public InstanceStatus(bool setupRequired = false)
    {
        this.SetupRequired = setupRequired;
    }

    /// <summary>
    /// Indicates whether the instance requires initial setup
    /// </summary>
    /// <value>Indicates whether the instance requires initial setup</value>
    /*
    <example>true</example>
    */
    [JsonPropertyName("setup_required")]
    public bool SetupRequired { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class InstanceStatus {\n");
        sb.Append("  SetupRequired: ").Append(SetupRequired).Append("\n");
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