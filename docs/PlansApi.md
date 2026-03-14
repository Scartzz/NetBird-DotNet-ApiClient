# NetBird.ApiClient.Api.PlansApi

All URIs are relative to *https://api.netbird.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiIntegrationsBillingPlansGet**](PlansApi.md#apiintegrationsbillingplansget) | **GET** integrations/billing/plans | Get available plans |

<a id="apiintegrationsbillingplansget"></a>
# **ApiIntegrationsBillingPlansGet**
> List&lt;Product&gt; ApiIntegrationsBillingPlansGet ()

Get available plans

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiIntegrationsBillingPlansGetExample
    {
        public static void Main()
        {
            
            NetBirdApiClientOptions c = new NetBirdApiClientOptions()
            {
                AccessToken = "nbp_XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                BaseUrl = "https://api.netbird.io/api"
            };
            var client = new NetBirdApiClient(c);

            var apiInstance = client.PlansApi;

            try
            {
                // Get available plans
                List<Product> result = apiInstance.ApiIntegrationsBillingPlansGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlansApi.ApiIntegrationsBillingPlansGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiIntegrationsBillingPlansGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get available plans
    ApiResponse<List<Product>> response = apiInstance.ApiIntegrationsBillingPlansGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PlansApi.ApiIntegrationsBillingPlansGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;Product&gt;**](Product.md)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of available plans |  -  |
| **401** | Requires authentication |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

