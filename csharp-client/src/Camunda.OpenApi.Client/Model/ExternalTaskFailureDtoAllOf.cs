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
    /// ExternalTaskFailureDtoAllOf
    /// </summary>
    [DataContract(Name = "ExternalTaskFailureDto_allOf")]
    public partial class ExternalTaskFailureDtoAllOf : IEquatable<ExternalTaskFailureDtoAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalTaskFailureDtoAllOf" /> class.
        /// </summary>
        /// <param name="errorMessage">An message indicating the reason of the failure..</param>
        /// <param name="errorDetails">A detailed error description..</param>
        /// <param name="retries">A number of how often the task should be retried. Must be &gt;&#x3D; 0. If this is 0, an incident is created and the task cannot be fetched anymore unless the retries are increased again. The incident&#39;s message is set to the &#x60;errorMessage&#x60; parameter..</param>
        /// <param name="retryTimeout">A timeout in milliseconds before the external task becomes available again for fetching. Must be &gt;&#x3D; 0..</param>
        /// <param name="variables">A JSON object containing variable key-value pairs. Each key is a variable name and each value a JSON variable value object with the following properties:.</param>
        /// <param name="localVariables">A JSON object containing local variable key-value pairs. Local variables are set only in the scope of external task. Each key is a variable name and each value a JSON variable value object with the following properties:.</param>
        public ExternalTaskFailureDtoAllOf(string errorMessage = default(string), string errorDetails = default(string), int? retries = default(int?), long? retryTimeout = default(long?), Dictionary<string, VariableValueDto> variables = default(Dictionary<string, VariableValueDto>), Dictionary<string, VariableValueDto> localVariables = default(Dictionary<string, VariableValueDto>))
        {
            this.ErrorMessage = errorMessage;
            this.ErrorDetails = errorDetails;
            this.Retries = retries;
            this.RetryTimeout = retryTimeout;
            this.Variables = variables;
            this.LocalVariables = localVariables;
        }

        /// <summary>
        /// An message indicating the reason of the failure.
        /// </summary>
        /// <value>An message indicating the reason of the failure.</value>
        [DataMember(Name = "errorMessage", EmitDefaultValue = true)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// A detailed error description.
        /// </summary>
        /// <value>A detailed error description.</value>
        [DataMember(Name = "errorDetails", EmitDefaultValue = true)]
        public string ErrorDetails { get; set; }

        /// <summary>
        /// A number of how often the task should be retried. Must be &gt;&#x3D; 0. If this is 0, an incident is created and the task cannot be fetched anymore unless the retries are increased again. The incident&#39;s message is set to the &#x60;errorMessage&#x60; parameter.
        /// </summary>
        /// <value>A number of how often the task should be retried. Must be &gt;&#x3D; 0. If this is 0, an incident is created and the task cannot be fetched anymore unless the retries are increased again. The incident&#39;s message is set to the &#x60;errorMessage&#x60; parameter.</value>
        [DataMember(Name = "retries", EmitDefaultValue = true)]
        public int? Retries { get; set; }

        /// <summary>
        /// A timeout in milliseconds before the external task becomes available again for fetching. Must be &gt;&#x3D; 0.
        /// </summary>
        /// <value>A timeout in milliseconds before the external task becomes available again for fetching. Must be &gt;&#x3D; 0.</value>
        [DataMember(Name = "retryTimeout", EmitDefaultValue = true)]
        public long? RetryTimeout { get; set; }

        /// <summary>
        /// A JSON object containing variable key-value pairs. Each key is a variable name and each value a JSON variable value object with the following properties:
        /// </summary>
        /// <value>A JSON object containing variable key-value pairs. Each key is a variable name and each value a JSON variable value object with the following properties:</value>
        [DataMember(Name = "variables", EmitDefaultValue = true)]
        public Dictionary<string, VariableValueDto> Variables { get; set; }

        /// <summary>
        /// A JSON object containing local variable key-value pairs. Local variables are set only in the scope of external task. Each key is a variable name and each value a JSON variable value object with the following properties:
        /// </summary>
        /// <value>A JSON object containing local variable key-value pairs. Local variables are set only in the scope of external task. Each key is a variable name and each value a JSON variable value object with the following properties:</value>
        [DataMember(Name = "localVariables", EmitDefaultValue = true)]
        public Dictionary<string, VariableValueDto> LocalVariables { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExternalTaskFailureDtoAllOf {\n");
            sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
            sb.Append("  ErrorDetails: ").Append(ErrorDetails).Append("\n");
            sb.Append("  Retries: ").Append(Retries).Append("\n");
            sb.Append("  RetryTimeout: ").Append(RetryTimeout).Append("\n");
            sb.Append("  Variables: ").Append(Variables).Append("\n");
            sb.Append("  LocalVariables: ").Append(LocalVariables).Append("\n");
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
            return this.Equals(input as ExternalTaskFailureDtoAllOf);
        }

        /// <summary>
        /// Returns true if ExternalTaskFailureDtoAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of ExternalTaskFailureDtoAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExternalTaskFailureDtoAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ErrorMessage == input.ErrorMessage ||
                    (this.ErrorMessage != null &&
                    this.ErrorMessage.Equals(input.ErrorMessage))
                ) && 
                (
                    this.ErrorDetails == input.ErrorDetails ||
                    (this.ErrorDetails != null &&
                    this.ErrorDetails.Equals(input.ErrorDetails))
                ) && 
                (
                    this.Retries == input.Retries ||
                    (this.Retries != null &&
                    this.Retries.Equals(input.Retries))
                ) && 
                (
                    this.RetryTimeout == input.RetryTimeout ||
                    (this.RetryTimeout != null &&
                    this.RetryTimeout.Equals(input.RetryTimeout))
                ) && 
                (
                    this.Variables == input.Variables ||
                    this.Variables != null &&
                    input.Variables != null &&
                    this.Variables.SequenceEqual(input.Variables)
                ) && 
                (
                    this.LocalVariables == input.LocalVariables ||
                    this.LocalVariables != null &&
                    input.LocalVariables != null &&
                    this.LocalVariables.SequenceEqual(input.LocalVariables)
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
                if (this.ErrorMessage != null)
                    hashCode = hashCode * 59 + this.ErrorMessage.GetHashCode();
                if (this.ErrorDetails != null)
                    hashCode = hashCode * 59 + this.ErrorDetails.GetHashCode();
                if (this.Retries != null)
                    hashCode = hashCode * 59 + this.Retries.GetHashCode();
                if (this.RetryTimeout != null)
                    hashCode = hashCode * 59 + this.RetryTimeout.GetHashCode();
                if (this.Variables != null)
                    hashCode = hashCode * 59 + this.Variables.GetHashCode();
                if (this.LocalVariables != null)
                    hashCode = hashCode * 59 + this.LocalVariables.GetHashCode();
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
