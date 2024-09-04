# Camunda.OpenApi.Client.Model.SetRemovalTimeToHistoricProcessInstancesDto

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AbsoluteRemovalTime** | **DateTime?** | The date for which the instances shall be removed. Value may not be &#x60;null&#x60;.  **Note:** Cannot be set in conjunction with &#x60;clearedRemovalTime&#x60; or &#x60;calculatedRemovalTime&#x60;. | [optional] 
**ClearedRemovalTime** | **bool?** | Sets the removal time to &#x60;null&#x60;. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior.  **Note:** Cannot be set in conjunction with &#x60;absoluteRemovalTime&#x60; or &#x60;calculatedRemovalTime&#x60;. | [optional] 
**CalculatedRemovalTime** | **bool?** | The removal time is calculated based on the engine&#39;s configuration settings. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior.  **Note:** Cannot be set in conjunction with &#x60;absoluteRemovalTime&#x60; or &#x60;clearedRemovalTime&#x60;. | [optional] 
**HistoricProcessInstanceIds** | **List&lt;string&gt;** | The id of the process instance. | [optional] 
**HistoricProcessInstanceQuery** | [**HistoricProcessInstanceQueryDto**](HistoricProcessInstanceQueryDto.md) |  | [optional] 
**Hierarchical** | **bool?** | Sets the removal time to all historic process instances in the hierarchy. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
**UpdateInChunks** | **bool?** | Handles removal time updates in chunks, taking into account the defined size in &#x60;removalTimeUpdateChunkSize&#x60; in the process engine configuration. The size of the  chunks can also be overridden per call with the &#x60;updateChunkSize&#x60; parameter. Enabling this option can lead to multiple executions of the resulting jobs, preventing the database transaction from timing out by limiting the number of rows to update. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional] 
**UpdateChunkSize** | **int?** | Defines the size of the chunks in which removal time updates are processed. The value must be a positive integer between &#x60;1&#x60; and &#x60;500&#x60;. This only has an  effect if &#x60;updateInChunks&#x60; is set to &#x60;true&#x60;. If undefined, the operation uses the  &#x60;removalTimeUpdateChunkSize&#x60; defined in the process engine configuration. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

