# NetBird.ApiClient.Api.IngressPortsApi

All URIs are relative to *https://api.netbird.io/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiIngressPeersGet**](IngressPortsApi.md#apiingresspeersget) | **GET** ingress/peers | List all Ingress Peers |
| [**ApiIngressPeersIngressPeerIdDelete**](IngressPortsApi.md#apiingresspeersingresspeeriddelete) | **DELETE** /api/ingress/peers/{ingressPeerId} | Delete a Ingress Peer |
| [**ApiIngressPeersIngressPeerIdGet**](IngressPortsApi.md#apiingresspeersingresspeeridget) | **GET** /api/ingress/peers/{ingressPeerId} | Retrieve a Ingress Peer |
| [**ApiIngressPeersIngressPeerIdPut**](IngressPortsApi.md#apiingresspeersingresspeeridput) | **PUT** /api/ingress/peers/{ingressPeerId} | Update a Ingress Peer |
| [**ApiIngressPeersPost**](IngressPortsApi.md#apiingresspeerspost) | **POST** /api/ingress/peers | Create a Ingress Peer |
| [**ApiPeersPeerIdIngressPortsAllocationIdDelete**](IngressPortsApi.md#apipeerspeeridingressportsallocationiddelete) | **DELETE** /api/peers/{peerId}/ingress/ports/{allocationId} | Delete a Port Allocation |
| [**ApiPeersPeerIdIngressPortsAllocationIdGet**](IngressPortsApi.md#apipeerspeeridingressportsallocationidget) | **GET** /api/peers/{peerId}/ingress/ports/{allocationId} | Retrieve a Port Allocation |
| [**ApiPeersPeerIdIngressPortsAllocationIdPut**](IngressPortsApi.md#apipeerspeeridingressportsallocationidput) | **PUT** /api/peers/{peerId}/ingress/ports/{allocationId} | Update a Port Allocation |
| [**ApiPeersPeerIdIngressPortsGet**](IngressPortsApi.md#apipeerspeeridingressportsget) | **GET** /api/peers/{peerId}/ingress/ports | List all Port Allocations |
| [**ApiPeersPeerIdIngressPortsPost**](IngressPortsApi.md#apipeerspeeridingressportspost) | **POST** /api/peers/{peerId}/ingress/ports | Create a Port Allocation |

<a id="apiingresspeersget"></a>
# **ApiIngressPeersGet**
> List&lt;IngressPeer&gt; ApiIngressPeersGet ()

List all Ingress Peers

Returns a list of all ingress peers

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiIngressPeersGetExample
    {
        public static void Main()
        {
            
            NetBirdApiClientOptions c = new NetBirdApiClientOptions()
            {
                AccessToken = "nbp_XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                BaseUrl = "https://api.netbird.io/api"
            };
            var client = new NetBirdApiClient(c);

            var apiInstance = client.IngressPortsApi;

            try
            {
                // List all Ingress Peers
                List<IngressPeer> result = apiInstance.ApiIngressPeersGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IngressPortsApi.ApiIngressPeersGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiIngressPeersGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List all Ingress Peers
    ApiResponse<List<IngressPeer>> response = apiInstance.ApiIngressPeersGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IngressPortsApi.ApiIngressPeersGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;IngressPeer&gt;**](IngressPeer.md)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A JSON Array of Ingress Peers |  -  |
| **400** | Bad Request |  -  |
| **401** | Requires authentication |  -  |
| **403** | Forbidden |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiingresspeersingresspeeriddelete"></a>
# **ApiIngressPeersIngressPeerIdDelete**
> void ApiIngressPeersIngressPeerIdDelete (string ingressPeerId)

Delete a Ingress Peer

Delete an ingress peer

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiIngressPeersIngressPeerIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.netbird.io";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure Bearer token for authorization: BearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = client.IngressPortsApi;
            var ingressPeerId = "ingressPeerId_example";  // string | The unique identifier of an ingress peer

            try
            {
                // Delete a Ingress Peer
                apiInstance.ApiIngressPeersIngressPeerIdDelete(ingressPeerId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IngressPortsApi.ApiIngressPeersIngressPeerIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiIngressPeersIngressPeerIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a Ingress Peer
    apiInstance.ApiIngressPeersIngressPeerIdDeleteWithHttpInfo(ingressPeerId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IngressPortsApi.ApiIngressPeersIngressPeerIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ingressPeerId** | **string** | The unique identifier of an ingress peer |  |

### Return type

void (empty response body)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Delete status code |  -  |
| **400** | Bad Request |  -  |
| **401** | Requires authentication |  -  |
| **403** | Forbidden |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiingresspeersingresspeeridget"></a>
# **ApiIngressPeersIngressPeerIdGet**
> IngressPeer ApiIngressPeersIngressPeerIdGet (string ingressPeerId)

Retrieve a Ingress Peer

Get information about an ingress peer

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiIngressPeersIngressPeerIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.netbird.io";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure Bearer token for authorization: BearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new IngressPortsApi;
            var ingressPeerId = "ingressPeerId_example";  // string | The unique identifier of an ingress peer

            try
            {
                // Retrieve a Ingress Peer
                IngressPeer result = apiInstance.ApiIngressPeersIngressPeerIdGet(ingressPeerId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IngressPortsApi.ApiIngressPeersIngressPeerIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiIngressPeersIngressPeerIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve a Ingress Peer
    ApiResponse<IngressPeer> response = apiInstance.ApiIngressPeersIngressPeerIdGetWithHttpInfo(ingressPeerId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IngressPortsApi.ApiIngressPeersIngressPeerIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ingressPeerId** | **string** | The unique identifier of an ingress peer |  |

### Return type

[**IngressPeer**](IngressPeer.md)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A Ingress Peer object |  -  |
| **400** | Bad Request |  -  |
| **401** | Requires authentication |  -  |
| **403** | Forbidden |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiingresspeersingresspeeridput"></a>
# **ApiIngressPeersIngressPeerIdPut**
> IngressPeer ApiIngressPeersIngressPeerIdPut (string ingressPeerId, IngressPeerUpdateRequest? ingressPeerUpdateRequest = null)

Update a Ingress Peer

Update information about an ingress peer

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiIngressPeersIngressPeerIdPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.netbird.io";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure Bearer token for authorization: BearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new IngressPortsApi;
            var ingressPeerId = "ingressPeerId_example";  // string | The unique identifier of an ingress peer
            var ingressPeerUpdateRequest = new IngressPeerUpdateRequest?(); // IngressPeerUpdateRequest? | update an ingress peer (optional) 

            try
            {
                // Update a Ingress Peer
                IngressPeer result = apiInstance.ApiIngressPeersIngressPeerIdPut(ingressPeerId, ingressPeerUpdateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IngressPortsApi.ApiIngressPeersIngressPeerIdPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiIngressPeersIngressPeerIdPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a Ingress Peer
    ApiResponse<IngressPeer> response = apiInstance.ApiIngressPeersIngressPeerIdPutWithHttpInfo(ingressPeerId, ingressPeerUpdateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IngressPortsApi.ApiIngressPeersIngressPeerIdPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ingressPeerId** | **string** | The unique identifier of an ingress peer |  |
| **ingressPeerUpdateRequest** | [**IngressPeerUpdateRequest?**](IngressPeerUpdateRequest?.md) | update an ingress peer | [optional]  |

### Return type

[**IngressPeer**](IngressPeer.md)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A Ingress Peer object |  -  |
| **400** | Bad Request |  -  |
| **401** | Requires authentication |  -  |
| **403** | Forbidden |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiingresspeerspost"></a>
# **ApiIngressPeersPost**
> IngressPeer ApiIngressPeersPost (IngressPeerCreateRequest? ingressPeerCreateRequest = null)

Create a Ingress Peer

Creates a new ingress peer

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiIngressPeersPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.netbird.io";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure Bearer token for authorization: BearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new IngressPortsApi;
            var ingressPeerCreateRequest = new IngressPeerCreateRequest?(); // IngressPeerCreateRequest? | New Ingress Peer request (optional) 

            try
            {
                // Create a Ingress Peer
                IngressPeer result = apiInstance.ApiIngressPeersPost(ingressPeerCreateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IngressPortsApi.ApiIngressPeersPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiIngressPeersPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a Ingress Peer
    ApiResponse<IngressPeer> response = apiInstance.ApiIngressPeersPostWithHttpInfo(ingressPeerCreateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IngressPortsApi.ApiIngressPeersPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ingressPeerCreateRequest** | [**IngressPeerCreateRequest?**](IngressPeerCreateRequest?.md) | New Ingress Peer request | [optional]  |

### Return type

[**IngressPeer**](IngressPeer.md)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A Ingress Peer object |  -  |
| **400** | Bad Request |  -  |
| **401** | Requires authentication |  -  |
| **403** | Forbidden |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apipeerspeeridingressportsallocationiddelete"></a>
# **ApiPeersPeerIdIngressPortsAllocationIdDelete**
> void ApiPeersPeerIdIngressPortsAllocationIdDelete (string peerId, string allocationId)

Delete a Port Allocation

Delete an ingress port allocation

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiPeersPeerIdIngressPortsAllocationIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.netbird.io";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure Bearer token for authorization: BearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new IngressPortsApi;
            var peerId = "peerId_example";  // string | The unique identifier of a peer
            var allocationId = "allocationId_example";  // string | The unique identifier of an ingress port allocation

            try
            {
                // Delete a Port Allocation
                apiInstance.ApiPeersPeerIdIngressPortsAllocationIdDelete(peerId, allocationId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IngressPortsApi.ApiPeersPeerIdIngressPortsAllocationIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiPeersPeerIdIngressPortsAllocationIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a Port Allocation
    apiInstance.ApiPeersPeerIdIngressPortsAllocationIdDeleteWithHttpInfo(peerId, allocationId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IngressPortsApi.ApiPeersPeerIdIngressPortsAllocationIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **peerId** | **string** | The unique identifier of a peer |  |
| **allocationId** | **string** | The unique identifier of an ingress port allocation |  |

### Return type

void (empty response body)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Delete status code |  -  |
| **400** | Bad Request |  -  |
| **401** | Requires authentication |  -  |
| **403** | Forbidden |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apipeerspeeridingressportsallocationidget"></a>
# **ApiPeersPeerIdIngressPortsAllocationIdGet**
> IngressPortAllocation ApiPeersPeerIdIngressPortsAllocationIdGet (string peerId, string allocationId)

Retrieve a Port Allocation

Get information about an ingress port allocation

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiPeersPeerIdIngressPortsAllocationIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.netbird.io";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure Bearer token for authorization: BearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new IngressPortsApi;
            var peerId = "peerId_example";  // string | The unique identifier of a peer
            var allocationId = "allocationId_example";  // string | The unique identifier of an ingress port allocation

            try
            {
                // Retrieve a Port Allocation
                IngressPortAllocation result = apiInstance.ApiPeersPeerIdIngressPortsAllocationIdGet(peerId, allocationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IngressPortsApi.ApiPeersPeerIdIngressPortsAllocationIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiPeersPeerIdIngressPortsAllocationIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve a Port Allocation
    ApiResponse<IngressPortAllocation> response = apiInstance.ApiPeersPeerIdIngressPortsAllocationIdGetWithHttpInfo(peerId, allocationId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IngressPortsApi.ApiPeersPeerIdIngressPortsAllocationIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **peerId** | **string** | The unique identifier of a peer |  |
| **allocationId** | **string** | The unique identifier of an ingress port allocation |  |

### Return type

[**IngressPortAllocation**](IngressPortAllocation.md)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A Ingress Port Allocation object |  -  |
| **400** | Bad Request |  -  |
| **401** | Requires authentication |  -  |
| **403** | Forbidden |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apipeerspeeridingressportsallocationidput"></a>
# **ApiPeersPeerIdIngressPortsAllocationIdPut**
> IngressPortAllocation ApiPeersPeerIdIngressPortsAllocationIdPut (string peerId, string allocationId, IngressPortAllocationRequest? ingressPortAllocationRequest = null)

Update a Port Allocation

Update information about an ingress port allocation

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiPeersPeerIdIngressPortsAllocationIdPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.netbird.io";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure Bearer token for authorization: BearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new IngressPortsApi;
            var peerId = "peerId_example";  // string | The unique identifier of a peer
            var allocationId = "allocationId_example";  // string | The unique identifier of an ingress port allocation
            var ingressPortAllocationRequest = new IngressPortAllocationRequest?(); // IngressPortAllocationRequest? | update an ingress port allocation (optional) 

            try
            {
                // Update a Port Allocation
                IngressPortAllocation result = apiInstance.ApiPeersPeerIdIngressPortsAllocationIdPut(peerId, allocationId, ingressPortAllocationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IngressPortsApi.ApiPeersPeerIdIngressPortsAllocationIdPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiPeersPeerIdIngressPortsAllocationIdPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a Port Allocation
    ApiResponse<IngressPortAllocation> response = apiInstance.ApiPeersPeerIdIngressPortsAllocationIdPutWithHttpInfo(peerId, allocationId, ingressPortAllocationRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IngressPortsApi.ApiPeersPeerIdIngressPortsAllocationIdPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **peerId** | **string** | The unique identifier of a peer |  |
| **allocationId** | **string** | The unique identifier of an ingress port allocation |  |
| **ingressPortAllocationRequest** | [**IngressPortAllocationRequest?**](IngressPortAllocationRequest?.md) | update an ingress port allocation | [optional]  |

### Return type

[**IngressPortAllocation**](IngressPortAllocation.md)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A Ingress Port Allocation object |  -  |
| **400** | Bad Request |  -  |
| **401** | Requires authentication |  -  |
| **403** | Forbidden |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apipeerspeeridingressportsget"></a>
# **ApiPeersPeerIdIngressPortsGet**
> List&lt;IngressPortAllocation&gt; ApiPeersPeerIdIngressPortsGet (string peerId, string? name = null)

List all Port Allocations

Returns a list of all ingress port allocations for a peer

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiPeersPeerIdIngressPortsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.netbird.io";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure Bearer token for authorization: BearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new IngressPortsApi;
            var peerId = "peerId_example";  // string | The unique identifier of a peer
            var name = "name_example";  // string? | Filters ingress port allocations by name (optional) 

            try
            {
                // List all Port Allocations
                List<IngressPortAllocation> result = apiInstance.ApiPeersPeerIdIngressPortsGet(peerId, name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IngressPortsApi.ApiPeersPeerIdIngressPortsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiPeersPeerIdIngressPortsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List all Port Allocations
    ApiResponse<List<IngressPortAllocation>> response = apiInstance.ApiPeersPeerIdIngressPortsGetWithHttpInfo(peerId, name);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IngressPortsApi.ApiPeersPeerIdIngressPortsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **peerId** | **string** | The unique identifier of a peer |  |
| **name** | **string?** | Filters ingress port allocations by name | [optional]  |

### Return type

[**List&lt;IngressPortAllocation&gt;**](IngressPortAllocation.md)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A JSON Array of Ingress Port Allocations |  -  |
| **400** | Bad Request |  -  |
| **401** | Requires authentication |  -  |
| **403** | Forbidden |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apipeerspeeridingressportspost"></a>
# **ApiPeersPeerIdIngressPortsPost**
> IngressPortAllocation ApiPeersPeerIdIngressPortsPost (string peerId, IngressPortAllocationRequest? ingressPortAllocationRequest = null)

Create a Port Allocation

Creates a new ingress port allocation for a peer

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiPeersPeerIdIngressPortsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.netbird.io";
            // Configure API key authorization: TokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure Bearer token for authorization: BearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new IngressPortsApi;
            var peerId = "peerId_example";  // string | The unique identifier of a peer
            var ingressPortAllocationRequest = new IngressPortAllocationRequest?(); // IngressPortAllocationRequest? | New Ingress Port Allocation request (optional) 

            try
            {
                // Create a Port Allocation
                IngressPortAllocation result = apiInstance.ApiPeersPeerIdIngressPortsPost(peerId, ingressPortAllocationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IngressPortsApi.ApiPeersPeerIdIngressPortsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiPeersPeerIdIngressPortsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a Port Allocation
    ApiResponse<IngressPortAllocation> response = apiInstance.ApiPeersPeerIdIngressPortsPostWithHttpInfo(peerId, ingressPortAllocationRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IngressPortsApi.ApiPeersPeerIdIngressPortsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **peerId** | **string** | The unique identifier of a peer |  |
| **ingressPortAllocationRequest** | [**IngressPortAllocationRequest?**](IngressPortAllocationRequest?.md) | New Ingress Port Allocation request | [optional]  |

### Return type

[**IngressPortAllocation**](IngressPortAllocation.md)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A Ingress Port Allocation object |  -  |
| **400** | Bad Request |  -  |
| **401** | Requires authentication |  -  |
| **403** | Forbidden |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

