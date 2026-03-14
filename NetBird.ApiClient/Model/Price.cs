


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
/// Price
/// </summary>
[DataContract(Name = "Price")]
public class Price : IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Price" /> class.
    /// </summary>
    [JsonConstructor]
    protected Price() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="Price" /> class.
    /// </summary>
    /// <param name="priceId">Unique identifier for the price. (required).</param>
    /// <param name="currency">Currency code for this price. (required).</param>
    /// <param name="varPrice">Price amount in minor units (e.g., cents). (required).</param>
    /// <param name="unit">Unit of measurement for this price (e.g., per user). (required).</param>
    public Price(string priceId = null, string currency = null, int varPrice = 0, string unit = null)
    {
        // to ensure "priceId" is required (not null)
        ArgumentNullException.ThrowIfNull(priceId);
        this.PriceId = priceId;
        // to ensure "currency" is required (not null)
        ArgumentNullException.ThrowIfNull(currency);
        this.Currency = currency;
        this.VarPrice = varPrice;
        // to ensure "unit" is required (not null)
        ArgumentNullException.ThrowIfNull(unit);
        this.Unit = unit;
    }

    /// <summary>
    /// Unique identifier for the price.
    /// </summary>
    /// <value>Unique identifier for the price.</value>
    /*
    <example>price_H2KmRb4u1tP0sR7s</example>
    */
    [JsonPropertyName("price_id")]
    public string PriceId { get; set; }

    /// <summary>
    /// Currency code for this price.
    /// </summary>
    /// <value>Currency code for this price.</value>
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
    public int VarPrice { get; set; }

    /// <summary>
    /// Unit of measurement for this price (e.g., per user).
    /// </summary>
    /// <value>Unit of measurement for this price (e.g., per user).</value>
    /*
    <example>user</example>
    */
    [JsonPropertyName("unit")]
    public string Unit { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class Price {\n");
        sb.Append("  PriceId: ").Append(PriceId).Append("\n");
        sb.Append("  Currency: ").Append(Currency).Append("\n");
        sb.Append("  VarPrice: ").Append(VarPrice).Append("\n");
        sb.Append("  Unit: ").Append(Unit).Append("\n");
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