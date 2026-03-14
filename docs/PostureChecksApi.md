# NetBird.ApiClient.Api.PostureChecksApi

All URIs are relative to *https://api.netbird.io/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiPostureChecksGet**](PostureChecksApi.md#apiposturechecksget) | **GET** posture-checks | List all Posture Checks |
| [**ApiPostureChecksPost**](PostureChecksApi.md#apiposturecheckspost) | **POST** posture-checks | Create a Posture Check |
| [**ApiPostureChecksPostureCheckIdDelete**](PostureChecksApi.md#apiposturechecksposturecheckiddelete) | **DELETE** /api/posture-checks/{postureCheckId} | Delete a Posture Check |
| [**ApiPostureChecksPostureCheckIdGet**](PostureChecksApi.md#apiposturechecksposturecheckidget) | **GET** /api/posture-checks/{postureCheckId} | Retrieve a Posture Check |
| [**ApiPostureChecksPostureCheckIdPut**](PostureChecksApi.md#apiposturechecksposturecheckidput) | **PUT** /api/posture-checks/{postureCheckId} | Update a Posture Check |

<a id="apiposturechecksget"></a>
# **ApiPostureChecksGet**
> List&lt;PostureCheck&gt; ApiPostureChecksGet ()

List all Posture Checks

Returns a list of all posture checks

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiPostureChecksGetExample
    {
        public static void Main()
        {
            
            NetBirdApiClientOptions c = new NetBirdApiClientOptions()
            {
                AccessToken = "nbp_XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                BaseUrl = "https://api.netbird.io/api"
            };
            var client = new NetBirdApiClient(c);

            var apiInstance = client.PostureChecksApi;

            try
            {
                // List all Posture Checks
                List<PostureCheck> result = apiInstance.ApiPostureChecksGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PostureChecksApi.ApiPostureChecksGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiPostureChecksGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List all Posture Checks
    ApiResponse<List<PostureCheck>> response = apiInstance.ApiPostureChecksGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PostureChecksApi.ApiPostureChecksGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;PostureCheck&gt;**](PostureCheck.md)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A JSON Array of posture checks |  -  |
| **400** | Bad Request |  -  |
| **401** | Requires authentication |  -  |
| **403** | Forbidden |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiposturecheckspost"></a>
# **ApiPostureChecksPost**
> PostureCheck ApiPostureChecksPost (PostureCheckUpdate? postureCheckUpdate = null)

Create a Posture Check

Creates a posture check

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiPostureChecksPostExample
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

            var apiInstance = client.PostureChecksApi;
            var postureCheckUpdate = new PostureCheckUpdate?(); // PostureCheckUpdate? | New posture check request (optional) 

            try
            {
                // Create a Posture Check
                PostureCheck result = apiInstance.ApiPostureChecksPost(postureCheckUpdate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PostureChecksApi.ApiPostureChecksPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiPostureChecksPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a Posture Check
    ApiResponse<PostureCheck> response = apiInstance.ApiPostureChecksPostWithHttpInfo(postureCheckUpdate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PostureChecksApi.ApiPostureChecksPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **postureCheckUpdate** | [**PostureCheckUpdate?**](PostureCheckUpdate?.md) | New posture check request | [optional]  |

### Return type

[**PostureCheck**](PostureCheck.md)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A posture check Object |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiposturechecksposturecheckiddelete"></a>
# **ApiPostureChecksPostureCheckIdDelete**
> void ApiPostureChecksPostureCheckIdDelete (string postureCheckId)

Delete a Posture Check

Delete a posture check

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiPostureChecksPostureCheckIdDeleteExample
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

            var apiInstance = client.PostureChecksApi;
            var postureCheckId = "postureCheckId_example";  // string | The unique identifier of a posture check

            try
            {
                // Delete a Posture Check
                apiInstance.ApiPostureChecksPostureCheckIdDelete(postureCheckId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PostureChecksApi.ApiPostureChecksPostureCheckIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiPostureChecksPostureCheckIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a Posture Check
    apiInstance.ApiPostureChecksPostureCheckIdDeleteWithHttpInfo(postureCheckId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PostureChecksApi.ApiPostureChecksPostureCheckIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **postureCheckId** | **string** | The unique identifier of a posture check |  |

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

<a id="apiposturechecksposturecheckidget"></a>
# **ApiPostureChecksPostureCheckIdGet**
> PostureCheck ApiPostureChecksPostureCheckIdGet (string postureCheckId)

Retrieve a Posture Check

Get information about a posture check

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiPostureChecksPostureCheckIdGetExample
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

            var apiInstance = new PostureChecksApi;
            var postureCheckId = "postureCheckId_example";  // string | The unique identifier of a posture check

            try
            {
                // Retrieve a Posture Check
                PostureCheck result = apiInstance.ApiPostureChecksPostureCheckIdGet(postureCheckId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PostureChecksApi.ApiPostureChecksPostureCheckIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiPostureChecksPostureCheckIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve a Posture Check
    ApiResponse<PostureCheck> response = apiInstance.ApiPostureChecksPostureCheckIdGetWithHttpInfo(postureCheckId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PostureChecksApi.ApiPostureChecksPostureCheckIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **postureCheckId** | **string** | The unique identifier of a posture check |  |

### Return type

[**PostureCheck**](PostureCheck.md)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A posture check object |  -  |
| **400** | Bad Request |  -  |
| **401** | Requires authentication |  -  |
| **403** | Forbidden |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiposturechecksposturecheckidput"></a>
# **ApiPostureChecksPostureCheckIdPut**
> PostureCheck ApiPostureChecksPostureCheckIdPut (string postureCheckId, PostureCheckUpdate? postureCheckUpdate = null)

Update a Posture Check

Update/Replace a posture check

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiPostureChecksPostureCheckIdPutExample
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

            var apiInstance = new PostureChecksApi;
            var postureCheckId = "postureCheckId_example";  // string | The unique identifier of a posture check
            var postureCheckUpdate = new PostureCheckUpdate?(); // PostureCheckUpdate? | Update Rule request (optional) 

            try
            {
                // Update a Posture Check
                PostureCheck result = apiInstance.ApiPostureChecksPostureCheckIdPut(postureCheckId, postureCheckUpdate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PostureChecksApi.ApiPostureChecksPostureCheckIdPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiPostureChecksPostureCheckIdPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a Posture Check
    ApiResponse<PostureCheck> response = apiInstance.ApiPostureChecksPostureCheckIdPutWithHttpInfo(postureCheckId, postureCheckUpdate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PostureChecksApi.ApiPostureChecksPostureCheckIdPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **postureCheckId** | **string** | The unique identifier of a posture check |  |
| **postureCheckUpdate** | [**PostureCheckUpdate?**](PostureCheckUpdate?.md) | Update Rule request | [optional]  |

### Return type

[**PostureCheck**](PostureCheck.md)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A posture check object |  -  |
| **400** | Bad Request |  -  |
| **401** | Requires authentication |  -  |
| **403** | Forbidden |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

