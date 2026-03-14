# NetBird.ApiClient.Api.DNSZonesApi

All URIs are relative to *https://api.netbird.io/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiDnsZonesGet**](DNSZonesApi.md#apidnszonesget) | **GET** dns/zones | List all DNS Zones |
| [**ApiDnsZonesPost**](DNSZonesApi.md#apidnszonespost) | **POST** dns/zones | Create a DNS Zone |
| [**ApiDnsZonesZoneIdDelete**](DNSZonesApi.md#apidnszoneszoneiddelete) | **DELETE** /api/dns/zones/{zoneId} | Delete a DNS Zone |
| [**ApiDnsZonesZoneIdGet**](DNSZonesApi.md#apidnszoneszoneidget) | **GET** /api/dns/zones/{zoneId} | Retrieve a DNS Zone |
| [**ApiDnsZonesZoneIdPut**](DNSZonesApi.md#apidnszoneszoneidput) | **PUT** /api/dns/zones/{zoneId} | Update a DNS Zone |
| [**ApiDnsZonesZoneIdRecordsGet**](DNSZonesApi.md#apidnszoneszoneidrecordsget) | **GET** /api/dns/zones/{zoneId}/records | List all DNS Records |
| [**ApiDnsZonesZoneIdRecordsPost**](DNSZonesApi.md#apidnszoneszoneidrecordspost) | **POST** /api/dns/zones/{zoneId}/records | Create a DNS Record |
| [**ApiDnsZonesZoneIdRecordsRecordIdDelete**](DNSZonesApi.md#apidnszoneszoneidrecordsrecordiddelete) | **DELETE** /api/dns/zones/{zoneId}/records/{recordId} | Delete a DNS Record |
| [**ApiDnsZonesZoneIdRecordsRecordIdGet**](DNSZonesApi.md#apidnszoneszoneidrecordsrecordidget) | **GET** /api/dns/zones/{zoneId}/records/{recordId} | Retrieve a DNS Record |
| [**ApiDnsZonesZoneIdRecordsRecordIdPut**](DNSZonesApi.md#apidnszoneszoneidrecordsrecordidput) | **PUT** /api/dns/zones/{zoneId}/records/{recordId} | Update a DNS Record |

<a id="apidnszonesget"></a>
# **ApiDnsZonesGet**
> List&lt;Zone&gt; ApiDnsZonesGet ()

List all DNS Zones

Returns a list of all custom DNS zones

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiDnsZonesGetExample
    {
        public static void Main()
        {
            
            NetBirdApiClientOptions c = new NetBirdApiClientOptions()
            {
                AccessToken = "nbp_XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                BaseUrl = "https://api.netbird.io/api"
            };
            var client = new NetBirdApiClient(c);

            var apiInstance = client.DNSZonesApi;

            try
            {
                // List all DNS Zones
                List<Zone> result = apiInstance.ApiDnsZonesGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DNSZonesApi.ApiDnsZonesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiDnsZonesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List all DNS Zones
    ApiResponse<List<Zone>> response = apiInstance.ApiDnsZonesGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DNSZonesApi.ApiDnsZonesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;Zone&gt;**](Zone.md)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A JSON Array of DNS Zones |  -  |
| **401** | Requires authentication |  -  |
| **403** | Forbidden |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apidnszonespost"></a>
# **ApiDnsZonesPost**
> Zone ApiDnsZonesPost (ZoneRequest? zoneRequest = null)

Create a DNS Zone

Creates a new custom DNS zone

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiDnsZonesPostExample
    {
        public static void Main()
        {
            
            NetBirdApiClientOptions c = new NetBirdApiClientOptions()
            {
                AccessToken = "nbp_XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                BaseUrl = "https://api.netbird.io/api"
            };
            var client = new NetBirdApiClient(c);

            var apiInstance = client.DNSZonesApi;
            var zoneRequest = new ZoneRequest?(); // ZoneRequest? | A DNS zone object (optional) 

            try
            {
                // Create a DNS Zone
                Zone result = apiInstance.ApiDnsZonesPost(zoneRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DNSZonesApi.ApiDnsZonesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiDnsZonesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a DNS Zone
    ApiResponse<Zone> response = apiInstance.ApiDnsZonesPostWithHttpInfo(zoneRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DNSZonesApi.ApiDnsZonesPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **zoneRequest** | [**ZoneRequest?**](ZoneRequest?.md) | A DNS zone object | [optional]  |

### Return type

[**Zone**](Zone.md)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A JSON Object of the created DNS Zone |  -  |
| **400** | Bad Request |  -  |
| **401** | Requires authentication |  -  |
| **403** | Forbidden |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apidnszoneszoneiddelete"></a>
# **ApiDnsZonesZoneIdDelete**
> void ApiDnsZonesZoneIdDelete (string zoneId)

Delete a DNS Zone

Deletes a custom DNS zone

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiDnsZonesZoneIdDeleteExample
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

            var apiInstance = new DNSZonesApi;
            var zoneId = chacbco6lnnbn6cg5s91;  // string | The unique identifier of a zone

            try
            {
                // Delete a DNS Zone
                apiInstance.ApiDnsZonesZoneIdDelete(zoneId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DNSZonesApi.ApiDnsZonesZoneIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiDnsZonesZoneIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a DNS Zone
    apiInstance.ApiDnsZonesZoneIdDeleteWithHttpInfo(zoneId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DNSZonesApi.ApiDnsZonesZoneIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **zoneId** | **string** | The unique identifier of a zone |  |

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
| **200** | Zone deletion successful |  -  |
| **400** | Bad Request |  -  |
| **401** | Requires authentication |  -  |
| **403** | Forbidden |  -  |
| **404** | Resource not found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apidnszoneszoneidget"></a>
# **ApiDnsZonesZoneIdGet**
> Zone ApiDnsZonesZoneIdGet (string zoneId)

Retrieve a DNS Zone

Returns information about a specific DNS zone

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiDnsZonesZoneIdGetExample
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

            var apiInstance = new DNSZonesApi;
            var zoneId = chacbco6lnnbn6cg5s91;  // string | The unique identifier of a zone

            try
            {
                // Retrieve a DNS Zone
                Zone result = apiInstance.ApiDnsZonesZoneIdGet(zoneId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DNSZonesApi.ApiDnsZonesZoneIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiDnsZonesZoneIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve a DNS Zone
    ApiResponse<Zone> response = apiInstance.ApiDnsZonesZoneIdGetWithHttpInfo(zoneId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DNSZonesApi.ApiDnsZonesZoneIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **zoneId** | **string** | The unique identifier of a zone |  |

### Return type

[**Zone**](Zone.md)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A JSON Object of a DNS Zone |  -  |
| **400** | Bad Request |  -  |
| **401** | Requires authentication |  -  |
| **403** | Forbidden |  -  |
| **404** | Resource not found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apidnszoneszoneidput"></a>
# **ApiDnsZonesZoneIdPut**
> Zone ApiDnsZonesZoneIdPut (string zoneId, ZoneRequest? zoneRequest = null)

Update a DNS Zone

Updates a custom DNS zone

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiDnsZonesZoneIdPutExample
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

            var apiInstance = new DNSZonesApi;
            var zoneId = chacbco6lnnbn6cg5s91;  // string | The unique identifier of a zone
            var zoneRequest = new ZoneRequest?(); // ZoneRequest? | A DNS zone object (optional) 

            try
            {
                // Update a DNS Zone
                Zone result = apiInstance.ApiDnsZonesZoneIdPut(zoneId, zoneRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DNSZonesApi.ApiDnsZonesZoneIdPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiDnsZonesZoneIdPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a DNS Zone
    ApiResponse<Zone> response = apiInstance.ApiDnsZonesZoneIdPutWithHttpInfo(zoneId, zoneRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DNSZonesApi.ApiDnsZonesZoneIdPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **zoneId** | **string** | The unique identifier of a zone |  |
| **zoneRequest** | [**ZoneRequest?**](ZoneRequest?.md) | A DNS zone object | [optional]  |

### Return type

[**Zone**](Zone.md)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A JSON Object of the updated DNS Zone |  -  |
| **400** | Bad Request |  -  |
| **401** | Requires authentication |  -  |
| **403** | Forbidden |  -  |
| **404** | Resource not found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apidnszoneszoneidrecordsget"></a>
# **ApiDnsZonesZoneIdRecordsGet**
> List&lt;DNSRecord&gt; ApiDnsZonesZoneIdRecordsGet (string zoneId)

List all DNS Records

Returns a list of all DNS records in a zone

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiDnsZonesZoneIdRecordsGetExample
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

            var apiInstance = new DNSZonesApi;
            var zoneId = chacbco6lnnbn6cg5s91;  // string | The unique identifier of a zone

            try
            {
                // List all DNS Records
                List<DNSRecord> result = apiInstance.ApiDnsZonesZoneIdRecordsGet(zoneId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DNSZonesApi.ApiDnsZonesZoneIdRecordsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiDnsZonesZoneIdRecordsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List all DNS Records
    ApiResponse<List<DNSRecord>> response = apiInstance.ApiDnsZonesZoneIdRecordsGetWithHttpInfo(zoneId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DNSZonesApi.ApiDnsZonesZoneIdRecordsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **zoneId** | **string** | The unique identifier of a zone |  |

### Return type

[**List&lt;DNSRecord&gt;**](DNSRecord.md)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A JSON Array of DNS Records |  -  |
| **401** | Requires authentication |  -  |
| **403** | Forbidden |  -  |
| **404** | Resource not found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apidnszoneszoneidrecordspost"></a>
# **ApiDnsZonesZoneIdRecordsPost**
> DNSRecord ApiDnsZonesZoneIdRecordsPost (string zoneId, DNSRecordRequest? dNSRecordRequest = null)

Create a DNS Record

Creates a new DNS record in a zone

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiDnsZonesZoneIdRecordsPostExample
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

            var apiInstance = new DNSZonesApi;
            var zoneId = chacbco6lnnbn6cg5s91;  // string | The unique identifier of a zone
            var dNSRecordRequest = new DNSRecordRequest?(); // DNSRecordRequest? | A DNS record object (optional) 

            try
            {
                // Create a DNS Record
                DNSRecord result = apiInstance.ApiDnsZonesZoneIdRecordsPost(zoneId, dNSRecordRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DNSZonesApi.ApiDnsZonesZoneIdRecordsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiDnsZonesZoneIdRecordsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a DNS Record
    ApiResponse<DNSRecord> response = apiInstance.ApiDnsZonesZoneIdRecordsPostWithHttpInfo(zoneId, dNSRecordRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DNSZonesApi.ApiDnsZonesZoneIdRecordsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **zoneId** | **string** | The unique identifier of a zone |  |
| **dNSRecordRequest** | [**DNSRecordRequest?**](DNSRecordRequest?.md) | A DNS record object | [optional]  |

### Return type

[**DNSRecord**](DNSRecord.md)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A JSON Object of the created DNS Record |  -  |
| **400** | Bad Request |  -  |
| **401** | Requires authentication |  -  |
| **403** | Forbidden |  -  |
| **404** | Resource not found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apidnszoneszoneidrecordsrecordiddelete"></a>
# **ApiDnsZonesZoneIdRecordsRecordIdDelete**
> void ApiDnsZonesZoneIdRecordsRecordIdDelete (string zoneId, string recordId)

Delete a DNS Record

Deletes a DNS record from a zone

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiDnsZonesZoneIdRecordsRecordIdDeleteExample
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

            var apiInstance = new DNSZonesApi;
            var zoneId = chacbco6lnnbn6cg5s91;  // string | The unique identifier of a zone
            var recordId = chacbco6lnnbn6cg5s92;  // string | The unique identifier of a DNS record

            try
            {
                // Delete a DNS Record
                apiInstance.ApiDnsZonesZoneIdRecordsRecordIdDelete(zoneId, recordId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DNSZonesApi.ApiDnsZonesZoneIdRecordsRecordIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiDnsZonesZoneIdRecordsRecordIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a DNS Record
    apiInstance.ApiDnsZonesZoneIdRecordsRecordIdDeleteWithHttpInfo(zoneId, recordId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DNSZonesApi.ApiDnsZonesZoneIdRecordsRecordIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **zoneId** | **string** | The unique identifier of a zone |  |
| **recordId** | **string** | The unique identifier of a DNS record |  |

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
| **200** | Record deletion successful |  -  |
| **400** | Bad Request |  -  |
| **401** | Requires authentication |  -  |
| **403** | Forbidden |  -  |
| **404** | Resource not found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apidnszoneszoneidrecordsrecordidget"></a>
# **ApiDnsZonesZoneIdRecordsRecordIdGet**
> DNSRecord ApiDnsZonesZoneIdRecordsRecordIdGet (string zoneId, string recordId)

Retrieve a DNS Record

Returns information about a specific DNS record

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiDnsZonesZoneIdRecordsRecordIdGetExample
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

            var apiInstance = new DNSZonesApi;
            var zoneId = chacbco6lnnbn6cg5s91;  // string | The unique identifier of a zone
            var recordId = chacbco6lnnbn6cg5s92;  // string | The unique identifier of a DNS record

            try
            {
                // Retrieve a DNS Record
                DNSRecord result = apiInstance.ApiDnsZonesZoneIdRecordsRecordIdGet(zoneId, recordId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DNSZonesApi.ApiDnsZonesZoneIdRecordsRecordIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiDnsZonesZoneIdRecordsRecordIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve a DNS Record
    ApiResponse<DNSRecord> response = apiInstance.ApiDnsZonesZoneIdRecordsRecordIdGetWithHttpInfo(zoneId, recordId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DNSZonesApi.ApiDnsZonesZoneIdRecordsRecordIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **zoneId** | **string** | The unique identifier of a zone |  |
| **recordId** | **string** | The unique identifier of a DNS record |  |

### Return type

[**DNSRecord**](DNSRecord.md)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A JSON Object of a DNS Record |  -  |
| **400** | Bad Request |  -  |
| **401** | Requires authentication |  -  |
| **403** | Forbidden |  -  |
| **404** | Resource not found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apidnszoneszoneidrecordsrecordidput"></a>
# **ApiDnsZonesZoneIdRecordsRecordIdPut**
> DNSRecord ApiDnsZonesZoneIdRecordsRecordIdPut (string zoneId, string recordId, DNSRecordRequest? dNSRecordRequest = null)

Update a DNS Record

Updates a DNS record in a zone

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiDnsZonesZoneIdRecordsRecordIdPutExample
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

            var apiInstance = new DNSZonesApi;
            var zoneId = chacbco6lnnbn6cg5s91;  // string | The unique identifier of a zone
            var recordId = chacbco6lnnbn6cg5s92;  // string | The unique identifier of a DNS record
            var dNSRecordRequest = new DNSRecordRequest?(); // DNSRecordRequest? | A DNS record object (optional) 

            try
            {
                // Update a DNS Record
                DNSRecord result = apiInstance.ApiDnsZonesZoneIdRecordsRecordIdPut(zoneId, recordId, dNSRecordRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DNSZonesApi.ApiDnsZonesZoneIdRecordsRecordIdPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiDnsZonesZoneIdRecordsRecordIdPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a DNS Record
    ApiResponse<DNSRecord> response = apiInstance.ApiDnsZonesZoneIdRecordsRecordIdPutWithHttpInfo(zoneId, recordId, dNSRecordRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DNSZonesApi.ApiDnsZonesZoneIdRecordsRecordIdPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **zoneId** | **string** | The unique identifier of a zone |  |
| **recordId** | **string** | The unique identifier of a DNS record |  |
| **dNSRecordRequest** | [**DNSRecordRequest?**](DNSRecordRequest?.md) | A DNS record object | [optional]  |

### Return type

[**DNSRecord**](DNSRecord.md)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A JSON Object of the updated DNS Record |  -  |
| **400** | Bad Request |  -  |
| **401** | Requires authentication |  -  |
| **403** | Forbidden |  -  |
| **404** | Resource not found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

