# NetBird.ApiClient.Model.ServiceRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Service name | 
**Domain** | **string** | Domain for the service | 
**Mode** | **string** | Service mode. \&quot;http\&quot; for L7 reverse proxy, \&quot;tcp\&quot;/\&quot;udp\&quot;/\&quot;tls\&quot; for L4 passthrough. | [optional] [default to ModeEnum.Http]
**ListenPort** | **int** | Port the proxy listens on (L4/TLS only). Set to 0 for auto-assignment. | [optional] 
**Targets** | [**List&lt;ServiceTarget&gt;**](ServiceTarget.md) | List of target backends for this service | [optional] 
**Enabled** | **bool** | Whether the service is enabled | [default to true]
**PassHostHeader** | **bool** | When true, the original client Host header is passed through to the backend instead of being rewritten to the backend&#39;s address | [optional] 
**RewriteRedirects** | **bool** | When true, Location headers in backend responses are rewritten to replace the backend address with the public-facing domain | [optional] 
**Auth** | [**ServiceAuthConfig**](ServiceAuthConfig.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

