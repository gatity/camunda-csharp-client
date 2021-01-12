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

using CamundaClient.Client;
using CamundaClient.Api;
// uncomment below to import models
//using CamundaClient.Model;

namespace CamundaClient.Test.Api
{
    /// <summary>
    ///  Class for testing TaskVariableApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class TaskVariableApiTests : IDisposable
    {
        private TaskVariableApi instance;

        public TaskVariableApiTests()
        {
            instance = new TaskVariableApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of TaskVariableApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' TaskVariableApi
            //Assert.IsType<TaskVariableApi>(instance);
        }

        /// <summary>
        /// Test DeleteTaskVariable
        /// </summary>
        [Fact]
        public void DeleteTaskVariableTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string varName = null;
            //instance.DeleteTaskVariable(id, varName);
        }

        /// <summary>
        /// Test GetTaskVariable
        /// </summary>
        [Fact]
        public void GetTaskVariableTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string varName = null;
            //bool? deserializeValue = null;
            //var response = instance.GetTaskVariable(id, varName, deserializeValue);
            //Assert.IsType<VariableValueDto>(response);
        }

        /// <summary>
        /// Test GetTaskVariableBinary
        /// </summary>
        [Fact]
        public void GetTaskVariableBinaryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string varName = null;
            //var response = instance.GetTaskVariableBinary(id, varName);
            //Assert.IsType<System.IO.Stream>(response);
        }

        /// <summary>
        /// Test GetTaskVariables
        /// </summary>
        [Fact]
        public void GetTaskVariablesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //bool? deserializeValue = null;
            //var response = instance.GetTaskVariables(id, deserializeValue);
            //Assert.IsType<Dictionary<string, VariableValueDto>>(response);
        }

        /// <summary>
        /// Test ModifyTaskVariables
        /// </summary>
        [Fact]
        public void ModifyTaskVariablesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //PatchVariablesDto patchVariablesDto = null;
            //instance.ModifyTaskVariables(id, patchVariablesDto);
        }

        /// <summary>
        /// Test PutTaskVariable
        /// </summary>
        [Fact]
        public void PutTaskVariableTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string varName = null;
            //VariableValueDto variableValueDto = null;
            //instance.PutTaskVariable(id, varName, variableValueDto);
        }

        /// <summary>
        /// Test SetBinaryTaskVariable
        /// </summary>
        [Fact]
        public void SetBinaryTaskVariableTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string varName = null;
            //System.IO.Stream data = null;
            //string valueType = null;
            //instance.SetBinaryTaskVariable(id, varName, data, valueType);
        }
    }
}
