/*
 * Camunda BPM REST API
 *
 * OpenApi Spec for Camunda BPM REST API.
 *
 * The version of the OpenAPI document: 7.14.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Camunda.OpenApi.Client.Client;
using Camunda.OpenApi.Client.Api;
// uncomment below to import models
//using Camunda.OpenApi.Client.Model;

namespace Camunda.OpenApi.Client.Test.Api
{
    /// <summary>
    ///  Class for testing ProcessDefinitionApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ProcessDefinitionApiTests : IDisposable
    {
        private ProcessDefinitionApi instance;

        public ProcessDefinitionApiTests()
        {
            instance = new ProcessDefinitionApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ProcessDefinitionApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ProcessDefinitionApi
            //Assert.IsType<ProcessDefinitionApi>(instance);
        }

        /// <summary>
        /// Test DeleteProcessDefinition
        /// </summary>
        [Fact]
        public void DeleteProcessDefinitionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //bool? cascade = null;
            //bool? skipCustomListeners = null;
            //bool? skipIoMappings = null;
            //instance.DeleteProcessDefinition(id, cascade, skipCustomListeners, skipIoMappings);
        }

        /// <summary>
        /// Test DeleteProcessDefinitionsByKey
        /// </summary>
        [Fact]
        public void DeleteProcessDefinitionsByKeyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string key = null;
            //bool? cascade = null;
            //bool? skipCustomListeners = null;
            //bool? skipIoMappings = null;
            //instance.DeleteProcessDefinitionsByKey(key, cascade, skipCustomListeners, skipIoMappings);
        }

        /// <summary>
        /// Test DeleteProcessDefinitionsByKeyAndTenantId
        /// </summary>
        [Fact]
        public void DeleteProcessDefinitionsByKeyAndTenantIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string key = null;
            //string tenantId = null;
            //bool? cascade = null;
            //bool? skipCustomListeners = null;
            //bool? skipIoMappings = null;
            //instance.DeleteProcessDefinitionsByKeyAndTenantId(key, tenantId, cascade, skipCustomListeners, skipIoMappings);
        }

        /// <summary>
        /// Test GetActivityStatistics
        /// </summary>
        [Fact]
        public void GetActivityStatisticsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //bool? failedJobs = null;
            //bool? incidents = null;
            //string incidentsForType = null;
            //var response = instance.GetActivityStatistics(id, failedJobs, incidents, incidentsForType);
            //Assert.IsType<List<ActivityStatisticsResultDto>>(response);
        }

        /// <summary>
        /// Test GetActivityStatisticsByProcessDefinitionKey
        /// </summary>
        [Fact]
        public void GetActivityStatisticsByProcessDefinitionKeyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string key = null;
            //bool? failedJobs = null;
            //bool? incidents = null;
            //string incidentsForType = null;
            //var response = instance.GetActivityStatisticsByProcessDefinitionKey(key, failedJobs, incidents, incidentsForType);
            //Assert.IsType<List<ActivityStatisticsResultDto>>(response);
        }

        /// <summary>
        /// Test GetActivityStatisticsByProcessDefinitionKeyAndTenantId
        /// </summary>
        [Fact]
        public void GetActivityStatisticsByProcessDefinitionKeyAndTenantIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string key = null;
            //string tenantId = null;
            //bool? failedJobs = null;
            //bool? incidents = null;
            //string incidentsForType = null;
            //var response = instance.GetActivityStatisticsByProcessDefinitionKeyAndTenantId(key, tenantId, failedJobs, incidents, incidentsForType);
            //Assert.IsType<List<ActivityStatisticsResultDto>>(response);
        }

        /// <summary>
        /// Test GetDeployedStartForm
        /// </summary>
        [Fact]
        public void GetDeployedStartFormTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.GetDeployedStartForm(id);
            //Assert.IsType<System.IO.Stream>(response);
        }

        /// <summary>
        /// Test GetDeployedStartFormByKey
        /// </summary>
        [Fact]
        public void GetDeployedStartFormByKeyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string key = null;
            //var response = instance.GetDeployedStartFormByKey(key);
            //Assert.IsType<System.IO.Stream>(response);
        }

        /// <summary>
        /// Test GetDeployedStartFormByKeyAndTenantId
        /// </summary>
        [Fact]
        public void GetDeployedStartFormByKeyAndTenantIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string key = null;
            //string tenantId = null;
            //var response = instance.GetDeployedStartFormByKeyAndTenantId(key, tenantId);
            //Assert.IsType<System.IO.Stream>(response);
        }

        /// <summary>
        /// Test GetLatestProcessDefinitionByTenantId
        /// </summary>
        [Fact]
        public void GetLatestProcessDefinitionByTenantIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string key = null;
            //string tenantId = null;
            //var response = instance.GetLatestProcessDefinitionByTenantId(key, tenantId);
            //Assert.IsType<ProcessDefinitionDto>(response);
        }

        /// <summary>
        /// Test GetProcessDefinition
        /// </summary>
        [Fact]
        public void GetProcessDefinitionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.GetProcessDefinition(id);
            //Assert.IsType<ProcessDefinitionDto>(response);
        }

        /// <summary>
        /// Test GetProcessDefinitionBpmn20Xml
        /// </summary>
        [Fact]
        public void GetProcessDefinitionBpmn20XmlTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.GetProcessDefinitionBpmn20Xml(id);
            //Assert.IsType<ProcessDefinitionDiagramDto>(response);
        }

        /// <summary>
        /// Test GetProcessDefinitionBpmn20XmlByKey
        /// </summary>
        [Fact]
        public void GetProcessDefinitionBpmn20XmlByKeyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string key = null;
            //var response = instance.GetProcessDefinitionBpmn20XmlByKey(key);
            //Assert.IsType<ProcessDefinitionDiagramDto>(response);
        }

        /// <summary>
        /// Test GetProcessDefinitionBpmn20XmlByKeyAndTenantId
        /// </summary>
        [Fact]
        public void GetProcessDefinitionBpmn20XmlByKeyAndTenantIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string key = null;
            //string tenantId = null;
            //var response = instance.GetProcessDefinitionBpmn20XmlByKeyAndTenantId(key, tenantId);
            //Assert.IsType<ProcessDefinitionDiagramDto>(response);
        }

        /// <summary>
        /// Test GetProcessDefinitionByKey
        /// </summary>
        [Fact]
        public void GetProcessDefinitionByKeyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string key = null;
            //var response = instance.GetProcessDefinitionByKey(key);
            //Assert.IsType<ProcessDefinitionDto>(response);
        }

        /// <summary>
        /// Test GetProcessDefinitionDiagram
        /// </summary>
        [Fact]
        public void GetProcessDefinitionDiagramTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.GetProcessDefinitionDiagram(id);
            //Assert.IsType<System.IO.Stream>(response);
        }

        /// <summary>
        /// Test GetProcessDefinitionDiagramByKey
        /// </summary>
        [Fact]
        public void GetProcessDefinitionDiagramByKeyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string key = null;
            //var response = instance.GetProcessDefinitionDiagramByKey(key);
            //Assert.IsType<System.IO.Stream>(response);
        }

        /// <summary>
        /// Test GetProcessDefinitionDiagramByKeyAndTenantId
        /// </summary>
        [Fact]
        public void GetProcessDefinitionDiagramByKeyAndTenantIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string key = null;
            //string tenantId = null;
            //var response = instance.GetProcessDefinitionDiagramByKeyAndTenantId(key, tenantId);
            //Assert.IsType<System.IO.Stream>(response);
        }

        /// <summary>
        /// Test GetProcessDefinitionStatistics
        /// </summary>
        [Fact]
        public void GetProcessDefinitionStatisticsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? failedJobs = null;
            //bool? incidents = null;
            //string incidentsForType = null;
            //bool? rootIncidents = null;
            //var response = instance.GetProcessDefinitionStatistics(failedJobs, incidents, incidentsForType, rootIncidents);
            //Assert.IsType<List<ProcessDefinitionStatisticsResultDto>>(response);
        }

        /// <summary>
        /// Test GetProcessDefinitions
        /// </summary>
        [Fact]
        public void GetProcessDefinitionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string processDefinitionId = null;
            //string processDefinitionIdIn = null;
            //string name = null;
            //string nameLike = null;
            //string deploymentId = null;
            //DateTime? deployedAfter = null;
            //DateTime? deployedAt = null;
            //string key = null;
            //string keysIn = null;
            //string keyLike = null;
            //string category = null;
            //string categoryLike = null;
            //int? version = null;
            //bool? latestVersion = null;
            //string resourceName = null;
            //string resourceNameLike = null;
            //string startableBy = null;
            //bool? active = null;
            //bool? suspended = null;
            //string incidentId = null;
            //string incidentType = null;
            //string incidentMessage = null;
            //string incidentMessageLike = null;
            //string tenantIdIn = null;
            //bool? withoutTenantId = null;
            //bool? includeProcessDefinitionsWithoutTenantId = null;
            //string versionTag = null;
            //string versionTagLike = null;
            //bool? withoutVersionTag = null;
            //bool? startableInTasklist = null;
            //bool? notStartableInTasklist = null;
            //bool? startablePermissionCheck = null;
            //string sortBy = null;
            //string sortOrder = null;
            //int? firstResult = null;
            //int? maxResults = null;
            //var response = instance.GetProcessDefinitions(processDefinitionId, processDefinitionIdIn, name, nameLike, deploymentId, deployedAfter, deployedAt, key, keysIn, keyLike, category, categoryLike, version, latestVersion, resourceName, resourceNameLike, startableBy, active, suspended, incidentId, incidentType, incidentMessage, incidentMessageLike, tenantIdIn, withoutTenantId, includeProcessDefinitionsWithoutTenantId, versionTag, versionTagLike, withoutVersionTag, startableInTasklist, notStartableInTasklist, startablePermissionCheck, sortBy, sortOrder, firstResult, maxResults);
            //Assert.IsType<List<ProcessDefinitionDto>>(response);
        }

        /// <summary>
        /// Test GetProcessDefinitionsCount
        /// </summary>
        [Fact]
        public void GetProcessDefinitionsCountTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string processDefinitionId = null;
            //string processDefinitionIdIn = null;
            //string name = null;
            //string nameLike = null;
            //string deploymentId = null;
            //DateTime? deployedAfter = null;
            //DateTime? deployedAt = null;
            //string key = null;
            //string keysIn = null;
            //string keyLike = null;
            //string category = null;
            //string categoryLike = null;
            //int? version = null;
            //bool? latestVersion = null;
            //string resourceName = null;
            //string resourceNameLike = null;
            //string startableBy = null;
            //bool? active = null;
            //bool? suspended = null;
            //string incidentId = null;
            //string incidentType = null;
            //string incidentMessage = null;
            //string incidentMessageLike = null;
            //string tenantIdIn = null;
            //bool? withoutTenantId = null;
            //bool? includeProcessDefinitionsWithoutTenantId = null;
            //string versionTag = null;
            //string versionTagLike = null;
            //bool? withoutVersionTag = null;
            //bool? startableInTasklist = null;
            //bool? notStartableInTasklist = null;
            //bool? startablePermissionCheck = null;
            //var response = instance.GetProcessDefinitionsCount(processDefinitionId, processDefinitionIdIn, name, nameLike, deploymentId, deployedAfter, deployedAt, key, keysIn, keyLike, category, categoryLike, version, latestVersion, resourceName, resourceNameLike, startableBy, active, suspended, incidentId, incidentType, incidentMessage, incidentMessageLike, tenantIdIn, withoutTenantId, includeProcessDefinitionsWithoutTenantId, versionTag, versionTagLike, withoutVersionTag, startableInTasklist, notStartableInTasklist, startablePermissionCheck);
            //Assert.IsType<CountResultDto>(response);
        }

        /// <summary>
        /// Test GetRenderedStartForm
        /// </summary>
        [Fact]
        public void GetRenderedStartFormTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.GetRenderedStartForm(id);
            //Assert.IsType<System.IO.Stream>(response);
        }

        /// <summary>
        /// Test GetRenderedStartFormByKey
        /// </summary>
        [Fact]
        public void GetRenderedStartFormByKeyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string key = null;
            //var response = instance.GetRenderedStartFormByKey(key);
            //Assert.IsType<System.IO.Stream>(response);
        }

        /// <summary>
        /// Test GetRenderedStartFormByKeyAndTenantId
        /// </summary>
        [Fact]
        public void GetRenderedStartFormByKeyAndTenantIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string key = null;
            //string tenantId = null;
            //var response = instance.GetRenderedStartFormByKeyAndTenantId(key, tenantId);
            //Assert.IsType<System.IO.Stream>(response);
        }

        /// <summary>
        /// Test GetStartForm
        /// </summary>
        [Fact]
        public void GetStartFormTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.GetStartForm(id);
            //Assert.IsType<FormDto>(response);
        }

        /// <summary>
        /// Test GetStartFormByKey
        /// </summary>
        [Fact]
        public void GetStartFormByKeyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string key = null;
            //var response = instance.GetStartFormByKey(key);
            //Assert.IsType<FormDto>(response);
        }

        /// <summary>
        /// Test GetStartFormByKeyAndTenantId
        /// </summary>
        [Fact]
        public void GetStartFormByKeyAndTenantIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string key = null;
            //string tenantId = null;
            //var response = instance.GetStartFormByKeyAndTenantId(key, tenantId);
            //Assert.IsType<FormDto>(response);
        }

        /// <summary>
        /// Test GetStartFormVariables
        /// </summary>
        [Fact]
        public void GetStartFormVariablesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string variableNames = null;
            //bool? deserializeValues = null;
            //var response = instance.GetStartFormVariables(id, variableNames, deserializeValues);
            //Assert.IsType<Dictionary<string, VariableValueDto>>(response);
        }

        /// <summary>
        /// Test GetStartFormVariablesByKey
        /// </summary>
        [Fact]
        public void GetStartFormVariablesByKeyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string key = null;
            //string variableNames = null;
            //bool? deserializeValues = null;
            //var response = instance.GetStartFormVariablesByKey(key, variableNames, deserializeValues);
            //Assert.IsType<Dictionary<string, VariableValueDto>>(response);
        }

        /// <summary>
        /// Test GetStartFormVariablesByKeyAndTenantId
        /// </summary>
        [Fact]
        public void GetStartFormVariablesByKeyAndTenantIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string key = null;
            //string tenantId = null;
            //string variableNames = null;
            //bool? deserializeValues = null;
            //var response = instance.GetStartFormVariablesByKeyAndTenantId(key, tenantId, variableNames, deserializeValues);
            //Assert.IsType<Dictionary<string, VariableValueDto>>(response);
        }

        /// <summary>
        /// Test RestartProcessInstance
        /// </summary>
        [Fact]
        public void RestartProcessInstanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //RestartProcessInstanceDto restartProcessInstanceDto = null;
            //instance.RestartProcessInstance(id, restartProcessInstanceDto);
        }

        /// <summary>
        /// Test RestartProcessInstanceAsyncOperation
        /// </summary>
        [Fact]
        public void RestartProcessInstanceAsyncOperationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //RestartProcessInstanceDto restartProcessInstanceDto = null;
            //var response = instance.RestartProcessInstanceAsyncOperation(id, restartProcessInstanceDto);
            //Assert.IsType<BatchDto>(response);
        }

        /// <summary>
        /// Test StartProcessInstance
        /// </summary>
        [Fact]
        public void StartProcessInstanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //StartProcessInstanceDto startProcessInstanceDto = null;
            //var response = instance.StartProcessInstance(id, startProcessInstanceDto);
            //Assert.IsType<ProcessInstanceWithVariablesDto>(response);
        }

        /// <summary>
        /// Test StartProcessInstanceByKey
        /// </summary>
        [Fact]
        public void StartProcessInstanceByKeyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string key = null;
            //StartProcessInstanceDto startProcessInstanceDto = null;
            //var response = instance.StartProcessInstanceByKey(key, startProcessInstanceDto);
            //Assert.IsType<ProcessInstanceWithVariablesDto>(response);
        }

        /// <summary>
        /// Test StartProcessInstanceByKeyAndTenantId
        /// </summary>
        [Fact]
        public void StartProcessInstanceByKeyAndTenantIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string key = null;
            //string tenantId = null;
            //StartProcessInstanceDto startProcessInstanceDto = null;
            //var response = instance.StartProcessInstanceByKeyAndTenantId(key, tenantId, startProcessInstanceDto);
            //Assert.IsType<ProcessInstanceWithVariablesDto>(response);
        }

        /// <summary>
        /// Test SubmitForm
        /// </summary>
        [Fact]
        public void SubmitFormTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //StartProcessInstanceFormDto startProcessInstanceFormDto = null;
            //var response = instance.SubmitForm(id, startProcessInstanceFormDto);
            //Assert.IsType<ProcessInstanceDto>(response);
        }

        /// <summary>
        /// Test SubmitFormByKey
        /// </summary>
        [Fact]
        public void SubmitFormByKeyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string key = null;
            //StartProcessInstanceFormDto startProcessInstanceFormDto = null;
            //var response = instance.SubmitFormByKey(key, startProcessInstanceFormDto);
            //Assert.IsType<ProcessInstanceDto>(response);
        }

        /// <summary>
        /// Test SubmitFormByKeyAndTenantId
        /// </summary>
        [Fact]
        public void SubmitFormByKeyAndTenantIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string key = null;
            //string tenantId = null;
            //StartProcessInstanceFormDto startProcessInstanceFormDto = null;
            //var response = instance.SubmitFormByKeyAndTenantId(key, tenantId, startProcessInstanceFormDto);
            //Assert.IsType<ProcessInstanceDto>(response);
        }

        /// <summary>
        /// Test UpdateHistoryTimeToLiveByProcessDefinitionId
        /// </summary>
        [Fact]
        public void UpdateHistoryTimeToLiveByProcessDefinitionIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //HistoryTimeToLiveDto historyTimeToLiveDto = null;
            //instance.UpdateHistoryTimeToLiveByProcessDefinitionId(id, historyTimeToLiveDto);
        }

        /// <summary>
        /// Test UpdateHistoryTimeToLiveByProcessDefinitionKey
        /// </summary>
        [Fact]
        public void UpdateHistoryTimeToLiveByProcessDefinitionKeyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string key = null;
            //HistoryTimeToLiveDto historyTimeToLiveDto = null;
            //instance.UpdateHistoryTimeToLiveByProcessDefinitionKey(key, historyTimeToLiveDto);
        }

        /// <summary>
        /// Test UpdateHistoryTimeToLiveByProcessDefinitionKeyAndTenantId
        /// </summary>
        [Fact]
        public void UpdateHistoryTimeToLiveByProcessDefinitionKeyAndTenantIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string key = null;
            //string tenantId = null;
            //HistoryTimeToLiveDto historyTimeToLiveDto = null;
            //instance.UpdateHistoryTimeToLiveByProcessDefinitionKeyAndTenantId(key, tenantId, historyTimeToLiveDto);
        }

        /// <summary>
        /// Test UpdateProcessDefinitionSuspensionState
        /// </summary>
        [Fact]
        public void UpdateProcessDefinitionSuspensionStateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ProcessDefinitionSuspensionStateDto processDefinitionSuspensionStateDto = null;
            //instance.UpdateProcessDefinitionSuspensionState(processDefinitionSuspensionStateDto);
        }

        /// <summary>
        /// Test UpdateProcessDefinitionSuspensionStateById
        /// </summary>
        [Fact]
        public void UpdateProcessDefinitionSuspensionStateByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //ProcessDefinitionSuspensionStateDto processDefinitionSuspensionStateDto = null;
            //instance.UpdateProcessDefinitionSuspensionStateById(id, processDefinitionSuspensionStateDto);
        }

        /// <summary>
        /// Test UpdateProcessDefinitionSuspensionStateByKey
        /// </summary>
        [Fact]
        public void UpdateProcessDefinitionSuspensionStateByKeyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string key = null;
            //ProcessDefinitionSuspensionStateDto processDefinitionSuspensionStateDto = null;
            //instance.UpdateProcessDefinitionSuspensionStateByKey(key, processDefinitionSuspensionStateDto);
        }

        /// <summary>
        /// Test UpdateProcessDefinitionSuspensionStateByKeyAndTenantId
        /// </summary>
        [Fact]
        public void UpdateProcessDefinitionSuspensionStateByKeyAndTenantIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string key = null;
            //string tenantId = null;
            //ProcessDefinitionSuspensionStateDto processDefinitionSuspensionStateDto = null;
            //instance.UpdateProcessDefinitionSuspensionStateByKeyAndTenantId(key, tenantId, processDefinitionSuspensionStateDto);
        }
    }
}