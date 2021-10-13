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
    /// JobDefinitionSuspensionStateDtoAllOf
    /// </summary>
    [DataContract(Name = "JobDefinitionSuspensionStateDto_allOf")]
    public partial class JobDefinitionSuspensionStateDtoAllOf : IEquatable<JobDefinitionSuspensionStateDtoAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JobDefinitionSuspensionStateDtoAllOf" /> class.
        /// </summary>
        /// <param name="includeJobs">A &#x60;Boolean&#x60; value which indicates whether to activate or suspend also all jobs of the referenced job definitions. When the value is set to &#x60;true&#x60;, all jobs of the provided job definitions will be activated or suspended and when the value is set to &#x60;false&#x60;, the suspension state of all jobs of the provided job definitions will not be updated..</param>
        /// <param name="executionDate">The date on which the referenced job definitions will be activated or suspended. If null, the suspension state of the given job definitions is updated immediately. By [default](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM- dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;..</param>
        public JobDefinitionSuspensionStateDtoAllOf(bool? includeJobs = default(bool?), string executionDate = default(string))
        {
            this.IncludeJobs = includeJobs;
            this.ExecutionDate = executionDate;
        }

        /// <summary>
        /// A &#x60;Boolean&#x60; value which indicates whether to activate or suspend also all jobs of the referenced job definitions. When the value is set to &#x60;true&#x60;, all jobs of the provided job definitions will be activated or suspended and when the value is set to &#x60;false&#x60;, the suspension state of all jobs of the provided job definitions will not be updated.
        /// </summary>
        /// <value>A &#x60;Boolean&#x60; value which indicates whether to activate or suspend also all jobs of the referenced job definitions. When the value is set to &#x60;true&#x60;, all jobs of the provided job definitions will be activated or suspended and when the value is set to &#x60;false&#x60;, the suspension state of all jobs of the provided job definitions will not be updated.</value>
        [DataMember(Name = "includeJobs", EmitDefaultValue = true)]
        public bool? IncludeJobs { get; set; }

        /// <summary>
        /// The date on which the referenced job definitions will be activated or suspended. If null, the suspension state of the given job definitions is updated immediately. By [default](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM- dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;.
        /// </summary>
        /// <value>The date on which the referenced job definitions will be activated or suspended. If null, the suspension state of the given job definitions is updated immediately. By [default](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM- dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;.</value>
        [DataMember(Name = "executionDate", EmitDefaultValue = true)]
        public string ExecutionDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JobDefinitionSuspensionStateDtoAllOf {\n");
            sb.Append("  IncludeJobs: ").Append(IncludeJobs).Append("\n");
            sb.Append("  ExecutionDate: ").Append(ExecutionDate).Append("\n");
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
            return this.Equals(input as JobDefinitionSuspensionStateDtoAllOf);
        }

        /// <summary>
        /// Returns true if JobDefinitionSuspensionStateDtoAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of JobDefinitionSuspensionStateDtoAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JobDefinitionSuspensionStateDtoAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IncludeJobs == input.IncludeJobs ||
                    (this.IncludeJobs != null &&
                    this.IncludeJobs.Equals(input.IncludeJobs))
                ) && 
                (
                    this.ExecutionDate == input.ExecutionDate ||
                    (this.ExecutionDate != null &&
                    this.ExecutionDate.Equals(input.ExecutionDate))
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
                if (this.IncludeJobs != null)
                    hashCode = hashCode * 59 + this.IncludeJobs.GetHashCode();
                if (this.ExecutionDate != null)
                    hashCode = hashCode * 59 + this.ExecutionDate.GetHashCode();
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
