


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
/// Response after accepting an invite
/// </summary>
[DataContract(Name = "UserInviteAcceptResponse")]
public class UserInviteAcceptResponse : IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="UserInviteAcceptResponse" /> class.
    /// </summary>
    [JsonConstructor]
    protected UserInviteAcceptResponse() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="UserInviteAcceptResponse" /> class.
    /// </summary>
    /// <param name="success">Whether the invite was accepted successfully (required).</param>
    public UserInviteAcceptResponse(bool success = false)
    {
        this.Success = success;
    }

    /// <summary>
    /// Whether the invite was accepted successfully
    /// </summary>
    /// <value>Whether the invite was accepted successfully</value>
    /*
    <example>true</example>
    */
    [JsonPropertyName("success")]
    public bool Success { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class UserInviteAcceptResponse {\n");
        sb.Append("  Success: ").Append(Success).Append("\n");
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