# NetBird.ApiClient.Model.IngressPortAllocation

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | ID of the ingress port allocation | 
**Name** | **string** | Name of the ingress port allocation | 
**IngressPeerId** | **string** | ID of the ingress peer that forwards the ports | 
**Region** | **string** | Region of the ingress peer | 
**Enabled** | **bool** | Indicates if an ingress port allocation is enabled | 
**IngressIp** | **string** | Ingress IP address of the ingress peer where the traffic arrives | 
**PortRangeMappings** | [**List&lt;IngressPortAllocationPortMapping&gt;**](IngressPortAllocationPortMapping.md) | List of port ranges that are allowed to be used by the ingress peer | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

