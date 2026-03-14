


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
/// ApiIntegrationsBillingCheckoutPostRequest
/// </summary>
[DataContract(Name = "_api_integrations_billing_checkout_post_request")]
public class ApiIntegrationsBillingCheckoutPostRequest : IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ApiIntegrationsBillingCheckoutPostRequest" /> class.
    /// </summary>
    [JsonConstructor]
    protected ApiIntegrationsBillingCheckoutPostRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ApiIntegrationsBillingCheckoutPostRequest" /> class.
    /// </summary>
    /// <param name="baseURL">The base URL for the redirect after checkout. (required).</param>
    /// <param name="priceID">The Price ID for checkout. (required).</param>
    /// <param name="enableTrial">Enables a 14-day trial for the account..</param>
    public ApiIntegrationsBillingCheckoutPostRequest(string baseURL = null, string priceID = null, bool enableTrial = false)
    {
        // to ensure "baseURL" is required (not null)
        ArgumentNullException.ThrowIfNull(baseURL);
        this.BaseURL = baseURL;
        // to ensure "priceID" is required (not null)
        ArgumentNullException.ThrowIfNull(priceID);
        this.PriceID = priceID;
        this.EnableTrial = enableTrial;
    }

    /// <summary>
    /// The base URL for the redirect after checkout.
    /// </summary>
    /// <value>The base URL for the redirect after checkout.</value>
    /*
    <example>https://app.netbird.io/plans/success</example>
    */
    [JsonPropertyName("baseURL")]
    public string BaseURL { get; set; }

    /// <summary>
    /// The Price ID for checkout.
    /// </summary>
    /// <value>The Price ID for checkout.</value>
    /*
    <example>price_1HhxOpBzq4JbCqRmJxkpzL2V</example>
    */
    [JsonPropertyName("priceID")]
    public string PriceID { get; set; }

    /// <summary>
    /// Enables a 14-day trial for the account.
    /// </summary>
    /// <value>Enables a 14-day trial for the account.</value>
    [JsonPropertyName("enableTrial")]
    public bool EnableTrial { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class ApiIntegrationsBillingCheckoutPostRequest {\n");
        sb.Append("  BaseURL: ").Append(BaseURL).Append("\n");
        sb.Append("  PriceID: ").Append(PriceID).Append("\n");
        sb.Append("  EnableTrial: ").Append(EnableTrial).Append("\n");
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