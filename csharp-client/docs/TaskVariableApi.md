# Camunda.OpenApi.Client.Api.TaskVariableApi

All URIs are relative to *http://localhost:8080/engine-rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteTaskVariable**](TaskVariableApi.md#deletetaskvariable) | **DELETE** /task/{id}/variables/{varName} | Delete Task Variable |
| [**GetTaskVariable**](TaskVariableApi.md#gettaskvariable) | **GET** /task/{id}/variables/{varName} | Get Task Variable |
| [**GetTaskVariableBinary**](TaskVariableApi.md#gettaskvariablebinary) | **GET** /task/{id}/variables/{varName}/data | Get Task Variable (Binary) |
| [**GetTaskVariables**](TaskVariableApi.md#gettaskvariables) | **GET** /task/{id}/variables | Get Task Variables |
| [**ModifyTaskVariables**](TaskVariableApi.md#modifytaskvariables) | **POST** /task/{id}/variables | Update/Delete Task Variables |
| [**PutTaskVariable**](TaskVariableApi.md#puttaskvariable) | **PUT** /task/{id}/variables/{varName} | Update Task Variable |
| [**SetBinaryTaskVariable**](TaskVariableApi.md#setbinarytaskvariable) | **POST** /task/{id}/variables/{varName}/data | Update Task Variable (Binary) |

<a id="deletetaskvariable"></a>
# **DeleteTaskVariable**
> void DeleteTaskVariable (string id, string varName)

Delete Task Variable

Removes a variable that is visible to a task. A variable is visible to a task if it is a local task variable or declared in a parent scope of the task. See documentation on [visiblity of variables](https://docs.camunda.org/manual/7.21/user-guide/process-engine/variables/).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class DeleteTaskVariableExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new TaskVariableApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | The id of the task to delete the variable from.
            var varName = "varName_example";  // string | The name of the variable to be removed.

            try
            {
                // Delete Task Variable
                apiInstance.DeleteTaskVariable(id, varName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaskVariableApi.DeleteTaskVariable: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteTaskVariableWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Task Variable
    apiInstance.DeleteTaskVariableWithHttpInfo(id, varName);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TaskVariableApi.DeleteTaskVariableWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The id of the task to delete the variable from. |  |
| **varName** | **string** | The name of the variable to be removed. |  |

### Return type

void (empty response body)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Request successful. |  -  |
| **500** | Task id is null or does not exist. See the [Introduction](https://docs.camunda.org/manual/7.21/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gettaskvariable"></a>
# **GetTaskVariable**
> VariableValueDto GetTaskVariable (string id, string varName, bool? deserializeValue = null)

Get Task Variable

Retrieves a variable from the context of a given task. The variable must be visible from the task. It is visible from the task if it is a local task variable or declared in a parent scope of the task. See documentation on [visiblity of variables](https://docs.camunda.org/manual/7.21/user-guide/process-engine/variables/).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class GetTaskVariableExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new TaskVariableApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | The id of the task to retrieve the variable from.
            var varName = "varName_example";  // string | The name of the variable to get.
            var deserializeValue = true;  // bool? | Determines whether serializable variable values (typically variables that store custom Java objects) should be deserialized on the server side (default `true`).  If set to `true`, a serializable variable will be deserialized on server side and transformed to JSON using [Jackson's](https://github.com/FasterXML/jackson) POJO/bean property introspection feature. Note that this requires the Java classes of the variable value to be on the REST API's classpath.  If set to `false`, a serializable variable will be returned in its serialized format. For example, a variable that is serialized as XML will be returned as a JSON string containing XML.  Note: While `true` is the default value for reasons of backward compatibility, we recommend setting this parameter to `false` when developing web applications that are independent of the Java process applications deployed to the engine. (optional)  (default to true)

            try
            {
                // Get Task Variable
                VariableValueDto result = apiInstance.GetTaskVariable(id, varName, deserializeValue);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaskVariableApi.GetTaskVariable: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTaskVariableWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Task Variable
    ApiResponse<VariableValueDto> response = apiInstance.GetTaskVariableWithHttpInfo(id, varName, deserializeValue);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TaskVariableApi.GetTaskVariableWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The id of the task to retrieve the variable from. |  |
| **varName** | **string** | The name of the variable to get. |  |
| **deserializeValue** | **bool?** | Determines whether serializable variable values (typically variables that store custom Java objects) should be deserialized on the server side (default &#x60;true&#x60;).  If set to &#x60;true&#x60;, a serializable variable will be deserialized on server side and transformed to JSON using [Jackson&#39;s](https://github.com/FasterXML/jackson) POJO/bean property introspection feature. Note that this requires the Java classes of the variable value to be on the REST API&#39;s classpath.  If set to &#x60;false&#x60;, a serializable variable will be returned in its serialized format. For example, a variable that is serialized as XML will be returned as a JSON string containing XML.  Note: While &#x60;true&#x60; is the default value for reasons of backward compatibility, we recommend setting this parameter to &#x60;false&#x60; when developing web applications that are independent of the Java process applications deployed to the engine. | [optional] [default to true] |

### Return type

[**VariableValueDto**](VariableValueDto.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **404** | Variable with given id does not exist. See the [Introduction](https://docs.camunda.org/manual/7.21/reference/rest/overview/#error-handling) for the error response format. |  -  |
| **500** | Task id is &#x60;null&#x60; or does not exist. See the [Introduction](https://docs.camunda.org/manual/7.21/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gettaskvariablebinary"></a>
# **GetTaskVariableBinary**
> FileParameter GetTaskVariableBinary (string id, string varName)

Get Task Variable (Binary)

Retrieves a binary variable from the context of a given task. Applicable for byte array and file variables. The variable must be visible from the task. It is visible from the task if it is a local task variable or declared in a parent scope of the task. See documentation on [visiblity of variables](https://docs.camunda.org/manual/7.21/user-guide/process-engine/variables/).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class GetTaskVariableBinaryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new TaskVariableApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | The id of the task to retrieve the variable for.
            var varName = "varName_example";  // string | The name of the variable to retrieve.

            try
            {
                // Get Task Variable (Binary)
                FileParameter result = apiInstance.GetTaskVariableBinary(id, varName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaskVariableApi.GetTaskVariableBinary: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTaskVariableBinaryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Task Variable (Binary)
    ApiResponse<FileParameter> response = apiInstance.GetTaskVariableBinaryWithHttpInfo(id, varName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TaskVariableApi.GetTaskVariableBinaryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The id of the task to retrieve the variable for. |  |
| **varName** | **string** | The name of the variable to retrieve. |  |

### Return type

[**FileParameter**](FileParameter.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/octet-stream, text/plain, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful.         For binary variables or files without any MIME type information, a byte stream is returned.         File variables with MIME type information are returned as the saved type.         Additionally, for file variables the Content-Disposition header will be set. |  -  |
| **400** | Variable with given id exists but is not a binary variable.See the [Introduction](https://docs.camunda.org/manual/7.21/reference/rest/overview/#error-handling) for the error response format. |  -  |
| **404** | Variable with given id does not exist. See the [Introduction](https://docs.camunda.org/manual/7.21/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gettaskvariables"></a>
# **GetTaskVariables**
> Dictionary&lt;string, VariableValueDto&gt; GetTaskVariables (string id, bool? deserializeValues = null)

Get Task Variables

Retrieves all variables visible from the task. A variable is visible from the task if it is a local task variable or declared in a parent scope of the task. See documentation on [visiblity of variables](https://docs.camunda.org/manual/7.21/user-guide/process-engine/variables/).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class GetTaskVariablesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new TaskVariableApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | The id of the task to retrieve the variables from.
            var deserializeValues = true;  // bool? | Determines whether serializable variable values (typically variables that store custom Java objects) should be deserialized on the server side (default `true`). If set to `true`, a serializable variable will be deserialized on server side and transformed to JSON using [Jackson's](https://github.com/FasterXML/jackson) POJO/bean property introspection feature. Note that this requires the Java classes of the variable value to be on the REST API's classpath.  If set to `false`, a serializable variable will be returned in its serialized format. For example, a variable that is serialized as XML will be returned as a JSON string containing XML.  Note: While `true` is the default value for reasons of backward compatibility, we recommend setting this parameter to `false` when developing web applications that are independent of the Java process applications deployed to the engine. (optional)  (default to true)

            try
            {
                // Get Task Variables
                Dictionary<string, VariableValueDto> result = apiInstance.GetTaskVariables(id, deserializeValues);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaskVariableApi.GetTaskVariables: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTaskVariablesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Task Variables
    ApiResponse<Dictionary<string, VariableValueDto>> response = apiInstance.GetTaskVariablesWithHttpInfo(id, deserializeValues);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TaskVariableApi.GetTaskVariablesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The id of the task to retrieve the variables from. |  |
| **deserializeValues** | **bool?** | Determines whether serializable variable values (typically variables that store custom Java objects) should be deserialized on the server side (default &#x60;true&#x60;). If set to &#x60;true&#x60;, a serializable variable will be deserialized on server side and transformed to JSON using [Jackson&#39;s](https://github.com/FasterXML/jackson) POJO/bean property introspection feature. Note that this requires the Java classes of the variable value to be on the REST API&#39;s classpath.  If set to &#x60;false&#x60;, a serializable variable will be returned in its serialized format. For example, a variable that is serialized as XML will be returned as a JSON string containing XML.  Note: While &#x60;true&#x60; is the default value for reasons of backward compatibility, we recommend setting this parameter to &#x60;false&#x60; when developing web applications that are independent of the Java process applications deployed to the engine. | [optional] [default to true] |

### Return type

[**Dictionary&lt;string, VariableValueDto&gt;**](VariableValueDto.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **500** | Task id is &#x60;null&#x60; or does not exist. See the [Introduction](https://docs.camunda.org/manual/7.21/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="modifytaskvariables"></a>
# **ModifyTaskVariables**
> void ModifyTaskVariables (string id, PatchVariablesDto patchVariablesDto = null)

Update/Delete Task Variables

Updates or deletes the variables visible from the task. Updates precede deletions. So, if a variable is updated AND deleted, the deletion overrides the update. A variable is visible from the task if it is a local task variable or declared in a parent scope of the task. See documentation on [visiblity of variables](https://docs.camunda.org/manual/7.21/user-guide/process-engine/variables/).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class ModifyTaskVariablesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new TaskVariableApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | The id of the task to set variables for.
            var patchVariablesDto = new PatchVariablesDto(); // PatchVariablesDto |  (optional) 

            try
            {
                // Update/Delete Task Variables
                apiInstance.ModifyTaskVariables(id, patchVariablesDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaskVariableApi.ModifyTaskVariables: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ModifyTaskVariablesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update/Delete Task Variables
    apiInstance.ModifyTaskVariablesWithHttpInfo(id, patchVariablesDto);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TaskVariableApi.ModifyTaskVariablesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The id of the task to set variables for. |  |
| **patchVariablesDto** | [**PatchVariablesDto**](PatchVariablesDto.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Request successful. |  -  |
| **400** | The variable value or type is invalid. For example the value could not be parsed to an &#x60;Integer&#x60; value or the passed variable type is not supported. See the [Introduction](https://docs.camunda.org/manual/7.21/reference/rest/overview/#error-handling) for the error response format. |  -  |
| **500** | Update or delete could not be executed because the task is &#x60;null&#x60; or does not exist. See the [Introduction](https://docs.camunda.org/manual/7.21/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="puttaskvariable"></a>
# **PutTaskVariable**
> void PutTaskVariable (string id, string varName, VariableValueDto variableValueDto = null)

Update Task Variable

Updates a process variable that is visible from the Task scope. A variable is visible from the task if it is a local task variable, or declared in a parent scope of the task. See the documentation on [variable scopes and visibility](https://docs.camunda.org/manual/7.21/user-guide/process-engine/variables#variable-scopes-and-variable-visibility).  **Note**: If a variable doesn't exist, the variable is created in the top-most scope visible from the task.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class PutTaskVariableExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new TaskVariableApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | The id of the task to set the variable for.
            var varName = "varName_example";  // string | The name of the variable to set.
            var variableValueDto = new VariableValueDto(); // VariableValueDto |  (optional) 

            try
            {
                // Update Task Variable
                apiInstance.PutTaskVariable(id, varName, variableValueDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaskVariableApi.PutTaskVariable: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PutTaskVariableWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Task Variable
    apiInstance.PutTaskVariableWithHttpInfo(id, varName, variableValueDto);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TaskVariableApi.PutTaskVariableWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The id of the task to set the variable for. |  |
| **varName** | **string** | The name of the variable to set. |  |
| **variableValueDto** | [**VariableValueDto**](VariableValueDto.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Request successful. |  -  |
| **400** | The variable name, value or type is invalid, for example if the value could not be parsed to an &#x60;Integer&#x60; value or the passed variable type is not supported or a new transient variable has the name that is already persisted. See the [Introduction](https://docs.camunda.org/manual/7.21/reference/rest/overview/#error-handling) for the error response format. |  -  |
| **500** | The variable name is &#x60;null&#x60;, or the Task id is &#x60;null&#x60; or does not exist. See the [Introduction](https://docs.camunda.org/manual/7.21/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="setbinarytaskvariable"></a>
# **SetBinaryTaskVariable**
> void SetBinaryTaskVariable (string id, string varName, FileParameter data = null, string valueType = null)

Update Task Variable (Binary)

Sets the serialized value for a binary variable or the binary value for a file variable visible from the task. A variable is visible from the task if it is a local task variable or declared in a parent scope of the task. See documentation on [visiblity of variables](https://docs.camunda.org/manual/7.21/user-guide/process-engine/variables/).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Camunda.OpenApi.Client.Api;
using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Model;

namespace Example
{
    public class SetBinaryTaskVariableExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new TaskVariableApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | The id of the task to retrieve the variable for.
            var varName = "varName_example";  // string | The name of the variable to retrieve.
            var data = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // FileParameter | The binary data to be set. For File variables, this multipart can contain the filename, binary value and MIME type of the file variable to be set Only the filename is mandatory. (optional) 
            var valueType = "Bytes";  // string | The name of the variable type. Either Bytes for a byte array variable or File for a file variable. (optional) 

            try
            {
                // Update Task Variable (Binary)
                apiInstance.SetBinaryTaskVariable(id, varName, data, valueType);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaskVariableApi.SetBinaryTaskVariable: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SetBinaryTaskVariableWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Task Variable (Binary)
    apiInstance.SetBinaryTaskVariableWithHttpInfo(id, varName, data, valueType);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TaskVariableApi.SetBinaryTaskVariableWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The id of the task to retrieve the variable for. |  |
| **varName** | **string** | The name of the variable to retrieve. |  |
| **data** | **FileParameter****FileParameter** | The binary data to be set. For File variables, this multipart can contain the filename, binary value and MIME type of the file variable to be set Only the filename is mandatory. | [optional]  |
| **valueType** | **string** | The name of the variable type. Either Bytes for a byte array variable or File for a file variable. | [optional]  |

### Return type

void (empty response body)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Request successful. |  -  |
| **400** | The variable value or type is invalid, for example if no filename is set. See the [Introduction](https://docs.camunda.org/manual/7.21/reference/rest/overview/#error-handling) for the error response format. |  -  |
| **500** | Variable name is &#x60;null&#x60;, or the Task id is &#x60;null&#x60; or does not exist. See the [Introduction](https://docs.camunda.org/manual/7.21/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

