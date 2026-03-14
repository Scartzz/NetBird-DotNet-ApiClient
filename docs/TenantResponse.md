# NetBird.ApiClient.Model.TenantResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The updated MSP tenant account ID | 
**Name** | **string** | The name for the MSP tenant | 
**Domain** | **string** | The tenant account domain | 
**Groups** | [**List&lt;TenantGroupResponse&gt;**](TenantGroupResponse.md) | MSP users Groups that can access the Tenant and Roles to assume | 
**ActivatedAt** | **DateTimeOffset** | The date and time when the tenant was activated. | [optional] 
**DnsChallenge** | **string** | The DNS challenge to set in a TXT record | 
**CreatedAt** | **DateTimeOffset** | The date and time when the tenant was created. | 
**UpdatedAt** | **DateTimeOffset** | The date and time when the tenant was last updated. | 
**InvitedAt** | **DateTimeOffset** | The date and time when the existing tenant was invited. | [optional] 
**Status** | **string** | The status of the tenant | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

