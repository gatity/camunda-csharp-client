# Camunda.OpenApi.Client.Api.VersionApi

All URIs are relative to *http://localhost:8080/engine-rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetRestAPIVersion**](VersionApi.md#getrestapiversion) | **GET** /version | Get Rest API version |

<a id="getrestapiversion"></a>
# **GetRestAPIVersion**
> VersionDto GetRestAPIVersion ()

Get Rest API version

Retrieves the version of the Rest API.

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
    public class GetRestAPIVersionExample
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
            var apiInstance = new VersionApi(httpClient, config, httpClientHandler);

            try
            {
                // Get Rest API version
                VersionDto result = apiInstance.GetRestAPIVersion();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VersionApi.GetRestAPIVersion: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRestAPIVersionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Rest API version
    ApiResponse<VersionDto> response = apiInstance.GetRestAPIVersionWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VersionApi.GetRestAPIVersionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**VersionDto**](VersionDto.md)

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

