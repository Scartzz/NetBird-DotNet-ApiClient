


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
/// CreateTenantRequest
/// </summary>
[DataContract(Name = "CreateTenantRequest")]
public class CreateTenantRequest : IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CreateTenantRequest" /> class.
    /// </summary>
    [JsonConstructor]
    protected CreateTenantRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="CreateTenantRequest" /> class.
    /// </summary>
    /// <param name="name">The name for the MSP tenant (required).</param>
    /// <param name="domain">The name for the MSP tenant (required).</param>
    /// <param name="groups">MSP users Groups that can access the Tenant and Roles to assume (required).</param>
    public CreateTenantRequest(string name = null, string domain = null, List<TenantGroupResponse> groups = null)
    {
        // to ensure "name" is required (not null)
        ArgumentNullException.ThrowIfNull(name);
        this.Name = name;
        // to ensure "domain" is required (not null)
        ArgumentNullException.ThrowIfNull(domain);
        this.Domain = domain;
        // to ensure "groups" is required (not null)
        ArgumentNullException.ThrowIfNull(groups);
        this.Groups = groups;
    }

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
    /// The name for the MSP tenant
    /// </summary>
    /// <value>The name for the MSP tenant</value>
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
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class CreateTenantRequest {\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Domain: ").Append(Domain).Append("\n");
        sb.Append("  Groups: ").Append(Groups).Append("\n");
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