


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
/// UsageStats
/// </summary>
[DataContract(Name = "UsageStats")]
public class UsageStats : IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="UsageStats" /> class.
    /// </summary>
    [JsonConstructor]
    protected UsageStats() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="UsageStats" /> class.
    /// </summary>
    /// <param name="activeUsers">Number of active users. (required).</param>
    /// <param name="totalUsers">Total number of users. (required).</param>
    /// <param name="activePeers">Number of active peers. (required).</param>
    /// <param name="totalPeers">Total number of peers. (required).</param>
    public UsageStats(long activeUsers = 0, long totalUsers = 0, long activePeers = 0, long totalPeers = 0)
    {
        this.ActiveUsers = activeUsers;
        this.TotalUsers = totalUsers;
        this.ActivePeers = activePeers;
        this.TotalPeers = totalPeers;
    }

    /// <summary>
    /// Number of active users.
    /// </summary>
    /// <value>Number of active users.</value>
    /*
    <example>15</example>
    */
    [JsonPropertyName("active_users")]
    public long ActiveUsers { get; set; }

    /// <summary>
    /// Total number of users.
    /// </summary>
    /// <value>Total number of users.</value>
    /*
    <example>20</example>
    */
    [JsonPropertyName("total_users")]
    public long TotalUsers { get; set; }

    /// <summary>
    /// Number of active peers.
    /// </summary>
    /// <value>Number of active peers.</value>
    /*
    <example>10</example>
    */
    [JsonPropertyName("active_peers")]
    public long ActivePeers { get; set; }

    /// <summary>
    /// Total number of peers.
    /// </summary>
    /// <value>Total number of peers.</value>
    /*
    <example>25</example>
    */
    [JsonPropertyName("total_peers")]
    public long TotalPeers { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class UsageStats {\n");
        sb.Append("  ActiveUsers: ").Append(ActiveUsers).Append("\n");
        sb.Append("  TotalUsers: ").Append(TotalUsers).Append("\n");
        sb.Append("  ActivePeers: ").Append(ActivePeers).Append("\n");
        sb.Append("  TotalPeers: ").Append(TotalPeers).Append("\n");
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