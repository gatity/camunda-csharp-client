# Camunda.OpenApi.Client.Api.TaskIdentityLinkApi

All URIs are relative to *http://localhost:8080/engine-rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddIdentityLink**](TaskIdentityLinkApi.md#addidentitylink) | **POST** /task/{id}/identity-links | Add |
| [**DeleteIdentityLink**](TaskIdentityLinkApi.md#deleteidentitylink) | **POST** /task/{id}/identity-links/delete | Delete |
| [**GetIdentityLinks**](TaskIdentityLinkApi.md#getidentitylinks) | **GET** /task/{id}/identity-links | Get List |

<a id="addidentitylink"></a>
# **AddIdentityLink**
> void AddIdentityLink (string id, IdentityLinkDto identityLinkDto = null)

Add

Adds an identity link to a task by id. Can be used to link any user or group to a task and specify a relation.

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
    public class AddIdentityLinkExample
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
            var apiInstance = new TaskIdentityLinkApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | The id of the task to add a link to.
            var identityLinkDto = new IdentityLinkDto(); // IdentityLinkDto |  (optional) 

            try
            {
                // Add
                apiInstance.AddIdentityLink(id, identityLinkDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaskIdentityLinkApi.AddIdentityLink: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddIdentityLinkWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add
    apiInstance.AddIdentityLinkWithHttpInfo(id, identityLinkDto);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TaskIdentityLinkApi.AddIdentityLinkWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The id of the task to add a link to. |  |
| **identityLinkDto** | [**IdentityLinkDto**](IdentityLinkDto.md) |  | [optional]  |

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
| **400** | Task with given id does not exist. See the [Introduction](https://docs.camunda.org/manual/7.21/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteidentitylink"></a>
# **DeleteIdentityLink**
> void DeleteIdentityLink (string id, IdentityLinkDto identityLinkDto = null)

Delete

Removes an identity link from a task by id

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
    public class DeleteIdentityLinkExample
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
            var apiInstance = new TaskIdentityLinkApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | The id of the task to remove a link from.
            var identityLinkDto = new IdentityLinkDto(); // IdentityLinkDto |  (optional) 

            try
            {
                // Delete
                apiInstance.DeleteIdentityLink(id, identityLinkDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaskIdentityLinkApi.DeleteIdentityLink: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteIdentityLinkWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete
    apiInstance.DeleteIdentityLinkWithHttpInfo(id, identityLinkDto);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TaskIdentityLinkApi.DeleteIdentityLinkWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The id of the task to remove a link from. |  |
| **identityLinkDto** | [**IdentityLinkDto**](IdentityLinkDto.md) |  | [optional]  |

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
| **400** | Task with given id does not exist. See the [Introduction](https://docs.camunda.org/manual/7.21/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getidentitylinks"></a>
# **GetIdentityLinks**
> List&lt;IdentityLinkDto&gt; GetIdentityLinks (string id, string type = null)

Get List

Gets the identity links for a task by id, which are the users and groups that are in *some* relation to it (including assignee and owner).

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
    public class GetIdentityLinksExample
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
            var apiInstance = new TaskIdentityLinkApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | The id of the task to retrieve the identity links for.
            var type = "type_example";  // string | Filter by the type of links to include. (optional) 

            try
            {
                // Get List
                List<IdentityLinkDto> result = apiInstance.GetIdentityLinks(id, type);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaskIdentityLinkApi.GetIdentityLinks: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetIdentityLinksWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get List
    ApiResponse<List<IdentityLinkDto>> response = apiInstance.GetIdentityLinksWithHttpInfo(id, type);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TaskIdentityLinkApi.GetIdentityLinksWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The id of the task to retrieve the identity links for. |  |
| **type** | **string** | Filter by the type of links to include. | [optional]  |

### Return type

[**List&lt;IdentityLinkDto&gt;**](IdentityLinkDto.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **400** | Task with given id does not exist. See the [Introduction](https://docs.camunda.org/manual/7.21/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

