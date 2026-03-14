


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
/// Subscription
/// </summary>
[DataContract(Name = "Subscription")]
public class Subscription : IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Subscription" /> class.
    /// </summary>
    [JsonConstructor]
    protected Subscription() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="Subscription" /> class.
    /// </summary>
    /// <param name="active">Indicates whether the subscription is active or not. (required).</param>
    /// <param name="planTier">The tier of the plan for the subscription. (required).</param>
    /// <param name="priceId">Unique identifier for the price of the subscription. (required).</param>
    /// <param name="remainingTrial">The remaining time for the trial period, in seconds..</param>
    /// <param name="features">List of features included in the subscription..</param>
    /// <param name="currency">Currency code of the subscription. (required).</param>
    /// <param name="price">Price amount in minor units (e.g., cents). (required).</param>
    /// <param name="provider">The provider of the subscription. (required).</param>
    /// <param name="updatedAt">The date and time when the subscription was last updated. (required).</param>
    public Subscription(bool active = false, string planTier = null, string priceId = null, int remainingTrial = 0, List<string> features = null, string currency = null, int price = 0, string provider = null, DateTimeOffset updatedAt = default)
    {
        this.Active = active;
        // to ensure "planTier" is required (not null)
        ArgumentNullException.ThrowIfNull(planTier);
        this.PlanTier = planTier;
        // to ensure "priceId" is required (not null)
        ArgumentNullException.ThrowIfNull(priceId);
        this.PriceId = priceId;
        // to ensure "currency" is required (not null)
        ArgumentNullException.ThrowIfNull(currency);
        this.Currency = currency;
        this.Price = price;
        // to ensure "provider" is required (not null)
        ArgumentNullException.ThrowIfNull(provider);
        this.Provider = provider;
        this.UpdatedAt = updatedAt;
        this.RemainingTrial = remainingTrial;
        this.Features = features;
    }

    /// <summary>
    /// Indicates whether the subscription is active or not.
    /// </summary>
    /// <value>Indicates whether the subscription is active or not.</value>
    /*
    <example>true</example>
    */
    [JsonPropertyName("active")]
    public bool Active { get; set; }

    /// <summary>
    /// The tier of the plan for the subscription.
    /// </summary>
    /// <value>The tier of the plan for the subscription.</value>
    /*
    <example>basic</example>
    */
    [JsonPropertyName("plan_tier")]
    public string PlanTier { get; set; }

    /// <summary>
    /// Unique identifier for the price of the subscription.
    /// </summary>
    /// <value>Unique identifier for the price of the subscription.</value>
    /*
    <example>price_1HhxOpBzq4JbCqRmJxkpzL2V</example>
    */
    [JsonPropertyName("price_id")]
    public string PriceId { get; set; }

    /// <summary>
    /// The remaining time for the trial period, in seconds.
    /// </summary>
    /// <value>The remaining time for the trial period, in seconds.</value>
    /*
    <example>3600</example>
    */
    [JsonPropertyName("remaining_trial")]
    public int RemainingTrial { get; set; }

    /// <summary>
    /// List of features included in the subscription.
    /// </summary>
    /// <value>List of features included in the subscription.</value>
    /*
    <example>[free, idp-sync, audit-logs]</example>
    */
    [JsonPropertyName("features")]
    public List<string> Features { get; set; }

    /// <summary>
    /// Currency code of the subscription.
    /// </summary>
    /// <value>Currency code of the subscription.</value>
    /*
    <example>USD</example>
    */
    [JsonPropertyName("currency")]
    public string Currency { get; set; }

    /// <summary>
    /// Price amount in minor units (e.g., cents).
    /// </summary>
    /// <value>Price amount in minor units (e.g., cents).</value>
    /*
    <example>1000</example>
    */
    [JsonPropertyName("price")]
    public int Price { get; set; }

    /// <summary>
    /// The provider of the subscription.
    /// </summary>
    /// <value>The provider of the subscription.</value>
    /*
    <example>[stripe, aws]</example>
    */
    [JsonPropertyName("provider")]
    public string Provider { get; set; }

    /// <summary>
    /// The date and time when the subscription was last updated.
    /// </summary>
    /// <value>The date and time when the subscription was last updated.</value>
    /*
    <example>2021-08-01T12:00:00Z</example>
    */
    [JsonPropertyName("updated_at")]
    public DateTimeOffset UpdatedAt { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class Subscription {\n");
        sb.Append("  Active: ").Append(Active).Append("\n");
        sb.Append("  PlanTier: ").Append(PlanTier).Append("\n");
        sb.Append("  PriceId: ").Append(PriceId).Append("\n");
        sb.Append("  RemainingTrial: ").Append(RemainingTrial).Append("\n");
        sb.Append("  Features: ").Append(Features).Append("\n");
        sb.Append("  Currency: ").Append(Currency).Append("\n");
        sb.Append("  Price: ").Append(Price).Append("\n");
        sb.Append("  Provider: ").Append(Provider).Append("\n");
        sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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