# NetBird.ApiClient.Api.RoutesApi

All URIs are relative to *https://api.netbird.io/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiRoutesGet**](RoutesApi.md#apiroutesget) | **GET** routes | List all Routes |
| [**ApiRoutesPost**](RoutesApi.md#apiroutespost) | **POST** routes | Create a Route |
| [**ApiRoutesRouteIdDelete**](RoutesApi.md#apiroutesrouteiddelete) | **DELETE** /api/routes/{routeId} | Delete a Route |
| [**ApiRoutesRouteIdGet**](RoutesApi.md#apiroutesrouteidget) | **GET** /api/routes/{routeId} | Retrieve a Route |
| [**ApiRoutesRouteIdPut**](RoutesApi.md#apiroutesrouteidput) | **PUT** /api/routes/{routeId} | Update a Route |

<a id="apiroutesget"></a>
# **ApiRoutesGet**
> List&lt;Route&gt; ApiRoutesGet ()

List all Routes

Returns a list of all routes

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiRoutesGetExample
    {
        public static void Main()
        {
            
            NetBirdApiClientOptions c = new NetBirdApiClientOptions()
            {
                AccessToken = "nbp_XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                BaseUrl = "https://api.netbird.io/api"
            };
            var client = new NetBirdApiClient(c);

            var apiInstance = client.RoutesApi;

            try
            {
                // List all Routes
                List<Route> result = apiInstance.ApiRoutesGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RoutesApi.ApiRoutesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiRoutesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List all Routes
    ApiResponse<List<Route>> response = apiInstance.ApiRoutesGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RoutesApi.ApiRoutesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;Route&gt;**](Route.md)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A JSON Array of Routes |  -  |
| **400** | Bad Request |  -  |
| **401** | Requires authentication |  -  |
| **403** | Forbidden |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiroutespost"></a>
# **ApiRoutesPost**
> Route ApiRoutesPost (RouteRequest? routeRequest = null)

Create a Route

Creates a Route

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiRoutesPostExample
    {
        public static void Main()
        {
            
            NetBirdApiClientOptions c = new NetBirdApiClientOptions()
            {
                AccessToken = "nbp_XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                BaseUrl = "https://api.netbird.io/api"
            };
            var client = new NetBirdApiClient(c);

            var apiInstance = client.RoutesApi;
            var routeRequest = new RouteRequest?(); // RouteRequest? | New Routes request (optional) 

            try
            {
                // Create a Route
                Route result = apiInstance.ApiRoutesPost(routeRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RoutesApi.ApiRoutesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiRoutesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a Route
    ApiResponse<Route> response = apiInstance.ApiRoutesPostWithHttpInfo(routeRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RoutesApi.ApiRoutesPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **routeRequest** | [**RouteRequest?**](RouteRequest?.md) | New Routes request | [optional]  |

### Return type

[**Route**](Route.md)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A Route Object |  -  |
| **400** | Bad Request |  -  |
| **401** | Requires authentication |  -  |
| **403** | Forbidden |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiroutesrouteiddelete"></a>
# **ApiRoutesRouteIdDelete**
> void ApiRoutesRouteIdDelete (string routeId)

Delete a Route

Delete a route

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiRoutesRouteIdDeleteExample
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

            var apiInstance = new RoutesApi;
            var routeId = "routeId_example";  // string | The unique identifier of a route

            try
            {
                // Delete a Route
                apiInstance.ApiRoutesRouteIdDelete(routeId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RoutesApi.ApiRoutesRouteIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiRoutesRouteIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a Route
    apiInstance.ApiRoutesRouteIdDeleteWithHttpInfo(routeId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RoutesApi.ApiRoutesRouteIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **routeId** | **string** | The unique identifier of a route |  |

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

<a id="apiroutesrouteidget"></a>
# **ApiRoutesRouteIdGet**
> Route ApiRoutesRouteIdGet (string routeId)

Retrieve a Route

Get information about a Routes

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiRoutesRouteIdGetExample
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

            var apiInstance = new RoutesApi;
            var routeId = "routeId_example";  // string | The unique identifier of a route

            try
            {
                // Retrieve a Route
                Route result = apiInstance.ApiRoutesRouteIdGet(routeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RoutesApi.ApiRoutesRouteIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiRoutesRouteIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve a Route
    ApiResponse<Route> response = apiInstance.ApiRoutesRouteIdGetWithHttpInfo(routeId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RoutesApi.ApiRoutesRouteIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **routeId** | **string** | The unique identifier of a route |  |

### Return type

[**Route**](Route.md)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A Route object |  -  |
| **400** | Bad Request |  -  |
| **401** | Requires authentication |  -  |
| **403** | Forbidden |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiroutesrouteidput"></a>
# **ApiRoutesRouteIdPut**
> Route ApiRoutesRouteIdPut (string routeId, RouteRequest? routeRequest = null)

Update a Route

Update/Replace a Route

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiRoutesRouteIdPutExample
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

            var apiInstance = new RoutesApi;
            var routeId = "routeId_example";  // string | The unique identifier of a route
            var routeRequest = new RouteRequest?(); // RouteRequest? | Update Route request (optional) 

            try
            {
                // Update a Route
                Route result = apiInstance.ApiRoutesRouteIdPut(routeId, routeRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RoutesApi.ApiRoutesRouteIdPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiRoutesRouteIdPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a Route
    ApiResponse<Route> response = apiInstance.ApiRoutesRouteIdPutWithHttpInfo(routeId, routeRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RoutesApi.ApiRoutesRouteIdPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **routeId** | **string** | The unique identifier of a route |  |
| **routeRequest** | [**RouteRequest?**](RouteRequest?.md) | Update Route request | [optional]  |

### Return type

[**Route**](Route.md)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A Route object |  -  |
| **400** | Bad Request |  -  |
| **401** | Requires authentication |  -  |
| **403** | Forbidden |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

