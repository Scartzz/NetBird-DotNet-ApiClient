


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
/// ApiIntegrationsMspTenantsIdUnlinkPostRequest
/// </summary>
[DataContract(Name = "_api_integrations_msp_tenants__id__unlink_post_request")]
public class ApiIntegrationsMspTenantsIdUnlinkPostRequest : IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ApiIntegrationsMspTenantsIdUnlinkPostRequest" /> class.
    /// </summary>
    [JsonConstructor]
    protected ApiIntegrationsMspTenantsIdUnlinkPostRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ApiIntegrationsMspTenantsIdUnlinkPostRequest" /> class.
    /// </summary>
    /// <param name="owner">The new owners user ID. (required).</param>
    public ApiIntegrationsMspTenantsIdUnlinkPostRequest(string owner = null)
    {
        // to ensure "owner" is required (not null)
        ArgumentNullException.ThrowIfNull(owner);
        this.Owner = owner;
    }

    /// <summary>
    /// The new owners user ID.
    /// </summary>
    /// <value>The new owners user ID.</value>
    /*
    <example>google-oauth2|123456789012345678901</example>
    */
    [JsonPropertyName("owner")]
    public string Owner { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class ApiIntegrationsMspTenantsIdUnlinkPostRequest {\n");
        sb.Append("  Owner: ").Append(Owner).Append("\n");
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