# NetBird.ApiClient.Api.ServicesApi

All URIs are relative to *https://api.netbird.io/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiReverseProxiesClustersGet**](ServicesApi.md#apireverseproxiesclustersget) | **GET** reverse-proxies/clusters | List available proxy clusters |
| [**ApiReverseProxiesDomainsDomainIdDelete**](ServicesApi.md#apireverseproxiesdomainsdomainiddelete) | **DELETE** reverse-proxies/domains/{domainId} | Delete a Custom domain |
| [**ApiReverseProxiesDomainsDomainIdValidateGet**](ServicesApi.md#apireverseproxiesdomainsdomainidvalidateget) | **GET** /api/reverse-proxies/domains/{domainId}/validate | Validate a custom domain |
| [**ApiReverseProxiesDomainsGet**](ServicesApi.md#apireverseproxiesdomainsget) | **GET** /api/reverse-proxies/domains | Retrieve Service Domains |
| [**ApiReverseProxiesDomainsPost**](ServicesApi.md#apireverseproxiesdomainspost) | **POST** /api/reverse-proxies/domains | Create a Custom domain |
| [**ApiReverseProxiesServicesGet**](ServicesApi.md#apireverseproxiesservicesget) | **GET** /api/reverse-proxies/services | List all Services |
| [**ApiReverseProxiesServicesPost**](ServicesApi.md#apireverseproxiesservicespost) | **POST** /api/reverse-proxies/services | Create a Service |
| [**ApiReverseProxiesServicesServiceIdDelete**](ServicesApi.md#apireverseproxiesservicesserviceiddelete) | **DELETE** /api/reverse-proxies/services/{serviceId} | Delete a Service |
| [**ApiReverseProxiesServicesServiceIdGet**](ServicesApi.md#apireverseproxiesservicesserviceidget) | **GET** /api/reverse-proxies/services/{serviceId} | Retrieve a Service |
| [**ApiReverseProxiesServicesServiceIdPut**](ServicesApi.md#apireverseproxiesservicesserviceidput) | **PUT** /api/reverse-proxies/services/{serviceId} | Update a Service |

<a id="apireverseproxiesclustersget"></a>
# **ApiReverseProxiesClustersGet**
> List&lt;ProxyCluster&gt; ApiReverseProxiesClustersGet ()

List available proxy clusters

Returns a list of available proxy clusters with their connection status

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiReverseProxiesClustersGetExample
    {
        public static void Main()
        {
            
            NetBirdApiClientOptions c = new NetBirdApiClientOptions()
            {
                AccessToken = "nbp_XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                BaseUrl = "https://api.netbird.io/api"
            };
            var client = new NetBirdApiClient(c);

            var apiInstance = client.ServicesApi;

            try
            {
                // List available proxy clusters
                List<ProxyCluster> result = apiInstance.ApiReverseProxiesClustersGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServicesApi.ApiReverseProxiesClustersGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiReverseProxiesClustersGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List available proxy clusters
    ApiResponse<List<ProxyCluster>> response = apiInstance.ApiReverseProxiesClustersGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ServicesApi.ApiReverseProxiesClustersGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;ProxyCluster&gt;**](ProxyCluster.md)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A JSON Array of proxy clusters |  -  |
| **401** | Requires authentication |  -  |
| **403** | Forbidden |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apireverseproxiesdomainsdomainiddelete"></a>
# **ApiReverseProxiesDomainsDomainIdDelete**
> void ApiReverseProxiesDomainsDomainIdDelete (string domainId)

Delete a Custom domain

Delete an existing service custom domain

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiReverseProxiesDomainsDomainIdDeleteExample
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

            var apiInstance = client.ServicesApi;
            var domainId = "domainId_example";  // string | The custom domain ID

            try
            {
                // Delete a Custom domain
                apiInstance.ApiReverseProxiesDomainsDomainIdDelete(domainId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServicesApi.ApiReverseProxiesDomainsDomainIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiReverseProxiesDomainsDomainIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a Custom domain
    apiInstance.ApiReverseProxiesDomainsDomainIdDeleteWithHttpInfo(domainId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ServicesApi.ApiReverseProxiesDomainsDomainIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **domainId** | **string** | The custom domain ID |  |

### Return type

void (empty response body)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Service custom domain deleted |  -  |
| **400** | Bad Request |  -  |
| **401** | Requires authentication |  -  |
| **403** | Forbidden |  -  |
| **404** | Resource not found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apireverseproxiesdomainsdomainidvalidateget"></a>
# **ApiReverseProxiesDomainsDomainIdValidateGet**
> void ApiReverseProxiesDomainsDomainIdValidateGet (string domainId)

Validate a custom domain

Trigger domain ownership validation for a custom domain

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiReverseProxiesDomainsDomainIdValidateGetExample
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

            var apiInstance = new ServicesApi;
            var domainId = "domainId_example";  // string | The custom domain ID

            try
            {
                // Validate a custom domain
                apiInstance.ApiReverseProxiesDomainsDomainIdValidateGet(domainId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServicesApi.ApiReverseProxiesDomainsDomainIdValidateGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiReverseProxiesDomainsDomainIdValidateGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Validate a custom domain
    apiInstance.ApiReverseProxiesDomainsDomainIdValidateGetWithHttpInfo(domainId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ServicesApi.ApiReverseProxiesDomainsDomainIdValidateGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **domainId** | **string** | The custom domain ID |  |

### Return type

void (empty response body)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | Reverse proxy custom domain validation triggered |  -  |
| **400** | Bad Request |  -  |
| **401** | Requires authentication |  -  |
| **403** | Forbidden |  -  |
| **404** | Resource not found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apireverseproxiesdomainsget"></a>
# **ApiReverseProxiesDomainsGet**
> List&lt;ReverseProxyDomain&gt; ApiReverseProxiesDomainsGet ()

Retrieve Service Domains

Get information about domains that can be used for service endpoints.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiReverseProxiesDomainsGetExample
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

            var apiInstance = new ServicesApi;

            try
            {
                // Retrieve Service Domains
                List<ReverseProxyDomain> result = apiInstance.ApiReverseProxiesDomainsGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServicesApi.ApiReverseProxiesDomainsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiReverseProxiesDomainsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Service Domains
    ApiResponse<List<ReverseProxyDomain>> response = apiInstance.ApiReverseProxiesDomainsGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ServicesApi.ApiReverseProxiesDomainsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;ReverseProxyDomain&gt;**](ReverseProxyDomain.md)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A JSON Array of ReverseProxyDomains |  -  |
| **400** | Bad Request |  -  |
| **401** | Requires authentication |  -  |
| **403** | Forbidden |  -  |
| **404** | Resource not found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apireverseproxiesdomainspost"></a>
# **ApiReverseProxiesDomainsPost**
> Service ApiReverseProxiesDomainsPost (ReverseProxyDomainRequest? reverseProxyDomainRequest = null)

Create a Custom domain

Create a new Custom domain for use with service endpoints, this will trigger an initial validation check

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiReverseProxiesDomainsPostExample
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

            var apiInstance = new ServicesApi;
            var reverseProxyDomainRequest = new ReverseProxyDomainRequest?(); // ReverseProxyDomainRequest? | Custom domain creation request (optional) 

            try
            {
                // Create a Custom domain
                Service result = apiInstance.ApiReverseProxiesDomainsPost(reverseProxyDomainRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServicesApi.ApiReverseProxiesDomainsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiReverseProxiesDomainsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a Custom domain
    ApiResponse<Service> response = apiInstance.ApiReverseProxiesDomainsPostWithHttpInfo(reverseProxyDomainRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ServicesApi.ApiReverseProxiesDomainsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **reverseProxyDomainRequest** | [**ReverseProxyDomainRequest?**](ReverseProxyDomainRequest?.md) | Custom domain creation request | [optional]  |

### Return type

[**Service**](Service.md)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Service created |  -  |
| **400** | Bad Request |  -  |
| **401** | Requires authentication |  -  |
| **403** | Forbidden |  -  |
| **404** | Resource not found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apireverseproxiesservicesget"></a>
# **ApiReverseProxiesServicesGet**
> List&lt;Service&gt; ApiReverseProxiesServicesGet ()

List all Services

Returns a list of all reverse proxy services

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiReverseProxiesServicesGetExample
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

            var apiInstance = new ServicesApi;

            try
            {
                // List all Services
                List<Service> result = apiInstance.ApiReverseProxiesServicesGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServicesApi.ApiReverseProxiesServicesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiReverseProxiesServicesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List all Services
    ApiResponse<List<Service>> response = apiInstance.ApiReverseProxiesServicesGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ServicesApi.ApiReverseProxiesServicesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;Service&gt;**](Service.md)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A JSON Array of services |  -  |
| **401** | Requires authentication |  -  |
| **403** | Forbidden |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apireverseproxiesservicespost"></a>
# **ApiReverseProxiesServicesPost**
> Service ApiReverseProxiesServicesPost (ServiceRequest? serviceRequest = null)

Create a Service

Creates a new reverse proxy service

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiReverseProxiesServicesPostExample
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

            var apiInstance = new ServicesApi;
            var serviceRequest = new ServiceRequest?(); // ServiceRequest? | New service request (optional) 

            try
            {
                // Create a Service
                Service result = apiInstance.ApiReverseProxiesServicesPost(serviceRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServicesApi.ApiReverseProxiesServicesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiReverseProxiesServicesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a Service
    ApiResponse<Service> response = apiInstance.ApiReverseProxiesServicesPostWithHttpInfo(serviceRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ServicesApi.ApiReverseProxiesServicesPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **serviceRequest** | [**ServiceRequest?**](ServiceRequest?.md) | New service request | [optional]  |

### Return type

[**Service**](Service.md)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Service created |  -  |
| **400** | Bad Request |  -  |
| **401** | Requires authentication |  -  |
| **403** | Forbidden |  -  |
| **409** | Conflict |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apireverseproxiesservicesserviceiddelete"></a>
# **ApiReverseProxiesServicesServiceIdDelete**
> void ApiReverseProxiesServicesServiceIdDelete (string serviceId)

Delete a Service

Delete an existing service

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiReverseProxiesServicesServiceIdDeleteExample
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

            var apiInstance = new ServicesApi;
            var serviceId = "serviceId_example";  // string | The unique identifier of a service

            try
            {
                // Delete a Service
                apiInstance.ApiReverseProxiesServicesServiceIdDelete(serviceId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServicesApi.ApiReverseProxiesServicesServiceIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiReverseProxiesServicesServiceIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a Service
    apiInstance.ApiReverseProxiesServicesServiceIdDeleteWithHttpInfo(serviceId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ServicesApi.ApiReverseProxiesServicesServiceIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **serviceId** | **string** | The unique identifier of a service |  |

### Return type

void (empty response body)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Service deleted |  -  |
| **400** | Bad Request |  -  |
| **401** | Requires authentication |  -  |
| **403** | Forbidden |  -  |
| **404** | Resource not found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apireverseproxiesservicesserviceidget"></a>
# **ApiReverseProxiesServicesServiceIdGet**
> Service ApiReverseProxiesServicesServiceIdGet (string serviceId)

Retrieve a Service

Get information about a specific reverse proxy service

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiReverseProxiesServicesServiceIdGetExample
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

            var apiInstance = new ServicesApi;
            var serviceId = "serviceId_example";  // string | The unique identifier of a service

            try
            {
                // Retrieve a Service
                Service result = apiInstance.ApiReverseProxiesServicesServiceIdGet(serviceId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServicesApi.ApiReverseProxiesServicesServiceIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiReverseProxiesServicesServiceIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve a Service
    ApiResponse<Service> response = apiInstance.ApiReverseProxiesServicesServiceIdGetWithHttpInfo(serviceId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ServicesApi.ApiReverseProxiesServicesServiceIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **serviceId** | **string** | The unique identifier of a service |  |

### Return type

[**Service**](Service.md)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A service object |  -  |
| **400** | Bad Request |  -  |
| **401** | Requires authentication |  -  |
| **403** | Forbidden |  -  |
| **404** | Resource not found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apireverseproxiesservicesserviceidput"></a>
# **ApiReverseProxiesServicesServiceIdPut**
> Service ApiReverseProxiesServicesServiceIdPut (string serviceId, ServiceRequest? serviceRequest = null)

Update a Service

Update an existing service

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiReverseProxiesServicesServiceIdPutExample
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

            var apiInstance = new ServicesApi;
            var serviceId = "serviceId_example";  // string | The unique identifier of a service
            var serviceRequest = new ServiceRequest?(); // ServiceRequest? | Service update request (optional) 

            try
            {
                // Update a Service
                Service result = apiInstance.ApiReverseProxiesServicesServiceIdPut(serviceId, serviceRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServicesApi.ApiReverseProxiesServicesServiceIdPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiReverseProxiesServicesServiceIdPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a Service
    ApiResponse<Service> response = apiInstance.ApiReverseProxiesServicesServiceIdPutWithHttpInfo(serviceId, serviceRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ServicesApi.ApiReverseProxiesServicesServiceIdPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **serviceId** | **string** | The unique identifier of a service |  |
| **serviceRequest** | [**ServiceRequest?**](ServiceRequest?.md) | Service update request | [optional]  |

### Return type

[**Service**](Service.md)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Service updated |  -  |
| **400** | Bad Request |  -  |
| **401** | Requires authentication |  -  |
| **403** | Forbidden |  -  |
| **404** | Resource not found |  -  |
| **409** | Conflict |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

