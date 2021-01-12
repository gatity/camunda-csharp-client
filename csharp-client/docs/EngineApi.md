# CamundaClient.Api.EngineApi

All URIs are relative to *http://localhost:8080/engine-rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetProcessEngineNames**](EngineApi.md#getprocessenginenames) | **GET** /engine | 


<a name="getprocessenginenames"></a>
# **GetProcessEngineNames**
> List&lt;ProcessEngineDto&gt; GetProcessEngineNames ()



Retrieves the names of all process engines available on your platform. **Note**: You cannot prepend `/engine/{name}` to this method.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CamundaClient.Api;
using CamundaClient.Client;
using CamundaClient.Model;

namespace Example
{
    public class GetProcessEngineNamesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/engine-rest";
            var apiInstance = new EngineApi(config);

            try
            {
                List<ProcessEngineDto> result = apiInstance.GetProcessEngineNames();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EngineApi.GetProcessEngineNames: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List&lt;ProcessEngineDto&gt;**](ProcessEngineDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
