# NetBird.ApiClient.Api.PoliciesApi

All URIs are relative to *https://api.netbird.io/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiPoliciesGet**](PoliciesApi.md#apipoliciesget) | **GET** policies | List all Policies |
| [**ApiPoliciesPolicyIdDelete**](PoliciesApi.md#apipoliciespolicyiddelete) | **DELETE** policies/{policyId} | Delete a Policy |
| [**ApiPoliciesPolicyIdGet**](PoliciesApi.md#apipoliciespolicyidget) | **GET** /api/policies/{policyId} | Retrieve a Policy |
| [**ApiPoliciesPolicyIdPut**](PoliciesApi.md#apipoliciespolicyidput) | **PUT** /api/policies/{policyId} | Update a Policy |
| [**ApiPoliciesPost**](PoliciesApi.md#apipoliciespost) | **POST** /api/policies | Create a Policy |

<a id="apipoliciesget"></a>
# **ApiPoliciesGet**
> List&lt;Policy&gt; ApiPoliciesGet ()

List all Policies

Returns a list of all policies

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiPoliciesGetExample
    {
        public static void Main()
        {
            
            NetBirdApiClientOptions c = new NetBirdApiClientOptions()
            {
                AccessToken = "nbp_XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                BaseUrl = "https://api.netbird.io/api"
            };
            var client = new NetBirdApiClient(c);

            var apiInstance = client.PoliciesApi;

            try
            {
                // List all Policies
                List<Policy> result = apiInstance.ApiPoliciesGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PoliciesApi.ApiPoliciesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiPoliciesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List all Policies
    ApiResponse<List<Policy>> response = apiInstance.ApiPoliciesGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PoliciesApi.ApiPoliciesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;Policy&gt;**](Policy.md)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A JSON Array of Policies |  -  |
| **400** | Bad Request |  -  |
| **401** | Requires authentication |  -  |
| **403** | Forbidden |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apipoliciespolicyiddelete"></a>
# **ApiPoliciesPolicyIdDelete**
> void ApiPoliciesPolicyIdDelete (string policyId)

Delete a Policy

Delete a policy

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiPoliciesPolicyIdDeleteExample
    {
        public static void Main()
        {
            
            NetBirdApiClientOptions c = new NetBirdApiClientOptions()
            {
                AccessToken = "nbp_XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                BaseUrl = "https://api.netbird.io/api"
            };
            var client = new NetBirdApiClient(c);

            var apiInstance = client.PoliciesApi;
            var policyId = "policyId_example";  // string | The unique identifier of a policy

            try
            {
                // Delete a Policy
                apiInstance.ApiPoliciesPolicyIdDelete(policyId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PoliciesApi.ApiPoliciesPolicyIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiPoliciesPolicyIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a Policy
    apiInstance.ApiPoliciesPolicyIdDeleteWithHttpInfo(policyId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PoliciesApi.ApiPoliciesPolicyIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **policyId** | **string** | The unique identifier of a policy |  |

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

<a id="apipoliciespolicyidget"></a>
# **ApiPoliciesPolicyIdGet**
> Policy ApiPoliciesPolicyIdGet (string policyId)

Retrieve a Policy

Get information about a Policies

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiPoliciesPolicyIdGetExample
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

            var apiInstance = new PoliciesApi;
            var policyId = "policyId_example";  // string | The unique identifier of a policy

            try
            {
                // Retrieve a Policy
                Policy result = apiInstance.ApiPoliciesPolicyIdGet(policyId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PoliciesApi.ApiPoliciesPolicyIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiPoliciesPolicyIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve a Policy
    ApiResponse<Policy> response = apiInstance.ApiPoliciesPolicyIdGetWithHttpInfo(policyId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PoliciesApi.ApiPoliciesPolicyIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **policyId** | **string** | The unique identifier of a policy |  |

### Return type

[**Policy**](Policy.md)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A Policy object |  -  |
| **400** | Bad Request |  -  |
| **401** | Requires authentication |  -  |
| **403** | Forbidden |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apipoliciespolicyidput"></a>
# **ApiPoliciesPolicyIdPut**
> Policy ApiPoliciesPolicyIdPut (string policyId, PolicyCreate? policyCreate = null)

Update a Policy

Update/Replace a Policy

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiPoliciesPolicyIdPutExample
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

            var apiInstance = new PoliciesApi;
            var policyId = "policyId_example";  // string | The unique identifier of a policy
            var policyCreate = new PolicyCreate?(); // PolicyCreate? | Update Policy request (optional) 

            try
            {
                // Update a Policy
                Policy result = apiInstance.ApiPoliciesPolicyIdPut(policyId, policyCreate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PoliciesApi.ApiPoliciesPolicyIdPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiPoliciesPolicyIdPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a Policy
    ApiResponse<Policy> response = apiInstance.ApiPoliciesPolicyIdPutWithHttpInfo(policyId, policyCreate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PoliciesApi.ApiPoliciesPolicyIdPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **policyId** | **string** | The unique identifier of a policy |  |
| **policyCreate** | [**PolicyCreate?**](PolicyCreate?.md) | Update Policy request | [optional]  |

### Return type

[**Policy**](Policy.md)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A Policy object |  -  |
| **400** | Bad Request |  -  |
| **401** | Requires authentication |  -  |
| **403** | Forbidden |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apipoliciespost"></a>
# **ApiPoliciesPost**
> Policy ApiPoliciesPost (PolicyUpdate? policyUpdate = null)

Create a Policy

Creates a policy

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiPoliciesPostExample
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

            var apiInstance = new PoliciesApi;
            var policyUpdate = new PolicyUpdate?(); // PolicyUpdate? | New Policy request (optional) 

            try
            {
                // Create a Policy
                Policy result = apiInstance.ApiPoliciesPost(policyUpdate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PoliciesApi.ApiPoliciesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiPoliciesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a Policy
    ApiResponse<Policy> response = apiInstance.ApiPoliciesPostWithHttpInfo(policyUpdate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PoliciesApi.ApiPoliciesPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **policyUpdate** | [**PolicyUpdate?**](PolicyUpdate?.md) | New Policy request | [optional]  |

### Return type

[**Policy**](Policy.md)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A Policy Object |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

