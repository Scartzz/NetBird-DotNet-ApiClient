


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
/// Describes the operational activity within a peer&#39;s system.
/// </summary>
[DataContract(Name = "Process")]
public class Process : IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Process" /> class.
    /// </summary>
    /// <param name="linuxPath">Path to the process executable file in a Linux operating system.</param>
    /// <param name="macPath">Path to the process executable file in a Mac operating system.</param>
    /// <param name="windowsPath">Path to the process executable file in a Windows operating system.</param>
    public Process(string linuxPath = null, string macPath = null, string windowsPath = null)
    {
        this.LinuxPath = linuxPath;
        this.MacPath = macPath;
        this.WindowsPath = windowsPath;
    }

    /// <summary>
    /// Path to the process executable file in a Linux operating system
    /// </summary>
    /// <value>Path to the process executable file in a Linux operating system</value>
    /*
    <example>/usr/local/bin/netbird</example>
    */
    [JsonPropertyName("linux_path")]
    public string LinuxPath { get; set; }

    /// <summary>
    /// Path to the process executable file in a Mac operating system
    /// </summary>
    /// <value>Path to the process executable file in a Mac operating system</value>
    /*
    <example>/Applications/NetBird.app/Contents/MacOS/netbird</example>
    */
    [JsonPropertyName("mac_path")]
    public string MacPath { get; set; }

    /// <summary>
    /// Path to the process executable file in a Windows operating system
    /// </summary>
    /// <value>Path to the process executable file in a Windows operating system</value>
    /*
    <example>C:
rogramData
etBird
etbird.exe</example>
    */
    [JsonPropertyName("windows_path")]
    public string WindowsPath { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class Process {\n");
        sb.Append("  LinuxPath: ").Append(LinuxPath).Append("\n");
        sb.Append("  MacPath: ").Append(MacPath).Append("\n");
        sb.Append("  WindowsPath: ").Append(WindowsPath).Append("\n");
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