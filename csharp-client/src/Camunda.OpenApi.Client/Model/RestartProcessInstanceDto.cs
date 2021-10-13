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
    /// RestartProcessInstanceDto
    /// </summary>
    [DataContract(Name = "RestartProcessInstanceDto")]
    public partial class RestartProcessInstanceDto : IEquatable<RestartProcessInstanceDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestartProcessInstanceDto" /> class.
        /// </summary>
        /// <param name="processInstanceIds">A list of process instance ids to restart..</param>
        /// <param name="historicProcessInstanceQuery">historicProcessInstanceQuery.</param>
        /// <param name="skipCustomListeners">Skip execution listener invocation for activities that are started as part of this request..</param>
        /// <param name="skipIoMappings">Skip execution of [input/output variable mappings](https://docs.camunda.org/manual/7.16/user-guide/process-engine/variables/#input-output-variable-mapping) for activities that are started as part of this request..</param>
        /// <param name="initialVariables">Set the initial set of variables during restart. By default, the last set of variables is used..</param>
        /// <param name="withoutBusinessKey">Do not take over the business key of the historic process instance..</param>
        /// <param name="instructions">**Optional**. A JSON array of instructions that specify which activities to start the process instance at. If this property is omitted, the process instance starts at its default blank start event..</param>
        public RestartProcessInstanceDto(List<string> processInstanceIds = default(List<string>), HistoricProcessInstanceQueryDto historicProcessInstanceQuery = default(HistoricProcessInstanceQueryDto), bool? skipCustomListeners = default(bool?), bool? skipIoMappings = default(bool?), bool? initialVariables = default(bool?), bool? withoutBusinessKey = default(bool?), List<RestartProcessInstanceModificationInstructionDto> instructions = default(List<RestartProcessInstanceModificationInstructionDto>))
        {
            this.ProcessInstanceIds = processInstanceIds;
            this.HistoricProcessInstanceQuery = historicProcessInstanceQuery;
            this.SkipCustomListeners = skipCustomListeners;
            this.SkipIoMappings = skipIoMappings;
            this.InitialVariables = initialVariables;
            this.WithoutBusinessKey = withoutBusinessKey;
            this.Instructions = instructions;
        }

        /// <summary>
        /// A list of process instance ids to restart.
        /// </summary>
        /// <value>A list of process instance ids to restart.</value>
        [DataMember(Name = "processInstanceIds", EmitDefaultValue = true)]
        public List<string> ProcessInstanceIds { get; set; }

        /// <summary>
        /// Gets or Sets HistoricProcessInstanceQuery
        /// </summary>
        [DataMember(Name = "historicProcessInstanceQuery", EmitDefaultValue = false)]
        public HistoricProcessInstanceQueryDto HistoricProcessInstanceQuery { get; set; }

        /// <summary>
        /// Skip execution listener invocation for activities that are started as part of this request.
        /// </summary>
        /// <value>Skip execution listener invocation for activities that are started as part of this request.</value>
        [DataMember(Name = "skipCustomListeners", EmitDefaultValue = true)]
        public bool? SkipCustomListeners { get; set; }

        /// <summary>
        /// Skip execution of [input/output variable mappings](https://docs.camunda.org/manual/7.16/user-guide/process-engine/variables/#input-output-variable-mapping) for activities that are started as part of this request.
        /// </summary>
        /// <value>Skip execution of [input/output variable mappings](https://docs.camunda.org/manual/7.16/user-guide/process-engine/variables/#input-output-variable-mapping) for activities that are started as part of this request.</value>
        [DataMember(Name = "skipIoMappings", EmitDefaultValue = true)]
        public bool? SkipIoMappings { get; set; }

        /// <summary>
        /// Set the initial set of variables during restart. By default, the last set of variables is used.
        /// </summary>
        /// <value>Set the initial set of variables during restart. By default, the last set of variables is used.</value>
        [DataMember(Name = "initialVariables", EmitDefaultValue = true)]
        public bool? InitialVariables { get; set; }

        /// <summary>
        /// Do not take over the business key of the historic process instance.
        /// </summary>
        /// <value>Do not take over the business key of the historic process instance.</value>
        [DataMember(Name = "withoutBusinessKey", EmitDefaultValue = true)]
        public bool? WithoutBusinessKey { get; set; }

        /// <summary>
        /// **Optional**. A JSON array of instructions that specify which activities to start the process instance at. If this property is omitted, the process instance starts at its default blank start event.
        /// </summary>
        /// <value>**Optional**. A JSON array of instructions that specify which activities to start the process instance at. If this property is omitted, the process instance starts at its default blank start event.</value>
        [DataMember(Name = "instructions", EmitDefaultValue = true)]
        public List<RestartProcessInstanceModificationInstructionDto> Instructions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RestartProcessInstanceDto {\n");
            sb.Append("  ProcessInstanceIds: ").Append(ProcessInstanceIds).Append("\n");
            sb.Append("  HistoricProcessInstanceQuery: ").Append(HistoricProcessInstanceQuery).Append("\n");
            sb.Append("  SkipCustomListeners: ").Append(SkipCustomListeners).Append("\n");
            sb.Append("  SkipIoMappings: ").Append(SkipIoMappings).Append("\n");
            sb.Append("  InitialVariables: ").Append(InitialVariables).Append("\n");
            sb.Append("  WithoutBusinessKey: ").Append(WithoutBusinessKey).Append("\n");
            sb.Append("  Instructions: ").Append(Instructions).Append("\n");
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
            return this.Equals(input as RestartProcessInstanceDto);
        }

        /// <summary>
        /// Returns true if RestartProcessInstanceDto instances are equal
        /// </summary>
        /// <param name="input">Instance of RestartProcessInstanceDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestartProcessInstanceDto input)
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
                    this.HistoricProcessInstanceQuery == input.HistoricProcessInstanceQuery ||
                    (this.HistoricProcessInstanceQuery != null &&
                    this.HistoricProcessInstanceQuery.Equals(input.HistoricProcessInstanceQuery))
                ) && 
                (
                    this.SkipCustomListeners == input.SkipCustomListeners ||
                    (this.SkipCustomListeners != null &&
                    this.SkipCustomListeners.Equals(input.SkipCustomListeners))
                ) && 
                (
                    this.SkipIoMappings == input.SkipIoMappings ||
                    (this.SkipIoMappings != null &&
                    this.SkipIoMappings.Equals(input.SkipIoMappings))
                ) && 
                (
                    this.InitialVariables == input.InitialVariables ||
                    (this.InitialVariables != null &&
                    this.InitialVariables.Equals(input.InitialVariables))
                ) && 
                (
                    this.WithoutBusinessKey == input.WithoutBusinessKey ||
                    (this.WithoutBusinessKey != null &&
                    this.WithoutBusinessKey.Equals(input.WithoutBusinessKey))
                ) && 
                (
                    this.Instructions == input.Instructions ||
                    this.Instructions != null &&
                    input.Instructions != null &&
                    this.Instructions.SequenceEqual(input.Instructions)
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
                if (this.HistoricProcessInstanceQuery != null)
                    hashCode = hashCode * 59 + this.HistoricProcessInstanceQuery.GetHashCode();
                if (this.SkipCustomListeners != null)
                    hashCode = hashCode * 59 + this.SkipCustomListeners.GetHashCode();
                if (this.SkipIoMappings != null)
                    hashCode = hashCode * 59 + this.SkipIoMappings.GetHashCode();
                if (this.InitialVariables != null)
                    hashCode = hashCode * 59 + this.InitialVariables.GetHashCode();
                if (this.WithoutBusinessKey != null)
                    hashCode = hashCode * 59 + this.WithoutBusinessKey.GetHashCode();
                if (this.Instructions != null)
                    hashCode = hashCode * 59 + this.Instructions.GetHashCode();
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
