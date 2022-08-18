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
    /// MigrationPlanReportDto
    /// </summary>
    [DataContract(Name = "MigrationPlanReportDto")]
    public partial class MigrationPlanReportDto : IEquatable<MigrationPlanReportDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MigrationPlanReportDto" /> class.
        /// </summary>
        /// <param name="instructionReports">The list of instruction validation reports. If no validation errors are detected it is an empty list..</param>
        /// <param name="variableReports">A map of variable reports. Each key is a variable name and each value a JSON object consisting of the variable&#39;s type, value, value info object and a list of failures..</param>
        public MigrationPlanReportDto(List<MigrationInstructionValidationReportDto> instructionReports = default(List<MigrationInstructionValidationReportDto>), Dictionary<string, MigrationVariableValidationReportDto> variableReports = default(Dictionary<string, MigrationVariableValidationReportDto>))
        {
            this.InstructionReports = instructionReports;
            this.VariableReports = variableReports;
        }

        /// <summary>
        /// The list of instruction validation reports. If no validation errors are detected it is an empty list.
        /// </summary>
        /// <value>The list of instruction validation reports. If no validation errors are detected it is an empty list.</value>
        [DataMember(Name = "instructionReports", EmitDefaultValue = true)]
        public List<MigrationInstructionValidationReportDto> InstructionReports { get; set; }

        /// <summary>
        /// A map of variable reports. Each key is a variable name and each value a JSON object consisting of the variable&#39;s type, value, value info object and a list of failures.
        /// </summary>
        /// <value>A map of variable reports. Each key is a variable name and each value a JSON object consisting of the variable&#39;s type, value, value info object and a list of failures.</value>
        [DataMember(Name = "variableReports", EmitDefaultValue = true)]
        public Dictionary<string, MigrationVariableValidationReportDto> VariableReports { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MigrationPlanReportDto {\n");
            sb.Append("  InstructionReports: ").Append(InstructionReports).Append("\n");
            sb.Append("  VariableReports: ").Append(VariableReports).Append("\n");
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
            return this.Equals(input as MigrationPlanReportDto);
        }

        /// <summary>
        /// Returns true if MigrationPlanReportDto instances are equal
        /// </summary>
        /// <param name="input">Instance of MigrationPlanReportDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MigrationPlanReportDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InstructionReports == input.InstructionReports ||
                    this.InstructionReports != null &&
                    input.InstructionReports != null &&
                    this.InstructionReports.SequenceEqual(input.InstructionReports)
                ) && 
                (
                    this.VariableReports == input.VariableReports ||
                    this.VariableReports != null &&
                    input.VariableReports != null &&
                    this.VariableReports.SequenceEqual(input.VariableReports)
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
                if (this.InstructionReports != null)
                    hashCode = hashCode * 59 + this.InstructionReports.GetHashCode();
                if (this.VariableReports != null)
                    hashCode = hashCode * 59 + this.VariableReports.GetHashCode();
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
