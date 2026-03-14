# NetBird.ApiClient.Api.AWSMarketplaceApi

All URIs are relative to *https://api.netbird.io/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiIntegrationsBillingAwsMarketplaceActivatePost**](AWSMarketplaceApi.md#apiintegrationsbillingawsmarketplaceactivatepost) | **POST** integrations/billing/aws/marketplace/activate | Activate AWS Marketplace subscription. |
| [**ApiIntegrationsBillingAwsMarketplaceEnrichPost**](AWSMarketplaceApi.md#apiintegrationsbillingawsmarketplaceenrichpost) | **POST** /api/integrations/billing/aws/marketplace/enrich | Enrich AWS Marketplace subscription with Account ID. |

<a id="apiintegrationsbillingawsmarketplaceactivatepost"></a>
# **ApiIntegrationsBillingAwsMarketplaceActivatePost**
> void ApiIntegrationsBillingAwsMarketplaceActivatePost (ApiIntegrationsBillingAwsMarketplaceActivatePostRequest apiIntegrationsBillingAwsMarketplaceActivatePostRequest)

Activate AWS Marketplace subscription.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiIntegrationsBillingAwsMarketplaceActivatePostExample
    {
        public static void Main()
        {
            
            NetBirdApiClientOptions c = new NetBirdApiClientOptions()
            {
                AccessToken = "nbp_XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                BaseUrl = "https://api.netbird.io/api"
            };
            var client = new NetBirdApiClient(c);

            var apiInstance = client.AWSMarketplaceApi;
            var apiIntegrationsBillingAwsMarketplaceActivatePostRequest = new ApiIntegrationsBillingAwsMarketplaceActivatePostRequest(); // ApiIntegrationsBillingAwsMarketplaceActivatePostRequest | 

            try
            {
                // Activate AWS Marketplace subscription.
                apiInstance.ApiIntegrationsBillingAwsMarketplaceActivatePost(apiIntegrationsBillingAwsMarketplaceActivatePostRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AWSMarketplaceApi.ApiIntegrationsBillingAwsMarketplaceActivatePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiIntegrationsBillingAwsMarketplaceActivatePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Activate AWS Marketplace subscription.
    apiInstance.ApiIntegrationsBillingAwsMarketplaceActivatePostWithHttpInfo(apiIntegrationsBillingAwsMarketplaceActivatePostRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AWSMarketplaceApi.ApiIntegrationsBillingAwsMarketplaceActivatePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **apiIntegrationsBillingAwsMarketplaceActivatePostRequest** | [**ApiIntegrationsBillingAwsMarketplaceActivatePostRequest**](ApiIntegrationsBillingAwsMarketplaceActivatePostRequest.md) |  |  |

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
| **200** | AWS subscription successfully activated |  -  |
| **400** | Bad Request |  -  |
| **401** | Requires authentication |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiintegrationsbillingawsmarketplaceenrichpost"></a>
# **ApiIntegrationsBillingAwsMarketplaceEnrichPost**
> void ApiIntegrationsBillingAwsMarketplaceEnrichPost (ApiIntegrationsBillingAwsMarketplaceEnrichPostRequest apiIntegrationsBillingAwsMarketplaceEnrichPostRequest)

Enrich AWS Marketplace subscription with Account ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiIntegrationsBillingAwsMarketplaceEnrichPostExample
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

            var apiInstance = client.AWSMarketplaceApi;
            var apiIntegrationsBillingAwsMarketplaceEnrichPostRequest = new ApiIntegrationsBillingAwsMarketplaceEnrichPostRequest(); // ApiIntegrationsBillingAwsMarketplaceEnrichPostRequest | 

            try
            {
                // Enrich AWS Marketplace subscription with Account ID.
                apiInstance.ApiIntegrationsBillingAwsMarketplaceEnrichPost(apiIntegrationsBillingAwsMarketplaceEnrichPostRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AWSMarketplaceApi.ApiIntegrationsBillingAwsMarketplaceEnrichPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiIntegrationsBillingAwsMarketplaceEnrichPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Enrich AWS Marketplace subscription with Account ID.
    apiInstance.ApiIntegrationsBillingAwsMarketplaceEnrichPostWithHttpInfo(apiIntegrationsBillingAwsMarketplaceEnrichPostRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AWSMarketplaceApi.ApiIntegrationsBillingAwsMarketplaceEnrichPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **apiIntegrationsBillingAwsMarketplaceEnrichPostRequest** | [**ApiIntegrationsBillingAwsMarketplaceEnrichPostRequest**](ApiIntegrationsBillingAwsMarketplaceEnrichPostRequest.md) |  |  |

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
| **200** | AWS subscription successfully enriched with Account ID. |  -  |
| **400** | Bad Request |  -  |
| **401** | Requires authentication |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

