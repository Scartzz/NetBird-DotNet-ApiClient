# NetBird.ApiClient.Model.NameserverGroup

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name of nameserver group name | 
**Description** | **string** | Description of the nameserver group | 
**Nameservers** | [**List&lt;Nameserver&gt;**](Nameserver.md) | Nameserver list | 
**Enabled** | **bool** | Nameserver group status | 
**Groups** | **List&lt;string&gt;** | Distribution group IDs that defines group of peers that will use this nameserver group | 
**Primary** | **bool** | Defines if a nameserver group is primary that resolves all domains. It should be true only if domains list is empty. | 
**Domains** | **List&lt;string&gt;** | Match domain list. It should be empty only if primary is true. | 
**SearchDomainsEnabled** | **bool** | Search domain status for match domains. It should be true only if domains list is not empty. | 
**Id** | **string** | Nameserver group ID | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

