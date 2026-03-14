


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
/// DNSRecord
/// </summary>
[DataContract(Name = "DNSRecord")]
public class DNSRecord : IValidatableObject
{

    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [JsonPropertyName("type")]
    public DNSRecordType Type { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="DNSRecord" /> class.
    /// </summary>
    [JsonConstructor]
    protected DNSRecord() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="DNSRecord" /> class.
    /// </summary>
    /// <param name="name">FQDN for the DNS record. Must be a subdomain within or match the zone&#39;s domain. (required).</param>
    /// <param name="type">type (required).</param>
    /// <param name="content">DNS record content (IP address for A/AAAA, domain for CNAME) (required).</param>
    /// <param name="ttl">Time to live in seconds (required).</param>
    /// <param name="id">DNS record ID (required).</param>
    public DNSRecord(string name = null, DNSRecordType type = default, string content = null, int ttl = 0, string id = null)
    {
        // to ensure "name" is required (not null)
        ArgumentNullException.ThrowIfNull(name);
        this.Name = name;
        this.Type = type;
        // to ensure "content" is required (not null)
        ArgumentNullException.ThrowIfNull(content);
        this.Content = content;
        this.Ttl = ttl;
        // to ensure "id" is required (not null)
        ArgumentNullException.ThrowIfNull(id);
        this.Id = id;
    }

    /// <summary>
    /// FQDN for the DNS record. Must be a subdomain within or match the zone&#39;s domain.
    /// </summary>
    /// <value>FQDN for the DNS record. Must be a subdomain within or match the zone&#39;s domain.</value>
    /*
    <example>www.example.com</example>
    */
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// DNS record content (IP address for A/AAAA, domain for CNAME)
    /// </summary>
    /// <value>DNS record content (IP address for A/AAAA, domain for CNAME)</value>
    /*
    <example>192.168.1.1</example>
    */
    [JsonPropertyName("content")]
    public string Content { get; set; }

    /// <summary>
    /// Time to live in seconds
    /// </summary>
    /// <value>Time to live in seconds</value>
    /*
    <example>300</example>
    */
    [JsonPropertyName("ttl")]
    public int Ttl { get; set; }

    /// <summary>
    /// DNS record ID
    /// </summary>
    /// <value>DNS record ID</value>
    /*
    <example>ch8i4ug6lnn4g9hqv7m0</example>
    */
    [JsonPropertyName("id")]
    public string Id { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class DNSRecord {\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Content: ").Append(Content).Append("\n");
        sb.Append("  Ttl: ").Append(Ttl).Append("\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
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
        // Content (string) maxLength
        if (this.Content is not null && this.Content.Length > 255)
        {
            yield return new ValidationResult("Invalid value for Content, length must be less than 255.", new [] { "Content" });
        }

        // Content (string) minLength
        if (this.Content is not null && this.Content.Length < 1)
        {
            yield return new ValidationResult("Invalid value for Content, length must be greater than 1.", new [] { "Content" });
        }

        // Ttl (int) minimum
        if (this.Ttl < (int)0)
        {
            yield return new ValidationResult("Invalid value for Ttl, must be a value greater than or equal to 0.", new [] { "Ttl" });
        }

        yield break;
    }
}