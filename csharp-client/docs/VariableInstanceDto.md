# Camunda.OpenApi.Client.Model.VariableInstanceDto

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Value** | **Object** | Can be any value - string, number, boolean, array or object.  **Note**: Not every endpoint supports every type. | [optional] 
**Type** | **string** | The value type of the variable. | [optional] 
**ValueInfo** | **Dictionary&lt;string, Object&gt;** | A JSON object containing additional, value-type-dependent properties. For serialized variables of type Object, the following properties can be provided:  * &#x60;objectTypeName&#x60;: A string representation of the object&#39;s type name. * &#x60;serializationDataFormat&#x60;: The serialization format used to store the variable.  For serialized variables of type File, the following properties can be provided:  * &#x60;filename&#x60;: The name of the file. This is not the variable name but the name that will be used when downloading the file again. * &#x60;mimetype&#x60;: The MIME type of the file that is being uploaded. * &#x60;encoding&#x60;: The encoding of the file that is being uploaded.  The following property can be provided for all value types:  * &#x60;transient&#x60;: Indicates whether the variable should be transient or not. See [documentation](https://docs.camunda.org/manual/7.21/user-guide/process-engine/variables#transient-variables) for more informations. (Not applicable for &#x60;decision-definition&#x60;, &#x60; /process-instance/variables-async&#x60;, and &#x60;/migration/executeAsync&#x60; endpoints) | [optional] 
**Id** | **string** | The id of the variable instance. | [optional] 
**Name** | **string** | The name of the variable instance. | [optional] 
**ProcessDefinitionId** | **string** | The id of the process definition that this variable instance belongs to. | [optional] 
**ProcessInstanceId** | **string** | The id of the process instance that this variable instance belongs to. | [optional] 
**ExecutionId** | **string** | The id of the execution that this variable instance belongs to. | [optional] 
**CaseInstanceId** | **string** | The id of the case instance that this variable instance belongs to. | [optional] 
**CaseExecutionId** | **string** | The id of the case execution that this variable instance belongs to. | [optional] 
**TaskId** | **string** | The id of the task that this variable instance belongs to. | [optional] 
**BatchId** | **string** | The id of the batch that this variable instance belongs to.&lt; | [optional] 
**ActivityInstanceId** | **string** | The id of the activity instance that this variable instance belongs to. | [optional] 
**TenantId** | **string** | The id of the tenant that this variable instance belongs to. | [optional] 
**ErrorMessage** | **string** | An error message in case a Java Serialized Object could not be de-serialized. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

