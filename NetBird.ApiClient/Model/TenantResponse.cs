


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
/// TenantResponse
/// </summary>
[DataContract(Name = "TenantResponse")]
public class TenantResponse : IValidatableObject
{
    /// <summary>
    /// The status of the tenant
    /// </summary>
    /// <value>The status of the tenant</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum StatusEnum
    {
        /// <summary>
        /// Enum Existing for value: existing
        /// </summary>
        [EnumMember(Value = "existing")]
        Existing = 1,

        /// <summary>
        /// Enum Invited for value: invited
        /// </summary>
        [EnumMember(Value = "invited")]
        Invited = 2,

        /// <summary>
        /// Enum Pending for value: pending
        /// </summary>
        [EnumMember(Value = "pending")]
        Pending = 3,

        /// <summary>
        /// Enum Active for value: active
        /// </summary>
        [EnumMember(Value = "active")]
        Active = 4
    }


    /// <summary>
    /// The status of the tenant
    /// </summary>
    /// <value>The status of the tenant</value>
    /*
    <example>active</example>
    */
    [JsonPropertyName("status")]
    public StatusEnum Status { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="TenantResponse" /> class.
    /// </summary>
    [JsonConstructor]
    protected TenantResponse() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="TenantResponse" /> class.
    /// </summary>
    /// <param name="id">The updated MSP tenant account ID (required).</param>
    /// <param name="name">The name for the MSP tenant (required).</param>
    /// <param name="domain">The tenant account domain (required).</param>
    /// <param name="groups">MSP users Groups that can access the Tenant and Roles to assume (required).</param>
    /// <param name="activatedAt">The date and time when the tenant was activated..</param>
    /// <param name="dnsChallenge">The DNS challenge to set in a TXT record (required).</param>
    /// <param name="createdAt">The date and time when the tenant was created. (required).</param>
    /// <param name="updatedAt">The date and time when the tenant was last updated. (required).</param>
    /// <param name="invitedAt">The date and time when the existing tenant was invited..</param>
    /// <param name="status">The status of the tenant (required).</param>
    public TenantResponse(string id = null, string name = null, string domain = null, List<TenantGroupResponse> groups = null, DateTimeOffset activatedAt = default, string dnsChallenge = null, DateTimeOffset createdAt = default, DateTimeOffset updatedAt = default, DateTimeOffset invitedAt = default, StatusEnum status = default)
    {
        // to ensure "id" is required (not null)
        ArgumentNullException.ThrowIfNull(id);
        this.Id = id;
        // to ensure "name" is required (not null)
        ArgumentNullException.ThrowIfNull(name);
        this.Name = name;
        // to ensure "domain" is required (not null)
        ArgumentNullException.ThrowIfNull(domain);
        this.Domain = domain;
        // to ensure "groups" is required (not null)
        ArgumentNullException.ThrowIfNull(groups);
        this.Groups = groups;
        // to ensure "dnsChallenge" is required (not null)
        ArgumentNullException.ThrowIfNull(dnsChallenge);
        this.DnsChallenge = dnsChallenge;
        this.CreatedAt = createdAt;
        this.UpdatedAt = updatedAt;
        this.Status = status;
        this.ActivatedAt = activatedAt;
        this.InvitedAt = invitedAt;
    }

    /// <summary>
    /// The updated MSP tenant account ID
    /// </summary>
    /// <value>The updated MSP tenant account ID</value>
    /*
    <example>ch8i4ug6lnn4g9hqv7m0</example>
    */
    [JsonPropertyName("id")]
    public string Id { get; set; }

    /// <summary>
    /// The name for the MSP tenant
    /// </summary>
    /// <value>The name for the MSP tenant</value>
    /*
    <example>My new tenant</example>
    */
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// The tenant account domain
    /// </summary>
    /// <value>The tenant account domain</value>
    /*
    <example>tenant.com</example>
    */
    [JsonPropertyName("domain")]
    public string Domain { get; set; }

    /// <summary>
    /// MSP users Groups that can access the Tenant and Roles to assume
    /// </summary>
    /// <value>MSP users Groups that can access the Tenant and Roles to assume</value>
    [JsonPropertyName("groups")]
    public List<TenantGroupResponse> Groups { get; set; }

    /// <summary>
    /// The date and time when the tenant was activated.
    /// </summary>
    /// <value>The date and time when the tenant was activated.</value>
    /*
    <example>2021-08-01T12:00:00Z</example>
    */
    [JsonPropertyName("activated_at")]
    public DateTimeOffset ActivatedAt { get; set; }

    /// <summary>
    /// The DNS challenge to set in a TXT record
    /// </summary>
    /// <value>The DNS challenge to set in a TXT record</value>
    /*
    <example>YXNkYSBkYXNhc2Rhc2RhIGFzZGFzZDJhc2QyNDUxNQ</example>
    */
    [JsonPropertyName("dns_challenge")]
    public string DnsChallenge { get; set; }

    /// <summary>
    /// The date and time when the tenant was created.
    /// </summary>
    /// <value>The date and time when the tenant was created.</value>
    /*
    <example>2021-08-01T12:00:00Z</example>
    */
    [JsonPropertyName("created_at")]
    public DateTimeOffset CreatedAt { get; set; }

    /// <summary>
    /// The date and time when the tenant was last updated.
    /// </summary>
    /// <value>The date and time when the tenant was last updated.</value>
    /*
    <example>2021-08-01T12:00:00Z</example>
    */
    [JsonPropertyName("updated_at")]
    public DateTimeOffset UpdatedAt { get; set; }

    /// <summary>
    /// The date and time when the existing tenant was invited.
    /// </summary>
    /// <value>The date and time when the existing tenant was invited.</value>
    /*
    <example>2021-08-01T12:00:00Z</example>
    */
    [JsonPropertyName("invited_at")]
    public DateTimeOffset InvitedAt { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class TenantResponse {\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Domain: ").Append(Domain).Append("\n");
        sb.Append("  Groups: ").Append(Groups).Append("\n");
        sb.Append("  ActivatedAt: ").Append(ActivatedAt).Append("\n");
        sb.Append("  DnsChallenge: ").Append(DnsChallenge).Append("\n");
        sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
        sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
        sb.Append("  InvitedAt: ").Append(InvitedAt).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
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