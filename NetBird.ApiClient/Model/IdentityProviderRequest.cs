


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
/// IdentityProviderRequest
/// </summary>
[DataContract(Name = "IdentityProviderRequest")]
public class IdentityProviderRequest : IValidatableObject
{

    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [JsonPropertyName("type")]
    public IdentityProviderType Type { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="IdentityProviderRequest" /> class.
    /// </summary>
    [JsonConstructor]
    protected IdentityProviderRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="IdentityProviderRequest" /> class.
    /// </summary>
    /// <param name="type">type (required).</param>
    /// <param name="name">Human-readable name for the identity provider (required).</param>
    /// <param name="issuer">OIDC issuer URL (required).</param>
    /// <param name="clientId">OAuth2 client ID (required).</param>
    /// <param name="clientSecret">OAuth2 client secret (required).</param>
    public IdentityProviderRequest(IdentityProviderType type = default, string name = null, string issuer = null, string clientId = null, string clientSecret = null)
    {
        this.Type = type;
        // to ensure "name" is required (not null)
        ArgumentNullException.ThrowIfNull(name);
        this.Name = name;
        // to ensure "issuer" is required (not null)
        ArgumentNullException.ThrowIfNull(issuer);
        this.Issuer = issuer;
        // to ensure "clientId" is required (not null)
        ArgumentNullException.ThrowIfNull(clientId);
        this.ClientId = clientId;
        // to ensure "clientSecret" is required (not null)
        ArgumentNullException.ThrowIfNull(clientSecret);
        this.ClientSecret = clientSecret;
    }

    /// <summary>
    /// Human-readable name for the identity provider
    /// </summary>
    /// <value>Human-readable name for the identity provider</value>
    /*
    <example>My OIDC Provider</example>
    */
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// OIDC issuer URL
    /// </summary>
    /// <value>OIDC issuer URL</value>
    /*
    <example>https://accounts.google.com</example>
    */
    [JsonPropertyName("issuer")]
    public string Issuer { get; set; }

    /// <summary>
    /// OAuth2 client ID
    /// </summary>
    /// <value>OAuth2 client ID</value>
    /*
    <example>123456789.apps.googleusercontent.com</example>
    */
    [JsonPropertyName("client_id")]
    public string ClientId { get; set; }

    /// <summary>
    /// OAuth2 client secret
    /// </summary>
    /// <value>OAuth2 client secret</value>
    /*
    <example>secret123</example>
    */
    [JsonPropertyName("client_secret")]
    public string ClientSecret { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class IdentityProviderRequest {\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Issuer: ").Append(Issuer).Append("\n");
        sb.Append("  ClientId: ").Append(ClientId).Append("\n");
        sb.Append("  ClientSecret: ").Append(ClientSecret).Append("\n");
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