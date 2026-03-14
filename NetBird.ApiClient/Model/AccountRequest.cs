


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
/// AccountRequest
/// </summary>
[DataContract(Name = "AccountRequest")]
public class AccountRequest : IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AccountRequest" /> class.
    /// </summary>
    [JsonConstructor]
    protected AccountRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="AccountRequest" /> class.
    /// </summary>
    /// <param name="settings">settings (required).</param>
    /// <param name="onboarding">onboarding.</param>
    public AccountRequest(AccountSettings settings = null, AccountOnboarding onboarding = null)
    {
        // to ensure "settings" is required (not null)
        ArgumentNullException.ThrowIfNull(settings);
        this.Settings = settings;
        this.Onboarding = onboarding;
    }

    /// <summary>
    /// Gets or Sets Settings
    /// </summary>
    [JsonPropertyName("settings")]
    public AccountSettings Settings { get; set; }

    /// <summary>
    /// Gets or Sets Onboarding
    /// </summary>
    [JsonPropertyName("onboarding")]
    public AccountOnboarding Onboarding { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class AccountRequest {\n");
        sb.Append("  Settings: ").Append(Settings).Append("\n");
        sb.Append("  Onboarding: ").Append(Onboarding).Append("\n");
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