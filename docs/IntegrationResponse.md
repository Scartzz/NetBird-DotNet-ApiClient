# NetBird.ApiClient.Model.IntegrationResponse
Represents an event streaming integration.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **long** | The unique numeric identifier for the integration. | [optional] 
**AccountId** | **string** | The identifier of the account this integration belongs to. | [optional] 
**Enabled** | **bool** | Whether the integration is currently active. | [optional] 
**Platform** | **string** | The event streaming platform. | [optional] 
**CreatedAt** | **DateTimeOffset** | Timestamp of when the integration was created. | [optional] 
**UpdatedAt** | **DateTimeOffset** | Timestamp of when the integration was last updated. | [optional] 
**Config** | **Dictionary&lt;string, string&gt;** | Configuration for the integration. Sensitive keys (like API keys, secret keys) are masked with &#39;****&#39; in responses, as indicated by the GetIntegration handler logic. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

