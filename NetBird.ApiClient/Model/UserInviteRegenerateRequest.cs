


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
/// Request to regenerate an invite link
/// </summary>
[DataContract(Name = "UserInviteRegenerateRequest")]
public class UserInviteRegenerateRequest : IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="UserInviteRegenerateRequest" /> class.
    /// </summary>
    /// <param name="expiresIn">Invite expiration time in seconds (default 72 hours).</param>
    public UserInviteRegenerateRequest(int expiresIn = 0)
    {
        this.ExpiresIn = expiresIn;
    }

    /// <summary>
    /// Invite expiration time in seconds (default 72 hours)
    /// </summary>
    /// <value>Invite expiration time in seconds (default 72 hours)</value>
    /*
    <example>259200</example>
    */
    [JsonPropertyName("expires_in")]
    public int ExpiresIn { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class UserInviteRegenerateRequest {\n");
        sb.Append("  ExpiresIn: ").Append(ExpiresIn).Append("\n");
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