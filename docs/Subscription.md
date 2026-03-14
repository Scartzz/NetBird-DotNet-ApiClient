# NetBird.ApiClient.Model.Subscription

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Active** | **bool** | Indicates whether the subscription is active or not. | 
**PlanTier** | **string** | The tier of the plan for the subscription. | 
**PriceId** | **string** | Unique identifier for the price of the subscription. | 
**RemainingTrial** | **int** | The remaining time for the trial period, in seconds. | [optional] 
**Features** | **List&lt;string&gt;** | List of features included in the subscription. | [optional] 
**Currency** | **string** | Currency code of the subscription. | 
**Price** | **int** | Price amount in minor units (e.g., cents). | 
**Provider** | **string** | The provider of the subscription. | 
**UpdatedAt** | **DateTimeOffset** | The date and time when the subscription was last updated. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

