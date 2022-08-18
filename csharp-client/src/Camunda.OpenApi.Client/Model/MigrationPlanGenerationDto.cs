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
    /// MigrationPlanGenerationDto
    /// </summary>
    [DataContract(Name = "MigrationPlanGenerationDto")]
    public partial class MigrationPlanGenerationDto : IEquatable<MigrationPlanGenerationDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MigrationPlanGenerationDto" /> class.
        /// </summary>
        /// <param name="sourceProcessDefinitionId">The id of the source process definition for the migration..</param>
        /// <param name="targetProcessDefinitionId">The id of the target process definition for the migration..</param>
        /// <param name="updateEventTriggers">A boolean flag indicating whether instructions between events should be configured to update the event triggers..</param>
        /// <param name="variables">A map of variables which will be set into the process instances&#39; scope. Each key is a variable name and each value a JSON variable value object..</param>
        public MigrationPlanGenerationDto(string sourceProcessDefinitionId = default(string), string targetProcessDefinitionId = default(string), bool? updateEventTriggers = default(bool?), Dictionary<string, VariableValueDto> variables = default(Dictionary<string, VariableValueDto>))
        {
            this.SourceProcessDefinitionId = sourceProcessDefinitionId;
            this.TargetProcessDefinitionId = targetProcessDefinitionId;
            this.UpdateEventTriggers = updateEventTriggers;
            this.Variables = variables;
        }

        /// <summary>
        /// The id of the source process definition for the migration.
        /// </summary>
        /// <value>The id of the source process definition for the migration.</value>
        [DataMember(Name = "sourceProcessDefinitionId", EmitDefaultValue = true)]
        public string SourceProcessDefinitionId { get; set; }

        /// <summary>
        /// The id of the target process definition for the migration.
        /// </summary>
        /// <value>The id of the target process definition for the migration.</value>
        [DataMember(Name = "targetProcessDefinitionId", EmitDefaultValue = true)]
        public string TargetProcessDefinitionId { get; set; }

        /// <summary>
        /// A boolean flag indicating whether instructions between events should be configured to update the event triggers.
        /// </summary>
        /// <value>A boolean flag indicating whether instructions between events should be configured to update the event triggers.</value>
        [DataMember(Name = "updateEventTriggers", EmitDefaultValue = true)]
        public bool? UpdateEventTriggers { get; set; }

        /// <summary>
        /// A map of variables which will be set into the process instances&#39; scope. Each key is a variable name and each value a JSON variable value object.
        /// </summary>
        /// <value>A map of variables which will be set into the process instances&#39; scope. Each key is a variable name and each value a JSON variable value object.</value>
        [DataMember(Name = "variables", EmitDefaultValue = true)]
        public Dictionary<string, VariableValueDto> Variables { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MigrationPlanGenerationDto {\n");
            sb.Append("  SourceProcessDefinitionId: ").Append(SourceProcessDefinitionId).Append("\n");
            sb.Append("  TargetProcessDefinitionId: ").Append(TargetProcessDefinitionId).Append("\n");
            sb.Append("  UpdateEventTriggers: ").Append(UpdateEventTriggers).Append("\n");
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
            return this.Equals(input as MigrationPlanGenerationDto);
        }

        /// <summary>
        /// Returns true if MigrationPlanGenerationDto instances are equal
        /// </summary>
        /// <param name="input">Instance of MigrationPlanGenerationDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MigrationPlanGenerationDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SourceProcessDefinitionId == input.SourceProcessDefinitionId ||
                    (this.SourceProcessDefinitionId != null &&
                    this.SourceProcessDefinitionId.Equals(input.SourceProcessDefinitionId))
                ) && 
                (
                    this.TargetProcessDefinitionId == input.TargetProcessDefinitionId ||
                    (this.TargetProcessDefinitionId != null &&
                    this.TargetProcessDefinitionId.Equals(input.TargetProcessDefinitionId))
                ) && 
                (
                    this.UpdateEventTriggers == input.UpdateEventTriggers ||
                    (this.UpdateEventTriggers != null &&
                    this.UpdateEventTriggers.Equals(input.UpdateEventTriggers))
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
                if (this.SourceProcessDefinitionId != null)
                    hashCode = hashCode * 59 + this.SourceProcessDefinitionId.GetHashCode();
                if (this.TargetProcessDefinitionId != null)
                    hashCode = hashCode * 59 + this.TargetProcessDefinitionId.GetHashCode();
                if (this.UpdateEventTriggers != null)
                    hashCode = hashCode * 59 + this.UpdateEventTriggers.GetHashCode();
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
