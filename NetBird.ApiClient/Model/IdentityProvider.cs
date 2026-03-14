


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
/// IdentityProvider
/// </summary>
[DataContract(Name = "IdentityProvider")]
public class IdentityProvider : IValidatableObject
{

    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [JsonPropertyName("type")]
    public IdentityProviderType Type { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="IdentityProvider" /> class.
    /// </summary>
    [JsonConstructor]
    protected IdentityProvider() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="IdentityProvider" /> class.
    /// </summary>
    /// <param name="id">Identity provider ID.</param>
    /// <param name="type">type (required).</param>
    /// <param name="name">Human-readable name for the identity provider (required).</param>
    /// <param name="issuer">OIDC issuer URL (required).</param>
    /// <param name="clientId">OAuth2 client ID (required).</param>
    public IdentityProvider(string id = null, IdentityProviderType type = default, string name = null, string issuer = null, string clientId = null)
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
        this.Id = id;
    }

    /// <summary>
    /// Identity provider ID
    /// </summary>
    /// <value>Identity provider ID</value>
    /*
    <example>ch8i4ug6lnn4g9hqv7l0</example>
    */
    [JsonPropertyName("id")]
    public string Id { get; set; }

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
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class IdentityProvider {\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Issuer: ").Append(Issuer).Append("\n");
        sb.Append("  ClientId: ").Append(ClientId).Append("\n");
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