# NetBird.ApiClient.Api.PortalApi

All URIs are relative to *https://api.netbird.io/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiIntegrationsBillingPortalGet**](PortalApi.md#apiintegrationsbillingportalget) | **GET** integrations/billing/portal | Get customer portal URL |

<a id="apiintegrationsbillingportalget"></a>
# **ApiIntegrationsBillingPortalGet**
> PortalResponse ApiIntegrationsBillingPortalGet (string baseURL)

Get customer portal URL

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiIntegrationsBillingPortalGetExample
    {
        public static void Main()
        {
            
            NetBirdApiClientOptions c = new NetBirdApiClientOptions()
            {
                AccessToken = "nbp_XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                BaseUrl = "https://api.netbird.io/api"
            };
            var client = new NetBirdApiClient(c);

            var apiInstance = client.PortalApi;
            var baseURL = https://app.netbird.io/plans;  // string | The base URL for the redirect after accessing the portal.

            try
            {
                // Get customer portal URL
                PortalResponse result = apiInstance.ApiIntegrationsBillingPortalGet(baseURL);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PortalApi.ApiIntegrationsBillingPortalGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiIntegrationsBillingPortalGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get customer portal URL
    ApiResponse<PortalResponse> response = apiInstance.ApiIntegrationsBillingPortalGetWithHttpInfo(baseURL);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PortalApi.ApiIntegrationsBillingPortalGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **baseURL** | **string** | The base URL for the redirect after accessing the portal. |  |

### Return type

[**PortalResponse**](PortalResponse.md)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Customer portal URL |  -  |
| **400** | Bad Request |  -  |
| **401** | Requires authentication |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

