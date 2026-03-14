


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
/// PeerRequest
/// </summary>
[DataContract(Name = "PeerRequest")]
public class PeerRequest : IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PeerRequest" /> class.
    /// </summary>
    [JsonConstructor]
    protected PeerRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="PeerRequest" /> class.
    /// </summary>
    /// <param name="name">name (required).</param>
    /// <param name="sshEnabled">sshEnabled (required).</param>
    /// <param name="loginExpirationEnabled">loginExpirationEnabled (required).</param>
    /// <param name="inactivityExpirationEnabled">inactivityExpirationEnabled (required).</param>
    /// <param name="approvalRequired">(Cloud only) Indicates whether peer needs approval.</param>
    /// <param name="ip">Peer&#39;s IP address.</param>
    public PeerRequest(string name = null, bool sshEnabled = false, bool loginExpirationEnabled = false, bool inactivityExpirationEnabled = false, bool approvalRequired = false, string ip = null)
    {
        // to ensure "name" is required (not null)
        ArgumentNullException.ThrowIfNull(name);
        this.Name = name;
        this.SshEnabled = sshEnabled;
        this.LoginExpirationEnabled = loginExpirationEnabled;
        this.InactivityExpirationEnabled = inactivityExpirationEnabled;
        this.ApprovalRequired = approvalRequired;
        this.Ip = ip;
    }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    /*
    <example>stage-host-1</example>
    */
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets SshEnabled
    /// </summary>
    /*
    <example>true</example>
    */
    [JsonPropertyName("ssh_enabled")]
    public bool SshEnabled { get; set; }

    /// <summary>
    /// Gets or Sets LoginExpirationEnabled
    /// </summary>
    /*
    <example>false</example>
    */
    [JsonPropertyName("login_expiration_enabled")]
    public bool LoginExpirationEnabled { get; set; }

    /// <summary>
    /// Gets or Sets InactivityExpirationEnabled
    /// </summary>
    /*
    <example>false</example>
    */
    [JsonPropertyName("inactivity_expiration_enabled")]
    public bool InactivityExpirationEnabled { get; set; }

    /// <summary>
    /// (Cloud only) Indicates whether peer needs approval
    /// </summary>
    /// <value>(Cloud only) Indicates whether peer needs approval</value>
    /*
    <example>true</example>
    */
    [JsonPropertyName("approval_required")]
    public bool ApprovalRequired { get; set; }

    /// <summary>
    /// Peer&#39;s IP address
    /// </summary>
    /// <value>Peer&#39;s IP address</value>
    /*
    <example>100.64.0.15</example>
    */
    [JsonPropertyName("ip")]
    public string Ip { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class PeerRequest {\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  SshEnabled: ").Append(SshEnabled).Append("\n");
        sb.Append("  LoginExpirationEnabled: ").Append(LoginExpirationEnabled).Append("\n");
        sb.Append("  InactivityExpirationEnabled: ").Append(InactivityExpirationEnabled).Append("\n");
        sb.Append("  ApprovalRequired: ").Append(ApprovalRequired).Append("\n");
        sb.Append("  Ip: ").Append(Ip).Append("\n");
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