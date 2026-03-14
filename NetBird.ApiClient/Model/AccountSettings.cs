


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
/// AccountSettings
/// </summary>
[DataContract(Name = "AccountSettings")]
public class AccountSettings : IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AccountSettings" /> class.
    /// </summary>
    [JsonConstructor]
    protected AccountSettings() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="AccountSettings" /> class.
    /// </summary>
    /// <param name="peerLoginExpirationEnabled">Enables or disables peer login expiration globally. After peer&#39;s login has expired the user has to log in (authenticate). Applies only to peers that were added by a user (interactive SSO login). (required).</param>
    /// <param name="peerLoginExpiration">Period of time after which peer login expires (seconds). (required).</param>
    /// <param name="peerInactivityExpirationEnabled">Enables or disables peer inactivity expiration globally. After peer&#39;s session has expired the user has to log in (authenticate). Applies only to peers that were added by a user (interactive SSO login). (required).</param>
    /// <param name="peerInactivityExpiration">Period of time of inactivity after which peer session expires (seconds). (required).</param>
    /// <param name="regularUsersViewBlocked">Allows blocking regular users from viewing parts of the system. (required).</param>
    /// <param name="groupsPropagationEnabled">Allows propagate the new user auto groups to peers that belongs to the user.</param>
    /// <param name="jwtGroupsEnabled">Allows extract groups from JWT claim and add it to account groups..</param>
    /// <param name="jwtGroupsClaimName">Name of the claim from which we extract groups names to add it to account groups..</param>
    /// <param name="jwtAllowGroups">List of groups to which users are allowed access.</param>
    /// <param name="routingPeerDnsResolutionEnabled">Enables or disables DNS resolution on the routing peers.</param>
    /// <param name="dnsDomain">Allows to define a custom dns domain for the account.</param>
    /// <param name="networkRange">Allows to define a custom network range for the account in CIDR format.</param>
    /// <param name="peerExposeEnabled">Enables or disables peer expose. If enabled, peers can expose local services through the reverse proxy using the CLI. (required).</param>
    /// <param name="peerExposeGroups">Limits which peer groups are allowed to expose services. If empty, all peers are allowed when peer expose is enabled. (required).</param>
    /// <param name="extra">extra.</param>
    /// <param name="lazyConnectionEnabled">Enables or disables experimental lazy connection.</param>
    /// <param name="autoUpdateVersion">Set Clients auto-update version. \&quot;latest\&quot;, \&quot;disabled\&quot;, or a specific version (e.g \&quot;0.50.1\&quot;).</param>
    /// <param name="autoUpdateAlways">When true, updates are installed automatically in the background. When false, updates require user interaction from the UI..</param>
    public AccountSettings(bool peerLoginExpirationEnabled = false, int peerLoginExpiration = 0, bool peerInactivityExpirationEnabled = false, int peerInactivityExpiration = 0, bool regularUsersViewBlocked = false, bool groupsPropagationEnabled = false, bool jwtGroupsEnabled = false, string jwtGroupsClaimName = null, List<string> jwtAllowGroups = null, bool routingPeerDnsResolutionEnabled = false, string dnsDomain = null, string networkRange = null, bool peerExposeEnabled = false, List<string> peerExposeGroups = null, AccountExtraSettings extra = null, bool lazyConnectionEnabled = false, string autoUpdateVersion = null, bool autoUpdateAlways = false)
    {
        this.PeerLoginExpirationEnabled = peerLoginExpirationEnabled;
        this.PeerLoginExpiration = peerLoginExpiration;
        this.PeerInactivityExpirationEnabled = peerInactivityExpirationEnabled;
        this.PeerInactivityExpiration = peerInactivityExpiration;
        this.RegularUsersViewBlocked = regularUsersViewBlocked;
        this.PeerExposeEnabled = peerExposeEnabled;
        // to ensure "peerExposeGroups" is required (not null)
        ArgumentNullException.ThrowIfNull(peerExposeGroups);
        this.PeerExposeGroups = peerExposeGroups;
        this.GroupsPropagationEnabled = groupsPropagationEnabled;
        this.JwtGroupsEnabled = jwtGroupsEnabled;
        this.JwtGroupsClaimName = jwtGroupsClaimName;
        this.JwtAllowGroups = jwtAllowGroups;
        this.RoutingPeerDnsResolutionEnabled = routingPeerDnsResolutionEnabled;
        this.DnsDomain = dnsDomain;
        this.NetworkRange = networkRange;
        this.Extra = extra;
        this.LazyConnectionEnabled = lazyConnectionEnabled;
        this.AutoUpdateVersion = autoUpdateVersion;
        this.AutoUpdateAlways = autoUpdateAlways;
    }

    /// <summary>
    /// Enables or disables peer login expiration globally. After peer&#39;s login has expired the user has to log in (authenticate). Applies only to peers that were added by a user (interactive SSO login).
    /// </summary>
    /// <value>Enables or disables peer login expiration globally. After peer&#39;s login has expired the user has to log in (authenticate). Applies only to peers that were added by a user (interactive SSO login).</value>
    /*
    <example>true</example>
    */
    [JsonPropertyName("peer_login_expiration_enabled")]
    public bool PeerLoginExpirationEnabled { get; set; }

    /// <summary>
    /// Period of time after which peer login expires (seconds).
    /// </summary>
    /// <value>Period of time after which peer login expires (seconds).</value>
    /*
    <example>43200</example>
    */
    [JsonPropertyName("peer_login_expiration")]
    public int PeerLoginExpiration { get; set; }

    /// <summary>
    /// Enables or disables peer inactivity expiration globally. After peer&#39;s session has expired the user has to log in (authenticate). Applies only to peers that were added by a user (interactive SSO login).
    /// </summary>
    /// <value>Enables or disables peer inactivity expiration globally. After peer&#39;s session has expired the user has to log in (authenticate). Applies only to peers that were added by a user (interactive SSO login).</value>
    /*
    <example>true</example>
    */
    [JsonPropertyName("peer_inactivity_expiration_enabled")]
    public bool PeerInactivityExpirationEnabled { get; set; }

    /// <summary>
    /// Period of time of inactivity after which peer session expires (seconds).
    /// </summary>
    /// <value>Period of time of inactivity after which peer session expires (seconds).</value>
    /*
    <example>43200</example>
    */
    [JsonPropertyName("peer_inactivity_expiration")]
    public int PeerInactivityExpiration { get; set; }

    /// <summary>
    /// Allows blocking regular users from viewing parts of the system.
    /// </summary>
    /// <value>Allows blocking regular users from viewing parts of the system.</value>
    /*
    <example>true</example>
    */
    [JsonPropertyName("regular_users_view_blocked")]
    public bool RegularUsersViewBlocked { get; set; }

    /// <summary>
    /// Allows propagate the new user auto groups to peers that belongs to the user
    /// </summary>
    /// <value>Allows propagate the new user auto groups to peers that belongs to the user</value>
    /*
    <example>true</example>
    */
    [JsonPropertyName("groups_propagation_enabled")]
    public bool GroupsPropagationEnabled { get; set; }

    /// <summary>
    /// Allows extract groups from JWT claim and add it to account groups.
    /// </summary>
    /// <value>Allows extract groups from JWT claim and add it to account groups.</value>
    /*
    <example>true</example>
    */
    [JsonPropertyName("jwt_groups_enabled")]
    public bool JwtGroupsEnabled { get; set; }

    /// <summary>
    /// Name of the claim from which we extract groups names to add it to account groups.
    /// </summary>
    /// <value>Name of the claim from which we extract groups names to add it to account groups.</value>
    /*
    <example>roles</example>
    */
    [JsonPropertyName("jwt_groups_claim_name")]
    public string JwtGroupsClaimName { get; set; }

    /// <summary>
    /// List of groups to which users are allowed access
    /// </summary>
    /// <value>List of groups to which users are allowed access</value>
    [JsonPropertyName("jwt_allow_groups")]
    public List<string> JwtAllowGroups { get; set; }

    /// <summary>
    /// Enables or disables DNS resolution on the routing peers
    /// </summary>
    /// <value>Enables or disables DNS resolution on the routing peers</value>
    /*
    <example>true</example>
    */
    [JsonPropertyName("routing_peer_dns_resolution_enabled")]
    public bool RoutingPeerDnsResolutionEnabled { get; set; }

    /// <summary>
    /// Allows to define a custom dns domain for the account
    /// </summary>
    /// <value>Allows to define a custom dns domain for the account</value>
    /*
    <example>my-organization.org</example>
    */
    [JsonPropertyName("dns_domain")]
    public string DnsDomain { get; set; }

    /// <summary>
    /// Allows to define a custom network range for the account in CIDR format
    /// </summary>
    /// <value>Allows to define a custom network range for the account in CIDR format</value>
    /*
    <example>100.64.0.0/16</example>
    */
    [JsonPropertyName("network_range")]
    public string NetworkRange { get; set; }

    /// <summary>
    /// Enables or disables peer expose. If enabled, peers can expose local services through the reverse proxy using the CLI.
    /// </summary>
    /// <value>Enables or disables peer expose. If enabled, peers can expose local services through the reverse proxy using the CLI.</value>
    /*
    <example>false</example>
    */
    [JsonPropertyName("peer_expose_enabled")]
    public bool PeerExposeEnabled { get; set; }

    /// <summary>
    /// Limits which peer groups are allowed to expose services. If empty, all peers are allowed when peer expose is enabled.
    /// </summary>
    /// <value>Limits which peer groups are allowed to expose services. If empty, all peers are allowed when peer expose is enabled.</value>
    [JsonPropertyName("peer_expose_groups")]
    public List<string> PeerExposeGroups { get; set; }

    /// <summary>
    /// Gets or Sets Extra
    /// </summary>
    [JsonPropertyName("extra")]
    public AccountExtraSettings Extra { get; set; }

    /// <summary>
    /// Enables or disables experimental lazy connection
    /// </summary>
    /// <value>Enables or disables experimental lazy connection</value>
    /*
    <example>true</example>
    */
    [JsonPropertyName("lazy_connection_enabled")]
    public bool LazyConnectionEnabled { get; set; }

    /// <summary>
    /// Set Clients auto-update version. \&quot;latest\&quot;, \&quot;disabled\&quot;, or a specific version (e.g \&quot;0.50.1\&quot;)
    /// </summary>
    /// <value>Set Clients auto-update version. \&quot;latest\&quot;, \&quot;disabled\&quot;, or a specific version (e.g \&quot;0.50.1\&quot;)</value>
    /*
    <example>0.51.2</example>
    */
    [JsonPropertyName("auto_update_version")]
    public string AutoUpdateVersion { get; set; }

    /// <summary>
    /// When true, updates are installed automatically in the background. When false, updates require user interaction from the UI.
    /// </summary>
    /// <value>When true, updates are installed automatically in the background. When false, updates require user interaction from the UI.</value>
    /*
    <example>false</example>
    */
    [JsonPropertyName("auto_update_always")]
    public bool AutoUpdateAlways { get; set; }

    /// <summary>
    /// Indicates whether the embedded identity provider (Dex) is enabled for this account. This is a read-only field.
    /// </summary>
    /// <value>Indicates whether the embedded identity provider (Dex) is enabled for this account. This is a read-only field.</value>
    /*
    <example>false</example>
    */
    [JsonPropertyName("embedded_idp_enabled")]
    public bool EmbeddedIdpEnabled { get; private set; }

    /// <summary>
    /// Returns false as EmbeddedIdpEnabled should not be serialized given that it's read-only.
    /// </summary>
    /// <returns>false (boolean)</returns>
    public bool ShouldSerializeEmbeddedIdpEnabled()
    {
        return false;
    }
    /// <summary>
    /// Indicates whether local (email/password) authentication is disabled. When true, users can only authenticate via external identity providers. This is a read-only field.
    /// </summary>
    /// <value>Indicates whether local (email/password) authentication is disabled. When true, users can only authenticate via external identity providers. This is a read-only field.</value>
    /*
    <example>false</example>
    */
    [JsonPropertyName("local_auth_disabled")]
    public bool LocalAuthDisabled { get; private set; }

    /// <summary>
    /// Returns false as LocalAuthDisabled should not be serialized given that it's read-only.
    /// </summary>
    /// <returns>false (boolean)</returns>
    public bool ShouldSerializeLocalAuthDisabled()
    {
        return false;
    }
    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class AccountSettings {\n");
        sb.Append("  PeerLoginExpirationEnabled: ").Append(PeerLoginExpirationEnabled).Append("\n");
        sb.Append("  PeerLoginExpiration: ").Append(PeerLoginExpiration).Append("\n");
        sb.Append("  PeerInactivityExpirationEnabled: ").Append(PeerInactivityExpirationEnabled).Append("\n");
        sb.Append("  PeerInactivityExpiration: ").Append(PeerInactivityExpiration).Append("\n");
        sb.Append("  RegularUsersViewBlocked: ").Append(RegularUsersViewBlocked).Append("\n");
        sb.Append("  GroupsPropagationEnabled: ").Append(GroupsPropagationEnabled).Append("\n");
        sb.Append("  JwtGroupsEnabled: ").Append(JwtGroupsEnabled).Append("\n");
        sb.Append("  JwtGroupsClaimName: ").Append(JwtGroupsClaimName).Append("\n");
        sb.Append("  JwtAllowGroups: ").Append(JwtAllowGroups).Append("\n");
        sb.Append("  RoutingPeerDnsResolutionEnabled: ").Append(RoutingPeerDnsResolutionEnabled).Append("\n");
        sb.Append("  DnsDomain: ").Append(DnsDomain).Append("\n");
        sb.Append("  NetworkRange: ").Append(NetworkRange).Append("\n");
        sb.Append("  PeerExposeEnabled: ").Append(PeerExposeEnabled).Append("\n");
        sb.Append("  PeerExposeGroups: ").Append(PeerExposeGroups).Append("\n");
        sb.Append("  Extra: ").Append(Extra).Append("\n");
        sb.Append("  LazyConnectionEnabled: ").Append(LazyConnectionEnabled).Append("\n");
        sb.Append("  AutoUpdateVersion: ").Append(AutoUpdateVersion).Append("\n");
        sb.Append("  AutoUpdateAlways: ").Append(AutoUpdateAlways).Append("\n");
        sb.Append("  EmbeddedIdpEnabled: ").Append(EmbeddedIdpEnabled).Append("\n");
        sb.Append("  LocalAuthDisabled: ").Append(LocalAuthDisabled).Append("\n");
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