


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
/// Describe city geographical location information
/// </summary>
[DataContract(Name = "City")]
public class City : IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="City" /> class.
    /// </summary>
    [JsonConstructor]
    protected City() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="City" /> class.
    /// </summary>
    /// <param name="geonameId">Integer ID of the record in GeoNames database (required).</param>
    /// <param name="cityName">Commonly used English name of the city (required).</param>
    public City(int geonameId = 0, string cityName = null)
    {
        this.GeonameId = geonameId;
        // to ensure "cityName" is required (not null)
        ArgumentNullException.ThrowIfNull(cityName);
        this.CityName = cityName;
    }

    /// <summary>
    /// Integer ID of the record in GeoNames database
    /// </summary>
    /// <value>Integer ID of the record in GeoNames database</value>
    /*
    <example>2950158</example>
    */
    [JsonPropertyName("geoname_id")]
    public int GeonameId { get; set; }

    /// <summary>
    /// Commonly used English name of the city
    /// </summary>
    /// <value>Commonly used English name of the city</value>
    /*
    <example>Berlin</example>
    */
    [JsonPropertyName("city_name")]
    public string CityName { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class City {\n");
        sb.Append("  GeonameId: ").Append(GeonameId).Append("\n");
        sb.Append("  CityName: ").Append(CityName).Append("\n");
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