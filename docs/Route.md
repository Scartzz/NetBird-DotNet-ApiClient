# NetBird.ApiClient.Model.Route

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Description** | **string** | Route description | 
**NetworkId** | **string** | Route network identifier, to group HA routes | 
**Enabled** | **bool** | Route status | 
**Peer** | **string** | Peer Identifier associated with route. This property can not be set together with &#x60;peer_groups&#x60; | [optional] 
**PeerGroups** | **List&lt;string&gt;** | Peers Group Identifier associated with route. This property can not be set together with &#x60;peer&#x60; | [optional] 
**Network** | **string** | Network range in CIDR format, Conflicts with domains | [optional] 
**Domains** | **List&lt;string&gt;** | Domain list to be dynamically resolved. Max of 32 domains can be added per route configuration. Conflicts with network | [optional] 
**Metric** | **int** | Route metric number. Lowest number has higher priority | 
**Masquerade** | **bool** | Indicate if peer should masquerade traffic to this route&#39;s prefix | 
**Groups** | **List&lt;string&gt;** | Group IDs containing routing peers | 
**KeepRoute** | **bool** | Indicate if the route should be kept after a domain doesn&#39;t resolve that IP anymore | 
**AccessControlGroups** | **List&lt;string&gt;** | Access control group identifier associated with route. | [optional] 
**SkipAutoApply** | **bool** | Indicate if this exit node route (0.0.0.0/0) should skip auto-application for client routing | [optional] 
**Id** | **string** | Route Id | 
**NetworkType** | **string** | Network type indicating if it is a domain route or a IPv4/IPv6 route | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

