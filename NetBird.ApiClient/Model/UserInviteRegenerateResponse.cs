


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
/// Response after regenerating an invite
/// </summary>
[DataContract(Name = "UserInviteRegenerateResponse")]
public class UserInviteRegenerateResponse : IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="UserInviteRegenerateResponse" /> class.
    /// </summary>
    [JsonConstructor]
    protected UserInviteRegenerateResponse() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="UserInviteRegenerateResponse" /> class.
    /// </summary>
    /// <param name="inviteToken">The new invite token (required).</param>
    /// <param name="inviteExpiresAt">New invite expiration time (required).</param>
    public UserInviteRegenerateResponse(string inviteToken = null, DateTimeOffset inviteExpiresAt = default)
    {
        // to ensure "inviteToken" is required (not null)
        ArgumentNullException.ThrowIfNull(inviteToken);
        this.InviteToken = inviteToken;
        this.InviteExpiresAt = inviteExpiresAt;
    }

    /// <summary>
    /// The new invite token
    /// </summary>
    /// <value>The new invite token</value>
    /*
    <example>nbi_Xk5Lz9mP2vQwRtYu1aN3bC4dE5fGh0ABC123</example>
    */
    [JsonPropertyName("invite_token")]
    public string InviteToken { get; set; }

    /// <summary>
    /// New invite expiration time
    /// </summary>
    /// <value>New invite expiration time</value>
    /*
    <example>2024-01-28T10:00:00Z</example>
    */
    [JsonPropertyName("invite_expires_at")]
    public DateTimeOffset InviteExpiresAt { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class UserInviteRegenerateResponse {\n");
        sb.Append("  InviteToken: ").Append(InviteToken).Append("\n");
        sb.Append("  InviteExpiresAt: ").Append(InviteExpiresAt).Append("\n");
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