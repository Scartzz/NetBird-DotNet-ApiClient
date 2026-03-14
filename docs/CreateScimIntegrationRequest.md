# NetBird.ApiClient.Model.CreateScimIntegrationRequest
Request payload for creating an SCIM IDP integration

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Prefix** | **string** | The connection prefix used for the SCIM provider | 
**Provider** | **string** | Name of the SCIM identity provider | 
**GroupPrefixes** | **List&lt;string&gt;** | List of start_with string patterns for groups to sync | [optional] 
**UserGroupPrefixes** | **List&lt;string&gt;** | List of start_with string patterns for groups which users to sync | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

