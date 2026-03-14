# NetBird.ApiClient.Model.PolicyRuleMinimum

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Policy rule name identifier | 
**Description** | **string** | Policy rule friendly description | [optional] 
**Enabled** | **bool** | Policy rule status | 
**Action** | **string** | Policy rule accept or drops packets | 
**Bidirectional** | **bool** | Define if the rule is applicable in both directions, sources, and destinations. | 
**Protocol** | **string** | Policy rule type of the traffic | 
**Ports** | **List&lt;string&gt;** | Policy rule affected ports | [optional] 
**PortRanges** | [**List&lt;RulePortRange&gt;**](RulePortRange.md) | Policy rule affected ports ranges list | [optional] 
**AuthorizedGroups** | **Dictionary&lt;string, List&lt;string&gt;&gt;** | Map of user group ids to a list of local users | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

