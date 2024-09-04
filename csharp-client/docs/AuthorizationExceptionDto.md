# Camunda.OpenApi.Client.Model.AuthorizationExceptionDto

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | An exception class indicating the occurred error. | [optional] 
**Message** | **string** | A detailed message of the error. | [optional] 
**Code** | **decimal** | The code allows your client application to identify the error in an automated fashion. You can look up the meaning of all built-in codes and learn how to add custom codes in the [User Guide](https://docs.camunda.org/manual/7.21/user-guide/process-engine/error-handling/#exception-codes). | [optional] 
**UserId** | **string** | The id of the user that does not have expected permissions | [optional] 
**MissingAuthorizations** | [**List&lt;MissingAuthorizationDto&gt;**](MissingAuthorizationDto.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

