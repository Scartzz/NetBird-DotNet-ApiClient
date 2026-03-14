# NetBird.ApiClient.Model.NetworkRouter

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Peer** | **string** | Peer Identifier associated with route. This property can not be set together with &#x60;peer_groups&#x60; | [optional] 
**PeerGroups** | **List&lt;string&gt;** | Peers Group Identifier associated with route. This property can not be set together with &#x60;peer&#x60; | [optional] 
**Metric** | **int** | Route metric number. Lowest number has higher priority | 
**Masquerade** | **bool** | Indicate if peer should masquerade traffic to this route&#39;s prefix | 
**Enabled** | **bool** | Network router status | 
**Id** | **string** | Network Router Id | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

