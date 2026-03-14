# NetBird.ApiClient.Api.EDRHuntressIntegrationsApi

All URIs are relative to *https://api.netbird.io/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiIntegrationsEdrHuntressDelete**](EDRHuntressIntegrationsApi.md#apiintegrationsedrhuntressdelete) | **DELETE** integrations/edr/huntress | Delete EDR Huntress Integration |
| [**ApiIntegrationsEdrHuntressGet**](EDRHuntressIntegrationsApi.md#apiintegrationsedrhuntressget) | **GET** integrations/edr/huntress | Get EDR Huntress Integration |
| [**CreateHuntressEDRIntegration**](EDRHuntressIntegrationsApi.md#createhuntressedrintegration) | **POST** /api/integrations/edr/huntress | Create EDR Huntress Integration |
| [**UpdateHuntressEDRIntegration**](EDRHuntressIntegrationsApi.md#updatehuntressedrintegration) | **PUT** /api/integrations/edr/huntress | Update EDR Huntress Integration |

<a id="apiintegrationsedrhuntressdelete"></a>
# **ApiIntegrationsEdrHuntressDelete**
> Object ApiIntegrationsEdrHuntressDelete ()

Delete EDR Huntress Integration

Deletes an EDR Huntress Integration by its ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiIntegrationsEdrHuntressDeleteExample
    {
        public static void Main()
        {
            
            NetBirdApiClientOptions c = new NetBirdApiClientOptions()
            {
                AccessToken = "nbp_XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                BaseUrl = "https://api.netbird.io/api"
            };
            var client = new NetBirdApiClient(c);

            var apiInstance = client.EDRHuntressIntegrationsApi;

            try
            {
                // Delete EDR Huntress Integration
                Object result = apiInstance.ApiIntegrationsEdrHuntressDelete();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EDRHuntressIntegrationsApi.ApiIntegrationsEdrHuntressDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiIntegrationsEdrHuntressDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete EDR Huntress Integration
    ApiResponse<Object> response = apiInstance.ApiIntegrationsEdrHuntressDeleteWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EDRHuntressIntegrationsApi.ApiIntegrationsEdrHuntressDeleteWithHttpInfo: " + e.Message);
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

<a id="apiintegrationsedrhuntressget"></a>
# **ApiIntegrationsEdrHuntressGet**
> EDRHuntressResponse ApiIntegrationsEdrHuntressGet ()

Get EDR Huntress Integration

Retrieves a specific EDR Huntress integration by its ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiIntegrationsEdrHuntressGetExample
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

            var apiInstance = new EDRHuntressIntegrationsApi;

            try
            {
                // Get EDR Huntress Integration
                EDRHuntressResponse result = apiInstance.ApiIntegrationsEdrHuntressGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EDRHuntressIntegrationsApi.ApiIntegrationsEdrHuntressGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiIntegrationsEdrHuntressGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get EDR Huntress Integration
    ApiResponse<EDRHuntressResponse> response = apiInstance.ApiIntegrationsEdrHuntressGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EDRHuntressIntegrationsApi.ApiIntegrationsEdrHuntressGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**EDRHuntressResponse**](EDRHuntressResponse.md)

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

<a id="createhuntressedrintegration"></a>
# **CreateHuntressEDRIntegration**
> EDRHuntressResponse CreateHuntressEDRIntegration (EDRHuntressRequest eDRHuntressRequest)

Create EDR Huntress Integration

Creates a new EDR Huntress integration

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class CreateHuntressEDRIntegrationExample
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

            var apiInstance = new EDRHuntressIntegrationsApi;
            var eDRHuntressRequest = new EDRHuntressRequest(); // EDRHuntressRequest | 

            try
            {
                // Create EDR Huntress Integration
                EDRHuntressResponse result = apiInstance.CreateHuntressEDRIntegration(eDRHuntressRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EDRHuntressIntegrationsApi.CreateHuntressEDRIntegration: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateHuntressEDRIntegrationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create EDR Huntress Integration
    ApiResponse<EDRHuntressResponse> response = apiInstance.CreateHuntressEDRIntegrationWithHttpInfo(eDRHuntressRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EDRHuntressIntegrationsApi.CreateHuntressEDRIntegrationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **eDRHuntressRequest** | [**EDRHuntressRequest**](EDRHuntressRequest.md) |  |  |

### Return type

[**EDRHuntressResponse**](EDRHuntressResponse.md)

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

<a id="updatehuntressedrintegration"></a>
# **UpdateHuntressEDRIntegration**
> EDRHuntressResponse UpdateHuntressEDRIntegration (EDRHuntressRequest eDRHuntressRequest)

Update EDR Huntress Integration

Updates an existing EDR Huntress Integration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class UpdateHuntressEDRIntegrationExample
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

            var apiInstance = new EDRHuntressIntegrationsApi;
            var eDRHuntressRequest = new EDRHuntressRequest(); // EDRHuntressRequest | 

            try
            {
                // Update EDR Huntress Integration
                EDRHuntressResponse result = apiInstance.UpdateHuntressEDRIntegration(eDRHuntressRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EDRHuntressIntegrationsApi.UpdateHuntressEDRIntegration: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateHuntressEDRIntegrationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update EDR Huntress Integration
    ApiResponse<EDRHuntressResponse> response = apiInstance.UpdateHuntressEDRIntegrationWithHttpInfo(eDRHuntressRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EDRHuntressIntegrationsApi.UpdateHuntressEDRIntegrationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **eDRHuntressRequest** | [**EDRHuntressRequest**](EDRHuntressRequest.md) |  |  |

### Return type

[**EDRHuntressResponse**](EDRHuntressResponse.md)

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

