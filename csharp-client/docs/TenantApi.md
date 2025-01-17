# Camunda.OpenApi.Client.Api.TenantApi

All URIs are relative to *http://localhost:8080/engine-rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AvailableTenantGroupMembersOperations**](TenantApi.md#availabletenantgroupmembersoperations) | **OPTIONS** /tenant/{id}/group-members | Tenant Group Membership Resource Options |
| [**AvailableTenantInstanceOperations**](TenantApi.md#availabletenantinstanceoperations) | **OPTIONS** /tenant/{id} | Tenant Resource Options |
| [**AvailableTenantResourceOperations**](TenantApi.md#availabletenantresourceoperations) | **OPTIONS** /tenant | Tenant Resource Options |
| [**AvailableTenantUserMembersOperations**](TenantApi.md#availabletenantusermembersoperations) | **OPTIONS** /tenant/{id}/user-members | Tenant User Membership Resource Options |
| [**CreateGroupMembership**](TenantApi.md#creategroupmembership) | **PUT** /tenant/{id}/group-members/{groupId} | Create Tenant Group Membership |
| [**CreateTenant**](TenantApi.md#createtenant) | **POST** /tenant/create | Create Tenant |
| [**CreateUserMembership**](TenantApi.md#createusermembership) | **PUT** /tenant/{id}/user-members/{userId} | Create Tenant User Membership |
| [**DeleteGroupMembership**](TenantApi.md#deletegroupmembership) | **DELETE** /tenant/{id}/group-members/{groupId} | Create Tenant Group Membership |
| [**DeleteTenant**](TenantApi.md#deletetenant) | **DELETE** /tenant/{id} | Delete Tenant |
| [**DeleteUserMembership**](TenantApi.md#deleteusermembership) | **DELETE** /tenant/{id}/user-members/{userId} | Delete a Tenant User Membership |
| [**GetTenant**](TenantApi.md#gettenant) | **GET** /tenant/{id} | Get Tenant |
| [**GetTenantCount**](TenantApi.md#gettenantcount) | **GET** /tenant/count | Get Tenant Count |
| [**QueryTenants**](TenantApi.md#querytenants) | **GET** /tenant | Get Tenants |
| [**UpdateTenant**](TenantApi.md#updatetenant) | **PUT** /tenant/{id} | Update Tenant |

<a id="availabletenantgroupmembersoperations"></a>
# **AvailableTenantGroupMembersOperations**
> ResourceOptionsDto AvailableTenantGroupMembersOperations (string id)

Tenant Group Membership Resource Options

The OPTIONS request allows checking for the set of available operations that the currently authenticated user can perform on the resource. If the user can perform an operation or not may depend on various things, including the users authorizations to interact with this resource and the internal configuration of the process engine.

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
    public class AvailableTenantGroupMembersOperationsExample
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
            var apiInstance = new TenantApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | The id of the tenant

            try
            {
                // Tenant Group Membership Resource Options
                ResourceOptionsDto result = apiInstance.AvailableTenantGroupMembersOperations(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TenantApi.AvailableTenantGroupMembersOperations: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AvailableTenantGroupMembersOperationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Tenant Group Membership Resource Options
    ApiResponse<ResourceOptionsDto> response = apiInstance.AvailableTenantGroupMembersOperationsWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TenantApi.AvailableTenantGroupMembersOperationsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The id of the tenant |  |

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

<a id="availabletenantinstanceoperations"></a>
# **AvailableTenantInstanceOperations**
> ResourceOptionsDto AvailableTenantInstanceOperations (string id)

Tenant Resource Options

The `/tenant` resource supports two custom OPTIONS requests, one for the resource as such and this one for individual tenant instances. The OPTIONS request allows checking for the set of available operations that the currently authenticated user can perform on the `/tenant/{id}` resource. If the user can perform an operation or not may depend on various things, including the users authorizations to interact with this resource and the internal configuration of the process engine.

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
    public class AvailableTenantInstanceOperationsExample
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
            var apiInstance = new TenantApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | The id of the tenant

            try
            {
                // Tenant Resource Options
                ResourceOptionsDto result = apiInstance.AvailableTenantInstanceOperations(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TenantApi.AvailableTenantInstanceOperations: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AvailableTenantInstanceOperationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Tenant Resource Options
    ApiResponse<ResourceOptionsDto> response = apiInstance.AvailableTenantInstanceOperationsWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TenantApi.AvailableTenantInstanceOperationsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The id of the tenant |  |

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

<a id="availabletenantresourceoperations"></a>
# **AvailableTenantResourceOperations**
> ResourceOptionsDto AvailableTenantResourceOperations ()

Tenant Resource Options

The `/tenant` resource supports two custom OPTIONS requests, this one for the resource as such and one for individual tenant instances. The OPTIONS request allows checking for the set of available operations that the currently authenticated user can perform on the `/tenant` resource. If the user can perform an operation or not may depend on various things, including the users authorizations to interact with this resource and the internal configuration of the process engine.

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
    public class AvailableTenantResourceOperationsExample
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
            var apiInstance = new TenantApi(httpClient, config, httpClientHandler);

            try
            {
                // Tenant Resource Options
                ResourceOptionsDto result = apiInstance.AvailableTenantResourceOperations();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TenantApi.AvailableTenantResourceOperations: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AvailableTenantResourceOperationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Tenant Resource Options
    ApiResponse<ResourceOptionsDto> response = apiInstance.AvailableTenantResourceOperationsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TenantApi.AvailableTenantResourceOperationsWithHttpInfo: " + e.Message);
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

<a id="availabletenantusermembersoperations"></a>
# **AvailableTenantUserMembersOperations**
> ResourceOptionsDto AvailableTenantUserMembersOperations (string id)

Tenant User Membership Resource Options

The OPTIONS request allows checking for the set of available operations that the currently authenticated user can perform on the resource. If the user can perform an operation or not may depend on various things, including the users authorizations to interact with this resource and the internal configuration of the process engine.

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
    public class AvailableTenantUserMembersOperationsExample
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
            var apiInstance = new TenantApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | The id of the tenant

            try
            {
                // Tenant User Membership Resource Options
                ResourceOptionsDto result = apiInstance.AvailableTenantUserMembersOperations(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TenantApi.AvailableTenantUserMembersOperations: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AvailableTenantUserMembersOperationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Tenant User Membership Resource Options
    ApiResponse<ResourceOptionsDto> response = apiInstance.AvailableTenantUserMembersOperationsWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TenantApi.AvailableTenantUserMembersOperationsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The id of the tenant |  |

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

<a id="creategroupmembership"></a>
# **CreateGroupMembership**
> void CreateGroupMembership (string id, string groupId)

Create Tenant Group Membership

Creates a membership between a tenant and a group.

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
    public class CreateGroupMembershipExample
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
            var apiInstance = new TenantApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | The id of the tenant.
            var groupId = "groupId_example";  // string | The id of the group.

            try
            {
                // Create Tenant Group Membership
                apiInstance.CreateGroupMembership(id, groupId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TenantApi.CreateGroupMembership: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateGroupMembershipWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Tenant Group Membership
    apiInstance.CreateGroupMembershipWithHttpInfo(id, groupId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TenantApi.CreateGroupMembershipWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The id of the tenant. |  |
| **groupId** | **string** | The id of the group. |  |

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
| **204** | Request successful. This method returns no content. |  -  |
| **403** | Identity service is read-only. |  -  |
| **500** | In case an internal error occurs. See the [Introduction](https://docs.camunda.org/manual/7.21/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createtenant"></a>
# **CreateTenant**
> void CreateTenant (TenantDto tenantDto = null)

Create Tenant

Create a new tenant.

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
    public class CreateTenantExample
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
            var apiInstance = new TenantApi(httpClient, config, httpClientHandler);
            var tenantDto = new TenantDto(); // TenantDto |  (optional) 

            try
            {
                // Create Tenant
                apiInstance.CreateTenant(tenantDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TenantApi.CreateTenant: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateTenantWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Tenant
    apiInstance.CreateTenantWithHttpInfo(tenantDto);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TenantApi.CreateTenantWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantDto** | [**TenantDto**](TenantDto.md) |  | [optional]  |

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
| **403** | Identity service is read-only. |  -  |
| **500** | The tenant could not be created due to an internal server error. See the [Introduction](https://docs.camunda.org/manual/7.21/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createusermembership"></a>
# **CreateUserMembership**
> void CreateUserMembership (string id, string userId)

Create Tenant User Membership

Creates a membership between a tenant and an user.

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
    public class CreateUserMembershipExample
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
            var apiInstance = new TenantApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | The id of the tenant.
            var userId = "userId_example";  // string | The id of the user.

            try
            {
                // Create Tenant User Membership
                apiInstance.CreateUserMembership(id, userId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TenantApi.CreateUserMembership: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateUserMembershipWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Tenant User Membership
    apiInstance.CreateUserMembershipWithHttpInfo(id, userId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TenantApi.CreateUserMembershipWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The id of the tenant. |  |
| **userId** | **string** | The id of the user. |  |

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
| **204** | Request successful. This method returns no content. |  -  |
| **403** | Identity service is read-only. |  -  |
| **500** | In case an internal error occurs. See the [Introduction](https://docs.camunda.org/manual/7.21/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletegroupmembership"></a>
# **DeleteGroupMembership**
> void DeleteGroupMembership (string id, string groupId)

Create Tenant Group Membership

Creates a membership between a tenant and a group.

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
    public class DeleteGroupMembershipExample
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
            var apiInstance = new TenantApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | The id of the tenant.
            var groupId = "groupId_example";  // string | The id of the group.

            try
            {
                // Create Tenant Group Membership
                apiInstance.DeleteGroupMembership(id, groupId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TenantApi.DeleteGroupMembership: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteGroupMembershipWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Tenant Group Membership
    apiInstance.DeleteGroupMembershipWithHttpInfo(id, groupId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TenantApi.DeleteGroupMembershipWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The id of the tenant. |  |
| **groupId** | **string** | The id of the group. |  |

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
| **204** | Request successful. This method returns no content. |  -  |
| **403** | Identity service is read-only. |  -  |
| **500** | In case an internal error occurs. See the [Introduction](https://docs.camunda.org/manual/7.21/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletetenant"></a>
# **DeleteTenant**
> void DeleteTenant (string id)

Delete Tenant

Deletes a tenant by id.

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
    public class DeleteTenantExample
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
            var apiInstance = new TenantApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | The id of the tenant to be deleted.

            try
            {
                // Delete Tenant
                apiInstance.DeleteTenant(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TenantApi.DeleteTenant: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteTenantWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Tenant
    apiInstance.DeleteTenantWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TenantApi.DeleteTenantWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The id of the tenant to be deleted. |  |

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
| **204** | Request successful. This method returns no content. |  -  |
| **403** | Identity service is read-only. |  -  |
| **404** | Tenant cannot be found. See the [Introduction](https://docs.camunda.org/manual/7.21/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteusermembership"></a>
# **DeleteUserMembership**
> void DeleteUserMembership (string id, string userId)

Delete a Tenant User Membership

Deletes a membership between a tenant and an user.

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
    public class DeleteUserMembershipExample
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
            var apiInstance = new TenantApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | The id of the tenant.
            var userId = "userId_example";  // string | The id of the user.

            try
            {
                // Delete a Tenant User Membership
                apiInstance.DeleteUserMembership(id, userId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TenantApi.DeleteUserMembership: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteUserMembershipWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a Tenant User Membership
    apiInstance.DeleteUserMembershipWithHttpInfo(id, userId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TenantApi.DeleteUserMembershipWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The id of the tenant. |  |
| **userId** | **string** | The id of the user. |  |

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
| **204** | Request successful. This method returns no content. |  -  |
| **403** | Identity service is read-only. |  -  |
| **500** | In case an error occurs. See the [Introduction](https://docs.camunda.org/manual/7.21/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gettenant"></a>
# **GetTenant**
> TenantDto GetTenant (string id)

Get Tenant

Retrieves a tenant.

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
    public class GetTenantExample
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
            var apiInstance = new TenantApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | The id of the tenant to be retrieved.

            try
            {
                // Get Tenant
                TenantDto result = apiInstance.GetTenant(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TenantApi.GetTenant: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTenantWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Tenant
    ApiResponse<TenantDto> response = apiInstance.GetTenantWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TenantApi.GetTenantWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The id of the tenant to be retrieved. |  |

### Return type

[**TenantDto**](TenantDto.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **404** | Tenant with given id does not exist. See the [Introduction](https://docs.camunda.org/manual/7.21/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gettenantcount"></a>
# **GetTenantCount**
> CountResultDto GetTenantCount (string id = null, string name = null, string nameLike = null, string userMember = null, string groupMember = null, bool? includingGroupsOfUser = null)

Get Tenant Count

Query for tenants using a list of parameters and retrieves the count.

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
    public class GetTenantCountExample
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
            var apiInstance = new TenantApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | Filter by the id of the tenant. (optional) 
            var name = "name_example";  // string | Filter by the name of the tenant. (optional) 
            var nameLike = "nameLike_example";  // string | Filter by the name that the parameter is a substring of. (optional) 
            var userMember = "userMember_example";  // string | Select only tenants where the given user is a member of. (optional) 
            var groupMember = "groupMember_example";  // string | Select only tenants where the given group is a member of. (optional) 
            var includingGroupsOfUser = true;  // bool? | Select only tenants where the user or one of his groups is a member of. Can only be used in combination with the `userMember` parameter. Value may only be `true`, as `false` is the default behavior. (optional) 

            try
            {
                // Get Tenant Count
                CountResultDto result = apiInstance.GetTenantCount(id, name, nameLike, userMember, groupMember, includingGroupsOfUser);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TenantApi.GetTenantCount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTenantCountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Tenant Count
    ApiResponse<CountResultDto> response = apiInstance.GetTenantCountWithHttpInfo(id, name, nameLike, userMember, groupMember, includingGroupsOfUser);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TenantApi.GetTenantCountWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Filter by the id of the tenant. | [optional]  |
| **name** | **string** | Filter by the name of the tenant. | [optional]  |
| **nameLike** | **string** | Filter by the name that the parameter is a substring of. | [optional]  |
| **userMember** | **string** | Select only tenants where the given user is a member of. | [optional]  |
| **groupMember** | **string** | Select only tenants where the given group is a member of. | [optional]  |
| **includingGroupsOfUser** | **bool?** | Select only tenants where the user or one of his groups is a member of. Can only be used in combination with the &#x60;userMember&#x60; parameter. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional]  |

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
| **400** | Returned if some of the query parameters are invalid. See the [Introduction](https://docs.camunda.org/manual/7.21/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="querytenants"></a>
# **QueryTenants**
> List&lt;TenantDto&gt; QueryTenants (string sortBy = null, string sortOrder = null, int? firstResult = null, int? maxResults = null, string id = null, string name = null, string nameLike = null, string userMember = null, string groupMember = null, bool? includingGroupsOfUser = null)

Get Tenants

Query for a list of tenants using a list of parameters. The size of the result set can be retrieved by using the [Get Tenant Count](https://docs.camunda.org/manual/7.21/reference/rest/tenant/get-query-count/) method.

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
    public class QueryTenantsExample
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
            var apiInstance = new TenantApi(httpClient, config, httpClientHandler);
            var sortBy = "id";  // string | Sort the results lexicographically by a given criterion. Must be used in conjunction with the sortOrder parameter. (optional) 
            var sortOrder = "asc";  // string | Sort the results in a given order. Values may be asc for ascending order or desc for descending order. Must be used in conjunction with the sortBy parameter. (optional) 
            var firstResult = 56;  // int? | Pagination of results. Specifies the index of the first result to return. (optional) 
            var maxResults = 56;  // int? | Pagination of results. Specifies the maximum number of results to return. Will return less results if there are no more results left. (optional) 
            var id = "id_example";  // string | Filter by the id of the tenant. (optional) 
            var name = "name_example";  // string | Filter by the name of the tenant. (optional) 
            var nameLike = "nameLike_example";  // string | Filter by the name that the parameter is a substring of. (optional) 
            var userMember = "userMember_example";  // string | Select only tenants where the given user is a member of. (optional) 
            var groupMember = "groupMember_example";  // string | Select only tenants where the given group is a member of. (optional) 
            var includingGroupsOfUser = true;  // bool? | Select only tenants where the user or one of his groups is a member of. Can only be used in combination with the `userMember` parameter. Value may only be `true`, as `false` is the default behavior. (optional) 

            try
            {
                // Get Tenants
                List<TenantDto> result = apiInstance.QueryTenants(sortBy, sortOrder, firstResult, maxResults, id, name, nameLike, userMember, groupMember, includingGroupsOfUser);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TenantApi.QueryTenants: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the QueryTenantsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Tenants
    ApiResponse<List<TenantDto>> response = apiInstance.QueryTenantsWithHttpInfo(sortBy, sortOrder, firstResult, maxResults, id, name, nameLike, userMember, groupMember, includingGroupsOfUser);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TenantApi.QueryTenantsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sortBy** | **string** | Sort the results lexicographically by a given criterion. Must be used in conjunction with the sortOrder parameter. | [optional]  |
| **sortOrder** | **string** | Sort the results in a given order. Values may be asc for ascending order or desc for descending order. Must be used in conjunction with the sortBy parameter. | [optional]  |
| **firstResult** | **int?** | Pagination of results. Specifies the index of the first result to return. | [optional]  |
| **maxResults** | **int?** | Pagination of results. Specifies the maximum number of results to return. Will return less results if there are no more results left. | [optional]  |
| **id** | **string** | Filter by the id of the tenant. | [optional]  |
| **name** | **string** | Filter by the name of the tenant. | [optional]  |
| **nameLike** | **string** | Filter by the name that the parameter is a substring of. | [optional]  |
| **userMember** | **string** | Select only tenants where the given user is a member of. | [optional]  |
| **groupMember** | **string** | Select only tenants where the given group is a member of. | [optional]  |
| **includingGroupsOfUser** | **bool?** | Select only tenants where the user or one of his groups is a member of. Can only be used in combination with the &#x60;userMember&#x60; parameter. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional]  |

### Return type

[**List&lt;TenantDto&gt;**](TenantDto.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **400** | Returned if some of the query parameters are invalid, for example if a &#x60;sortOrder&#x60; parameter is supplied, but no &#x60;sortBy&#x60; is specified. See the [Introduction](https://docs.camunda.org/manual/7.21/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatetenant"></a>
# **UpdateTenant**
> void UpdateTenant (string id, TenantDto tenantDto = null)

Update Tenant

Updates a given tenant.

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
    public class UpdateTenantExample
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
            var apiInstance = new TenantApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | The id of the tenant.
            var tenantDto = new TenantDto(); // TenantDto |  (optional) 

            try
            {
                // Update Tenant
                apiInstance.UpdateTenant(id, tenantDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TenantApi.UpdateTenant: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateTenantWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Tenant
    apiInstance.UpdateTenantWithHttpInfo(id, tenantDto);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TenantApi.UpdateTenantWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The id of the tenant. |  |
| **tenantDto** | [**TenantDto**](TenantDto.md) |  | [optional]  |

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
| **403** | Identity service is read-only. |  -  |
| **404** | If the tenant with the requested Id cannot be found. |  -  |
| **500** | The tenant could not be updated due to an internal server error. See the [Introduction](https://docs.camunda.org/manual/7.21/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

