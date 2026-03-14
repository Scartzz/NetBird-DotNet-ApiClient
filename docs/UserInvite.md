# NetBird.ApiClient.Model.UserInvite
A user invite

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Invite ID | 
**Email** | **string** | User&#39;s email address | 
**Name** | **string** | User&#39;s full name | 
**Role** | **string** | User&#39;s NetBird account role | 
**AutoGroups** | **List&lt;string&gt;** | Group IDs to auto-assign to peers registered by this user | 
**ExpiresAt** | **DateTimeOffset** | Invite expiration time | 
**CreatedAt** | **DateTimeOffset** | Invite creation time | 
**Expired** | **bool** | Whether the invite has expired | 
**InviteToken** | **string** | The invite link to be shared with the user. Only returned when the invite is created or regenerated. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

