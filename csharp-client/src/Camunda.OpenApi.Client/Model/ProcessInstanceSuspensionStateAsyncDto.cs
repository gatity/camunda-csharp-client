/*
 * Camunda Platform REST API
 *
 * OpenApi Spec for Camunda Platform REST API.
 *
 * The version of the OpenAPI document: 7.17.0
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
    /// ProcessInstanceSuspensionStateAsyncDto
    /// </summary>
    [DataContract(Name = "ProcessInstanceSuspensionStateAsyncDto")]
    public partial class ProcessInstanceSuspensionStateAsyncDto : IEquatable<ProcessInstanceSuspensionStateAsyncDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessInstanceSuspensionStateAsyncDto" /> class.
        /// </summary>
        /// <param name="processInstanceIds">A list of process instance ids which defines a group of process instances which will be activated or suspended by the operation..</param>
        /// <param name="processInstanceQuery">processInstanceQuery.</param>
        /// <param name="historicProcessInstanceQuery">historicProcessInstanceQuery.</param>
        /// <param name="suspended">A Boolean value which indicates whether to activate or suspend a given instance  (e.g. process instance, job, job definition, or batch). When the value is set to true,  the given instance will be suspended and when the value is set to false,  the given instance will be activated..</param>
        public ProcessInstanceSuspensionStateAsyncDto(List<string> processInstanceIds = default(List<string>), ProcessInstanceQueryDto processInstanceQuery = default(ProcessInstanceQueryDto), HistoricProcessInstanceQueryDto historicProcessInstanceQuery = default(HistoricProcessInstanceQueryDto), bool? suspended = default(bool?))
        {
            this.ProcessInstanceIds = processInstanceIds;
            this.ProcessInstanceQuery = processInstanceQuery;
            this.HistoricProcessInstanceQuery = historicProcessInstanceQuery;
            this.Suspended = suspended;
        }

        /// <summary>
        /// A list of process instance ids which defines a group of process instances which will be activated or suspended by the operation.
        /// </summary>
        /// <value>A list of process instance ids which defines a group of process instances which will be activated or suspended by the operation.</value>
        [DataMember(Name = "processInstanceIds", EmitDefaultValue = true)]
        public List<string> ProcessInstanceIds { get; set; }

        /// <summary>
        /// Gets or Sets ProcessInstanceQuery
        /// </summary>
        [DataMember(Name = "processInstanceQuery", EmitDefaultValue = false)]
        public ProcessInstanceQueryDto ProcessInstanceQuery { get; set; }

        /// <summary>
        /// Gets or Sets HistoricProcessInstanceQuery
        /// </summary>
        [DataMember(Name = "historicProcessInstanceQuery", EmitDefaultValue = false)]
        public HistoricProcessInstanceQueryDto HistoricProcessInstanceQuery { get; set; }

        /// <summary>
        /// A Boolean value which indicates whether to activate or suspend a given instance  (e.g. process instance, job, job definition, or batch). When the value is set to true,  the given instance will be suspended and when the value is set to false,  the given instance will be activated.
        /// </summary>
        /// <value>A Boolean value which indicates whether to activate or suspend a given instance  (e.g. process instance, job, job definition, or batch). When the value is set to true,  the given instance will be suspended and when the value is set to false,  the given instance will be activated.</value>
        [DataMember(Name = "suspended", EmitDefaultValue = true)]
        public bool? Suspended { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProcessInstanceSuspensionStateAsyncDto {\n");
            sb.Append("  ProcessInstanceIds: ").Append(ProcessInstanceIds).Append("\n");
            sb.Append("  ProcessInstanceQuery: ").Append(ProcessInstanceQuery).Append("\n");
            sb.Append("  HistoricProcessInstanceQuery: ").Append(HistoricProcessInstanceQuery).Append("\n");
            sb.Append("  Suspended: ").Append(Suspended).Append("\n");
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
            return this.Equals(input as ProcessInstanceSuspensionStateAsyncDto);
        }

        /// <summary>
        /// Returns true if ProcessInstanceSuspensionStateAsyncDto instances are equal
        /// </summary>
        /// <param name="input">Instance of ProcessInstanceSuspensionStateAsyncDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProcessInstanceSuspensionStateAsyncDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProcessInstanceIds == input.ProcessInstanceIds ||
                    this.ProcessInstanceIds != null &&
                    input.ProcessInstanceIds != null &&
                    this.ProcessInstanceIds.SequenceEqual(input.ProcessInstanceIds)
                ) && 
                (
                    this.ProcessInstanceQuery == input.ProcessInstanceQuery ||
                    (this.ProcessInstanceQuery != null &&
                    this.ProcessInstanceQuery.Equals(input.ProcessInstanceQuery))
                ) && 
                (
                    this.HistoricProcessInstanceQuery == input.HistoricProcessInstanceQuery ||
                    (this.HistoricProcessInstanceQuery != null &&
                    this.HistoricProcessInstanceQuery.Equals(input.HistoricProcessInstanceQuery))
                ) && 
                (
                    this.Suspended == input.Suspended ||
                    (this.Suspended != null &&
                    this.Suspended.Equals(input.Suspended))
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
                if (this.ProcessInstanceIds != null)
                    hashCode = hashCode * 59 + this.ProcessInstanceIds.GetHashCode();
                if (this.ProcessInstanceQuery != null)
                    hashCode = hashCode * 59 + this.ProcessInstanceQuery.GetHashCode();
                if (this.HistoricProcessInstanceQuery != null)
                    hashCode = hashCode * 59 + this.HistoricProcessInstanceQuery.GetHashCode();
                if (this.Suspended != null)
                    hashCode = hashCode * 59 + this.Suspended.GetHashCode();
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
