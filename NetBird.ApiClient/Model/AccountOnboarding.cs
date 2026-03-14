


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
/// AccountOnboarding
/// </summary>
[DataContract(Name = "AccountOnboarding")]
public class AccountOnboarding : IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AccountOnboarding" /> class.
    /// </summary>
    [JsonConstructor]
    protected AccountOnboarding() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="AccountOnboarding" /> class.
    /// </summary>
    /// <param name="signupFormPending">Indicates whether the account signup form is pending (required).</param>
    /// <param name="onboardingFlowPending">Indicates whether the account onboarding flow is pending (required).</param>
    public AccountOnboarding(bool signupFormPending = false, bool onboardingFlowPending = false)
    {
        this.SignupFormPending = signupFormPending;
        this.OnboardingFlowPending = onboardingFlowPending;
    }

    /// <summary>
    /// Indicates whether the account signup form is pending
    /// </summary>
    /// <value>Indicates whether the account signup form is pending</value>
    /*
    <example>true</example>
    */
    [JsonPropertyName("signup_form_pending")]
    public bool SignupFormPending { get; set; }

    /// <summary>
    /// Indicates whether the account onboarding flow is pending
    /// </summary>
    /// <value>Indicates whether the account onboarding flow is pending</value>
    /*
    <example>false</example>
    */
    [JsonPropertyName("onboarding_flow_pending")]
    public bool OnboardingFlowPending { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class AccountOnboarding {\n");
        sb.Append("  SignupFormPending: ").Append(SignupFormPending).Append("\n");
        sb.Append("  OnboardingFlowPending: ").Append(OnboardingFlowPending).Append("\n");
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