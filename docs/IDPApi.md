# NetBird.ApiClient.Api.IDPApi

All URIs are relative to *https://api.netbird.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateSCIMIntegration**](IDPApi.md#createscimintegration) | **POST** integrations/scim-idp | Create SCIM IDP Integration |
| [**DeleteSCIMIntegration**](IDPApi.md#deletescimintegration) | **DELETE** integrations/scim-idp/{id} | Delete SCIM IDP Integration |
| [**GetAllSCIMIntegrations**](IDPApi.md#getallscimintegrations) | **GET** integrations/scim-idp | Get All SCIM IDP Integrations |
| [**GetSCIMIntegration**](IDPApi.md#getscimintegration) | **GET** /api/integrations/scim-idp/{id} | Get SCIM IDP Integration |
| [**GetSCIMIntegrationLogs**](IDPApi.md#getscimintegrationlogs) | **GET** /api/integrations/scim-idp/{id}/logs | Get SCIM Integration Sync Logs |
| [**RegenerateSCIMToken**](IDPApi.md#regeneratescimtoken) | **POST** /api/integrations/scim-idp/{id}/token | Regenerate SCIM Token |
| [**UpdateSCIMIntegration**](IDPApi.md#updatescimintegration) | **PUT** /api/integrations/scim-idp/{id} | Update SCIM IDP Integration |

<a id="createscimintegration"></a>
# **CreateSCIMIntegration**
> ScimIntegration CreateSCIMIntegration (CreateScimIntegrationRequest createScimIntegrationRequest)

Create SCIM IDP Integration

Creates a new SCIM integration

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class CreateSCIMIntegrationExample
    {
        public static void Main()
        {
            
            NetBirdApiClientOptions c = new NetBirdApiClientOptions()
            {
                AccessToken = "nbp_XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                BaseUrl = "https://api.netbird.io/api"
            };
            var client = new NetBirdApiClient(c);

            var apiInstance = client.IDPApi;
            var createScimIntegrationRequest = new CreateScimIntegrationRequest(); // CreateScimIntegrationRequest | 

            try
            {
                // Create SCIM IDP Integration
                ScimIntegration result = apiInstance.CreateSCIMIntegration(createScimIntegrationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IDPApi.CreateSCIMIntegration: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateSCIMIntegrationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create SCIM IDP Integration
    ApiResponse<ScimIntegration> response = apiInstance.CreateSCIMIntegrationWithHttpInfo(createScimIntegrationRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IDPApi.CreateSCIMIntegrationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createScimIntegrationRequest** | [**CreateScimIntegrationRequest**](CreateScimIntegrationRequest.md) |  |  |

### Return type

[**ScimIntegration**](ScimIntegration.md)

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

<a id="deletescimintegration"></a>
# **DeleteSCIMIntegration**
> Object DeleteSCIMIntegration (string id)

Delete SCIM IDP Integration

Deletes an SCIM IDP integration by ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class DeleteSCIMIntegrationExample
    {
        public static void Main()
        {
            
            NetBirdApiClientOptions c = new NetBirdApiClientOptions()
            {
                AccessToken = "nbp_XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                BaseUrl = "https://api.netbird.io/api"
            };
            var client = new NetBirdApiClient(c);

            var apiInstance = client.IDPApi;
            var id = ch8i4ug6lnn4g9hqv7m0;  // string | The unique identifier of the SCIM IDP integration.

            try
            {
                // Delete SCIM IDP Integration
                Object result = apiInstance.DeleteSCIMIntegration(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IDPApi.DeleteSCIMIntegration: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteSCIMIntegrationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete SCIM IDP Integration
    ApiResponse<Object> response = apiInstance.DeleteSCIMIntegrationWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IDPApi.DeleteSCIMIntegrationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The unique identifier of the SCIM IDP integration. |  |

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

<a id="getallscimintegrations"></a>
# **GetAllSCIMIntegrations**
> List&lt;ScimIntegration&gt; GetAllSCIMIntegrations ()

Get All SCIM IDP Integrations

Retrieves all SCIM IDP integrations for the authenticated account

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class GetAllSCIMIntegrationsExample
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

            var apiInstance = client.IDPApi;

            try
            {
                // Get All SCIM IDP Integrations
                List<ScimIntegration> result = apiInstance.GetAllSCIMIntegrations();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IDPApi.GetAllSCIMIntegrations: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAllSCIMIntegrationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get All SCIM IDP Integrations
    ApiResponse<List<ScimIntegration>> response = apiInstance.GetAllSCIMIntegrationsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IDPApi.GetAllSCIMIntegrationsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;ScimIntegration&gt;**](ScimIntegration.md)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A list of SCIM IDP integrations. |  -  |
| **401** | Unauthorized. |  -  |
| **500** | Internal Server Error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getscimintegration"></a>
# **GetSCIMIntegration**
> ScimIntegration GetSCIMIntegration (string id)

Get SCIM IDP Integration

Retrieves an SCIM IDP integration by ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class GetSCIMIntegrationExample
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

            var apiInstance = new IDPApi;
            var id = ch8i4ug6lnn4g9hqv7m0;  // string | The unique identifier of the SCIM IDP integration.

            try
            {
                // Get SCIM IDP Integration
                ScimIntegration result = apiInstance.GetSCIMIntegration(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IDPApi.GetSCIMIntegration: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSCIMIntegrationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get SCIM IDP Integration
    ApiResponse<ScimIntegration> response = apiInstance.GetSCIMIntegrationWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IDPApi.GetSCIMIntegrationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The unique identifier of the SCIM IDP integration. |  |

### Return type

[**ScimIntegration**](ScimIntegration.md)

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

<a id="getscimintegrationlogs"></a>
# **GetSCIMIntegrationLogs**
> List&lt;IdpIntegrationSyncLog&gt; GetSCIMIntegrationLogs (string id)

Get SCIM Integration Sync Logs

Retrieves synchronization logs for a SCIM IDP integration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class GetSCIMIntegrationLogsExample
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

            var apiInstance = new IDPApi;
            var id = ch8i4ug6lnn4g9hqv7m0;  // string | The unique identifier of the SCIM IDP integration.

            try
            {
                // Get SCIM Integration Sync Logs
                List<IdpIntegrationSyncLog> result = apiInstance.GetSCIMIntegrationLogs(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IDPApi.GetSCIMIntegrationLogs: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSCIMIntegrationLogsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get SCIM Integration Sync Logs
    ApiResponse<List<IdpIntegrationSyncLog>> response = apiInstance.GetSCIMIntegrationLogsWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IDPApi.GetSCIMIntegrationLogsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The unique identifier of the SCIM IDP integration. |  |

### Return type

[**List&lt;IdpIntegrationSyncLog&gt;**](IdpIntegrationSyncLog.md)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved the integration sync logs. |  -  |
| **400** | Bad Request (e.g., invalid integration ID format). |  -  |
| **401** | Unauthorized. |  -  |
| **404** | Not Found. |  -  |
| **500** | Internal Server Error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="regeneratescimtoken"></a>
# **RegenerateSCIMToken**
> ScimTokenResponse RegenerateSCIMToken (string id)

Regenerate SCIM Token

Regenerates the SCIM API token for an SCIM IDP integration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class RegenerateSCIMTokenExample
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

            var apiInstance = new IDPApi;
            var id = ch8i4ug6lnn4g9hqv7m0;  // string | The unique identifier of the SCIM IDP integration.

            try
            {
                // Regenerate SCIM Token
                ScimTokenResponse result = apiInstance.RegenerateSCIMToken(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IDPApi.RegenerateSCIMToken: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RegenerateSCIMTokenWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Regenerate SCIM Token
    ApiResponse<ScimTokenResponse> response = apiInstance.RegenerateSCIMTokenWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IDPApi.RegenerateSCIMTokenWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The unique identifier of the SCIM IDP integration. |  |

### Return type

[**ScimTokenResponse**](ScimTokenResponse.md)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Token regenerated successfully. Returns the new token. |  -  |
| **400** | Bad Request (e.g., invalid integration ID format). |  -  |
| **401** | Unauthorized. |  -  |
| **404** | Not Found. |  -  |
| **500** | Internal Server Error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatescimintegration"></a>
# **UpdateSCIMIntegration**
> ScimIntegration UpdateSCIMIntegration (string id, UpdateScimIntegrationRequest updateScimIntegrationRequest)

Update SCIM IDP Integration

Updates an existing SCIM IDP Integration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class UpdateSCIMIntegrationExample
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

            var apiInstance = new IDPApi;
            var id = ch8i4ug6lnn4g9hqv7m0;  // string | The unique identifier of the SCIM IDP integration.
            var updateScimIntegrationRequest = new UpdateScimIntegrationRequest(); // UpdateScimIntegrationRequest | 

            try
            {
                // Update SCIM IDP Integration
                ScimIntegration result = apiInstance.UpdateSCIMIntegration(id, updateScimIntegrationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IDPApi.UpdateSCIMIntegration: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateSCIMIntegrationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update SCIM IDP Integration
    ApiResponse<ScimIntegration> response = apiInstance.UpdateSCIMIntegrationWithHttpInfo(id, updateScimIntegrationRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IDPApi.UpdateSCIMIntegrationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The unique identifier of the SCIM IDP integration. |  |
| **updateScimIntegrationRequest** | [**UpdateScimIntegrationRequest**](UpdateScimIntegrationRequest.md) |  |  |

### Return type

[**ScimIntegration**](ScimIntegration.md)

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

