


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
/// DNSRecordRequest
/// </summary>
[DataContract(Name = "DNSRecordRequest")]
public class DNSRecordRequest : IValidatableObject
{

    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [JsonPropertyName("type")]
    public DNSRecordType Type { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="DNSRecordRequest" /> class.
    /// </summary>
    [JsonConstructor]
    protected DNSRecordRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="DNSRecordRequest" /> class.
    /// </summary>
    /// <param name="name">FQDN for the DNS record. Must be a subdomain within or match the zone&#39;s domain. (required).</param>
    /// <param name="type">type (required).</param>
    /// <param name="content">DNS record content (IP address for A/AAAA, domain for CNAME) (required).</param>
    /// <param name="ttl">Time to live in seconds (required).</param>
    public DNSRecordRequest(string name = null, DNSRecordType type = default, string content = null, int ttl = 0)
    {
        // to ensure "name" is required (not null)
        ArgumentNullException.ThrowIfNull(name);
        this.Name = name;
        this.Type = type;
        // to ensure "content" is required (not null)
        ArgumentNullException.ThrowIfNull(content);
        this.Content = content;
        this.Ttl = ttl;
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
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class DNSRecordRequest {\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Content: ").Append(Content).Append("\n");
        sb.Append("  Ttl: ").Append(Ttl).Append("\n");
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