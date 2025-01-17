# Camunda.OpenApi.Client.Api.MetricsApi

All URIs are relative to *http://localhost:8080/engine-rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteTaskMetrics**](MetricsApi.md#deletetaskmetrics) | **DELETE** /metrics/task-worker | Delete Task Worker Metrics |
| [**GetMetrics**](MetricsApi.md#getmetrics) | **GET** /metrics/{metrics-name}/sum | Get Sum |
| [**Interval**](MetricsApi.md#interval) | **GET** /metrics | Get Metrics in Interval |

<a id="deletetaskmetrics"></a>
# **DeleteTaskMetrics**
> void DeleteTaskMetrics (DateTime? date = null)

Delete Task Worker Metrics

Deletes all task worker metrics prior to the given date or all if no date is provided.

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
    public class DeleteTaskMetricsExample
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
            var apiInstance = new MetricsApi(httpClient, config, httpClientHandler);
            var date = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | The date prior to which all task worker metrics should be deleted. (optional) 

            try
            {
                // Delete Task Worker Metrics
                apiInstance.DeleteTaskMetrics(date);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetricsApi.DeleteTaskMetrics: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteTaskMetricsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Task Worker Metrics
    apiInstance.DeleteTaskMetricsWithHttpInfo(date);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MetricsApi.DeleteTaskMetricsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **date** | **DateTime?** | The date prior to which all task worker metrics should be deleted. | [optional]  |

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
| **403** | If the user who performs the operation is not a &lt;b&gt;camunda-admin&lt;/b&gt; user. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getmetrics"></a>
# **GetMetrics**
> MetricsResultDto GetMetrics (string metricsName, DateTime? startDate = null, DateTime? endDate = null)

Get Sum

Retrieves the `sum` (count) for a given metric.

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
    public class GetMetricsExample
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
            var apiInstance = new MetricsApi(httpClient, config, httpClientHandler);
            var metricsName = "activity-instance-start";  // string | The name of the metric.
            var startDate = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | The start date (inclusive). (optional) 
            var endDate = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | The end date (exclusive). (optional) 

            try
            {
                // Get Sum
                MetricsResultDto result = apiInstance.GetMetrics(metricsName, startDate, endDate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetricsApi.GetMetrics: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMetricsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Sum
    ApiResponse<MetricsResultDto> response = apiInstance.GetMetricsWithHttpInfo(metricsName, startDate, endDate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MetricsApi.GetMetricsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **metricsName** | **string** | The name of the metric. |  |
| **startDate** | **DateTime?** | The start date (inclusive). | [optional]  |
| **endDate** | **DateTime?** | The end date (exclusive). | [optional]  |

### Return type

[**MetricsResultDto**](MetricsResultDto.md)

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

<a id="interval"></a>
# **Interval**
> List&lt;MetricsIntervalResultDto&gt; Interval (string name = null, string reporter = null, DateTime? startDate = null, DateTime? endDate = null, int? firstResult = null, int? maxResults = null, string interval = null, string aggregateByReporter = null)

Get Metrics in Interval

Retrieves a list of metrics, aggregated for a given interval.

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
    public class IntervalExample
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
            var apiInstance = new MetricsApi(httpClient, config, httpClientHandler);
            var name = "activity-instance-start";  // string | The name of the metric. (optional) 
            var reporter = "reporter_example";  // string | The name of the reporter (host), on which the metrics was logged. This will have value provided by the [hostname configuration property](https://docs.camunda.org/manual/7.21/reference/deployment-descriptors/tags/process-engine/#hostname). (optional) 
            var startDate = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | The start date (inclusive). (optional) 
            var endDate = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | The end date (exclusive). (optional) 
            var firstResult = 56;  // int? | Pagination of results. Specifies the index of the first result to return. (optional) 
            var maxResults = 56;  // int? | Pagination of results. Specifies the maximum number of results to return. Will return less results if there are no more results left. (optional) 
            var interval = "\"900\"";  // string | The interval for which the metrics should be aggregated. Time unit is seconds. Default: The interval is set to 15 minutes (900 seconds). (optional)  (default to "900")
            var aggregateByReporter = "aggregateByReporter_example";  // string | Aggregate metrics by reporter. (optional) 

            try
            {
                // Get Metrics in Interval
                List<MetricsIntervalResultDto> result = apiInstance.Interval(name, reporter, startDate, endDate, firstResult, maxResults, interval, aggregateByReporter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetricsApi.Interval: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IntervalWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Metrics in Interval
    ApiResponse<List<MetricsIntervalResultDto>> response = apiInstance.IntervalWithHttpInfo(name, reporter, startDate, endDate, firstResult, maxResults, interval, aggregateByReporter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MetricsApi.IntervalWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** | The name of the metric. | [optional]  |
| **reporter** | **string** | The name of the reporter (host), on which the metrics was logged. This will have value provided by the [hostname configuration property](https://docs.camunda.org/manual/7.21/reference/deployment-descriptors/tags/process-engine/#hostname). | [optional]  |
| **startDate** | **DateTime?** | The start date (inclusive). | [optional]  |
| **endDate** | **DateTime?** | The end date (exclusive). | [optional]  |
| **firstResult** | **int?** | Pagination of results. Specifies the index of the first result to return. | [optional]  |
| **maxResults** | **int?** | Pagination of results. Specifies the maximum number of results to return. Will return less results if there are no more results left. | [optional]  |
| **interval** | **string** | The interval for which the metrics should be aggregated. Time unit is seconds. Default: The interval is set to 15 minutes (900 seconds). | [optional] [default to &quot;900&quot;] |
| **aggregateByReporter** | **string** | Aggregate metrics by reporter. | [optional]  |

### Return type

[**List&lt;MetricsIntervalResultDto&gt;**](MetricsIntervalResultDto.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **400** | Returned if some of the query parameters are invalid. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

