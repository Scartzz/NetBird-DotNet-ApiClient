# NetBird.ApiClient.Model.EDRIntuneRequest
Request payload for creating or updating a EDR Intune integration.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClientId** | **string** | The Azure application client id | 
**TenantId** | **string** | The Azure tenant id | 
**Secret** | **string** | The Azure application client secret | 
**Groups** | **List&lt;string&gt;** | The Groups this integrations applies to | 
**LastSyncedInterval** | **int** | The devices last sync requirement interval in hours. Minimum value is 24 hours. | 
**Enabled** | **bool** | Indicates whether the integration is enabled | [optional] [default to true]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

