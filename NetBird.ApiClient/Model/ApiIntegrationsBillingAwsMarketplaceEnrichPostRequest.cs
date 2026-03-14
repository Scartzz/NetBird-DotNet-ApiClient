


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
/// ApiIntegrationsBillingAwsMarketplaceEnrichPostRequest
/// </summary>
[DataContract(Name = "_api_integrations_billing_aws_marketplace_enrich_post_request")]
public class ApiIntegrationsBillingAwsMarketplaceEnrichPostRequest : IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ApiIntegrationsBillingAwsMarketplaceEnrichPostRequest" /> class.
    /// </summary>
    [JsonConstructor]
    protected ApiIntegrationsBillingAwsMarketplaceEnrichPostRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ApiIntegrationsBillingAwsMarketplaceEnrichPostRequest" /> class.
    /// </summary>
    /// <param name="awsUserId">The AWS user ID. (required).</param>
    public ApiIntegrationsBillingAwsMarketplaceEnrichPostRequest(string awsUserId = null)
    {
        // to ensure "awsUserId" is required (not null)
        ArgumentNullException.ThrowIfNull(awsUserId);
        this.AwsUserId = awsUserId;
    }

    /// <summary>
    /// The AWS user ID.
    /// </summary>
    /// <value>The AWS user ID.</value>
    /*
    <example>eRF345hgdgFyu</example>
    */
    [JsonPropertyName("aws_user_id")]
    public string AwsUserId { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class ApiIntegrationsBillingAwsMarketplaceEnrichPostRequest {\n");
        sb.Append("  AwsUserId: ").Append(AwsUserId).Append("\n");
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