# NetBird.ApiClient.Model.AccountExtraSettings

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PeerApprovalEnabled** | **bool** | (Cloud only) Enables or disables peer approval globally. If enabled, all peers added will be in pending state until approved by an admin. | 
**UserApprovalRequired** | **bool** | Enables manual approval for new users joining via domain matching. When enabled, users are blocked with pending approval status until explicitly approved by an admin. | 
**NetworkTrafficLogsEnabled** | **bool** | Enables or disables network traffic logging. If enabled, all network traffic events from peers will be stored. | 
**NetworkTrafficLogsGroups** | **List&lt;string&gt;** | Limits traffic logging to these groups. If unset all peers are enabled. | 
**NetworkTrafficPacketCounterEnabled** | **bool** | Enables or disables network traffic packet counter. If enabled, network packets and their size will be counted and reported. (This can have an slight impact on performance) | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

