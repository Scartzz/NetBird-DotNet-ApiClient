# NetBird.ApiClient.Model.EDRSentinelOneRequest
Request payload for creating or updating a EDR SentinelOne integration

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ApiToken** | **string** | SentinelOne API token | 
**ApiUrl** | **string** | The Base URL of SentinelOne API | 
**Groups** | **List&lt;string&gt;** | The Groups this integrations applies to | 
**LastSyncedInterval** | **int** | The devices last sync requirement interval in hours. Minimum value is 24 hours. | 
**Enabled** | **bool** | Indicates whether the integration is enabled | [optional] [default to true]
**MatchAttributes** | [**SentinelOneMatchAttributes**](SentinelOneMatchAttributes.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

