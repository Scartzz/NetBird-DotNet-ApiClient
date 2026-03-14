# NetBird.ApiClient.Api.SetupKeysApi

All URIs are relative to *https://api.netbird.io/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiSetupKeysGet**](SetupKeysApi.md#apisetupkeysget) | **GET** setup-keys | List all Setup Keys |
| [**ApiSetupKeysKeyIdDelete**](SetupKeysApi.md#apisetupkeyskeyiddelete) | **DELETE** setup-keys/{keyId} | Delete a Setup Key |
| [**ApiSetupKeysKeyIdGet**](SetupKeysApi.md#apisetupkeyskeyidget) | **GET** /api/setup-keys/{keyId} | Retrieve a Setup Key |
| [**ApiSetupKeysKeyIdPut**](SetupKeysApi.md#apisetupkeyskeyidput) | **PUT** /api/setup-keys/{keyId} | Update a Setup Key |
| [**ApiSetupKeysPost**](SetupKeysApi.md#apisetupkeyspost) | **POST** /api/setup-keys | Create a Setup Key |

<a id="apisetupkeysget"></a>
# **ApiSetupKeysGet**
> List&lt;SetupKey&gt; ApiSetupKeysGet ()

List all Setup Keys

Returns a list of all Setup Keys

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiSetupKeysGetExample
    {
        public static void Main()
        {
            
            NetBirdApiClientOptions c = new NetBirdApiClientOptions()
            {
                AccessToken = "nbp_XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                BaseUrl = "https://api.netbird.io/api"
            };
            var client = new NetBirdApiClient(c);

            var apiInstance = client.SetupKeysApi;

            try
            {
                // List all Setup Keys
                List<SetupKey> result = apiInstance.ApiSetupKeysGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SetupKeysApi.ApiSetupKeysGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiSetupKeysGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List all Setup Keys
    ApiResponse<List<SetupKey>> response = apiInstance.ApiSetupKeysGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SetupKeysApi.ApiSetupKeysGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;SetupKey&gt;**](SetupKey.md)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A JSON Array of Setup keys |  -  |
| **400** | Bad Request |  -  |
| **401** | Requires authentication |  -  |
| **403** | Forbidden |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apisetupkeyskeyiddelete"></a>
# **ApiSetupKeysKeyIdDelete**
> void ApiSetupKeysKeyIdDelete (string keyId)

Delete a Setup Key

Delete a Setup Key

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiSetupKeysKeyIdDeleteExample
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

            var apiInstance = client.SetupKeysApi;
            var keyId = "keyId_example";  // string | The unique identifier of a setup key

            try
            {
                // Delete a Setup Key
                apiInstance.ApiSetupKeysKeyIdDelete(keyId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SetupKeysApi.ApiSetupKeysKeyIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiSetupKeysKeyIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a Setup Key
    apiInstance.ApiSetupKeysKeyIdDeleteWithHttpInfo(keyId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SetupKeysApi.ApiSetupKeysKeyIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **keyId** | **string** | The unique identifier of a setup key |  |

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

<a id="apisetupkeyskeyidget"></a>
# **ApiSetupKeysKeyIdGet**
> SetupKey ApiSetupKeysKeyIdGet (string keyId)

Retrieve a Setup Key

Get information about a setup key

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiSetupKeysKeyIdGetExample
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

            var apiInstance = client.SetupKeysApi;
            var keyId = "keyId_example";  // string | The unique identifier of a setup key

            try
            {
                // Retrieve a Setup Key
                SetupKey result = apiInstance.ApiSetupKeysKeyIdGet(keyId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SetupKeysApi.ApiSetupKeysKeyIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiSetupKeysKeyIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve a Setup Key
    ApiResponse<SetupKey> response = apiInstance.ApiSetupKeysKeyIdGetWithHttpInfo(keyId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SetupKeysApi.ApiSetupKeysKeyIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **keyId** | **string** | The unique identifier of a setup key |  |

### Return type

[**SetupKey**](SetupKey.md)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A Setup Key object |  -  |
| **400** | Bad Request |  -  |
| **401** | Requires authentication |  -  |
| **403** | Forbidden |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apisetupkeyskeyidput"></a>
# **ApiSetupKeysKeyIdPut**
> SetupKey ApiSetupKeysKeyIdPut (string keyId, SetupKeyRequest? setupKeyRequest = null)

Update a Setup Key

Update information about a setup key

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiSetupKeysKeyIdPutExample
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

            var apiInstance = new SetupKeysApi;
            var keyId = "keyId_example";  // string | The unique identifier of a setup key
            var setupKeyRequest = new SetupKeyRequest?(); // SetupKeyRequest? | update to Setup Key (optional) 

            try
            {
                // Update a Setup Key
                SetupKey result = apiInstance.ApiSetupKeysKeyIdPut(keyId, setupKeyRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SetupKeysApi.ApiSetupKeysKeyIdPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiSetupKeysKeyIdPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a Setup Key
    ApiResponse<SetupKey> response = apiInstance.ApiSetupKeysKeyIdPutWithHttpInfo(keyId, setupKeyRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SetupKeysApi.ApiSetupKeysKeyIdPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **keyId** | **string** | The unique identifier of a setup key |  |
| **setupKeyRequest** | [**SetupKeyRequest?**](SetupKeyRequest?.md) | update to Setup Key | [optional]  |

### Return type

[**SetupKey**](SetupKey.md)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A Setup Key object |  -  |
| **400** | Bad Request |  -  |
| **401** | Requires authentication |  -  |
| **403** | Forbidden |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apisetupkeyspost"></a>
# **ApiSetupKeysPost**
> SetupKeyClear ApiSetupKeysPost (CreateSetupKeyRequest? createSetupKeyRequest = null)

Create a Setup Key

Creates a setup key

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiSetupKeysPostExample
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

            var apiInstance = new SetupKeysApi;
            var createSetupKeyRequest = new CreateSetupKeyRequest?(); // CreateSetupKeyRequest? | New Setup Key request (optional) 

            try
            {
                // Create a Setup Key
                SetupKeyClear result = apiInstance.ApiSetupKeysPost(createSetupKeyRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SetupKeysApi.ApiSetupKeysPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiSetupKeysPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a Setup Key
    ApiResponse<SetupKeyClear> response = apiInstance.ApiSetupKeysPostWithHttpInfo(createSetupKeyRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SetupKeysApi.ApiSetupKeysPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createSetupKeyRequest** | [**CreateSetupKeyRequest?**](CreateSetupKeyRequest?.md) | New Setup Key request | [optional]  |

### Return type

[**SetupKeyClear**](SetupKeyClear.md)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A Setup Keys Object |  -  |
| **400** | Bad Request |  -  |
| **401** | Requires authentication |  -  |
| **403** | Forbidden |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

