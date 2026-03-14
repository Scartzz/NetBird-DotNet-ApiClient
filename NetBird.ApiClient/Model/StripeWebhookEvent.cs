


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
/// StripeWebhookEvent
/// </summary>
[DataContract(Name = "StripeWebhookEvent")]
public class StripeWebhookEvent : IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="StripeWebhookEvent" /> class.
    /// </summary>
    /// <param name="type">The type of event received from Stripe..</param>
    /// <param name="data">The data associated with the event from Stripe..</param>
    public StripeWebhookEvent(string type = null, Object data = null)
    {
        this.Type = type;
        this.Data = data;
    }

    /// <summary>
    /// The type of event received from Stripe.
    /// </summary>
    /// <value>The type of event received from Stripe.</value>
    /*
    <example>customer.subscription.updated</example>
    */
    [JsonPropertyName("type")]
    public string Type { get; set; }

    /// <summary>
    /// The data associated with the event from Stripe.
    /// </summary>
    /// <value>The data associated with the event from Stripe.</value>
    /*
    <example>{&quot;object&quot;:{&quot;id&quot;:&quot;sub_123456789&quot;,&quot;object&quot;:&quot;subscription&quot;,&quot;status&quot;:&quot;active&quot;,&quot;items&quot;:{&quot;object&quot;:&quot;list&quot;,&quot;data&quot;:[{&quot;id&quot;:&quot;si_123456789&quot;,&quot;object&quot;:&quot;subscription_item&quot;,&quot;price&quot;:{&quot;id&quot;:&quot;price_1HhxOpBzq4JbCqRmJxkpzL2V&quot;,&quot;object&quot;:&quot;price&quot;,&quot;unit_amount&quot;:2000,&quot;currency&quot;:&quot;usd&quot;}}]},&quot;billing_cycle_anchor&quot;:1609459200}}</example>
    */
    [JsonPropertyName("data")]
    public Object Data { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class StripeWebhookEvent {\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Data: ").Append(Data).Append("\n");
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