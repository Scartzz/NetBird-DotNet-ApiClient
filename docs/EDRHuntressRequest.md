# NetBird.ApiClient.Model.EDRHuntressRequest
Request payload for creating or updating a EDR Huntress integration

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ApiKey** | **string** | Huntress API key | 
**ApiSecret** | **string** | Huntress API secret | 
**Groups** | **List&lt;string&gt;** | The Groups this integrations applies to | 
**LastSyncedInterval** | **int** | The devices last sync requirement interval in hours. Minimum value is 24 hours | 
**Enabled** | **bool** | Indicates whether the integration is enabled | [optional] [default to true]
**MatchAttributes** | [**HuntressMatchAttributes**](HuntressMatchAttributes.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

