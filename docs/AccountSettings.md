# NetBird.ApiClient.Model.AccountSettings

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PeerLoginExpirationEnabled** | **bool** | Enables or disables peer login expiration globally. After peer&#39;s login has expired the user has to log in (authenticate). Applies only to peers that were added by a user (interactive SSO login). | 
**PeerLoginExpiration** | **int** | Period of time after which peer login expires (seconds). | 
**PeerInactivityExpirationEnabled** | **bool** | Enables or disables peer inactivity expiration globally. After peer&#39;s session has expired the user has to log in (authenticate). Applies only to peers that were added by a user (interactive SSO login). | 
**PeerInactivityExpiration** | **int** | Period of time of inactivity after which peer session expires (seconds). | 
**RegularUsersViewBlocked** | **bool** | Allows blocking regular users from viewing parts of the system. | 
**GroupsPropagationEnabled** | **bool** | Allows propagate the new user auto groups to peers that belongs to the user | [optional] 
**JwtGroupsEnabled** | **bool** | Allows extract groups from JWT claim and add it to account groups. | [optional] 
**JwtGroupsClaimName** | **string** | Name of the claim from which we extract groups names to add it to account groups. | [optional] 
**JwtAllowGroups** | **List&lt;string&gt;** | List of groups to which users are allowed access | [optional] 
**RoutingPeerDnsResolutionEnabled** | **bool** | Enables or disables DNS resolution on the routing peers | [optional] 
**DnsDomain** | **string** | Allows to define a custom dns domain for the account | [optional] 
**NetworkRange** | **string** | Allows to define a custom network range for the account in CIDR format | [optional] 
**PeerExposeEnabled** | **bool** | Enables or disables peer expose. If enabled, peers can expose local services through the reverse proxy using the CLI. | 
**PeerExposeGroups** | **List&lt;string&gt;** | Limits which peer groups are allowed to expose services. If empty, all peers are allowed when peer expose is enabled. | 
**Extra** | [**AccountExtraSettings**](AccountExtraSettings.md) |  | [optional] 
**LazyConnectionEnabled** | **bool** | Enables or disables experimental lazy connection | [optional] 
**AutoUpdateVersion** | **string** | Set Clients auto-update version. \&quot;latest\&quot;, \&quot;disabled\&quot;, or a specific version (e.g \&quot;0.50.1\&quot;) | [optional] 
**AutoUpdateAlways** | **bool** | When true, updates are installed automatically in the background. When false, updates require user interaction from the UI. | [optional] 
**EmbeddedIdpEnabled** | **bool** | Indicates whether the embedded identity provider (Dex) is enabled for this account. This is a read-only field. | [optional] [readonly] 
**LocalAuthDisabled** | **bool** | Indicates whether local (email/password) authentication is disabled. When true, users can only authenticate via external identity providers. This is a read-only field. | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

