# NetBird.ApiClient.Model.EDRFalconRequest
Request payload for creating or updating a EDR Falcon integration

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClientId** | **string** | CrowdStrike API client ID | 
**Secret** | **string** | CrowdStrike API client secret | 
**CloudId** | **string** | CrowdStrike cloud identifier (e.g., \&quot;us-1\&quot;, \&quot;us-2\&quot;, \&quot;eu-1\&quot;) | 
**Groups** | **List&lt;string&gt;** | The Groups this integration applies to | 
**ZtaScoreThreshold** | **int** | The minimum Zero Trust Assessment score required for agent approval (0-100) | 
**Enabled** | **bool** | Indicates whether the integration is enabled | [optional] [default to true]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

