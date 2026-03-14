


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
/// ProxyAccessLogsResponse
/// </summary>
[DataContract(Name = "ProxyAccessLogsResponse")]
public class ProxyAccessLogsResponse : IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ProxyAccessLogsResponse" /> class.
    /// </summary>
    [JsonConstructor]
    protected ProxyAccessLogsResponse() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ProxyAccessLogsResponse" /> class.
    /// </summary>
    /// <param name="data">List of proxy access log entries (required).</param>
    /// <param name="page">Current page number (required).</param>
    /// <param name="pageSize">Number of items per page (required).</param>
    /// <param name="totalRecords">Total number of log records available (required).</param>
    /// <param name="totalPages">Total number of pages available (required).</param>
    public ProxyAccessLogsResponse(List<ProxyAccessLog> data = null, int page = 0, int pageSize = 0, int totalRecords = 0, int totalPages = 0)
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
    /// List of proxy access log entries
    /// </summary>
    /// <value>List of proxy access log entries</value>
    [JsonPropertyName("data")]
    public List<ProxyAccessLog> Data { get; set; }

    /// <summary>
    /// Current page number
    /// </summary>
    /// <value>Current page number</value>
    /*
    <example>1</example>
    */
    [JsonPropertyName("page")]
    public int Page { get; set; }

    /// <summary>
    /// Number of items per page
    /// </summary>
    /// <value>Number of items per page</value>
    /*
    <example>50</example>
    */
    [JsonPropertyName("page_size")]
    public int PageSize { get; set; }

    /// <summary>
    /// Total number of log records available
    /// </summary>
    /// <value>Total number of log records available</value>
    /*
    <example>523</example>
    */
    [JsonPropertyName("total_records")]
    public int TotalRecords { get; set; }

    /// <summary>
    /// Total number of pages available
    /// </summary>
    /// <value>Total number of pages available</value>
    /*
    <example>11</example>
    */
    [JsonPropertyName("total_pages")]
    public int TotalPages { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class ProxyAccessLogsResponse {\n");
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