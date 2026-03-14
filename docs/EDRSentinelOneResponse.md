# NetBird.ApiClient.Model.EDRSentinelOneResponse
Represents a SentinelOne EDR integration configuration

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **long** | The unique numeric identifier for the integration. | 
**AccountId** | **string** | The identifier of the account this integration belongs to. | 
**LastSyncedAt** | **DateTimeOffset** | Timestamp of when the integration was last synced. | 
**CreatedBy** | **string** | The user id that created the integration | 
**CreatedAt** | **DateTimeOffset** | Timestamp of when the integration was created. | 
**UpdatedAt** | **DateTimeOffset** | Timestamp of when the integration was last updated. | 
**ApiUrl** | **string** | The Base URL of SentinelOne API | 
**Groups** | [**List&lt;Group&gt;**](Group.md) | List of groups | 
**LastSyncedInterval** | **int** | The devices last sync requirement interval in hours. | 
**MatchAttributes** | [**SentinelOneMatchAttributes**](SentinelOneMatchAttributes.md) |  | 
**Enabled** | **bool** | Indicates whether the integration is enabled | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

