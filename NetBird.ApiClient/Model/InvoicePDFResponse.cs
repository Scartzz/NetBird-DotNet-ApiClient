


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
/// InvoicePDFResponse
/// </summary>
[DataContract(Name = "InvoicePDFResponse")]
public class InvoicePDFResponse : IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="InvoicePDFResponse" /> class.
    /// </summary>
    [JsonConstructor]
    protected InvoicePDFResponse() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="InvoicePDFResponse" /> class.
    /// </summary>
    /// <param name="url">URL to redirect the user to invoice. (required).</param>
    public InvoicePDFResponse(string url = null)
    {
        // to ensure "url" is required (not null)
        ArgumentNullException.ThrowIfNull(url);
        this.Url = url;
    }

    /// <summary>
    /// URL to redirect the user to invoice.
    /// </summary>
    /// <value>URL to redirect the user to invoice.</value>
    /*
    <example>https://invoice.stripe.com/i/acct_1M2DaBKina4I2KUb/test_YWNjdF8xTTJEdVBLaW5hM0kyS1ViLF1SeFpQdEJZd3lUOGNEajNqeWdrdXY2RFM4aHcyCnpsLDEzMjg3GTgyNQ02000JoIHc1X?s&#x3D;db</example>
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
        sb.Append("class InvoicePDFResponse {\n");
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