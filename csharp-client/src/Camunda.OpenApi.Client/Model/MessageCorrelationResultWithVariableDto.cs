/*
 * Camunda Platform REST API
 *
 * OpenApi Spec for Camunda Platform REST API.
 *
 * The version of the OpenAPI document: 7.16.0
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
using OpenAPIDateConverter = Camunda.OpenApi.Client.Client.OpenAPIDateConverter;

namespace Camunda.OpenApi.Client.Model
{
    /// <summary>
    /// The &#x60;processInstance&#x60; property only has a value if the resultType is set to &#x60;ProcessDefinition&#x60;. The processInstance with the properties as described in the [get single instance](https://docs.camunda.org/manual/7.16/reference/rest/process-instance/get/) method.  The &#x60;execution&#x60; property only has a value if the resultType is set to &#x60;Execution&#x60;. The execution with the properties as described in the [get single execution](https://docs.camunda.org/manual/7.16/reference/rest/execution/get/) method.
    /// </summary>
    [DataContract(Name = "MessageCorrelationResultWithVariableDto")]
    public partial class MessageCorrelationResultWithVariableDto : IEquatable<MessageCorrelationResultWithVariableDto>, IValidatableObject
    {
        /// <summary>
        /// Indicates if the message was correlated to a message start event or an  intermediate message catching event. In the first case, the resultType is  &#x60;ProcessDefinition&#x60; and otherwise &#x60;Execution&#x60;.
        /// </summary>
        /// <value>Indicates if the message was correlated to a message start event or an  intermediate message catching event. In the first case, the resultType is  &#x60;ProcessDefinition&#x60; and otherwise &#x60;Execution&#x60;.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ResultTypeEnum
        {
            /// <summary>
            /// Enum Execution for value: Execution
            /// </summary>
            [EnumMember(Value = "Execution")]
            Execution = 1,

            /// <summary>
            /// Enum ProcessDefinition for value: ProcessDefinition
            /// </summary>
            [EnumMember(Value = "ProcessDefinition")]
            ProcessDefinition = 2

        }

        /// <summary>
        /// Indicates if the message was correlated to a message start event or an  intermediate message catching event. In the first case, the resultType is  &#x60;ProcessDefinition&#x60; and otherwise &#x60;Execution&#x60;.
        /// </summary>
        /// <value>Indicates if the message was correlated to a message start event or an  intermediate message catching event. In the first case, the resultType is  &#x60;ProcessDefinition&#x60; and otherwise &#x60;Execution&#x60;.</value>
        [DataMember(Name = "resultType", EmitDefaultValue = true)]
        public ResultTypeEnum? ResultType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageCorrelationResultWithVariableDto" /> class.
        /// </summary>
        /// <param name="resultType">Indicates if the message was correlated to a message start event or an  intermediate message catching event. In the first case, the resultType is  &#x60;ProcessDefinition&#x60; and otherwise &#x60;Execution&#x60;..</param>
        /// <param name="processInstance">processInstance.</param>
        /// <param name="execution">execution.</param>
        /// <param name="variables">This property is returned if the &#x60;variablesInResultEnabled&#x60; is set to &#x60;true&#x60;. Contains a list of the process variables. .</param>
        public MessageCorrelationResultWithVariableDto(ResultTypeEnum? resultType = default(ResultTypeEnum?), ProcessInstanceDto processInstance = default(ProcessInstanceDto), ExecutionDto execution = default(ExecutionDto), Dictionary<string, VariableValueDto> variables = default(Dictionary<string, VariableValueDto>))
        {
            this.ResultType = resultType;
            this.ProcessInstance = processInstance;
            this.Execution = execution;
            this.Variables = variables;
        }

        /// <summary>
        /// Gets or Sets ProcessInstance
        /// </summary>
        [DataMember(Name = "processInstance", EmitDefaultValue = false)]
        public ProcessInstanceDto ProcessInstance { get; set; }

        /// <summary>
        /// Gets or Sets Execution
        /// </summary>
        [DataMember(Name = "execution", EmitDefaultValue = false)]
        public ExecutionDto Execution { get; set; }

        /// <summary>
        /// This property is returned if the &#x60;variablesInResultEnabled&#x60; is set to &#x60;true&#x60;. Contains a list of the process variables. 
        /// </summary>
        /// <value>This property is returned if the &#x60;variablesInResultEnabled&#x60; is set to &#x60;true&#x60;. Contains a list of the process variables. </value>
        [DataMember(Name = "variables", EmitDefaultValue = true)]
        public Dictionary<string, VariableValueDto> Variables { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MessageCorrelationResultWithVariableDto {\n");
            sb.Append("  ResultType: ").Append(ResultType).Append("\n");
            sb.Append("  ProcessInstance: ").Append(ProcessInstance).Append("\n");
            sb.Append("  Execution: ").Append(Execution).Append("\n");
            sb.Append("  Variables: ").Append(Variables).Append("\n");
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
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as MessageCorrelationResultWithVariableDto);
        }

        /// <summary>
        /// Returns true if MessageCorrelationResultWithVariableDto instances are equal
        /// </summary>
        /// <param name="input">Instance of MessageCorrelationResultWithVariableDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MessageCorrelationResultWithVariableDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ResultType == input.ResultType ||
                    this.ResultType.Equals(input.ResultType)
                ) && 
                (
                    this.ProcessInstance == input.ProcessInstance ||
                    (this.ProcessInstance != null &&
                    this.ProcessInstance.Equals(input.ProcessInstance))
                ) && 
                (
                    this.Execution == input.Execution ||
                    (this.Execution != null &&
                    this.Execution.Equals(input.Execution))
                ) && 
                (
                    this.Variables == input.Variables ||
                    this.Variables != null &&
                    input.Variables != null &&
                    this.Variables.SequenceEqual(input.Variables)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                hashCode = hashCode * 59 + this.ResultType.GetHashCode();
                if (this.ProcessInstance != null)
                    hashCode = hashCode * 59 + this.ProcessInstance.GetHashCode();
                if (this.Execution != null)
                    hashCode = hashCode * 59 + this.Execution.GetHashCode();
                if (this.Variables != null)
                    hashCode = hashCode * 59 + this.Variables.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
