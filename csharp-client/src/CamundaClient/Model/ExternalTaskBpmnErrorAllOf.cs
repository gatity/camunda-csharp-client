/*
 * Camunda BPM REST API
 *
 * OpenApi Spec for Camunda BPM REST API.
 *
 * The version of the OpenAPI document: 7.14.0
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
using OpenAPIDateConverter = CamundaClient.Client.OpenAPIDateConverter;

namespace CamundaClient.Model
{
    /// <summary>
    /// ExternalTaskBpmnErrorAllOf
    /// </summary>
    [DataContract(Name = "ExternalTaskBpmnError_allOf")]
    public partial class ExternalTaskBpmnErrorAllOf : IEquatable<ExternalTaskBpmnErrorAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalTaskBpmnErrorAllOf" /> class.
        /// </summary>
        /// <param name="workerId">The id of the worker that reports the failure. Must match the id of the worker who has most recently locked the task..</param>
        public ExternalTaskBpmnErrorAllOf(string workerId = default(string))
        {
            this.WorkerId = workerId;
        }

        /// <summary>
        /// The id of the worker that reports the failure. Must match the id of the worker who has most recently locked the task.
        /// </summary>
        /// <value>The id of the worker that reports the failure. Must match the id of the worker who has most recently locked the task.</value>
        [DataMember(Name = "workerId", EmitDefaultValue = false)]
        public string WorkerId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExternalTaskBpmnErrorAllOf {\n");
            sb.Append("  WorkerId: ").Append(WorkerId).Append("\n");
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
            return this.Equals(input as ExternalTaskBpmnErrorAllOf);
        }

        /// <summary>
        /// Returns true if ExternalTaskBpmnErrorAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of ExternalTaskBpmnErrorAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExternalTaskBpmnErrorAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.WorkerId == input.WorkerId ||
                    (this.WorkerId != null &&
                    this.WorkerId.Equals(input.WorkerId))
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
                if (this.WorkerId != null)
                    hashCode = hashCode * 59 + this.WorkerId.GetHashCode();
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
