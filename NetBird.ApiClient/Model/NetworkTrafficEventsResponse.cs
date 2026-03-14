


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
/// NetworkTrafficEventsResponse
/// </summary>
[DataContract(Name = "NetworkTrafficEventsResponse")]
public class NetworkTrafficEventsResponse : IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="NetworkTrafficEventsResponse" /> class.
    /// </summary>
    [JsonConstructor]
    protected NetworkTrafficEventsResponse() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="NetworkTrafficEventsResponse" /> class.
    /// </summary>
    /// <param name="data">List of network traffic events (required).</param>
    /// <param name="page">Current page number (required).</param>
    /// <param name="pageSize">Number of items per page (required).</param>
    /// <param name="totalRecords">Total number of event records available (required).</param>
    /// <param name="totalPages">Total number of pages available (required).</param>
    public NetworkTrafficEventsResponse(List<NetworkTrafficEvent> data = null, int page = 0, int pageSize = 0, int totalRecords = 0, int totalPages = 0)
    {
        // to ensure "data" is required (not null)
        ArgumentNullException.ThrowIfNull(data);
        this.Data = data;
        this.Page = page;
        this.PageSize = pageSize;
        this.TotalRecords = totalRecords;
        this.TotalPages = totalPages;
    }

    /// <summary>
    /// List of network traffic events
    /// </summary>
    /// <value>List of network traffic events</value>
    [JsonPropertyName("data")]
    public List<NetworkTrafficEvent> Data { get; set; }

    /// <summary>
    /// Current page number
    /// </summary>
    /// <value>Current page number</value>
    [JsonPropertyName("page")]
    public int Page { get; set; }

    /// <summary>
    /// Number of items per page
    /// </summary>
    /// <value>Number of items per page</value>
    [JsonPropertyName("page_size")]
    public int PageSize { get; set; }

    /// <summary>
    /// Total number of event records available
    /// </summary>
    /// <value>Total number of event records available</value>
    [JsonPropertyName("total_records")]
    public int TotalRecords { get; set; }

    /// <summary>
    /// Total number of pages available
    /// </summary>
    /// <value>Total number of pages available</value>
    [JsonPropertyName("total_pages")]
    public int TotalPages { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class NetworkTrafficEventsResponse {\n");
        sb.Append("  Data: ").Append(Data).Append("\n");
        sb.Append("  Page: ").Append(Page).Append("\n");
        sb.Append("  PageSize: ").Append(PageSize).Append("\n");
        sb.Append("  TotalRecords: ").Append(TotalRecords).Append("\n");
        sb.Append("  TotalPages: ").Append(TotalPages).Append("\n");
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