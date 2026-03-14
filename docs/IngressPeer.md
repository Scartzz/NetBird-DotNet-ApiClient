# NetBird.ApiClient.Model.IngressPeer

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | ID of the ingress peer | 
**PeerId** | **string** | ID of the peer that is used as an ingress peer | 
**IngressIp** | **string** | Ingress IP address of the ingress peer where the traffic arrives | 
**AvailablePorts** | [**AvailablePorts**](AvailablePorts.md) |  | 
**Enabled** | **bool** | Indicates if an ingress peer is enabled | 
**Connected** | **bool** | Indicates if an ingress peer is connected to the management server | 
**Fallback** | **bool** | Indicates if an ingress peer can be used as a fallback if no ingress peer can be found in the region of the forwarded peer | 
**Region** | **string** | Region of the ingress peer | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

