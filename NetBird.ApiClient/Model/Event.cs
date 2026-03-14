


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
/// Event
/// </summary>
[DataContract(Name = "Event")]
public class Event : IValidatableObject
{
    /// <summary>
    /// The string code of the activity that occurred during the event
    /// </summary>
    /// <value>The string code of the activity that occurred during the event</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ActivityCodeEnum
    {
        /// <summary>
        /// Enum PeerUserAdd for value: peer.user.add
        /// </summary>
        [EnumMember(Value = "peer.user.add")]
        PeerUserAdd = 1,

        /// <summary>
        /// Enum PeerSetupkeyAdd for value: peer.setupkey.add
        /// </summary>
        [EnumMember(Value = "peer.setupkey.add")]
        PeerSetupkeyAdd = 2,

        /// <summary>
        /// Enum UserJoin for value: user.join
        /// </summary>
        [EnumMember(Value = "user.join")]
        UserJoin = 3,

        /// <summary>
        /// Enum UserInvite for value: user.invite
        /// </summary>
        [EnumMember(Value = "user.invite")]
        UserInvite = 4,

        /// <summary>
        /// Enum AccountCreate for value: account.create
        /// </summary>
        [EnumMember(Value = "account.create")]
        AccountCreate = 5,

        /// <summary>
        /// Enum AccountDelete for value: account.delete
        /// </summary>
        [EnumMember(Value = "account.delete")]
        AccountDelete = 6,

        /// <summary>
        /// Enum UserPeerDelete for value: user.peer.delete
        /// </summary>
        [EnumMember(Value = "user.peer.delete")]
        UserPeerDelete = 7,

        /// <summary>
        /// Enum RuleAdd for value: rule.add
        /// </summary>
        [EnumMember(Value = "rule.add")]
        RuleAdd = 8,

        /// <summary>
        /// Enum RuleUpdate for value: rule.update
        /// </summary>
        [EnumMember(Value = "rule.update")]
        RuleUpdate = 9,

        /// <summary>
        /// Enum RuleDelete for value: rule.delete
        /// </summary>
        [EnumMember(Value = "rule.delete")]
        RuleDelete = 10,

        /// <summary>
        /// Enum PolicyAdd for value: policy.add
        /// </summary>
        [EnumMember(Value = "policy.add")]
        PolicyAdd = 11,

        /// <summary>
        /// Enum PolicyUpdate for value: policy.update
        /// </summary>
        [EnumMember(Value = "policy.update")]
        PolicyUpdate = 12,

        /// <summary>
        /// Enum PolicyDelete for value: policy.delete
        /// </summary>
        [EnumMember(Value = "policy.delete")]
        PolicyDelete = 13,

        /// <summary>
        /// Enum SetupkeyAdd for value: setupkey.add
        /// </summary>
        [EnumMember(Value = "setupkey.add")]
        SetupkeyAdd = 14,

        /// <summary>
        /// Enum SetupkeyUpdate for value: setupkey.update
        /// </summary>
        [EnumMember(Value = "setupkey.update")]
        SetupkeyUpdate = 15,

        /// <summary>
        /// Enum SetupkeyRevoke for value: setupkey.revoke
        /// </summary>
        [EnumMember(Value = "setupkey.revoke")]
        SetupkeyRevoke = 16,

        /// <summary>
        /// Enum SetupkeyOveruse for value: setupkey.overuse
        /// </summary>
        [EnumMember(Value = "setupkey.overuse")]
        SetupkeyOveruse = 17,

        /// <summary>
        /// Enum SetupkeyDelete for value: setupkey.delete
        /// </summary>
        [EnumMember(Value = "setupkey.delete")]
        SetupkeyDelete = 18,

        /// <summary>
        /// Enum GroupAdd for value: group.add
        /// </summary>
        [EnumMember(Value = "group.add")]
        GroupAdd = 19,

        /// <summary>
        /// Enum GroupUpdate for value: group.update
        /// </summary>
        [EnumMember(Value = "group.update")]
        GroupUpdate = 20,

        /// <summary>
        /// Enum GroupDelete for value: group.delete
        /// </summary>
        [EnumMember(Value = "group.delete")]
        GroupDelete = 21,

        /// <summary>
        /// Enum PeerGroupAdd for value: peer.group.add
        /// </summary>
        [EnumMember(Value = "peer.group.add")]
        PeerGroupAdd = 22,

        /// <summary>
        /// Enum PeerGroupDelete for value: peer.group.delete
        /// </summary>
        [EnumMember(Value = "peer.group.delete")]
        PeerGroupDelete = 23,

        /// <summary>
        /// Enum UserGroupAdd for value: user.group.add
        /// </summary>
        [EnumMember(Value = "user.group.add")]
        UserGroupAdd = 24,

        /// <summary>
        /// Enum UserGroupDelete for value: user.group.delete
        /// </summary>
        [EnumMember(Value = "user.group.delete")]
        UserGroupDelete = 25,

        /// <summary>
        /// Enum UserRoleUpdate for value: user.role.update
        /// </summary>
        [EnumMember(Value = "user.role.update")]
        UserRoleUpdate = 26,

        /// <summary>
        /// Enum SetupkeyGroupAdd for value: setupkey.group.add
        /// </summary>
        [EnumMember(Value = "setupkey.group.add")]
        SetupkeyGroupAdd = 27,

        /// <summary>
        /// Enum SetupkeyGroupDelete for value: setupkey.group.delete
        /// </summary>
        [EnumMember(Value = "setupkey.group.delete")]
        SetupkeyGroupDelete = 28,

        /// <summary>
        /// Enum DnsSettingDisabledManagementGroupAdd for value: dns.setting.disabled.management.group.add
        /// </summary>
        [EnumMember(Value = "dns.setting.disabled.management.group.add")]
        DnsSettingDisabledManagementGroupAdd = 29,

        /// <summary>
        /// Enum DnsSettingDisabledManagementGroupDelete for value: dns.setting.disabled.management.group.delete
        /// </summary>
        [EnumMember(Value = "dns.setting.disabled.management.group.delete")]
        DnsSettingDisabledManagementGroupDelete = 30,

        /// <summary>
        /// Enum RouteAdd for value: route.add
        /// </summary>
        [EnumMember(Value = "route.add")]
        RouteAdd = 31,

        /// <summary>
        /// Enum RouteDelete for value: route.delete
        /// </summary>
        [EnumMember(Value = "route.delete")]
        RouteDelete = 32,

        /// <summary>
        /// Enum RouteUpdate for value: route.update
        /// </summary>
        [EnumMember(Value = "route.update")]
        RouteUpdate = 33,

        /// <summary>
        /// Enum PeerSshEnable for value: peer.ssh.enable
        /// </summary>
        [EnumMember(Value = "peer.ssh.enable")]
        PeerSshEnable = 34,

        /// <summary>
        /// Enum PeerSshDisable for value: peer.ssh.disable
        /// </summary>
        [EnumMember(Value = "peer.ssh.disable")]
        PeerSshDisable = 35,

        /// <summary>
        /// Enum PeerRename for value: peer.rename
        /// </summary>
        [EnumMember(Value = "peer.rename")]
        PeerRename = 36,

        /// <summary>
        /// Enum PeerLoginExpirationEnable for value: peer.login.expiration.enable
        /// </summary>
        [EnumMember(Value = "peer.login.expiration.enable")]
        PeerLoginExpirationEnable = 37,

        /// <summary>
        /// Enum PeerLoginExpirationDisable for value: peer.login.expiration.disable
        /// </summary>
        [EnumMember(Value = "peer.login.expiration.disable")]
        PeerLoginExpirationDisable = 38,

        /// <summary>
        /// Enum NameserverGroupAdd for value: nameserver.group.add
        /// </summary>
        [EnumMember(Value = "nameserver.group.add")]
        NameserverGroupAdd = 39,

        /// <summary>
        /// Enum NameserverGroupDelete for value: nameserver.group.delete
        /// </summary>
        [EnumMember(Value = "nameserver.group.delete")]
        NameserverGroupDelete = 40,

        /// <summary>
        /// Enum NameserverGroupUpdate for value: nameserver.group.update
        /// </summary>
        [EnumMember(Value = "nameserver.group.update")]
        NameserverGroupUpdate = 41,

        /// <summary>
        /// Enum AccountSettingPeerLoginExpirationUpdate for value: account.setting.peer.login.expiration.update
        /// </summary>
        [EnumMember(Value = "account.setting.peer.login.expiration.update")]
        AccountSettingPeerLoginExpirationUpdate = 42,

        /// <summary>
        /// Enum AccountSettingPeerLoginExpirationEnable for value: account.setting.peer.login.expiration.enable
        /// </summary>
        [EnumMember(Value = "account.setting.peer.login.expiration.enable")]
        AccountSettingPeerLoginExpirationEnable = 43,

        /// <summary>
        /// Enum AccountSettingPeerLoginExpirationDisable for value: account.setting.peer.login.expiration.disable
        /// </summary>
        [EnumMember(Value = "account.setting.peer.login.expiration.disable")]
        AccountSettingPeerLoginExpirationDisable = 44,

        /// <summary>
        /// Enum PersonalAccessTokenCreate for value: personal.access.token.create
        /// </summary>
        [EnumMember(Value = "personal.access.token.create")]
        PersonalAccessTokenCreate = 45,

        /// <summary>
        /// Enum PersonalAccessTokenDelete for value: personal.access.token.delete
        /// </summary>
        [EnumMember(Value = "personal.access.token.delete")]
        PersonalAccessTokenDelete = 46,

        /// <summary>
        /// Enum ServiceUserCreate for value: service.user.create
        /// </summary>
        [EnumMember(Value = "service.user.create")]
        ServiceUserCreate = 47,

        /// <summary>
        /// Enum ServiceUserDelete for value: service.user.delete
        /// </summary>
        [EnumMember(Value = "service.user.delete")]
        ServiceUserDelete = 48,

        /// <summary>
        /// Enum UserBlock for value: user.block
        /// </summary>
        [EnumMember(Value = "user.block")]
        UserBlock = 49,

        /// <summary>
        /// Enum UserUnblock for value: user.unblock
        /// </summary>
        [EnumMember(Value = "user.unblock")]
        UserUnblock = 50,

        /// <summary>
        /// Enum UserDelete for value: user.delete
        /// </summary>
        [EnumMember(Value = "user.delete")]
        UserDelete = 51,

        /// <summary>
        /// Enum UserPeerLogin for value: user.peer.login
        /// </summary>
        [EnumMember(Value = "user.peer.login")]
        UserPeerLogin = 52,

        /// <summary>
        /// Enum PeerLoginExpire for value: peer.login.expire
        /// </summary>
        [EnumMember(Value = "peer.login.expire")]
        PeerLoginExpire = 53,

        /// <summary>
        /// Enum DashboardLogin for value: dashboard.login
        /// </summary>
        [EnumMember(Value = "dashboard.login")]
        DashboardLogin = 54,

        /// <summary>
        /// Enum IntegrationCreate for value: integration.create
        /// </summary>
        [EnumMember(Value = "integration.create")]
        IntegrationCreate = 55,

        /// <summary>
        /// Enum IntegrationUpdate for value: integration.update
        /// </summary>
        [EnumMember(Value = "integration.update")]
        IntegrationUpdate = 56,

        /// <summary>
        /// Enum IntegrationDelete for value: integration.delete
        /// </summary>
        [EnumMember(Value = "integration.delete")]
        IntegrationDelete = 57,

        /// <summary>
        /// Enum AccountSettingPeerApprovalEnable for value: account.setting.peer.approval.enable
        /// </summary>
        [EnumMember(Value = "account.setting.peer.approval.enable")]
        AccountSettingPeerApprovalEnable = 58,

        /// <summary>
        /// Enum AccountSettingPeerApprovalDisable for value: account.setting.peer.approval.disable
        /// </summary>
        [EnumMember(Value = "account.setting.peer.approval.disable")]
        AccountSettingPeerApprovalDisable = 59,

        /// <summary>
        /// Enum PeerApprove for value: peer.approve
        /// </summary>
        [EnumMember(Value = "peer.approve")]
        PeerApprove = 60,

        /// <summary>
        /// Enum PeerApprovalRevoke for value: peer.approval.revoke
        /// </summary>
        [EnumMember(Value = "peer.approval.revoke")]
        PeerApprovalRevoke = 61,

        /// <summary>
        /// Enum TransferredOwnerRole for value: transferred.owner.role
        /// </summary>
        [EnumMember(Value = "transferred.owner.role")]
        TransferredOwnerRole = 62,

        /// <summary>
        /// Enum PostureCheckCreate for value: posture.check.create
        /// </summary>
        [EnumMember(Value = "posture.check.create")]
        PostureCheckCreate = 63,

        /// <summary>
        /// Enum PostureCheckUpdate for value: posture.check.update
        /// </summary>
        [EnumMember(Value = "posture.check.update")]
        PostureCheckUpdate = 64,

        /// <summary>
        /// Enum PostureCheckDelete for value: posture.check.delete
        /// </summary>
        [EnumMember(Value = "posture.check.delete")]
        PostureCheckDelete = 65,

        /// <summary>
        /// Enum PeerInactivityExpirationEnable for value: peer.inactivity.expiration.enable
        /// </summary>
        [EnumMember(Value = "peer.inactivity.expiration.enable")]
        PeerInactivityExpirationEnable = 66,

        /// <summary>
        /// Enum PeerInactivityExpirationDisable for value: peer.inactivity.expiration.disable
        /// </summary>
        [EnumMember(Value = "peer.inactivity.expiration.disable")]
        PeerInactivityExpirationDisable = 67,

        /// <summary>
        /// Enum AccountPeerInactivityExpirationEnable for value: account.peer.inactivity.expiration.enable
        /// </summary>
        [EnumMember(Value = "account.peer.inactivity.expiration.enable")]
        AccountPeerInactivityExpirationEnable = 68,

        /// <summary>
        /// Enum AccountPeerInactivityExpirationDisable for value: account.peer.inactivity.expiration.disable
        /// </summary>
        [EnumMember(Value = "account.peer.inactivity.expiration.disable")]
        AccountPeerInactivityExpirationDisable = 69,

        /// <summary>
        /// Enum AccountPeerInactivityExpirationUpdate for value: account.peer.inactivity.expiration.update
        /// </summary>
        [EnumMember(Value = "account.peer.inactivity.expiration.update")]
        AccountPeerInactivityExpirationUpdate = 70,

        /// <summary>
        /// Enum AccountSettingGroupPropagationEnable for value: account.setting.group.propagation.enable
        /// </summary>
        [EnumMember(Value = "account.setting.group.propagation.enable")]
        AccountSettingGroupPropagationEnable = 71,

        /// <summary>
        /// Enum AccountSettingGroupPropagationDisable for value: account.setting.group.propagation.disable
        /// </summary>
        [EnumMember(Value = "account.setting.group.propagation.disable")]
        AccountSettingGroupPropagationDisable = 72,

        /// <summary>
        /// Enum AccountSettingRoutingPeerDnsResolutionEnable for value: account.setting.routing.peer.dns.resolution.enable
        /// </summary>
        [EnumMember(Value = "account.setting.routing.peer.dns.resolution.enable")]
        AccountSettingRoutingPeerDnsResolutionEnable = 73,

        /// <summary>
        /// Enum AccountSettingRoutingPeerDnsResolutionDisable for value: account.setting.routing.peer.dns.resolution.disable
        /// </summary>
        [EnumMember(Value = "account.setting.routing.peer.dns.resolution.disable")]
        AccountSettingRoutingPeerDnsResolutionDisable = 74,

        /// <summary>
        /// Enum NetworkCreate for value: network.create
        /// </summary>
        [EnumMember(Value = "network.create")]
        NetworkCreate = 75,

        /// <summary>
        /// Enum NetworkUpdate for value: network.update
        /// </summary>
        [EnumMember(Value = "network.update")]
        NetworkUpdate = 76,

        /// <summary>
        /// Enum NetworkDelete for value: network.delete
        /// </summary>
        [EnumMember(Value = "network.delete")]
        NetworkDelete = 77,

        /// <summary>
        /// Enum NetworkResourceCreate for value: network.resource.create
        /// </summary>
        [EnumMember(Value = "network.resource.create")]
        NetworkResourceCreate = 78,

        /// <summary>
        /// Enum NetworkResourceUpdate for value: network.resource.update
        /// </summary>
        [EnumMember(Value = "network.resource.update")]
        NetworkResourceUpdate = 79,

        /// <summary>
        /// Enum NetworkResourceDelete for value: network.resource.delete
        /// </summary>
        [EnumMember(Value = "network.resource.delete")]
        NetworkResourceDelete = 80,

        /// <summary>
        /// Enum NetworkRouterCreate for value: network.router.create
        /// </summary>
        [EnumMember(Value = "network.router.create")]
        NetworkRouterCreate = 81,

        /// <summary>
        /// Enum NetworkRouterUpdate for value: network.router.update
        /// </summary>
        [EnumMember(Value = "network.router.update")]
        NetworkRouterUpdate = 82,

        /// <summary>
        /// Enum NetworkRouterDelete for value: network.router.delete
        /// </summary>
        [EnumMember(Value = "network.router.delete")]
        NetworkRouterDelete = 83,

        /// <summary>
        /// Enum ResourceGroupAdd for value: resource.group.add
        /// </summary>
        [EnumMember(Value = "resource.group.add")]
        ResourceGroupAdd = 84,

        /// <summary>
        /// Enum ResourceGroupDelete for value: resource.group.delete
        /// </summary>
        [EnumMember(Value = "resource.group.delete")]
        ResourceGroupDelete = 85,

        /// <summary>
        /// Enum AccountDnsDomainUpdate for value: account.dns.domain.update
        /// </summary>
        [EnumMember(Value = "account.dns.domain.update")]
        AccountDnsDomainUpdate = 86,

        /// <summary>
        /// Enum AccountSettingLazyConnectionEnable for value: account.setting.lazy.connection.enable
        /// </summary>
        [EnumMember(Value = "account.setting.lazy.connection.enable")]
        AccountSettingLazyConnectionEnable = 87,

        /// <summary>
        /// Enum AccountSettingLazyConnectionDisable for value: account.setting.lazy.connection.disable
        /// </summary>
        [EnumMember(Value = "account.setting.lazy.connection.disable")]
        AccountSettingLazyConnectionDisable = 88,

        /// <summary>
        /// Enum AccountNetworkRangeUpdate for value: account.network.range.update
        /// </summary>
        [EnumMember(Value = "account.network.range.update")]
        AccountNetworkRangeUpdate = 89,

        /// <summary>
        /// Enum PeerIpUpdate for value: peer.ip.update
        /// </summary>
        [EnumMember(Value = "peer.ip.update")]
        PeerIpUpdate = 90,

        /// <summary>
        /// Enum UserApprove for value: user.approve
        /// </summary>
        [EnumMember(Value = "user.approve")]
        UserApprove = 91,

        /// <summary>
        /// Enum UserReject for value: user.reject
        /// </summary>
        [EnumMember(Value = "user.reject")]
        UserReject = 92,

        /// <summary>
        /// Enum UserCreate for value: user.create
        /// </summary>
        [EnumMember(Value = "user.create")]
        UserCreate = 93,

        /// <summary>
        /// Enum AccountSettingsAutoVersionUpdate for value: account.settings.auto.version.update
        /// </summary>
        [EnumMember(Value = "account.settings.auto.version.update")]
        AccountSettingsAutoVersionUpdate = 94,

        /// <summary>
        /// Enum IdentityproviderCreate for value: identityprovider.create
        /// </summary>
        [EnumMember(Value = "identityprovider.create")]
        IdentityproviderCreate = 95,

        /// <summary>
        /// Enum IdentityproviderUpdate for value: identityprovider.update
        /// </summary>
        [EnumMember(Value = "identityprovider.update")]
        IdentityproviderUpdate = 96,

        /// <summary>
        /// Enum IdentityproviderDelete for value: identityprovider.delete
        /// </summary>
        [EnumMember(Value = "identityprovider.delete")]
        IdentityproviderDelete = 97,

        /// <summary>
        /// Enum DnsZoneCreate for value: dns.zone.create
        /// </summary>
        [EnumMember(Value = "dns.zone.create")]
        DnsZoneCreate = 98,

        /// <summary>
        /// Enum DnsZoneUpdate for value: dns.zone.update
        /// </summary>
        [EnumMember(Value = "dns.zone.update")]
        DnsZoneUpdate = 99,

        /// <summary>
        /// Enum DnsZoneDelete for value: dns.zone.delete
        /// </summary>
        [EnumMember(Value = "dns.zone.delete")]
        DnsZoneDelete = 100,

        /// <summary>
        /// Enum DnsZoneRecordCreate for value: dns.zone.record.create
        /// </summary>
        [EnumMember(Value = "dns.zone.record.create")]
        DnsZoneRecordCreate = 101,

        /// <summary>
        /// Enum DnsZoneRecordUpdate for value: dns.zone.record.update
        /// </summary>
        [EnumMember(Value = "dns.zone.record.update")]
        DnsZoneRecordUpdate = 102,

        /// <summary>
        /// Enum DnsZoneRecordDelete for value: dns.zone.record.delete
        /// </summary>
        [EnumMember(Value = "dns.zone.record.delete")]
        DnsZoneRecordDelete = 103,

        /// <summary>
        /// Enum PeerJobCreate for value: peer.job.create
        /// </summary>
        [EnumMember(Value = "peer.job.create")]
        PeerJobCreate = 104,

        /// <summary>
        /// Enum UserPasswordChange for value: user.password.change
        /// </summary>
        [EnumMember(Value = "user.password.change")]
        UserPasswordChange = 105,

        /// <summary>
        /// Enum UserInviteLinkCreate for value: user.invite.link.create
        /// </summary>
        [EnumMember(Value = "user.invite.link.create")]
        UserInviteLinkCreate = 106,

        /// <summary>
        /// Enum UserInviteLinkAccept for value: user.invite.link.accept
        /// </summary>
        [EnumMember(Value = "user.invite.link.accept")]
        UserInviteLinkAccept = 107,

        /// <summary>
        /// Enum UserInviteLinkRegenerate for value: user.invite.link.regenerate
        /// </summary>
        [EnumMember(Value = "user.invite.link.regenerate")]
        UserInviteLinkRegenerate = 108,

        /// <summary>
        /// Enum UserInviteLinkDelete for value: user.invite.link.delete
        /// </summary>
        [EnumMember(Value = "user.invite.link.delete")]
        UserInviteLinkDelete = 109,

        /// <summary>
        /// Enum ServiceCreate for value: service.create
        /// </summary>
        [EnumMember(Value = "service.create")]
        ServiceCreate = 110,

        /// <summary>
        /// Enum ServiceUpdate for value: service.update
        /// </summary>
        [EnumMember(Value = "service.update")]
        ServiceUpdate = 111,

        /// <summary>
        /// Enum ServiceDelete for value: service.delete
        /// </summary>
        [EnumMember(Value = "service.delete")]
        ServiceDelete = 112
    }


    /// <summary>
    /// The string code of the activity that occurred during the event
    /// </summary>
    /// <value>The string code of the activity that occurred during the event</value>
    /*
    <example>route.add</example>
    */
    [JsonPropertyName("activity_code")]
    public ActivityCodeEnum ActivityCode { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="Event" /> class.
    /// </summary>
    [JsonConstructor]
    protected Event() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="Event" /> class.
    /// </summary>
    /// <param name="id">Event unique identifier (required).</param>
    /// <param name="timestamp">The date and time when the event occurred (required).</param>
    /// <param name="activity">The activity that occurred during the event (required).</param>
    /// <param name="activityCode">The string code of the activity that occurred during the event (required).</param>
    /// <param name="initiatorId">The ID of the initiator of the event. E.g., an ID of a user that triggered the event. (required).</param>
    /// <param name="initiatorName">The name of the initiator of the event. (required).</param>
    /// <param name="initiatorEmail">The e-mail address of the initiator of the event. E.g., an e-mail of a user that triggered the event. (required).</param>
    /// <param name="targetId">The ID of the target of the event. E.g., an ID of the peer that a user removed. (required).</param>
    /// <param name="meta">The metadata of the event (required).</param>
    public Event(string id = null, DateTimeOffset timestamp = default, string activity = null, ActivityCodeEnum activityCode = default, string initiatorId = null, string initiatorName = null, string initiatorEmail = null, string targetId = null, Dictionary<string, string> meta = null)
    {
        // to ensure "id" is required (not null)
        ArgumentNullException.ThrowIfNull(id);
        this.Id = id;
        this.Timestamp = timestamp;
        // to ensure "activity" is required (not null)
        ArgumentNullException.ThrowIfNull(activity);
        this.Activity = activity;
        this.ActivityCode = activityCode;
        // to ensure "initiatorId" is required (not null)
        ArgumentNullException.ThrowIfNull(initiatorId);
        this.InitiatorId = initiatorId;
        // to ensure "initiatorName" is required (not null)
        ArgumentNullException.ThrowIfNull(initiatorName);
        this.InitiatorName = initiatorName;
        // to ensure "initiatorEmail" is required (not null)
        ArgumentNullException.ThrowIfNull(initiatorEmail);
        this.InitiatorEmail = initiatorEmail;
        // to ensure "targetId" is required (not null)
        ArgumentNullException.ThrowIfNull(targetId);
        this.TargetId = targetId;
        // to ensure "meta" is required (not null)
        ArgumentNullException.ThrowIfNull(meta);
        this.Meta = meta;
    }

    /// <summary>
    /// Event unique identifier
    /// </summary>
    /// <value>Event unique identifier</value>
    /*
    <example>10</example>
    */
    [JsonPropertyName("id")]
    public string Id { get; set; }

    /// <summary>
    /// The date and time when the event occurred
    /// </summary>
    /// <value>The date and time when the event occurred</value>
    /*
    <example>2023-05-05T10:04:37.473542Z</example>
    */
    [JsonPropertyName("timestamp")]
    public DateTimeOffset Timestamp { get; set; }

    /// <summary>
    /// The activity that occurred during the event
    /// </summary>
    /// <value>The activity that occurred during the event</value>
    /*
    <example>Route created</example>
    */
    [JsonPropertyName("activity")]
    public string Activity { get; set; }

    /// <summary>
    /// The ID of the initiator of the event. E.g., an ID of a user that triggered the event.
    /// </summary>
    /// <value>The ID of the initiator of the event. E.g., an ID of a user that triggered the event.</value>
    /*
    <example>google-oauth2|123456789012345678901</example>
    */
    [JsonPropertyName("initiator_id")]
    public string InitiatorId { get; set; }

    /// <summary>
    /// The name of the initiator of the event.
    /// </summary>
    /// <value>The name of the initiator of the event.</value>
    /*
    <example>John Doe</example>
    */
    [JsonPropertyName("initiator_name")]
    public string InitiatorName { get; set; }

    /// <summary>
    /// The e-mail address of the initiator of the event. E.g., an e-mail of a user that triggered the event.
    /// </summary>
    /// <value>The e-mail address of the initiator of the event. E.g., an e-mail of a user that triggered the event.</value>
    /*
    <example>demo@netbird.io</example>
    */
    [JsonPropertyName("initiator_email")]
    public string InitiatorEmail { get; set; }

    /// <summary>
    /// The ID of the target of the event. E.g., an ID of the peer that a user removed.
    /// </summary>
    /// <value>The ID of the target of the event. E.g., an ID of the peer that a user removed.</value>
    /*
    <example>chad9d86lnnc59g18ou0</example>
    */
    [JsonPropertyName("target_id")]
    public string TargetId { get; set; }

    /// <summary>
    /// The metadata of the event
    /// </summary>
    /// <value>The metadata of the event</value>
    /*
    <example>{name&#x3D;my route, network_range&#x3D;10.64.0.0/24, peer_id&#x3D;chacbco6lnnbn6cg5s91}</example>
    */
    [JsonPropertyName("meta")]
    public Dictionary<string, string> Meta { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class Event {\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
        sb.Append("  Activity: ").Append(Activity).Append("\n");
        sb.Append("  ActivityCode: ").Append(ActivityCode).Append("\n");
        sb.Append("  InitiatorId: ").Append(InitiatorId).Append("\n");
        sb.Append("  InitiatorName: ").Append(InitiatorName).Append("\n");
        sb.Append("  InitiatorEmail: ").Append(InitiatorEmail).Append("\n");
        sb.Append("  TargetId: ").Append(TargetId).Append("\n");
        sb.Append("  Meta: ").Append(Meta).Append("\n");
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