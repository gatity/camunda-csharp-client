# Camunda.OpenApi.Client.Api.TelemetryApi

All URIs are relative to *http://localhost:8080/engine-rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ConfigureTelemetry**](TelemetryApi.md#configuretelemetry) | **POST** /telemetry/configuration | Configure Telemetry |
| [**GetTelemetryConfiguration**](TelemetryApi.md#gettelemetryconfiguration) | **GET** /telemetry/configuration | Fetch Telemetry Configuration |
| [**GetTelemetryData**](TelemetryApi.md#gettelemetrydata) | **GET** /telemetry/data | Fetch Telemetry Data |

<a id="configuretelemetry"></a>
# **ConfigureTelemetry**
> void ConfigureTelemetry (TelemetryConfigurationDto telemetryConfigurationDto = null)

Configure Telemetry

Configures whether Camunda receives data collection of the process engine setup and usage.

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
    public class ConfigureTelemetryExample
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
            var apiInstance = new TelemetryApi(httpClient, config, httpClientHandler);
            var telemetryConfigurationDto = new TelemetryConfigurationDto(); // TelemetryConfigurationDto |  (optional) 

            try
            {
                // Configure Telemetry
                apiInstance.ConfigureTelemetry(telemetryConfigurationDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TelemetryApi.ConfigureTelemetry: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ConfigureTelemetryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Configure Telemetry
    apiInstance.ConfigureTelemetryWithHttpInfo(telemetryConfigurationDto);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TelemetryApi.ConfigureTelemetryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **telemetryConfigurationDto** | [**TelemetryConfigurationDto**](TelemetryConfigurationDto.md) |  | [optional]  |

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
| **401** | If the user who perform the operation is not a &lt;b&gt;camunda-admin&lt;/b&gt; user. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gettelemetryconfiguration"></a>
# **GetTelemetryConfiguration**
> TelemetryConfigurationDto GetTelemetryConfiguration ()

Fetch Telemetry Configuration

Fetches Telemetry Configuration.

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
    public class GetTelemetryConfigurationExample
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
            var apiInstance = new TelemetryApi(httpClient, config, httpClientHandler);

            try
            {
                // Fetch Telemetry Configuration
                TelemetryConfigurationDto result = apiInstance.GetTelemetryConfiguration();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TelemetryApi.GetTelemetryConfiguration: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTelemetryConfigurationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Fetch Telemetry Configuration
    ApiResponse<TelemetryConfigurationDto> response = apiInstance.GetTelemetryConfigurationWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TelemetryApi.GetTelemetryConfigurationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**TelemetryConfigurationDto**](TelemetryConfigurationDto.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **401** | If the user who perform the operation is not a &lt;b&gt;camunda-admin&lt;/b&gt; user. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gettelemetrydata"></a>
# **GetTelemetryData**
> TelemetryDataDto GetTelemetryData ()

Fetch Telemetry Data

Fetches Telemetry Data.

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
    public class GetTelemetryDataExample
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
            var apiInstance = new TelemetryApi(httpClient, config, httpClientHandler);

            try
            {
                // Fetch Telemetry Data
                TelemetryDataDto result = apiInstance.GetTelemetryData();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TelemetryApi.GetTelemetryData: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTelemetryDataWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Fetch Telemetry Data
    ApiResponse<TelemetryDataDto> response = apiInstance.GetTelemetryDataWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TelemetryApi.GetTelemetryDataWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**TelemetryDataDto**](TelemetryDataDto.md)

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

