# NetBird.ApiClient.Api.GeoLocationsApi

All URIs are relative to *https://api.netbird.io/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiLocationsCountriesCountryCitiesGet**](GeoLocationsApi.md#apilocationscountriescountrycitiesget) | **GET** locations/countries/{country}/cities | List all city names by country |
| [**ApiLocationsCountriesGet**](GeoLocationsApi.md#apilocationscountriesget) | **GET** locations/countries | List all country codes |

<a id="apilocationscountriescountrycitiesget"></a>
# **ApiLocationsCountriesCountryCitiesGet**
> City ApiLocationsCountriesCountryCitiesGet (Country country)

List all city names by country

Get a list of all English city names for a given country code

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiLocationsCountriesCountryCitiesGetExample
    {
        public static void Main()
        {
            
            NetBirdApiClientOptions c = new NetBirdApiClientOptions()
            {
                AccessToken = "nbp_XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                BaseUrl = "https://api.netbird.io/api"
            };
            var client = new NetBirdApiClient(c);

            var apiInstance = client.GeoLocationsApi;
            var country = new Country(); // Country | 

            try
            {
                // List all city names by country
                City result = apiInstance.ApiLocationsCountriesCountryCitiesGet(country);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GeoLocationsApi.ApiLocationsCountriesCountryCitiesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiLocationsCountriesCountryCitiesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List all city names by country
    ApiResponse<City> response = apiInstance.ApiLocationsCountriesCountryCitiesGetWithHttpInfo(country);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GeoLocationsApi.ApiLocationsCountriesCountryCitiesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **country** | [**Country**](Country.md) |  |  |

### Return type

[**City**](City.md)

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of city names |  -  |
| **400** | Bad Request |  -  |
| **401** | Requires authentication |  -  |
| **403** | Forbidden |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apilocationscountriesget"></a>
# **ApiLocationsCountriesGet**
> List&lt;string&gt; ApiLocationsCountriesGet ()

List all country codes

Get list of all country in 2-letter ISO 3166-1 alpha-2 codes

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NetBird.ApiClient.Api;
using NetBird.ApiClient.Client;
using NetBird.ApiClient.Model;

namespace Example
{
    public class ApiLocationsCountriesGetExample
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

            var apiInstance = client.GeoLocationsApi;

            try
            {
                // List all country codes
                List<string> result = apiInstance.ApiLocationsCountriesGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GeoLocationsApi.ApiLocationsCountriesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiLocationsCountriesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List all country codes
    ApiResponse<List<string>> response = apiInstance.ApiLocationsCountriesGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GeoLocationsApi.ApiLocationsCountriesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

**List<string>**

### Authorization

[TokenAuth](../README.md#TokenAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of country codes |  -  |
| **400** | Bad Request |  -  |
| **401** | Requires authentication |  -  |
| **403** | Forbidden |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

