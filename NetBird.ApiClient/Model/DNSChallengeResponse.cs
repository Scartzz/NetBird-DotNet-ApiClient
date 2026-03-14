


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
/// DNSChallengeResponse
/// </summary>
[DataContract(Name = "DNSChallengeResponse")]
public class DNSChallengeResponse : IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DNSChallengeResponse" /> class.
    /// </summary>
    [JsonConstructor]
    protected DNSChallengeResponse() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="DNSChallengeResponse" /> class.
    /// </summary>
    /// <param name="dnsChallenge">The DNS challenge to set in a TXT record (required).</param>
    public DNSChallengeResponse(string dnsChallenge = null)
    {
        // to ensure "dnsChallenge" is required (not null)
        ArgumentNullException.ThrowIfNull(dnsChallenge);
        this.DnsChallenge = dnsChallenge;
    }

    /// <summary>
    /// The DNS challenge to set in a TXT record
    /// </summary>
    /// <value>The DNS challenge to set in a TXT record</value>
    /*
    <example>YXNkYSBkYXNhc2Rhc2RhIGFzZGFzZDJhc2QyNDUxNQ</example>
    */
    [JsonPropertyName("dns_challenge")]
    public string DnsChallenge { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class DNSChallengeResponse {\n");
        sb.Append("  DnsChallenge: ").Append(DnsChallenge).Append("\n");
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