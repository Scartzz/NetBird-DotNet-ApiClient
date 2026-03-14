# NetBird.ApiClient.Api.NetworksApi

All URIs are relative to *https://api.netbird.io/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiNetworksGet**](NetworksApi.md#apinetworksget) | **GET** networks | List all Networks |
| [**ApiNetworksNetworkIdDelete**](NetworksApi.md#apinetworksnetworkiddelete) | **DELETE** /api/networks/{networkId} | Delete a Network |
| [**ApiNetworksNetworkIdGet**](NetworksApi.md#apinetworksnetworkidget) | **GET** /api/networks/{networkId} | Retrieve a Network |
| [**ApiNetworksNetworkIdPut**](NetworksApi.md#apinetworksnetworkidput) | **PUT** /api/networks/{networkId} | Update a Network |
| [**ApiNetworksNetworkIdResourcesGet**](NetworksApi.md#apinetworksnetworkidresourcesget) | **GET** /api/networks/{networkId}/resources | List all Network Resources |
| [**ApiNetworksNetworkIdResourcesPost**](NetworksApi.md#apinetworksnetworkidresourcespost) | **POST** /api/networks/{networkId}/resources | Create a Network Resource |
| [**ApiNetworksNetworkIdResourcesResourceIdDelete**](NetworksApi.md#apinetworksnetworkidresourcesresourceiddelete) | **DELETE** /api/networks/{networkId}/resources/{resourceId} | Delete a Network Resource |
| [**ApiNetworksNetworkIdResourcesResourceIdGet**](NetworksApi.md#apinetworksnetworkidresourcesresourceidget) | **GET** /api/networks/{networkId}/resources/{resourceId} | Retrieve a Network Resource |
| [**ApiNetworksNetworkIdResourcesResourceIdPut**](NetworksApi.md#apinetworksnetworkidresourcesresourceidput) | **PUT** /api/networks/{networkId}/resources/{resourceId} | Update a Network Resource |
| [**ApiNetworksNetworkIdRoutersGet**](NetworksApi.md#apinetworksnetworkidroutersget) | **GET** /api/networks/{networkId}/routers | List all Network Routers |
| [**ApiNetworksNetworkIdRoutersPost**](NetworksApi.md#apinetworksnetworkidrouterspost) | **POST** /api/networks/{networkId}/routers | Create a Network Router |
| [**ApiNetworksNetworkIdRoutersRouterIdDelete**](NetworksApi.md#apinetworksnetworkidroutersrouteriddelete) | **DELETE** /api/networks/{networkId}/routers/{routerId} | Delete a Network Router |
| [**ApiNetworksNetworkIdRoutersRouterIdGet**](NetworksApi.md#apinetworksnetworkidroutersrouteridget) | **GET** /api/networks/{networkId}/routers/{routerId} | Retrieve a Network Router |
| [**ApiNetworksNetworkIdRoutersRouterIdPut**](NetworksApi.md#apinetworksnetworkidroutersrouteridput) | **PUT** /api/networks/{networkId}/routers/{routerId} | Update a Network Router |
| [**ApiNetworksPost**](NetworksApi.md#apinetworkspost) | **POST** /api/networks | Create a Network |
| [**ApiNetworksRoutersGet**](NetworksApi.md#apinetworksroutersget) | **GET** /api/networks/routers | List all Network Routers |

<a id="apinetworksget"></a>
# **ApiNetworksGet**
> List&lt;Network&gt; ApiNetworksGet ()

List all Networks

Returns a list of all networks

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiNetworksGetExample
    {
        public static void Main()
        {
            
            NetBirdApiClientOptions c = new NetBirdApiClientOptions()
            {
                AccessToken = "nbp_XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                BaseUrl = "https://api.netbird.io/api"
            };
            var client = new NetBirdApiClient(c);

            var apiInstance = client.NetworksApi;

            try
            {
                // List all Networks
                List<Network> result = apiInstance.ApiNetworksGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NetworksApi.ApiNetworksGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiNetworksGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List all Networks
    ApiResponse<List<Network>> response = apiInstance.ApiNetworksGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NetworksApi.ApiNetworksGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;Network&gt;**](Network.md)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A JSON Array of Networks |  -  |
| **400** | Bad Request |  -  |
| **401** | Requires authentication |  -  |
| **403** | Forbidden |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apinetworksnetworkiddelete"></a>
# **ApiNetworksNetworkIdDelete**
> void ApiNetworksNetworkIdDelete (string networkId)

Delete a Network

Delete a network

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiNetworksNetworkIdDeleteExample
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

            var apiInstance = client.NetworksApi;
            var networkId = "networkId_example";  // string | The unique identifier of a network

            try
            {
                // Delete a Network
                apiInstance.ApiNetworksNetworkIdDelete(networkId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NetworksApi.ApiNetworksNetworkIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiNetworksNetworkIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a Network
    apiInstance.ApiNetworksNetworkIdDeleteWithHttpInfo(networkId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NetworksApi.ApiNetworksNetworkIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **networkId** | **string** | The unique identifier of a network |  |

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

<a id="apinetworksnetworkidget"></a>
# **ApiNetworksNetworkIdGet**
> Network ApiNetworksNetworkIdGet (string networkId)

Retrieve a Network

Get information about a Network

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiNetworksNetworkIdGetExample
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

            var apiInstance = new NetworksApi;
            var networkId = "networkId_example";  // string | The unique identifier of a network

            try
            {
                // Retrieve a Network
                Network result = apiInstance.ApiNetworksNetworkIdGet(networkId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NetworksApi.ApiNetworksNetworkIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiNetworksNetworkIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve a Network
    ApiResponse<Network> response = apiInstance.ApiNetworksNetworkIdGetWithHttpInfo(networkId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NetworksApi.ApiNetworksNetworkIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **networkId** | **string** | The unique identifier of a network |  |

### Return type

[**Network**](Network.md)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A Network object |  -  |
| **400** | Bad Request |  -  |
| **401** | Requires authentication |  -  |
| **403** | Forbidden |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apinetworksnetworkidput"></a>
# **ApiNetworksNetworkIdPut**
> Network ApiNetworksNetworkIdPut (string networkId, NetworkRequest? networkRequest = null)

Update a Network

Update/Replace a Network

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiNetworksNetworkIdPutExample
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

            var apiInstance = new NetworksApi;
            var networkId = "networkId_example";  // string | The unique identifier of a network
            var networkRequest = new NetworkRequest?(); // NetworkRequest? | Update Network request (optional) 

            try
            {
                // Update a Network
                Network result = apiInstance.ApiNetworksNetworkIdPut(networkId, networkRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NetworksApi.ApiNetworksNetworkIdPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiNetworksNetworkIdPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a Network
    ApiResponse<Network> response = apiInstance.ApiNetworksNetworkIdPutWithHttpInfo(networkId, networkRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NetworksApi.ApiNetworksNetworkIdPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **networkId** | **string** | The unique identifier of a network |  |
| **networkRequest** | [**NetworkRequest?**](NetworkRequest?.md) | Update Network request | [optional]  |

### Return type

[**Network**](Network.md)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A Network object |  -  |
| **400** | Bad Request |  -  |
| **401** | Requires authentication |  -  |
| **403** | Forbidden |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apinetworksnetworkidresourcesget"></a>
# **ApiNetworksNetworkIdResourcesGet**
> List&lt;NetworkResource&gt; ApiNetworksNetworkIdResourcesGet (string networkId)

List all Network Resources

Returns a list of all resources in a network

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiNetworksNetworkIdResourcesGetExample
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

            var apiInstance = new NetworksApi;
            var networkId = "networkId_example";  // string | The unique identifier of a network

            try
            {
                // List all Network Resources
                List<NetworkResource> result = apiInstance.ApiNetworksNetworkIdResourcesGet(networkId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NetworksApi.ApiNetworksNetworkIdResourcesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiNetworksNetworkIdResourcesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List all Network Resources
    ApiResponse<List<NetworkResource>> response = apiInstance.ApiNetworksNetworkIdResourcesGetWithHttpInfo(networkId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NetworksApi.ApiNetworksNetworkIdResourcesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **networkId** | **string** | The unique identifier of a network |  |

### Return type

[**List&lt;NetworkResource&gt;**](NetworkResource.md)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A JSON Array of Resources |  -  |
| **400** | Bad Request |  -  |
| **401** | Requires authentication |  -  |
| **403** | Forbidden |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apinetworksnetworkidresourcespost"></a>
# **ApiNetworksNetworkIdResourcesPost**
> NetworkResource ApiNetworksNetworkIdResourcesPost (string networkId, NetworkResourceRequest? networkResourceRequest = null)

Create a Network Resource

Creates a Network Resource

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiNetworksNetworkIdResourcesPostExample
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

            var apiInstance = new NetworksApi;
            var networkId = "networkId_example";  // string | The unique identifier of a network
            var networkResourceRequest = new NetworkResourceRequest?(); // NetworkResourceRequest? | New Network Resource request (optional) 

            try
            {
                // Create a Network Resource
                NetworkResource result = apiInstance.ApiNetworksNetworkIdResourcesPost(networkId, networkResourceRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NetworksApi.ApiNetworksNetworkIdResourcesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiNetworksNetworkIdResourcesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a Network Resource
    ApiResponse<NetworkResource> response = apiInstance.ApiNetworksNetworkIdResourcesPostWithHttpInfo(networkId, networkResourceRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NetworksApi.ApiNetworksNetworkIdResourcesPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **networkId** | **string** | The unique identifier of a network |  |
| **networkResourceRequest** | [**NetworkResourceRequest?**](NetworkResourceRequest?.md) | New Network Resource request | [optional]  |

### Return type

[**NetworkResource**](NetworkResource.md)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A Network Resource Object |  -  |
| **400** | Bad Request |  -  |
| **401** | Requires authentication |  -  |
| **403** | Forbidden |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apinetworksnetworkidresourcesresourceiddelete"></a>
# **ApiNetworksNetworkIdResourcesResourceIdDelete**
> void ApiNetworksNetworkIdResourcesResourceIdDelete (string networkId, string resourceId)

Delete a Network Resource

Delete a network resource

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiNetworksNetworkIdResourcesResourceIdDeleteExample
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

            var apiInstance = new NetworksApi;
            var networkId = "networkId_example";  // string | 
            var resourceId = "resourceId_example";  // string | 

            try
            {
                // Delete a Network Resource
                apiInstance.ApiNetworksNetworkIdResourcesResourceIdDelete(networkId, resourceId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NetworksApi.ApiNetworksNetworkIdResourcesResourceIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiNetworksNetworkIdResourcesResourceIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a Network Resource
    apiInstance.ApiNetworksNetworkIdResourcesResourceIdDeleteWithHttpInfo(networkId, resourceId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NetworksApi.ApiNetworksNetworkIdResourcesResourceIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **networkId** | **string** |  |  |
| **resourceId** | **string** |  |  |

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

<a id="apinetworksnetworkidresourcesresourceidget"></a>
# **ApiNetworksNetworkIdResourcesResourceIdGet**
> NetworkResource ApiNetworksNetworkIdResourcesResourceIdGet (string networkId, string resourceId)

Retrieve a Network Resource

Get information about a Network Resource

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiNetworksNetworkIdResourcesResourceIdGetExample
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

            var apiInstance = new NetworksApi;
            var networkId = "networkId_example";  // string | The unique identifier of a network
            var resourceId = "resourceId_example";  // string | The unique identifier of a network resource

            try
            {
                // Retrieve a Network Resource
                NetworkResource result = apiInstance.ApiNetworksNetworkIdResourcesResourceIdGet(networkId, resourceId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NetworksApi.ApiNetworksNetworkIdResourcesResourceIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiNetworksNetworkIdResourcesResourceIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve a Network Resource
    ApiResponse<NetworkResource> response = apiInstance.ApiNetworksNetworkIdResourcesResourceIdGetWithHttpInfo(networkId, resourceId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NetworksApi.ApiNetworksNetworkIdResourcesResourceIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **networkId** | **string** | The unique identifier of a network |  |
| **resourceId** | **string** | The unique identifier of a network resource |  |

### Return type

[**NetworkResource**](NetworkResource.md)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A Network Resource object |  -  |
| **400** | Bad Request |  -  |
| **401** | Requires authentication |  -  |
| **403** | Forbidden |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apinetworksnetworkidresourcesresourceidput"></a>
# **ApiNetworksNetworkIdResourcesResourceIdPut**
> NetworkResource ApiNetworksNetworkIdResourcesResourceIdPut (string networkId, string resourceId, NetworkResourceRequest? networkResourceRequest = null)

Update a Network Resource

Update a Network Resource

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiNetworksNetworkIdResourcesResourceIdPutExample
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

            var apiInstance = new NetworksApi;
            var networkId = "networkId_example";  // string | The unique identifier of a network
            var resourceId = "resourceId_example";  // string | The unique identifier of a resource
            var networkResourceRequest = new NetworkResourceRequest?(); // NetworkResourceRequest? | Update Network Resource request (optional) 

            try
            {
                // Update a Network Resource
                NetworkResource result = apiInstance.ApiNetworksNetworkIdResourcesResourceIdPut(networkId, resourceId, networkResourceRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NetworksApi.ApiNetworksNetworkIdResourcesResourceIdPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiNetworksNetworkIdResourcesResourceIdPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a Network Resource
    ApiResponse<NetworkResource> response = apiInstance.ApiNetworksNetworkIdResourcesResourceIdPutWithHttpInfo(networkId, resourceId, networkResourceRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NetworksApi.ApiNetworksNetworkIdResourcesResourceIdPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **networkId** | **string** | The unique identifier of a network |  |
| **resourceId** | **string** | The unique identifier of a resource |  |
| **networkResourceRequest** | [**NetworkResourceRequest?**](NetworkResourceRequest?.md) | Update Network Resource request | [optional]  |

### Return type

[**NetworkResource**](NetworkResource.md)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A Network Resource object |  -  |
| **400** | Bad Request |  -  |
| **401** | Requires authentication |  -  |
| **403** | Forbidden |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apinetworksnetworkidroutersget"></a>
# **ApiNetworksNetworkIdRoutersGet**
> List&lt;NetworkRouter&gt; ApiNetworksNetworkIdRoutersGet (string networkId)

List all Network Routers

Returns a list of all routers in a network

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiNetworksNetworkIdRoutersGetExample
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

            var apiInstance = new NetworksApi;
            var networkId = "networkId_example";  // string | The unique identifier of a network

            try
            {
                // List all Network Routers
                List<NetworkRouter> result = apiInstance.ApiNetworksNetworkIdRoutersGet(networkId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NetworksApi.ApiNetworksNetworkIdRoutersGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiNetworksNetworkIdRoutersGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List all Network Routers
    ApiResponse<List<NetworkRouter>> response = apiInstance.ApiNetworksNetworkIdRoutersGetWithHttpInfo(networkId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NetworksApi.ApiNetworksNetworkIdRoutersGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **networkId** | **string** | The unique identifier of a network |  |

### Return type

[**List&lt;NetworkRouter&gt;**](NetworkRouter.md)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A JSON Array of Routers |  -  |
| **400** | Bad Request |  -  |
| **401** | Requires authentication |  -  |
| **403** | Forbidden |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apinetworksnetworkidrouterspost"></a>
# **ApiNetworksNetworkIdRoutersPost**
> NetworkRouter ApiNetworksNetworkIdRoutersPost (string networkId, NetworkRouterRequest? networkRouterRequest = null)

Create a Network Router

Creates a Network Router

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiNetworksNetworkIdRoutersPostExample
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

            var apiInstance = new NetworksApi;
            var networkId = "networkId_example";  // string | The unique identifier of a network
            var networkRouterRequest = new NetworkRouterRequest?(); // NetworkRouterRequest? | New Network Router request (optional) 

            try
            {
                // Create a Network Router
                NetworkRouter result = apiInstance.ApiNetworksNetworkIdRoutersPost(networkId, networkRouterRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NetworksApi.ApiNetworksNetworkIdRoutersPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiNetworksNetworkIdRoutersPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a Network Router
    ApiResponse<NetworkRouter> response = apiInstance.ApiNetworksNetworkIdRoutersPostWithHttpInfo(networkId, networkRouterRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NetworksApi.ApiNetworksNetworkIdRoutersPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **networkId** | **string** | The unique identifier of a network |  |
| **networkRouterRequest** | [**NetworkRouterRequest?**](NetworkRouterRequest?.md) | New Network Router request | [optional]  |

### Return type

[**NetworkRouter**](NetworkRouter.md)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A Router Object |  -  |
| **400** | Bad Request |  -  |
| **401** | Requires authentication |  -  |
| **403** | Forbidden |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apinetworksnetworkidroutersrouteriddelete"></a>
# **ApiNetworksNetworkIdRoutersRouterIdDelete**
> void ApiNetworksNetworkIdRoutersRouterIdDelete (string networkId, string routerId)

Delete a Network Router

Delete a network router

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiNetworksNetworkIdRoutersRouterIdDeleteExample
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

            var apiInstance = new NetworksApi;
            var networkId = "networkId_example";  // string | 
            var routerId = "routerId_example";  // string | 

            try
            {
                // Delete a Network Router
                apiInstance.ApiNetworksNetworkIdRoutersRouterIdDelete(networkId, routerId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NetworksApi.ApiNetworksNetworkIdRoutersRouterIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiNetworksNetworkIdRoutersRouterIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a Network Router
    apiInstance.ApiNetworksNetworkIdRoutersRouterIdDeleteWithHttpInfo(networkId, routerId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NetworksApi.ApiNetworksNetworkIdRoutersRouterIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **networkId** | **string** |  |  |
| **routerId** | **string** |  |  |

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

<a id="apinetworksnetworkidroutersrouteridget"></a>
# **ApiNetworksNetworkIdRoutersRouterIdGet**
> NetworkRouter ApiNetworksNetworkIdRoutersRouterIdGet (string networkId, string routerId)

Retrieve a Network Router

Get information about a Network Router

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiNetworksNetworkIdRoutersRouterIdGetExample
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

            var apiInstance = new NetworksApi;
            var networkId = "networkId_example";  // string | The unique identifier of a network
            var routerId = "routerId_example";  // string | The unique identifier of a router

            try
            {
                // Retrieve a Network Router
                NetworkRouter result = apiInstance.ApiNetworksNetworkIdRoutersRouterIdGet(networkId, routerId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NetworksApi.ApiNetworksNetworkIdRoutersRouterIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiNetworksNetworkIdRoutersRouterIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve a Network Router
    ApiResponse<NetworkRouter> response = apiInstance.ApiNetworksNetworkIdRoutersRouterIdGetWithHttpInfo(networkId, routerId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NetworksApi.ApiNetworksNetworkIdRoutersRouterIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **networkId** | **string** | The unique identifier of a network |  |
| **routerId** | **string** | The unique identifier of a router |  |

### Return type

[**NetworkRouter**](NetworkRouter.md)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A Router object |  -  |
| **400** | Bad Request |  -  |
| **401** | Requires authentication |  -  |
| **403** | Forbidden |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apinetworksnetworkidroutersrouteridput"></a>
# **ApiNetworksNetworkIdRoutersRouterIdPut**
> NetworkRouter ApiNetworksNetworkIdRoutersRouterIdPut (string networkId, string routerId, NetworkRouterRequest? networkRouterRequest = null)

Update a Network Router

Update a Network Router

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiNetworksNetworkIdRoutersRouterIdPutExample
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

            var apiInstance = new NetworksApi;
            var networkId = "networkId_example";  // string | The unique identifier of a network
            var routerId = "routerId_example";  // string | The unique identifier of a router
            var networkRouterRequest = new NetworkRouterRequest?(); // NetworkRouterRequest? | Update Network Router request (optional) 

            try
            {
                // Update a Network Router
                NetworkRouter result = apiInstance.ApiNetworksNetworkIdRoutersRouterIdPut(networkId, routerId, networkRouterRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NetworksApi.ApiNetworksNetworkIdRoutersRouterIdPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiNetworksNetworkIdRoutersRouterIdPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a Network Router
    ApiResponse<NetworkRouter> response = apiInstance.ApiNetworksNetworkIdRoutersRouterIdPutWithHttpInfo(networkId, routerId, networkRouterRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NetworksApi.ApiNetworksNetworkIdRoutersRouterIdPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **networkId** | **string** | The unique identifier of a network |  |
| **routerId** | **string** | The unique identifier of a router |  |
| **networkRouterRequest** | [**NetworkRouterRequest?**](NetworkRouterRequest?.md) | Update Network Router request | [optional]  |

### Return type

[**NetworkRouter**](NetworkRouter.md)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A Router object |  -  |
| **400** | Bad Request |  -  |
| **401** | Requires authentication |  -  |
| **403** | Forbidden |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apinetworkspost"></a>
# **ApiNetworksPost**
> Network ApiNetworksPost (NetworkRequest? networkRequest = null)

Create a Network

Creates a Network

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiNetworksPostExample
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

            var apiInstance = new NetworksApi;
            var networkRequest = new NetworkRequest?(); // NetworkRequest? | New Network request (optional) 

            try
            {
                // Create a Network
                Network result = apiInstance.ApiNetworksPost(networkRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NetworksApi.ApiNetworksPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiNetworksPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a Network
    ApiResponse<Network> response = apiInstance.ApiNetworksPostWithHttpInfo(networkRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NetworksApi.ApiNetworksPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **networkRequest** | [**NetworkRequest?**](NetworkRequest?.md) | New Network request | [optional]  |

### Return type

[**Network**](Network.md)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A Network Object |  -  |
| **400** | Bad Request |  -  |
| **401** | Requires authentication |  -  |
| **403** | Forbidden |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apinetworksroutersget"></a>
# **ApiNetworksRoutersGet**
> List&lt;NetworkRouter&gt; ApiNetworksRoutersGet ()

List all Network Routers

Returns a list of all routers in a network

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiNetworksRoutersGetExample
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

            var apiInstance = new NetworksApi;

            try
            {
                // List all Network Routers
                List<NetworkRouter> result = apiInstance.ApiNetworksRoutersGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NetworksApi.ApiNetworksRoutersGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiNetworksRoutersGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List all Network Routers
    ApiResponse<List<NetworkRouter>> response = apiInstance.ApiNetworksRoutersGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NetworksApi.ApiNetworksRoutersGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;NetworkRouter&gt;**](NetworkRouter.md)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A JSON Array of Routers |  -  |
| **400** | Bad Request |  -  |
| **401** | Requires authentication |  -  |
| **403** | Forbidden |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

