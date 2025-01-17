# Camunda.OpenApi.Client.Model.SetRemovalTimeToHistoricDecisionInstancesDto

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AbsoluteRemovalTime** | **DateTime?** | The date for which the instances shall be removed. Value may not be &#x60;null&#x60;.  **Note:** Cannot be set in conjunction with &#x60;clearedRemovalTime&#x60; or &#x60;calculatedRemovalTime&#x60;. | [optional] 
**ClearedRemovalTime** | **bool?** | Sets the removal time to &#x60;null&#x60;. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior.  **Note:** Cannot be set in conjunction with &#x60;absoluteRemovalTime&#x60; or &#x60;calculatedRemovalTime&#x60;. | [optional] 
**CalculatedRemovalTime** | **bool?** | The removal time is calculated based on the engine&#39;s configuration settings. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior.  **Note:** Cannot be set in conjunction with &#x60;absoluteRemovalTime&#x60; or &#x60;clearedRemovalTime&#x60;. | [optional] 
**Hierarchical** | **bool?** | Sets the removal time to all historic decision instances in the hierarchy. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
**HistoricDecisionInstanceQuery** | [**HistoricDecisionInstanceQueryDto**](HistoricDecisionInstanceQueryDto.md) |  | [optional] 
**HistoricDecisionInstanceIds** | **List&lt;string&gt;** | The ids of the historic decision instances to set the removal time for. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

