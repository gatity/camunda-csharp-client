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
    ///  Class for testing IncidentApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class IncidentApiTests : IDisposable
    {
        private IncidentApi instance;

        public IncidentApiTests()
        {
            instance = new IncidentApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of IncidentApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' IncidentApi
            //Assert.IsType<IncidentApi>(instance);
        }

        /// <summary>
        /// Test GetIncident
        /// </summary>
        [Fact]
        public void GetIncidentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.GetIncident(id);
            //Assert.IsType<IncidentDto>(response);
        }

        /// <summary>
        /// Test GetIncidents
        /// </summary>
        [Fact]
        public void GetIncidentsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string incidentId = null;
            //string incidentType = null;
            //string incidentMessage = null;
            //string incidentMessageLike = null;
            //string processDefinitionId = null;
            //string processDefinitionKeyIn = null;
            //string processInstanceId = null;
            //string executionId = null;
            //DateTime? incidentTimestampBefore = null;
            //DateTime? incidentTimestampAfter = null;
            //string activityId = null;
            //string failedActivityId = null;
            //string causeIncidentId = null;
            //string rootCauseIncidentId = null;
            //string configuration = null;
            //string tenantIdIn = null;
            //string jobDefinitionIdIn = null;
            //string sortBy = null;
            //string sortOrder = null;
            //var response = instance.GetIncidents(incidentId, incidentType, incidentMessage, incidentMessageLike, processDefinitionId, processDefinitionKeyIn, processInstanceId, executionId, incidentTimestampBefore, incidentTimestampAfter, activityId, failedActivityId, causeIncidentId, rootCauseIncidentId, configuration, tenantIdIn, jobDefinitionIdIn, sortBy, sortOrder);
            //Assert.IsType<List<IncidentDto>>(response);
        }

        /// <summary>
        /// Test GetIncidentsCount
        /// </summary>
        [Fact]
        public void GetIncidentsCountTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string incidentId = null;
            //string incidentType = null;
            //string incidentMessage = null;
            //string incidentMessageLike = null;
            //string processDefinitionId = null;
            //string processDefinitionKeyIn = null;
            //string processInstanceId = null;
            //string executionId = null;
            //DateTime? incidentTimestampBefore = null;
            //DateTime? incidentTimestampAfter = null;
            //string activityId = null;
            //string failedActivityId = null;
            //string causeIncidentId = null;
            //string rootCauseIncidentId = null;
            //string configuration = null;
            //string tenantIdIn = null;
            //string jobDefinitionIdIn = null;
            //var response = instance.GetIncidentsCount(incidentId, incidentType, incidentMessage, incidentMessageLike, processDefinitionId, processDefinitionKeyIn, processInstanceId, executionId, incidentTimestampBefore, incidentTimestampAfter, activityId, failedActivityId, causeIncidentId, rootCauseIncidentId, configuration, tenantIdIn, jobDefinitionIdIn);
            //Assert.IsType<List<CountResultDto>>(response);
        }

        /// <summary>
        /// Test ResolveIncident
        /// </summary>
        [Fact]
        public void ResolveIncidentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.ResolveIncident(id);
        }
    }
}