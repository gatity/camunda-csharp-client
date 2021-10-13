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
    /// JobDefinitionsSuspensionStateDto
    /// </summary>
    [DataContract(Name = "JobDefinitionsSuspensionStateDto")]
    public partial class JobDefinitionsSuspensionStateDto : IEquatable<JobDefinitionsSuspensionStateDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JobDefinitionsSuspensionStateDto" /> class.
        /// </summary>
        /// <param name="processDefinitionId">The process definition id of the job definitions to activate or suspend..</param>
        /// <param name="processDefinitionKey">The process definition key of the job definitions to activate or suspend..</param>
        /// <param name="processDefinitionTenantId">Only activate or suspend job definitions of a process definition which belongs to a tenant with the given id.  Note that this parameter will only be considered  in combination with &#x60;processDefinitionKey&#x60;..</param>
        /// <param name="processDefinitionWithoutTenantId">Only activate or suspend job definitions of a process definition which belongs to no tenant. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior.  Note that this parameter will only be considered  in combination with &#x60;processDefinitionKey&#x60;..</param>
        /// <param name="includeJobs">A &#x60;Boolean&#x60; value which indicates whether to activate or suspend also all jobs of the referenced job definitions. When the value is set to &#x60;true&#x60;, all jobs of the provided job definitions will be activated or suspended and when the value is set to &#x60;false&#x60;, the suspension state of all jobs of the provided job definitions will not be updated..</param>
        /// <param name="executionDate">The date on which the referenced job definitions will be activated or suspended. If null, the suspension state of the given job definitions is updated immediately. By [default](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM- dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;..</param>
        /// <param name="suspended">A Boolean value which indicates whether to activate or suspend a given instance  (e.g. process instance, job, job definition, or batch). When the value is set to true,  the given instance will be suspended and when the value is set to false,  the given instance will be activated..</param>
        public JobDefinitionsSuspensionStateDto(string processDefinitionId = default(string), string processDefinitionKey = default(string), string processDefinitionTenantId = default(string), bool? processDefinitionWithoutTenantId = default(bool?), bool? includeJobs = default(bool?), string executionDate = default(string), bool? suspended = default(bool?))
        {
            this.ProcessDefinitionId = processDefinitionId;
            this.ProcessDefinitionKey = processDefinitionKey;
            this.ProcessDefinitionTenantId = processDefinitionTenantId;
            this.ProcessDefinitionWithoutTenantId = processDefinitionWithoutTenantId;
            this.IncludeJobs = includeJobs;
            this.ExecutionDate = executionDate;
            this.Suspended = suspended;
        }

        /// <summary>
        /// The process definition id of the job definitions to activate or suspend.
        /// </summary>
        /// <value>The process definition id of the job definitions to activate or suspend.</value>
        [DataMember(Name = "processDefinitionId", EmitDefaultValue = true)]
        public string ProcessDefinitionId { get; set; }

        /// <summary>
        /// The process definition key of the job definitions to activate or suspend.
        /// </summary>
        /// <value>The process definition key of the job definitions to activate or suspend.</value>
        [DataMember(Name = "processDefinitionKey", EmitDefaultValue = true)]
        public string ProcessDefinitionKey { get; set; }

        /// <summary>
        /// Only activate or suspend job definitions of a process definition which belongs to a tenant with the given id.  Note that this parameter will only be considered  in combination with &#x60;processDefinitionKey&#x60;.
        /// </summary>
        /// <value>Only activate or suspend job definitions of a process definition which belongs to a tenant with the given id.  Note that this parameter will only be considered  in combination with &#x60;processDefinitionKey&#x60;.</value>
        [DataMember(Name = "processDefinitionTenantId", EmitDefaultValue = true)]
        public string ProcessDefinitionTenantId { get; set; }

        /// <summary>
        /// Only activate or suspend job definitions of a process definition which belongs to no tenant. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior.  Note that this parameter will only be considered  in combination with &#x60;processDefinitionKey&#x60;.
        /// </summary>
        /// <value>Only activate or suspend job definitions of a process definition which belongs to no tenant. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior.  Note that this parameter will only be considered  in combination with &#x60;processDefinitionKey&#x60;.</value>
        [DataMember(Name = "processDefinitionWithoutTenantId", EmitDefaultValue = true)]
        public bool? ProcessDefinitionWithoutTenantId { get; set; }

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
            sb.Append("class JobDefinitionsSuspensionStateDto {\n");
            sb.Append("  ProcessDefinitionId: ").Append(ProcessDefinitionId).Append("\n");
            sb.Append("  ProcessDefinitionKey: ").Append(ProcessDefinitionKey).Append("\n");
            sb.Append("  ProcessDefinitionTenantId: ").Append(ProcessDefinitionTenantId).Append("\n");
            sb.Append("  ProcessDefinitionWithoutTenantId: ").Append(ProcessDefinitionWithoutTenantId).Append("\n");
            sb.Append("  IncludeJobs: ").Append(IncludeJobs).Append("\n");
            sb.Append("  ExecutionDate: ").Append(ExecutionDate).Append("\n");
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
            return this.Equals(input as JobDefinitionsSuspensionStateDto);
        }

        /// <summary>
        /// Returns true if JobDefinitionsSuspensionStateDto instances are equal
        /// </summary>
        /// <param name="input">Instance of JobDefinitionsSuspensionStateDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JobDefinitionsSuspensionStateDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProcessDefinitionId == input.ProcessDefinitionId ||
                    (this.ProcessDefinitionId != null &&
                    this.ProcessDefinitionId.Equals(input.ProcessDefinitionId))
                ) && 
                (
                    this.ProcessDefinitionKey == input.ProcessDefinitionKey ||
                    (this.ProcessDefinitionKey != null &&
                    this.ProcessDefinitionKey.Equals(input.ProcessDefinitionKey))
                ) && 
                (
                    this.ProcessDefinitionTenantId == input.ProcessDefinitionTenantId ||
                    (this.ProcessDefinitionTenantId != null &&
                    this.ProcessDefinitionTenantId.Equals(input.ProcessDefinitionTenantId))
                ) && 
                (
                    this.ProcessDefinitionWithoutTenantId == input.ProcessDefinitionWithoutTenantId ||
                    (this.ProcessDefinitionWithoutTenantId != null &&
                    this.ProcessDefinitionWithoutTenantId.Equals(input.ProcessDefinitionWithoutTenantId))
                ) && 
                (
                    this.IncludeJobs == input.IncludeJobs ||
                    (this.IncludeJobs != null &&
                    this.IncludeJobs.Equals(input.IncludeJobs))
                ) && 
                (
                    this.ExecutionDate == input.ExecutionDate ||
                    (this.ExecutionDate != null &&
                    this.ExecutionDate.Equals(input.ExecutionDate))
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
                if (this.ProcessDefinitionId != null)
                    hashCode = hashCode * 59 + this.ProcessDefinitionId.GetHashCode();
                if (this.ProcessDefinitionKey != null)
                    hashCode = hashCode * 59 + this.ProcessDefinitionKey.GetHashCode();
                if (this.ProcessDefinitionTenantId != null)
                    hashCode = hashCode * 59 + this.ProcessDefinitionTenantId.GetHashCode();
                if (this.ProcessDefinitionWithoutTenantId != null)
                    hashCode = hashCode * 59 + this.ProcessDefinitionWithoutTenantId.GetHashCode();
                if (this.IncludeJobs != null)
                    hashCode = hashCode * 59 + this.IncludeJobs.GetHashCode();
                if (this.ExecutionDate != null)
                    hashCode = hashCode * 59 + this.ExecutionDate.GetHashCode();
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
