# NetBird.ApiClient.Model.AccessiblePeer

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Peer ID | 
**Name** | **string** | Peer&#39;s hostname | 
**Ip** | **string** | Peer&#39;s IP address | 
**DnsLabel** | **string** | Peer&#39;s DNS label is the parsed peer name for domain resolution. It is used to form an FQDN by appending the account&#39;s domain to the peer label. e.g. peer-dns-label.netbird.cloud | 
**UserId** | **string** | User ID of the user that enrolled this peer | 
**Os** | **string** | Peer&#39;s operating system and version | 
**CountryCode** | **string** | 2-letter ISO 3166-1 alpha-2 code that represents the country | 
**CityName** | **string** | Commonly used English name of the city | 
**GeonameId** | **int** | Unique identifier from the GeoNames database for a specific geographical location. | 
**Connected** | **bool** | Peer to Management connection status | 
**LastSeen** | **DateTimeOffset** | Last time peer connected to Netbird&#39;s management service | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

