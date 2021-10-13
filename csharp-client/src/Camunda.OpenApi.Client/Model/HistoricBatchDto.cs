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
    /// HistoricBatchDto
    /// </summary>
    [DataContract(Name = "HistoricBatchDto")]
    public partial class HistoricBatchDto : IEquatable<HistoricBatchDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HistoricBatchDto" /> class.
        /// </summary>
        /// <param name="id">The id of the batch..</param>
        /// <param name="type">The type of the batch. See the [User Guide](https://docs.camunda.org/manual/7.16/user-guide/process-engine/batch/#creating-a-batch) for more information about batch types..</param>
        /// <param name="totalJobs"> The total jobs of a batch is the number of batch execution jobs required to complete the batch. .</param>
        /// <param name="batchJobsPerSeed"> The number of batch execution jobs created per seed job invocation. The batch seed job is invoked until it has created all batch execution jobs required by the batch (see &#x60;totalJobs&#x60; property). .</param>
        /// <param name="invocationsPerBatchJob"> Every batch execution job invokes the command executed by the batch &#x60;invocationsPerBatchJob&#x60; times. E.g., for a process instance migration batch this specifies the number of process instances which are migrated per batch execution job. .</param>
        /// <param name="seedJobDefinitionId">The job definition id for the seed jobs of this batch..</param>
        /// <param name="monitorJobDefinitionId">The job definition id for the monitor jobs of this batch..</param>
        /// <param name="batchJobDefinitionId">The job definition id for the batch execution jobs of this batch..</param>
        /// <param name="tenantId">The tenant id of the batch..</param>
        /// <param name="createUserId">The batch creator&#39;s user id..</param>
        /// <param name="startTime">The time the batch was started. Default format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;. For further information, please see the [documentation](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/).</param>
        /// <param name="endTime">The time the batch ended. Default format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;. For further information, please see the [documentation](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/).</param>
        /// <param name="removalTime">The time after which the historic batch should be removed by the History Cleanup job. Default format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;. For further information, please see the [documentation](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/).</param>
        public HistoricBatchDto(string id = default(string), string type = default(string), int? totalJobs = default(int?), int? batchJobsPerSeed = default(int?), int? invocationsPerBatchJob = default(int?), string seedJobDefinitionId = default(string), string monitorJobDefinitionId = default(string), string batchJobDefinitionId = default(string), string tenantId = default(string), string createUserId = default(string), DateTime? startTime = default(DateTime?), DateTime? endTime = default(DateTime?), DateTime? removalTime = default(DateTime?))
        {
            this.Id = id;
            this.Type = type;
            this.TotalJobs = totalJobs;
            this.BatchJobsPerSeed = batchJobsPerSeed;
            this.InvocationsPerBatchJob = invocationsPerBatchJob;
            this.SeedJobDefinitionId = seedJobDefinitionId;
            this.MonitorJobDefinitionId = monitorJobDefinitionId;
            this.BatchJobDefinitionId = batchJobDefinitionId;
            this.TenantId = tenantId;
            this.CreateUserId = createUserId;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.RemovalTime = removalTime;
        }

        /// <summary>
        /// The id of the batch.
        /// </summary>
        /// <value>The id of the batch.</value>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// The type of the batch. See the [User Guide](https://docs.camunda.org/manual/7.16/user-guide/process-engine/batch/#creating-a-batch) for more information about batch types.
        /// </summary>
        /// <value>The type of the batch. See the [User Guide](https://docs.camunda.org/manual/7.16/user-guide/process-engine/batch/#creating-a-batch) for more information about batch types.</value>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        ///  The total jobs of a batch is the number of batch execution jobs required to complete the batch. 
        /// </summary>
        /// <value> The total jobs of a batch is the number of batch execution jobs required to complete the batch. </value>
        [DataMember(Name = "totalJobs", EmitDefaultValue = true)]
        public int? TotalJobs { get; set; }

        /// <summary>
        ///  The number of batch execution jobs created per seed job invocation. The batch seed job is invoked until it has created all batch execution jobs required by the batch (see &#x60;totalJobs&#x60; property). 
        /// </summary>
        /// <value> The number of batch execution jobs created per seed job invocation. The batch seed job is invoked until it has created all batch execution jobs required by the batch (see &#x60;totalJobs&#x60; property). </value>
        [DataMember(Name = "batchJobsPerSeed", EmitDefaultValue = true)]
        public int? BatchJobsPerSeed { get; set; }

        /// <summary>
        ///  Every batch execution job invokes the command executed by the batch &#x60;invocationsPerBatchJob&#x60; times. E.g., for a process instance migration batch this specifies the number of process instances which are migrated per batch execution job. 
        /// </summary>
        /// <value> Every batch execution job invokes the command executed by the batch &#x60;invocationsPerBatchJob&#x60; times. E.g., for a process instance migration batch this specifies the number of process instances which are migrated per batch execution job. </value>
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
        /// The tenant id of the batch.
        /// </summary>
        /// <value>The tenant id of the batch.</value>
        [DataMember(Name = "tenantId", EmitDefaultValue = true)]
        public string TenantId { get; set; }

        /// <summary>
        /// The batch creator&#39;s user id.
        /// </summary>
        /// <value>The batch creator&#39;s user id.</value>
        [DataMember(Name = "createUserId", EmitDefaultValue = true)]
        public string CreateUserId { get; set; }

        /// <summary>
        /// The time the batch was started. Default format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;. For further information, please see the [documentation](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/)
        /// </summary>
        /// <value>The time the batch was started. Default format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;. For further information, please see the [documentation](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/)</value>
        [DataMember(Name = "startTime", EmitDefaultValue = true)]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// The time the batch ended. Default format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;. For further information, please see the [documentation](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/)
        /// </summary>
        /// <value>The time the batch ended. Default format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;. For further information, please see the [documentation](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/)</value>
        [DataMember(Name = "endTime", EmitDefaultValue = true)]
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// The time after which the historic batch should be removed by the History Cleanup job. Default format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;. For further information, please see the [documentation](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/)
        /// </summary>
        /// <value>The time after which the historic batch should be removed by the History Cleanup job. Default format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;. For further information, please see the [documentation](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/)</value>
        [DataMember(Name = "removalTime", EmitDefaultValue = true)]
        public DateTime? RemovalTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HistoricBatchDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  TotalJobs: ").Append(TotalJobs).Append("\n");
            sb.Append("  BatchJobsPerSeed: ").Append(BatchJobsPerSeed).Append("\n");
            sb.Append("  InvocationsPerBatchJob: ").Append(InvocationsPerBatchJob).Append("\n");
            sb.Append("  SeedJobDefinitionId: ").Append(SeedJobDefinitionId).Append("\n");
            sb.Append("  MonitorJobDefinitionId: ").Append(MonitorJobDefinitionId).Append("\n");
            sb.Append("  BatchJobDefinitionId: ").Append(BatchJobDefinitionId).Append("\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  CreateUserId: ").Append(CreateUserId).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  RemovalTime: ").Append(RemovalTime).Append("\n");
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
            return this.Equals(input as HistoricBatchDto);
        }

        /// <summary>
        /// Returns true if HistoricBatchDto instances are equal
        /// </summary>
        /// <param name="input">Instance of HistoricBatchDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HistoricBatchDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.TotalJobs == input.TotalJobs ||
                    (this.TotalJobs != null &&
                    this.TotalJobs.Equals(input.TotalJobs))
                ) && 
                (
                    this.BatchJobsPerSeed == input.BatchJobsPerSeed ||
                    (this.BatchJobsPerSeed != null &&
                    this.BatchJobsPerSeed.Equals(input.BatchJobsPerSeed))
                ) && 
                (
                    this.InvocationsPerBatchJob == input.InvocationsPerBatchJob ||
                    (this.InvocationsPerBatchJob != null &&
                    this.InvocationsPerBatchJob.Equals(input.InvocationsPerBatchJob))
                ) && 
                (
                    this.SeedJobDefinitionId == input.SeedJobDefinitionId ||
                    (this.SeedJobDefinitionId != null &&
                    this.SeedJobDefinitionId.Equals(input.SeedJobDefinitionId))
                ) && 
                (
                    this.MonitorJobDefinitionId == input.MonitorJobDefinitionId ||
                    (this.MonitorJobDefinitionId != null &&
                    this.MonitorJobDefinitionId.Equals(input.MonitorJobDefinitionId))
                ) && 
                (
                    this.BatchJobDefinitionId == input.BatchJobDefinitionId ||
                    (this.BatchJobDefinitionId != null &&
                    this.BatchJobDefinitionId.Equals(input.BatchJobDefinitionId))
                ) && 
                (
                    this.TenantId == input.TenantId ||
                    (this.TenantId != null &&
                    this.TenantId.Equals(input.TenantId))
                ) && 
                (
                    this.CreateUserId == input.CreateUserId ||
                    (this.CreateUserId != null &&
                    this.CreateUserId.Equals(input.CreateUserId))
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
                ) && 
                (
                    this.RemovalTime == input.RemovalTime ||
                    (this.RemovalTime != null &&
                    this.RemovalTime.Equals(input.RemovalTime))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.TotalJobs != null)
                    hashCode = hashCode * 59 + this.TotalJobs.GetHashCode();
                if (this.BatchJobsPerSeed != null)
                    hashCode = hashCode * 59 + this.BatchJobsPerSeed.GetHashCode();
                if (this.InvocationsPerBatchJob != null)
                    hashCode = hashCode * 59 + this.InvocationsPerBatchJob.GetHashCode();
                if (this.SeedJobDefinitionId != null)
                    hashCode = hashCode * 59 + this.SeedJobDefinitionId.GetHashCode();
                if (this.MonitorJobDefinitionId != null)
                    hashCode = hashCode * 59 + this.MonitorJobDefinitionId.GetHashCode();
                if (this.BatchJobDefinitionId != null)
                    hashCode = hashCode * 59 + this.BatchJobDefinitionId.GetHashCode();
                if (this.TenantId != null)
                    hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.CreateUserId != null)
                    hashCode = hashCode * 59 + this.CreateUserId.GetHashCode();
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null)
                    hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.RemovalTime != null)
                    hashCode = hashCode * 59 + this.RemovalTime.GetHashCode();
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
