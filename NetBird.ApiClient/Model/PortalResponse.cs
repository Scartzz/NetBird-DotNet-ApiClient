


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
/// PortalResponse
/// </summary>
[DataContract(Name = "PortalResponse")]
public class PortalResponse : IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PortalResponse" /> class.
    /// </summary>
    [JsonConstructor]
    protected PortalResponse() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="PortalResponse" /> class.
    /// </summary>
    /// <param name="sessionId">The unique identifier for the customer portal session. (required).</param>
    /// <param name="url">URL to redirect the user to the customer portal. (required).</param>
    public PortalResponse(string sessionId = null, string url = null)
    {
        // to ensure "sessionId" is required (not null)
        ArgumentNullException.ThrowIfNull(sessionId);
        this.SessionId = sessionId;
        // to ensure "url" is required (not null)
        ArgumentNullException.ThrowIfNull(url);
        this.Url = url;
    }

    /// <summary>
    /// The unique identifier for the customer portal session.
    /// </summary>
    /// <value>The unique identifier for the customer portal session.</value>
    /*
    <example>cps_test_123456789</example>
    */
    [JsonPropertyName("session_id")]
    public string SessionId { get; set; }

    /// <summary>
    /// URL to redirect the user to the customer portal.
    /// </summary>
    /// <value>URL to redirect the user to the customer portal.</value>
    /*
    <example>https://billing.stripe.com/session/a1b2c3d4e5f6g7h8i9j0k</example>
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
        sb.Append("class PortalResponse {\n");
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