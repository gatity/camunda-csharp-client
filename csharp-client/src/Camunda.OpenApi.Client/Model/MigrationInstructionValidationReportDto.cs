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
using FileParameter = Camunda.OpenApi.Client.Client.FileParameter;
using OpenAPIDateConverter = Camunda.OpenApi.Client.Client.OpenAPIDateConverter;

namespace Camunda.OpenApi.Client.Model
{
    /// <summary>
    /// MigrationInstructionValidationReportDto
    /// </summary>
    [DataContract(Name = "MigrationInstructionValidationReportDto")]
    public partial class MigrationInstructionValidationReportDto : IEquatable<MigrationInstructionValidationReportDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MigrationInstructionValidationReportDto" /> class.
        /// </summary>
        /// <param name="instruction">instruction.</param>
        /// <param name="failures">A list of instruction validation report messages..</param>
        public MigrationInstructionValidationReportDto(MigrationInstructionDto instruction = default(MigrationInstructionDto), List<string> failures = default(List<string>))
        {
            this.Instruction = instruction;
            this.Failures = failures;
        }

        /// <summary>
        /// Gets or Sets Instruction
        /// </summary>
        [DataMember(Name = "instruction", EmitDefaultValue = false)]
        public MigrationInstructionDto Instruction { get; set; }

        /// <summary>
        /// A list of instruction validation report messages.
        /// </summary>
        /// <value>A list of instruction validation report messages.</value>
        [DataMember(Name = "failures", EmitDefaultValue = true)]
        public List<string> Failures { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MigrationInstructionValidationReportDto {\n");
            sb.Append("  Instruction: ").Append(Instruction).Append("\n");
            sb.Append("  Failures: ").Append(Failures).Append("\n");
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
            return this.Equals(input as MigrationInstructionValidationReportDto);
        }

        /// <summary>
        /// Returns true if MigrationInstructionValidationReportDto instances are equal
        /// </summary>
        /// <param name="input">Instance of MigrationInstructionValidationReportDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MigrationInstructionValidationReportDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Instruction == input.Instruction ||
                    (this.Instruction != null &&
                    this.Instruction.Equals(input.Instruction))
                ) && 
                (
                    this.Failures == input.Failures ||
                    this.Failures != null &&
                    input.Failures != null &&
                    this.Failures.SequenceEqual(input.Failures)
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
                if (this.Instruction != null)
                    hashCode = hashCode * 59 + this.Instruction.GetHashCode();
                if (this.Failures != null)
                    hashCode = hashCode * 59 + this.Failures.GetHashCode();
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
