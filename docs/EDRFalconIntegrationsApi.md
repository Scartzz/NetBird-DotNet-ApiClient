# NetBird.ApiClient.Api.EDRFalconIntegrationsApi

All URIs are relative to *https://api.netbird.io/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiIntegrationsEdrFalconDelete**](EDRFalconIntegrationsApi.md#apiintegrationsedrfalcondelete) | **DELETE** integrations/edr/falcon | Delete EDR Falcon Integration |
| [**ApiIntegrationsEdrFalconGet**](EDRFalconIntegrationsApi.md#apiintegrationsedrfalconget) | **GET** integrations/edr/falcon | Get EDR Falcon Integration |
| [**CreateFalconEDRIntegration**](EDRFalconIntegrationsApi.md#createfalconedrintegration) | **POST** /api/integrations/edr/falcon | Create EDR Falcon Integration |
| [**UpdateFalconEDRIntegration**](EDRFalconIntegrationsApi.md#updatefalconedrintegration) | **PUT** /api/integrations/edr/falcon | Update EDR Falcon Integration |

<a id="apiintegrationsedrfalcondelete"></a>
# **ApiIntegrationsEdrFalconDelete**
> void ApiIntegrationsEdrFalconDelete ()

Delete EDR Falcon Integration

Deletes an existing EDR Falcon Integration by its ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiIntegrationsEdrFalconDeleteExample
    {
        public static void Main()
        {
            
            NetBirdApiClientOptions c = new NetBirdApiClientOptions()
            {
                AccessToken = "nbp_XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                BaseUrl = "https://api.netbird.io/api"
            };
            var client = new NetBirdApiClient(c);

            var apiInstance = client.EDRFalconIntegrationsApi;

            try
            {
                // Delete EDR Falcon Integration
                apiInstance.ApiIntegrationsEdrFalconDelete();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EDRFalconIntegrationsApi.ApiIntegrationsEdrFalconDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiIntegrationsEdrFalconDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete EDR Falcon Integration
    apiInstance.ApiIntegrationsEdrFalconDeleteWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EDRFalconIntegrationsApi.ApiIntegrationsEdrFalconDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

void (empty response body)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | Integration deleted successfully. Typically returns no content. |  -  |
| **400** | Bad Request (e.g., invalid integration ID format). |  -  |
| **401** | Unauthorized. |  -  |
| **404** | Not Found. |  -  |
| **500** | Internal Server Error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiintegrationsedrfalconget"></a>
# **ApiIntegrationsEdrFalconGet**
> EDRFalconResponse ApiIntegrationsEdrFalconGet ()

Get EDR Falcon Integration

Retrieves a specific EDR Falcon integration by its ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiIntegrationsEdrFalconGetExample
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

            var apiInstance = new EDRFalconIntegrationsApi;

            try
            {
                // Get EDR Falcon Integration
                EDRFalconResponse result = apiInstance.ApiIntegrationsEdrFalconGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EDRFalconIntegrationsApi.ApiIntegrationsEdrFalconGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiIntegrationsEdrFalconGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get EDR Falcon Integration
    ApiResponse<EDRFalconResponse> response = apiInstance.ApiIntegrationsEdrFalconGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EDRFalconIntegrationsApi.ApiIntegrationsEdrFalconGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**EDRFalconResponse**](EDRFalconResponse.md)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved the integration details. |  -  |
| **400** | Bad Request (e.g., invalid integration ID format). |  -  |
| **401** | Unauthorized. |  -  |
| **404** | Not Found (e.g., integration with the given ID does not exist). |  -  |
| **500** | Internal Server Error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createfalconedrintegration"></a>
# **CreateFalconEDRIntegration**
> EDRFalconResponse CreateFalconEDRIntegration (EDRFalconRequest eDRFalconRequest)

Create EDR Falcon Integration

Creates a new EDR Falcon integration

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class CreateFalconEDRIntegrationExample
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

            var apiInstance = new EDRFalconIntegrationsApi;
            var eDRFalconRequest = new EDRFalconRequest(); // EDRFalconRequest | 

            try
            {
                // Create EDR Falcon Integration
                EDRFalconResponse result = apiInstance.CreateFalconEDRIntegration(eDRFalconRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EDRFalconIntegrationsApi.CreateFalconEDRIntegration: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateFalconEDRIntegrationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create EDR Falcon Integration
    ApiResponse<EDRFalconResponse> response = apiInstance.CreateFalconEDRIntegrationWithHttpInfo(eDRFalconRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EDRFalconIntegrationsApi.CreateFalconEDRIntegrationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **eDRFalconRequest** | [**EDRFalconRequest**](EDRFalconRequest.md) |  |  |

### Return type

[**EDRFalconResponse**](EDRFalconResponse.md)

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

<a id="updatefalconedrintegration"></a>
# **UpdateFalconEDRIntegration**
> EDRFalconResponse UpdateFalconEDRIntegration (EDRFalconRequest eDRFalconRequest)

Update EDR Falcon Integration

Updates an existing EDR Falcon Integration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class UpdateFalconEDRIntegrationExample
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

            var apiInstance = new EDRFalconIntegrationsApi;
            var eDRFalconRequest = new EDRFalconRequest(); // EDRFalconRequest | 

            try
            {
                // Update EDR Falcon Integration
                EDRFalconResponse result = apiInstance.UpdateFalconEDRIntegration(eDRFalconRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EDRFalconIntegrationsApi.UpdateFalconEDRIntegration: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateFalconEDRIntegrationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update EDR Falcon Integration
    ApiResponse<EDRFalconResponse> response = apiInstance.UpdateFalconEDRIntegrationWithHttpInfo(eDRFalconRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EDRFalconIntegrationsApi.UpdateFalconEDRIntegrationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **eDRFalconRequest** | [**EDRFalconRequest**](EDRFalconRequest.md) |  |  |

### Return type

[**EDRFalconResponse**](EDRFalconResponse.md)

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

