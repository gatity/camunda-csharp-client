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
    /// TaskEscalationDto
    /// </summary>
    [DataContract(Name = "TaskEscalationDto")]
    public partial class TaskEscalationDto : IEquatable<TaskEscalationDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskEscalationDto" /> class.
        /// </summary>
        /// <param name="escalationCode">An escalation code that indicates the predefined escalation. It is used to identify the BPMN escalation handler..</param>
        /// <param name="variables">A JSON object containing variable key-value pairs..</param>
        public TaskEscalationDto(string escalationCode = default(string), Dictionary<string, VariableValueDto> variables = default(Dictionary<string, VariableValueDto>))
        {
            this.EscalationCode = escalationCode;
            this.Variables = variables;
        }

        /// <summary>
        /// An escalation code that indicates the predefined escalation. It is used to identify the BPMN escalation handler.
        /// </summary>
        /// <value>An escalation code that indicates the predefined escalation. It is used to identify the BPMN escalation handler.</value>
        [DataMember(Name = "escalationCode", EmitDefaultValue = true)]
        public string EscalationCode { get; set; }

        /// <summary>
        /// A JSON object containing variable key-value pairs.
        /// </summary>
        /// <value>A JSON object containing variable key-value pairs.</value>
        [DataMember(Name = "variables", EmitDefaultValue = true)]
        public Dictionary<string, VariableValueDto> Variables { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskEscalationDto {\n");
            sb.Append("  EscalationCode: ").Append(EscalationCode).Append("\n");
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
            return this.Equals(input as TaskEscalationDto);
        }

        /// <summary>
        /// Returns true if TaskEscalationDto instances are equal
        /// </summary>
        /// <param name="input">Instance of TaskEscalationDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaskEscalationDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EscalationCode == input.EscalationCode ||
                    (this.EscalationCode != null &&
                    this.EscalationCode.Equals(input.EscalationCode))
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
                if (this.EscalationCode != null)
                    hashCode = hashCode * 59 + this.EscalationCode.GetHashCode();
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
