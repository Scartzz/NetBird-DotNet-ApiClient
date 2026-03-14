


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
/// NetworkTrafficLocation
/// </summary>
[DataContract(Name = "NetworkTrafficLocation")]
public class NetworkTrafficLocation : IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="NetworkTrafficLocation" /> class.
    /// </summary>
    [JsonConstructor]
    protected NetworkTrafficLocation() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="NetworkTrafficLocation" /> class.
    /// </summary>
    /// <param name="cityName">Name of the city (if known). (required).</param>
    /// <param name="countryCode">ISO country code (if known). (required).</param>
    public NetworkTrafficLocation(string cityName = null, string countryCode = null)
    {
        // to ensure "cityName" is required (not null)
        ArgumentNullException.ThrowIfNull(cityName);
        this.CityName = cityName;
        // to ensure "countryCode" is required (not null)
        ArgumentNullException.ThrowIfNull(countryCode);
        this.CountryCode = countryCode;
    }

    /// <summary>
    /// Name of the city (if known).
    /// </summary>
    /// <value>Name of the city (if known).</value>
    /*
    <example>Berlin</example>
    */
    [JsonPropertyName("city_name")]
    public string CityName { get; set; }

    /// <summary>
    /// ISO country code (if known).
    /// </summary>
    /// <value>ISO country code (if known).</value>
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
        sb.Append("class NetworkTrafficLocation {\n");
        sb.Append("  CityName: ").Append(CityName).Append("\n");
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