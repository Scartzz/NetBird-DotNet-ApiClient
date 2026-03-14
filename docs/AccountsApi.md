# NetBird.ApiClient.Api.AccountsApi

All URIs are relative to *https://api.netbird.io/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiAccountsAccountIdDelete**](AccountsApi.md#apiaccountsaccountiddelete) | **DELETE** accounts/{accountId} | Delete an Account |
| [**ApiAccountsAccountIdPut**](AccountsApi.md#apiaccountsaccountidput) | **PUT** accounts/{accountId} | Update an Account |
| [**ApiAccountsGet**](AccountsApi.md#apiaccountsget) | **GET** /api/accounts | List all Accounts |

<a id="apiaccountsaccountiddelete"></a>
# **ApiAccountsAccountIdDelete**
> void ApiAccountsAccountIdDelete (string accountId)

Delete an Account

Deletes an account and all its resources. Only account owners can delete accounts.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiAccountsAccountIdDeleteExample
    {
        public static void Main()
        {
            NetBirdApiClientOptions c = new NetBirdApiClientOptions()
            {
                AccessToken = "nbp_XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                BaseUrl = "https://api.netbird.io/api"
            };
            var client = new NetBirdApiClient(c);
            var apiInstance = client.AccountsApi;
            var accountId = "accountId_example";  // string | The unique identifier of an account

            try
            {
                // Delete an Account
                apiInstance.ApiAccountsAccountIdDelete(accountId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountsApi.ApiAccountsAccountIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiAccountsAccountIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete an Account
    apiInstance.ApiAccountsAccountIdDeleteWithHttpInfo(accountId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountsApi.ApiAccountsAccountIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountId** | **string** | The unique identifier of an account |  |

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
| **200** | Delete account status code |  -  |
| **400** | Bad Request |  -  |
| **401** | Requires authentication |  -  |
| **403** | Forbidden |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiaccountsaccountidput"></a>
# **ApiAccountsAccountIdPut**
> Account ApiAccountsAccountIdPut (string accountId, AccountRequest? accountRequest = null)

Update an Account

Update information about an account

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiAccountsAccountIdPutExample
    {
        public static void Main()
        {
            NetBirdApiClientOptions c = new NetBirdApiClientOptions()
            {
                AccessToken = "nbp_XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                BaseUrl = "https://api.netbird.io/api"
            };
            var client = new NetBirdApiClient(c);
            var apiInstance = client.AccountsApi;
            var accountId = "accountId_example";  // string | The unique identifier of an account
            var accountRequest = new AccountRequest?(); // AccountRequest? | update an account (optional) 

            try
            {
                // Update an Account
                Account result = apiInstance.ApiAccountsAccountIdPut(accountId, accountRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountsApi.ApiAccountsAccountIdPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiAccountsAccountIdPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update an Account
    ApiResponse<Account> response = apiInstance.ApiAccountsAccountIdPutWithHttpInfo(accountId, accountRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountsApi.ApiAccountsAccountIdPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountId** | **string** | The unique identifier of an account |  |
| **accountRequest** | [**AccountRequest?**](AccountRequest?.md) | update an account | [optional]  |

### Return type

[**Account**](Account.md)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | An Account object |  -  |
| **400** | Bad Request |  -  |
| **401** | Requires authentication |  -  |
| **403** | Forbidden |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiaccountsget"></a>
# **ApiAccountsGet**
> List&lt;Account&gt; ApiAccountsGet ()

List all Accounts

Returns a list of accounts of a user. Always returns a list of one account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiAccountsGetExample
    {
        public static void Main()
        {
            NetBirdApiClientOptions c = new NetBirdApiClientOptions()
            {
                AccessToken = "nbp_XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                BaseUrl = "https://api.netbird.io/api"
            };
            var client = new NetBirdApiClient(c);
            var apiInstance = client.AccountsApi;

            try
            {
                // List all Accounts
                List<Account> result = apiInstance.ApiAccountsGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountsApi.ApiAccountsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiAccountsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List all Accounts
    ApiResponse<List<Account>> response = apiInstance.ApiAccountsGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountsApi.ApiAccountsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;Account&gt;**](Account.md)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A JSON array of accounts |  -  |
| **400** | Bad Request |  -  |
| **401** | Requires authentication |  -  |
| **403** | Forbidden |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

