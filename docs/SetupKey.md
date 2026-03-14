# NetBird.ApiClient.Model.SetupKey

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Setup Key ID | 
**Name** | **string** | Setup key name identifier | 
**Expires** | **DateTimeOffset** | Setup Key expiration date | 
**Type** | **string** | Setup key type, one-off for single time usage and reusable | 
**Valid** | **bool** | Setup key validity status | 
**Revoked** | **bool** | Setup key revocation status | 
**UsedTimes** | **int** | Usage count of setup key | 
**LastUsed** | **DateTimeOffset** | Setup key last usage date | 
**State** | **string** | Setup key status, \&quot;valid\&quot;, \&quot;overused\&quot;,\&quot;expired\&quot; or \&quot;revoked\&quot; | 
**AutoGroups** | **List&lt;string&gt;** | List of group IDs to auto-assign to peers registered with this key | 
**UpdatedAt** | **DateTimeOffset** | Setup key last update date | 
**UsageLimit** | **int** | A number of times this key can be used. The value of 0 indicates the unlimited usage. | 
**Ephemeral** | **bool** | Indicate that the peer will be ephemeral or not | 
**AllowExtraDnsLabels** | **bool** | Allow extra DNS labels to be added to the peer | 
**Key** | **string** | Setup Key as secret | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

