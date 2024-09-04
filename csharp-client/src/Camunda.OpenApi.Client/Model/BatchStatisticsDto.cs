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
    /// BatchStatisticsDto
    /// </summary>
    [DataContract(Name = "BatchStatisticsDto")]
    public partial class BatchStatisticsDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BatchStatisticsDto" /> class.
        /// </summary>
        /// <param name="id">The id of the batch..</param>
        /// <param name="type">The type of the batch. See the [User Guide](https://docs.camunda.org/manual/7.21/user-guide/process-engine/batch/#creating-a-batch) for more information about batch types..</param>
        /// <param name="totalJobs">The total jobs of a batch is the number of batch execution jobs required to complete the batch..</param>
        /// <param name="jobsCreated">The number of batch execution jobs already created by the seed job..</param>
        /// <param name="batchJobsPerSeed">The number of batch execution jobs created per seed job invocation. The batch seed job is invoked until it has created all batch execution jobs required by the batch (see &#x60;totalJobs&#x60; property)..</param>
        /// <param name="invocationsPerBatchJob">Every batch execution job invokes the command executed by the batch &#x60;invocationsPerBatchJob&#x60; times. E.g., for a process instance migration batch this specifies the number of process instances which are migrated per batch execution job..</param>
        /// <param name="seedJobDefinitionId">The job definition id for the seed jobs of this batch..</param>
        /// <param name="monitorJobDefinitionId">The job definition id for the monitor jobs of this batch..</param>
        /// <param name="batchJobDefinitionId">The job definition id for the batch execution jobs of this batch..</param>
        /// <param name="suspended">Indicates whether this batch is suspended or not..</param>
        /// <param name="tenantId">The tenant id of the batch..</param>
        /// <param name="createUserId">The id of the user that created the batch..</param>
        /// <param name="startTime">The time the batch was started. Default format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;. For further information, please see the [documentation] (https://docs.camunda.org/manual/7.21/reference/rest/overview/date-format/).</param>
        /// <param name="executionStartTime">The time the batch execution was started, i.e., at least one batch job has been executed. Default format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;. For further information, please see the [documentation] (https://docs.camunda.org/manual/7.21/reference/rest/overview/date-format/).</param>
        /// <param name="remainingJobs">The number of remaining batch execution jobs. This does include failed batch execution jobs and batch execution jobs which still have to be created by the seed job..</param>
        /// <param name="completedJobs">The number of completed batch execution jobs. This does include aborted/deleted batch execution jobs..</param>
        /// <param name="failedJobs">The number of failed batch execution jobs. This does not include aborted or deleted batch execution jobs..</param>
        public BatchStatisticsDto(string id = default(string), string type = default(string), int? totalJobs = default(int?), int? jobsCreated = default(int?), int? batchJobsPerSeed = default(int?), int? invocationsPerBatchJob = default(int?), string seedJobDefinitionId = default(string), string monitorJobDefinitionId = default(string), string batchJobDefinitionId = default(string), bool? suspended = default(bool?), string tenantId = default(string), string createUserId = default(string), DateTime? startTime = default(DateTime?), DateTime? executionStartTime = default(DateTime?), int? remainingJobs = default(int?), int? completedJobs = default(int?), int? failedJobs = default(int?))
        {
            this.Id = id;
            this.Type = type;
            this.TotalJobs = totalJobs;
            this.JobsCreated = jobsCreated;
            this.BatchJobsPerSeed = batchJobsPerSeed;
            this.InvocationsPerBatchJob = invocationsPerBatchJob;
            this.SeedJobDefinitionId = seedJobDefinitionId;
            this.MonitorJobDefinitionId = monitorJobDefinitionId;
            this.BatchJobDefinitionId = batchJobDefinitionId;
            this.Suspended = suspended;
            this.TenantId = tenantId;
            this.CreateUserId = createUserId;
            this.StartTime = startTime;
            this.ExecutionStartTime = executionStartTime;
            this.RemainingJobs = remainingJobs;
            this.CompletedJobs = completedJobs;
            this.FailedJobs = failedJobs;
        }

        /// <summary>
        /// The id of the batch.
        /// </summary>
        /// <value>The id of the batch.</value>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// The type of the batch. See the [User Guide](https://docs.camunda.org/manual/7.21/user-guide/process-engine/batch/#creating-a-batch) for more information about batch types.
        /// </summary>
        /// <value>The type of the batch. See the [User Guide](https://docs.camunda.org/manual/7.21/user-guide/process-engine/batch/#creating-a-batch) for more information about batch types.</value>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// The total jobs of a batch is the number of batch execution jobs required to complete the batch.
        /// </summary>
        /// <value>The total jobs of a batch is the number of batch execution jobs required to complete the batch.</value>
        [DataMember(Name = "totalJobs", EmitDefaultValue = true)]
        public int? TotalJobs { get; set; }

        /// <summary>
        /// The number of batch execution jobs already created by the seed job.
        /// </summary>
        /// <value>The number of batch execution jobs already created by the seed job.</value>
        [DataMember(Name = "jobsCreated", EmitDefaultValue = true)]
        public int? JobsCreated { get; set; }

        /// <summary>
        /// The number of batch execution jobs created per seed job invocation. The batch seed job is invoked until it has created all batch execution jobs required by the batch (see &#x60;totalJobs&#x60; property).
        /// </summary>
        /// <value>The number of batch execution jobs created per seed job invocation. The batch seed job is invoked until it has created all batch execution jobs required by the batch (see &#x60;totalJobs&#x60; property).</value>
        [DataMember(Name = "batchJobsPerSeed", EmitDefaultValue = true)]
        public int? BatchJobsPerSeed { get; set; }

        /// <summary>
        /// Every batch execution job invokes the command executed by the batch &#x60;invocationsPerBatchJob&#x60; times. E.g., for a process instance migration batch this specifies the number of process instances which are migrated per batch execution job.
        /// </summary>
        /// <value>Every batch execution job invokes the command executed by the batch &#x60;invocationsPerBatchJob&#x60; times. E.g., for a process instance migration batch this specifies the number of process instances which are migrated per batch execution job.</value>
        [DataMember(Name = "invocationsPerBatchJob", EmitDefaultValue = true)]
        public int? InvocationsPerBatchJob { get; set; }

        /// <summary>
        /// The job definition id for the seed jobs of this batch.
        /// </summary>
        /// <value>The job definition id for the seed jobs of this batch.</value>
        [DataMember(Name = "seedJobDefinitionId", EmitDefaultValue = true)]
        public string SeedJobDefinitionId { get; set; }

        /// <summary>
        /// The job definition id for the monitor jobs of this batch.
        /// </summary>
        /// <value>The job definition id for the monitor jobs of this batch.</value>
        [DataMember(Name = "monitorJobDefinitionId", EmitDefaultValue = true)]
        public string MonitorJobDefinitionId { get; set; }

        /// <summary>
        /// The job definition id for the batch execution jobs of this batch.
        /// </summary>
        /// <value>The job definition id for the batch execution jobs of this batch.</value>
        [DataMember(Name = "batchJobDefinitionId", EmitDefaultValue = true)]
        public string BatchJobDefinitionId { get; set; }

        /// <summary>
        /// Indicates whether this batch is suspended or not.
        /// </summary>
        /// <value>Indicates whether this batch is suspended or not.</value>
        [DataMember(Name = "suspended", EmitDefaultValue = true)]
        public bool? Suspended { get; set; }

        /// <summary>
        /// The tenant id of the batch.
        /// </summary>
        /// <value>The tenant id of the batch.</value>
        [DataMember(Name = "tenantId", EmitDefaultValue = true)]
        public string TenantId { get; set; }

        /// <summary>
        /// The id of the user that created the batch.
        /// </summary>
        /// <value>The id of the user that created the batch.</value>
        [DataMember(Name = "createUserId", EmitDefaultValue = true)]
        public string CreateUserId { get; set; }

        /// <summary>
        /// The time the batch was started. Default format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;. For further information, please see the [documentation] (https://docs.camunda.org/manual/7.21/reference/rest/overview/date-format/)
        /// </summary>
        /// <value>The time the batch was started. Default format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;. For further information, please see the [documentation] (https://docs.camunda.org/manual/7.21/reference/rest/overview/date-format/)</value>
        [DataMember(Name = "startTime", EmitDefaultValue = true)]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// The time the batch execution was started, i.e., at least one batch job has been executed. Default format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;. For further information, please see the [documentation] (https://docs.camunda.org/manual/7.21/reference/rest/overview/date-format/)
        /// </summary>
        /// <value>The time the batch execution was started, i.e., at least one batch job has been executed. Default format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;. For further information, please see the [documentation] (https://docs.camunda.org/manual/7.21/reference/rest/overview/date-format/)</value>
        [DataMember(Name = "executionStartTime", EmitDefaultValue = true)]
        public DateTime? ExecutionStartTime { get; set; }

        /// <summary>
        /// The number of remaining batch execution jobs. This does include failed batch execution jobs and batch execution jobs which still have to be created by the seed job.
        /// </summary>
        /// <value>The number of remaining batch execution jobs. This does include failed batch execution jobs and batch execution jobs which still have to be created by the seed job.</value>
        [DataMember(Name = "remainingJobs", EmitDefaultValue = true)]
        public int? RemainingJobs { get; set; }

        /// <summary>
        /// The number of completed batch execution jobs. This does include aborted/deleted batch execution jobs.
        /// </summary>
        /// <value>The number of completed batch execution jobs. This does include aborted/deleted batch execution jobs.</value>
        [DataMember(Name = "completedJobs", EmitDefaultValue = true)]
        public int? CompletedJobs { get; set; }

        /// <summary>
        /// The number of failed batch execution jobs. This does not include aborted or deleted batch execution jobs.
        /// </summary>
        /// <value>The number of failed batch execution jobs. This does not include aborted or deleted batch execution jobs.</value>
        [DataMember(Name = "failedJobs", EmitDefaultValue = true)]
        public int? FailedJobs { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BatchStatisticsDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  TotalJobs: ").Append(TotalJobs).Append("\n");
            sb.Append("  JobsCreated: ").Append(JobsCreated).Append("\n");
            sb.Append("  BatchJobsPerSeed: ").Append(BatchJobsPerSeed).Append("\n");
            sb.Append("  InvocationsPerBatchJob: ").Append(InvocationsPerBatchJob).Append("\n");
            sb.Append("  SeedJobDefinitionId: ").Append(SeedJobDefinitionId).Append("\n");
            sb.Append("  MonitorJobDefinitionId: ").Append(MonitorJobDefinitionId).Append("\n");
            sb.Append("  BatchJobDefinitionId: ").Append(BatchJobDefinitionId).Append("\n");
            sb.Append("  Suspended: ").Append(Suspended).Append("\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  CreateUserId: ").Append(CreateUserId).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  ExecutionStartTime: ").Append(ExecutionStartTime).Append("\n");
            sb.Append("  RemainingJobs: ").Append(RemainingJobs).Append("\n");
            sb.Append("  CompletedJobs: ").Append(CompletedJobs).Append("\n");
            sb.Append("  FailedJobs: ").Append(FailedJobs).Append("\n");
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
