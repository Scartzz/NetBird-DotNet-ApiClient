


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
/// InvoiceResponse
/// </summary>
[DataContract(Name = "InvoiceResponse")]
public class InvoiceResponse : IValidatableObject
{
    /// <summary>
    /// The invoice type
    /// </summary>
    /// <value>The invoice type</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TypeEnum
    {
        /// <summary>
        /// Enum Account for value: account
        /// </summary>
        [EnumMember(Value = "account")]
        Account = 1,

        /// <summary>
        /// Enum Tenants for value: tenants
        /// </summary>
        [EnumMember(Value = "tenants")]
        Tenants = 2
    }


    /// <summary>
    /// The invoice type
    /// </summary>
    /// <value>The invoice type</value>
    [JsonPropertyName("type")]
    public TypeEnum Type { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="InvoiceResponse" /> class.
    /// </summary>
    [JsonConstructor]
    protected InvoiceResponse() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="InvoiceResponse" /> class.
    /// </summary>
    /// <param name="id">The Stripe invoice id (required).</param>
    /// <param name="type">The invoice type (required).</param>
    /// <param name="periodStart">The start date of the invoice period. (required).</param>
    /// <param name="periodEnd">The end date of the invoice period. (required).</param>
    public InvoiceResponse(string id = null, TypeEnum type = default, DateTimeOffset periodStart = default, DateTimeOffset periodEnd = default)
    {
        // to ensure "id" is required (not null)
        ArgumentNullException.ThrowIfNull(id);
        this.Id = id;
        this.Type = type;
        this.PeriodStart = periodStart;
        this.PeriodEnd = periodEnd;
    }

    /// <summary>
    /// The Stripe invoice id
    /// </summary>
    /// <value>The Stripe invoice id</value>
    /*
    <example>in_1MtHbELkdIwHu7ixl4OzzPMv</example>
    */
    [JsonPropertyName("id")]
    public string Id { get; set; }

    /// <summary>
    /// The start date of the invoice period.
    /// </summary>
    /// <value>The start date of the invoice period.</value>
    /*
    <example>2021-08-01T12:00:00Z</example>
    */
    [JsonPropertyName("period_start")]
    public DateTimeOffset PeriodStart { get; set; }

    /// <summary>
    /// The end date of the invoice period.
    /// </summary>
    /// <value>The end date of the invoice period.</value>
    /*
    <example>2021-08-31T12:00:00Z</example>
    */
    [JsonPropertyName("period_end")]
    public DateTimeOffset PeriodEnd { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class InvoiceResponse {\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  PeriodStart: ").Append(PeriodStart).Append("\n");
        sb.Append("  PeriodEnd: ").Append(PeriodEnd).Append("\n");
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