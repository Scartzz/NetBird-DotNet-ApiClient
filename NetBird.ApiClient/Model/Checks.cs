


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
/// List of objects that perform the actual checks
/// </summary>
[DataContract(Name = "Checks")]
public class Checks : IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Checks" /> class.
    /// </summary>
    /// <param name="nbVersionCheck">nbVersionCheck.</param>
    /// <param name="osVersionCheck">osVersionCheck.</param>
    /// <param name="geoLocationCheck">geoLocationCheck.</param>
    /// <param name="peerNetworkRangeCheck">peerNetworkRangeCheck.</param>
    /// <param name="processCheck">processCheck.</param>
    public Checks(NBVersionCheck nbVersionCheck = null, OSVersionCheck osVersionCheck = null, GeoLocationCheck geoLocationCheck = null, PeerNetworkRangeCheck peerNetworkRangeCheck = null, ProcessCheck processCheck = null)
    {
        this.NbVersionCheck = nbVersionCheck;
        this.OsVersionCheck = osVersionCheck;
        this.GeoLocationCheck = geoLocationCheck;
        this.PeerNetworkRangeCheck = peerNetworkRangeCheck;
        this.ProcessCheck = processCheck;
    }

    /// <summary>
    /// Gets or Sets NbVersionCheck
    /// </summary>
    [JsonPropertyName("nb_version_check")]
    public NBVersionCheck NbVersionCheck { get; set; }

    /// <summary>
    /// Gets or Sets OsVersionCheck
    /// </summary>
    [JsonPropertyName("os_version_check")]
    public OSVersionCheck OsVersionCheck { get; set; }

    /// <summary>
    /// Gets or Sets GeoLocationCheck
    /// </summary>
    [JsonPropertyName("geo_location_check")]
    public GeoLocationCheck GeoLocationCheck { get; set; }

    /// <summary>
    /// Gets or Sets PeerNetworkRangeCheck
    /// </summary>
    [JsonPropertyName("peer_network_range_check")]
    public PeerNetworkRangeCheck PeerNetworkRangeCheck { get; set; }

    /// <summary>
    /// Gets or Sets ProcessCheck
    /// </summary>
    [JsonPropertyName("process_check")]
    public ProcessCheck ProcessCheck { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class Checks {\n");
        sb.Append("  NbVersionCheck: ").Append(NbVersionCheck).Append("\n");
        sb.Append("  OsVersionCheck: ").Append(OsVersionCheck).Append("\n");
        sb.Append("  GeoLocationCheck: ").Append(GeoLocationCheck).Append("\n");
        sb.Append("  PeerNetworkRangeCheck: ").Append(PeerNetworkRangeCheck).Append("\n");
        sb.Append("  ProcessCheck: ").Append(ProcessCheck).Append("\n");
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