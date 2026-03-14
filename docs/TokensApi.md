# NetBird.ApiClient.Api.TokensApi

All URIs are relative to *https://api.netbird.io/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiUsersUserIdTokensGet**](TokensApi.md#apiusersuseridtokensget) | **GET** users/{userId}/tokens | List all Tokens |
| [**ApiUsersUserIdTokensPost**](TokensApi.md#apiusersuseridtokenspost) | **POST** users/{userId}/tokens | Create a Token |
| [**ApiUsersUserIdTokensTokenIdDelete**](TokensApi.md#apiusersuseridtokenstokeniddelete) | **DELETE** /api/users/{userId}/tokens/{tokenId} | Delete a Token |
| [**ApiUsersUserIdTokensTokenIdGet**](TokensApi.md#apiusersuseridtokenstokenidget) | **GET** /api/users/{userId}/tokens/{tokenId} | Retrieve a Token |

<a id="apiusersuseridtokensget"></a>
# **ApiUsersUserIdTokensGet**
> List&lt;PersonalAccessToken&gt; ApiUsersUserIdTokensGet (string userId)

List all Tokens

Returns a list of all tokens for a user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiUsersUserIdTokensGetExample
    {
        public static void Main()
        {
            
            NetBirdApiClientOptions c = new NetBirdApiClientOptions()
            {
                AccessToken = "nbp_XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                BaseUrl = "https://api.netbird.io/api"
            };
            var client = new NetBirdApiClient(c);

            var apiInstance = client.TokensApi;
            var userId = "userId_example";  // string | The unique identifier of a user

            try
            {
                // List all Tokens
                List<PersonalAccessToken> result = apiInstance.ApiUsersUserIdTokensGet(userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TokensApi.ApiUsersUserIdTokensGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiUsersUserIdTokensGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List all Tokens
    ApiResponse<List<PersonalAccessToken>> response = apiInstance.ApiUsersUserIdTokensGetWithHttpInfo(userId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TokensApi.ApiUsersUserIdTokensGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **string** | The unique identifier of a user |  |

### Return type

[**List&lt;PersonalAccessToken&gt;**](PersonalAccessToken.md)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A JSON Array of PersonalAccessTokens |  -  |
| **400** | Bad Request |  -  |
| **401** | Requires authentication |  -  |
| **403** | Forbidden |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiusersuseridtokenspost"></a>
# **ApiUsersUserIdTokensPost**
> PersonalAccessTokenGenerated ApiUsersUserIdTokensPost (string userId, PersonalAccessTokenRequest? personalAccessTokenRequest = null)

Create a Token

Create a new token for a user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiUsersUserIdTokensPostExample
    {
        public static void Main()
        {
            
            NetBirdApiClientOptions c = new NetBirdApiClientOptions()
            {
                AccessToken = "nbp_XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                BaseUrl = "https://api.netbird.io/api"
            };
            var client = new NetBirdApiClient(c);

            var apiInstance = client.TokensApi;
            var userId = "userId_example";  // string | The unique identifier of a user
            var personalAccessTokenRequest = new PersonalAccessTokenRequest?(); // PersonalAccessTokenRequest? | PersonalAccessToken create parameters (optional) 

            try
            {
                // Create a Token
                PersonalAccessTokenGenerated result = apiInstance.ApiUsersUserIdTokensPost(userId, personalAccessTokenRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TokensApi.ApiUsersUserIdTokensPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiUsersUserIdTokensPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a Token
    ApiResponse<PersonalAccessTokenGenerated> response = apiInstance.ApiUsersUserIdTokensPostWithHttpInfo(userId, personalAccessTokenRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TokensApi.ApiUsersUserIdTokensPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **string** | The unique identifier of a user |  |
| **personalAccessTokenRequest** | [**PersonalAccessTokenRequest?**](PersonalAccessTokenRequest?.md) | PersonalAccessToken create parameters | [optional]  |

### Return type

[**PersonalAccessTokenGenerated**](PersonalAccessTokenGenerated.md)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The token in plain text |  -  |
| **400** | Bad Request |  -  |
| **401** | Requires authentication |  -  |
| **403** | Forbidden |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiusersuseridtokenstokeniddelete"></a>
# **ApiUsersUserIdTokensTokenIdDelete**
> void ApiUsersUserIdTokensTokenIdDelete (string userId, string tokenId)

Delete a Token

Delete a token for a user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiUsersUserIdTokensTokenIdDeleteExample
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

            var apiInstance = new TokensApi;
            var userId = "userId_example";  // string | The unique identifier of a user
            var tokenId = "tokenId_example";  // string | The unique identifier of a token

            try
            {
                // Delete a Token
                apiInstance.ApiUsersUserIdTokensTokenIdDelete(userId, tokenId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TokensApi.ApiUsersUserIdTokensTokenIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiUsersUserIdTokensTokenIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a Token
    apiInstance.ApiUsersUserIdTokensTokenIdDeleteWithHttpInfo(userId, tokenId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TokensApi.ApiUsersUserIdTokensTokenIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **string** | The unique identifier of a user |  |
| **tokenId** | **string** | The unique identifier of a token |  |

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

<a id="apiusersuseridtokenstokenidget"></a>
# **ApiUsersUserIdTokensTokenIdGet**
> PersonalAccessToken ApiUsersUserIdTokensTokenIdGet (string userId, string tokenId)

Retrieve a Token

Returns a specific token for a user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiUsersUserIdTokensTokenIdGetExample
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

            var apiInstance = new TokensApi;
            var userId = "userId_example";  // string | The unique identifier of a user
            var tokenId = "tokenId_example";  // string | The unique identifier of a token

            try
            {
                // Retrieve a Token
                PersonalAccessToken result = apiInstance.ApiUsersUserIdTokensTokenIdGet(userId, tokenId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TokensApi.ApiUsersUserIdTokensTokenIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiUsersUserIdTokensTokenIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve a Token
    ApiResponse<PersonalAccessToken> response = apiInstance.ApiUsersUserIdTokensTokenIdGetWithHttpInfo(userId, tokenId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TokensApi.ApiUsersUserIdTokensTokenIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **string** | The unique identifier of a user |  |
| **tokenId** | **string** | The unique identifier of a token |  |

### Return type

[**PersonalAccessToken**](PersonalAccessToken.md)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A PersonalAccessTokens Object |  -  |
| **400** | Bad Request |  -  |
| **401** | Requires authentication |  -  |
| **403** | Forbidden |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

