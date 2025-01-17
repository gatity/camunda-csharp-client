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
    /// ProcessInstanceModificationDto
    /// </summary>
    [DataContract(Name = "ProcessInstanceModificationDto")]
    public partial class ProcessInstanceModificationDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessInstanceModificationDto" /> class.
        /// </summary>
        /// <param name="skipCustomListeners">Skip execution listener invocation for activities that are started or ended as part of this request..</param>
        /// <param name="skipIoMappings">Skip execution of [input/output variable mappings](https://docs.camunda.org/manual/7.21/user-guide/process-engine/variables/#input-output-variable-mapping) for activities that are started or ended as part of this request..</param>
        /// <param name="instructions">JSON array of modification instructions. The instructions are executed in the order they are in..</param>
        /// <param name="annotation">An arbitrary text annotation set by a user for auditing reasons..</param>
        public ProcessInstanceModificationDto(bool? skipCustomListeners = default(bool?), bool? skipIoMappings = default(bool?), List<ProcessInstanceModificationInstructionDto> instructions = default(List<ProcessInstanceModificationInstructionDto>), string annotation = default(string))
        {
            this.SkipCustomListeners = skipCustomListeners;
            this.SkipIoMappings = skipIoMappings;
            this.Instructions = instructions;
            this.Annotation = annotation;
        }

        /// <summary>
        /// Skip execution listener invocation for activities that are started or ended as part of this request.
        /// </summary>
        /// <value>Skip execution listener invocation for activities that are started or ended as part of this request.</value>
        [DataMember(Name = "skipCustomListeners", EmitDefaultValue = true)]
        public bool? SkipCustomListeners { get; set; }

        /// <summary>
        /// Skip execution of [input/output variable mappings](https://docs.camunda.org/manual/7.21/user-guide/process-engine/variables/#input-output-variable-mapping) for activities that are started or ended as part of this request.
        /// </summary>
        /// <value>Skip execution of [input/output variable mappings](https://docs.camunda.org/manual/7.21/user-guide/process-engine/variables/#input-output-variable-mapping) for activities that are started or ended as part of this request.</value>
        [DataMember(Name = "skipIoMappings", EmitDefaultValue = true)]
        public bool? SkipIoMappings { get; set; }

        /// <summary>
        /// JSON array of modification instructions. The instructions are executed in the order they are in.
        /// </summary>
        /// <value>JSON array of modification instructions. The instructions are executed in the order they are in.</value>
        [DataMember(Name = "instructions", EmitDefaultValue = true)]
        public List<ProcessInstanceModificationInstructionDto> Instructions { get; set; }

        /// <summary>
        /// An arbitrary text annotation set by a user for auditing reasons.
        /// </summary>
        /// <value>An arbitrary text annotation set by a user for auditing reasons.</value>
        [DataMember(Name = "annotation", EmitDefaultValue = true)]
        public string Annotation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ProcessInstanceModificationDto {\n");
            sb.Append("  SkipCustomListeners: ").Append(SkipCustomListeners).Append("\n");
            sb.Append("  SkipIoMappings: ").Append(SkipIoMappings).Append("\n");
            sb.Append("  Instructions: ").Append(Instructions).Append("\n");
            sb.Append("  Annotation: ").Append(Annotation).Append("\n");
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
