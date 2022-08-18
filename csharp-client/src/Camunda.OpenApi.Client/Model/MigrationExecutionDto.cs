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
    /// MigrationExecutionDto
    /// </summary>
    [DataContract(Name = "MigrationExecutionDto")]
    public partial class MigrationExecutionDto : IEquatable<MigrationExecutionDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MigrationExecutionDto" /> class.
        /// </summary>
        /// <param name="migrationPlan">migrationPlan.</param>
        /// <param name="processInstanceIds">A list of process instance ids to migrate..</param>
        /// <param name="processInstanceQuery">processInstanceQuery.</param>
        /// <param name="skipCustomListeners">A boolean value to control whether execution listeners should be invoked during migration..</param>
        /// <param name="skipIoMappings">A boolean value to control whether input/output mappings should be executed during migration..</param>
        public MigrationExecutionDto(MigrationPlanDto migrationPlan = default(MigrationPlanDto), List<string> processInstanceIds = default(List<string>), ProcessInstanceQueryDto processInstanceQuery = default(ProcessInstanceQueryDto), bool? skipCustomListeners = default(bool?), bool? skipIoMappings = default(bool?))
        {
            this.MigrationPlan = migrationPlan;
            this.ProcessInstanceIds = processInstanceIds;
            this.ProcessInstanceQuery = processInstanceQuery;
            this.SkipCustomListeners = skipCustomListeners;
            this.SkipIoMappings = skipIoMappings;
        }

        /// <summary>
        /// Gets or Sets MigrationPlan
        /// </summary>
        [DataMember(Name = "migrationPlan", EmitDefaultValue = false)]
        public MigrationPlanDto MigrationPlan { get; set; }

        /// <summary>
        /// A list of process instance ids to migrate.
        /// </summary>
        /// <value>A list of process instance ids to migrate.</value>
        [DataMember(Name = "processInstanceIds", EmitDefaultValue = true)]
        public List<string> ProcessInstanceIds { get; set; }

        /// <summary>
        /// Gets or Sets ProcessInstanceQuery
        /// </summary>
        [DataMember(Name = "processInstanceQuery", EmitDefaultValue = false)]
        public ProcessInstanceQueryDto ProcessInstanceQuery { get; set; }

        /// <summary>
        /// A boolean value to control whether execution listeners should be invoked during migration.
        /// </summary>
        /// <value>A boolean value to control whether execution listeners should be invoked during migration.</value>
        [DataMember(Name = "skipCustomListeners", EmitDefaultValue = true)]
        public bool? SkipCustomListeners { get; set; }

        /// <summary>
        /// A boolean value to control whether input/output mappings should be executed during migration.
        /// </summary>
        /// <value>A boolean value to control whether input/output mappings should be executed during migration.</value>
        [DataMember(Name = "skipIoMappings", EmitDefaultValue = true)]
        public bool? SkipIoMappings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MigrationExecutionDto {\n");
            sb.Append("  MigrationPlan: ").Append(MigrationPlan).Append("\n");
            sb.Append("  ProcessInstanceIds: ").Append(ProcessInstanceIds).Append("\n");
            sb.Append("  ProcessInstanceQuery: ").Append(ProcessInstanceQuery).Append("\n");
            sb.Append("  SkipCustomListeners: ").Append(SkipCustomListeners).Append("\n");
            sb.Append("  SkipIoMappings: ").Append(SkipIoMappings).Append("\n");
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
            return this.Equals(input as MigrationExecutionDto);
        }

        /// <summary>
        /// Returns true if MigrationExecutionDto instances are equal
        /// </summary>
        /// <param name="input">Instance of MigrationExecutionDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MigrationExecutionDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MigrationPlan == input.MigrationPlan ||
                    (this.MigrationPlan != null &&
                    this.MigrationPlan.Equals(input.MigrationPlan))
                ) && 
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
                    this.SkipCustomListeners == input.SkipCustomListeners ||
                    (this.SkipCustomListeners != null &&
                    this.SkipCustomListeners.Equals(input.SkipCustomListeners))
                ) && 
                (
                    this.SkipIoMappings == input.SkipIoMappings ||
                    (this.SkipIoMappings != null &&
                    this.SkipIoMappings.Equals(input.SkipIoMappings))
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
                if (this.MigrationPlan != null)
                    hashCode = hashCode * 59 + this.MigrationPlan.GetHashCode();
                if (this.ProcessInstanceIds != null)
                    hashCode = hashCode * 59 + this.ProcessInstanceIds.GetHashCode();
                if (this.ProcessInstanceQuery != null)
                    hashCode = hashCode * 59 + this.ProcessInstanceQuery.GetHashCode();
                if (this.SkipCustomListeners != null)
                    hashCode = hashCode * 59 + this.SkipCustomListeners.GetHashCode();
                if (this.SkipIoMappings != null)
                    hashCode = hashCode * 59 + this.SkipIoMappings.GetHashCode();
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
