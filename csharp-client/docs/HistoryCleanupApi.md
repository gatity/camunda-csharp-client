# Camunda.OpenApi.Client.Api.HistoryCleanupApi

All URIs are relative to *http://localhost:8080/engine-rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CleanupAsync**](HistoryCleanupApi.md#cleanupasync) | **POST** /history/cleanup | Clean up history (POST) |
| [**FindCleanupJob**](HistoryCleanupApi.md#findcleanupjob) | **GET** /history/cleanup/job | Find clean up history job (GET) |
| [**FindCleanupJobs**](HistoryCleanupApi.md#findcleanupjobs) | **GET** /history/cleanup/jobs | Find clean up history jobs (GET) |
| [**GetHistoryCleanupConfiguration**](HistoryCleanupApi.md#gethistorycleanupconfiguration) | **GET** /history/cleanup/configuration | Get History Cleanup Configuration |

<a id="cleanupasync"></a>
# **CleanupAsync**
> JobDto CleanupAsync (bool? immediatelyDue = null)

Clean up history (POST)

Schedules asynchronous history cleanup (See [History cleanup](https://docs.camunda.org/manual/7.21/user-guide/process-engine/history/#history-cleanup)).  **Note:** This endpoint will return at most a single history cleanup job. Since version `7.9.0` it is possible to configure multiple [parallel history cleanup jobs](https://docs.camunda.org/manual/7.21/user-guide/process-engine/history/#parallel-execution). Use [`GET /history/cleanup/jobs`](https://docs.camunda.org/manual/7.21/reference/rest/history/history-cleanup/get-history-cleanup-jobs) to find all the available history cleanup jobs.

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
    public class CleanupAsyncExample
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
            var apiInstance = new HistoryCleanupApi(httpClient, config, httpClientHandler);
            var immediatelyDue = true;  // bool? | When true the job will be scheduled for nearest future. When `false`, the job will be scheduled for next batch window start time. Default is `true`. (optional) 

            try
            {
                // Clean up history (POST)
                JobDto result = apiInstance.CleanupAsync(immediatelyDue);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HistoryCleanupApi.CleanupAsync: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CleanupAsyncWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Clean up history (POST)
    ApiResponse<JobDto> response = apiInstance.CleanupAsyncWithHttpInfo(immediatelyDue);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HistoryCleanupApi.CleanupAsyncWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **immediatelyDue** | **bool?** | When true the job will be scheduled for nearest future. When &#x60;false&#x60;, the job will be scheduled for next batch window start time. Default is &#x60;true&#x60;. | [optional]  |

### Return type

[**JobDto**](JobDto.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **400** | Returned if some of the query parameters are invalid or the engine does not participate in history cleanup. See [Cleanup Execution Participation per Node](https://docs.camunda.org/manual/7.21/user-guide/process-engine/history/#cleanup-execution-participation-per-node). |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="findcleanupjob"></a>
# **FindCleanupJob**
> JobDto FindCleanupJob ()

Find clean up history job (GET)

**Deprecated!** Use `GET /history/cleanup/jobs` instead.  Finds history cleanup job (See [History cleanup](https://docs.camunda.org/manual/7.21/user-guide/process-engine/history/#history-cleanup)).

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
    public class FindCleanupJobExample
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
            var apiInstance = new HistoryCleanupApi(httpClient, config, httpClientHandler);

            try
            {
                // Find clean up history job (GET)
                JobDto result = apiInstance.FindCleanupJob();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HistoryCleanupApi.FindCleanupJob: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FindCleanupJobWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Find clean up history job (GET)
    ApiResponse<JobDto> response = apiInstance.FindCleanupJobWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HistoryCleanupApi.FindCleanupJobWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**JobDto**](JobDto.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **404** | History clean up job does not exist. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="findcleanupjobs"></a>
# **FindCleanupJobs**
> List&lt;JobDto&gt; FindCleanupJobs ()

Find clean up history jobs (GET)

Finds history cleanup jobs (See [History cleanup](https://docs.camunda.org/manual/7.21/user-guide/process-engine/history/#history-cleanup)).

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
    public class FindCleanupJobsExample
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
            var apiInstance = new HistoryCleanupApi(httpClient, config, httpClientHandler);

            try
            {
                // Find clean up history jobs (GET)
                List<JobDto> result = apiInstance.FindCleanupJobs();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HistoryCleanupApi.FindCleanupJobs: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FindCleanupJobsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Find clean up history jobs (GET)
    ApiResponse<List<JobDto>> response = apiInstance.FindCleanupJobsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HistoryCleanupApi.FindCleanupJobsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;JobDto&gt;**](JobDto.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **404** | History clean up jobs are empty. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gethistorycleanupconfiguration"></a>
# **GetHistoryCleanupConfiguration**
> HistoryCleanupConfigurationDto GetHistoryCleanupConfiguration ()

Get History Cleanup Configuration

Retrieves history cleanup batch window configuration (See [History cleanup](https://docs.camunda.org/manual/7.21/user-guide/process-engine/history/#history-cleanup)).

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
    public class GetHistoryCleanupConfigurationExample
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
            var apiInstance = new HistoryCleanupApi(httpClient, config, httpClientHandler);

            try
            {
                // Get History Cleanup Configuration
                HistoryCleanupConfigurationDto result = apiInstance.GetHistoryCleanupConfiguration();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HistoryCleanupApi.GetHistoryCleanupConfiguration: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetHistoryCleanupConfigurationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get History Cleanup Configuration
    ApiResponse<HistoryCleanupConfigurationDto> response = apiInstance.GetHistoryCleanupConfigurationWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HistoryCleanupApi.GetHistoryCleanupConfigurationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**HistoryCleanupConfigurationDto**](HistoryCleanupConfigurationDto.md)

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

