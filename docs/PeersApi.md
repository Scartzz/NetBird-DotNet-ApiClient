# NetBird.ApiClient.Api.PeersApi

All URIs are relative to *https://api.netbird.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiPeersGet**](PeersApi.md#apipeersget) | **GET** peers | List all Peers |
| [**ApiPeersPeerIdAccessiblePeersGet**](PeersApi.md#apipeerspeeridaccessiblepeersget) | **GET** peers/{peerId}/accessible-peers | List accessible Peers |
| [**ApiPeersPeerIdDelete**](PeersApi.md#apipeerspeeriddelete) | **DELETE** /api/peers/{peerId} | Delete a Peer |
| [**ApiPeersPeerIdGet**](PeersApi.md#apipeerspeeridget) | **GET** /api/peers/{peerId} | Retrieve a Peer |
| [**ApiPeersPeerIdPut**](PeersApi.md#apipeerspeeridput) | **PUT** /api/peers/{peerId} | Update a Peer |
| [**ApiPeersPeerIdTemporaryAccessPost**](PeersApi.md#apipeerspeeridtemporaryaccesspost) | **POST** /api/peers/{peerId}/temporary-access | Create a Temporary Access Peer |

<a id="apipeersget"></a>
# **ApiPeersGet**
> List&lt;PeerBatch&gt; ApiPeersGet (string? name = null, string? ip = null)

List all Peers

Returns a list of all peers

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiPeersGetExample
    {
        public static void Main()
        {
            
            NetBirdApiClientOptions c = new NetBirdApiClientOptions()
            {
                AccessToken = "nbp_XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                BaseUrl = "https://api.netbird.io/api"
            };
            var client = new NetBirdApiClient(c);

            var apiInstance = client.PeersApi;
            var name = "name_example";  // string? | Filter peers by name (optional) 
            var ip = "ip_example";  // string? | Filter peers by IP address (optional) 

            try
            {
                // List all Peers
                List<PeerBatch> result = apiInstance.ApiPeersGet(name, ip);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PeersApi.ApiPeersGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiPeersGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List all Peers
    ApiResponse<List<PeerBatch>> response = apiInstance.ApiPeersGetWithHttpInfo(name, ip);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PeersApi.ApiPeersGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string?** | Filter peers by name | [optional]  |
| **ip** | **string?** | Filter peers by IP address | [optional]  |

### Return type

[**List&lt;PeerBatch&gt;**](PeerBatch.md)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A JSON Array of Peers |  -  |
| **400** | Bad Request |  -  |
| **401** | Requires authentication |  -  |
| **403** | Forbidden |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apipeerspeeridaccessiblepeersget"></a>
# **ApiPeersPeerIdAccessiblePeersGet**
> List&lt;AccessiblePeer&gt; ApiPeersPeerIdAccessiblePeersGet (string peerId)

List accessible Peers

Returns a list of peers that the specified peer can connect to within the network.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiPeersPeerIdAccessiblePeersGetExample
    {
        public static void Main()
        {
            
            NetBirdApiClientOptions c = new NetBirdApiClientOptions()
            {
                AccessToken = "nbp_XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                BaseUrl = "https://api.netbird.io/api"
            };
            var client = new NetBirdApiClient(c);

            var apiInstance = client.PeersApi;
            var peerId = "peerId_example";  // string | The unique identifier of a peer

            try
            {
                // List accessible Peers
                List<AccessiblePeer> result = apiInstance.ApiPeersPeerIdAccessiblePeersGet(peerId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PeersApi.ApiPeersPeerIdAccessiblePeersGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiPeersPeerIdAccessiblePeersGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List accessible Peers
    ApiResponse<List<AccessiblePeer>> response = apiInstance.ApiPeersPeerIdAccessiblePeersGetWithHttpInfo(peerId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PeersApi.ApiPeersPeerIdAccessiblePeersGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **peerId** | **string** | The unique identifier of a peer |  |

### Return type

[**List&lt;AccessiblePeer&gt;**](AccessiblePeer.md)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A JSON Array of Accessible Peers |  -  |
| **400** | Bad Request |  -  |
| **401** | Requires authentication |  -  |
| **403** | Forbidden |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apipeerspeeriddelete"></a>
# **ApiPeersPeerIdDelete**
> void ApiPeersPeerIdDelete (string peerId)

Delete a Peer

Delete a peer

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiPeersPeerIdDeleteExample
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

            var apiInstance = new PeersApi;
            var peerId = "peerId_example";  // string | The unique identifier of a peer

            try
            {
                // Delete a Peer
                apiInstance.ApiPeersPeerIdDelete(peerId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PeersApi.ApiPeersPeerIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiPeersPeerIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a Peer
    apiInstance.ApiPeersPeerIdDeleteWithHttpInfo(peerId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PeersApi.ApiPeersPeerIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **peerId** | **string** | The unique identifier of a peer |  |

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

<a id="apipeerspeeridget"></a>
# **ApiPeersPeerIdGet**
> Peer ApiPeersPeerIdGet (string peerId)

Retrieve a Peer

Get information about a peer

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiPeersPeerIdGetExample
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

            var apiInstance = new PeersApi;
            var peerId = "peerId_example";  // string | The unique identifier of a peer

            try
            {
                // Retrieve a Peer
                Peer result = apiInstance.ApiPeersPeerIdGet(peerId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PeersApi.ApiPeersPeerIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiPeersPeerIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve a Peer
    ApiResponse<Peer> response = apiInstance.ApiPeersPeerIdGetWithHttpInfo(peerId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PeersApi.ApiPeersPeerIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **peerId** | **string** | The unique identifier of a peer |  |

### Return type

[**Peer**](Peer.md)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A Peer object |  -  |
| **400** | Bad Request |  -  |
| **401** | Requires authentication |  -  |
| **403** | Forbidden |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apipeerspeeridput"></a>
# **ApiPeersPeerIdPut**
> Peer ApiPeersPeerIdPut (string peerId, PeerRequest? peerRequest = null)

Update a Peer

Update information about a peer

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiPeersPeerIdPutExample
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

            var apiInstance = new PeersApi;
            var peerId = "peerId_example";  // string | The unique identifier of a peer
            var peerRequest = new PeerRequest?(); // PeerRequest? | update a peer (optional) 

            try
            {
                // Update a Peer
                Peer result = apiInstance.ApiPeersPeerIdPut(peerId, peerRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PeersApi.ApiPeersPeerIdPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiPeersPeerIdPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a Peer
    ApiResponse<Peer> response = apiInstance.ApiPeersPeerIdPutWithHttpInfo(peerId, peerRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PeersApi.ApiPeersPeerIdPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **peerId** | **string** | The unique identifier of a peer |  |
| **peerRequest** | [**PeerRequest?**](PeerRequest?.md) | update a peer | [optional]  |

### Return type

[**Peer**](Peer.md)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A Peer object |  -  |
| **400** | Bad Request |  -  |
| **401** | Requires authentication |  -  |
| **403** | Forbidden |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apipeerspeeridtemporaryaccesspost"></a>
# **ApiPeersPeerIdTemporaryAccessPost**
> PeerTemporaryAccessResponse ApiPeersPeerIdTemporaryAccessPost (string peerId, PeerTemporaryAccessRequest? peerTemporaryAccessRequest = null)

Create a Temporary Access Peer

Creates a temporary access peer that can be used to access this peer and this peer only. The temporary access peer and its access policies will be automatically deleted after it disconnects.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiPeersPeerIdTemporaryAccessPostExample
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

            var apiInstance = new PeersApi;
            var peerId = "peerId_example";  // string | The unique identifier of a peer
            var peerTemporaryAccessRequest = new PeerTemporaryAccessRequest?(); // PeerTemporaryAccessRequest? | Temporary Access Peer create request (optional) 

            try
            {
                // Create a Temporary Access Peer
                PeerTemporaryAccessResponse result = apiInstance.ApiPeersPeerIdTemporaryAccessPost(peerId, peerTemporaryAccessRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PeersApi.ApiPeersPeerIdTemporaryAccessPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiPeersPeerIdTemporaryAccessPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a Temporary Access Peer
    ApiResponse<PeerTemporaryAccessResponse> response = apiInstance.ApiPeersPeerIdTemporaryAccessPostWithHttpInfo(peerId, peerTemporaryAccessRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PeersApi.ApiPeersPeerIdTemporaryAccessPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **peerId** | **string** | The unique identifier of a peer |  |
| **peerTemporaryAccessRequest** | [**PeerTemporaryAccessRequest?**](PeerTemporaryAccessRequest?.md) | Temporary Access Peer create request | [optional]  |

### Return type

[**PeerTemporaryAccessResponse**](PeerTemporaryAccessResponse.md)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Temporary Access Peer response |  -  |
| **400** | Bad Request |  -  |
| **401** | Requires authentication |  -  |
| **403** | Forbidden |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

