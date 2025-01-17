# Camunda.OpenApi.Client.Model.AuthorizationDto

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The id of the authorization. | [optional] 
**Type** | **int?** | The type of the authorization (0&#x3D;global, 1&#x3D;grant, 2&#x3D;revoke). See the [User Guide](https://docs.camunda.org/manual/7.21/user-guide/process-engine/authorization-service.md#authorization-type) for more information about authorization types. | [optional] 
**Permissions** | **List&lt;string&gt;** | An array of Strings holding the permissions provided by this authorization. | [optional] 
**UserId** | **string** | The id of the user this authorization has been created for. The value &#x60;*&#x60; represents a global authorization ranging over all users. | [optional] 
**GroupId** | **string** | The id of the group this authorization has been created for. | [optional] 
**ResourceType** | **int?** | An integer representing the resource type. See the [User Guide](https://docs.camunda.org/manual/7.21/user-guide/process-engine/authorization-service/#resources) for a list of integer representations of resource types. | [optional] 
**ResourceId** | **string** | The resource Id. The value &#x60;*&#x60; represents an authorization ranging over all instances of a resource. | [optional] 
**RemovalTime** | **DateTime?** | The removal time indicates the date a historic instance authorization is cleaned up. A removal time can only be assigned to a historic instance authorization. Can be &#x60;null&#x60; when not related to a historic instance resource or when the removal time strategy is end and the root process instance is not finished. Default format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;. | [optional] 
**RootProcessInstanceId** | **string** | The process instance id of the root process instance the historic instance authorization is related to. Can be &#x60;null&#x60; if not related to a historic instance resource. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

