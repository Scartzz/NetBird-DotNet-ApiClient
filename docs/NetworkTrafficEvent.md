# NetBird.ApiClient.Model.NetworkTrafficEvent

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FlowId** | **string** | FlowID is the ID of the connection flow. Not unique because it can be the same for multiple events (e.g., start and end of the connection). | 
**ReporterId** | **string** | ID of the reporter of the event (e.g., the peer that reported the event). | 
**Source** | [**NetworkTrafficEndpoint**](NetworkTrafficEndpoint.md) |  | 
**Destination** | [**NetworkTrafficEndpoint**](NetworkTrafficEndpoint.md) |  | 
**User** | [**NetworkTrafficUser**](NetworkTrafficUser.md) |  | 
**Policy** | [**NetworkTrafficPolicy**](NetworkTrafficPolicy.md) |  | 
**Icmp** | [**NetworkTrafficICMP**](NetworkTrafficICMP.md) |  | 
**Protocol** | **int** | Protocol is the protocol of the traffic (e.g. 1 &#x3D; ICMP, 6 &#x3D; TCP, 17 &#x3D; UDP, etc.). | 
**Direction** | **string** | Direction of the traffic (e.g. DIRECTION_UNKNOWN, INGRESS, EGRESS). | 
**RxBytes** | **int** | Number of bytes received. | 
**RxPackets** | **int** | Number of packets received. | 
**TxBytes** | **int** | Number of bytes transmitted. | 
**TxPackets** | **int** | Number of packets transmitted. | 
**Events** | [**List&lt;NetworkTrafficSubEvent&gt;**](NetworkTrafficSubEvent.md) | List of events that are correlated to this flow (e.g., start, end). | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

