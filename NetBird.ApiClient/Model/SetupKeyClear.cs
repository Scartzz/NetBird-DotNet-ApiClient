


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
/// SetupKeyClear
/// </summary>
[DataContract(Name = "SetupKeyClear")]
public class SetupKeyClear : IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SetupKeyClear" /> class.
    /// </summary>
    [JsonConstructor]
    protected SetupKeyClear() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="SetupKeyClear" /> class.
    /// </summary>
    /// <param name="id">Setup Key ID (required).</param>
    /// <param name="name">Setup key name identifier (required).</param>
    /// <param name="expires">Setup Key expiration date (required).</param>
    /// <param name="type">Setup key type, one-off for single time usage and reusable (required).</param>
    /// <param name="valid">Setup key validity status (required).</param>
    /// <param name="revoked">Setup key revocation status (required).</param>
    /// <param name="usedTimes">Usage count of setup key (required).</param>
    /// <param name="lastUsed">Setup key last usage date (required).</param>
    /// <param name="state">Setup key status, \&quot;valid\&quot;, \&quot;overused\&quot;,\&quot;expired\&quot; or \&quot;revoked\&quot; (required).</param>
    /// <param name="autoGroups">List of group IDs to auto-assign to peers registered with this key (required).</param>
    /// <param name="updatedAt">Setup key last update date (required).</param>
    /// <param name="usageLimit">A number of times this key can be used. The value of 0 indicates the unlimited usage. (required).</param>
    /// <param name="ephemeral">Indicate that the peer will be ephemeral or not (required).</param>
    /// <param name="allowExtraDnsLabels">Allow extra DNS labels to be added to the peer (required).</param>
    /// <param name="key">Setup Key as plain text (required).</param>
    public SetupKeyClear(string id = null, string name = null, DateTimeOffset expires = default, string type = null, bool valid = false, bool revoked = false, int usedTimes = 0, DateTimeOffset lastUsed = default, string state = null, List<string> autoGroups = null, DateTimeOffset updatedAt = default, int usageLimit = 0, bool ephemeral = false, bool allowExtraDnsLabels = false, string key = null)
    {
        // to ensure "id" is required (not null)
        ArgumentNullException.ThrowIfNull(id);
        this.Id = id;
        // to ensure "name" is required (not null)
        ArgumentNullException.ThrowIfNull(name);
        this.Name = name;
        this.Expires = expires;
        // to ensure "type" is required (not null)
        ArgumentNullException.ThrowIfNull(type);
        this.Type = type;
        this.Valid = valid;
        this.Revoked = revoked;
        this.UsedTimes = usedTimes;
        this.LastUsed = lastUsed;
        // to ensure "state" is required (not null)
        ArgumentNullException.ThrowIfNull(state);
        this.State = state;
        // to ensure "autoGroups" is required (not null)
        ArgumentNullException.ThrowIfNull(autoGroups);
        this.AutoGroups = autoGroups;
        this.UpdatedAt = updatedAt;
        this.UsageLimit = usageLimit;
        this.Ephemeral = ephemeral;
        this.AllowExtraDnsLabels = allowExtraDnsLabels;
        // to ensure "key" is required (not null)
        ArgumentNullException.ThrowIfNull(key);
        this.Key = key;
    }

    /// <summary>
    /// Setup Key ID
    /// </summary>
    /// <value>Setup Key ID</value>
    /*
    <example>2531583362</example>
    */
    [JsonPropertyName("id")]
    public string Id { get; set; }

    /// <summary>
    /// Setup key name identifier
    /// </summary>
    /// <value>Setup key name identifier</value>
    /*
    <example>Default key</example>
    */
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// Setup Key expiration date
    /// </summary>
    /// <value>Setup Key expiration date</value>
    /*
    <example>2023-06-01T14:47:22.291057Z</example>
    */
    [JsonPropertyName("expires")]
    public DateTimeOffset Expires { get; set; }

    /// <summary>
    /// Setup key type, one-off for single time usage and reusable
    /// </summary>
    /// <value>Setup key type, one-off for single time usage and reusable</value>
    /*
    <example>reusable</example>
    */
    [JsonPropertyName("type")]
    public string Type { get; set; }

    /// <summary>
    /// Setup key validity status
    /// </summary>
    /// <value>Setup key validity status</value>
    /*
    <example>true</example>
    */
    [JsonPropertyName("valid")]
    public bool Valid { get; set; }

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
    /// Usage count of setup key
    /// </summary>
    /// <value>Usage count of setup key</value>
    /*
    <example>2</example>
    */
    [JsonPropertyName("used_times")]
    public int UsedTimes { get; set; }

    /// <summary>
    /// Setup key last usage date
    /// </summary>
    /// <value>Setup key last usage date</value>
    /*
    <example>2023-05-05T09:00:35.477782Z</example>
    */
    [JsonPropertyName("last_used")]
    public DateTimeOffset LastUsed { get; set; }

    /// <summary>
    /// Setup key status, \&quot;valid\&quot;, \&quot;overused\&quot;,\&quot;expired\&quot; or \&quot;revoked\&quot;
    /// </summary>
    /// <value>Setup key status, \&quot;valid\&quot;, \&quot;overused\&quot;,\&quot;expired\&quot; or \&quot;revoked\&quot;</value>
    /*
    <example>valid</example>
    */
    [JsonPropertyName("state")]
    public string State { get; set; }

    /// <summary>
    /// List of group IDs to auto-assign to peers registered with this key
    /// </summary>
    /// <value>List of group IDs to auto-assign to peers registered with this key</value>
    [JsonPropertyName("auto_groups")]
    public List<string> AutoGroups { get; set; }

    /// <summary>
    /// Setup key last update date
    /// </summary>
    /// <value>Setup key last update date</value>
    /*
    <example>2023-05-05T09:00:35.477782Z</example>
    */
    [JsonPropertyName("updated_at")]
    public DateTimeOffset UpdatedAt { get; set; }

    /// <summary>
    /// A number of times this key can be used. The value of 0 indicates the unlimited usage.
    /// </summary>
    /// <value>A number of times this key can be used. The value of 0 indicates the unlimited usage.</value>
    /*
    <example>0</example>
    */
    [JsonPropertyName("usage_limit")]
    public int UsageLimit { get; set; }

    /// <summary>
    /// Indicate that the peer will be ephemeral or not
    /// </summary>
    /// <value>Indicate that the peer will be ephemeral or not</value>
    /*
    <example>true</example>
    */
    [JsonPropertyName("ephemeral")]
    public bool Ephemeral { get; set; }

    /// <summary>
    /// Allow extra DNS labels to be added to the peer
    /// </summary>
    /// <value>Allow extra DNS labels to be added to the peer</value>
    /*
    <example>true</example>
    */
    [JsonPropertyName("allow_extra_dns_labels")]
    public bool AllowExtraDnsLabels { get; set; }

    /// <summary>
    /// Setup Key as plain text
    /// </summary>
    /// <value>Setup Key as plain text</value>
    /*
    <example>A616097E-FCF0-48FA-9354-CA4A61142761</example>
    */
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class SetupKeyClear {\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Expires: ").Append(Expires).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Valid: ").Append(Valid).Append("\n");
        sb.Append("  Revoked: ").Append(Revoked).Append("\n");
        sb.Append("  UsedTimes: ").Append(UsedTimes).Append("\n");
        sb.Append("  LastUsed: ").Append(LastUsed).Append("\n");
        sb.Append("  State: ").Append(State).Append("\n");
        sb.Append("  AutoGroups: ").Append(AutoGroups).Append("\n");
        sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
        sb.Append("  UsageLimit: ").Append(UsageLimit).Append("\n");
        sb.Append("  Ephemeral: ").Append(Ephemeral).Append("\n");
        sb.Append("  AllowExtraDnsLabels: ").Append(AllowExtraDnsLabels).Append("\n");
        sb.Append("  Key: ").Append(Key).Append("\n");
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