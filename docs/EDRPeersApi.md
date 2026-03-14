# NetBird.ApiClient.Api.EDRPeersApi

All URIs are relative to *https://api.netbird.io/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**BypassCompliance**](EDRPeersApi.md#bypasscompliance) | **POST** peers/{peer-id}/edr/bypass | Bypass compliance for a non-compliant peer |
| [**ListBypassedPeers**](EDRPeersApi.md#listbypassedpeers) | **GET** peers/edr/bypassed | List all bypassed peers |
| [**RevokeBypass**](EDRPeersApi.md#revokebypass) | **DELETE** /api/peers/{peer-id}/edr/bypass | Revoke compliance bypass for a peer |

<a id="bypasscompliance"></a>
# **BypassCompliance**
> BypassResponse BypassCompliance (string peerId)

Bypass compliance for a non-compliant peer

Allows an admin to bypass EDR compliance checks for a specific peer. The peer will remain bypassed until the admin revokes it OR the device becomes naturally compliant in the EDR system. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class BypassComplianceExample
    {
        public static void Main()
        {
            
            NetBirdApiClientOptions c = new NetBirdApiClientOptions()
            {
                AccessToken = "nbp_XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                BaseUrl = "https://api.netbird.io/api"
            };
            var client = new NetBirdApiClient(c);

            var apiInstance = client.EDRPeersApi;
            var peerId = "peerId_example";  // string | The unique identifier of the peer

            try
            {
                // Bypass compliance for a non-compliant peer
                BypassResponse result = apiInstance.BypassCompliance(peerId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EDRPeersApi.BypassCompliance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BypassComplianceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Bypass compliance for a non-compliant peer
    ApiResponse<BypassResponse> response = apiInstance.BypassComplianceWithHttpInfo(peerId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EDRPeersApi.BypassComplianceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **peerId** | **string** | The unique identifier of the peer |  |

### Return type

[**BypassResponse**](BypassResponse.md)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Peer compliance bypassed successfully |  -  |
| **400** | Bad Request (peer not in non-compliant state) |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listbypassedpeers"></a>
# **ListBypassedPeers**
> List&lt;BypassResponse&gt; ListBypassedPeers ()

List all bypassed peers

Returns all peers that have compliance bypassed by an admin.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ListBypassedPeersExample
    {
        public static void Main()
        {
            
            NetBirdApiClientOptions c = new NetBirdApiClientOptions()
            {
                AccessToken = "nbp_XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                BaseUrl = "https://api.netbird.io/api"
            };
            var client = new NetBirdApiClient(c);

            var apiInstance = client.EDRPeersApi;

            try
            {
                // List all bypassed peers
                List<BypassResponse> result = apiInstance.ListBypassedPeers();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EDRPeersApi.ListBypassedPeers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListBypassedPeersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List all bypassed peers
    ApiResponse<List<BypassResponse>> response = apiInstance.ListBypassedPeersWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EDRPeersApi.ListBypassedPeersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;BypassResponse&gt;**](BypassResponse.md)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of bypassed peers |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="revokebypass"></a>
# **RevokeBypass**
> void RevokeBypass (string peerId)

Revoke compliance bypass for a peer

Removes the compliance bypass, subjecting the peer to normal EDR validation.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class RevokeBypassExample
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

            var apiInstance = new EDRPeersApi;
            var peerId = "peerId_example";  // string | The unique identifier of the peer

            try
            {
                // Revoke compliance bypass for a peer
                apiInstance.RevokeBypass(peerId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EDRPeersApi.RevokeBypass: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RevokeBypassWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Revoke compliance bypass for a peer
    apiInstance.RevokeBypassWithHttpInfo(peerId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EDRPeersApi.RevokeBypassWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **peerId** | **string** | The unique identifier of the peer |  |

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
| **200** | Compliance bypass revoked successfully |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

