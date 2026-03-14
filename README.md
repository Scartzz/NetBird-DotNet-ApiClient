# NetBird.ApiClient - C# API Client for the NetBird API

API to manipulate groups, rules, policies and retrieve information about peers and users

This API was originally created using OpenAPI Generator, but has since been heavily customized.

# Installation

````
dotnet add package NetBird.ApiClient
````

## Dependencies

- [RestSharp](https://www.nuget.org/packages/RestSharp) - 114.0.0
- [Polly](https://www.nuget.org/packages/Polly) - 8.6.6

## Usage

To use the API client
```csharp
NetBirdApiClientOptions c = new NetBirdApiClientOptions()
{
    AccessToken = "nbp_XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
    BaseUrl = "https://api.netbird.io/api"
};
var client = new NetBirdApiClient(c);
var peers = await client.PeersApi.ApiPeersGetAsync();
foreach (PeerBatch peer in peers)
{
    Console.WriteLine(peer.ToString());
}
```

## Documentation for API Endpoints

All URIs are relative to *https://api.netbird.io/api*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AWSMarketplaceApi* | [**ApiIntegrationsBillingAwsMarketplaceActivatePost**](docs/AWSMarketplaceApi.md#apiintegrationsbillingawsmarketplaceactivatepost) | **POST** integrations/billing/aws/marketplace/activate | Activate AWS Marketplace subscription.
*AWSMarketplaceApi* | [**ApiIntegrationsBillingAwsMarketplaceEnrichPost**](docs/AWSMarketplaceApi.md#apiintegrationsbillingawsmarketplaceenrichpost) | **POST** integrations/billing/aws/marketplace/enrich | Enrich AWS Marketplace subscription with Account ID.
*AccountsApi* | [**ApiAccountsAccountIdDelete**](docs/AccountsApi.md#apiaccountsaccountiddelete) | **DELETE** accounts/{accountId} | Delete an Account
*AccountsApi* | [**ApiAccountsAccountIdPut**](docs/AccountsApi.md#apiaccountsaccountidput) | **PUT** accounts/{accountId} | Update an Account
*AccountsApi* | [**ApiAccountsGet**](docs/AccountsApi.md#apiaccountsget) | **GET** accounts | List all Accounts
*CheckoutApi* | [**ApiIntegrationsBillingCheckoutPost**](docs/CheckoutApi.md#apiintegrationsbillingcheckoutpost) | **POST** integrations/billing/checkout | Create checkout session
*DNSApi* | [**ApiDnsNameserversGet**](docs/DNSApi.md#apidnsnameserversget) | **GET** dns/nameservers | List all Nameserver Groups
*DNSApi* | [**ApiDnsNameserversNsgroupIdDelete**](docs/DNSApi.md#apidnsnameserversnsgroupiddelete) | **DELETE** dns/nameservers/{nsgroupId} | Delete a Nameserver Group
*DNSApi* | [**ApiDnsNameserversNsgroupIdGet**](docs/DNSApi.md#apidnsnameserversnsgroupidget) | **GET** dns/nameservers/{nsgroupId} | Retrieve a Nameserver Group
*DNSApi* | [**ApiDnsNameserversNsgroupIdPut**](docs/DNSApi.md#apidnsnameserversnsgroupidput) | **PUT** dns/nameservers/{nsgroupId} | Update a Nameserver Group
*DNSApi* | [**ApiDnsNameserversPost**](docs/DNSApi.md#apidnsnameserverspost) | **POST** dns/nameservers | Create a Nameserver Group
*DNSApi* | [**ApiDnsSettingsGet**](docs/DNSApi.md#apidnssettingsget) | **GET** dns/settings | Retrieve DNS settings
*DNSApi* | [**ApiDnsSettingsPut**](docs/DNSApi.md#apidnssettingsput) | **PUT** dns/settings | Update DNS Settings
*DNSZonesApi* | [**ApiDnsZonesGet**](docs/DNSZonesApi.md#apidnszonesget) | **GET** dns/zones | List all DNS Zones
*DNSZonesApi* | [**ApiDnsZonesPost**](docs/DNSZonesApi.md#apidnszonespost) | **POST** dns/zones | Create a DNS Zone
*DNSZonesApi* | [**ApiDnsZonesZoneIdDelete**](docs/DNSZonesApi.md#apidnszoneszoneiddelete) | **DELETE** dns/zones/{zoneId} | Delete a DNS Zone
*DNSZonesApi* | [**ApiDnsZonesZoneIdGet**](docs/DNSZonesApi.md#apidnszoneszoneidget) | **GET** dns/zones/{zoneId} | Retrieve a DNS Zone
*DNSZonesApi* | [**ApiDnsZonesZoneIdPut**](docs/DNSZonesApi.md#apidnszoneszoneidput) | **PUT** dns/zones/{zoneId} | Update a DNS Zone
*DNSZonesApi* | [**ApiDnsZonesZoneIdRecordsGet**](docs/DNSZonesApi.md#apidnszoneszoneidrecordsget) | **GET** dns/zones/{zoneId}/records | List all DNS Records
*DNSZonesApi* | [**ApiDnsZonesZoneIdRecordsPost**](docs/DNSZonesApi.md#apidnszoneszoneidrecordspost) | **POST** dns/zones/{zoneId}/records | Create a DNS Record
*DNSZonesApi* | [**ApiDnsZonesZoneIdRecordsRecordIdDelete**](docs/DNSZonesApi.md#apidnszoneszoneidrecordsrecordiddelete) | **DELETE** dns/zones/{zoneId}/records/{recordId} | Delete a DNS Record
*DNSZonesApi* | [**ApiDnsZonesZoneIdRecordsRecordIdGet**](docs/DNSZonesApi.md#apidnszoneszoneidrecordsrecordidget) | **GET** dns/zones/{zoneId}/records/{recordId} | Retrieve a DNS Record
*DNSZonesApi* | [**ApiDnsZonesZoneIdRecordsRecordIdPut**](docs/DNSZonesApi.md#apidnszoneszoneidrecordsrecordidput) | **PUT** dns/zones/{zoneId}/records/{recordId} | Update a DNS Record
*EDRFalconIntegrationsApi* | [**ApiIntegrationsEdrFalconDelete**](docs/EDRFalconIntegrationsApi.md#apiintegrationsedrfalcondelete) | **DELETE** integrations/edr/falcon | Delete EDR Falcon Integration
*EDRFalconIntegrationsApi* | [**ApiIntegrationsEdrFalconGet**](docs/EDRFalconIntegrationsApi.md#apiintegrationsedrfalconget) | **GET** integrations/edr/falcon | Get EDR Falcon Integration
*EDRFalconIntegrationsApi* | [**CreateFalconEDRIntegration**](docs/EDRFalconIntegrationsApi.md#createfalconedrintegration) | **POST** integrations/edr/falcon | Create EDR Falcon Integration
*EDRFalconIntegrationsApi* | [**UpdateFalconEDRIntegration**](docs/EDRFalconIntegrationsApi.md#updatefalconedrintegration) | **PUT** integrations/edr/falcon | Update EDR Falcon Integration
*EDRHuntressIntegrationsApi* | [**ApiIntegrationsEdrHuntressDelete**](docs/EDRHuntressIntegrationsApi.md#apiintegrationsedrhuntressdelete) | **DELETE** integrations/edr/huntress | Delete EDR Huntress Integration
*EDRHuntressIntegrationsApi* | [**ApiIntegrationsEdrHuntressGet**](docs/EDRHuntressIntegrationsApi.md#apiintegrationsedrhuntressget) | **GET** integrations/edr/huntress | Get EDR Huntress Integration
*EDRHuntressIntegrationsApi* | [**CreateHuntressEDRIntegration**](docs/EDRHuntressIntegrationsApi.md#createhuntressedrintegration) | **POST** integrations/edr/huntress | Create EDR Huntress Integration
*EDRHuntressIntegrationsApi* | [**UpdateHuntressEDRIntegration**](docs/EDRHuntressIntegrationsApi.md#updatehuntressedrintegration) | **PUT** integrations/edr/huntress | Update EDR Huntress Integration
*EDRIntuneIntegrationsApi* | [**CreateEDRIntegration**](docs/EDRIntuneIntegrationsApi.md#createedrintegration) | **POST** integrations/edr/intune | Create EDR Intune Integration
*EDRIntuneIntegrationsApi* | [**DeleteIntegration**](docs/EDRIntuneIntegrationsApi.md#deleteintegration) | **DELETE** integrations/edr/intune | Delete EDR Intune Integration
*EDRIntuneIntegrationsApi* | [**GetEDRIntegration**](docs/EDRIntuneIntegrationsApi.md#getedrintegration) | **GET** integrations/edr/intune | Get EDR Intune Integration
*EDRIntuneIntegrationsApi* | [**UpdateEDRIntegration**](docs/EDRIntuneIntegrationsApi.md#updateedrintegration) | **PUT** integrations/edr/intune | Update EDR Intune Integration
*EDRPeersApi* | [**BypassCompliance**](docs/EDRPeersApi.md#bypasscompliance) | **POST** peers/{peer-id}/edr/bypass | Bypass compliance for a non-compliant peer
*EDRPeersApi* | [**ListBypassedPeers**](docs/EDRPeersApi.md#listbypassedpeers) | **GET** peers/edr/bypassed | List all bypassed peers
*EDRPeersApi* | [**RevokeBypass**](docs/EDRPeersApi.md#revokebypass) | **DELETE** peers/{peer-id}/edr/bypass | Revoke compliance bypass for a peer
*EDRSentinelOneIntegrationsApi* | [**ApiIntegrationsEdrSentineloneDelete**](docs/EDRSentinelOneIntegrationsApi.md#apiintegrationsedrsentinelonedelete) | **DELETE** integrations/edr/sentinelone | Delete EDR SentinelOne Integration
*EDRSentinelOneIntegrationsApi* | [**ApiIntegrationsEdrSentineloneGet**](docs/EDRSentinelOneIntegrationsApi.md#apiintegrationsedrsentineloneget) | **GET** integrations/edr/sentinelone | Get EDR SentinelOne Integration
*EDRSentinelOneIntegrationsApi* | [**CreateSentinelOneEDRIntegration**](docs/EDRSentinelOneIntegrationsApi.md#createsentineloneedrintegration) | **POST** integrations/edr/sentinelone | Create EDR SentinelOne Integration
*EDRSentinelOneIntegrationsApi* | [**UpdateSentinelOneEDRIntegration**](docs/EDRSentinelOneIntegrationsApi.md#updatesentineloneedrintegration) | **PUT** integrations/edr/sentinelone | Update EDR SentinelOne Integration
*EventStreamingIntegrationsApi* | [**CreateIntegration**](docs/EventStreamingIntegrationsApi.md#createintegration) | **POST** event-streaming | Create Event Streaming Integration
*EventStreamingIntegrationsApi* | [**DeleteIntegration**](docs/EventStreamingIntegrationsApi.md#deleteintegration) | **DELETE** event-streaming/{id} | Delete Event Streaming Integration
*EventStreamingIntegrationsApi* | [**GetAllIntegrations**](docs/EventStreamingIntegrationsApi.md#getallintegrations) | **GET** event-streaming | List Event Streaming Integrations
*EventStreamingIntegrationsApi* | [**GetIntegration**](docs/EventStreamingIntegrationsApi.md#getintegration) | **GET** event-streaming/{id} | Get Event Streaming Integration
*EventStreamingIntegrationsApi* | [**UpdateIntegration**](docs/EventStreamingIntegrationsApi.md#updateintegration) | **PUT** event-streaming/{id} | Update Event Streaming Integration
*EventsApi* | [**ApiEventsAuditGet**](docs/EventsApi.md#apieventsauditget) | **GET** events/audit | List all Audit Events
*EventsApi* | [**ApiEventsNetworkTrafficGet**](docs/EventsApi.md#apieventsnetworktrafficget) | **GET** events/network-traffic | List all Traffic Events
*EventsApi* | [**ApiEventsProxyGet**](docs/EventsApi.md#apieventsproxyget) | **GET** events/proxy | List all Reverse Proxy Access Logs
*GeoLocationsApi* | [**ApiLocationsCountriesCountryCitiesGet**](docs/GeoLocationsApi.md#apilocationscountriescountrycitiesget) | **GET** locations/countries/{country}/cities | List all city names by country
*GeoLocationsApi* | [**ApiLocationsCountriesGet**](docs/GeoLocationsApi.md#apilocationscountriesget) | **GET** locations/countries | List all country codes
*GroupsApi* | [**ApiGroupsGet**](docs/GroupsApi.md#apigroupsget) | **GET** groups | List all Groups
*GroupsApi* | [**ApiGroupsGroupIdDelete**](docs/GroupsApi.md#apigroupsgroupiddelete) | **DELETE** groups/{groupId} | Delete a Group
*GroupsApi* | [**ApiGroupsGroupIdGet**](docs/GroupsApi.md#apigroupsgroupidget) | **GET** groups/{groupId} | Retrieve a Group
*GroupsApi* | [**ApiGroupsGroupIdPut**](docs/GroupsApi.md#apigroupsgroupidput) | **PUT** groups/{groupId} | Update a Group
*GroupsApi* | [**ApiGroupsPost**](docs/GroupsApi.md#apigroupspost) | **POST** groups | Create a Group
*IDPApi* | [**CreateSCIMIntegration**](docs/IDPApi.md#createscimintegration) | **POST** integrations/scim-idp | Create SCIM IDP Integration
*IDPApi* | [**DeleteSCIMIntegration**](docs/IDPApi.md#deletescimintegration) | **DELETE** integrations/scim-idp/{id} | Delete SCIM IDP Integration
*IDPApi* | [**GetAllSCIMIntegrations**](docs/IDPApi.md#getallscimintegrations) | **GET** integrations/scim-idp | Get All SCIM IDP Integrations
*IDPApi* | [**GetSCIMIntegration**](docs/IDPApi.md#getscimintegration) | **GET** integrations/scim-idp/{id} | Get SCIM IDP Integration
*IDPApi* | [**GetSCIMIntegrationLogs**](docs/IDPApi.md#getscimintegrationlogs) | **GET** integrations/scim-idp/{id}/logs | Get SCIM Integration Sync Logs
*IDPApi* | [**RegenerateSCIMToken**](docs/IDPApi.md#regeneratescimtoken) | **POST** integrations/scim-idp/{id}/token | Regenerate SCIM Token
*IDPApi* | [**UpdateSCIMIntegration**](docs/IDPApi.md#updatescimintegration) | **PUT** integrations/scim-idp/{id} | Update SCIM IDP Integration
*IdentityProvidersApi* | [**ApiIdentityProvidersGet**](docs/IdentityProvidersApi.md#apiidentityprovidersget) | **GET** identity-providers | List all Identity Providers
*IdentityProvidersApi* | [**ApiIdentityProvidersIdpIdDelete**](docs/IdentityProvidersApi.md#apiidentityprovidersidpiddelete) | **DELETE** identity-providers/{idpId} | Delete an Identity Provider
*IdentityProvidersApi* | [**ApiIdentityProvidersIdpIdGet**](docs/IdentityProvidersApi.md#apiidentityprovidersidpidget) | **GET** identity-providers/{idpId} | Retrieve an Identity Provider
*IdentityProvidersApi* | [**ApiIdentityProvidersIdpIdPut**](docs/IdentityProvidersApi.md#apiidentityprovidersidpidput) | **PUT** identity-providers/{idpId} | Update an Identity Provider
*IdentityProvidersApi* | [**ApiIdentityProvidersPost**](docs/IdentityProvidersApi.md#apiidentityproviderspost) | **POST** identity-providers | Create an Identity Provider
*IngressPortsApi* | [**ApiIngressPeersGet**](docs/IngressPortsApi.md#apiingresspeersget) | **GET** ingress/peers | List all Ingress Peers
*IngressPortsApi* | [**ApiIngressPeersIngressPeerIdDelete**](docs/IngressPortsApi.md#apiingresspeersingresspeeriddelete) | **DELETE** ingress/peers/{ingressPeerId} | Delete a Ingress Peer
*IngressPortsApi* | [**ApiIngressPeersIngressPeerIdGet**](docs/IngressPortsApi.md#apiingresspeersingresspeeridget) | **GET** ingress/peers/{ingressPeerId} | Retrieve a Ingress Peer
*IngressPortsApi* | [**ApiIngressPeersIngressPeerIdPut**](docs/IngressPortsApi.md#apiingresspeersingresspeeridput) | **PUT** ingress/peers/{ingressPeerId} | Update a Ingress Peer
*IngressPortsApi* | [**ApiIngressPeersPost**](docs/IngressPortsApi.md#apiingresspeerspost) | **POST** ingress/peers | Create a Ingress Peer
*IngressPortsApi* | [**ApiPeersPeerIdIngressPortsAllocationIdDelete**](docs/IngressPortsApi.md#apipeerspeeridingressportsallocationiddelete) | **DELETE** peers/{peerId}/ingress/ports/{allocationId} | Delete a Port Allocation
*IngressPortsApi* | [**ApiPeersPeerIdIngressPortsAllocationIdGet**](docs/IngressPortsApi.md#apipeerspeeridingressportsallocationidget) | **GET** peers/{peerId}/ingress/ports/{allocationId} | Retrieve a Port Allocation
*IngressPortsApi* | [**ApiPeersPeerIdIngressPortsAllocationIdPut**](docs/IngressPortsApi.md#apipeerspeeridingressportsallocationidput) | **PUT** peers/{peerId}/ingress/ports/{allocationId} | Update a Port Allocation
*IngressPortsApi* | [**ApiPeersPeerIdIngressPortsGet**](docs/IngressPortsApi.md#apipeerspeeridingressportsget) | **GET** peers/{peerId}/ingress/ports | List all Port Allocations
*IngressPortsApi* | [**ApiPeersPeerIdIngressPortsPost**](docs/IngressPortsApi.md#apipeerspeeridingressportspost) | **POST** peers/{peerId}/ingress/ports | Create a Port Allocation
*InstanceApi* | [**ApiInstanceGet**](docs/InstanceApi.md#apiinstanceget) | **GET** instance | Get Instance Status
*InstanceApi* | [**ApiInstanceVersionGet**](docs/InstanceApi.md#apiinstanceversionget) | **GET** instance/version | Get Version Info
*InstanceApi* | [**ApiSetupPost**](docs/InstanceApi.md#apisetuppost) | **POST** setup | Setup Instance
*InvoiceApi* | [**ApiIntegrationsBillingInvoicesGet**](docs/InvoiceApi.md#apiintegrationsbillinginvoicesget) | **GET** integrations/billing/invoices | Get account's paid invoices
*InvoiceApi* | [**ApiIntegrationsBillingInvoicesIdCsvGet**](docs/InvoiceApi.md#apiintegrationsbillinginvoicesidcsvget) | **GET** integrations/billing/invoices/{id}/csv | Get account invoice CSV.
*InvoiceApi* | [**ApiIntegrationsBillingInvoicesIdPdfGet**](docs/InvoiceApi.md#apiintegrationsbillinginvoicesidpdfget) | **GET** integrations/billing/invoices/{id}/pdf | Get account invoice URL to Stripe.
*JobsApi* | [**ApiPeersPeerIdJobsGet**](docs/JobsApi.md#apipeerspeeridjobsget) | **GET** peers/{peerId}/jobs | List Jobs
*JobsApi* | [**ApiPeersPeerIdJobsJobIdGet**](docs/JobsApi.md#apipeerspeeridjobsjobidget) | **GET** peers/{peerId}/jobs/{jobId} | Get Job
*JobsApi* | [**ApiPeersPeerIdJobsPost**](docs/JobsApi.md#apipeerspeeridjobspost) | **POST** peers/{peerId}/jobs | Create Job
*MSPApi* | [**ApiIntegrationsMspTenantsGet**](docs/MSPApi.md#apiintegrationsmsptenantsget) | **GET** integrations/msp/tenants | Get MSP tenants
*MSPApi* | [**ApiIntegrationsMspTenantsIdDnsPost**](docs/MSPApi.md#apiintegrationsmsptenantsiddnspost) | **POST** integrations/msp/tenants/{id}/dns | Verify a tenant domain DNS challenge
*MSPApi* | [**ApiIntegrationsMspTenantsIdInvitePost**](docs/MSPApi.md#apiintegrationsmsptenantsidinvitepost) | **POST** integrations/msp/tenants/{id}/invite | Invite existing account as a Tenant to the MSP account
*MSPApi* | [**ApiIntegrationsMspTenantsIdInvitePut**](docs/MSPApi.md#apiintegrationsmsptenantsidinviteput) | **PUT** integrations/msp/tenants/{id}/invite | Response by the invited Tenant account owner
*MSPApi* | [**ApiIntegrationsMspTenantsIdPut**](docs/MSPApi.md#apiintegrationsmsptenantsidput) | **PUT** integrations/msp/tenants/{id} | Update MSP tenant
*MSPApi* | [**ApiIntegrationsMspTenantsIdSubscriptionPost**](docs/MSPApi.md#apiintegrationsmsptenantsidsubscriptionpost) | **POST** integrations/msp/tenants/{id}/subscription | Create subscription for Tenant
*MSPApi* | [**ApiIntegrationsMspTenantsIdUnlinkPost**](docs/MSPApi.md#apiintegrationsmsptenantsidunlinkpost) | **POST** integrations/msp/tenants/{id}/unlink | Unlink a tenant
*MSPApi* | [**ApiIntegrationsMspTenantsPost**](docs/MSPApi.md#apiintegrationsmsptenantspost) | **POST** integrations/msp/tenants | Create MSP tenant
*NetworksApi* | [**ApiNetworksGet**](docs/NetworksApi.md#apinetworksget) | **GET** networks | List all Networks
*NetworksApi* | [**ApiNetworksNetworkIdDelete**](docs/NetworksApi.md#apinetworksnetworkiddelete) | **DELETE** networks/{networkId} | Delete a Network
*NetworksApi* | [**ApiNetworksNetworkIdGet**](docs/NetworksApi.md#apinetworksnetworkidget) | **GET** networks/{networkId} | Retrieve a Network
*NetworksApi* | [**ApiNetworksNetworkIdPut**](docs/NetworksApi.md#apinetworksnetworkidput) | **PUT** networks/{networkId} | Update a Network
*NetworksApi* | [**ApiNetworksNetworkIdResourcesGet**](docs/NetworksApi.md#apinetworksnetworkidresourcesget) | **GET** networks/{networkId}/resources | List all Network Resources
*NetworksApi* | [**ApiNetworksNetworkIdResourcesPost**](docs/NetworksApi.md#apinetworksnetworkidresourcespost) | **POST** networks/{networkId}/resources | Create a Network Resource
*NetworksApi* | [**ApiNetworksNetworkIdResourcesResourceIdDelete**](docs/NetworksApi.md#apinetworksnetworkidresourcesresourceiddelete) | **DELETE** networks/{networkId}/resources/{resourceId} | Delete a Network Resource
*NetworksApi* | [**ApiNetworksNetworkIdResourcesResourceIdGet**](docs/NetworksApi.md#apinetworksnetworkidresourcesresourceidget) | **GET** networks/{networkId}/resources/{resourceId} | Retrieve a Network Resource
*NetworksApi* | [**ApiNetworksNetworkIdResourcesResourceIdPut**](docs/NetworksApi.md#apinetworksnetworkidresourcesresourceidput) | **PUT** networks/{networkId}/resources/{resourceId} | Update a Network Resource
*NetworksApi* | [**ApiNetworksNetworkIdRoutersGet**](docs/NetworksApi.md#apinetworksnetworkidroutersget) | **GET** networks/{networkId}/routers | List all Network Routers
*NetworksApi* | [**ApiNetworksNetworkIdRoutersPost**](docs/NetworksApi.md#apinetworksnetworkidrouterspost) | **POST** networks/{networkId}/routers | Create a Network Router
*NetworksApi* | [**ApiNetworksNetworkIdRoutersRouterIdDelete**](docs/NetworksApi.md#apinetworksnetworkidroutersrouteriddelete) | **DELETE** networks/{networkId}/routers/{routerId} | Delete a Network Router
*NetworksApi* | [**ApiNetworksNetworkIdRoutersRouterIdGet**](docs/NetworksApi.md#apinetworksnetworkidroutersrouteridget) | **GET** networks/{networkId}/routers/{routerId} | Retrieve a Network Router
*NetworksApi* | [**ApiNetworksNetworkIdRoutersRouterIdPut**](docs/NetworksApi.md#apinetworksnetworkidroutersrouteridput) | **PUT** networks/{networkId}/routers/{routerId} | Update a Network Router
*NetworksApi* | [**ApiNetworksPost**](docs/NetworksApi.md#apinetworkspost) | **POST** networks | Create a Network
*NetworksApi* | [**ApiNetworksRoutersGet**](docs/NetworksApi.md#apinetworksroutersget) | **GET** networks/routers | List all Network Routers
*PeersApi* | [**ApiPeersGet**](docs/PeersApi.md#apipeersget) | **GET** peers | List all Peers
*PeersApi* | [**ApiPeersPeerIdAccessiblePeersGet**](docs/PeersApi.md#apipeerspeeridaccessiblepeersget) | **GET** peers/{peerId}/accessible-peers | List accessible Peers
*PeersApi* | [**ApiPeersPeerIdDelete**](docs/PeersApi.md#apipeerspeeriddelete) | **DELETE** peers/{peerId} | Delete a Peer
*PeersApi* | [**ApiPeersPeerIdGet**](docs/PeersApi.md#apipeerspeeridget) | **GET** peers/{peerId} | Retrieve a Peer
*PeersApi* | [**ApiPeersPeerIdPut**](docs/PeersApi.md#apipeerspeeridput) | **PUT** peers/{peerId} | Update a Peer
*PeersApi* | [**ApiPeersPeerIdTemporaryAccessPost**](docs/PeersApi.md#apipeerspeeridtemporaryaccesspost) | **POST** peers/{peerId}/temporary-access | Create a Temporary Access Peer
*PlansApi* | [**ApiIntegrationsBillingPlansGet**](docs/PlansApi.md#apiintegrationsbillingplansget) | **GET** integrations/billing/plans | Get available plans
*PoliciesApi* | [**ApiPoliciesGet**](docs/PoliciesApi.md#apipoliciesget) | **GET** policies | List all Policies
*PoliciesApi* | [**ApiPoliciesPolicyIdDelete**](docs/PoliciesApi.md#apipoliciespolicyiddelete) | **DELETE** policies/{policyId} | Delete a Policy
*PoliciesApi* | [**ApiPoliciesPolicyIdGet**](docs/PoliciesApi.md#apipoliciespolicyidget) | **GET** policies/{policyId} | Retrieve a Policy
*PoliciesApi* | [**ApiPoliciesPolicyIdPut**](docs/PoliciesApi.md#apipoliciespolicyidput) | **PUT** policies/{policyId} | Update a Policy
*PoliciesApi* | [**ApiPoliciesPost**](docs/PoliciesApi.md#apipoliciespost) | **POST** policies | Create a Policy
*PortalApi* | [**ApiIntegrationsBillingPortalGet**](docs/PortalApi.md#apiintegrationsbillingportalget) | **GET** integrations/billing/portal | Get customer portal URL
*PostureChecksApi* | [**ApiPostureChecksGet**](docs/PostureChecksApi.md#apiposturechecksget) | **GET** posture-checks | List all Posture Checks
*PostureChecksApi* | [**ApiPostureChecksPost**](docs/PostureChecksApi.md#apiposturecheckspost) | **POST** posture-checks | Create a Posture Check
*PostureChecksApi* | [**ApiPostureChecksPostureCheckIdDelete**](docs/PostureChecksApi.md#apiposturechecksposturecheckiddelete) | **DELETE** posture-checks/{postureCheckId} | Delete a Posture Check
*PostureChecksApi* | [**ApiPostureChecksPostureCheckIdGet**](docs/PostureChecksApi.md#apiposturechecksposturecheckidget) | **GET** posture-checks/{postureCheckId} | Retrieve a Posture Check
*PostureChecksApi* | [**ApiPostureChecksPostureCheckIdPut**](docs/PostureChecksApi.md#apiposturechecksposturecheckidput) | **PUT** posture-checks/{postureCheckId} | Update a Posture Check
*RoutesApi* | [**ApiRoutesGet**](docs/RoutesApi.md#apiroutesget) | **GET** routes | List all Routes
*RoutesApi* | [**ApiRoutesPost**](docs/RoutesApi.md#apiroutespost) | **POST** routes | Create a Route
*RoutesApi* | [**ApiRoutesRouteIdDelete**](docs/RoutesApi.md#apiroutesrouteiddelete) | **DELETE** routes/{routeId} | Delete a Route
*RoutesApi* | [**ApiRoutesRouteIdGet**](docs/RoutesApi.md#apiroutesrouteidget) | **GET** routes/{routeId} | Retrieve a Route
*RoutesApi* | [**ApiRoutesRouteIdPut**](docs/RoutesApi.md#apiroutesrouteidput) | **PUT** routes/{routeId} | Update a Route
*ServicesApi* | [**ApiReverseProxiesClustersGet**](docs/ServicesApi.md#apireverseproxiesclustersget) | **GET** reverse-proxies/clusters | List available proxy clusters
*ServicesApi* | [**ApiReverseProxiesDomainsDomainIdDelete**](docs/ServicesApi.md#apireverseproxiesdomainsdomainiddelete) | **DELETE** reverse-proxies/domains/{domainId} | Delete a Custom domain
*ServicesApi* | [**ApiReverseProxiesDomainsDomainIdValidateGet**](docs/ServicesApi.md#apireverseproxiesdomainsdomainidvalidateget) | **GET** reverse-proxies/domains/{domainId}/validate | Validate a custom domain
*ServicesApi* | [**ApiReverseProxiesDomainsGet**](docs/ServicesApi.md#apireverseproxiesdomainsget) | **GET** reverse-proxies/domains | Retrieve Service Domains
*ServicesApi* | [**ApiReverseProxiesDomainsPost**](docs/ServicesApi.md#apireverseproxiesdomainspost) | **POST** reverse-proxies/domains | Create a Custom domain
*ServicesApi* | [**ApiReverseProxiesServicesGet**](docs/ServicesApi.md#apireverseproxiesservicesget) | **GET** reverse-proxies/services | List all Services
*ServicesApi* | [**ApiReverseProxiesServicesPost**](docs/ServicesApi.md#apireverseproxiesservicespost) | **POST** reverse-proxies/services | Create a Service
*ServicesApi* | [**ApiReverseProxiesServicesServiceIdDelete**](docs/ServicesApi.md#apireverseproxiesservicesserviceiddelete) | **DELETE** reverse-proxies/services/{serviceId} | Delete a Service
*ServicesApi* | [**ApiReverseProxiesServicesServiceIdGet**](docs/ServicesApi.md#apireverseproxiesservicesserviceidget) | **GET** reverse-proxies/services/{serviceId} | Retrieve a Service
*ServicesApi* | [**ApiReverseProxiesServicesServiceIdPut**](docs/ServicesApi.md#apireverseproxiesservicesserviceidput) | **PUT** reverse-proxies/services/{serviceId} | Update a Service
*SetupKeysApi* | [**ApiSetupKeysGet**](docs/SetupKeysApi.md#apisetupkeysget) | **GET** setup-keys | List all Setup Keys
*SetupKeysApi* | [**ApiSetupKeysKeyIdDelete**](docs/SetupKeysApi.md#apisetupkeyskeyiddelete) | **DELETE** setup-keys/{keyId} | Delete a Setup Key
*SetupKeysApi* | [**ApiSetupKeysKeyIdGet**](docs/SetupKeysApi.md#apisetupkeyskeyidget) | **GET** setup-keys/{keyId} | Retrieve a Setup Key
*SetupKeysApi* | [**ApiSetupKeysKeyIdPut**](docs/SetupKeysApi.md#apisetupkeyskeyidput) | **PUT** setup-keys/{keyId} | Update a Setup Key
*SetupKeysApi* | [**ApiSetupKeysPost**](docs/SetupKeysApi.md#apisetupkeyspost) | **POST** setup-keys | Create a Setup Key
*SubscriptionApi* | [**ApiIntegrationsBillingSubscriptionGet**](docs/SubscriptionApi.md#apiintegrationsbillingsubscriptionget) | **GET** integrations/billing/subscription | Get current subscription
*SubscriptionApi* | [**ApiIntegrationsBillingSubscriptionPut**](docs/SubscriptionApi.md#apiintegrationsbillingsubscriptionput) | **PUT** integrations/billing/subscription | Change subscription
*TokensApi* | [**ApiUsersUserIdTokensGet**](docs/TokensApi.md#apiusersuseridtokensget) | **GET** users/{userId}/tokens | List all Tokens
*TokensApi* | [**ApiUsersUserIdTokensPost**](docs/TokensApi.md#apiusersuseridtokenspost) | **POST** users/{userId}/tokens | Create a Token
*TokensApi* | [**ApiUsersUserIdTokensTokenIdDelete**](docs/TokensApi.md#apiusersuseridtokenstokeniddelete) | **DELETE** users/{userId}/tokens/{tokenId} | Delete a Token
*TokensApi* | [**ApiUsersUserIdTokensTokenIdGet**](docs/TokensApi.md#apiusersuseridtokenstokenidget) | **GET** users/{userId}/tokens/{tokenId} | Retrieve a Token
*UsageApi* | [**ApiIntegrationsBillingUsageGet**](docs/UsageApi.md#apiintegrationsbillingusageget) | **GET** integrations/billing/usage | Get current usage
*UsersApi* | [**ApiUsersCurrentGet**](docs/UsersApi.md#apiuserscurrentget) | **GET** users/current | Retrieve current user
*UsersApi* | [**ApiUsersGet**](docs/UsersApi.md#apiusersget) | **GET** users | List all Users
*UsersApi* | [**ApiUsersInvitesGet**](docs/UsersApi.md#apiusersinvitesget) | **GET** users/invites | List user invites
*UsersApi* | [**ApiUsersInvitesInviteIdDelete**](docs/UsersApi.md#apiusersinvitesinviteiddelete) | **DELETE** users/invites/{inviteId} | Delete a user invite
*UsersApi* | [**ApiUsersInvitesInviteIdRegeneratePost**](docs/UsersApi.md#apiusersinvitesinviteidregeneratepost) | **POST** users/invites/{inviteId}/regenerate | Regenerate a user invite
*UsersApi* | [**ApiUsersInvitesPost**](docs/UsersApi.md#apiusersinvitespost) | **POST** users/invites | Create a user invite
*UsersApi* | [**ApiUsersInvitesTokenAcceptPost**](docs/UsersApi.md#apiusersinvitestokenacceptpost) | **POST** users/invites/{token}/accept | Accept an invite
*UsersApi* | [**ApiUsersInvitesTokenGet**](docs/UsersApi.md#apiusersinvitestokenget) | **GET** users/invites/{token} | Get invite information
*UsersApi* | [**ApiUsersPost**](docs/UsersApi.md#apiuserspost) | **POST** users | Create a User
*UsersApi* | [**ApiUsersUserIdApprovePost**](docs/UsersApi.md#apiusersuseridapprovepost) | **POST** users/{userId}/approve | Approve user
*UsersApi* | [**ApiUsersUserIdDelete**](docs/UsersApi.md#apiusersuseriddelete) | **DELETE** users/{userId} | Delete a User
*UsersApi* | [**ApiUsersUserIdInvitePost**](docs/UsersApi.md#apiusersuseridinvitepost) | **POST** users/{userId}/invite | Resend user invitation
*UsersApi* | [**ApiUsersUserIdPasswordPut**](docs/UsersApi.md#apiusersuseridpasswordput) | **PUT** users/{userId}/password | Change user password
*UsersApi* | [**ApiUsersUserIdPut**](docs/UsersApi.md#apiusersuseridput) | **PUT** users/{userId} | Update a User
*UsersApi* | [**ApiUsersUserIdRejectDelete**](docs/UsersApi.md#apiusersuseridrejectdelete) | **DELETE** users/{userId}/reject | Reject user


<a id="documentation-for-models"></a>
## Documentation for Models

- [Model.AccessiblePeer](docs/AccessiblePeer.md)
- [Model.Account](docs/Account.md)
- [Model.AccountExtraSettings](docs/AccountExtraSettings.md)
- [Model.AccountOnboarding](docs/AccountOnboarding.md)
- [Model.AccountRequest](docs/AccountRequest.md)
- [Model.AccountSettings](docs/AccountSettings.md)
- [Model.ApiIntegrationsBillingAwsMarketplaceActivatePostRequest](docs/ApiIntegrationsBillingAwsMarketplaceActivatePostRequest.md)
- [Model.ApiIntegrationsBillingAwsMarketplaceEnrichPostRequest](docs/ApiIntegrationsBillingAwsMarketplaceEnrichPostRequest.md)
- [Model.ApiIntegrationsBillingCheckoutPostRequest](docs/ApiIntegrationsBillingCheckoutPostRequest.md)
- [Model.ApiIntegrationsBillingSubscriptionPutRequest](docs/ApiIntegrationsBillingSubscriptionPutRequest.md)
- [Model.ApiIntegrationsMspTenantsIdInvitePutRequest](docs/ApiIntegrationsMspTenantsIdInvitePutRequest.md)
- [Model.ApiIntegrationsMspTenantsIdSubscriptionPostRequest](docs/ApiIntegrationsMspTenantsIdSubscriptionPostRequest.md)
- [Model.ApiIntegrationsMspTenantsIdUnlinkPostRequest](docs/ApiIntegrationsMspTenantsIdUnlinkPostRequest.md)
- [Model.AvailablePorts](docs/AvailablePorts.md)
- [Model.BearerAuthConfig](docs/BearerAuthConfig.md)
- [Model.BundleParameters](docs/BundleParameters.md)
- [Model.BundleResult](docs/BundleResult.md)
- [Model.BundleWorkloadRequest](docs/BundleWorkloadRequest.md)
- [Model.BundleWorkloadResponse](docs/BundleWorkloadResponse.md)
- [Model.BypassResponse](docs/BypassResponse.md)
- [Model.CheckoutResponse](docs/CheckoutResponse.md)
- [Model.Checks](docs/Checks.md)
- [Model.City](docs/City.md)
- [Model.Country](docs/Country.md)
- [Model.CreateIntegrationRequest](docs/CreateIntegrationRequest.md)
- [Model.CreateScimIntegrationRequest](docs/CreateScimIntegrationRequest.md)
- [Model.CreateSetupKeyRequest](docs/CreateSetupKeyRequest.md)
- [Model.CreateTenantRequest](docs/CreateTenantRequest.md)
- [Model.DNSChallengeResponse](docs/DNSChallengeResponse.md)
- [Model.DNSRecord](docs/DNSRecord.md)
- [Model.DNSRecordRequest](docs/DNSRecordRequest.md)
- [Model.DNSRecordType](docs/DNSRecordType.md)
- [Model.DNSSettings](docs/DNSSettings.md)
- [Model.EDRFalconRequest](docs/EDRFalconRequest.md)
- [Model.EDRFalconResponse](docs/EDRFalconResponse.md)
- [Model.EDRHuntressRequest](docs/EDRHuntressRequest.md)
- [Model.EDRHuntressResponse](docs/EDRHuntressResponse.md)
- [Model.EDRIntuneRequest](docs/EDRIntuneRequest.md)
- [Model.EDRIntuneResponse](docs/EDRIntuneResponse.md)
- [Model.EDRSentinelOneRequest](docs/EDRSentinelOneRequest.md)
- [Model.EDRSentinelOneResponse](docs/EDRSentinelOneResponse.md)
- [Model.ErrorResponse](docs/ErrorResponse.md)
- [Model.Event](docs/Event.md)
- [Model.GeoLocationCheck](docs/GeoLocationCheck.md)
- [Model.Group](docs/Group.md)
- [Model.GroupMinimum](docs/GroupMinimum.md)
- [Model.GroupRequest](docs/GroupRequest.md)
- [Model.HuntressMatchAttributes](docs/HuntressMatchAttributes.md)
- [Model.IdentityProvider](docs/IdentityProvider.md)
- [Model.IdentityProviderRequest](docs/IdentityProviderRequest.md)
- [Model.IdentityProviderType](docs/IdentityProviderType.md)
- [Model.IdpIntegrationSyncLog](docs/IdpIntegrationSyncLog.md)
- [Model.IngressPeer](docs/IngressPeer.md)
- [Model.IngressPeerCreateRequest](docs/IngressPeerCreateRequest.md)
- [Model.IngressPeerUpdateRequest](docs/IngressPeerUpdateRequest.md)
- [Model.IngressPortAllocation](docs/IngressPortAllocation.md)
- [Model.IngressPortAllocationPortMapping](docs/IngressPortAllocationPortMapping.md)
- [Model.IngressPortAllocationRequest](docs/IngressPortAllocationRequest.md)
- [Model.IngressPortAllocationRequestDirectPort](docs/IngressPortAllocationRequestDirectPort.md)
- [Model.IngressPortAllocationRequestPortRange](docs/IngressPortAllocationRequestPortRange.md)
- [Model.InstanceStatus](docs/InstanceStatus.md)
- [Model.InstanceVersionInfo](docs/InstanceVersionInfo.md)
- [Model.IntegrationResponse](docs/IntegrationResponse.md)
- [Model.InvoicePDFResponse](docs/InvoicePDFResponse.md)
- [Model.InvoiceResponse](docs/InvoiceResponse.md)
- [Model.JobRequest](docs/JobRequest.md)
- [Model.JobResponse](docs/JobResponse.md)
- [Model.LinkAuthConfig](docs/LinkAuthConfig.md)
- [Model.Location](docs/Location.md)
- [Model.MinKernelVersionCheck](docs/MinKernelVersionCheck.md)
- [Model.MinVersionCheck](docs/MinVersionCheck.md)
- [Model.NBVersionCheck](docs/NBVersionCheck.md)
- [Model.Nameserver](docs/Nameserver.md)
- [Model.NameserverGroup](docs/NameserverGroup.md)
- [Model.NameserverGroupRequest](docs/NameserverGroupRequest.md)
- [Model.Network](docs/Network.md)
- [Model.NetworkRequest](docs/NetworkRequest.md)
- [Model.NetworkResource](docs/NetworkResource.md)
- [Model.NetworkResourceMinimum](docs/NetworkResourceMinimum.md)
- [Model.NetworkResourceRequest](docs/NetworkResourceRequest.md)
- [Model.NetworkResourceType](docs/NetworkResourceType.md)
- [Model.NetworkRouter](docs/NetworkRouter.md)
- [Model.NetworkRouterRequest](docs/NetworkRouterRequest.md)
- [Model.NetworkTrafficEndpoint](docs/NetworkTrafficEndpoint.md)
- [Model.NetworkTrafficEvent](docs/NetworkTrafficEvent.md)
- [Model.NetworkTrafficEventsResponse](docs/NetworkTrafficEventsResponse.md)
- [Model.NetworkTrafficICMP](docs/NetworkTrafficICMP.md)
- [Model.NetworkTrafficLocation](docs/NetworkTrafficLocation.md)
- [Model.NetworkTrafficPolicy](docs/NetworkTrafficPolicy.md)
- [Model.NetworkTrafficSubEvent](docs/NetworkTrafficSubEvent.md)
- [Model.NetworkTrafficUser](docs/NetworkTrafficUser.md)
- [Model.OSVersionCheck](docs/OSVersionCheck.md)
- [Model.PINAuthConfig](docs/PINAuthConfig.md)
- [Model.PasswordAuthConfig](docs/PasswordAuthConfig.md)
- [Model.PasswordChangeRequest](docs/PasswordChangeRequest.md)
- [Model.Peer](docs/Peer.md)
- [Model.PeerBatch](docs/PeerBatch.md)
- [Model.PeerLocalFlags](docs/PeerLocalFlags.md)
- [Model.PeerMinimum](docs/PeerMinimum.md)
- [Model.PeerNetworkRangeCheck](docs/PeerNetworkRangeCheck.md)
- [Model.PeerRequest](docs/PeerRequest.md)
- [Model.PeerTemporaryAccessRequest](docs/PeerTemporaryAccessRequest.md)
- [Model.PeerTemporaryAccessResponse](docs/PeerTemporaryAccessResponse.md)
- [Model.PersonalAccessToken](docs/PersonalAccessToken.md)
- [Model.PersonalAccessTokenGenerated](docs/PersonalAccessTokenGenerated.md)
- [Model.PersonalAccessTokenRequest](docs/PersonalAccessTokenRequest.md)
- [Model.Policy](docs/Policy.md)
- [Model.PolicyCreate](docs/PolicyCreate.md)
- [Model.PolicyMinimum](docs/PolicyMinimum.md)
- [Model.PolicyRule](docs/PolicyRule.md)
- [Model.PolicyRuleCreate](docs/PolicyRuleCreate.md)
- [Model.PolicyRuleMinimum](docs/PolicyRuleMinimum.md)
- [Model.PolicyRuleUpdate](docs/PolicyRuleUpdate.md)
- [Model.PolicyUpdate](docs/PolicyUpdate.md)
- [Model.PortalResponse](docs/PortalResponse.md)
- [Model.PostureCheck](docs/PostureCheck.md)
- [Model.PostureCheckUpdate](docs/PostureCheckUpdate.md)
- [Model.Price](docs/Price.md)
- [Model.Process](docs/Process.md)
- [Model.ProcessCheck](docs/ProcessCheck.md)
- [Model.Product](docs/Product.md)
- [Model.ProxyAccessLog](docs/ProxyAccessLog.md)
- [Model.ProxyAccessLogsResponse](docs/ProxyAccessLogsResponse.md)
- [Model.ProxyCluster](docs/ProxyCluster.md)
- [Model.Resource](docs/Resource.md)
- [Model.ResourceType](docs/ResourceType.md)
- [Model.ReverseProxyDomain](docs/ReverseProxyDomain.md)
- [Model.ReverseProxyDomainRequest](docs/ReverseProxyDomainRequest.md)
- [Model.ReverseProxyDomainType](docs/ReverseProxyDomainType.md)
- [Model.Route](docs/Route.md)
- [Model.RouteRequest](docs/RouteRequest.md)
- [Model.RulePortRange](docs/RulePortRange.md)
- [Model.ScimIntegration](docs/ScimIntegration.md)
- [Model.ScimTokenResponse](docs/ScimTokenResponse.md)
- [Model.SentinelOneMatchAttributes](docs/SentinelOneMatchAttributes.md)
- [Model.Service](docs/Service.md)
- [Model.ServiceAuthConfig](docs/ServiceAuthConfig.md)
- [Model.ServiceMeta](docs/ServiceMeta.md)
- [Model.ServiceRequest](docs/ServiceRequest.md)
- [Model.ServiceTarget](docs/ServiceTarget.md)
- [Model.ServiceTargetOptions](docs/ServiceTargetOptions.md)
- [Model.SetupKey](docs/SetupKey.md)
- [Model.SetupKeyBase](docs/SetupKeyBase.md)
- [Model.SetupKeyClear](docs/SetupKeyClear.md)
- [Model.SetupKeyRequest](docs/SetupKeyRequest.md)
- [Model.SetupRequest](docs/SetupRequest.md)
- [Model.SetupResponse](docs/SetupResponse.md)
- [Model.StripeWebhookEvent](docs/StripeWebhookEvent.md)
- [Model.Subscription](docs/Subscription.md)
- [Model.TenantGroupResponse](docs/TenantGroupResponse.md)
- [Model.TenantResponse](docs/TenantResponse.md)
- [Model.UpdateScimIntegrationRequest](docs/UpdateScimIntegrationRequest.md)
- [Model.UpdateTenantRequest](docs/UpdateTenantRequest.md)
- [Model.UsageStats](docs/UsageStats.md)
- [Model.User](docs/User.md)
- [Model.UserCreateRequest](docs/UserCreateRequest.md)
- [Model.UserInvite](docs/UserInvite.md)
- [Model.UserInviteAcceptRequest](docs/UserInviteAcceptRequest.md)
- [Model.UserInviteAcceptResponse](docs/UserInviteAcceptResponse.md)
- [Model.UserInviteCreateRequest](docs/UserInviteCreateRequest.md)
- [Model.UserInviteInfo](docs/UserInviteInfo.md)
- [Model.UserInviteRegenerateRequest](docs/UserInviteRegenerateRequest.md)
- [Model.UserInviteRegenerateResponse](docs/UserInviteRegenerateResponse.md)
- [Model.UserPermissions](docs/UserPermissions.md)
- [Model.UserRequest](docs/UserRequest.md)
- [Model.WorkloadType](docs/WorkloadType.md)
- [Model.Zone](docs/Zone.md)
- [Model.ZoneRequest](docs/ZoneRequest.md)
