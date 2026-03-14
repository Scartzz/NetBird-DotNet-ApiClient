# NetBird.ApiClient.Api.MSPApi

All URIs are relative to *https://api.netbird.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiIntegrationsMspTenantsGet**](MSPApi.md#apiintegrationsmsptenantsget) | **GET** integrations/msp/tenants | Get MSP tenants |
| [**ApiIntegrationsMspTenantsIdDnsPost**](MSPApi.md#apiintegrationsmsptenantsiddnspost) | **POST** integrations/msp/tenants/{id}/dns | Verify a tenant domain DNS challenge |
| [**ApiIntegrationsMspTenantsIdInvitePost**](MSPApi.md#apiintegrationsmsptenantsidinvitepost) | **POST** /api/integrations/msp/tenants/{id}/invite | Invite existing account as a Tenant to the MSP account |
| [**ApiIntegrationsMspTenantsIdInvitePut**](MSPApi.md#apiintegrationsmsptenantsidinviteput) | **PUT** /api/integrations/msp/tenants/{id}/invite | Response by the invited Tenant account owner |
| [**ApiIntegrationsMspTenantsIdPut**](MSPApi.md#apiintegrationsmsptenantsidput) | **PUT** /api/integrations/msp/tenants/{id} | Update MSP tenant |
| [**ApiIntegrationsMspTenantsIdSubscriptionPost**](MSPApi.md#apiintegrationsmsptenantsidsubscriptionpost) | **POST** /api/integrations/msp/tenants/{id}/subscription | Create subscription for Tenant |
| [**ApiIntegrationsMspTenantsIdUnlinkPost**](MSPApi.md#apiintegrationsmsptenantsidunlinkpost) | **POST** /api/integrations/msp/tenants/{id}/unlink | Unlink a tenant |
| [**ApiIntegrationsMspTenantsPost**](MSPApi.md#apiintegrationsmsptenantspost) | **POST** /api/integrations/msp/tenants | Create MSP tenant |

<a id="apiintegrationsmsptenantsget"></a>
# **ApiIntegrationsMspTenantsGet**
> List&lt;TenantResponse&gt; ApiIntegrationsMspTenantsGet ()

Get MSP tenants

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiIntegrationsMspTenantsGetExample
    {
        public static void Main()
        {
            
            NetBirdApiClientOptions c = new NetBirdApiClientOptions()
            {
                AccessToken = "nbp_XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                BaseUrl = "https://api.netbird.io/api"
            };
            var client = new NetBirdApiClient(c);

            var apiInstance = client.MSPApi;

            try
            {
                // Get MSP tenants
                List<TenantResponse> result = apiInstance.ApiIntegrationsMspTenantsGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MSPApi.ApiIntegrationsMspTenantsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiIntegrationsMspTenantsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get MSP tenants
    ApiResponse<List<TenantResponse>> response = apiInstance.ApiIntegrationsMspTenantsGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MSPApi.ApiIntegrationsMspTenantsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;TenantResponse&gt;**](TenantResponse.md)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Get MSP tenants response |  -  |
| **400** | Bad Request |  -  |
| **403** | Requires authentication |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiintegrationsmsptenantsiddnspost"></a>
# **ApiIntegrationsMspTenantsIdDnsPost**
> void ApiIntegrationsMspTenantsIdDnsPost (string id)

Verify a tenant domain DNS challenge

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiIntegrationsMspTenantsIdDnsPostExample
    {
        public static void Main()
        {
            
            NetBirdApiClientOptions c = new NetBirdApiClientOptions()
            {
                AccessToken = "nbp_XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                BaseUrl = "https://api.netbird.io/api"
            };
            var client = new NetBirdApiClient(c);

            var apiInstance = client.MSPApi;
            var id = "id_example";  // string | The unique identifier of a tenant account

            try
            {
                // Verify a tenant domain DNS challenge
                apiInstance.ApiIntegrationsMspTenantsIdDnsPost(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MSPApi.ApiIntegrationsMspTenantsIdDnsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiIntegrationsMspTenantsIdDnsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Verify a tenant domain DNS challenge
    apiInstance.ApiIntegrationsMspTenantsIdDnsPostWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MSPApi.ApiIntegrationsMspTenantsIdDnsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The unique identifier of a tenant account |  |

### Return type

void (empty response body)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully verified the DNS challenge |  -  |
| **400** | Bad Request |  -  |
| **403** | Requires authentication |  -  |
| **404** | The tenant was not found |  -  |
| **500** | Internal Server Error |  -  |
| **501** | DNS Challenge Failed Response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiintegrationsmsptenantsidinvitepost"></a>
# **ApiIntegrationsMspTenantsIdInvitePost**
> TenantResponse ApiIntegrationsMspTenantsIdInvitePost (string id)

Invite existing account as a Tenant to the MSP account

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiIntegrationsMspTenantsIdInvitePostExample
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

            var apiInstance = new MSPApi;
            var id = "id_example";  // string | The unique identifier of an existing tenant account

            try
            {
                // Invite existing account as a Tenant to the MSP account
                TenantResponse result = apiInstance.ApiIntegrationsMspTenantsIdInvitePost(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MSPApi.ApiIntegrationsMspTenantsIdInvitePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiIntegrationsMspTenantsIdInvitePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Invite existing account as a Tenant to the MSP account
    ApiResponse<TenantResponse> response = apiInstance.ApiIntegrationsMspTenantsIdInvitePostWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MSPApi.ApiIntegrationsMspTenantsIdInvitePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The unique identifier of an existing tenant account |  |

### Return type

[**TenantResponse**](TenantResponse.md)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully invited existing Tenant to the MSP account |  -  |
| **400** | Bad Request |  -  |
| **403** | Requires authentication |  -  |
| **404** | The tenant was not found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiintegrationsmsptenantsidinviteput"></a>
# **ApiIntegrationsMspTenantsIdInvitePut**
> void ApiIntegrationsMspTenantsIdInvitePut (string id, ApiIntegrationsMspTenantsIdInvitePutRequest apiIntegrationsMspTenantsIdInvitePutRequest)

Response by the invited Tenant account owner

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiIntegrationsMspTenantsIdInvitePutExample
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

            var apiInstance = new MSPApi;
            var id = "id_example";  // string | The unique identifier of an existing tenant account
            var apiIntegrationsMspTenantsIdInvitePutRequest = new ApiIntegrationsMspTenantsIdInvitePutRequest(); // ApiIntegrationsMspTenantsIdInvitePutRequest | 

            try
            {
                // Response by the invited Tenant account owner
                apiInstance.ApiIntegrationsMspTenantsIdInvitePut(id, apiIntegrationsMspTenantsIdInvitePutRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MSPApi.ApiIntegrationsMspTenantsIdInvitePut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiIntegrationsMspTenantsIdInvitePutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Response by the invited Tenant account owner
    apiInstance.ApiIntegrationsMspTenantsIdInvitePutWithHttpInfo(id, apiIntegrationsMspTenantsIdInvitePutRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MSPApi.ApiIntegrationsMspTenantsIdInvitePutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The unique identifier of an existing tenant account |  |
| **apiIntegrationsMspTenantsIdInvitePutRequest** | [**ApiIntegrationsMspTenantsIdInvitePutRequest**](ApiIntegrationsMspTenantsIdInvitePutRequest.md) |  |  |

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
| **200** | Successful response |  -  |
| **400** | Bad Request |  -  |
| **403** | Requires authentication |  -  |
| **404** | The tenant was not found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiintegrationsmsptenantsidput"></a>
# **ApiIntegrationsMspTenantsIdPut**
> TenantResponse ApiIntegrationsMspTenantsIdPut (string id, UpdateTenantRequest updateTenantRequest)

Update MSP tenant

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiIntegrationsMspTenantsIdPutExample
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

            var apiInstance = new MSPApi;
            var id = "id_example";  // string | The unique identifier of a tenant account
            var updateTenantRequest = new UpdateTenantRequest(); // UpdateTenantRequest | 

            try
            {
                // Update MSP tenant
                TenantResponse result = apiInstance.ApiIntegrationsMspTenantsIdPut(id, updateTenantRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MSPApi.ApiIntegrationsMspTenantsIdPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiIntegrationsMspTenantsIdPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update MSP tenant
    ApiResponse<TenantResponse> response = apiInstance.ApiIntegrationsMspTenantsIdPutWithHttpInfo(id, updateTenantRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MSPApi.ApiIntegrationsMspTenantsIdPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The unique identifier of a tenant account |  |
| **updateTenantRequest** | [**UpdateTenantRequest**](UpdateTenantRequest.md) |  |  |

### Return type

[**TenantResponse**](TenantResponse.md)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Update MSP tenant Response |  -  |
| **400** | Bad Request |  -  |
| **403** | Requires authentication |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiintegrationsmsptenantsidsubscriptionpost"></a>
# **ApiIntegrationsMspTenantsIdSubscriptionPost**
> void ApiIntegrationsMspTenantsIdSubscriptionPost (string id, ApiIntegrationsMspTenantsIdSubscriptionPostRequest apiIntegrationsMspTenantsIdSubscriptionPostRequest)

Create subscription for Tenant

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiIntegrationsMspTenantsIdSubscriptionPostExample
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

            var apiInstance = new MSPApi;
            var id = "id_example";  // string | The unique identifier of a tenant account
            var apiIntegrationsMspTenantsIdSubscriptionPostRequest = new ApiIntegrationsMspTenantsIdSubscriptionPostRequest(); // ApiIntegrationsMspTenantsIdSubscriptionPostRequest | 

            try
            {
                // Create subscription for Tenant
                apiInstance.ApiIntegrationsMspTenantsIdSubscriptionPost(id, apiIntegrationsMspTenantsIdSubscriptionPostRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MSPApi.ApiIntegrationsMspTenantsIdSubscriptionPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiIntegrationsMspTenantsIdSubscriptionPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create subscription for Tenant
    apiInstance.ApiIntegrationsMspTenantsIdSubscriptionPostWithHttpInfo(id, apiIntegrationsMspTenantsIdSubscriptionPostRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MSPApi.ApiIntegrationsMspTenantsIdSubscriptionPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The unique identifier of a tenant account |  |
| **apiIntegrationsMspTenantsIdSubscriptionPostRequest** | [**ApiIntegrationsMspTenantsIdSubscriptionPostRequest**](ApiIntegrationsMspTenantsIdSubscriptionPostRequest.md) |  |  |

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
| **200** | Successfully created subscription for Tenant |  -  |
| **400** | Bad Request |  -  |
| **403** | Requires authentication |  -  |
| **404** | The tenant was not found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiintegrationsmsptenantsidunlinkpost"></a>
# **ApiIntegrationsMspTenantsIdUnlinkPost**
> void ApiIntegrationsMspTenantsIdUnlinkPost (string id, ApiIntegrationsMspTenantsIdUnlinkPostRequest apiIntegrationsMspTenantsIdUnlinkPostRequest)

Unlink a tenant

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiIntegrationsMspTenantsIdUnlinkPostExample
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

            var apiInstance = new MSPApi;
            var id = "id_example";  // string | The unique identifier of a tenant account
            var apiIntegrationsMspTenantsIdUnlinkPostRequest = new ApiIntegrationsMspTenantsIdUnlinkPostRequest(); // ApiIntegrationsMspTenantsIdUnlinkPostRequest | 

            try
            {
                // Unlink a tenant
                apiInstance.ApiIntegrationsMspTenantsIdUnlinkPost(id, apiIntegrationsMspTenantsIdUnlinkPostRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MSPApi.ApiIntegrationsMspTenantsIdUnlinkPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiIntegrationsMspTenantsIdUnlinkPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Unlink a tenant
    apiInstance.ApiIntegrationsMspTenantsIdUnlinkPostWithHttpInfo(id, apiIntegrationsMspTenantsIdUnlinkPostRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MSPApi.ApiIntegrationsMspTenantsIdUnlinkPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The unique identifier of a tenant account |  |
| **apiIntegrationsMspTenantsIdUnlinkPostRequest** | [**ApiIntegrationsMspTenantsIdUnlinkPostRequest**](ApiIntegrationsMspTenantsIdUnlinkPostRequest.md) |  |  |

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
| **200** | Successfully unlinked the tenant |  -  |
| **400** | Bad Request |  -  |
| **403** | Requires authentication |  -  |
| **404** | The tenant was not found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiintegrationsmsptenantspost"></a>
# **ApiIntegrationsMspTenantsPost**
> TenantResponse ApiIntegrationsMspTenantsPost (CreateTenantRequest createTenantRequest)

Create MSP tenant

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiIntegrationsMspTenantsPostExample
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

            var apiInstance = new MSPApi;
            var createTenantRequest = new CreateTenantRequest(); // CreateTenantRequest | 

            try
            {
                // Create MSP tenant
                TenantResponse result = apiInstance.ApiIntegrationsMspTenantsPost(createTenantRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MSPApi.ApiIntegrationsMspTenantsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiIntegrationsMspTenantsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create MSP tenant
    ApiResponse<TenantResponse> response = apiInstance.ApiIntegrationsMspTenantsPostWithHttpInfo(createTenantRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MSPApi.ApiIntegrationsMspTenantsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createTenantRequest** | [**CreateTenantRequest**](CreateTenantRequest.md) |  |  |

### Return type

[**TenantResponse**](TenantResponse.md)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Create MSP tenant Response |  -  |
| **400** | Bad Request |  -  |
| **403** | Requires authentication |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

