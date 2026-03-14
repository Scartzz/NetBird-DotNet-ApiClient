


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
/// Product
/// </summary>
[DataContract(Name = "Product")]
public class Product : IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Product" /> class.
    /// </summary>
    [JsonConstructor]
    protected Product() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="Product" /> class.
    /// </summary>
    /// <param name="name">Name of the product. (required).</param>
    /// <param name="description">Detailed description of the product. (required).</param>
    /// <param name="features">List of features provided by the product. (required).</param>
    /// <param name="prices">List of prices for the product in different currencies (required).</param>
    /// <param name="free">Indicates whether the product is free or not. (required).</param>
    public Product(string name = null, string description = null, List<string> features = null, List<Price> prices = null, bool free = false)
    {
        // to ensure "name" is required (not null)
        ArgumentNullException.ThrowIfNull(name);
        this.Name = name;
        // to ensure "description" is required (not null)
        ArgumentNullException.ThrowIfNull(description);
        this.Description = description;
        // to ensure "features" is required (not null)
        ArgumentNullException.ThrowIfNull(features);
        this.Features = features;
        // to ensure "prices" is required (not null)
        ArgumentNullException.ThrowIfNull(prices);
        this.Prices = prices;
        this.Free = free;
    }

    /// <summary>
    /// Name of the product.
    /// </summary>
    /// <value>Name of the product.</value>
    /*
    <example>Basic Plan</example>
    */
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// Detailed description of the product.
    /// </summary>
    /// <value>Detailed description of the product.</value>
    /*
    <example>This is the basic plan with limited features.</example>
    */
    [JsonPropertyName("description")]
    public string Description { get; set; }

    /// <summary>
    /// List of features provided by the product.
    /// </summary>
    /// <value>List of features provided by the product.</value>
    /*
    <example>[5 free users, Basic support]</example>
    */
    [JsonPropertyName("features")]
    public List<string> Features { get; set; }

    /// <summary>
    /// List of prices for the product in different currencies
    /// </summary>
    /// <value>List of prices for the product in different currencies</value>
    [JsonPropertyName("prices")]
    public List<Price> Prices { get; set; }

    /// <summary>
    /// Indicates whether the product is free or not.
    /// </summary>
    /// <value>Indicates whether the product is free or not.</value>
    /*
    <example>false</example>
    */
    [JsonPropertyName("free")]
    public bool Free { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class Product {\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  Features: ").Append(Features).Append("\n");
        sb.Append("  Prices: ").Append(Prices).Append("\n");
        sb.Append("  Free: ").Append(Free).Append("\n");
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