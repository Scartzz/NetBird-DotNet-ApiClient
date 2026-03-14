# NetBird.ApiClient.Model.CreateSetupKeyRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Setup Key name | 
**Type** | **string** | Setup key type, one-off for single time usage and reusable | 
**ExpiresIn** | **int** | Expiration time in seconds | 
**AutoGroups** | **List&lt;string&gt;** | List of group IDs to auto-assign to peers registered with this key | 
**UsageLimit** | **int** | A number of times this key can be used. The value of 0 indicates the unlimited usage. | 
**Ephemeral** | **bool** | Indicate that the peer will be ephemeral or not | [optional] 
**AllowExtraDnsLabels** | **bool** | Allow extra DNS labels to be added to the peer | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

