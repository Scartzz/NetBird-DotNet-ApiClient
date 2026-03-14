# NetBird.ApiClient.Api.UsersApi

All URIs are relative to *https://api.netbird.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiUsersCurrentGet**](UsersApi.md#apiuserscurrentget) | **GET** users/current | Retrieve current user |
| [**ApiUsersGet**](UsersApi.md#apiusersget) | **GET** users | List all Users |
| [**ApiUsersInvitesGet**](UsersApi.md#apiusersinvitesget) | **GET** /api/users/invites | List user invites |
| [**ApiUsersInvitesInviteIdDelete**](UsersApi.md#apiusersinvitesinviteiddelete) | **DELETE** /api/users/invites/{inviteId} | Delete a user invite |
| [**ApiUsersInvitesInviteIdRegeneratePost**](UsersApi.md#apiusersinvitesinviteidregeneratepost) | **POST** /api/users/invites/{inviteId}/regenerate | Regenerate a user invite |
| [**ApiUsersInvitesPost**](UsersApi.md#apiusersinvitespost) | **POST** /api/users/invites | Create a user invite |
| [**ApiUsersInvitesTokenAcceptPost**](UsersApi.md#apiusersinvitestokenacceptpost) | **POST** /api/users/invites/{token}/accept | Accept an invite |
| [**ApiUsersInvitesTokenGet**](UsersApi.md#apiusersinvitestokenget) | **GET** /api/users/invites/{token} | Get invite information |
| [**ApiUsersPost**](UsersApi.md#apiuserspost) | **POST** /api/users | Create a User |
| [**ApiUsersUserIdApprovePost**](UsersApi.md#apiusersuseridapprovepost) | **POST** /api/users/{userId}/approve | Approve user |
| [**ApiUsersUserIdDelete**](UsersApi.md#apiusersuseriddelete) | **DELETE** /api/users/{userId} | Delete a User |
| [**ApiUsersUserIdInvitePost**](UsersApi.md#apiusersuseridinvitepost) | **POST** /api/users/{userId}/invite | Resend user invitation |
| [**ApiUsersUserIdPasswordPut**](UsersApi.md#apiusersuseridpasswordput) | **PUT** /api/users/{userId}/password | Change user password |
| [**ApiUsersUserIdPut**](UsersApi.md#apiusersuseridput) | **PUT** /api/users/{userId} | Update a User |
| [**ApiUsersUserIdRejectDelete**](UsersApi.md#apiusersuseridrejectdelete) | **DELETE** /api/users/{userId}/reject | Reject user |

<a id="apiuserscurrentget"></a>
# **ApiUsersCurrentGet**
> User ApiUsersCurrentGet ()

Retrieve current user

Get information about the current user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiUsersCurrentGetExample
    {
        public static void Main()
        {
            
            NetBirdApiClientOptions c = new NetBirdApiClientOptions()
            {
                AccessToken = "nbp_XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                BaseUrl = "https://api.netbird.io/api"
            };
            var client = new NetBirdApiClient(c);

            var apiInstance = client.UsersApi;

            try
            {
                // Retrieve current user
                User result = apiInstance.ApiUsersCurrentGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.ApiUsersCurrentGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiUsersCurrentGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve current user
    ApiResponse<User> response = apiInstance.ApiUsersCurrentGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.ApiUsersCurrentGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**User**](User.md)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A User object |  -  |
| **400** | Bad Request |  -  |
| **401** | Requires authentication |  -  |
| **403** | Forbidden |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiusersget"></a>
# **ApiUsersGet**
> List&lt;User&gt; ApiUsersGet (bool? serviceUser = null)

List all Users

Returns a list of all users

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiUsersGetExample
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

            var apiInstance = client.UsersApi;
            var serviceUser = true;  // bool? | Filters users and returns either regular users or service users (optional) 

            try
            {
                // List all Users
                List<User> result = apiInstance.ApiUsersGet(serviceUser);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.ApiUsersGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiUsersGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List all Users
    ApiResponse<List<User>> response = apiInstance.ApiUsersGetWithHttpInfo(serviceUser);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.ApiUsersGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **serviceUser** | **bool?** | Filters users and returns either regular users or service users | [optional]  |

### Return type

[**List&lt;User&gt;**](User.md)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A JSON array of Users |  -  |
| **400** | Bad Request |  -  |
| **401** | Requires authentication |  -  |
| **403** | Forbidden |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiusersinvitesget"></a>
# **ApiUsersInvitesGet**
> List&lt;UserInvite&gt; ApiUsersInvitesGet ()

List user invites

Lists all pending invites for the account. Only available when embedded IdP is enabled.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiUsersInvitesGetExample
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

            var apiInstance = new UsersApi;

            try
            {
                // List user invites
                List<UserInvite> result = apiInstance.ApiUsersInvitesGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.ApiUsersInvitesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiUsersInvitesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List user invites
    ApiResponse<List<UserInvite>> response = apiInstance.ApiUsersInvitesGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.ApiUsersInvitesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;UserInvite&gt;**](UserInvite.md)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of invites |  -  |
| **401** | Requires authentication |  -  |
| **403** | Forbidden |  -  |
| **412** | Precondition failed - embedded IdP is not enabled |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiusersinvitesinviteiddelete"></a>
# **ApiUsersInvitesInviteIdDelete**
> void ApiUsersInvitesInviteIdDelete (string inviteId)

Delete a user invite

Deletes a pending invite. Only available when embedded IdP is enabled.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiUsersInvitesInviteIdDeleteExample
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

            var apiInstance = new UsersApi;
            var inviteId = "inviteId_example";  // string | The ID of the invite to delete

            try
            {
                // Delete a user invite
                apiInstance.ApiUsersInvitesInviteIdDelete(inviteId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.ApiUsersInvitesInviteIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiUsersInvitesInviteIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a user invite
    apiInstance.ApiUsersInvitesInviteIdDeleteWithHttpInfo(inviteId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.ApiUsersInvitesInviteIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **inviteId** | **string** | The ID of the invite to delete |  |

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
| **200** | Invite deleted successfully |  -  |
| **401** | Requires authentication |  -  |
| **403** | Forbidden |  -  |
| **404** | Invite not found |  -  |
| **412** | Precondition failed - embedded IdP is not enabled |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiusersinvitesinviteidregeneratepost"></a>
# **ApiUsersInvitesInviteIdRegeneratePost**
> UserInviteRegenerateResponse ApiUsersInvitesInviteIdRegeneratePost (string inviteId, UserInviteRegenerateRequest? userInviteRegenerateRequest = null)

Regenerate a user invite

Regenerates an invite link for an existing invite. Invalidates the previous token and creates a new one.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiUsersInvitesInviteIdRegeneratePostExample
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

            var apiInstance = new UsersApi;
            var inviteId = "inviteId_example";  // string | The ID of the invite to regenerate
            var userInviteRegenerateRequest = new UserInviteRegenerateRequest?(); // UserInviteRegenerateRequest? | Regenerate options (optional) 

            try
            {
                // Regenerate a user invite
                UserInviteRegenerateResponse result = apiInstance.ApiUsersInvitesInviteIdRegeneratePost(inviteId, userInviteRegenerateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.ApiUsersInvitesInviteIdRegeneratePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiUsersInvitesInviteIdRegeneratePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Regenerate a user invite
    ApiResponse<UserInviteRegenerateResponse> response = apiInstance.ApiUsersInvitesInviteIdRegeneratePostWithHttpInfo(inviteId, userInviteRegenerateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.ApiUsersInvitesInviteIdRegeneratePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **inviteId** | **string** | The ID of the invite to regenerate |  |
| **userInviteRegenerateRequest** | [**UserInviteRegenerateRequest?**](UserInviteRegenerateRequest?.md) | Regenerate options | [optional]  |

### Return type

[**UserInviteRegenerateResponse**](UserInviteRegenerateResponse.md)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Invite regenerated successfully |  -  |
| **400** | Bad Request |  -  |
| **401** | Requires authentication |  -  |
| **403** | Forbidden |  -  |
| **404** | Invite not found |  -  |
| **412** | Precondition failed - embedded IdP is not enabled |  -  |
| **422** | Validation failed |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiusersinvitespost"></a>
# **ApiUsersInvitesPost**
> UserInvite ApiUsersInvitesPost (UserInviteCreateRequest userInviteCreateRequest)

Create a user invite

Creates an invite link for a new user. Only available when embedded IdP is enabled. The user is not created until they accept the invite.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiUsersInvitesPostExample
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

            var apiInstance = new UsersApi;
            var userInviteCreateRequest = new UserInviteCreateRequest(); // UserInviteCreateRequest | User invite information

            try
            {
                // Create a user invite
                UserInvite result = apiInstance.ApiUsersInvitesPost(userInviteCreateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.ApiUsersInvitesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiUsersInvitesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a user invite
    ApiResponse<UserInvite> response = apiInstance.ApiUsersInvitesPostWithHttpInfo(userInviteCreateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.ApiUsersInvitesPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userInviteCreateRequest** | [**UserInviteCreateRequest**](UserInviteCreateRequest.md) | User invite information |  |

### Return type

[**UserInvite**](UserInvite.md)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Invite created successfully |  -  |
| **400** | Bad Request |  -  |
| **401** | Requires authentication |  -  |
| **403** | Forbidden |  -  |
| **409** | User or invite already exists |  -  |
| **412** | Precondition failed - embedded IdP is not enabled |  -  |
| **422** | Validation failed |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiusersinvitestokenacceptpost"></a>
# **ApiUsersInvitesTokenAcceptPost**
> UserInviteAcceptResponse ApiUsersInvitesTokenAcceptPost (string token, UserInviteAcceptRequest userInviteAcceptRequest)

Accept an invite

Accepts an invite and creates the user with the provided password. This endpoint is unauthenticated and protected by the token itself.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiUsersInvitesTokenAcceptPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.netbird.io";
            var apiInstance = new UsersApi;
            var token = "token_example";  // string | The invite token
            var userInviteAcceptRequest = new UserInviteAcceptRequest(); // UserInviteAcceptRequest | Password to set for the new user

            try
            {
                // Accept an invite
                UserInviteAcceptResponse result = apiInstance.ApiUsersInvitesTokenAcceptPost(token, userInviteAcceptRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.ApiUsersInvitesTokenAcceptPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiUsersInvitesTokenAcceptPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Accept an invite
    ApiResponse<UserInviteAcceptResponse> response = apiInstance.ApiUsersInvitesTokenAcceptPostWithHttpInfo(token, userInviteAcceptRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.ApiUsersInvitesTokenAcceptPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **token** | **string** | The invite token |  |
| **userInviteAcceptRequest** | [**UserInviteAcceptRequest**](UserInviteAcceptRequest.md) | Password to set for the new user |  |

### Return type

[**UserInviteAcceptResponse**](UserInviteAcceptResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Invite accepted successfully |  -  |
| **400** | Bad Request |  -  |
| **404** | Invite not found or invalid token |  -  |
| **412** | Precondition failed - embedded IdP is not enabled or invite expired |  -  |
| **422** | Validation failed |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiusersinvitestokenget"></a>
# **ApiUsersInvitesTokenGet**
> UserInviteInfo ApiUsersInvitesTokenGet (string token)

Get invite information

Retrieves public information about an invite. This endpoint is unauthenticated and protected by the token itself.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiUsersInvitesTokenGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.netbird.io";
            var apiInstance = new UsersApi;
            var token = "token_example";  // string | The invite token

            try
            {
                // Get invite information
                UserInviteInfo result = apiInstance.ApiUsersInvitesTokenGet(token);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.ApiUsersInvitesTokenGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiUsersInvitesTokenGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get invite information
    ApiResponse<UserInviteInfo> response = apiInstance.ApiUsersInvitesTokenGetWithHttpInfo(token);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.ApiUsersInvitesTokenGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **token** | **string** | The invite token |  |

### Return type

[**UserInviteInfo**](UserInviteInfo.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Invite information |  -  |
| **400** | Bad Request |  -  |
| **404** | Invite not found or invalid token |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiuserspost"></a>
# **ApiUsersPost**
> User ApiUsersPost (UserCreateRequest? userCreateRequest = null)

Create a User

Creates a new service user or sends an invite to a regular user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiUsersPostExample
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

            var apiInstance = new UsersApi;
            var userCreateRequest = new UserCreateRequest?(); // UserCreateRequest? | User invite information (optional) 

            try
            {
                // Create a User
                User result = apiInstance.ApiUsersPost(userCreateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.ApiUsersPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiUsersPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a User
    ApiResponse<User> response = apiInstance.ApiUsersPostWithHttpInfo(userCreateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.ApiUsersPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userCreateRequest** | [**UserCreateRequest?**](UserCreateRequest?.md) | User invite information | [optional]  |

### Return type

[**User**](User.md)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A User object |  -  |
| **400** | Bad Request |  -  |
| **401** | Requires authentication |  -  |
| **403** | Forbidden |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiusersuseridapprovepost"></a>
# **ApiUsersUserIdApprovePost**
> User ApiUsersUserIdApprovePost (string userId)

Approve user

Approve a user that is pending approval

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiUsersUserIdApprovePostExample
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

            var apiInstance = new UsersApi;
            var userId = "userId_example";  // string | The unique identifier of a user

            try
            {
                // Approve user
                User result = apiInstance.ApiUsersUserIdApprovePost(userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.ApiUsersUserIdApprovePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiUsersUserIdApprovePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Approve user
    ApiResponse<User> response = apiInstance.ApiUsersUserIdApprovePostWithHttpInfo(userId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.ApiUsersUserIdApprovePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **string** | The unique identifier of a user |  |

### Return type

[**User**](User.md)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the approved user |  -  |
| **400** | Bad Request |  -  |
| **401** | Requires authentication |  -  |
| **403** | Forbidden |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiusersuseriddelete"></a>
# **ApiUsersUserIdDelete**
> void ApiUsersUserIdDelete (string userId)

Delete a User

This method removes a user from accessing the system. For this leaves the IDP user intact unless the `- -user-delete-from-idp` is passed to management startup.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiUsersUserIdDeleteExample
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

            var apiInstance = new UsersApi;
            var userId = "userId_example";  // string | The unique identifier of a user

            try
            {
                // Delete a User
                apiInstance.ApiUsersUserIdDelete(userId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.ApiUsersUserIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiUsersUserIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a User
    apiInstance.ApiUsersUserIdDeleteWithHttpInfo(userId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.ApiUsersUserIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **string** | The unique identifier of a user |  |

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

<a id="apiusersuseridinvitepost"></a>
# **ApiUsersUserIdInvitePost**
> void ApiUsersUserIdInvitePost (string userId)

Resend user invitation

Resend user invitation

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiUsersUserIdInvitePostExample
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

            var apiInstance = new UsersApi;
            var userId = "userId_example";  // string | The unique identifier of a user

            try
            {
                // Resend user invitation
                apiInstance.ApiUsersUserIdInvitePost(userId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.ApiUsersUserIdInvitePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiUsersUserIdInvitePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Resend user invitation
    apiInstance.ApiUsersUserIdInvitePostWithHttpInfo(userId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.ApiUsersUserIdInvitePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **string** | The unique identifier of a user |  |

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
| **200** | Invite status code |  -  |
| **400** | Bad Request |  -  |
| **401** | Requires authentication |  -  |
| **403** | Forbidden |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiusersuseridpasswordput"></a>
# **ApiUsersUserIdPasswordPut**
> void ApiUsersUserIdPasswordPut (string userId, PasswordChangeRequest passwordChangeRequest)

Change user password

Change the password for a user. Only available when embedded IdP is enabled. Users can only change their own password.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiUsersUserIdPasswordPutExample
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

            var apiInstance = new UsersApi;
            var userId = "userId_example";  // string | The unique identifier of a user
            var passwordChangeRequest = new PasswordChangeRequest(); // PasswordChangeRequest | Password change request

            try
            {
                // Change user password
                apiInstance.ApiUsersUserIdPasswordPut(userId, passwordChangeRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.ApiUsersUserIdPasswordPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiUsersUserIdPasswordPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Change user password
    apiInstance.ApiUsersUserIdPasswordPutWithHttpInfo(userId, passwordChangeRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.ApiUsersUserIdPasswordPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **string** | The unique identifier of a user |  |
| **passwordChangeRequest** | [**PasswordChangeRequest**](PasswordChangeRequest.md) | Password change request |  |

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
| **200** | Password changed successfully |  -  |
| **400** | Bad Request |  -  |
| **401** | Requires authentication |  -  |
| **403** | Forbidden |  -  |
| **412** | Precondition failed - embedded IdP is not enabled |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiusersuseridput"></a>
# **ApiUsersUserIdPut**
> User ApiUsersUserIdPut (string userId, UserRequest? userRequest = null)

Update a User

Update information about a User

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiUsersUserIdPutExample
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

            var apiInstance = new UsersApi;
            var userId = "userId_example";  // string | The unique identifier of a user
            var userRequest = new UserRequest?(); // UserRequest? | User update (optional) 

            try
            {
                // Update a User
                User result = apiInstance.ApiUsersUserIdPut(userId, userRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.ApiUsersUserIdPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiUsersUserIdPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a User
    ApiResponse<User> response = apiInstance.ApiUsersUserIdPutWithHttpInfo(userId, userRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.ApiUsersUserIdPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **string** | The unique identifier of a user |  |
| **userRequest** | [**UserRequest?**](UserRequest?.md) | User update | [optional]  |

### Return type

[**User**](User.md)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A User object |  -  |
| **400** | Bad Request |  -  |
| **401** | Requires authentication |  -  |
| **403** | Forbidden |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiusersuseridrejectdelete"></a>
# **ApiUsersUserIdRejectDelete**
> void ApiUsersUserIdRejectDelete (string userId)

Reject user

Reject a user that is pending approval by removing them from the account

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiUsersUserIdRejectDeleteExample
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

            var apiInstance = new UsersApi;
            var userId = "userId_example";  // string | The unique identifier of a user

            try
            {
                // Reject user
                apiInstance.ApiUsersUserIdRejectDelete(userId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.ApiUsersUserIdRejectDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiUsersUserIdRejectDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reject user
    apiInstance.ApiUsersUserIdRejectDeleteWithHttpInfo(userId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.ApiUsersUserIdRejectDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **string** | The unique identifier of a user |  |

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
| **200** | User rejected successfully |  -  |
| **400** | Bad Request |  -  |
| **401** | Requires authentication |  -  |
| **403** | Forbidden |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

