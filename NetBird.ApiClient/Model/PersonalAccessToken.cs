


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
/// PersonalAccessToken
/// </summary>
[DataContract(Name = "PersonalAccessToken")]
public class PersonalAccessToken : IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PersonalAccessToken" /> class.
    /// </summary>
    [JsonConstructor]
    protected PersonalAccessToken() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="PersonalAccessToken" /> class.
    /// </summary>
    /// <param name="id">ID of a token (required).</param>
    /// <param name="name">Name of the token (required).</param>
    /// <param name="expirationDate">Date the token expires (required).</param>
    /// <param name="createdBy">User ID of the user who created the token (required).</param>
    /// <param name="createdAt">Date the token was created (required).</param>
    /// <param name="lastUsed">Date the token was last used.</param>
    public PersonalAccessToken(string id = null, string name = null, DateTimeOffset expirationDate = default, string createdBy = null, DateTimeOffset createdAt = default, DateTimeOffset lastUsed = default)
    {
        // to ensure "id" is required (not null)
        ArgumentNullException.ThrowIfNull(id);
        this.Id = id;
        // to ensure "name" is required (not null)
        ArgumentNullException.ThrowIfNull(name);
        this.Name = name;
        this.ExpirationDate = expirationDate;
        // to ensure "createdBy" is required (not null)
        ArgumentNullException.ThrowIfNull(createdBy);
        this.CreatedBy = createdBy;
        this.CreatedAt = createdAt;
        this.LastUsed = lastUsed;
    }

    /// <summary>
    /// ID of a token
    /// </summary>
    /// <value>ID of a token</value>
    /*
    <example>ch8i54g6lnn4g9hqv7n0</example>
    */
    [JsonPropertyName("id")]
    public string Id { get; set; }

    /// <summary>
    /// Name of the token
    /// </summary>
    /// <value>Name of the token</value>
    /*
    <example>My first token</example>
    */
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// Date the token expires
    /// </summary>
    /// <value>Date the token expires</value>
    /*
    <example>2023-05-05T14:38:28.977616Z</example>
    */
    [JsonPropertyName("expiration_date")]
    public DateTimeOffset ExpirationDate { get; set; }

    /// <summary>
    /// User ID of the user who created the token
    /// </summary>
    /// <value>User ID of the user who created the token</value>
    /*
    <example>google-oauth2|277474792786460067937</example>
    */
    [JsonPropertyName("created_by")]
    public string CreatedBy { get; set; }

    /// <summary>
    /// Date the token was created
    /// </summary>
    /// <value>Date the token was created</value>
    /*
    <example>2023-05-02T14:48:20.465209Z</example>
    */
    [JsonPropertyName("created_at")]
    public DateTimeOffset CreatedAt { get; set; }

    /// <summary>
    /// Date the token was last used
    /// </summary>
    /// <value>Date the token was last used</value>
    /*
    <example>2023-05-04T12:45:25.9723616Z</example>
    */
    [JsonPropertyName("last_used")]
    public DateTimeOffset LastUsed { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class PersonalAccessToken {\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  ExpirationDate: ").Append(ExpirationDate).Append("\n");
        sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
        sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
        sb.Append("  LastUsed: ").Append(LastUsed).Append("\n");
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