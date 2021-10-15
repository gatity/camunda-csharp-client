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
    /// A Job definition query which defines a list of Job definitions
    /// </summary>
    [DataContract(Name = "JobDefinitionQueryDto")]
    public partial class JobDefinitionQueryDto : IEquatable<JobDefinitionQueryDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JobDefinitionQueryDto" /> class.
        /// </summary>
        /// <param name="jobDefinitionId">Filter by job definition id..</param>
        /// <param name="activityIdIn">Only include job definitions which belong to one of the passed activity ids..</param>
        /// <param name="processDefinitionId">Only include job definitions which exist for the given process definition id..</param>
        /// <param name="processDefinitionKey">Only include job definitions which exist for the given process definition key..</param>
        /// <param name="jobType">Only include job definitions which exist for the given job type. See the [User Guide](https://docs.camunda.org/manual/7.16/user-guide/process-engine/the-job-executor/#job-creation) for more information about job types..</param>
        /// <param name="jobConfiguration">Only include job definitions which exist for the given job configuration. For example: for timer jobs it is the timer configuration..</param>
        /// <param name="active">Only include active job definitions. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior..</param>
        /// <param name="suspended">Only include suspended job definitions. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior..</param>
        /// <param name="withOverridingJobPriority">Only include job definitions that have an overriding job priority defined. The only effective value is &#x60;true&#x60;. If set to &#x60;false&#x60;, this filter is not applied..</param>
        /// <param name="tenantIdIn">Only include job definitions which belong to one of the passed tenant ids..</param>
        /// <param name="withoutTenantId">Only include job definitions which belong to no tenant. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior..</param>
        /// <param name="includeJobDefinitionsWithoutTenantId">Include job definitions which belong to no tenant. Can be used in combination with &#x60;tenantIdIn&#x60;. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior..</param>
        /// <param name="sorting">An array of criteria to sort the result by. Each element of the array is                        an object that specifies one ordering. The position in the array                        identifies the rank of an ordering, i.e., whether it is primary, secondary,                        etc. Sorting has no effect for &#x60;count&#x60; endpoints..</param>
        public JobDefinitionQueryDto(string jobDefinitionId = default(string), List<string> activityIdIn = default(List<string>), string processDefinitionId = default(string), string processDefinitionKey = default(string), string jobType = default(string), string jobConfiguration = default(string), bool? active = default(bool?), bool? suspended = default(bool?), bool? withOverridingJobPriority = default(bool?), List<string> tenantIdIn = default(List<string>), bool? withoutTenantId = default(bool?), bool? includeJobDefinitionsWithoutTenantId = default(bool?), List<JobDefinitionQueryDtoSorting> sorting = default(List<JobDefinitionQueryDtoSorting>))
        {
            this.JobDefinitionId = jobDefinitionId;
            this.ActivityIdIn = activityIdIn;
            this.ProcessDefinitionId = processDefinitionId;
            this.ProcessDefinitionKey = processDefinitionKey;
            this.JobType = jobType;
            this.JobConfiguration = jobConfiguration;
            this.Active = active;
            this.Suspended = suspended;
            this.WithOverridingJobPriority = withOverridingJobPriority;
            this.TenantIdIn = tenantIdIn;
            this.WithoutTenantId = withoutTenantId;
            this.IncludeJobDefinitionsWithoutTenantId = includeJobDefinitionsWithoutTenantId;
            this.Sorting = sorting;
        }

        /// <summary>
        /// Filter by job definition id.
        /// </summary>
        /// <value>Filter by job definition id.</value>
        [DataMember(Name = "jobDefinitionId", EmitDefaultValue = true)]
        public string JobDefinitionId { get; set; }

        /// <summary>
        /// Only include job definitions which belong to one of the passed activity ids.
        /// </summary>
        /// <value>Only include job definitions which belong to one of the passed activity ids.</value>
        [DataMember(Name = "activityIdIn", EmitDefaultValue = true)]
        public List<string> ActivityIdIn { get; set; }

        /// <summary>
        /// Only include job definitions which exist for the given process definition id.
        /// </summary>
        /// <value>Only include job definitions which exist for the given process definition id.</value>
        [DataMember(Name = "processDefinitionId", EmitDefaultValue = true)]
        public string ProcessDefinitionId { get; set; }

        /// <summary>
        /// Only include job definitions which exist for the given process definition key.
        /// </summary>
        /// <value>Only include job definitions which exist for the given process definition key.</value>
        [DataMember(Name = "processDefinitionKey", EmitDefaultValue = true)]
        public string ProcessDefinitionKey { get; set; }

        /// <summary>
        /// Only include job definitions which exist for the given job type. See the [User Guide](https://docs.camunda.org/manual/7.16/user-guide/process-engine/the-job-executor/#job-creation) for more information about job types.
        /// </summary>
        /// <value>Only include job definitions which exist for the given job type. See the [User Guide](https://docs.camunda.org/manual/7.16/user-guide/process-engine/the-job-executor/#job-creation) for more information about job types.</value>
        [DataMember(Name = "jobType", EmitDefaultValue = true)]
        public string JobType { get; set; }

        /// <summary>
        /// Only include job definitions which exist for the given job configuration. For example: for timer jobs it is the timer configuration.
        /// </summary>
        /// <value>Only include job definitions which exist for the given job configuration. For example: for timer jobs it is the timer configuration.</value>
        [DataMember(Name = "jobConfiguration", EmitDefaultValue = true)]
        public string JobConfiguration { get; set; }

        /// <summary>
        /// Only include active job definitions. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior.
        /// </summary>
        /// <value>Only include active job definitions. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior.</value>
        [DataMember(Name = "active", EmitDefaultValue = true)]
        public bool? Active { get; set; }

        /// <summary>
        /// Only include suspended job definitions. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior.
        /// </summary>
        /// <value>Only include suspended job definitions. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior.</value>
        [DataMember(Name = "suspended", EmitDefaultValue = true)]
        public bool? Suspended { get; set; }

        /// <summary>
        /// Only include job definitions that have an overriding job priority defined. The only effective value is &#x60;true&#x60;. If set to &#x60;false&#x60;, this filter is not applied.
        /// </summary>
        /// <value>Only include job definitions that have an overriding job priority defined. The only effective value is &#x60;true&#x60;. If set to &#x60;false&#x60;, this filter is not applied.</value>
        [DataMember(Name = "withOverridingJobPriority", EmitDefaultValue = true)]
        public bool? WithOverridingJobPriority { get; set; }

        /// <summary>
        /// Only include job definitions which belong to one of the passed tenant ids.
        /// </summary>
        /// <value>Only include job definitions which belong to one of the passed tenant ids.</value>
        [DataMember(Name = "tenantIdIn", EmitDefaultValue = true)]
        public List<string> TenantIdIn { get; set; }

        /// <summary>
        /// Only include job definitions which belong to no tenant. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior.
        /// </summary>
        /// <value>Only include job definitions which belong to no tenant. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior.</value>
        [DataMember(Name = "withoutTenantId", EmitDefaultValue = true)]
        public bool? WithoutTenantId { get; set; }

        /// <summary>
        /// Include job definitions which belong to no tenant. Can be used in combination with &#x60;tenantIdIn&#x60;. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior.
        /// </summary>
        /// <value>Include job definitions which belong to no tenant. Can be used in combination with &#x60;tenantIdIn&#x60;. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior.</value>
        [DataMember(Name = "includeJobDefinitionsWithoutTenantId", EmitDefaultValue = true)]
        public bool? IncludeJobDefinitionsWithoutTenantId { get; set; }

        /// <summary>
        /// An array of criteria to sort the result by. Each element of the array is                        an object that specifies one ordering. The position in the array                        identifies the rank of an ordering, i.e., whether it is primary, secondary,                        etc. Sorting has no effect for &#x60;count&#x60; endpoints.
        /// </summary>
        /// <value>An array of criteria to sort the result by. Each element of the array is                        an object that specifies one ordering. The position in the array                        identifies the rank of an ordering, i.e., whether it is primary, secondary,                        etc. Sorting has no effect for &#x60;count&#x60; endpoints.</value>
        [DataMember(Name = "sorting", EmitDefaultValue = true)]
        public List<JobDefinitionQueryDtoSorting> Sorting { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JobDefinitionQueryDto {\n");
            sb.Append("  JobDefinitionId: ").Append(JobDefinitionId).Append("\n");
            sb.Append("  ActivityIdIn: ").Append(ActivityIdIn).Append("\n");
            sb.Append("  ProcessDefinitionId: ").Append(ProcessDefinitionId).Append("\n");
            sb.Append("  ProcessDefinitionKey: ").Append(ProcessDefinitionKey).Append("\n");
            sb.Append("  JobType: ").Append(JobType).Append("\n");
            sb.Append("  JobConfiguration: ").Append(JobConfiguration).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  Suspended: ").Append(Suspended).Append("\n");
            sb.Append("  WithOverridingJobPriority: ").Append(WithOverridingJobPriority).Append("\n");
            sb.Append("  TenantIdIn: ").Append(TenantIdIn).Append("\n");
            sb.Append("  WithoutTenantId: ").Append(WithoutTenantId).Append("\n");
            sb.Append("  IncludeJobDefinitionsWithoutTenantId: ").Append(IncludeJobDefinitionsWithoutTenantId).Append("\n");
            sb.Append("  Sorting: ").Append(Sorting).Append("\n");
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
            return this.Equals(input as JobDefinitionQueryDto);
        }

        /// <summary>
        /// Returns true if JobDefinitionQueryDto instances are equal
        /// </summary>
        /// <param name="input">Instance of JobDefinitionQueryDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JobDefinitionQueryDto input)
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
                    this.ActivityIdIn == input.ActivityIdIn ||
                    this.ActivityIdIn != null &&
                    input.ActivityIdIn != null &&
                    this.ActivityIdIn.SequenceEqual(input.ActivityIdIn)
                ) && 
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
                    this.JobType == input.JobType ||
                    (this.JobType != null &&
                    this.JobType.Equals(input.JobType))
                ) && 
                (
                    this.JobConfiguration == input.JobConfiguration ||
                    (this.JobConfiguration != null &&
                    this.JobConfiguration.Equals(input.JobConfiguration))
                ) && 
                (
                    this.Active == input.Active ||
                    (this.Active != null &&
                    this.Active.Equals(input.Active))
                ) && 
                (
                    this.Suspended == input.Suspended ||
                    (this.Suspended != null &&
                    this.Suspended.Equals(input.Suspended))
                ) && 
                (
                    this.WithOverridingJobPriority == input.WithOverridingJobPriority ||
                    (this.WithOverridingJobPriority != null &&
                    this.WithOverridingJobPriority.Equals(input.WithOverridingJobPriority))
                ) && 
                (
                    this.TenantIdIn == input.TenantIdIn ||
                    this.TenantIdIn != null &&
                    input.TenantIdIn != null &&
                    this.TenantIdIn.SequenceEqual(input.TenantIdIn)
                ) && 
                (
                    this.WithoutTenantId == input.WithoutTenantId ||
                    (this.WithoutTenantId != null &&
                    this.WithoutTenantId.Equals(input.WithoutTenantId))
                ) && 
                (
                    this.IncludeJobDefinitionsWithoutTenantId == input.IncludeJobDefinitionsWithoutTenantId ||
                    (this.IncludeJobDefinitionsWithoutTenantId != null &&
                    this.IncludeJobDefinitionsWithoutTenantId.Equals(input.IncludeJobDefinitionsWithoutTenantId))
                ) && 
                (
                    this.Sorting == input.Sorting ||
                    this.Sorting != null &&
                    input.Sorting != null &&
                    this.Sorting.SequenceEqual(input.Sorting)
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
                if (this.ActivityIdIn != null)
                    hashCode = hashCode * 59 + this.ActivityIdIn.GetHashCode();
                if (this.ProcessDefinitionId != null)
                    hashCode = hashCode * 59 + this.ProcessDefinitionId.GetHashCode();
                if (this.ProcessDefinitionKey != null)
                    hashCode = hashCode * 59 + this.ProcessDefinitionKey.GetHashCode();
                if (this.JobType != null)
                    hashCode = hashCode * 59 + this.JobType.GetHashCode();
                if (this.JobConfiguration != null)
                    hashCode = hashCode * 59 + this.JobConfiguration.GetHashCode();
                if (this.Active != null)
                    hashCode = hashCode * 59 + this.Active.GetHashCode();
                if (this.Suspended != null)
                    hashCode = hashCode * 59 + this.Suspended.GetHashCode();
                if (this.WithOverridingJobPriority != null)
                    hashCode = hashCode * 59 + this.WithOverridingJobPriority.GetHashCode();
                if (this.TenantIdIn != null)
                    hashCode = hashCode * 59 + this.TenantIdIn.GetHashCode();
                if (this.WithoutTenantId != null)
                    hashCode = hashCode * 59 + this.WithoutTenantId.GetHashCode();
                if (this.IncludeJobDefinitionsWithoutTenantId != null)
                    hashCode = hashCode * 59 + this.IncludeJobDefinitionsWithoutTenantId.GetHashCode();
                if (this.Sorting != null)
                    hashCode = hashCode * 59 + this.Sorting.GetHashCode();
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
