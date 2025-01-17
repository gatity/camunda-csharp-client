/*
 * Camunda Platform REST API
 *
 * OpenApi Spec for Camunda Platform REST API.
 *
 * The version of the OpenAPI document: 7.21.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using FileParameter = Camunda.OpenApi.Client.Client.FileParameter;
using OpenAPIDateConverter = Camunda.OpenApi.Client.Client.OpenAPIDateConverter;

namespace Camunda.OpenApi.Client.Model
{
    /// <summary>
    /// CompleteTaskDto
    /// </summary>
    [DataContract(Name = "CompleteTaskDto")]
    public partial class CompleteTaskDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CompleteTaskDto" /> class.
        /// </summary>
        /// <param name="variables">A JSON object containing variable key-value pairs..</param>
        /// <param name="withVariablesInReturn">Indicates whether the response should contain the process variables or not. The default is &#x60;false&#x60; with a response code of &#x60;204&#x60;. If set to &#x60;true&#x60; the response contains the process variables and has a response code of &#x60;200&#x60;. If the task is not associated with a process instance (e.g. if it&#39;s part of a case instance) no variables will be returned. (default to false).</param>
        public CompleteTaskDto(Dictionary<string, VariableValueDto> variables = default(Dictionary<string, VariableValueDto>), bool? withVariablesInReturn = false)
        {
            this.Variables = variables;
            // use default value if no "withVariablesInReturn" provided
            this.WithVariablesInReturn = withVariablesInReturn ?? false;
        }

        /// <summary>
        /// A JSON object containing variable key-value pairs.
        /// </summary>
        /// <value>A JSON object containing variable key-value pairs.</value>
        [DataMember(Name = "variables", EmitDefaultValue = true)]
        public Dictionary<string, VariableValueDto> Variables { get; set; }

        /// <summary>
        /// Indicates whether the response should contain the process variables or not. The default is &#x60;false&#x60; with a response code of &#x60;204&#x60;. If set to &#x60;true&#x60; the response contains the process variables and has a response code of &#x60;200&#x60;. If the task is not associated with a process instance (e.g. if it&#39;s part of a case instance) no variables will be returned.
        /// </summary>
        /// <value>Indicates whether the response should contain the process variables or not. The default is &#x60;false&#x60; with a response code of &#x60;204&#x60;. If set to &#x60;true&#x60; the response contains the process variables and has a response code of &#x60;200&#x60;. If the task is not associated with a process instance (e.g. if it&#39;s part of a case instance) no variables will be returned.</value>
        [DataMember(Name = "withVariablesInReturn", EmitDefaultValue = true)]
        public bool? WithVariablesInReturn { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CompleteTaskDto {\n");
            sb.Append("  Variables: ").Append(Variables).Append("\n");
            sb.Append("  WithVariablesInReturn: ").Append(WithVariablesInReturn).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
