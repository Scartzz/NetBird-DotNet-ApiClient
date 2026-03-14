# NetBird.ApiClient.Model.CreateIntegrationRequest
Request payload for creating a new event streaming integration. Also used as the structure for the PUT request body, but not all fields are applicable for updates (see PUT operation description).

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Platform** | **string** | The event streaming platform to integrate with (e.g., \&quot;datadog\&quot;, \&quot;s3\&quot;, \&quot;firehose\&quot;). This field is used for creation. For updates (PUT), this field, if sent, is ignored by the backend. | 
**Config** | **Dictionary&lt;string, string&gt;** | Platform-specific configuration as key-value pairs. For creation, all necessary credentials and settings must be provided. For updates, provide the fields to change or the entire new configuration. | 
**Enabled** | **bool** | Specifies whether the integration is enabled. During creation (POST), this value is sent by the client, but the provided backend manager function &#x60;CreateIntegration&#x60; does not appear to use it directly, so its effect on creation should be verified. During updates (PUT), this field is used to enable or disable the integration. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

