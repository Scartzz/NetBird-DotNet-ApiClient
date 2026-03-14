# NetBird.ApiClient.Api.IdentityProvidersApi

All URIs are relative to *https://api.netbird.io/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiIdentityProvidersGet**](IdentityProvidersApi.md#apiidentityprovidersget) | **GET** identity-providers | List all Identity Providers |
| [**ApiIdentityProvidersIdpIdDelete**](IdentityProvidersApi.md#apiidentityprovidersidpiddelete) | **DELETE** /api/identity-providers/{idpId} | Delete an Identity Provider |
| [**ApiIdentityProvidersIdpIdGet**](IdentityProvidersApi.md#apiidentityprovidersidpidget) | **GET** /api/identity-providers/{idpId} | Retrieve an Identity Provider |
| [**ApiIdentityProvidersIdpIdPut**](IdentityProvidersApi.md#apiidentityprovidersidpidput) | **PUT** /api/identity-providers/{idpId} | Update an Identity Provider |
| [**ApiIdentityProvidersPost**](IdentityProvidersApi.md#apiidentityproviderspost) | **POST** /api/identity-providers | Create an Identity Provider |

<a id="apiidentityprovidersget"></a>
# **ApiIdentityProvidersGet**
> List&lt;IdentityProvider&gt; ApiIdentityProvidersGet ()

List all Identity Providers

Returns a list of all identity providers configured for the account

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiIdentityProvidersGetExample
    {
        public static void Main()
        {
            
            NetBirdApiClientOptions c = new NetBirdApiClientOptions()
            {
                AccessToken = "nbp_XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                BaseUrl = "https://api.netbird.io/api"
            };
            var client = new NetBirdApiClient(c);

            var apiInstance = client.IdentityProvidersApi;

            try
            {
                // List all Identity Providers
                List<IdentityProvider> result = apiInstance.ApiIdentityProvidersGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IdentityProvidersApi.ApiIdentityProvidersGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiIdentityProvidersGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List all Identity Providers
    ApiResponse<List<IdentityProvider>> response = apiInstance.ApiIdentityProvidersGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IdentityProvidersApi.ApiIdentityProvidersGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;IdentityProvider&gt;**](IdentityProvider.md)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A JSON array of identity providers |  -  |
| **400** | Bad Request |  -  |
| **401** | Requires authentication |  -  |
| **403** | Forbidden |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiidentityprovidersidpiddelete"></a>
# **ApiIdentityProvidersIdpIdDelete**
> void ApiIdentityProvidersIdpIdDelete (string idpId)

Delete an Identity Provider

Delete an identity provider configuration

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiIdentityProvidersIdpIdDeleteExample
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

            var apiInstance = client.IdentityProvidersApi;
            var idpId = "idpId_example";  // string | The unique identifier of an identity provider

            try
            {
                // Delete an Identity Provider
                apiInstance.ApiIdentityProvidersIdpIdDelete(idpId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IdentityProvidersApi.ApiIdentityProvidersIdpIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiIdentityProvidersIdpIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete an Identity Provider
    apiInstance.ApiIdentityProvidersIdpIdDeleteWithHttpInfo(idpId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IdentityProvidersApi.ApiIdentityProvidersIdpIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **idpId** | **string** | The unique identifier of an identity provider |  |

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
| **200** | Delete status code |  -  |
| **400** | Bad Request |  -  |
| **401** | Requires authentication |  -  |
| **403** | Forbidden |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiidentityprovidersidpidget"></a>
# **ApiIdentityProvidersIdpIdGet**
> IdentityProvider ApiIdentityProvidersIdpIdGet (string idpId)

Retrieve an Identity Provider

Get information about a specific identity provider

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiIdentityProvidersIdpIdGetExample
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

            var apiInstance = new IdentityProvidersApi;
            var idpId = "idpId_example";  // string | The unique identifier of an identity provider

            try
            {
                // Retrieve an Identity Provider
                IdentityProvider result = apiInstance.ApiIdentityProvidersIdpIdGet(idpId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IdentityProvidersApi.ApiIdentityProvidersIdpIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiIdentityProvidersIdpIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve an Identity Provider
    ApiResponse<IdentityProvider> response = apiInstance.ApiIdentityProvidersIdpIdGetWithHttpInfo(idpId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IdentityProvidersApi.ApiIdentityProvidersIdpIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **idpId** | **string** | The unique identifier of an identity provider |  |

### Return type

[**IdentityProvider**](IdentityProvider.md)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | An Identity Provider object |  -  |
| **400** | Bad Request |  -  |
| **401** | Requires authentication |  -  |
| **403** | Forbidden |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiidentityprovidersidpidput"></a>
# **ApiIdentityProvidersIdpIdPut**
> IdentityProvider ApiIdentityProvidersIdpIdPut (string idpId, IdentityProviderRequest? identityProviderRequest = null)

Update an Identity Provider

Update an existing identity provider configuration

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiIdentityProvidersIdpIdPutExample
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

            var apiInstance = new IdentityProvidersApi;
            var idpId = "idpId_example";  // string | The unique identifier of an identity provider
            var identityProviderRequest = new IdentityProviderRequest?(); // IdentityProviderRequest? | Identity provider update (optional) 

            try
            {
                // Update an Identity Provider
                IdentityProvider result = apiInstance.ApiIdentityProvidersIdpIdPut(idpId, identityProviderRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IdentityProvidersApi.ApiIdentityProvidersIdpIdPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiIdentityProvidersIdpIdPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update an Identity Provider
    ApiResponse<IdentityProvider> response = apiInstance.ApiIdentityProvidersIdpIdPutWithHttpInfo(idpId, identityProviderRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IdentityProvidersApi.ApiIdentityProvidersIdpIdPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **idpId** | **string** | The unique identifier of an identity provider |  |
| **identityProviderRequest** | [**IdentityProviderRequest?**](IdentityProviderRequest?.md) | Identity provider update | [optional]  |

### Return type

[**IdentityProvider**](IdentityProvider.md)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | An Identity Provider object |  -  |
| **400** | Bad Request |  -  |
| **401** | Requires authentication |  -  |
| **403** | Forbidden |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiidentityproviderspost"></a>
# **ApiIdentityProvidersPost**
> IdentityProvider ApiIdentityProvidersPost (IdentityProviderRequest? identityProviderRequest = null)

Create an Identity Provider

Creates a new identity provider configuration

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiIdentityProvidersPostExample
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

            var apiInstance = new IdentityProvidersApi;
            var identityProviderRequest = new IdentityProviderRequest?(); // IdentityProviderRequest? | Identity provider configuration (optional) 

            try
            {
                // Create an Identity Provider
                IdentityProvider result = apiInstance.ApiIdentityProvidersPost(identityProviderRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IdentityProvidersApi.ApiIdentityProvidersPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiIdentityProvidersPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create an Identity Provider
    ApiResponse<IdentityProvider> response = apiInstance.ApiIdentityProvidersPostWithHttpInfo(identityProviderRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IdentityProvidersApi.ApiIdentityProvidersPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **identityProviderRequest** | [**IdentityProviderRequest?**](IdentityProviderRequest?.md) | Identity provider configuration | [optional]  |

### Return type

[**IdentityProvider**](IdentityProvider.md)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | An Identity Provider object |  -  |
| **400** | Bad Request |  -  |
| **401** | Requires authentication |  -  |
| **403** | Forbidden |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

