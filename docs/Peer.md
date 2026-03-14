# NetBird.ApiClient.Model.Peer

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Peer ID | 
**Name** | **string** | Peer&#39;s hostname | 
**CreatedAt** | **DateTimeOffset** | Peer creation date (UTC) | 
**Ip** | **string** | Peer&#39;s IP address | 
**ConnectionIp** | **string** | Peer&#39;s public connection IP address | 
**Connected** | **bool** | Peer to Management connection status | 
**LastSeen** | **DateTimeOffset** | Last time peer connected to Netbird&#39;s management service | 
**Os** | **string** | Peer&#39;s operating system and version | 
**KernelVersion** | **string** | Peer&#39;s operating system kernel version | 
**GeonameId** | **int** | Unique identifier from the GeoNames database for a specific geographical location. | 
**VarVersion** | **string** | Peer&#39;s daemon or cli version | 
**Groups** | [**List&lt;GroupMinimum&gt;**](GroupMinimum.md) | Groups that the peer belongs to | 
**SshEnabled** | **bool** | Indicates whether SSH server is enabled on this peer | 
**UserId** | **string** | User ID of the user that enrolled this peer | 
**Hostname** | **string** | Hostname of the machine | 
**UiVersion** | **string** | Peer&#39;s desktop UI version | 
**DnsLabel** | **string** | Peer&#39;s DNS label is the parsed peer name for domain resolution. It is used to form an FQDN by appending the account&#39;s domain to the peer label. e.g. peer-dns-label.netbird.cloud | 
**LoginExpirationEnabled** | **bool** | Indicates whether peer login expiration has been enabled or not | 
**LoginExpired** | **bool** | Indicates whether peer&#39;s login expired or not | 
**LastLogin** | **DateTimeOffset** | Last time this peer performed log in (authentication). E.g., user authenticated. | 
**InactivityExpirationEnabled** | **bool** | Indicates whether peer inactivity expiration has been enabled or not | 
**ApprovalRequired** | **bool** | (Cloud only) Indicates whether peer needs approval | 
**DisapprovalReason** | **string** | (Cloud only) Reason why the peer requires approval | [optional] 
**CountryCode** | **string** | 2-letter ISO 3166-1 alpha-2 code that represents the country | 
**CityName** | **string** | Commonly used English name of the city | 
**SerialNumber** | **string** | System serial number | 
**ExtraDnsLabels** | **List&lt;string&gt;** | Extra DNS labels added to the peer | 
**Ephemeral** | **bool** | Indicates whether the peer is ephemeral or not | 
**LocalFlags** | [**PeerLocalFlags**](PeerLocalFlags.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

