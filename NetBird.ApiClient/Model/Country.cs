


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
/// Describe country geographical location information
/// </summary>
[DataContract(Name = "Country")]
public class Country : IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Country" /> class.
    /// </summary>
    [JsonConstructor]
    protected Country() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="Country" /> class.
    /// </summary>
    /// <param name="countryName">Commonly used English name of the country (required).</param>
    /// <param name="countryCode">2-letter ISO 3166-1 alpha-2 code that represents the country (required).</param>
    public Country(string countryName = null, string countryCode = null)
    {
        // to ensure "countryName" is required (not null)
        ArgumentNullException.ThrowIfNull(countryName);
        this.CountryName = countryName;
        // to ensure "countryCode" is required (not null)
        ArgumentNullException.ThrowIfNull(countryCode);
        this.CountryCode = countryCode;
    }

    /// <summary>
    /// Commonly used English name of the country
    /// </summary>
    /// <value>Commonly used English name of the country</value>
    /*
    <example>Germany</example>
    */
    [JsonPropertyName("country_name")]
    public string CountryName { get; set; }

    /// <summary>
    /// 2-letter ISO 3166-1 alpha-2 code that represents the country
    /// </summary>
    /// <value>2-letter ISO 3166-1 alpha-2 code that represents the country</value>
    /*
    <example>DE</example>
    */
    [JsonPropertyName("country_code")]
    public string CountryCode { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class Country {\n");
        sb.Append("  CountryName: ").Append(CountryName).Append("\n");
        sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
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