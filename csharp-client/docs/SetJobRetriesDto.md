# Camunda.OpenApi.Client.Model.SetJobRetriesDto

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DueDate** | **DateTime?** | The due date to set for the job. A due date indicates when this job is ready for execution. Jobs with due dates in the past will be scheduled for execution. | [optional] 
**Retries** | **int?** | The number of retries to set for the resource.  Must be &gt;&#x3D; 0. If this is 0, an incident is created and the task, or job, cannot be fetched, or acquired anymore unless the retries are increased again. Can not be null. | [optional] 
**JobIds** | **List&lt;string&gt;** | A list of job ids to set retries for. | [optional] 
**JobQuery** | [**JobQueryDto**](JobQueryDto.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

