


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
/// ApiIntegrationsBillingSubscriptionPutRequest
/// </summary>
[DataContract(Name = "_api_integrations_billing_subscription_put_request")]
public class ApiIntegrationsBillingSubscriptionPutRequest : IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ApiIntegrationsBillingSubscriptionPutRequest" /> class.
    /// </summary>
    /// <param name="priceID">The Price ID to change the subscription to..</param>
    /// <param name="planTier">The plan tier to change the subscription to..</param>
    public ApiIntegrationsBillingSubscriptionPutRequest(string priceID = null, string planTier = null)
    {
        this.PriceID = priceID;
        this.PlanTier = planTier;
    }

    /// <summary>
    /// The Price ID to change the subscription to.
    /// </summary>
    /// <value>The Price ID to change the subscription to.</value>
    /*
    <example>price_1HhxOpBzq4JbCqRmJxkpzL2V</example>
    */
    [JsonPropertyName("priceID")]
    public string PriceID { get; set; }

    /// <summary>
    /// The plan tier to change the subscription to.
    /// </summary>
    /// <value>The plan tier to change the subscription to.</value>
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
        sb.Append("class ApiIntegrationsBillingSubscriptionPutRequest {\n");
        sb.Append("  PriceID: ").Append(PriceID).Append("\n");
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