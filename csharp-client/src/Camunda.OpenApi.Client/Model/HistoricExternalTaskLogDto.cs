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
    /// HistoricExternalTaskLogDto
    /// </summary>
    [DataContract(Name = "HistoricExternalTaskLogDto")]
    public partial class HistoricExternalTaskLogDto : IEquatable<HistoricExternalTaskLogDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HistoricExternalTaskLogDto" /> class.
        /// </summary>
        /// <param name="id">The id of the log entry..</param>
        /// <param name="externalTaskId">The id of the external task..</param>
        /// <param name="timestamp">The time when the log entry has been written..</param>
        /// <param name="topicName">The topic name of the associated external task..</param>
        /// <param name="workerId">The id of the worker that posessed the most recent lock..</param>
        /// <param name="retries">The number of retries the associated external task has left..</param>
        /// <param name="priority">The execution priority the external task had when the log entry was created..</param>
        /// <param name="errorMessage">The message of the error that occurred by executing the associated external task..</param>
        /// <param name="activityId">The id of the activity on which the associated external task was created..</param>
        /// <param name="activityInstanceId">The id of the activity instance on which the associated external task was created..</param>
        /// <param name="executionId">The execution id on which the associated external task was created..</param>
        /// <param name="processInstanceId">The id of the process instance on which the associated external task was created..</param>
        /// <param name="processDefinitionId">The id of the process definition which the associated external task belongs to..</param>
        /// <param name="processDefinitionKey">The key of the process definition which the associated external task belongs to..</param>
        /// <param name="tenantId">The id of the tenant that this historic external task log entry belongs to..</param>
        /// <param name="creationLog">A flag indicating whether this log represents the creation of the associated external task..</param>
        /// <param name="failureLog">A flag indicating whether this log represents the failed execution of the associated external task..</param>
        /// <param name="successLog">A flag indicating whether this log represents the successful execution of the associated external task..</param>
        /// <param name="deletionLog">A flag indicating whether this log represents the deletion of the associated external task..</param>
        /// <param name="removalTime">The time after which this log should be removed by the History Cleanup job. Default format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;.  For further information, please see the [documentation](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/).</param>
        /// <param name="rootProcessInstanceId">The process instance id of the root process instance that initiated the process containing this log..</param>
        public HistoricExternalTaskLogDto(string id = default(string), string externalTaskId = default(string), DateTime? timestamp = default(DateTime?), string topicName = default(string), string workerId = default(string), int? retries = default(int?), long? priority = default(long?), string errorMessage = default(string), string activityId = default(string), string activityInstanceId = default(string), string executionId = default(string), string processInstanceId = default(string), string processDefinitionId = default(string), string processDefinitionKey = default(string), string tenantId = default(string), bool? creationLog = default(bool?), bool? failureLog = default(bool?), bool? successLog = default(bool?), bool? deletionLog = default(bool?), DateTime? removalTime = default(DateTime?), string rootProcessInstanceId = default(string))
        {
            this.Id = id;
            this.ExternalTaskId = externalTaskId;
            this.Timestamp = timestamp;
            this.TopicName = topicName;
            this.WorkerId = workerId;
            this.Retries = retries;
            this.Priority = priority;
            this.ErrorMessage = errorMessage;
            this.ActivityId = activityId;
            this.ActivityInstanceId = activityInstanceId;
            this.ExecutionId = executionId;
            this.ProcessInstanceId = processInstanceId;
            this.ProcessDefinitionId = processDefinitionId;
            this.ProcessDefinitionKey = processDefinitionKey;
            this.TenantId = tenantId;
            this.CreationLog = creationLog;
            this.FailureLog = failureLog;
            this.SuccessLog = successLog;
            this.DeletionLog = deletionLog;
            this.RemovalTime = removalTime;
            this.RootProcessInstanceId = rootProcessInstanceId;
        }

        /// <summary>
        /// The id of the log entry.
        /// </summary>
        /// <value>The id of the log entry.</value>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// The id of the external task.
        /// </summary>
        /// <value>The id of the external task.</value>
        [DataMember(Name = "externalTaskId", EmitDefaultValue = true)]
        public string ExternalTaskId { get; set; }

        /// <summary>
        /// The time when the log entry has been written.
        /// </summary>
        /// <value>The time when the log entry has been written.</value>
        [DataMember(Name = "timestamp", EmitDefaultValue = true)]
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// The topic name of the associated external task.
        /// </summary>
        /// <value>The topic name of the associated external task.</value>
        [DataMember(Name = "topicName", EmitDefaultValue = true)]
        public string TopicName { get; set; }

        /// <summary>
        /// The id of the worker that posessed the most recent lock.
        /// </summary>
        /// <value>The id of the worker that posessed the most recent lock.</value>
        [DataMember(Name = "workerId", EmitDefaultValue = true)]
        public string WorkerId { get; set; }

        /// <summary>
        /// The number of retries the associated external task has left.
        /// </summary>
        /// <value>The number of retries the associated external task has left.</value>
        [DataMember(Name = "retries", EmitDefaultValue = true)]
        public int? Retries { get; set; }

        /// <summary>
        /// The execution priority the external task had when the log entry was created.
        /// </summary>
        /// <value>The execution priority the external task had when the log entry was created.</value>
        [DataMember(Name = "priority", EmitDefaultValue = true)]
        public long? Priority { get; set; }

        /// <summary>
        /// The message of the error that occurred by executing the associated external task.
        /// </summary>
        /// <value>The message of the error that occurred by executing the associated external task.</value>
        [DataMember(Name = "errorMessage", EmitDefaultValue = true)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The id of the activity on which the associated external task was created.
        /// </summary>
        /// <value>The id of the activity on which the associated external task was created.</value>
        [DataMember(Name = "activityId", EmitDefaultValue = true)]
        public string ActivityId { get; set; }

        /// <summary>
        /// The id of the activity instance on which the associated external task was created.
        /// </summary>
        /// <value>The id of the activity instance on which the associated external task was created.</value>
        [DataMember(Name = "activityInstanceId", EmitDefaultValue = true)]
        public string ActivityInstanceId { get; set; }

        /// <summary>
        /// The execution id on which the associated external task was created.
        /// </summary>
        /// <value>The execution id on which the associated external task was created.</value>
        [DataMember(Name = "executionId", EmitDefaultValue = true)]
        public string ExecutionId { get; set; }

        /// <summary>
        /// The id of the process instance on which the associated external task was created.
        /// </summary>
        /// <value>The id of the process instance on which the associated external task was created.</value>
        [DataMember(Name = "processInstanceId", EmitDefaultValue = true)]
        public string ProcessInstanceId { get; set; }

        /// <summary>
        /// The id of the process definition which the associated external task belongs to.
        /// </summary>
        /// <value>The id of the process definition which the associated external task belongs to.</value>
        [DataMember(Name = "processDefinitionId", EmitDefaultValue = true)]
        public string ProcessDefinitionId { get; set; }

        /// <summary>
        /// The key of the process definition which the associated external task belongs to.
        /// </summary>
        /// <value>The key of the process definition which the associated external task belongs to.</value>
        [DataMember(Name = "processDefinitionKey", EmitDefaultValue = true)]
        public string ProcessDefinitionKey { get; set; }

        /// <summary>
        /// The id of the tenant that this historic external task log entry belongs to.
        /// </summary>
        /// <value>The id of the tenant that this historic external task log entry belongs to.</value>
        [DataMember(Name = "tenantId", EmitDefaultValue = true)]
        public string TenantId { get; set; }

        /// <summary>
        /// A flag indicating whether this log represents the creation of the associated external task.
        /// </summary>
        /// <value>A flag indicating whether this log represents the creation of the associated external task.</value>
        [DataMember(Name = "creationLog", EmitDefaultValue = true)]
        public bool? CreationLog { get; set; }

        /// <summary>
        /// A flag indicating whether this log represents the failed execution of the associated external task.
        /// </summary>
        /// <value>A flag indicating whether this log represents the failed execution of the associated external task.</value>
        [DataMember(Name = "failureLog", EmitDefaultValue = true)]
        public bool? FailureLog { get; set; }

        /// <summary>
        /// A flag indicating whether this log represents the successful execution of the associated external task.
        /// </summary>
        /// <value>A flag indicating whether this log represents the successful execution of the associated external task.</value>
        [DataMember(Name = "successLog", EmitDefaultValue = true)]
        public bool? SuccessLog { get; set; }

        /// <summary>
        /// A flag indicating whether this log represents the deletion of the associated external task.
        /// </summary>
        /// <value>A flag indicating whether this log represents the deletion of the associated external task.</value>
        [DataMember(Name = "deletionLog", EmitDefaultValue = true)]
        public bool? DeletionLog { get; set; }

        /// <summary>
        /// The time after which this log should be removed by the History Cleanup job. Default format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;.  For further information, please see the [documentation](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/)
        /// </summary>
        /// <value>The time after which this log should be removed by the History Cleanup job. Default format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;.  For further information, please see the [documentation](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/)</value>
        [DataMember(Name = "removalTime", EmitDefaultValue = true)]
        public DateTime? RemovalTime { get; set; }

        /// <summary>
        /// The process instance id of the root process instance that initiated the process containing this log.
        /// </summary>
        /// <value>The process instance id of the root process instance that initiated the process containing this log.</value>
        [DataMember(Name = "rootProcessInstanceId", EmitDefaultValue = true)]
        public string RootProcessInstanceId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HistoricExternalTaskLogDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ExternalTaskId: ").Append(ExternalTaskId).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  TopicName: ").Append(TopicName).Append("\n");
            sb.Append("  WorkerId: ").Append(WorkerId).Append("\n");
            sb.Append("  Retries: ").Append(Retries).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
            sb.Append("  ActivityId: ").Append(ActivityId).Append("\n");
            sb.Append("  ActivityInstanceId: ").Append(ActivityInstanceId).Append("\n");
            sb.Append("  ExecutionId: ").Append(ExecutionId).Append("\n");
            sb.Append("  ProcessInstanceId: ").Append(ProcessInstanceId).Append("\n");
            sb.Append("  ProcessDefinitionId: ").Append(ProcessDefinitionId).Append("\n");
            sb.Append("  ProcessDefinitionKey: ").Append(ProcessDefinitionKey).Append("\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  CreationLog: ").Append(CreationLog).Append("\n");
            sb.Append("  FailureLog: ").Append(FailureLog).Append("\n");
            sb.Append("  SuccessLog: ").Append(SuccessLog).Append("\n");
            sb.Append("  DeletionLog: ").Append(DeletionLog).Append("\n");
            sb.Append("  RemovalTime: ").Append(RemovalTime).Append("\n");
            sb.Append("  RootProcessInstanceId: ").Append(RootProcessInstanceId).Append("\n");
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
            return this.Equals(input as HistoricExternalTaskLogDto);
        }

        /// <summary>
        /// Returns true if HistoricExternalTaskLogDto instances are equal
        /// </summary>
        /// <param name="input">Instance of HistoricExternalTaskLogDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HistoricExternalTaskLogDto input)
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
                    this.ExternalTaskId == input.ExternalTaskId ||
                    (this.ExternalTaskId != null &&
                    this.ExternalTaskId.Equals(input.ExternalTaskId))
                ) && 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
                ) && 
                (
                    this.TopicName == input.TopicName ||
                    (this.TopicName != null &&
                    this.TopicName.Equals(input.TopicName))
                ) && 
                (
                    this.WorkerId == input.WorkerId ||
                    (this.WorkerId != null &&
                    this.WorkerId.Equals(input.WorkerId))
                ) && 
                (
                    this.Retries == input.Retries ||
                    (this.Retries != null &&
                    this.Retries.Equals(input.Retries))
                ) && 
                (
                    this.Priority == input.Priority ||
                    (this.Priority != null &&
                    this.Priority.Equals(input.Priority))
                ) && 
                (
                    this.ErrorMessage == input.ErrorMessage ||
                    (this.ErrorMessage != null &&
                    this.ErrorMessage.Equals(input.ErrorMessage))
                ) && 
                (
                    this.ActivityId == input.ActivityId ||
                    (this.ActivityId != null &&
                    this.ActivityId.Equals(input.ActivityId))
                ) && 
                (
                    this.ActivityInstanceId == input.ActivityInstanceId ||
                    (this.ActivityInstanceId != null &&
                    this.ActivityInstanceId.Equals(input.ActivityInstanceId))
                ) && 
                (
                    this.ExecutionId == input.ExecutionId ||
                    (this.ExecutionId != null &&
                    this.ExecutionId.Equals(input.ExecutionId))
                ) && 
                (
                    this.ProcessInstanceId == input.ProcessInstanceId ||
                    (this.ProcessInstanceId != null &&
                    this.ProcessInstanceId.Equals(input.ProcessInstanceId))
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
                    this.TenantId == input.TenantId ||
                    (this.TenantId != null &&
                    this.TenantId.Equals(input.TenantId))
                ) && 
                (
                    this.CreationLog == input.CreationLog ||
                    (this.CreationLog != null &&
                    this.CreationLog.Equals(input.CreationLog))
                ) && 
                (
                    this.FailureLog == input.FailureLog ||
                    (this.FailureLog != null &&
                    this.FailureLog.Equals(input.FailureLog))
                ) && 
                (
                    this.SuccessLog == input.SuccessLog ||
                    (this.SuccessLog != null &&
                    this.SuccessLog.Equals(input.SuccessLog))
                ) && 
                (
                    this.DeletionLog == input.DeletionLog ||
                    (this.DeletionLog != null &&
                    this.DeletionLog.Equals(input.DeletionLog))
                ) && 
                (
                    this.RemovalTime == input.RemovalTime ||
                    (this.RemovalTime != null &&
                    this.RemovalTime.Equals(input.RemovalTime))
                ) && 
                (
                    this.RootProcessInstanceId == input.RootProcessInstanceId ||
                    (this.RootProcessInstanceId != null &&
                    this.RootProcessInstanceId.Equals(input.RootProcessInstanceId))
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
                if (this.ExternalTaskId != null)
                    hashCode = hashCode * 59 + this.ExternalTaskId.GetHashCode();
                if (this.Timestamp != null)
                    hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
                if (this.TopicName != null)
                    hashCode = hashCode * 59 + this.TopicName.GetHashCode();
                if (this.WorkerId != null)
                    hashCode = hashCode * 59 + this.WorkerId.GetHashCode();
                if (this.Retries != null)
                    hashCode = hashCode * 59 + this.Retries.GetHashCode();
                if (this.Priority != null)
                    hashCode = hashCode * 59 + this.Priority.GetHashCode();
                if (this.ErrorMessage != null)
                    hashCode = hashCode * 59 + this.ErrorMessage.GetHashCode();
                if (this.ActivityId != null)
                    hashCode = hashCode * 59 + this.ActivityId.GetHashCode();
                if (this.ActivityInstanceId != null)
                    hashCode = hashCode * 59 + this.ActivityInstanceId.GetHashCode();
                if (this.ExecutionId != null)
                    hashCode = hashCode * 59 + this.ExecutionId.GetHashCode();
                if (this.ProcessInstanceId != null)
                    hashCode = hashCode * 59 + this.ProcessInstanceId.GetHashCode();
                if (this.ProcessDefinitionId != null)
                    hashCode = hashCode * 59 + this.ProcessDefinitionId.GetHashCode();
                if (this.ProcessDefinitionKey != null)
                    hashCode = hashCode * 59 + this.ProcessDefinitionKey.GetHashCode();
                if (this.TenantId != null)
                    hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.CreationLog != null)
                    hashCode = hashCode * 59 + this.CreationLog.GetHashCode();
                if (this.FailureLog != null)
                    hashCode = hashCode * 59 + this.FailureLog.GetHashCode();
                if (this.SuccessLog != null)
                    hashCode = hashCode * 59 + this.SuccessLog.GetHashCode();
                if (this.DeletionLog != null)
                    hashCode = hashCode * 59 + this.DeletionLog.GetHashCode();
                if (this.RemovalTime != null)
                    hashCode = hashCode * 59 + this.RemovalTime.GetHashCode();
                if (this.RootProcessInstanceId != null)
                    hashCode = hashCode * 59 + this.RootProcessInstanceId.GetHashCode();
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
