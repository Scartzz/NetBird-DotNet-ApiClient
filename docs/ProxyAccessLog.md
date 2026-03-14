# NetBird.ApiClient.Model.ProxyAccessLog

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique identifier for the access log entry | 
**ServiceId** | **string** | ID of the service that handled the request | 
**Timestamp** | **DateTimeOffset** | Timestamp when the request was made | 
**Method** | **string** | HTTP method of the request | 
**Host** | **string** | Host header of the request | 
**Path** | **string** | Path of the request | 
**DurationMs** | **int** | Duration of the request in milliseconds | 
**StatusCode** | **int** | HTTP status code returned | 
**SourceIp** | **string** | Source IP address of the request | [optional] 
**Reason** | **string** | Reason for the request result (e.g., authentication failure) | [optional] 
**UserId** | **string** | ID of the authenticated user, if applicable | [optional] 
**AuthMethodUsed** | **string** | Authentication method used (e.g., password, pin, oidc) | [optional] 
**CountryCode** | **string** | Country code from geolocation | [optional] 
**CityName** | **string** | City name from geolocation | [optional] 
**BytesUpload** | **long** | Bytes uploaded (request body size) | 
**BytesDownload** | **long** | Bytes downloaded (response body size) | 
**Protocol** | **string** | Protocol type: http, tcp, or udp | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

