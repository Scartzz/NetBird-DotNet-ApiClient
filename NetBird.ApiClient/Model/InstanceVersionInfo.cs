


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
/// Version information for NetBird components
/// </summary>
[DataContract(Name = "InstanceVersionInfo")]
public class InstanceVersionInfo : IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="InstanceVersionInfo" /> class.
    /// </summary>
    [JsonConstructor]
    protected InstanceVersionInfo() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="InstanceVersionInfo" /> class.
    /// </summary>
    /// <param name="managementCurrentVersion">The current running version of the management server (required).</param>
    /// <param name="dashboardAvailableVersion">The latest available version of the dashboard (from GitHub releases).</param>
    /// <param name="managementAvailableVersion">The latest available version of the management server (from GitHub releases).</param>
    /// <param name="managementUpdateAvailable">Indicates if a newer management version is available (required).</param>
    public InstanceVersionInfo(string managementCurrentVersion = null, string dashboardAvailableVersion = null, string managementAvailableVersion = null, bool managementUpdateAvailable = false)
    {
        // to ensure "managementCurrentVersion" is required (not null)
        ArgumentNullException.ThrowIfNull(managementCurrentVersion);
        this.ManagementCurrentVersion = managementCurrentVersion;
        this.ManagementUpdateAvailable = managementUpdateAvailable;
        this.DashboardAvailableVersion = dashboardAvailableVersion;
        this.ManagementAvailableVersion = managementAvailableVersion;
    }

    /// <summary>
    /// The current running version of the management server
    /// </summary>
    /// <value>The current running version of the management server</value>
    /*
    <example>0.35.0</example>
    */
    [JsonPropertyName("management_current_version")]
    public string ManagementCurrentVersion { get; set; }

    /// <summary>
    /// The latest available version of the dashboard (from GitHub releases)
    /// </summary>
    /// <value>The latest available version of the dashboard (from GitHub releases)</value>
    /*
    <example>2.10.0</example>
    */
    [JsonPropertyName("dashboard_available_version")]
    public string DashboardAvailableVersion { get; set; }

    /// <summary>
    /// The latest available version of the management server (from GitHub releases)
    /// </summary>
    /// <value>The latest available version of the management server (from GitHub releases)</value>
    /*
    <example>0.35.0</example>
    */
    [JsonPropertyName("management_available_version")]
    public string ManagementAvailableVersion { get; set; }

    /// <summary>
    /// Indicates if a newer management version is available
    /// </summary>
    /// <value>Indicates if a newer management version is available</value>
    /*
    <example>true</example>
    */
    [JsonPropertyName("management_update_available")]
    public bool ManagementUpdateAvailable { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class InstanceVersionInfo {\n");
        sb.Append("  ManagementCurrentVersion: ").Append(ManagementCurrentVersion).Append("\n");
        sb.Append("  DashboardAvailableVersion: ").Append(DashboardAvailableVersion).Append("\n");
        sb.Append("  ManagementAvailableVersion: ").Append(ManagementAvailableVersion).Append("\n");
        sb.Append("  ManagementUpdateAvailable: ").Append(ManagementUpdateAvailable).Append("\n");
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