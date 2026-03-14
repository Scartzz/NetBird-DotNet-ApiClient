


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
/// ApiIntegrationsMspTenantsIdInvitePutRequest
/// </summary>
[DataContract(Name = "_api_integrations_msp_tenants__id__invite_put_request")]
public class ApiIntegrationsMspTenantsIdInvitePutRequest : IValidatableObject
{
    /// <summary>
    /// Accept or decline the invitation.
    /// </summary>
    /// <value>Accept or decline the invitation.</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ValueEnum
    {
        /// <summary>
        /// Enum Accept for value: accept
        /// </summary>
        [EnumMember(Value = "accept")]
        Accept = 1,

        /// <summary>
        /// Enum Decline for value: decline
        /// </summary>
        [EnumMember(Value = "decline")]
        Decline = 2
    }


    /// <summary>
    /// Accept or decline the invitation.
    /// </summary>
    /// <value>Accept or decline the invitation.</value>
    [JsonPropertyName("value")]
    public ValueEnum Value { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="ApiIntegrationsMspTenantsIdInvitePutRequest" /> class.
    /// </summary>
    [JsonConstructor]
    protected ApiIntegrationsMspTenantsIdInvitePutRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ApiIntegrationsMspTenantsIdInvitePutRequest" /> class.
    /// </summary>
    /// <param name="value">Accept or decline the invitation. (required).</param>
    public ApiIntegrationsMspTenantsIdInvitePutRequest(ValueEnum value = default)
    {
        this.Value = value;
    }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class ApiIntegrationsMspTenantsIdInvitePutRequest {\n");
        sb.Append("  Value: ").Append(Value).Append("\n");
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