# NetBird.ApiClient.Api.EventsApi

All URIs are relative to *https://api.netbird.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiEventsAuditGet**](EventsApi.md#apieventsauditget) | **GET** events/audit | List all Audit Events |
| [**ApiEventsNetworkTrafficGet**](EventsApi.md#apieventsnetworktrafficget) | **GET** events/network-traffic | List all Traffic Events |
| [**ApiEventsProxyGet**](EventsApi.md#apieventsproxyget) | **GET** /api/events/proxy | List all Reverse Proxy Access Logs |

<a id="apieventsauditget"></a>
# **ApiEventsAuditGet**
> List&lt;Event&gt; ApiEventsAuditGet ()

List all Audit Events

Returns a list of all audit events

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiEventsAuditGetExample
    {
        public static void Main()
        {
            
            NetBirdApiClientOptions c = new NetBirdApiClientOptions()
            {
                AccessToken = "nbp_XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                BaseUrl = "https://api.netbird.io/api"
            };
            var client = new NetBirdApiClient(c);

            var apiInstance = client.EventsApi;

            try
            {
                // List all Audit Events
                List<Event> result = apiInstance.ApiEventsAuditGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventsApi.ApiEventsAuditGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiEventsAuditGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List all Audit Events
    ApiResponse<List<Event>> response = apiInstance.ApiEventsAuditGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EventsApi.ApiEventsAuditGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;Event&gt;**](Event.md)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A JSON Array of Events |  -  |
| **400** | Bad Request |  -  |
| **401** | Requires authentication |  -  |
| **403** | Forbidden |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apieventsnetworktrafficget"></a>
# **ApiEventsNetworkTrafficGet**
> NetworkTrafficEventsResponse ApiEventsNetworkTrafficGet (int? page = null, int? pageSize = null, string? userId = null, string? reporterId = null, int? protocol = null, string? type = null, string? connectionType = null, string? direction = null, string? search = null, DateTimeOffset? startDate = null, DateTimeOffset? endDate = null)

List all Traffic Events

Returns a list of all network traffic events

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiEventsNetworkTrafficGetExample
    {
        public static void Main()
        {
            
            NetBirdApiClientOptions c = new NetBirdApiClientOptions()
            {
                AccessToken = "nbp_XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                BaseUrl = "https://api.netbird.io/api"
            };
            var client = new NetBirdApiClient(c);

            var apiInstance = client.EventsApi;
            var page = 1;  // int? | Page number (optional)  (default to 1)
            var pageSize = 1000;  // int? | Number of items per page (optional)  (default to 1000)
            var userId = "userId_example";  // string? | Filter by user ID (optional) 
            var reporterId = "reporterId_example";  // string? | Filter by reporter ID (optional) 
            var protocol = 56;  // int? | Filter by protocol (optional) 
            var type = "TYPE_UNKNOWN";  // string? | Filter by event type (optional) 
            var connectionType = "P2P";  // string? | Filter by connection type (optional) 
            var direction = "INGRESS";  // string? | Filter by direction (optional) 
            var search = "search_example";  // string? | Case-insensitive partial match on user email, source/destination names, and source/destination addresses (optional) 
            var startDate = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | Start date for filtering events (ISO 8601 format, e.g., 2024-01-01T00:00:00Z). (optional) 
            var endDate = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | End date for filtering events (ISO 8601 format, e.g., 2024-01-31T23:59:59Z). (optional) 

            try
            {
                // List all Traffic Events
                NetworkTrafficEventsResponse result = apiInstance.ApiEventsNetworkTrafficGet(page, pageSize, userId, reporterId, protocol, type, connectionType, direction, search, startDate, endDate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventsApi.ApiEventsNetworkTrafficGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiEventsNetworkTrafficGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List all Traffic Events
    ApiResponse<NetworkTrafficEventsResponse> response = apiInstance.ApiEventsNetworkTrafficGetWithHttpInfo(page, pageSize, userId, reporterId, protocol, type, connectionType, direction, search, startDate, endDate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EventsApi.ApiEventsNetworkTrafficGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int?** | Page number | [optional] [default to 1] |
| **pageSize** | **int?** | Number of items per page | [optional] [default to 1000] |
| **userId** | **string?** | Filter by user ID | [optional]  |
| **reporterId** | **string?** | Filter by reporter ID | [optional]  |
| **protocol** | **int?** | Filter by protocol | [optional]  |
| **type** | **string?** | Filter by event type | [optional]  |
| **connectionType** | **string?** | Filter by connection type | [optional]  |
| **direction** | **string?** | Filter by direction | [optional]  |
| **search** | **string?** | Case-insensitive partial match on user email, source/destination names, and source/destination addresses | [optional]  |
| **startDate** | **DateTimeOffset?** | Start date for filtering events (ISO 8601 format, e.g., 2024-01-01T00:00:00Z). | [optional]  |
| **endDate** | **DateTimeOffset?** | End date for filtering events (ISO 8601 format, e.g., 2024-01-31T23:59:59Z). | [optional]  |

### Return type

[**NetworkTrafficEventsResponse**](NetworkTrafficEventsResponse.md)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of network traffic events |  -  |
| **400** | Bad Request |  -  |
| **401** | Requires authentication |  -  |
| **403** | Forbidden |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apieventsproxyget"></a>
# **ApiEventsProxyGet**
> ProxyAccessLogsResponse ApiEventsProxyGet (int? page = null, int? pageSize = null, string? sortBy = null, string? sortOrder = null, string? search = null, string? sourceIp = null, string? host = null, string? path = null, string? userId = null, string? userEmail = null, string? userName = null, string? method = null, string? status = null, int? statusCode = null, DateTimeOffset? startDate = null, DateTimeOffset? endDate = null)

List all Reverse Proxy Access Logs

Returns a paginated list of all reverse proxy access log entries

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiEventsProxyGetExample
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

            var apiInstance = client.EventsApi;
            var page = 1;  // int? | Page number for pagination (1-indexed) (optional)  (default to 1)
            var pageSize = 50;  // int? | Number of items per page (max 100) (optional)  (default to 50)
            var sortBy = "timestamp";  // string? | Field to sort by (url sorts by host then path) (optional)  (default to timestamp)
            var sortOrder = "asc";  // string? | Sort order (ascending or descending) (optional)  (default to desc)
            var search = "search_example";  // string? | General search across request ID, host, path, source IP, user email, and user name (optional) 
            var sourceIp = "sourceIp_example";  // string? | Filter by source IP address (optional) 
            var host = "host_example";  // string? | Filter by host header (optional) 
            var path = "path_example";  // string? | Filter by request path (supports partial matching) (optional) 
            var userId = "userId_example";  // string? | Filter by authenticated user ID (optional) 
            var userEmail = "userEmail_example";  // string? | Filter by user email (partial matching) (optional) 
            var userName = "userName_example";  // string? | Filter by user name (partial matching) (optional) 
            var method = "GET";  // string? | Filter by HTTP method (optional) 
            var status = "success";  // string? | Filter by status (success = 2xx/3xx, failed = 1xx/4xx/5xx) (optional) 
            var statusCode = 56;  // int? | Filter by HTTP status code (optional) 
            var startDate = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | Filter by timestamp >= start_date (RFC3339 format) (optional) 
            var endDate = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | Filter by timestamp <= end_date (RFC3339 format) (optional) 

            try
            {
                // List all Reverse Proxy Access Logs
                ProxyAccessLogsResponse result = apiInstance.ApiEventsProxyGet(page, pageSize, sortBy, sortOrder, search, sourceIp, host, path, userId, userEmail, userName, method, status, statusCode, startDate, endDate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventsApi.ApiEventsProxyGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiEventsProxyGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List all Reverse Proxy Access Logs
    ApiResponse<ProxyAccessLogsResponse> response = apiInstance.ApiEventsProxyGetWithHttpInfo(page, pageSize, sortBy, sortOrder, search, sourceIp, host, path, userId, userEmail, userName, method, status, statusCode, startDate, endDate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EventsApi.ApiEventsProxyGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int?** | Page number for pagination (1-indexed) | [optional] [default to 1] |
| **pageSize** | **int?** | Number of items per page (max 100) | [optional] [default to 50] |
| **sortBy** | **string?** | Field to sort by (url sorts by host then path) | [optional] [default to timestamp] |
| **sortOrder** | **string?** | Sort order (ascending or descending) | [optional] [default to desc] |
| **search** | **string?** | General search across request ID, host, path, source IP, user email, and user name | [optional]  |
| **sourceIp** | **string?** | Filter by source IP address | [optional]  |
| **host** | **string?** | Filter by host header | [optional]  |
| **path** | **string?** | Filter by request path (supports partial matching) | [optional]  |
| **userId** | **string?** | Filter by authenticated user ID | [optional]  |
| **userEmail** | **string?** | Filter by user email (partial matching) | [optional]  |
| **userName** | **string?** | Filter by user name (partial matching) | [optional]  |
| **method** | **string?** | Filter by HTTP method | [optional]  |
| **status** | **string?** | Filter by status (success &#x3D; 2xx/3xx, failed &#x3D; 1xx/4xx/5xx) | [optional]  |
| **statusCode** | **int?** | Filter by HTTP status code | [optional]  |
| **startDate** | **DateTimeOffset?** | Filter by timestamp &gt;&#x3D; start_date (RFC3339 format) | [optional]  |
| **endDate** | **DateTimeOffset?** | Filter by timestamp &lt;&#x3D; end_date (RFC3339 format) | [optional]  |

### Return type

[**ProxyAccessLogsResponse**](ProxyAccessLogsResponse.md)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Paginated list of reverse proxy access logs |  -  |
| **401** | Requires authentication |  -  |
| **403** | Forbidden |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

