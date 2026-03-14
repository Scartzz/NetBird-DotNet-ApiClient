# NetBird.ApiClient.Api.JobsApi

All URIs are relative to *https://api.netbird.io/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiPeersPeerIdJobsGet**](JobsApi.md#apipeerspeeridjobsget) | **GET** peers/{peerId}/jobs | List Jobs |
| [**ApiPeersPeerIdJobsJobIdGet**](JobsApi.md#apipeerspeeridjobsjobidget) | **GET** peers/{peerId}/jobs/{jobId} | Get Job |
| [**ApiPeersPeerIdJobsPost**](JobsApi.md#apipeerspeeridjobspost) | **POST** /api/peers/{peerId}/jobs | Create Job |

<a id="apipeerspeeridjobsget"></a>
# **ApiPeersPeerIdJobsGet**
> List&lt;JobResponse&gt; ApiPeersPeerIdJobsGet (string peerId)

List Jobs

Retrieve all jobs for a given peer

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiPeersPeerIdJobsGetExample
    {
        public static void Main()
        {
            
            NetBirdApiClientOptions c = new NetBirdApiClientOptions()
            {
                AccessToken = "nbp_XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                BaseUrl = "https://api.netbird.io/api"
            };
            var client = new NetBirdApiClient(c);

            var apiInstance = client.JobsApi;
            var peerId = "peerId_example";  // string | The unique identifier of a peer

            try
            {
                // List Jobs
                List<JobResponse> result = apiInstance.ApiPeersPeerIdJobsGet(peerId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling JobsApi.ApiPeersPeerIdJobsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiPeersPeerIdJobsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Jobs
    ApiResponse<List<JobResponse>> response = apiInstance.ApiPeersPeerIdJobsGetWithHttpInfo(peerId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling JobsApi.ApiPeersPeerIdJobsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **peerId** | **string** | The unique identifier of a peer |  |

### Return type

[**List&lt;JobResponse&gt;**](JobResponse.md)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of jobs |  -  |
| **400** | Bad Request |  -  |
| **401** | Requires authentication |  -  |
| **403** | Forbidden |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apipeerspeeridjobsjobidget"></a>
# **ApiPeersPeerIdJobsJobIdGet**
> JobResponse ApiPeersPeerIdJobsJobIdGet (string peerId, string jobId)

Get Job

Retrieve details of a specific job

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiPeersPeerIdJobsJobIdGetExample
    {
        public static void Main()
        {
            
            NetBirdApiClientOptions c = new NetBirdApiClientOptions()
            {
                AccessToken = "nbp_XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                BaseUrl = "https://api.netbird.io/api"
            };
            var client = new NetBirdApiClient(c);

            var apiInstance = client.JobsApi;
            var peerId = "peerId_example";  // string | The unique identifier of a peer
            var jobId = "jobId_example";  // string | The unique identifier of a job

            try
            {
                // Get Job
                JobResponse result = apiInstance.ApiPeersPeerIdJobsJobIdGet(peerId, jobId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling JobsApi.ApiPeersPeerIdJobsJobIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiPeersPeerIdJobsJobIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Job
    ApiResponse<JobResponse> response = apiInstance.ApiPeersPeerIdJobsJobIdGetWithHttpInfo(peerId, jobId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling JobsApi.ApiPeersPeerIdJobsJobIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **peerId** | **string** | The unique identifier of a peer |  |
| **jobId** | **string** | The unique identifier of a job |  |

### Return type

[**JobResponse**](JobResponse.md)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A Job object |  -  |
| **400** | Bad Request |  -  |
| **401** | Requires authentication |  -  |
| **403** | Forbidden |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apipeerspeeridjobspost"></a>
# **ApiPeersPeerIdJobsPost**
> JobResponse ApiPeersPeerIdJobsPost (string peerId, JobRequest jobRequest)

Create Job

Create a new job for a given peer

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiPeersPeerIdJobsPostExample
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

            var apiInstance = client.JobsApi;
            var peerId = "peerId_example";  // string | The unique identifier of a peer
            var jobRequest = new JobRequest(); // JobRequest | Create job request

            try
            {
                // Create Job
                JobResponse result = apiInstance.ApiPeersPeerIdJobsPost(peerId, jobRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling JobsApi.ApiPeersPeerIdJobsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiPeersPeerIdJobsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Job
    ApiResponse<JobResponse> response = apiInstance.ApiPeersPeerIdJobsPostWithHttpInfo(peerId, jobRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling JobsApi.ApiPeersPeerIdJobsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **peerId** | **string** | The unique identifier of a peer |  |
| **jobRequest** | [**JobRequest**](JobRequest.md) | Create job request |  |

### Return type

[**JobResponse**](JobResponse.md)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Job created |  -  |
| **400** | Bad Request |  -  |
| **401** | Requires authentication |  -  |
| **403** | Forbidden |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

