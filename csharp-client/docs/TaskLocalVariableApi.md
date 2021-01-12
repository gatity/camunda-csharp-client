# CamundaClient.Api.TaskLocalVariableApi

All URIs are relative to *http://localhost:8080/engine-rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteTaskLocalVariable**](TaskLocalVariableApi.md#deletetasklocalvariable) | **DELETE** /task/{id}/localVariables/{varName} | 
[**GetTaskLocalVariable**](TaskLocalVariableApi.md#gettasklocalvariable) | **GET** /task/{id}/localVariables/{varName} | 
[**GetTaskLocalVariableBinary**](TaskLocalVariableApi.md#gettasklocalvariablebinary) | **GET** /task/{id}/localVariables/{varName}/data | 
[**GetTaskLocalVariables**](TaskLocalVariableApi.md#gettasklocalvariables) | **GET** /task/{id}/localVariables | 
[**ModifyTaskLocalVariables**](TaskLocalVariableApi.md#modifytasklocalvariables) | **POST** /task/{id}/localVariables | 
[**PutTaskLocalVariable**](TaskLocalVariableApi.md#puttasklocalvariable) | **PUT** /task/{id}/localVariables/{varName} | 
[**SetBinaryTaskLocalVariable**](TaskLocalVariableApi.md#setbinarytasklocalvariable) | **POST** /task/{id}/localVariables/{varName}/data | 


<a name="deletetasklocalvariable"></a>
# **DeleteTaskLocalVariable**
> void DeleteTaskLocalVariable (string id, string varName)



Removes a local variable from a task by id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CamundaClient.Api;
using CamundaClient.Client;
using CamundaClient.Model;

namespace Example
{
    public class DeleteTaskLocalVariableExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new TaskLocalVariableApi(config);
            var id = id_example;  // string | The id of the task to delete the variable from.
            var varName = varName_example;  // string | The name of the variable to be removed.

            try
            {
                apiInstance.DeleteTaskLocalVariable(id, varName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaskLocalVariableApi.DeleteTaskLocalVariable: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the task to delete the variable from. | 
 **varName** | **string**| The name of the variable to be removed. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Request successful. |  -  |
| **500** | Task id is &#x60;null&#x60; or does not exist. See the [Introduction](https://docs.camunda.org/manual/7.14/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettasklocalvariable"></a>
# **GetTaskLocalVariable**
> VariableValueDto GetTaskLocalVariable (string id, string varName, bool? deserializeValue = null)



Retrieves a variable from the context of a given task by id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CamundaClient.Api;
using CamundaClient.Client;
using CamundaClient.Model;

namespace Example
{
    public class GetTaskLocalVariableExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new TaskLocalVariableApi(config);
            var id = id_example;  // string | The id of the task to retrieve the variable from.
            var varName = varName_example;  // string | The name of the variable to get
            var deserializeValue = true;  // bool? | Determines whether serializable variable values (typically variables that store custom Java objects) should be deserialized on the server side (default `true`).  If set to `true`, a serializable variable will be deserialized on server side and transformed to JSON using [Jackson's](https://github.com/FasterXML/jackson) POJO/bean property introspection feature. Note that this requires the Java classes of the variable value to be on the REST API's classpath.  If set to `false`, a serializable variable will be returned in its serialized format. For example, a variable that is serialized as XML will be returned as a JSON string containing XML.  Note: While `true` is the default value for reasons of backward compatibility, we recommend setting this parameter to `false` when developing web applications that are independent of the Java process applications deployed to the engine. (optional)  (default to true)

            try
            {
                VariableValueDto result = apiInstance.GetTaskLocalVariable(id, varName, deserializeValue);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaskLocalVariableApi.GetTaskLocalVariable: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the task to retrieve the variable from. | 
 **varName** | **string**| The name of the variable to get | 
 **deserializeValue** | **bool?**| Determines whether serializable variable values (typically variables that store custom Java objects) should be deserialized on the server side (default &#x60;true&#x60;).  If set to &#x60;true&#x60;, a serializable variable will be deserialized on server side and transformed to JSON using [Jackson&#39;s](https://github.com/FasterXML/jackson) POJO/bean property introspection feature. Note that this requires the Java classes of the variable value to be on the REST API&#39;s classpath.  If set to &#x60;false&#x60;, a serializable variable will be returned in its serialized format. For example, a variable that is serialized as XML will be returned as a JSON string containing XML.  Note: While &#x60;true&#x60; is the default value for reasons of backward compatibility, we recommend setting this parameter to &#x60;false&#x60; when developing web applications that are independent of the Java process applications deployed to the engine. | [optional] [default to true]

### Return type

[**VariableValueDto**](VariableValueDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **404** | Variable with given id does not exist. See the [Introduction](https://docs.camunda.org/manual/7.14/reference/rest/overview/#error-handling) for the error response format. |  -  |
| **500** | Task id is &#x60;null&#x60; or does not exist. See the [Introduction](https://docs.camunda.org/manual/7.14/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettasklocalvariablebinary"></a>
# **GetTaskLocalVariableBinary**
> System.IO.Stream GetTaskLocalVariableBinary (string id, string varName)



Retrieves a binary variable from the context of a given task by id. Applicable for byte array and file variables.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CamundaClient.Api;
using CamundaClient.Client;
using CamundaClient.Model;

namespace Example
{
    public class GetTaskLocalVariableBinaryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new TaskLocalVariableApi(config);
            var id = id_example;  // string | The id of the task to retrieve the variable for.
            var varName = varName_example;  // string | The name of the variable to retrieve.

            try
            {
                System.IO.Stream result = apiInstance.GetTaskLocalVariableBinary(id, varName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaskLocalVariableApi.GetTaskLocalVariableBinary: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the task to retrieve the variable for. | 
 **varName** | **string**| The name of the variable to retrieve. | 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/octet-stream, text/plain, application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful.         For binary variables or files without any MIME type information, a byte stream is returned.         File variables with MIME type information are returned as the saved type.         Additionally, for file variables the Content-Disposition header will be set. |  -  |
| **400** | Variable with given id exists but is not a binary variable.See the [Introduction](https://docs.camunda.org/manual/7.14/reference/rest/overview/#error-handling) for the error response format. |  -  |
| **404** | Variable with given id does not exist. See the [Introduction](https://docs.camunda.org/manual/7.14/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettasklocalvariables"></a>
# **GetTaskLocalVariables**
> Dictionary&lt;string, VariableValueDto&gt; GetTaskLocalVariables (string id, bool? deserializeValues = null)



Retrieves all variables of a given task by id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CamundaClient.Api;
using CamundaClient.Client;
using CamundaClient.Model;

namespace Example
{
    public class GetTaskLocalVariablesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new TaskLocalVariableApi(config);
            var id = id_example;  // string | The id of the task to retrieve the variables from.
            var deserializeValues = true;  // bool? | Determines whether serializable variable values (typically variables that store custom Java objects) should be deserialized on the server side (default `true`).  If set to `true`, a serializable variable will be deserialized on server side and transformed to JSON using [Jackson's](https://github.com/FasterXML/jackson) POJO/bean property introspection feature. Note that this requires the Java classes of the variable value to be on the REST API's classpath.  If set to `false`, a serializable variable will be returned in its serialized format. For example, a variable that is serialized as XML will be returned as a JSON string containing XML.  **Note:** While `true` is the default value for reasons of backward compatibility, we recommend setting this parameter to `false` when developing web applications that are independent of the Java process applications deployed to the engine. (optional)  (default to true)

            try
            {
                Dictionary<string, VariableValueDto> result = apiInstance.GetTaskLocalVariables(id, deserializeValues);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaskLocalVariableApi.GetTaskLocalVariables: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the task to retrieve the variables from. | 
 **deserializeValues** | **bool?**| Determines whether serializable variable values (typically variables that store custom Java objects) should be deserialized on the server side (default &#x60;true&#x60;).  If set to &#x60;true&#x60;, a serializable variable will be deserialized on server side and transformed to JSON using [Jackson&#39;s](https://github.com/FasterXML/jackson) POJO/bean property introspection feature. Note that this requires the Java classes of the variable value to be on the REST API&#39;s classpath.  If set to &#x60;false&#x60;, a serializable variable will be returned in its serialized format. For example, a variable that is serialized as XML will be returned as a JSON string containing XML.  **Note:** While &#x60;true&#x60; is the default value for reasons of backward compatibility, we recommend setting this parameter to &#x60;false&#x60; when developing web applications that are independent of the Java process applications deployed to the engine. | [optional] [default to true]

### Return type

[**Dictionary&lt;string, VariableValueDto&gt;**](VariableValueDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **500** | Task id is &#x60;null&#x60; or does not exist. See the [Introduction](https://docs.camunda.org/manual/7.14/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="modifytasklocalvariables"></a>
# **ModifyTaskLocalVariables**
> void ModifyTaskLocalVariables (string id, PatchVariablesDto patchVariablesDto = null)



Updates or deletes the variables in the context of a task. Updates precede deletions. So, if a variable is updated AND deleted, the deletion overrides the update.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CamundaClient.Api;
using CamundaClient.Client;
using CamundaClient.Model;

namespace Example
{
    public class ModifyTaskLocalVariablesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new TaskLocalVariableApi(config);
            var id = id_example;  // string | The id of the task to set variables for.
            var patchVariablesDto = new PatchVariablesDto(); // PatchVariablesDto |  (optional) 

            try
            {
                apiInstance.ModifyTaskLocalVariables(id, patchVariablesDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaskLocalVariableApi.ModifyTaskLocalVariables: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the task to set variables for. | 
 **patchVariablesDto** | [**PatchVariablesDto**](PatchVariablesDto.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Request successful. |  -  |
| **400** | The variable value or type is invalid. For example the value could not be parsed to an &#x60;Integer&#x60; value or the passed variable type is not supported. See the [Introduction](https://docs.camunda.org/manual/7.14/reference/rest/overview/#error-handling) for the error response format. |  -  |
| **500** | Update or delete could not be executed because the task is &#x60;null&#x60; or does not exist.. See the [Introduction](https://docs.camunda.org/manual/7.14/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="puttasklocalvariable"></a>
# **PutTaskLocalVariable**
> void PutTaskLocalVariable (string id, string varName, VariableValueDto variableValueDto = null)



Sets a variable in the context of a given task.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CamundaClient.Api;
using CamundaClient.Client;
using CamundaClient.Model;

namespace Example
{
    public class PutTaskLocalVariableExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new TaskLocalVariableApi(config);
            var id = id_example;  // string | The id of the task to set the variable for.
            var varName = varName_example;  // string | The name of the variable to set.
            var variableValueDto = new VariableValueDto(); // VariableValueDto |  (optional) 

            try
            {
                apiInstance.PutTaskLocalVariable(id, varName, variableValueDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaskLocalVariableApi.PutTaskLocalVariable: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the task to set the variable for. | 
 **varName** | **string**| The name of the variable to set. | 
 **variableValueDto** | [**VariableValueDto**](VariableValueDto.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Request successful. |  -  |
| **400** | The variable name, value or type is invalid, for example if the value could not be parsed to an &#x60;Integer&#x60; value or the passed variable type is not supported or a new transient variable has the name that is already persisted. See the [Introduction](https://docs.camunda.org/manual/7.14/reference/rest/overview/#error-handling) for the error response format. |  -  |
| **500** | The variable name is &#x60;null&#x60;, or the Task id is &#x60;null&#x60; or does not exist. See the [Introduction](https://docs.camunda.org/manual/7.14/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setbinarytasklocalvariable"></a>
# **SetBinaryTaskLocalVariable**
> void SetBinaryTaskLocalVariable (string id, string varName, System.IO.Stream data = null, string valueType = null)



Sets the serialized value for a binary variable or the binary value for a file variable.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CamundaClient.Api;
using CamundaClient.Client;
using CamundaClient.Model;

namespace Example
{
    public class SetBinaryTaskLocalVariableExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new TaskLocalVariableApi(config);
            var id = id_example;  // string | The id of the task to retrieve the variable for.
            var varName = varName_example;  // string | The name of the variable to retrieve.
            var data = BINARY_DATA_HERE;  // System.IO.Stream | The binary data to be set. For File variables, this multipart can contain the filename, binary value and MIME type of the file variable to be set Only the filename is mandatory. (optional) 
            var valueType = valueType_example;  // string | The name of the variable type. Either Bytes for a byte array variable or File for a file variable. (optional) 

            try
            {
                apiInstance.SetBinaryTaskLocalVariable(id, varName, data, valueType);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaskLocalVariableApi.SetBinaryTaskLocalVariable: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the task to retrieve the variable for. | 
 **varName** | **string**| The name of the variable to retrieve. | 
 **data** | **System.IO.Stream****System.IO.Stream**| The binary data to be set. For File variables, this multipart can contain the filename, binary value and MIME type of the file variable to be set Only the filename is mandatory. | [optional] 
 **valueType** | **string**| The name of the variable type. Either Bytes for a byte array variable or File for a file variable. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Request successful. |  -  |
| **400** | The variable value or type is invalid, for example if no filename is set. See the [Introduction](https://docs.camunda.org/manual/7.14/reference/rest/overview/#error-handling) for the error response format. |  -  |
| **500** | Variable name is &#x60;null&#x60;, or the Task id is &#x60;null&#x60; or does not exist. See the [Introduction](https://docs.camunda.org/manual/7.14/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
