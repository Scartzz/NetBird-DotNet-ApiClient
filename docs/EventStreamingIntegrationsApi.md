# NetBird.ApiClient.Api.EventStreamingIntegrationsApi

All URIs are relative to *https://api.netbird.io/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateIntegration**](EventStreamingIntegrationsApi.md#createintegration) | **POST** event-streaming | Create Event Streaming Integration |
| [**DeleteIntegration**](EventStreamingIntegrationsApi.md#deleteintegration) | **DELETE** /api/event-streaming/{id} | Delete Event Streaming Integration |
| [**GetAllIntegrations**](EventStreamingIntegrationsApi.md#getallintegrations) | **GET** /api/event-streaming | List Event Streaming Integrations |
| [**GetIntegration**](EventStreamingIntegrationsApi.md#getintegration) | **GET** /api/event-streaming/{id} | Get Event Streaming Integration |
| [**UpdateIntegration**](EventStreamingIntegrationsApi.md#updateintegration) | **PUT** /api/event-streaming/{id} | Update Event Streaming Integration |

<a id="createintegration"></a>
# **CreateIntegration**
> IntegrationResponse CreateIntegration (CreateIntegrationRequest createIntegrationRequest)

Create Event Streaming Integration

Creates a new event streaming integration for the authenticated account. The request body should conform to `CreateIntegrationRequest`. Note: Based on the provided Go code, the `enabled` field from the request is part of the `CreateIntegrationRequest` struct, but the backend `manager.CreateIntegration` function signature shown does not directly use this `enabled` field. The actual behavior for `enabled` during creation should be confirmed (e.g., it might have a server-side default or be handled by other logic). 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class CreateIntegrationExample
    {
        public static void Main()
        {
            
            NetBirdApiClientOptions c = new NetBirdApiClientOptions()
            {
                AccessToken = "nbp_XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                BaseUrl = "https://api.netbird.io/api"
            };
            var client = new NetBirdApiClient(c);

            var apiInstance = client.EventStreamingIntegrationsApi;
            var createIntegrationRequest = new CreateIntegrationRequest(); // CreateIntegrationRequest | 

            try
            {
                // Create Event Streaming Integration
                IntegrationResponse result = apiInstance.CreateIntegration(createIntegrationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventStreamingIntegrationsApi.CreateIntegration: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateIntegrationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Event Streaming Integration
    ApiResponse<IntegrationResponse> response = apiInstance.CreateIntegrationWithHttpInfo(createIntegrationRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EventStreamingIntegrationsApi.CreateIntegrationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createIntegrationRequest** | [**CreateIntegrationRequest**](CreateIntegrationRequest.md) |  |  |

### Return type

[**IntegrationResponse**](IntegrationResponse.md)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Integration created successfully. Returns the created integration. |  -  |
| **400** | Bad Request (e.g., invalid JSON, missing required fields, validation error). |  -  |
| **401** | Unauthorized (e.g., missing or invalid authentication token). |  -  |
| **500** | Internal Server Error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteintegration"></a>
# **DeleteIntegration**
> Object DeleteIntegration (int id)

Delete Event Streaming Integration

Deletes an event streaming integration by its ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class DeleteIntegrationExample
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

            var apiInstance = new EventStreamingIntegrationsApi;
            var id = 123;  // int | The unique numeric identifier of the event streaming integration.

            try
            {
                // Delete Event Streaming Integration
                Object result = apiInstance.DeleteIntegration(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventStreamingIntegrationsApi.DeleteIntegration: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteIntegrationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Event Streaming Integration
    ApiResponse<Object> response = apiInstance.DeleteIntegrationWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EventStreamingIntegrationsApi.DeleteIntegrationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | The unique numeric identifier of the event streaming integration. |  |

### Return type

**Object**

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Integration deleted successfully. Returns an empty object. |  -  |
| **400** | Bad Request (e.g., invalid integration ID format). |  -  |
| **401** | Unauthorized. |  -  |
| **404** | Not Found. |  -  |
| **500** | Internal Server Error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getallintegrations"></a>
# **GetAllIntegrations**
> List&lt;IntegrationResponse&gt; GetAllIntegrations ()

List Event Streaming Integrations

Retrieves all event streaming integrations for the authenticated account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class GetAllIntegrationsExample
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

            var apiInstance = new EventStreamingIntegrationsApi;

            try
            {
                // List Event Streaming Integrations
                List<IntegrationResponse> result = apiInstance.GetAllIntegrations();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventStreamingIntegrationsApi.GetAllIntegrations: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAllIntegrationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Event Streaming Integrations
    ApiResponse<List<IntegrationResponse>> response = apiInstance.GetAllIntegrationsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EventStreamingIntegrationsApi.GetAllIntegrationsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;IntegrationResponse&gt;**](IntegrationResponse.md)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A list of event streaming integrations. |  -  |
| **401** | Unauthorized. |  -  |
| **500** | Internal Server Error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getintegration"></a>
# **GetIntegration**
> IntegrationResponse GetIntegration (int id)

Get Event Streaming Integration

Retrieves a specific event streaming integration by its ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class GetIntegrationExample
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

            var apiInstance = new EventStreamingIntegrationsApi;
            var id = 123;  // int | The unique numeric identifier of the event streaming integration.

            try
            {
                // Get Event Streaming Integration
                IntegrationResponse result = apiInstance.GetIntegration(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventStreamingIntegrationsApi.GetIntegration: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetIntegrationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Event Streaming Integration
    ApiResponse<IntegrationResponse> response = apiInstance.GetIntegrationWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EventStreamingIntegrationsApi.GetIntegrationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | The unique numeric identifier of the event streaming integration. |  |

### Return type

[**IntegrationResponse**](IntegrationResponse.md)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved the integration details. Config keys are masked. |  -  |
| **400** | Bad Request (e.g., invalid integration ID format). |  -  |
| **401** | Unauthorized. |  -  |
| **404** | Not Found (e.g., integration with the given ID does not exist). |  -  |
| **500** | Internal Server Error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updateintegration"></a>
# **UpdateIntegration**
> IntegrationResponse UpdateIntegration (int id, CreateIntegrationRequest createIntegrationRequest)

Update Event Streaming Integration

Updates an existing event streaming integration. The request body structure is `CreateIntegrationRequest`. However, for updates: - The `platform` field, if provided in the body, is ignored by the backend manager function, as the platform of an existing integration is typically immutable. - The `enabled` and `config` fields from the request body are used to update the integration. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class UpdateIntegrationExample
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

            var apiInstance = new EventStreamingIntegrationsApi;
            var id = 123;  // int | The unique numeric identifier of the event streaming integration.
            var createIntegrationRequest = new CreateIntegrationRequest(); // CreateIntegrationRequest | 

            try
            {
                // Update Event Streaming Integration
                IntegrationResponse result = apiInstance.UpdateIntegration(id, createIntegrationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventStreamingIntegrationsApi.UpdateIntegration: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateIntegrationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Event Streaming Integration
    ApiResponse<IntegrationResponse> response = apiInstance.UpdateIntegrationWithHttpInfo(id, createIntegrationRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EventStreamingIntegrationsApi.UpdateIntegrationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | The unique numeric identifier of the event streaming integration. |  |
| **createIntegrationRequest** | [**CreateIntegrationRequest**](CreateIntegrationRequest.md) |  |  |

### Return type

[**IntegrationResponse**](IntegrationResponse.md)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Integration updated successfully. Returns the updated integration. |  -  |
| **400** | Bad Request (e.g., invalid JSON, validation error, invalid ID). |  -  |
| **401** | Unauthorized. |  -  |
| **404** | Not Found. |  -  |
| **500** | Internal Server Error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

