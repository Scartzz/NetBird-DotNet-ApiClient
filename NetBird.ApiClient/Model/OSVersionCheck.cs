


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
/// Posture check for the version of operating system
/// </summary>
[DataContract(Name = "OSVersionCheck")]
public class OSVersionCheck : IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="OSVersionCheck" /> class.
    /// </summary>
    /// <param name="android">Minimum version of Android.</param>
    /// <param name="darwin">darwin.</param>
    /// <param name="ios">Minimum version of iOS.</param>
    /// <param name="linux">Minimum Linux kernel version.</param>
    /// <param name="windows">Minimum Windows kernel build version.</param>
    public OSVersionCheck(MinVersionCheck android = null, MinVersionCheck darwin = null, MinVersionCheck ios = null, MinKernelVersionCheck linux = null, MinKernelVersionCheck windows = null)
    {
        this.Android = android;
        this.Darwin = darwin;
        this.Ios = ios;
        this.Linux = linux;
        this.Windows = windows;
    }

    /// <summary>
    /// Minimum version of Android
    /// </summary>
    /// <value>Minimum version of Android</value>
    [JsonPropertyName("android")]
    public MinVersionCheck Android { get; set; }

    /// <summary>
    /// Gets or Sets Darwin
    /// </summary>
    [JsonPropertyName("darwin")]
    public MinVersionCheck Darwin { get; set; }

    /// <summary>
    /// Minimum version of iOS
    /// </summary>
    /// <value>Minimum version of iOS</value>
    [JsonPropertyName("ios")]
    public MinVersionCheck Ios { get; set; }

    /// <summary>
    /// Minimum Linux kernel version
    /// </summary>
    /// <value>Minimum Linux kernel version</value>
    [JsonPropertyName("linux")]
    public MinKernelVersionCheck Linux { get; set; }

    /// <summary>
    /// Minimum Windows kernel build version
    /// </summary>
    /// <value>Minimum Windows kernel build version</value>
    [JsonPropertyName("windows")]
    public MinKernelVersionCheck Windows { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class OSVersionCheck {\n");
        sb.Append("  Android: ").Append(Android).Append("\n");
        sb.Append("  Darwin: ").Append(Darwin).Append("\n");
        sb.Append("  Ios: ").Append(Ios).Append("\n");
        sb.Append("  Linux: ").Append(Linux).Append("\n");
        sb.Append("  Windows: ").Append(Windows).Append("\n");
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