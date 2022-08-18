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
    /// JobSuspensionStateDto
    /// </summary>
    [DataContract(Name = "JobSuspensionStateDto")]
    public partial class JobSuspensionStateDto : IEquatable<JobSuspensionStateDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JobSuspensionStateDto" /> class.
        /// </summary>
        /// <param name="jobDefinitionId">The job definition id of the jobs to activate or suspend..</param>
        /// <param name="processDefinitionId">The process definition id of the jobs to activate or suspend..</param>
        /// <param name="processInstanceId">The process instance id of the jobs to activate or suspend..</param>
        /// <param name="processDefinitionKey">The process definition key of the jobs to activate or suspend..</param>
        /// <param name="processDefinitionTenantId">Only activate or suspend jobs of a process definition which belongs to a tenant with the given id. Works only when selecting with &#x60;processDefinitionKey&#x60;..</param>
        /// <param name="processDefinitionWithoutTenantId">Only activate or suspend jobs of a process definition which belongs to no tenant. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. Works only when selecting with &#x60;processDefinitionKey&#x60;..</param>
        /// <param name="suspended">A Boolean value which indicates whether to activate or suspend a given instance  (e.g. process instance, job, job definition, or batch). When the value is set to true,  the given instance will be suspended and when the value is set to false,  the given instance will be activated..</param>
        public JobSuspensionStateDto(string jobDefinitionId = default(string), string processDefinitionId = default(string), string processInstanceId = default(string), string processDefinitionKey = default(string), string processDefinitionTenantId = default(string), bool? processDefinitionWithoutTenantId = default(bool?), bool? suspended = default(bool?))
        {
            this.JobDefinitionId = jobDefinitionId;
            this.ProcessDefinitionId = processDefinitionId;
            this.ProcessInstanceId = processInstanceId;
            this.ProcessDefinitionKey = processDefinitionKey;
            this.ProcessDefinitionTenantId = processDefinitionTenantId;
            this.ProcessDefinitionWithoutTenantId = processDefinitionWithoutTenantId;
            this.Suspended = suspended;
        }

        /// <summary>
        /// The job definition id of the jobs to activate or suspend.
        /// </summary>
        /// <value>The job definition id of the jobs to activate or suspend.</value>
        [DataMember(Name = "jobDefinitionId", EmitDefaultValue = true)]
        public string JobDefinitionId { get; set; }

        /// <summary>
        /// The process definition id of the jobs to activate or suspend.
        /// </summary>
        /// <value>The process definition id of the jobs to activate or suspend.</value>
        [DataMember(Name = "processDefinitionId", EmitDefaultValue = true)]
        public string ProcessDefinitionId { get; set; }

        /// <summary>
        /// The process instance id of the jobs to activate or suspend.
        /// </summary>
        /// <value>The process instance id of the jobs to activate or suspend.</value>
        [DataMember(Name = "processInstanceId", EmitDefaultValue = true)]
        public string ProcessInstanceId { get; set; }

        /// <summary>
        /// The process definition key of the jobs to activate or suspend.
        /// </summary>
        /// <value>The process definition key of the jobs to activate or suspend.</value>
        [DataMember(Name = "processDefinitionKey", EmitDefaultValue = true)]
        public string ProcessDefinitionKey { get; set; }

        /// <summary>
        /// Only activate or suspend jobs of a process definition which belongs to a tenant with the given id. Works only when selecting with &#x60;processDefinitionKey&#x60;.
        /// </summary>
        /// <value>Only activate or suspend jobs of a process definition which belongs to a tenant with the given id. Works only when selecting with &#x60;processDefinitionKey&#x60;.</value>
        [DataMember(Name = "processDefinitionTenantId", EmitDefaultValue = true)]
        public string ProcessDefinitionTenantId { get; set; }

        /// <summary>
        /// Only activate or suspend jobs of a process definition which belongs to no tenant. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. Works only when selecting with &#x60;processDefinitionKey&#x60;.
        /// </summary>
        /// <value>Only activate or suspend jobs of a process definition which belongs to no tenant. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior. Works only when selecting with &#x60;processDefinitionKey&#x60;.</value>
        [DataMember(Name = "processDefinitionWithoutTenantId", EmitDefaultValue = true)]
        public bool? ProcessDefinitionWithoutTenantId { get; set; }

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
            sb.Append("class JobSuspensionStateDto {\n");
            sb.Append("  JobDefinitionId: ").Append(JobDefinitionId).Append("\n");
            sb.Append("  ProcessDefinitionId: ").Append(ProcessDefinitionId).Append("\n");
            sb.Append("  ProcessInstanceId: ").Append(ProcessInstanceId).Append("\n");
            sb.Append("  ProcessDefinitionKey: ").Append(ProcessDefinitionKey).Append("\n");
            sb.Append("  ProcessDefinitionTenantId: ").Append(ProcessDefinitionTenantId).Append("\n");
            sb.Append("  ProcessDefinitionWithoutTenantId: ").Append(ProcessDefinitionWithoutTenantId).Append("\n");
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
            return this.Equals(input as JobSuspensionStateDto);
        }

        /// <summary>
        /// Returns true if JobSuspensionStateDto instances are equal
        /// </summary>
        /// <param name="input">Instance of JobSuspensionStateDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JobSuspensionStateDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.JobDefinitionId == input.JobDefinitionId ||
                    (this.JobDefinitionId != null &&
                    this.JobDefinitionId.Equals(input.JobDefinitionId))
                ) && 
                (
                    this.ProcessDefinitionId == input.ProcessDefinitionId ||
                    (this.ProcessDefinitionId != null &&
                    this.ProcessDefinitionId.Equals(input.ProcessDefinitionId))
                ) && 
                (
                    this.ProcessInstanceId == input.ProcessInstanceId ||
                    (this.ProcessInstanceId != null &&
                    this.ProcessInstanceId.Equals(input.ProcessInstanceId))
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
                if (this.JobDefinitionId != null)
                    hashCode = hashCode * 59 + this.JobDefinitionId.GetHashCode();
                if (this.ProcessDefinitionId != null)
                    hashCode = hashCode * 59 + this.ProcessDefinitionId.GetHashCode();
                if (this.ProcessInstanceId != null)
                    hashCode = hashCode * 59 + this.ProcessInstanceId.GetHashCode();
                if (this.ProcessDefinitionKey != null)
                    hashCode = hashCode * 59 + this.ProcessDefinitionKey.GetHashCode();
                if (this.ProcessDefinitionTenantId != null)
                    hashCode = hashCode * 59 + this.ProcessDefinitionTenantId.GetHashCode();
                if (this.ProcessDefinitionWithoutTenantId != null)
                    hashCode = hashCode * 59 + this.ProcessDefinitionWithoutTenantId.GetHashCode();
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
