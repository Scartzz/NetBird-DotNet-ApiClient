


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
/// ApiIntegrationsBillingAwsMarketplaceActivatePostRequest
/// </summary>
[DataContract(Name = "_api_integrations_billing_aws_marketplace_activate_post_request")]
public class ApiIntegrationsBillingAwsMarketplaceActivatePostRequest : IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ApiIntegrationsBillingAwsMarketplaceActivatePostRequest" /> class.
    /// </summary>
    [JsonConstructor]
    protected ApiIntegrationsBillingAwsMarketplaceActivatePostRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ApiIntegrationsBillingAwsMarketplaceActivatePostRequest" /> class.
    /// </summary>
    /// <param name="planTier">The plan tier to activate the subscription for. (required).</param>
    public ApiIntegrationsBillingAwsMarketplaceActivatePostRequest(string planTier = null)
    {
        // to ensure "planTier" is required (not null)
        ArgumentNullException.ThrowIfNull(planTier);
        this.PlanTier = planTier;
    }

    /// <summary>
    /// The plan tier to activate the subscription for.
    /// </summary>
    /// <value>The plan tier to activate the subscription for.</value>
    /*
    <example>business</example>
    */
    [JsonPropertyName("plan_tier")]
    public string PlanTier { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class ApiIntegrationsBillingAwsMarketplaceActivatePostRequest {\n");
        sb.Append("  PlanTier: ").Append(PlanTier).Append("\n");
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