


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
/// CheckoutResponse
/// </summary>
[DataContract(Name = "CheckoutResponse")]
public class CheckoutResponse : IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CheckoutResponse" /> class.
    /// </summary>
    [JsonConstructor]
    protected CheckoutResponse() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="CheckoutResponse" /> class.
    /// </summary>
    /// <param name="sessionId">The unique identifier for the checkout session. (required).</param>
    /// <param name="url">URL to redirect the user to the checkout session. (required).</param>
    public CheckoutResponse(string sessionId = null, string url = null)
    {
        // to ensure "sessionId" is required (not null)
        ArgumentNullException.ThrowIfNull(sessionId);
        this.SessionId = sessionId;
        // to ensure "url" is required (not null)
        ArgumentNullException.ThrowIfNull(url);
        this.Url = url;
    }

    /// <summary>
    /// The unique identifier for the checkout session.
    /// </summary>
    /// <value>The unique identifier for the checkout session.</value>
    /*
    <example>cs_test_a1b2c3d4e5f6g7h8i9j0</example>
    */
    [JsonPropertyName("session_id")]
    public string SessionId { get; set; }

    /// <summary>
    /// URL to redirect the user to the checkout session.
    /// </summary>
    /// <value>URL to redirect the user to the checkout session.</value>
    /*
    <example>https://checkout.stripe.com/pay/cs_test_a1b2c3d4e5f6g7h8i9j0</example>
    */
    [JsonPropertyName("url")]
    public string Url { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class CheckoutResponse {\n");
        sb.Append("  SessionId: ").Append(SessionId).Append("\n");
        sb.Append("  Url: ").Append(Url).Append("\n");
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