


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
/// User
/// </summary>
[DataContract(Name = "User")]
public class User : IValidatableObject
{
    /// <summary>
    /// User&#39;s status
    /// </summary>
    /// <value>User&#39;s status</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum StatusEnum
    {
        /// <summary>
        /// Enum Active for value: active
        /// </summary>
        [EnumMember(Value = "active")]
        Active = 1,

        /// <summary>
        /// Enum Invited for value: invited
        /// </summary>
        [EnumMember(Value = "invited")]
        Invited = 2,

        /// <summary>
        /// Enum Blocked for value: blocked
        /// </summary>
        [EnumMember(Value = "blocked")]
        Blocked = 3
    }


    /// <summary>
    /// User&#39;s status
    /// </summary>
    /// <value>User&#39;s status</value>
    /*
    <example>active</example>
    */
    [JsonPropertyName("status")]
    public StatusEnum Status { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="User" /> class.
    /// </summary>
    [JsonConstructor]
    protected User() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="User" /> class.
    /// </summary>
    /// <param name="id">User ID (required).</param>
    /// <param name="email">User&#39;s email address (required).</param>
    /// <param name="password">User&#39;s password. Only present when user is created (create user endpoint is called) and only when IdP supports user creation with password..</param>
    /// <param name="name">User&#39;s name from idp provider (required).</param>
    /// <param name="role">User&#39;s NetBird account role (required).</param>
    /// <param name="status">User&#39;s status (required).</param>
    /// <param name="lastLogin">Last time this user performed a login to the dashboard.</param>
    /// <param name="autoGroups">Group IDs to auto-assign to peers registered by this user (required).</param>
    /// <param name="isBlocked">Is true if this user is blocked. Blocked users can&#39;t use the system (required).</param>
    /// <param name="pendingApproval">Is true if this user requires approval before being activated. Only applicable for users joining via domain matching when user_approval_required is enabled. (required).</param>
    /// <param name="issued">How user was issued by API or Integration.</param>
    /// <param name="idpId">Identity provider ID (connector ID) that the user authenticated with. Only populated for users with Dex-encoded user IDs..</param>
    /// <param name="permissions">permissions.</param>
    public User(string id = null, string email = null, string password = null, string name = null, string role = null, StatusEnum status = default, DateTimeOffset lastLogin = default, List<string> autoGroups = null, bool isBlocked = false, bool pendingApproval = false, string issued = null, string idpId = null, UserPermissions permissions = null)
    {
        // to ensure "id" is required (not null)
        ArgumentNullException.ThrowIfNull(id);
        this.Id = id;
        // to ensure "email" is required (not null)
        ArgumentNullException.ThrowIfNull(email);
        this.Email = email;
        // to ensure "name" is required (not null)
        ArgumentNullException.ThrowIfNull(name);
        this.Name = name;
        // to ensure "role" is required (not null)
        ArgumentNullException.ThrowIfNull(role);
        this.Role = role;
        this.Status = status;
        // to ensure "autoGroups" is required (not null)
        ArgumentNullException.ThrowIfNull(autoGroups);
        this.AutoGroups = autoGroups;
        this.IsBlocked = isBlocked;
        this.PendingApproval = pendingApproval;
        this.Password = password;
        this.LastLogin = lastLogin;
        this.Issued = issued;
        this.IdpId = idpId;
        this.Permissions = permissions;
    }

    /// <summary>
    /// User ID
    /// </summary>
    /// <value>User ID</value>
    /*
    <example>google-oauth2|277474792786460067937</example>
    */
    [JsonPropertyName("id")]
    public string Id { get; set; }

    /// <summary>
    /// User&#39;s email address
    /// </summary>
    /// <value>User&#39;s email address</value>
    /*
    <example>demo@netbird.io</example>
    */
    [JsonPropertyName("email")]
    public string Email { get; set; }

    /// <summary>
    /// User&#39;s password. Only present when user is created (create user endpoint is called) and only when IdP supports user creation with password.
    /// </summary>
    /// <value>User&#39;s password. Only present when user is created (create user endpoint is called) and only when IdP supports user creation with password.</value>
    /*
    <example>super_secure_password</example>
    */
    [JsonPropertyName("password")]
    public string Password { get; set; }

    /// <summary>
    /// User&#39;s name from idp provider
    /// </summary>
    /// <value>User&#39;s name from idp provider</value>
    /*
    <example>Tom Schulz</example>
    */
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// User&#39;s NetBird account role
    /// </summary>
    /// <value>User&#39;s NetBird account role</value>
    /*
    <example>admin</example>
    */
    [JsonPropertyName("role")]
    public string Role { get; set; }

    /// <summary>
    /// Last time this user performed a login to the dashboard
    /// </summary>
    /// <value>Last time this user performed a login to the dashboard</value>
    /*
    <example>2023-05-05T09:00:35.477782Z</example>
    */
    [JsonPropertyName("last_login")]
    public DateTimeOffset LastLogin { get; set; }

    /// <summary>
    /// Group IDs to auto-assign to peers registered by this user
    /// </summary>
    /// <value>Group IDs to auto-assign to peers registered by this user</value>
    [JsonPropertyName("auto_groups")]
    public List<string> AutoGroups { get; set; }

    /// <summary>
    /// Is true if authenticated user is the same as this user
    /// </summary>
    /// <value>Is true if authenticated user is the same as this user</value>
    /*
    <example>true</example>
    */
    [JsonPropertyName("is_current")]
    public bool IsCurrent { get; private set; }

    /// <summary>
    /// Returns false as IsCurrent should not be serialized given that it's read-only.
    /// </summary>
    /// <returns>false (boolean)</returns>
    public bool ShouldSerializeIsCurrent()
    {
        return false;
    }
    /// <summary>
    /// Is true if this user is a service user
    /// </summary>
    /// <value>Is true if this user is a service user</value>
    /*
    <example>false</example>
    */
    [JsonPropertyName("is_service_user")]
    public bool IsServiceUser { get; private set; }

    /// <summary>
    /// Returns false as IsServiceUser should not be serialized given that it's read-only.
    /// </summary>
    /// <returns>false (boolean)</returns>
    public bool ShouldSerializeIsServiceUser()
    {
        return false;
    }
    /// <summary>
    /// Is true if this user is blocked. Blocked users can&#39;t use the system
    /// </summary>
    /// <value>Is true if this user is blocked. Blocked users can&#39;t use the system</value>
    /*
    <example>false</example>
    */
    [JsonPropertyName("is_blocked")]
    public bool IsBlocked { get; set; }

    /// <summary>
    /// Is true if this user requires approval before being activated. Only applicable for users joining via domain matching when user_approval_required is enabled.
    /// </summary>
    /// <value>Is true if this user requires approval before being activated. Only applicable for users joining via domain matching when user_approval_required is enabled.</value>
    /*
    <example>false</example>
    */
    [JsonPropertyName("pending_approval")]
    public bool PendingApproval { get; set; }

    /// <summary>
    /// How user was issued by API or Integration
    /// </summary>
    /// <value>How user was issued by API or Integration</value>
    /*
    <example>api</example>
    */
    [JsonPropertyName("issued")]
    public string Issued { get; set; }

    /// <summary>
    /// Identity provider ID (connector ID) that the user authenticated with. Only populated for users with Dex-encoded user IDs.
    /// </summary>
    /// <value>Identity provider ID (connector ID) that the user authenticated with. Only populated for users with Dex-encoded user IDs.</value>
    /*
    <example>okta-abc123</example>
    */
    [JsonPropertyName("idp_id")]
    public string IdpId { get; set; }

    /// <summary>
    /// Gets or Sets Permissions
    /// </summary>
    [JsonPropertyName("permissions")]
    public UserPermissions Permissions { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class User {\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Email: ").Append(Email).Append("\n");
        sb.Append("  Password: ").Append(Password).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Role: ").Append(Role).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  LastLogin: ").Append(LastLogin).Append("\n");
        sb.Append("  AutoGroups: ").Append(AutoGroups).Append("\n");
        sb.Append("  IsCurrent: ").Append(IsCurrent).Append("\n");
        sb.Append("  IsServiceUser: ").Append(IsServiceUser).Append("\n");
        sb.Append("  IsBlocked: ").Append(IsBlocked).Append("\n");
        sb.Append("  PendingApproval: ").Append(PendingApproval).Append("\n");
        sb.Append("  Issued: ").Append(Issued).Append("\n");
        sb.Append("  IdpId: ").Append(IdpId).Append("\n");
        sb.Append("  Permissions: ").Append(Permissions).Append("\n");
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