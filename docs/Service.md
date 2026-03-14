# NetBird.ApiClient.Model.Service

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Service ID | 
**Name** | **string** | Service name | 
**Domain** | **string** | Domain for the service | 
**Mode** | **string** | Service mode. \&quot;http\&quot; for L7 reverse proxy, \&quot;tcp\&quot;/\&quot;udp\&quot;/\&quot;tls\&quot; for L4 passthrough. | [optional] [default to ModeEnum.Http]
**ListenPort** | **int** | Port the proxy listens on (L4/TLS only) | [optional] 
**PortAutoAssigned** | **bool** | Whether the listen port was auto-assigned | [optional] [readonly] 
**ProxyCluster** | **string** | The proxy cluster handling this service (derived from domain) | [optional] 
**Targets** | [**List&lt;ServiceTarget&gt;**](ServiceTarget.md) | List of target backends for this service | 
**Enabled** | **bool** | Whether the service is enabled | 
**PassHostHeader** | **bool** | When true, the original client Host header is passed through to the backend instead of being rewritten to the backend&#39;s address | [optional] 
**RewriteRedirects** | **bool** | When true, Location headers in backend responses are rewritten to replace the backend address with the public-facing domain | [optional] 
**Auth** | [**ServiceAuthConfig**](ServiceAuthConfig.md) |  | 
**Meta** | [**ServiceMeta**](ServiceMeta.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

