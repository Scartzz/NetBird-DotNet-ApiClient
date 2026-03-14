# NetBird.ApiClient.Model.Event

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Event unique identifier | 
**Timestamp** | **DateTimeOffset** | The date and time when the event occurred | 
**Activity** | **string** | The activity that occurred during the event | 
**ActivityCode** | **string** | The string code of the activity that occurred during the event | 
**InitiatorId** | **string** | The ID of the initiator of the event. E.g., an ID of a user that triggered the event. | 
**InitiatorName** | **string** | The name of the initiator of the event. | 
**InitiatorEmail** | **string** | The e-mail address of the initiator of the event. E.g., an e-mail of a user that triggered the event. | 
**TargetId** | **string** | The ID of the target of the event. E.g., an ID of the peer that a user removed. | 
**Meta** | **Dictionary&lt;string, string&gt;** | The metadata of the event | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

