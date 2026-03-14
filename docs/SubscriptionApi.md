# NetBird.ApiClient.Api.SubscriptionApi

All URIs are relative to *https://api.netbird.io/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiIntegrationsBillingSubscriptionGet**](SubscriptionApi.md#apiintegrationsbillingsubscriptionget) | **GET** integrations/billing/subscription | Get current subscription |
| [**ApiIntegrationsBillingSubscriptionPut**](SubscriptionApi.md#apiintegrationsbillingsubscriptionput) | **PUT** /api/integrations/billing/subscription | Change subscription |

<a id="apiintegrationsbillingsubscriptionget"></a>
# **ApiIntegrationsBillingSubscriptionGet**
> Subscription ApiIntegrationsBillingSubscriptionGet ()

Get current subscription

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiIntegrationsBillingSubscriptionGetExample
    {
        public static void Main()
        {
            
            NetBirdApiClientOptions c = new NetBirdApiClientOptions()
            {
                AccessToken = "nbp_XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                BaseUrl = "https://api.netbird.io/api"
            };
            var client = new NetBirdApiClient(c);

            var apiInstance = client.SubscriptionApi;

            try
            {
                // Get current subscription
                Subscription result = apiInstance.ApiIntegrationsBillingSubscriptionGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubscriptionApi.ApiIntegrationsBillingSubscriptionGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiIntegrationsBillingSubscriptionGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get current subscription
    ApiResponse<Subscription> response = apiInstance.ApiIntegrationsBillingSubscriptionGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubscriptionApi.ApiIntegrationsBillingSubscriptionGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**Subscription**](Subscription.md)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Subscription details |  -  |
| **401** | Requires authentication |  -  |
| **404** | No subscription found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiintegrationsbillingsubscriptionput"></a>
# **ApiIntegrationsBillingSubscriptionPut**
> void ApiIntegrationsBillingSubscriptionPut (ApiIntegrationsBillingSubscriptionPutRequest apiIntegrationsBillingSubscriptionPutRequest)

Change subscription

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiIntegrationsBillingSubscriptionPutExample
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

            var apiInstance = client.SubscriptionApi;
            var apiIntegrationsBillingSubscriptionPutRequest = new ApiIntegrationsBillingSubscriptionPutRequest(); // ApiIntegrationsBillingSubscriptionPutRequest | 

            try
            {
                // Change subscription
                apiInstance.ApiIntegrationsBillingSubscriptionPut(apiIntegrationsBillingSubscriptionPutRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubscriptionApi.ApiIntegrationsBillingSubscriptionPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiIntegrationsBillingSubscriptionPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Change subscription
    apiInstance.ApiIntegrationsBillingSubscriptionPutWithHttpInfo(apiIntegrationsBillingSubscriptionPutRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubscriptionApi.ApiIntegrationsBillingSubscriptionPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **apiIntegrationsBillingSubscriptionPutRequest** | [**ApiIntegrationsBillingSubscriptionPutRequest**](ApiIntegrationsBillingSubscriptionPutRequest.md) |  |  |

### Return type

void (empty response body)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Subscription successfully changed |  -  |
| **400** | Bad Request |  -  |
| **401** | Requires authentication |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

