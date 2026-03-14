


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
/// ServiceAuthConfig
/// </summary>
[DataContract(Name = "ServiceAuthConfig")]
public class ServiceAuthConfig : IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ServiceAuthConfig" /> class.
    /// </summary>
    /// <param name="passwordAuth">passwordAuth.</param>
    /// <param name="pinAuth">pinAuth.</param>
    /// <param name="bearerAuth">bearerAuth.</param>
    /// <param name="linkAuth">linkAuth.</param>
    public ServiceAuthConfig(PasswordAuthConfig passwordAuth = null, PINAuthConfig pinAuth = null, BearerAuthConfig bearerAuth = null, LinkAuthConfig linkAuth = null)
    {
        this.PasswordAuth = passwordAuth;
        this.PinAuth = pinAuth;
        this.BearerAuth = bearerAuth;
        this.LinkAuth = linkAuth;
    }

    /// <summary>
    /// Gets or Sets PasswordAuth
    /// </summary>
    [JsonPropertyName("password_auth")]
    public PasswordAuthConfig PasswordAuth { get; set; }

    /// <summary>
    /// Gets or Sets PinAuth
    /// </summary>
    [JsonPropertyName("pin_auth")]
    public PINAuthConfig PinAuth { get; set; }

    /// <summary>
    /// Gets or Sets BearerAuth
    /// </summary>
    [JsonPropertyName("bearer_auth")]
    public BearerAuthConfig BearerAuth { get; set; }

    /// <summary>
    /// Gets or Sets LinkAuth
    /// </summary>
    [JsonPropertyName("link_auth")]
    public LinkAuthConfig LinkAuth { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class ServiceAuthConfig {\n");
        sb.Append("  PasswordAuth: ").Append(PasswordAuth).Append("\n");
        sb.Append("  PinAuth: ").Append(PinAuth).Append("\n");
        sb.Append("  BearerAuth: ").Append(BearerAuth).Append("\n");
        sb.Append("  LinkAuth: ").Append(LinkAuth).Append("\n");
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