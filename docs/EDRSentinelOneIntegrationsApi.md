# NetBird.ApiClient.Api.EDRSentinelOneIntegrationsApi

All URIs are relative to *https://api.netbird.io/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiIntegrationsEdrSentineloneDelete**](EDRSentinelOneIntegrationsApi.md#apiintegrationsedrsentinelonedelete) | **DELETE** integrations/edr/sentinelone | Delete EDR SentinelOne Integration |
| [**ApiIntegrationsEdrSentineloneGet**](EDRSentinelOneIntegrationsApi.md#apiintegrationsedrsentineloneget) | **GET** integrations/edr/sentinelone | Get EDR SentinelOne Integration |
| [**CreateSentinelOneEDRIntegration**](EDRSentinelOneIntegrationsApi.md#createsentineloneedrintegration) | **POST** /api/integrations/edr/sentinelone | Create EDR SentinelOne Integration |
| [**UpdateSentinelOneEDRIntegration**](EDRSentinelOneIntegrationsApi.md#updatesentineloneedrintegration) | **PUT** /api/integrations/edr/sentinelone | Update EDR SentinelOne Integration |

<a id="apiintegrationsedrsentinelonedelete"></a>
# **ApiIntegrationsEdrSentineloneDelete**
> Object ApiIntegrationsEdrSentineloneDelete ()

Delete EDR SentinelOne Integration

Deletes an EDR SentinelOne Integration by its ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiIntegrationsEdrSentineloneDeleteExample
    {
        public static void Main()
        {
            
            NetBirdApiClientOptions c = new NetBirdApiClientOptions()
            {
                AccessToken = "nbp_XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                BaseUrl = "https://api.netbird.io/api"
            };
            var client = new NetBirdApiClient(c);

            var apiInstance = client.EDRSentinelOneIntegrationsApi;

            try
            {
                // Delete EDR SentinelOne Integration
                Object result = apiInstance.ApiIntegrationsEdrSentineloneDelete();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EDRSentinelOneIntegrationsApi.ApiIntegrationsEdrSentineloneDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiIntegrationsEdrSentineloneDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete EDR SentinelOne Integration
    ApiResponse<Object> response = apiInstance.ApiIntegrationsEdrSentineloneDeleteWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EDRSentinelOneIntegrationsApi.ApiIntegrationsEdrSentineloneDeleteWithHttpInfo: " + e.Message);
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

<a id="apiintegrationsedrsentineloneget"></a>
# **ApiIntegrationsEdrSentineloneGet**
> EDRSentinelOneResponse ApiIntegrationsEdrSentineloneGet ()

Get EDR SentinelOne Integration

Retrieves a specific EDR SentinelOne integration by its ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiIntegrationsEdrSentineloneGetExample
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

            var apiInstance = new EDRSentinelOneIntegrationsApi;

            try
            {
                // Get EDR SentinelOne Integration
                EDRSentinelOneResponse result = apiInstance.ApiIntegrationsEdrSentineloneGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EDRSentinelOneIntegrationsApi.ApiIntegrationsEdrSentineloneGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiIntegrationsEdrSentineloneGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get EDR SentinelOne Integration
    ApiResponse<EDRSentinelOneResponse> response = apiInstance.ApiIntegrationsEdrSentineloneGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EDRSentinelOneIntegrationsApi.ApiIntegrationsEdrSentineloneGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**EDRSentinelOneResponse**](EDRSentinelOneResponse.md)

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

<a id="createsentineloneedrintegration"></a>
# **CreateSentinelOneEDRIntegration**
> EDRSentinelOneResponse CreateSentinelOneEDRIntegration (EDRSentinelOneRequest eDRSentinelOneRequest)

Create EDR SentinelOne Integration

Creates a new EDR SentinelOne integration

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class CreateSentinelOneEDRIntegrationExample
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

            var apiInstance = new EDRSentinelOneIntegrationsApi;
            var eDRSentinelOneRequest = new EDRSentinelOneRequest(); // EDRSentinelOneRequest | 

            try
            {
                // Create EDR SentinelOne Integration
                EDRSentinelOneResponse result = apiInstance.CreateSentinelOneEDRIntegration(eDRSentinelOneRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EDRSentinelOneIntegrationsApi.CreateSentinelOneEDRIntegration: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateSentinelOneEDRIntegrationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create EDR SentinelOne Integration
    ApiResponse<EDRSentinelOneResponse> response = apiInstance.CreateSentinelOneEDRIntegrationWithHttpInfo(eDRSentinelOneRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EDRSentinelOneIntegrationsApi.CreateSentinelOneEDRIntegrationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **eDRSentinelOneRequest** | [**EDRSentinelOneRequest**](EDRSentinelOneRequest.md) |  |  |

### Return type

[**EDRSentinelOneResponse**](EDRSentinelOneResponse.md)

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

<a id="updatesentineloneedrintegration"></a>
# **UpdateSentinelOneEDRIntegration**
> EDRSentinelOneResponse UpdateSentinelOneEDRIntegration (EDRSentinelOneRequest eDRSentinelOneRequest)

Update EDR SentinelOne Integration

Updates an existing EDR SentinelOne Integration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class UpdateSentinelOneEDRIntegrationExample
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

            var apiInstance = new EDRSentinelOneIntegrationsApi;
            var eDRSentinelOneRequest = new EDRSentinelOneRequest(); // EDRSentinelOneRequest | 

            try
            {
                // Update EDR SentinelOne Integration
                EDRSentinelOneResponse result = apiInstance.UpdateSentinelOneEDRIntegration(eDRSentinelOneRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EDRSentinelOneIntegrationsApi.UpdateSentinelOneEDRIntegration: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateSentinelOneEDRIntegrationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update EDR SentinelOne Integration
    ApiResponse<EDRSentinelOneResponse> response = apiInstance.UpdateSentinelOneEDRIntegrationWithHttpInfo(eDRSentinelOneRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EDRSentinelOneIntegrationsApi.UpdateSentinelOneEDRIntegrationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **eDRSentinelOneRequest** | [**EDRSentinelOneRequest**](EDRSentinelOneRequest.md) |  |  |

### Return type

[**EDRSentinelOneResponse**](EDRSentinelOneResponse.md)

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

