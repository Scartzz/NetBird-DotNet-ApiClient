


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
/// BundleResult
/// </summary>
[DataContract(Name = "BundleResult")]
public class BundleResult : IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BundleResult" /> class.
    /// </summary>
    /// <param name="uploadKey">uploadKey.</param>
    public BundleResult(string uploadKey = null)
    {
        this.UploadKey = uploadKey;
    }

    /// <summary>
    /// Gets or Sets UploadKey
    /// </summary>
    /*
    <example>upload_key_123</example>
    */
    [JsonPropertyName("upload_key")]
    public string UploadKey { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class BundleResult {\n");
        sb.Append("  UploadKey: ").Append(UploadKey).Append("\n");
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