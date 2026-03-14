# NetBird.ApiClient.Model.ScimIntegration
Represents a SCIM IDP integration

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **long** | The unique identifier for the integration | 
**Enabled** | **bool** | Indicates whether the integration is enabled | 
**Provider** | **string** | Name of the SCIM identity provider | 
**GroupPrefixes** | **List&lt;string&gt;** | List of start_with string patterns for groups to sync | 
**UserGroupPrefixes** | **List&lt;string&gt;** | List of start_with string patterns for groups which users to sync | 
**AuthToken** | **string** | SCIM API token (full on creation, masked otherwise) | 
**LastSyncedAt** | **DateTimeOffset** | Timestamp of when the integration was last synced | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

