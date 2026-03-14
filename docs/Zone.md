# NetBird.ApiClient.Model.Zone

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Zone name identifier | 
**Domain** | **string** | Zone domain (FQDN) | 
**Enabled** | **bool** | Zone status | [optional] [default to true]
**EnableSearchDomain** | **bool** | Enable this zone as a search domain | 
**DistributionGroups** | **List&lt;string&gt;** | Group IDs that defines groups of peers that will resolve this zone | 
**Id** | **string** | Zone ID | 
**Records** | [**List&lt;DNSRecord&gt;**](DNSRecord.md) | DNS records associated with this zone | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

