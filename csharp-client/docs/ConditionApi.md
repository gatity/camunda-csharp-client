# Camunda.OpenApi.Client.Api.ConditionApi

All URIs are relative to *http://localhost:8080/engine-rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**EvaluateCondition**](ConditionApi.md#evaluatecondition) | **POST** /condition | Evaluate |

<a id="evaluatecondition"></a>
# **EvaluateCondition**
> List&lt;ProcessInstanceDto&gt; EvaluateCondition (EvaluationConditionDto evaluationConditionDto = null)

Evaluate

Triggers evaluation of conditions for conditional start event(s).  Internally this maps to the engines condition evaluation builder method ConditionEvaluationBuilder#evaluateStartConditions().  For more information see the [Conditional Start Events](https://docs.camunda.org/manual/7.21/reference/bpmn20/events/conditional-events/#conditional-start-event) section of the [BPMN 2.0 Implementation Reference](https://docs.camunda.org/manual/7.21/reference/bpmn20/).

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
    public class EvaluateConditionExample
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
            var apiInstance = new ConditionApi(httpClient, config, httpClientHandler);
            var evaluationConditionDto = new EvaluationConditionDto(); // EvaluationConditionDto |  (optional) 

            try
            {
                // Evaluate
                List<ProcessInstanceDto> result = apiInstance.EvaluateCondition(evaluationConditionDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConditionApi.EvaluateCondition: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EvaluateConditionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Evaluate
    ApiResponse<List<ProcessInstanceDto>> response = apiInstance.EvaluateConditionWithHttpInfo(evaluationConditionDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConditionApi.EvaluateConditionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **evaluationConditionDto** | [**EvaluationConditionDto**](EvaluationConditionDto.md) |  | [optional]  |

### Return type

[**List&lt;ProcessInstanceDto&gt;**](ProcessInstanceDto.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **400** | If both tenantId and withoutTenantId are supplied. |  -  |
| **403** | If the user is not allowed to start the process instance of the process definition, which start condition was evaluated to &#x60;true&#x60;. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

