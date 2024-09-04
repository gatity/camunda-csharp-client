# Camunda.OpenApi.Client.Api.BatchApi

All URIs are relative to *http://localhost:8080/engine-rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteBatch**](BatchApi.md#deletebatch) | **DELETE** /batch/{id} | Delete |
| [**GetBatch**](BatchApi.md#getbatch) | **GET** /batch/{id} | Get |
| [**GetBatchStatistics**](BatchApi.md#getbatchstatistics) | **GET** /batch/statistics | Get Statistics |
| [**GetBatchStatisticsCount**](BatchApi.md#getbatchstatisticscount) | **GET** /batch/statistics/count | Get Statistics Count |
| [**GetBatches**](BatchApi.md#getbatches) | **GET** /batch | Get List |
| [**GetBatchesCount**](BatchApi.md#getbatchescount) | **GET** /batch/count | Get List Count |
| [**UpdateBatchSuspensionState**](BatchApi.md#updatebatchsuspensionstate) | **PUT** /batch/{id}/suspended | Activate/Suspend |

<a id="deletebatch"></a>
# **DeleteBatch**
> void DeleteBatch (string id, bool? cascade = null)

Delete

Deletes a batch by id, including all related jobs and job definitions. Optionally also deletes the batch history.

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
    public class DeleteBatchExample
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
            var apiInstance = new BatchApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | The id of the batch to be deleted.
            var cascade = true;  // bool? | `true`, if the historic batch and historic job logs for this batch should also be deleted. (optional) 

            try
            {
                // Delete
                apiInstance.DeleteBatch(id, cascade);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BatchApi.DeleteBatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteBatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete
    apiInstance.DeleteBatchWithHttpInfo(id, cascade);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BatchApi.DeleteBatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The id of the batch to be deleted. |  |
| **cascade** | **bool?** | &#x60;true&#x60;, if the historic batch and historic job logs for this batch should also be deleted. | [optional]  |

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
| **400** | Batch with given id does not exist. See the [Introduction](https://docs.camunda.org/manual/7.21/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getbatch"></a>
# **GetBatch**
> BatchDto GetBatch (string id)

Get

Retrieves a batch by id, according to the Batch interface in the engine.

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
    public class GetBatchExample
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
            var apiInstance = new BatchApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | The id of the batch to be retrieved.

            try
            {
                // Get
                BatchDto result = apiInstance.GetBatch(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BatchApi.GetBatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetBatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get
    ApiResponse<BatchDto> response = apiInstance.GetBatchWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BatchApi.GetBatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The id of the batch to be retrieved. |  |

### Return type

[**BatchDto**](BatchDto.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **404** | Batch with given id does not exist. See the [Introduction](https://docs.camunda.org/manual/7.21/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getbatchstatistics"></a>
# **GetBatchStatistics**
> List&lt;BatchStatisticsDto&gt; GetBatchStatistics (string sortBy = null, string sortOrder = null, int? firstResult = null, int? maxResults = null, string batchId = null, string type = null, string tenantIdIn = null, bool? withoutTenantId = null, bool? suspended = null, string createdBy = null, DateTime? startedBefore = null, DateTime? startedAfter = null, bool? withFailures = null, bool? withoutFailures = null)

Get Statistics

Queries for batch statistics that fulfill given parameters. Parameters may be the properties of batches, such as the id or type. The size of the result set can be retrieved by using the  [Get Batch Statistics Count](https://docs.camunda.org/manual/7.21/reference/rest/batch/get-statistics-query-count/) method.

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
    public class GetBatchStatisticsExample
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
            var apiInstance = new BatchApi(httpClient, config, httpClientHandler);
            var sortBy = "batchId";  // string | Sort the results lexicographically by a given criterion. Must be used in conjunction with the sortOrder parameter. (optional) 
            var sortOrder = "asc";  // string | Sort the results in a given order. Values may be asc for ascending order or desc for descending order. Must be used in conjunction with the sortBy parameter. (optional) 
            var firstResult = 56;  // int? | Pagination of results. Specifies the index of the first result to return. (optional) 
            var maxResults = 56;  // int? | Pagination of results. Specifies the maximum number of results to return. Will return less results if there are no more results left. (optional) 
            var batchId = "batchId_example";  // string | Filter by batch id. (optional) 
            var type = "type_example";  // string | Filter by batch type. See the [User Guide](https://docs.camunda.org/manual/7.21/user-guide/process-engine/batch/#creating-a-batch) for more information about batch types. (optional) 
            var tenantIdIn = "tenantIdIn_example";  // string | Filter by a comma-separated list of `Strings`. A batch matches if it has one of the given tenant ids. (optional) 
            var withoutTenantId = true;  // bool? | Only include batches which belong to no tenant. Value can effectively only be `true`, as `false` is the default behavior. (optional) 
            var suspended = true;  // bool? | A `Boolean` value which indicates whether only active or suspended batches should be included. When the value is set to `true`, only suspended batches will be returned and when the value is set to `false`, only active batches will be returned. (optional) 
            var createdBy = "createdBy_example";  // string | Only include batches that were started by this user id. (optional) 
            var startedBefore = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Only include batches that were started before the given date. By [default](https://docs.camunda.org/manual/7.21/reference/rest/overview/date-format/), the date must have the format `yyyy-MM-dd'T'HH:mm:ss.SSSZ`, e.g., `2013-01-23T14:42:45.000+0200`. (optional) 
            var startedAfter = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Only include batches that were started after the given date. By [default](https://docs.camunda.org/manual/7.21/reference/rest/overview/date-format/), the date must have the format `yyyy-MM-dd'T'HH:mm:ss.SSSZ`, e.g., `2013-01-23T14:42:45.000+0200`. (optional) 
            var withFailures = true;  // bool? | Only include batches having jobs with failures. Value can only be `true`. (optional) 
            var withoutFailures = true;  // bool? | Only include batches having jobs without failures. Value can only be `true`. (optional) 

            try
            {
                // Get Statistics
                List<BatchStatisticsDto> result = apiInstance.GetBatchStatistics(sortBy, sortOrder, firstResult, maxResults, batchId, type, tenantIdIn, withoutTenantId, suspended, createdBy, startedBefore, startedAfter, withFailures, withoutFailures);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BatchApi.GetBatchStatistics: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetBatchStatisticsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Statistics
    ApiResponse<List<BatchStatisticsDto>> response = apiInstance.GetBatchStatisticsWithHttpInfo(sortBy, sortOrder, firstResult, maxResults, batchId, type, tenantIdIn, withoutTenantId, suspended, createdBy, startedBefore, startedAfter, withFailures, withoutFailures);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BatchApi.GetBatchStatisticsWithHttpInfo: " + e.Message);
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
| **batchId** | **string** | Filter by batch id. | [optional]  |
| **type** | **string** | Filter by batch type. See the [User Guide](https://docs.camunda.org/manual/7.21/user-guide/process-engine/batch/#creating-a-batch) for more information about batch types. | [optional]  |
| **tenantIdIn** | **string** | Filter by a comma-separated list of &#x60;Strings&#x60;. A batch matches if it has one of the given tenant ids. | [optional]  |
| **withoutTenantId** | **bool?** | Only include batches which belong to no tenant. Value can effectively only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional]  |
| **suspended** | **bool?** | A &#x60;Boolean&#x60; value which indicates whether only active or suspended batches should be included. When the value is set to &#x60;true&#x60;, only suspended batches will be returned and when the value is set to &#x60;false&#x60;, only active batches will be returned. | [optional]  |
| **createdBy** | **string** | Only include batches that were started by this user id. | [optional]  |
| **startedBefore** | **DateTime?** | Only include batches that were started before the given date. By [default](https://docs.camunda.org/manual/7.21/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;. | [optional]  |
| **startedAfter** | **DateTime?** | Only include batches that were started after the given date. By [default](https://docs.camunda.org/manual/7.21/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;. | [optional]  |
| **withFailures** | **bool?** | Only include batches having jobs with failures. Value can only be &#x60;true&#x60;. | [optional]  |
| **withoutFailures** | **bool?** | Only include batches having jobs without failures. Value can only be &#x60;true&#x60;. | [optional]  |

### Return type

[**List&lt;BatchStatisticsDto&gt;**](BatchStatisticsDto.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **400** | Returned if some of the query parameters are invalid, for example if a &#x60;sortOrder&#x60; parameter is supplied, but no &#x60;sortBy&#x60;. See the [Introduction](https://docs.camunda.org/manual/7.21/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getbatchstatisticscount"></a>
# **GetBatchStatisticsCount**
> CountResultDto GetBatchStatisticsCount (string batchId = null, string type = null, string tenantIdIn = null, bool? withoutTenantId = null, bool? suspended = null, string createdBy = null, DateTime? startedBefore = null, DateTime? startedAfter = null, bool? withFailures = null, bool? withoutFailures = null)

Get Statistics Count

Requests the number of batch statistics that fulfill the query criteria. Takes the same filtering parameters as the [Get Batch Statistics](https://docs.camunda.org/manual/7.21/reference/rest/batch/get-statistics-query/) method.

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
    public class GetBatchStatisticsCountExample
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
            var apiInstance = new BatchApi(httpClient, config, httpClientHandler);
            var batchId = "batchId_example";  // string | Filter by batch id. (optional) 
            var type = "type_example";  // string | Filter by batch type. See the [User Guide](https://docs.camunda.org/manual/7.21/user-guide/process-engine/batch/#creating-a-batch) for more information about batch types. (optional) 
            var tenantIdIn = "tenantIdIn_example";  // string | Filter by a comma-separated list of `Strings`. A batch matches if it has one of the given tenant ids. (optional) 
            var withoutTenantId = true;  // bool? | Only include batches which belong to no tenant. Value can effectively only be `true`, as `false` is the default behavior. (optional) 
            var suspended = true;  // bool? | A `Boolean` value which indicates whether only active or suspended batches should be included. When the value is set to `true`, only suspended batches will be returned and when the value is set to `false`, only active batches will be returned. (optional) 
            var createdBy = "createdBy_example";  // string | Only include batches that were started by this user id. (optional) 
            var startedBefore = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Only include batches that were started before the given date. By [default](https://docs.camunda.org/manual/7.21/reference/rest/overview/date-format/), the date must have the format `yyyy-MM-dd'T'HH:mm:ss.SSSZ`, e.g., `2013-01-23T14:42:45.000+0200`. (optional) 
            var startedAfter = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Only include batches that were started after the given date. By [default](https://docs.camunda.org/manual/7.21/reference/rest/overview/date-format/), the date must have the format `yyyy-MM-dd'T'HH:mm:ss.SSSZ`, e.g., `2013-01-23T14:42:45.000+0200`. (optional) 
            var withFailures = true;  // bool? | Only include batches having jobs with failures. Value can only be `true`. (optional) 
            var withoutFailures = true;  // bool? | Only include batches having jobs without failures. Value can only be `true`. (optional) 

            try
            {
                // Get Statistics Count
                CountResultDto result = apiInstance.GetBatchStatisticsCount(batchId, type, tenantIdIn, withoutTenantId, suspended, createdBy, startedBefore, startedAfter, withFailures, withoutFailures);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BatchApi.GetBatchStatisticsCount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetBatchStatisticsCountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Statistics Count
    ApiResponse<CountResultDto> response = apiInstance.GetBatchStatisticsCountWithHttpInfo(batchId, type, tenantIdIn, withoutTenantId, suspended, createdBy, startedBefore, startedAfter, withFailures, withoutFailures);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BatchApi.GetBatchStatisticsCountWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **batchId** | **string** | Filter by batch id. | [optional]  |
| **type** | **string** | Filter by batch type. See the [User Guide](https://docs.camunda.org/manual/7.21/user-guide/process-engine/batch/#creating-a-batch) for more information about batch types. | [optional]  |
| **tenantIdIn** | **string** | Filter by a comma-separated list of &#x60;Strings&#x60;. A batch matches if it has one of the given tenant ids. | [optional]  |
| **withoutTenantId** | **bool?** | Only include batches which belong to no tenant. Value can effectively only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional]  |
| **suspended** | **bool?** | A &#x60;Boolean&#x60; value which indicates whether only active or suspended batches should be included. When the value is set to &#x60;true&#x60;, only suspended batches will be returned and when the value is set to &#x60;false&#x60;, only active batches will be returned. | [optional]  |
| **createdBy** | **string** | Only include batches that were started by this user id. | [optional]  |
| **startedBefore** | **DateTime?** | Only include batches that were started before the given date. By [default](https://docs.camunda.org/manual/7.21/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;. | [optional]  |
| **startedAfter** | **DateTime?** | Only include batches that were started after the given date. By [default](https://docs.camunda.org/manual/7.21/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;. | [optional]  |
| **withFailures** | **bool?** | Only include batches having jobs with failures. Value can only be &#x60;true&#x60;. | [optional]  |
| **withoutFailures** | **bool?** | Only include batches having jobs without failures. Value can only be &#x60;true&#x60;. | [optional]  |

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

<a id="getbatches"></a>
# **GetBatches**
> List&lt;BatchDto&gt; GetBatches (string sortBy = null, string sortOrder = null, int? firstResult = null, int? maxResults = null, string batchId = null, string type = null, string tenantIdIn = null, bool? withoutTenantId = null, bool? suspended = null, string createdBy = null, DateTime? startedBefore = null, DateTime? startedAfter = null, bool? withFailures = null, bool? withoutFailures = null)

Get List

Queries for batches that fulfill given parameters. Parameters may be the properties of batches, such as the id or type. The size of the result set can be retrieved by using the [Get Batch Count](https://docs.camunda.org/manual/7.21/reference/rest/batch/get-query-count/) method.

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
    public class GetBatchesExample
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
            var apiInstance = new BatchApi(httpClient, config, httpClientHandler);
            var sortBy = "batchId";  // string | Sort the results lexicographically by a given criterion. Must be used in conjunction with the sortOrder parameter. (optional) 
            var sortOrder = "asc";  // string | Sort the results in a given order. Values may be asc for ascending order or desc for descending order. Must be used in conjunction with the sortBy parameter. (optional) 
            var firstResult = 56;  // int? | Pagination of results. Specifies the index of the first result to return. (optional) 
            var maxResults = 56;  // int? | Pagination of results. Specifies the maximum number of results to return. Will return less results if there are no more results left. (optional) 
            var batchId = "batchId_example";  // string | Filter by batch id. (optional) 
            var type = "type_example";  // string | Filter by batch type. See the [User Guide](https://docs.camunda.org/manual/7.21/user-guide/process-engine/batch/#creating-a-batch) for more information about batch types. (optional) 
            var tenantIdIn = "tenantIdIn_example";  // string | Filter by a comma-separated list of `Strings`. A batch matches if it has one of the given tenant ids. (optional) 
            var withoutTenantId = true;  // bool? | Only include batches which belong to no tenant. Value can effectively only be `true`, as `false` is the default behavior. (optional) 
            var suspended = true;  // bool? | A `Boolean` value which indicates whether only active or suspended batches should be included. When the value is set to `true`, only suspended batches will be returned and when the value is set to `false`, only active batches will be returned. (optional) 
            var createdBy = "createdBy_example";  // string | Only include batches that were started by this user id. (optional) 
            var startedBefore = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Only include batches that were started before the given date. By [default](https://docs.camunda.org/manual/7.21/reference/rest/overview/date-format/), the date must have the format `yyyy-MM-dd'T'HH:mm:ss.SSSZ`, e.g., `2013-01-23T14:42:45.000+0200`. (optional) 
            var startedAfter = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Only include batches that were started after the given date. By [default](https://docs.camunda.org/manual/7.21/reference/rest/overview/date-format/), the date must have the format `yyyy-MM-dd'T'HH:mm:ss.SSSZ`, e.g., `2013-01-23T14:42:45.000+0200`. (optional) 
            var withFailures = true;  // bool? | Only include batches having jobs with failures. Value can only be `true`. (optional) 
            var withoutFailures = true;  // bool? | Only include batches having jobs without failures. Value can only be `true`. (optional) 

            try
            {
                // Get List
                List<BatchDto> result = apiInstance.GetBatches(sortBy, sortOrder, firstResult, maxResults, batchId, type, tenantIdIn, withoutTenantId, suspended, createdBy, startedBefore, startedAfter, withFailures, withoutFailures);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BatchApi.GetBatches: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetBatchesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get List
    ApiResponse<List<BatchDto>> response = apiInstance.GetBatchesWithHttpInfo(sortBy, sortOrder, firstResult, maxResults, batchId, type, tenantIdIn, withoutTenantId, suspended, createdBy, startedBefore, startedAfter, withFailures, withoutFailures);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BatchApi.GetBatchesWithHttpInfo: " + e.Message);
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
| **batchId** | **string** | Filter by batch id. | [optional]  |
| **type** | **string** | Filter by batch type. See the [User Guide](https://docs.camunda.org/manual/7.21/user-guide/process-engine/batch/#creating-a-batch) for more information about batch types. | [optional]  |
| **tenantIdIn** | **string** | Filter by a comma-separated list of &#x60;Strings&#x60;. A batch matches if it has one of the given tenant ids. | [optional]  |
| **withoutTenantId** | **bool?** | Only include batches which belong to no tenant. Value can effectively only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional]  |
| **suspended** | **bool?** | A &#x60;Boolean&#x60; value which indicates whether only active or suspended batches should be included. When the value is set to &#x60;true&#x60;, only suspended batches will be returned and when the value is set to &#x60;false&#x60;, only active batches will be returned. | [optional]  |
| **createdBy** | **string** | Only include batches that were started by this user id. | [optional]  |
| **startedBefore** | **DateTime?** | Only include batches that were started before the given date. By [default](https://docs.camunda.org/manual/7.21/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;. | [optional]  |
| **startedAfter** | **DateTime?** | Only include batches that were started after the given date. By [default](https://docs.camunda.org/manual/7.21/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;. | [optional]  |
| **withFailures** | **bool?** | Only include batches having jobs with failures. Value can only be &#x60;true&#x60;. | [optional]  |
| **withoutFailures** | **bool?** | Only include batches having jobs without failures. Value can only be &#x60;true&#x60;. | [optional]  |

### Return type

[**List&lt;BatchDto&gt;**](BatchDto.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **400** | Returned if some of the query parameters are invalid, for example if a &#x60;sortOrder&#x60; parameter is supplied, but no &#x60;sortBy&#x60;. See the [Introduction](https://docs.camunda.org/manual/7.21/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getbatchescount"></a>
# **GetBatchesCount**
> CountResultDto GetBatchesCount (string batchId = null, string type = null, string tenantIdIn = null, bool? withoutTenantId = null, bool? suspended = null, string createdBy = null, DateTime? startedBefore = null, DateTime? startedAfter = null, bool? withFailures = null, bool? withoutFailures = null)

Get List Count

Requests the number of batches that fulfill the query criteria. Takes the same filtering parameters as the [Get Batches](https://docs.camunda.org/manual/7.21/reference/rest/batch/get-query/) method.

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
    public class GetBatchesCountExample
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
            var apiInstance = new BatchApi(httpClient, config, httpClientHandler);
            var batchId = "batchId_example";  // string | Filter by batch id. (optional) 
            var type = "type_example";  // string | Filter by batch type. See the [User Guide](https://docs.camunda.org/manual/7.21/user-guide/process-engine/batch/#creating-a-batch) for more information about batch types. (optional) 
            var tenantIdIn = "tenantIdIn_example";  // string | Filter by a comma-separated list of `Strings`. A batch matches if it has one of the given tenant ids. (optional) 
            var withoutTenantId = true;  // bool? | Only include batches which belong to no tenant. Value can effectively only be `true`, as `false` is the default behavior. (optional) 
            var suspended = true;  // bool? | A `Boolean` value which indicates whether only active or suspended batches should be included. When the value is set to `true`, only suspended batches will be returned and when the value is set to `false`, only active batches will be returned. (optional) 
            var createdBy = "createdBy_example";  // string | Only include batches that were started by this user id. (optional) 
            var startedBefore = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Only include batches that were started before the given date. By [default](https://docs.camunda.org/manual/7.21/reference/rest/overview/date-format/), the date must have the format `yyyy-MM-dd'T'HH:mm:ss.SSSZ`, e.g., `2013-01-23T14:42:45.000+0200`. (optional) 
            var startedAfter = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Only include batches that were started after the given date. By [default](https://docs.camunda.org/manual/7.21/reference/rest/overview/date-format/), the date must have the format `yyyy-MM-dd'T'HH:mm:ss.SSSZ`, e.g., `2013-01-23T14:42:45.000+0200`. (optional) 
            var withFailures = true;  // bool? | Only include batches having jobs with failures. Value can only be `true`. (optional) 
            var withoutFailures = true;  // bool? | Only include batches having jobs without failures. Value can only be `true`. (optional) 

            try
            {
                // Get List Count
                CountResultDto result = apiInstance.GetBatchesCount(batchId, type, tenantIdIn, withoutTenantId, suspended, createdBy, startedBefore, startedAfter, withFailures, withoutFailures);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BatchApi.GetBatchesCount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetBatchesCountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get List Count
    ApiResponse<CountResultDto> response = apiInstance.GetBatchesCountWithHttpInfo(batchId, type, tenantIdIn, withoutTenantId, suspended, createdBy, startedBefore, startedAfter, withFailures, withoutFailures);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BatchApi.GetBatchesCountWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **batchId** | **string** | Filter by batch id. | [optional]  |
| **type** | **string** | Filter by batch type. See the [User Guide](https://docs.camunda.org/manual/7.21/user-guide/process-engine/batch/#creating-a-batch) for more information about batch types. | [optional]  |
| **tenantIdIn** | **string** | Filter by a comma-separated list of &#x60;Strings&#x60;. A batch matches if it has one of the given tenant ids. | [optional]  |
| **withoutTenantId** | **bool?** | Only include batches which belong to no tenant. Value can effectively only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. | [optional]  |
| **suspended** | **bool?** | A &#x60;Boolean&#x60; value which indicates whether only active or suspended batches should be included. When the value is set to &#x60;true&#x60;, only suspended batches will be returned and when the value is set to &#x60;false&#x60;, only active batches will be returned. | [optional]  |
| **createdBy** | **string** | Only include batches that were started by this user id. | [optional]  |
| **startedBefore** | **DateTime?** | Only include batches that were started before the given date. By [default](https://docs.camunda.org/manual/7.21/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;. | [optional]  |
| **startedAfter** | **DateTime?** | Only include batches that were started after the given date. By [default](https://docs.camunda.org/manual/7.21/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;. | [optional]  |
| **withFailures** | **bool?** | Only include batches having jobs with failures. Value can only be &#x60;true&#x60;. | [optional]  |
| **withoutFailures** | **bool?** | Only include batches having jobs without failures. Value can only be &#x60;true&#x60;. | [optional]  |

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

<a id="updatebatchsuspensionstate"></a>
# **UpdateBatchSuspensionState**
> void UpdateBatchSuspensionState (string id, SuspensionStateDto suspensionStateDto = null)

Activate/Suspend

Activates or suspends a batch by id.

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
    public class UpdateBatchSuspensionStateExample
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
            var apiInstance = new BatchApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | The id of the batch to activate or suspend.
            var suspensionStateDto = new SuspensionStateDto(); // SuspensionStateDto |  (optional) 

            try
            {
                // Activate/Suspend
                apiInstance.UpdateBatchSuspensionState(id, suspensionStateDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BatchApi.UpdateBatchSuspensionState: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateBatchSuspensionStateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Activate/Suspend
    apiInstance.UpdateBatchSuspensionStateWithHttpInfo(id, suspensionStateDto);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BatchApi.UpdateBatchSuspensionStateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The id of the batch to activate or suspend. |  |
| **suspensionStateDto** | [**SuspensionStateDto**](SuspensionStateDto.md) |  | [optional]  |

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
| **400** | Returned if the batch cannot be suspended or activated. See the [Introduction](https://docs.camunda.org/manual/7.21/reference/rest/overview/#error-handling) for the error response format. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

