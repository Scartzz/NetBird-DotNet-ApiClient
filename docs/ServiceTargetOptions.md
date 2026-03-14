# NetBird.ApiClient.Model.ServiceTargetOptions

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SkipTlsVerify** | **bool** | Skip TLS certificate verification for this backend | [optional] 
**RequestTimeout** | **string** | Per-target response timeout as a Go duration string (e.g. \&quot;30s\&quot;, \&quot;2m\&quot;) | [optional] 
**PathRewrite** | **string** | Controls how the request path is rewritten before forwarding to the backend. Default strips the matched prefix. \&quot;preserve\&quot; keeps the full original request path. | [optional] 
**CustomHeaders** | **Dictionary&lt;string, string&gt;** | Extra headers sent to the backend. Hop-by-hop and proxy-managed headers (Host, Connection, Transfer-Encoding, etc.) are rejected. | [optional] 
**ProxyProtocol** | **bool** | Send PROXY Protocol v2 header to this backend (TCP/TLS only) | [optional] 
**SessionIdleTimeout** | **string** | Idle timeout before a UDP session is reaped, as a Go duration string (e.g. \&quot;30s\&quot;, \&quot;2m\&quot;). Maximum 10m. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

