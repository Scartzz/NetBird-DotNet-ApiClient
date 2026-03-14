# NetBird.ApiClient.Api.CheckoutApi

All URIs are relative to *https://api.netbird.io/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiIntegrationsBillingCheckoutPost**](CheckoutApi.md#apiintegrationsbillingcheckoutpost) | **POST** integrations/billing/checkout | Create checkout session |

<a id="apiintegrationsbillingcheckoutpost"></a>
# **ApiIntegrationsBillingCheckoutPost**
> CheckoutResponse ApiIntegrationsBillingCheckoutPost (ApiIntegrationsBillingCheckoutPostRequest apiIntegrationsBillingCheckoutPostRequest)

Create checkout session

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiIntegrationsBillingCheckoutPostExample
    {
        public static void Main()
        {
            
            NetBirdApiClientOptions c = new NetBirdApiClientOptions()
            {
                AccessToken = "nbp_XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                BaseUrl = "https://api.netbird.io/api"
            };
            var client = new NetBirdApiClient(c);

            var apiInstance = client.CheckoutApi;
            var apiIntegrationsBillingCheckoutPostRequest = new ApiIntegrationsBillingCheckoutPostRequest(); // ApiIntegrationsBillingCheckoutPostRequest | 

            try
            {
                // Create checkout session
                CheckoutResponse result = apiInstance.ApiIntegrationsBillingCheckoutPost(apiIntegrationsBillingCheckoutPostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CheckoutApi.ApiIntegrationsBillingCheckoutPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiIntegrationsBillingCheckoutPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create checkout session
    ApiResponse<CheckoutResponse> response = apiInstance.ApiIntegrationsBillingCheckoutPostWithHttpInfo(apiIntegrationsBillingCheckoutPostRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CheckoutApi.ApiIntegrationsBillingCheckoutPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **apiIntegrationsBillingCheckoutPostRequest** | [**ApiIntegrationsBillingCheckoutPostRequest**](ApiIntegrationsBillingCheckoutPostRequest.md) |  |  |

### Return type

[**CheckoutResponse**](CheckoutResponse.md)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Checkout session URL |  -  |
| **400** | Bad Request |  -  |
| **401** | Requires authentication |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

