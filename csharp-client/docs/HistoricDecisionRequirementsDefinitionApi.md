# Camunda.OpenApi.Client.Api.HistoricDecisionRequirementsDefinitionApi

All URIs are relative to *http://localhost:8080/engine-rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetDecisionStatistics**](HistoricDecisionRequirementsDefinitionApi.md#getdecisionstatistics) | **GET** /history/decision-requirements-definition/{id}/statistics | Get DRD Statistics |

<a id="getdecisionstatistics"></a>
# **GetDecisionStatistics**
> List&lt;HistoricDecisionInstanceStatisticsDto&gt; GetDecisionStatistics (string id, string decisionInstanceId = null)

Get DRD Statistics

Retrieves evaluation statistics of a given decision requirements definition.

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
    public class GetDecisionStatisticsExample
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
            var apiInstance = new HistoricDecisionRequirementsDefinitionApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | The id of the decision requirements definition.
            var decisionInstanceId = "decisionInstanceId_example";  // string | Restrict query results to be based only on specific evaluation instance of a given decision requirements definition. (optional) 

            try
            {
                // Get DRD Statistics
                List<HistoricDecisionInstanceStatisticsDto> result = apiInstance.GetDecisionStatistics(id, decisionInstanceId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HistoricDecisionRequirementsDefinitionApi.GetDecisionStatistics: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDecisionStatisticsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get DRD Statistics
    ApiResponse<List<HistoricDecisionInstanceStatisticsDto>> response = apiInstance.GetDecisionStatisticsWithHttpInfo(id, decisionInstanceId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HistoricDecisionRequirementsDefinitionApi.GetDecisionStatisticsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The id of the decision requirements definition. |  |
| **decisionInstanceId** | **string** | Restrict query results to be based only on specific evaluation instance of a given decision requirements definition. | [optional]  |

### Return type

[**List&lt;HistoricDecisionInstanceStatisticsDto&gt;**](HistoricDecisionInstanceStatisticsDto.md)

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

