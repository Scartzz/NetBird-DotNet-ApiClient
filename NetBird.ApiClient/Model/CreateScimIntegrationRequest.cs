


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
/// Request payload for creating an SCIM IDP integration
/// </summary>
[DataContract(Name = "CreateScimIntegrationRequest")]
public class CreateScimIntegrationRequest : IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CreateScimIntegrationRequest" /> class.
    /// </summary>
    [JsonConstructor]
    protected CreateScimIntegrationRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="CreateScimIntegrationRequest" /> class.
    /// </summary>
    /// <param name="prefix">The connection prefix used for the SCIM provider (required).</param>
    /// <param name="provider">Name of the SCIM identity provider (required).</param>
    /// <param name="groupPrefixes">List of start_with string patterns for groups to sync.</param>
    /// <param name="userGroupPrefixes">List of start_with string patterns for groups which users to sync.</param>
    public CreateScimIntegrationRequest(string prefix = null, string provider = null, List<string> groupPrefixes = null, List<string> userGroupPrefixes = null)
    {
        // to ensure "prefix" is required (not null)
        ArgumentNullException.ThrowIfNull(prefix);
        this.Prefix = prefix;
        // to ensure "provider" is required (not null)
        ArgumentNullException.ThrowIfNull(provider);
        this.Provider = provider;
        this.GroupPrefixes = groupPrefixes;
        this.UserGroupPrefixes = userGroupPrefixes;
    }

    /// <summary>
    /// The connection prefix used for the SCIM provider
    /// </summary>
    /// <value>The connection prefix used for the SCIM provider</value>
    [JsonPropertyName("prefix")]
    public string Prefix { get; set; }

    /// <summary>
    /// Name of the SCIM identity provider
    /// </summary>
    /// <value>Name of the SCIM identity provider</value>
    [JsonPropertyName("provider")]
    public string Provider { get; set; }

    /// <summary>
    /// List of start_with string patterns for groups to sync
    /// </summary>
    /// <value>List of start_with string patterns for groups to sync</value>
    /*
    <example>[Engineering, Sales]</example>
    */
    [JsonPropertyName("group_prefixes")]
    public List<string> GroupPrefixes { get; set; }

    /// <summary>
    /// List of start_with string patterns for groups which users to sync
    /// </summary>
    /// <value>List of start_with string patterns for groups which users to sync</value>
    /*
    <example>[Users]</example>
    */
    [JsonPropertyName("user_group_prefixes")]
    public List<string> UserGroupPrefixes { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class CreateScimIntegrationRequest {\n");
        sb.Append("  Prefix: ").Append(Prefix).Append("\n");
        sb.Append("  Provider: ").Append(Provider).Append("\n");
        sb.Append("  GroupPrefixes: ").Append(GroupPrefixes).Append("\n");
        sb.Append("  UserGroupPrefixes: ").Append(UserGroupPrefixes).Append("\n");
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