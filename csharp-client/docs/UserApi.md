# Camunda.OpenApi.Client.Api.UserApi

All URIs are relative to *http://localhost:8080/engine-rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AvailableOperations**](UserApi.md#availableoperations) | **OPTIONS** /user | Options |
| [**AvailableUserOperations**](UserApi.md#availableuseroperations) | **OPTIONS** /user/{id} | Options |
| [**CreateUser**](UserApi.md#createuser) | **POST** /user/create | Create |
| [**DeleteUser**](UserApi.md#deleteuser) | **DELETE** /user/{id} | Delete |
| [**GetUserCount**](UserApi.md#getusercount) | **GET** /user/count | Get List Count |
| [**GetUserProfile**](UserApi.md#getuserprofile) | **GET** /user/{id}/profile | Get Profile |
| [**GetUsers**](UserApi.md#getusers) | **GET** /user | Get List |
| [**UnlockUser**](UserApi.md#unlockuser) | **POST** /user/{id}/unlock | Unlock User |
| [**UpdateCredentials**](UserApi.md#updatecredentials) | **PUT** /user/{id}/credentials | Update Credentials |
| [**UpdateProfile**](UserApi.md#updateprofile) | **PUT** /user/{id}/profile | Update User Profile |

<a id="availableoperations"></a>
# **AvailableOperations**
> ResourceOptionsDto AvailableOperations ()

Options

The `/user` resource supports two custom `OPTIONS` requests, one for the resource as such and one for individual user instances. The `OPTIONS` request allows checking for the set of available operations that the currently authenticated user can perform on the /user resource. If the user can perform an operation or not may depend on various things, including the user's authorizations to interact with this resource and the internal configuration of the process engine. `OPTIONS /user` returns available interactions on the resource.

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
    public class AvailableOperationsExample
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
            var apiInstance = new UserApi(httpClient, config, httpClientHandler);

            try
            {
                // Options
                ResourceOptionsDto result = apiInstance.AvailableOperations();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.AvailableOperations: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AvailableOperationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Options
    ApiResponse<ResourceOptionsDto> response = apiInstance.AvailableOperationsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.AvailableOperationsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**ResourceOptionsDto**](ResourceOptionsDto.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="availableuseroperations"></a>
# **AvailableUserOperations**
> ResourceOptionsDto AvailableUserOperations (string id)

Options

The `/user` resource supports two custom `OPTIONS` requests, one for the resource as such and one for individual user instances. The `OPTIONS` request allows checking for the set of available operations that the currently authenticated user can perform on the /user resource. If the user can perform an operation or not may depend on various things, including the user's authorizations to interact with this resource and the internal configuration of the process engine. `OPTIONS /user/{id}` returns available interactions on a resource instance.

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
    public class AvailableUserOperationsExample
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
            var apiInstance = new UserApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | The id of the user to be deleted.

            try
            {
                // Options
                ResourceOptionsDto result = apiInstance.AvailableUserOperations(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.AvailableUserOperations: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AvailableUserOperationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Options
    ApiResponse<ResourceOptionsDto> response = apiInstance.AvailableUserOperationsWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.AvailableUserOperationsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The id of the user to be deleted. |  |

### Return type

[**ResourceOptionsDto**](ResourceOptionsDto.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createuser"></a>
# **CreateUser**
> void CreateUser (UserDto userDto = null)

Create

Create a new user.

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
    public class CreateUserExample
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
            var apiInstance = new UserApi(httpClient, config, httpClientHandler);
            var userDto = new UserDto(); // UserDto |  (optional) 

            try
            {
                // Create
                apiInstance.CreateUser(userDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.CreateUser: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateUserWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create
    apiInstance.CreateUserWithHttpInfo(userDto);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.CreateUserWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userDto** | [**UserDto**](UserDto.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Request successful. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteuser"></a>
# **DeleteUser**
> void DeleteUser (string id)

Delete

Deletes a user by id.

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
    public class DeleteUserExample
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
            var apiInstance = new UserApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | The id of the user to be deleted.

            try
            {
                // Delete
                apiInstance.DeleteUser(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.DeleteUser: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteUserWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete
    apiInstance.DeleteUserWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.DeleteUserWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The id of the user to be deleted. |  |

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
| **403** | Identity service is read-only (Cannot modify users / groups / memberships). |  -  |
| **404** | A Deployment with the provided id does not exist. See the [Introduction](https://docs.camunda.org/manual/7.21/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getusercount"></a>
# **GetUserCount**
> CountResultDto GetUserCount (string id = null, string idIn = null, string firstName = null, string firstNameLike = null, string lastName = null, string lastNameLike = null, string email = null, string emailLike = null, string memberOfGroup = null, string memberOfTenant = null, string potentialStarter = null)

Get List Count

Queries for the number of deployments that fulfill given parameters. Takes the same parameters as the [Get Users](https://docs.camunda.org/manual/7.21/reference/rest/user/get-query/) method.

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
    public class GetUserCountExample
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
            var apiInstance = new UserApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | Filter by user id (optional) 
            var idIn = "idIn_example";  // string | Filter by a comma-separated list of user ids. (optional) 
            var firstName = "firstName_example";  // string | Filter by the first name of the user. Exact match. (optional) 
            var firstNameLike = "firstNameLike_example";  // string | Filter by the first name that the parameter is a substring of. (optional) 
            var lastName = "lastName_example";  // string | Filter by the last name of the user. Exact match. (optional) 
            var lastNameLike = "lastNameLike_example";  // string | Filter by the last name that the parameter is a substring of. (optional) 
            var email = "email_example";  // string | Filter by the email of the user. Exact match. (optional) 
            var emailLike = "emailLike_example";  // string | Filter by the email that the parameter is a substring of. (optional) 
            var memberOfGroup = "memberOfGroup_example";  // string | Filter for users which are members of the given group. (optional) 
            var memberOfTenant = "memberOfTenant_example";  // string | Filter for users which are members of the given tenant. (optional) 
            var potentialStarter = "potentialStarter_example";  // string | Only select Users that are potential starter for the given process definition. (optional) 

            try
            {
                // Get List Count
                CountResultDto result = apiInstance.GetUserCount(id, idIn, firstName, firstNameLike, lastName, lastNameLike, email, emailLike, memberOfGroup, memberOfTenant, potentialStarter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.GetUserCount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetUserCountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get List Count
    ApiResponse<CountResultDto> response = apiInstance.GetUserCountWithHttpInfo(id, idIn, firstName, firstNameLike, lastName, lastNameLike, email, emailLike, memberOfGroup, memberOfTenant, potentialStarter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.GetUserCountWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Filter by user id | [optional]  |
| **idIn** | **string** | Filter by a comma-separated list of user ids. | [optional]  |
| **firstName** | **string** | Filter by the first name of the user. Exact match. | [optional]  |
| **firstNameLike** | **string** | Filter by the first name that the parameter is a substring of. | [optional]  |
| **lastName** | **string** | Filter by the last name of the user. Exact match. | [optional]  |
| **lastNameLike** | **string** | Filter by the last name that the parameter is a substring of. | [optional]  |
| **email** | **string** | Filter by the email of the user. Exact match. | [optional]  |
| **emailLike** | **string** | Filter by the email that the parameter is a substring of. | [optional]  |
| **memberOfGroup** | **string** | Filter for users which are members of the given group. | [optional]  |
| **memberOfTenant** | **string** | Filter for users which are members of the given tenant. | [optional]  |
| **potentialStarter** | **string** | Only select Users that are potential starter for the given process definition. | [optional]  |

### Return type

[**CountResultDto**](CountResultDto.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **400** | Returned if some of the query parameters are invalid, for example, if an invalid operator for variable comparison is used. See the [Introduction](https://docs.camunda.org/manual/7.21/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getuserprofile"></a>
# **GetUserProfile**
> UserProfileDto GetUserProfile (string id)

Get Profile

Retrieves a user's profile.

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
    public class GetUserProfileExample
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
            var apiInstance = new UserApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | The id of the user to retrieve.

            try
            {
                // Get Profile
                UserProfileDto result = apiInstance.GetUserProfile(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.GetUserProfile: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetUserProfileWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Profile
    ApiResponse<UserProfileDto> response = apiInstance.GetUserProfileWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.GetUserProfileWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The id of the user to retrieve. |  |

### Return type

[**UserProfileDto**](UserProfileDto.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **404** | Execution with given id does not exist. See the [Introduction](https://docs.camunda.org/manual/7.21/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getusers"></a>
# **GetUsers**
> List&lt;UserProfileDto&gt; GetUsers (string id = null, string idIn = null, string firstName = null, string firstNameLike = null, string lastName = null, string lastNameLike = null, string email = null, string emailLike = null, string memberOfGroup = null, string memberOfTenant = null, string potentialStarter = null, string sortBy = null, string sortOrder = null, int? firstResult = null, int? maxResults = null)

Get List

Query for a list of users using a list of parameters. The size of the result set can be retrieved by using the Get User Count method. [Get User Count](https://docs.camunda.org/manual/7.21/reference/rest/user/get-query-count/) method.

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
    public class GetUsersExample
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
            var apiInstance = new UserApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | Filter by user id (optional) 
            var idIn = "idIn_example";  // string | Filter by a comma-separated list of user ids. (optional) 
            var firstName = "firstName_example";  // string | Filter by the first name of the user. Exact match. (optional) 
            var firstNameLike = "firstNameLike_example";  // string | Filter by the first name that the parameter is a substring of. (optional) 
            var lastName = "lastName_example";  // string | Filter by the last name of the user. Exact match. (optional) 
            var lastNameLike = "lastNameLike_example";  // string | Filter by the last name that the parameter is a substring of. (optional) 
            var email = "email_example";  // string | Filter by the email of the user. Exact match. (optional) 
            var emailLike = "emailLike_example";  // string | Filter by the email that the parameter is a substring of. (optional) 
            var memberOfGroup = "memberOfGroup_example";  // string | Filter for users which are members of the given group. (optional) 
            var memberOfTenant = "memberOfTenant_example";  // string | Filter for users which are members of the given tenant. (optional) 
            var potentialStarter = "potentialStarter_example";  // string | Only select Users that are potential starter for the given process definition. (optional) 
            var sortBy = "userId";  // string | Sort the results lexicographically by a given criterion. Must be used in conjunction with the sortOrder parameter. (optional) 
            var sortOrder = "asc";  // string | Sort the results in a given order. Values may be asc for ascending order or desc for descending order. Must be used in conjunction with the sortBy parameter. (optional) 
            var firstResult = 56;  // int? | Pagination of results. Specifies the index of the first result to return. (optional) 
            var maxResults = 56;  // int? | Pagination of results. Specifies the maximum number of results to return. Will return less results if there are no more results left. (optional) 

            try
            {
                // Get List
                List<UserProfileDto> result = apiInstance.GetUsers(id, idIn, firstName, firstNameLike, lastName, lastNameLike, email, emailLike, memberOfGroup, memberOfTenant, potentialStarter, sortBy, sortOrder, firstResult, maxResults);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.GetUsers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetUsersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get List
    ApiResponse<List<UserProfileDto>> response = apiInstance.GetUsersWithHttpInfo(id, idIn, firstName, firstNameLike, lastName, lastNameLike, email, emailLike, memberOfGroup, memberOfTenant, potentialStarter, sortBy, sortOrder, firstResult, maxResults);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.GetUsersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Filter by user id | [optional]  |
| **idIn** | **string** | Filter by a comma-separated list of user ids. | [optional]  |
| **firstName** | **string** | Filter by the first name of the user. Exact match. | [optional]  |
| **firstNameLike** | **string** | Filter by the first name that the parameter is a substring of. | [optional]  |
| **lastName** | **string** | Filter by the last name of the user. Exact match. | [optional]  |
| **lastNameLike** | **string** | Filter by the last name that the parameter is a substring of. | [optional]  |
| **email** | **string** | Filter by the email of the user. Exact match. | [optional]  |
| **emailLike** | **string** | Filter by the email that the parameter is a substring of. | [optional]  |
| **memberOfGroup** | **string** | Filter for users which are members of the given group. | [optional]  |
| **memberOfTenant** | **string** | Filter for users which are members of the given tenant. | [optional]  |
| **potentialStarter** | **string** | Only select Users that are potential starter for the given process definition. | [optional]  |
| **sortBy** | **string** | Sort the results lexicographically by a given criterion. Must be used in conjunction with the sortOrder parameter. | [optional]  |
| **sortOrder** | **string** | Sort the results in a given order. Values may be asc for ascending order or desc for descending order. Must be used in conjunction with the sortBy parameter. | [optional]  |
| **firstResult** | **int?** | Pagination of results. Specifies the index of the first result to return. | [optional]  |
| **maxResults** | **int?** | Pagination of results. Specifies the maximum number of results to return. Will return less results if there are no more results left. | [optional]  |

### Return type

[**List&lt;UserProfileDto&gt;**](UserProfileDto.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **400** | Returned if some of the query parameters are invalid, for example if a &#x60;sortOrder&#x60; parameter is supplied, but no &#x60;sortBy&#x60;, or if an invalid operator for variable comparison is used. See the [Introduction](https://docs.camunda.org/manual/7.21/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="unlockuser"></a>
# **UnlockUser**
> void UnlockUser (string id)

Unlock User

Unlocks a user by id.

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
    public class UnlockUserExample
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
            var apiInstance = new UserApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | The id of the user to be unlocked.

            try
            {
                // Unlock User
                apiInstance.UnlockUser(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UnlockUser: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UnlockUserWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Unlock User
    apiInstance.UnlockUserWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UnlockUserWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The id of the user to be unlocked. |  |

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
| **403** | The user who performed the operation is not a Camunda admin user. |  -  |
| **404** | User cannot be found. See the [Introduction](https://docs.camunda.org/manual/7.21/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatecredentials"></a>
# **UpdateCredentials**
> void UpdateCredentials (string id, UserCredentialsDto userCredentialsDto = null)

Update Credentials

Updates a user's credentials (password)

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
    public class UpdateCredentialsExample
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
            var apiInstance = new UserApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | The id of the user to be updated.
            var userCredentialsDto = new UserCredentialsDto(); // UserCredentialsDto |  (optional) 

            try
            {
                // Update Credentials
                apiInstance.UpdateCredentials(id, userCredentialsDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UpdateCredentials: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateCredentialsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Credentials
    apiInstance.UpdateCredentialsWithHttpInfo(id, userCredentialsDto);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UpdateCredentialsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The id of the user to be updated. |  |
| **userCredentialsDto** | [**UserCredentialsDto**](UserCredentialsDto.md) |  | [optional]  |

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
| **204** | Request successful. This method returns no content. |  -  |
| **403** | Identity service is read-only (Cannot modify users / groups / memberships). |  -  |
| **400** | The authenticated user password does not match |  -  |
| **404** | If the corresponding user cannot be found |  -  |
| **500** | The user could not be updated due to an internal server error. See the [Introduction](https://docs.camunda.org/manual/7.21/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updateprofile"></a>
# **UpdateProfile**
> void UpdateProfile (string id, UserProfileDto userProfileDto = null)

Update User Profile

Updates the profile information of an already existing user.

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
    public class UpdateProfileExample
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
            var apiInstance = new UserApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | The id of the user.
            var userProfileDto = new UserProfileDto(); // UserProfileDto |  (optional) 

            try
            {
                // Update User Profile
                apiInstance.UpdateProfile(id, userProfileDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UpdateProfile: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateProfileWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update User Profile
    apiInstance.UpdateProfileWithHttpInfo(id, userProfileDto);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UpdateProfileWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The id of the user. |  |
| **userProfileDto** | [**UserProfileDto**](UserProfileDto.md) |  | [optional]  |

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
| **204** | Request successful. This method returns no content. |  -  |
| **403** | Identity service is read-only (Cannot modify users / groups / memberships). |  -  |
| **404** | If the user with the requested Id cannot be found. |  -  |
| **500** | The user could not be updated due to an internal server error. See the [Introduction](https://docs.camunda.org/manual/7.21/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

