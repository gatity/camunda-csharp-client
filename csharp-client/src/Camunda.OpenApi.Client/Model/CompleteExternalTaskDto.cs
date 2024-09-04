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
    /// CompleteExternalTaskDto
    /// </summary>
    [DataContract(Name = "CompleteExternalTaskDto")]
    public partial class CompleteExternalTaskDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CompleteExternalTaskDto" /> class.
        /// </summary>
        /// <param name="workerId">**Mandatory.** The ID of the worker who is performing the operation on the external task. If the task is already locked, must match the id of the worker who has most recently locked the task..</param>
        /// <param name="variables">A JSON object containing variable key-value pairs. Each key is a variable name and each value a JSON variable value object with the following properties:.</param>
        /// <param name="localVariables">A JSON object containing local variable key-value pairs. Local variables are set only in the scope of external task. Each key is a variable name and each value a JSON variable value object with the following properties:.</param>
        public CompleteExternalTaskDto(string workerId = default(string), Dictionary<string, VariableValueDto> variables = default(Dictionary<string, VariableValueDto>), Dictionary<string, VariableValueDto> localVariables = default(Dictionary<string, VariableValueDto>))
        {
            this.WorkerId = workerId;
            this.Variables = variables;
            this.LocalVariables = localVariables;
        }

        /// <summary>
        /// **Mandatory.** The ID of the worker who is performing the operation on the external task. If the task is already locked, must match the id of the worker who has most recently locked the task.
        /// </summary>
        /// <value>**Mandatory.** The ID of the worker who is performing the operation on the external task. If the task is already locked, must match the id of the worker who has most recently locked the task.</value>
        [DataMember(Name = "workerId", EmitDefaultValue = false)]
        public string WorkerId { get; set; }

        /// <summary>
        /// A JSON object containing variable key-value pairs. Each key is a variable name and each value a JSON variable value object with the following properties:
        /// </summary>
        /// <value>A JSON object containing variable key-value pairs. Each key is a variable name and each value a JSON variable value object with the following properties:</value>
        [DataMember(Name = "variables", EmitDefaultValue = true)]
        public Dictionary<string, VariableValueDto> Variables { get; set; }

        /// <summary>
        /// A JSON object containing local variable key-value pairs. Local variables are set only in the scope of external task. Each key is a variable name and each value a JSON variable value object with the following properties:
        /// </summary>
        /// <value>A JSON object containing local variable key-value pairs. Local variables are set only in the scope of external task. Each key is a variable name and each value a JSON variable value object with the following properties:</value>
        [DataMember(Name = "localVariables", EmitDefaultValue = true)]
        public Dictionary<string, VariableValueDto> LocalVariables { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CompleteExternalTaskDto {\n");
            sb.Append("  WorkerId: ").Append(WorkerId).Append("\n");
            sb.Append("  Variables: ").Append(Variables).Append("\n");
            sb.Append("  LocalVariables: ").Append(LocalVariables).Append("\n");
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
