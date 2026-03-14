# NetBird.ApiClient.Api.InvoiceApi

All URIs are relative to *https://api.netbird.io/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiIntegrationsBillingInvoicesGet**](InvoiceApi.md#apiintegrationsbillinginvoicesget) | **GET** integrations/billing/invoices | Get account&#39;s paid invoices |
| [**ApiIntegrationsBillingInvoicesIdCsvGet**](InvoiceApi.md#apiintegrationsbillinginvoicesidcsvget) | **GET** integrations/billing/invoices/{id}/csv | Get account invoice CSV. |
| [**ApiIntegrationsBillingInvoicesIdPdfGet**](InvoiceApi.md#apiintegrationsbillinginvoicesidpdfget) | **GET** integrations/billing/invoices/{id}/pdf | Get account invoice URL to Stripe. |

<a id="apiintegrationsbillinginvoicesget"></a>
# **ApiIntegrationsBillingInvoicesGet**
> List&lt;InvoiceResponse&gt; ApiIntegrationsBillingInvoicesGet ()

Get account's paid invoices

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiIntegrationsBillingInvoicesGetExample
    {
        public static void Main()
        {
            
            NetBirdApiClientOptions c = new NetBirdApiClientOptions()
            {
                AccessToken = "nbp_XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                BaseUrl = "https://api.netbird.io/api"
            };
            var client = new NetBirdApiClient(c);

            var apiInstance = client.InvoiceApi;

            try
            {
                // Get account's paid invoices
                List<InvoiceResponse> result = apiInstance.ApiIntegrationsBillingInvoicesGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InvoiceApi.ApiIntegrationsBillingInvoicesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiIntegrationsBillingInvoicesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get account's paid invoices
    ApiResponse<List<InvoiceResponse>> response = apiInstance.ApiIntegrationsBillingInvoicesGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InvoiceApi.ApiIntegrationsBillingInvoicesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;InvoiceResponse&gt;**](InvoiceResponse.md)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The account&#39;s paid invoices |  -  |
| **400** | Bad Request |  -  |
| **401** | Requires authentication |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiintegrationsbillinginvoicesidcsvget"></a>
# **ApiIntegrationsBillingInvoicesIdCsvGet**
> string ApiIntegrationsBillingInvoicesIdCsvGet (string id)

Get account invoice CSV.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiIntegrationsBillingInvoicesIdCsvGetExample
    {
        public static void Main()
        {
            
            NetBirdApiClientOptions c = new NetBirdApiClientOptions()
            {
                AccessToken = "nbp_XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                BaseUrl = "https://api.netbird.io/api"
            };
            var client = new NetBirdApiClient(c);

            var apiInstance = client.InvoiceApi;
            var id = "id_example";  // string | The unique identifier of the invoice

            try
            {
                // Get account invoice CSV.
                string result = apiInstance.ApiIntegrationsBillingInvoicesIdCsvGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InvoiceApi.ApiIntegrationsBillingInvoicesIdCsvGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiIntegrationsBillingInvoicesIdCsvGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get account invoice CSV.
    ApiResponse<string> response = apiInstance.ApiIntegrationsBillingInvoicesIdCsvGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InvoiceApi.ApiIntegrationsBillingInvoicesIdCsvGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The unique identifier of the invoice |  |

### Return type

**string**

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The invoice CSV |  * Content-Disposition -  <br>  |
| **400** | Bad Request |  -  |
| **401** | Requires authentication |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiintegrationsbillinginvoicesidpdfget"></a>
# **ApiIntegrationsBillingInvoicesIdPdfGet**
> InvoicePDFResponse ApiIntegrationsBillingInvoicesIdPdfGet (string id)

Get account invoice URL to Stripe.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiIntegrationsBillingInvoicesIdPdfGetExample
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

            var apiInstance = new InvoiceApi;
            var id = "id_example";  // string | The unique identifier of the invoice

            try
            {
                // Get account invoice URL to Stripe.
                InvoicePDFResponse result = apiInstance.ApiIntegrationsBillingInvoicesIdPdfGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InvoiceApi.ApiIntegrationsBillingInvoicesIdPdfGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiIntegrationsBillingInvoicesIdPdfGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get account invoice URL to Stripe.
    ApiResponse<InvoicePDFResponse> response = apiInstance.ApiIntegrationsBillingInvoicesIdPdfGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InvoiceApi.ApiIntegrationsBillingInvoicesIdPdfGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The unique identifier of the invoice |  |

### Return type

[**InvoicePDFResponse**](InvoicePDFResponse.md)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The invoice URL to Stripe |  -  |
| **400** | Bad Request |  -  |
| **401** | Requires authentication |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

