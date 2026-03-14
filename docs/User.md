# NetBird.ApiClient.Model.User

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | User ID | 
**Email** | **string** | User&#39;s email address | 
**Password** | **string** | User&#39;s password. Only present when user is created (create user endpoint is called) and only when IdP supports user creation with password. | [optional] 
**Name** | **string** | User&#39;s name from idp provider | 
**Role** | **string** | User&#39;s NetBird account role | 
**Status** | **string** | User&#39;s status | 
**LastLogin** | **DateTimeOffset** | Last time this user performed a login to the dashboard | [optional] 
**AutoGroups** | **List&lt;string&gt;** | Group IDs to auto-assign to peers registered by this user | 
**IsCurrent** | **bool** | Is true if authenticated user is the same as this user | [optional] [readonly] 
**IsServiceUser** | **bool** | Is true if this user is a service user | [optional] [readonly] 
**IsBlocked** | **bool** | Is true if this user is blocked. Blocked users can&#39;t use the system | 
**PendingApproval** | **bool** | Is true if this user requires approval before being activated. Only applicable for users joining via domain matching when user_approval_required is enabled. | 
**Issued** | **string** | How user was issued by API or Integration | [optional] 
**IdpId** | **string** | Identity provider ID (connector ID) that the user authenticated with. Only populated for users with Dex-encoded user IDs. | [optional] 
**Permissions** | [**UserPermissions**](UserPermissions.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

