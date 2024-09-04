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
    /// JobDto
    /// </summary>
    [DataContract(Name = "JobDto")]
    public partial class JobDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JobDto" /> class.
        /// </summary>
        /// <param name="id">The id of the job..</param>
        /// <param name="jobDefinitionId">The id of the associated job definition..</param>
        /// <param name="dueDate">The date on which this job is supposed to be processed..</param>
        /// <param name="processInstanceId">The id of the process instance which execution created the job..</param>
        /// <param name="executionId">The specific execution id on which the job was created..</param>
        /// <param name="processDefinitionId">The id of the process definition which this job belongs to..</param>
        /// <param name="processDefinitionKey">The key of the process definition which this job belongs to..</param>
        /// <param name="retries">The number of retries this job has left..</param>
        /// <param name="exceptionMessage">The message of the exception that occurred, the last time the job was executed. Is null when no exception occurred..</param>
        /// <param name="failedActivityId">The id of the activity on which the last exception occurred, the last time the job was executed. Is null when no exception occurred..</param>
        /// <param name="suspended">A flag indicating whether the job is suspended or not..</param>
        /// <param name="priority">The job&#39;s priority for execution..</param>
        /// <param name="tenantId">The id of the tenant which this job belongs to..</param>
        /// <param name="createTime">The date on which this job has been created..</param>
        public JobDto(string id = default(string), string jobDefinitionId = default(string), DateTime? dueDate = default(DateTime?), string processInstanceId = default(string), string executionId = default(string), string processDefinitionId = default(string), string processDefinitionKey = default(string), int? retries = default(int?), string exceptionMessage = default(string), string failedActivityId = default(string), bool? suspended = default(bool?), long? priority = default(long?), string tenantId = default(string), DateTime? createTime = default(DateTime?))
        {
            this.Id = id;
            this.JobDefinitionId = jobDefinitionId;
            this.DueDate = dueDate;
            this.ProcessInstanceId = processInstanceId;
            this.ExecutionId = executionId;
            this.ProcessDefinitionId = processDefinitionId;
            this.ProcessDefinitionKey = processDefinitionKey;
            this.Retries = retries;
            this.ExceptionMessage = exceptionMessage;
            this.FailedActivityId = failedActivityId;
            this.Suspended = suspended;
            this.Priority = priority;
            this.TenantId = tenantId;
            this.CreateTime = createTime;
        }

        /// <summary>
        /// The id of the job.
        /// </summary>
        /// <value>The id of the job.</value>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// The id of the associated job definition.
        /// </summary>
        /// <value>The id of the associated job definition.</value>
        [DataMember(Name = "jobDefinitionId", EmitDefaultValue = true)]
        public string JobDefinitionId { get; set; }

        /// <summary>
        /// The date on which this job is supposed to be processed.
        /// </summary>
        /// <value>The date on which this job is supposed to be processed.</value>
        [DataMember(Name = "dueDate", EmitDefaultValue = true)]
        public DateTime? DueDate { get; set; }

        /// <summary>
        /// The id of the process instance which execution created the job.
        /// </summary>
        /// <value>The id of the process instance which execution created the job.</value>
        [DataMember(Name = "processInstanceId", EmitDefaultValue = true)]
        public string ProcessInstanceId { get; set; }

        /// <summary>
        /// The specific execution id on which the job was created.
        /// </summary>
        /// <value>The specific execution id on which the job was created.</value>
        [DataMember(Name = "executionId", EmitDefaultValue = true)]
        public string ExecutionId { get; set; }

        /// <summary>
        /// The id of the process definition which this job belongs to.
        /// </summary>
        /// <value>The id of the process definition which this job belongs to.</value>
        [DataMember(Name = "processDefinitionId", EmitDefaultValue = true)]
        public string ProcessDefinitionId { get; set; }

        /// <summary>
        /// The key of the process definition which this job belongs to.
        /// </summary>
        /// <value>The key of the process definition which this job belongs to.</value>
        [DataMember(Name = "processDefinitionKey", EmitDefaultValue = true)]
        public string ProcessDefinitionKey { get; set; }

        /// <summary>
        /// The number of retries this job has left.
        /// </summary>
        /// <value>The number of retries this job has left.</value>
        [DataMember(Name = "retries", EmitDefaultValue = true)]
        public int? Retries { get; set; }

        /// <summary>
        /// The message of the exception that occurred, the last time the job was executed. Is null when no exception occurred.
        /// </summary>
        /// <value>The message of the exception that occurred, the last time the job was executed. Is null when no exception occurred.</value>
        [DataMember(Name = "exceptionMessage", EmitDefaultValue = true)]
        public string ExceptionMessage { get; set; }

        /// <summary>
        /// The id of the activity on which the last exception occurred, the last time the job was executed. Is null when no exception occurred.
        /// </summary>
        /// <value>The id of the activity on which the last exception occurred, the last time the job was executed. Is null when no exception occurred.</value>
        [DataMember(Name = "failedActivityId", EmitDefaultValue = true)]
        public string FailedActivityId { get; set; }

        /// <summary>
        /// A flag indicating whether the job is suspended or not.
        /// </summary>
        /// <value>A flag indicating whether the job is suspended or not.</value>
        [DataMember(Name = "suspended", EmitDefaultValue = true)]
        public bool? Suspended { get; set; }

        /// <summary>
        /// The job&#39;s priority for execution.
        /// </summary>
        /// <value>The job&#39;s priority for execution.</value>
        [DataMember(Name = "priority", EmitDefaultValue = true)]
        public long? Priority { get; set; }

        /// <summary>
        /// The id of the tenant which this job belongs to.
        /// </summary>
        /// <value>The id of the tenant which this job belongs to.</value>
        [DataMember(Name = "tenantId", EmitDefaultValue = true)]
        public string TenantId { get; set; }

        /// <summary>
        /// The date on which this job has been created.
        /// </summary>
        /// <value>The date on which this job has been created.</value>
        [DataMember(Name = "createTime", EmitDefaultValue = true)]
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class JobDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  JobDefinitionId: ").Append(JobDefinitionId).Append("\n");
            sb.Append("  DueDate: ").Append(DueDate).Append("\n");
            sb.Append("  ProcessInstanceId: ").Append(ProcessInstanceId).Append("\n");
            sb.Append("  ExecutionId: ").Append(ExecutionId).Append("\n");
            sb.Append("  ProcessDefinitionId: ").Append(ProcessDefinitionId).Append("\n");
            sb.Append("  ProcessDefinitionKey: ").Append(ProcessDefinitionKey).Append("\n");
            sb.Append("  Retries: ").Append(Retries).Append("\n");
            sb.Append("  ExceptionMessage: ").Append(ExceptionMessage).Append("\n");
            sb.Append("  FailedActivityId: ").Append(FailedActivityId).Append("\n");
            sb.Append("  Suspended: ").Append(Suspended).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  CreateTime: ").Append(CreateTime).Append("\n");
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
