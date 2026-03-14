# NetBird.ApiClient.Api.EDRIntuneIntegrationsApi

All URIs are relative to *https://api.netbird.io/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateEDRIntegration**](EDRIntuneIntegrationsApi.md#createedrintegration) | **POST** integrations/edr/intune | Create EDR Intune Integration |
| [**DeleteIntegration**](EDRIntuneIntegrationsApi.md#deleteintegration) | **DELETE** integrations/edr/intune | Delete EDR Intune Integration |
| [**GetEDRIntegration**](EDRIntuneIntegrationsApi.md#getedrintegration) | **GET** /api/integrations/edr/intune | Get EDR Intune Integration |
| [**UpdateEDRIntegration**](EDRIntuneIntegrationsApi.md#updateedrintegration) | **PUT** /api/integrations/edr/intune | Update EDR Intune Integration |

<a id="createedrintegration"></a>
# **CreateEDRIntegration**
> EDRIntuneResponse CreateEDRIntegration (EDRIntuneRequest eDRIntuneRequest)

Create EDR Intune Integration

Creates a new EDR Intune integration for the authenticated account. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class CreateEDRIntegrationExample
    {
        public static void Main()
        {
            
            NetBirdApiClientOptions c = new NetBirdApiClientOptions()
            {
                AccessToken = "nbp_XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                BaseUrl = "https://api.netbird.io/api"
            };
            var client = new NetBirdApiClient(c);

            var apiInstance = client.EDRIntuneIntegrationsApi;
            var eDRIntuneRequest = new EDRIntuneRequest(); // EDRIntuneRequest | 

            try
            {
                // Create EDR Intune Integration
                EDRIntuneResponse result = apiInstance.CreateEDRIntegration(eDRIntuneRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EDRIntuneIntegrationsApi.CreateEDRIntegration: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateEDRIntegrationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create EDR Intune Integration
    ApiResponse<EDRIntuneResponse> response = apiInstance.CreateEDRIntegrationWithHttpInfo(eDRIntuneRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EDRIntuneIntegrationsApi.CreateEDRIntegrationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **eDRIntuneRequest** | [**EDRIntuneRequest**](EDRIntuneRequest.md) |  |  |

### Return type

[**EDRIntuneResponse**](EDRIntuneResponse.md)

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
> Object DeleteIntegration ()

Delete EDR Intune Integration

Deletes an EDR Intune Integration by its ID.

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

            var apiInstance = new EDRIntuneIntegrationsApi;

            try
            {
                // Delete EDR Intune Integration
                Object result = apiInstance.DeleteIntegration();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EDRIntuneIntegrationsApi.DeleteIntegration: " + e.Message);
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
    // Delete EDR Intune Integration
    ApiResponse<Object> response = apiInstance.DeleteIntegrationWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EDRIntuneIntegrationsApi.DeleteIntegrationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
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

<a id="getedrintegration"></a>
# **GetEDRIntegration**
> EDRIntuneResponse GetEDRIntegration ()

Get EDR Intune Integration

Retrieves a specific EDR Intune integration by its ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class GetEDRIntegrationExample
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

            var apiInstance = new EDRIntuneIntegrationsApi;

            try
            {
                // Get EDR Intune Integration
                EDRIntuneResponse result = apiInstance.GetEDRIntegration();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EDRIntuneIntegrationsApi.GetEDRIntegration: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEDRIntegrationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get EDR Intune Integration
    ApiResponse<EDRIntuneResponse> response = apiInstance.GetEDRIntegrationWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EDRIntuneIntegrationsApi.GetEDRIntegrationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**EDRIntuneResponse**](EDRIntuneResponse.md)

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

<a id="updateedrintegration"></a>
# **UpdateEDRIntegration**
> EDRIntuneResponse UpdateEDRIntegration (EDRIntuneRequest eDRIntuneRequest)

Update EDR Intune Integration

Updates an existing EDR Intune Integration. The request body structure is `EDRIntuneRequest`. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class UpdateEDRIntegrationExample
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

            var apiInstance = new EDRIntuneIntegrationsApi;
            var eDRIntuneRequest = new EDRIntuneRequest(); // EDRIntuneRequest | 

            try
            {
                // Update EDR Intune Integration
                EDRIntuneResponse result = apiInstance.UpdateEDRIntegration(eDRIntuneRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EDRIntuneIntegrationsApi.UpdateEDRIntegration: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateEDRIntegrationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update EDR Intune Integration
    ApiResponse<EDRIntuneResponse> response = apiInstance.UpdateEDRIntegrationWithHttpInfo(eDRIntuneRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EDRIntuneIntegrationsApi.UpdateEDRIntegrationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **eDRIntuneRequest** | [**EDRIntuneRequest**](EDRIntuneRequest.md) |  |  |

### Return type

[**EDRIntuneResponse**](EDRIntuneResponse.md)

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

