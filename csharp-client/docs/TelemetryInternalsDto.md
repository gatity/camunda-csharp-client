# Camunda.OpenApi.Client.Model.TelemetryInternalsDto

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Database** | [**AbstractVendorVersionInformationDto**](AbstractVendorVersionInformationDto.md) |  | [optional] 
**ApplicationServer** | [**AbstractVendorVersionInformationDto**](AbstractVendorVersionInformationDto.md) |  | [optional] 
**LicenseKey** | [**TelemetryLicenseKeyDto**](TelemetryLicenseKeyDto.md) |  | [optional] 
**CamundaIntegration** | **List&lt;string&gt;** | List of Camunda integrations used (e.g., Camunda Spring Boot Starter, Camunda Run, WildFly/JBoss subsystem, Camunda EJB). | [optional] 
**Commands** | [**Dictionary&lt;string, TelemetryCountDto&gt;**](TelemetryCountDto.md) | The count of executed commands after the last retrieved data. | [optional] 
**Metrics** | [**Dictionary&lt;string, TelemetryCountDto&gt;**](TelemetryCountDto.md) | The collected metrics are the number of root process instance executions started, the number of activity instances started or also known as flow node instances, and the number of executed decision instances and elements. | [optional] 
**Webapps** | **List&lt;string&gt;** | The webapps enabled in this installation of Camunda. | [optional] 
**Jdk** | [**AbstractVendorVersionInformationDto**](AbstractVendorVersionInformationDto.md) |  | [optional] 
**DataCollectionStartDate** | **DateTime** | The date when the engine started to collect dynamic data, such as command executions and metrics. If telemetry sending is enabled, dynamic data resets on sending the data to Camunda. Dynamic data and the date returned by this method are reset in three cases: engine startup, after engine start when sending telemetry data to Camunda is enabled via API, after sending telemetry data to Camunda (only when this was enabled) The date is in the format &lt;code&gt;YYYY-MM-DD&#39;T&#39;HH:mm:ss.SSSZ&lt;/code&gt;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

