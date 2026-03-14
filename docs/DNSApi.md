# NetBird.ApiClient.Api.DNSApi

All URIs are relative to *https://api.netbird.io/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiDnsNameserversGet**](DNSApi.md#apidnsnameserversget) | **GET** dns/nameservers | List all Nameserver Groups |
| [**ApiDnsNameserversNsgroupIdDelete**](DNSApi.md#apidnsnameserversnsgroupiddelete) | **DELETE** dns/nameservers/{nsgroupId} | Delete a Nameserver Group |
| [**ApiDnsNameserversNsgroupIdGet**](DNSApi.md#apidnsnameserversnsgroupidget) | **GET** dns/nameservers/{nsgroupId} | Retrieve a Nameserver Group |
| [**ApiDnsNameserversNsgroupIdPut**](DNSApi.md#apidnsnameserversnsgroupidput) | **PUT** /api/dns/nameservers/{nsgroupId} | Update a Nameserver Group |
| [**ApiDnsNameserversPost**](DNSApi.md#apidnsnameserverspost) | **POST** /api/dns/nameservers | Create a Nameserver Group |
| [**ApiDnsSettingsGet**](DNSApi.md#apidnssettingsget) | **GET** /api/dns/settings | Retrieve DNS settings |
| [**ApiDnsSettingsPut**](DNSApi.md#apidnssettingsput) | **PUT** /api/dns/settings | Update DNS Settings |

<a id="apidnsnameserversget"></a>
# **ApiDnsNameserversGet**
> List&lt;NameserverGroup&gt; ApiDnsNameserversGet ()

List all Nameserver Groups

Returns a list of all Nameserver Groups

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiDnsNameserversGetExample
    {
        public static void Main()
        {
            
            NetBirdApiClientOptions c = new NetBirdApiClientOptions()
            {
                AccessToken = "nbp_XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                BaseUrl = "https://api.netbird.io/api"
            };
            var client = new NetBirdApiClient(c);

            var apiInstance = client.DNSApi;

            try
            {
                // List all Nameserver Groups
                List<NameserverGroup> result = apiInstance.ApiDnsNameserversGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DNSApi.ApiDnsNameserversGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiDnsNameserversGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List all Nameserver Groups
    ApiResponse<List<NameserverGroup>> response = apiInstance.ApiDnsNameserversGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DNSApi.ApiDnsNameserversGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;NameserverGroup&gt;**](NameserverGroup.md)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A JSON Array of Nameserver Groups |  -  |
| **400** | Bad Request |  -  |
| **401** | Requires authentication |  -  |
| **403** | Forbidden |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apidnsnameserversnsgroupiddelete"></a>
# **ApiDnsNameserversNsgroupIdDelete**
> void ApiDnsNameserversNsgroupIdDelete (string nsgroupId)

Delete a Nameserver Group

Delete a Nameserver Group

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiDnsNameserversNsgroupIdDeleteExample
    {
        public static void Main()
        {
            
            NetBirdApiClientOptions c = new NetBirdApiClientOptions()
            {
                AccessToken = "nbp_XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                BaseUrl = "https://api.netbird.io/api"
            };
            var client = new NetBirdApiClient(c);

            var apiInstance = client.DNSApi;
            var nsgroupId = "nsgroupId_example";  // string | The unique identifier of a Nameserver Group

            try
            {
                // Delete a Nameserver Group
                apiInstance.ApiDnsNameserversNsgroupIdDelete(nsgroupId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DNSApi.ApiDnsNameserversNsgroupIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiDnsNameserversNsgroupIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a Nameserver Group
    apiInstance.ApiDnsNameserversNsgroupIdDeleteWithHttpInfo(nsgroupId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DNSApi.ApiDnsNameserversNsgroupIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **nsgroupId** | **string** | The unique identifier of a Nameserver Group |  |

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

<a id="apidnsnameserversnsgroupidget"></a>
# **ApiDnsNameserversNsgroupIdGet**
> NameserverGroup ApiDnsNameserversNsgroupIdGet (string nsgroupId)

Retrieve a Nameserver Group

Get information about a Nameserver Groups

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiDnsNameserversNsgroupIdGetExample
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

            var apiInstance = client.DNSApi;
            var nsgroupId = "nsgroupId_example";  // string | The unique identifier of a Nameserver Group

            try
            {
                // Retrieve a Nameserver Group
                NameserverGroup result = apiInstance.ApiDnsNameserversNsgroupIdGet(nsgroupId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DNSApi.ApiDnsNameserversNsgroupIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiDnsNameserversNsgroupIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve a Nameserver Group
    ApiResponse<NameserverGroup> response = apiInstance.ApiDnsNameserversNsgroupIdGetWithHttpInfo(nsgroupId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DNSApi.ApiDnsNameserversNsgroupIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **nsgroupId** | **string** | The unique identifier of a Nameserver Group |  |

### Return type

[**NameserverGroup**](NameserverGroup.md)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A Nameserver Group object |  -  |
| **400** | Bad Request |  -  |
| **401** | Requires authentication |  -  |
| **403** | Forbidden |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apidnsnameserversnsgroupidput"></a>
# **ApiDnsNameserversNsgroupIdPut**
> NameserverGroup ApiDnsNameserversNsgroupIdPut (string nsgroupId, NameserverGroupRequest? nameserverGroupRequest = null)

Update a Nameserver Group

Update/Replace a Nameserver Group

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiDnsNameserversNsgroupIdPutExample
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

            var apiInstance = client.DNSApi;
            var nsgroupId = "nsgroupId_example";  // string | The unique identifier of a Nameserver Group
            var nameserverGroupRequest = new NameserverGroupRequest?(); // NameserverGroupRequest? | Update Nameserver Group request (optional) 

            try
            {
                // Update a Nameserver Group
                NameserverGroup result = apiInstance.ApiDnsNameserversNsgroupIdPut(nsgroupId, nameserverGroupRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DNSApi.ApiDnsNameserversNsgroupIdPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiDnsNameserversNsgroupIdPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a Nameserver Group
    ApiResponse<NameserverGroup> response = apiInstance.ApiDnsNameserversNsgroupIdPutWithHttpInfo(nsgroupId, nameserverGroupRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DNSApi.ApiDnsNameserversNsgroupIdPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **nsgroupId** | **string** | The unique identifier of a Nameserver Group |  |
| **nameserverGroupRequest** | [**NameserverGroupRequest?**](NameserverGroupRequest?.md) | Update Nameserver Group request | [optional]  |

### Return type

[**NameserverGroup**](NameserverGroup.md)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A Nameserver Group object |  -  |
| **400** | Bad Request |  -  |
| **401** | Requires authentication |  -  |
| **403** | Forbidden |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apidnsnameserverspost"></a>
# **ApiDnsNameserversPost**
> NameserverGroup ApiDnsNameserversPost (NameserverGroupRequest? nameserverGroupRequest = null)

Create a Nameserver Group

Creates a Nameserver Group

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiDnsNameserversPostExample
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

            var apiInstance = new DNSApi;
            var nameserverGroupRequest = new NameserverGroupRequest?(); // NameserverGroupRequest? | New Nameserver Groups request (optional) 

            try
            {
                // Create a Nameserver Group
                NameserverGroup result = apiInstance.ApiDnsNameserversPost(nameserverGroupRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DNSApi.ApiDnsNameserversPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiDnsNameserversPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a Nameserver Group
    ApiResponse<NameserverGroup> response = apiInstance.ApiDnsNameserversPostWithHttpInfo(nameserverGroupRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DNSApi.ApiDnsNameserversPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **nameserverGroupRequest** | [**NameserverGroupRequest?**](NameserverGroupRequest?.md) | New Nameserver Groups request | [optional]  |

### Return type

[**NameserverGroup**](NameserverGroup.md)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A Nameserver Groups Object |  -  |
| **400** | Bad Request |  -  |
| **401** | Requires authentication |  -  |
| **403** | Forbidden |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apidnssettingsget"></a>
# **ApiDnsSettingsGet**
> Object ApiDnsSettingsGet ()

Retrieve DNS settings

Returns a DNS settings object

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiDnsSettingsGetExample
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

            var apiInstance = new DNSApi;

            try
            {
                // Retrieve DNS settings
                Object result = apiInstance.ApiDnsSettingsGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DNSApi.ApiDnsSettingsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiDnsSettingsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve DNS settings
    ApiResponse<Object> response = apiInstance.ApiDnsSettingsGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DNSApi.ApiDnsSettingsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
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
| **200** | A JSON Object of DNS Setting |  -  |
| **400** | Bad Request |  -  |
| **401** | Requires authentication |  -  |
| **403** | Forbidden |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apidnssettingsput"></a>
# **ApiDnsSettingsPut**
> DNSSettings ApiDnsSettingsPut (DNSSettings? dNSSettings = null)

Update DNS Settings

Updates a DNS settings object

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiDnsSettingsPutExample
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

            var apiInstance = new DNSApi;
            var dNSSettings = new DNSSettings?(); // DNSSettings? | A DNS settings object (optional) 

            try
            {
                // Update DNS Settings
                DNSSettings result = apiInstance.ApiDnsSettingsPut(dNSSettings);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DNSApi.ApiDnsSettingsPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiDnsSettingsPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update DNS Settings
    ApiResponse<DNSSettings> response = apiInstance.ApiDnsSettingsPutWithHttpInfo(dNSSettings);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DNSApi.ApiDnsSettingsPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dNSSettings** | [**DNSSettings?**](DNSSettings?.md) | A DNS settings object | [optional]  |

### Return type

[**DNSSettings**](DNSSettings.md)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A JSON Object of DNS Setting |  -  |
| **400** | Bad Request |  -  |
| **401** | Requires authentication |  -  |
| **403** | Forbidden |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

