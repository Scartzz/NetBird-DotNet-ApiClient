


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
/// Standard error response. Note: The exact structure of this error response is inferred from &#x60;util.WriteErrorResponse&#x60; and &#x60;util.WriteError&#x60; usage in the provided Go code, as a specific Go struct for errors was not provided.
/// </summary>
[DataContract(Name = "ErrorResponse")]
public class ErrorResponse : IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ErrorResponse" /> class.
    /// </summary>
    /// <param name="message">A human-readable error message..</param>
    public ErrorResponse(string message = null)
    {
        this.Message = message;
    }

    /// <summary>
    /// A human-readable error message.
    /// </summary>
    /// <value>A human-readable error message.</value>
    /*
    <example>couldn&#39;t parse JSON request</example>
    */
    [JsonPropertyName("message")]
    public string Message { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class ErrorResponse {\n");
        sb.Append("  Message: ").Append(Message).Append("\n");
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