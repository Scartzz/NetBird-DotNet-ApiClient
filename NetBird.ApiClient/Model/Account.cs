


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
/// Account
/// </summary>
[DataContract(Name = "Account")]
public class Account : IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Account" /> class.
    /// </summary>
    [JsonConstructor]
    protected Account() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="Account" /> class.
    /// </summary>
    /// <param name="id">Account ID (required).</param>
    /// <param name="settings">settings (required).</param>
    /// <param name="domain">Account domain (required).</param>
    /// <param name="domainCategory">Account domain category (required).</param>
    /// <param name="createdAt">Account creation date (UTC) (required).</param>
    /// <param name="createdBy">Account creator (required).</param>
    /// <param name="onboarding">onboarding (required).</param>
    public Account(string id = null, AccountSettings settings = null, string domain = null, string domainCategory = null, DateTimeOffset createdAt = default, string createdBy = null, AccountOnboarding onboarding = null)
    {
        // to ensure "id" is required (not null)
        ArgumentNullException.ThrowIfNull(id);
        this.Id = id;
        // to ensure "settings" is required (not null)
        ArgumentNullException.ThrowIfNull(settings);
        this.Settings = settings;
        // to ensure "domain" is required (not null)
        ArgumentNullException.ThrowIfNull(domain);
        this.Domain = domain;
        // to ensure "domainCategory" is required (not null)
        ArgumentNullException.ThrowIfNull(domainCategory);
        this.DomainCategory = domainCategory;
        this.CreatedAt = createdAt;
        // to ensure "createdBy" is required (not null)
        ArgumentNullException.ThrowIfNull(createdBy);
        this.CreatedBy = createdBy;
        // to ensure "onboarding" is required (not null)
        ArgumentNullException.ThrowIfNull(onboarding);
        this.Onboarding = onboarding;
    }

    /// <summary>
    /// Account ID
    /// </summary>
    /// <value>Account ID</value>
    /*
    <example>ch8i4ug6lnn4g9hqv7l0</example>
    */
    [JsonPropertyName("id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Settings
    /// </summary>
    [JsonPropertyName("settings")]
    public AccountSettings Settings { get; set; }

    /// <summary>
    /// Account domain
    /// </summary>
    /// <value>Account domain</value>
    /*
    <example>netbird.io</example>
    */
    [JsonPropertyName("domain")]
    public string Domain { get; set; }

    /// <summary>
    /// Account domain category
    /// </summary>
    /// <value>Account domain category</value>
    /*
    <example>private</example>
    */
    [JsonPropertyName("domain_category")]
    public string DomainCategory { get; set; }

    /// <summary>
    /// Account creation date (UTC)
    /// </summary>
    /// <value>Account creation date (UTC)</value>
    /*
    <example>2023-05-05T09:00:35.477782Z</example>
    */
    [JsonPropertyName("created_at")]
    public DateTimeOffset CreatedAt { get; set; }

    /// <summary>
    /// Account creator
    /// </summary>
    /// <value>Account creator</value>
    /*
    <example>google-oauth2|277474792786460067937</example>
    */
    [JsonPropertyName("created_by")]
    public string CreatedBy { get; set; }

    /// <summary>
    /// Gets or Sets Onboarding
    /// </summary>
    [JsonPropertyName("onboarding")]
    public AccountOnboarding Onboarding { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class Account {\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Settings: ").Append(Settings).Append("\n");
        sb.Append("  Domain: ").Append(Domain).Append("\n");
        sb.Append("  DomainCategory: ").Append(DomainCategory).Append("\n");
        sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
        sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
        sb.Append("  Onboarding: ").Append(Onboarding).Append("\n");
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