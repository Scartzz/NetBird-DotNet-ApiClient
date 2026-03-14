


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
/// PINAuthConfig
/// </summary>
[DataContract(Name = "PINAuthConfig")]
public class PINAuthConfig : IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PINAuthConfig" /> class.
    /// </summary>
    [JsonConstructor]
    protected PINAuthConfig() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="PINAuthConfig" /> class.
    /// </summary>
    /// <param name="enabled">Whether PIN auth is enabled (required).</param>
    /// <param name="pin">PIN value (required).</param>
    public PINAuthConfig(bool enabled = false, string pin = null)
    {
        this.Enabled = enabled;
        // to ensure "pin" is required (not null)
        ArgumentNullException.ThrowIfNull(pin);
        this.Pin = pin;
    }

    /// <summary>
    /// Whether PIN auth is enabled
    /// </summary>
    /// <value>Whether PIN auth is enabled</value>
    [JsonPropertyName("enabled")]
    public bool Enabled { get; set; }

    /// <summary>
    /// PIN value
    /// </summary>
    /// <value>PIN value</value>
    [JsonPropertyName("pin")]
    public string Pin { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class PINAuthConfig {\n");
        sb.Append("  Enabled: ").Append(Enabled).Append("\n");
        sb.Append("  Pin: ").Append(Pin).Append("\n");
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