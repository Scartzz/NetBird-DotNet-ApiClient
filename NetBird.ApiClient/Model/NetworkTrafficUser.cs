


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
/// NetworkTrafficUser
/// </summary>
[DataContract(Name = "NetworkTrafficUser")]
public class NetworkTrafficUser : IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="NetworkTrafficUser" /> class.
    /// </summary>
    [JsonConstructor]
    protected NetworkTrafficUser() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="NetworkTrafficUser" /> class.
    /// </summary>
    /// <param name="id">UserID is the ID of the user that initiated the event (can be empty as not every event is user-initiated). (required).</param>
    /// <param name="email">Email of the user who initiated the event (if any). (required).</param>
    /// <param name="name">Name of the user who initiated the event (if any). (required).</param>
    public NetworkTrafficUser(string id = null, string email = null, string name = null)
    {
        // to ensure "id" is required (not null)
        ArgumentNullException.ThrowIfNull(id);
        this.Id = id;
        // to ensure "email" is required (not null)
        ArgumentNullException.ThrowIfNull(email);
        this.Email = email;
        // to ensure "name" is required (not null)
        ArgumentNullException.ThrowIfNull(name);
        this.Name = name;
    }

    /// <summary>
    /// UserID is the ID of the user that initiated the event (can be empty as not every event is user-initiated).
    /// </summary>
    /// <value>UserID is the ID of the user that initiated the event (can be empty as not every event is user-initiated).</value>
    /*
    <example>google-oauth2|123456789012345678901</example>
    */
    [JsonPropertyName("id")]
    public string Id { get; set; }

    /// <summary>
    /// Email of the user who initiated the event (if any).
    /// </summary>
    /// <value>Email of the user who initiated the event (if any).</value>
    /*
    <example>alice@netbird.io</example>
    */
    [JsonPropertyName("email")]
    public string Email { get; set; }

    /// <summary>
    /// Name of the user who initiated the event (if any).
    /// </summary>
    /// <value>Name of the user who initiated the event (if any).</value>
    /*
    <example>Alice Smith</example>
    */
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class NetworkTrafficUser {\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Email: ").Append(Email).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
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