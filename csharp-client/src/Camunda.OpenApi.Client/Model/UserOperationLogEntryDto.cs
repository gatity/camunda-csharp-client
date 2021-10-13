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
    /// UserOperationLogEntryDto
    /// </summary>
    [DataContract(Name = "UserOperationLogEntryDto")]
    public partial class UserOperationLogEntryDto : IEquatable<UserOperationLogEntryDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserOperationLogEntryDto" /> class.
        /// </summary>
        /// <param name="id">The unique identifier of this log entry..</param>
        /// <param name="userId">The user who performed this operation..</param>
        /// <param name="timestamp">Timestamp of this operation..</param>
        /// <param name="operationId">The unique identifier of this operation. A composite operation that changes multiple properties has a common &#x60;operationId&#x60;..</param>
        /// <param name="operationType">The type of this operation, e.g., &#x60;Assign&#x60;, &#x60;Claim&#x60; and so on..</param>
        /// <param name="entityType">The type of the entity on which this operation was executed, e.g., &#x60;Task&#x60; or &#x60;Attachment&#x60;..</param>
        /// <param name="category">The name of the category this operation was associated with, e.g., &#x60;TaskWorker&#x60; or &#x60;Admin&#x60;..</param>
        /// <param name="annotation">An arbitrary annotation set by a user for auditing reasons..</param>
        /// <param name="property">The property changed by this operation..</param>
        /// <param name="orgValue">The original value of the changed property..</param>
        /// <param name="newValue">The new value of the changed property..</param>
        /// <param name="deploymentId">If not &#x60;null&#x60;, the operation is restricted to entities in relation to this deployment..</param>
        /// <param name="processDefinitionId">If not &#x60;null&#x60;, the operation is restricted to entities in relation to this process definition..</param>
        /// <param name="processDefinitionKey">If not &#x60;null&#x60;, the operation is restricted to entities in relation to process definitions with this key..</param>
        /// <param name="processInstanceId">If not &#x60;null&#x60;, the operation is restricted to entities in relation to this process instance..</param>
        /// <param name="executionId">If not &#x60;null&#x60;, the operation is restricted to entities in relation to this execution..</param>
        /// <param name="caseDefinitionId">If not &#x60;null&#x60;, the operation is restricted to entities in relation to this case definition..</param>
        /// <param name="caseInstanceId">If not &#x60;null&#x60;, the operation is restricted to entities in relation to this case instance..</param>
        /// <param name="caseExecutionId">If not &#x60;null&#x60;, the operation is restricted to entities in relation to this case execution..</param>
        /// <param name="taskId">If not &#x60;null&#x60;, the operation is restricted to entities in relation to this task..</param>
        /// <param name="externalTaskId">If not &#x60;null&#x60;, the operation is restricted to entities in relation to this external task..</param>
        /// <param name="batchId">If not &#x60;null&#x60;, the operation is restricted to entities in relation to this batch..</param>
        /// <param name="jobId">If not &#x60;null&#x60;, the operation is restricted to entities in relation to this job..</param>
        /// <param name="jobDefinitionId">If not &#x60;null&#x60;, the operation is restricted to entities in relation to this job definition..</param>
        /// <param name="removalTime">The time after which the entry should be removed by the History Cleanup job. [Default format](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/) &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;..</param>
        /// <param name="rootProcessInstanceId">The process instance id of the root process instance that initiated the process containing this entry..</param>
        public UserOperationLogEntryDto(string id = default(string), string userId = default(string), DateTime? timestamp = default(DateTime?), string operationId = default(string), string operationType = default(string), string entityType = default(string), string category = default(string), string annotation = default(string), string property = default(string), string orgValue = default(string), string newValue = default(string), string deploymentId = default(string), string processDefinitionId = default(string), string processDefinitionKey = default(string), string processInstanceId = default(string), string executionId = default(string), string caseDefinitionId = default(string), string caseInstanceId = default(string), string caseExecutionId = default(string), string taskId = default(string), string externalTaskId = default(string), string batchId = default(string), string jobId = default(string), string jobDefinitionId = default(string), DateTime? removalTime = default(DateTime?), string rootProcessInstanceId = default(string))
        {
            this.Id = id;
            this.UserId = userId;
            this.Timestamp = timestamp;
            this.OperationId = operationId;
            this.OperationType = operationType;
            this.EntityType = entityType;
            this.Category = category;
            this.Annotation = annotation;
            this.Property = property;
            this.OrgValue = orgValue;
            this.NewValue = newValue;
            this.DeploymentId = deploymentId;
            this.ProcessDefinitionId = processDefinitionId;
            this.ProcessDefinitionKey = processDefinitionKey;
            this.ProcessInstanceId = processInstanceId;
            this.ExecutionId = executionId;
            this.CaseDefinitionId = caseDefinitionId;
            this.CaseInstanceId = caseInstanceId;
            this.CaseExecutionId = caseExecutionId;
            this.TaskId = taskId;
            this.ExternalTaskId = externalTaskId;
            this.BatchId = batchId;
            this.JobId = jobId;
            this.JobDefinitionId = jobDefinitionId;
            this.RemovalTime = removalTime;
            this.RootProcessInstanceId = rootProcessInstanceId;
        }

        /// <summary>
        /// The unique identifier of this log entry.
        /// </summary>
        /// <value>The unique identifier of this log entry.</value>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// The user who performed this operation.
        /// </summary>
        /// <value>The user who performed this operation.</value>
        [DataMember(Name = "userId", EmitDefaultValue = true)]
        public string UserId { get; set; }

        /// <summary>
        /// Timestamp of this operation.
        /// </summary>
        /// <value>Timestamp of this operation.</value>
        [DataMember(Name = "timestamp", EmitDefaultValue = true)]
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// The unique identifier of this operation. A composite operation that changes multiple properties has a common &#x60;operationId&#x60;.
        /// </summary>
        /// <value>The unique identifier of this operation. A composite operation that changes multiple properties has a common &#x60;operationId&#x60;.</value>
        [DataMember(Name = "operationId", EmitDefaultValue = true)]
        public string OperationId { get; set; }

        /// <summary>
        /// The type of this operation, e.g., &#x60;Assign&#x60;, &#x60;Claim&#x60; and so on.
        /// </summary>
        /// <value>The type of this operation, e.g., &#x60;Assign&#x60;, &#x60;Claim&#x60; and so on.</value>
        [DataMember(Name = "operationType", EmitDefaultValue = true)]
        public string OperationType { get; set; }

        /// <summary>
        /// The type of the entity on which this operation was executed, e.g., &#x60;Task&#x60; or &#x60;Attachment&#x60;.
        /// </summary>
        /// <value>The type of the entity on which this operation was executed, e.g., &#x60;Task&#x60; or &#x60;Attachment&#x60;.</value>
        [DataMember(Name = "entityType", EmitDefaultValue = true)]
        public string EntityType { get; set; }

        /// <summary>
        /// The name of the category this operation was associated with, e.g., &#x60;TaskWorker&#x60; or &#x60;Admin&#x60;.
        /// </summary>
        /// <value>The name of the category this operation was associated with, e.g., &#x60;TaskWorker&#x60; or &#x60;Admin&#x60;.</value>
        [DataMember(Name = "category", EmitDefaultValue = true)]
        public string Category { get; set; }

        /// <summary>
        /// An arbitrary annotation set by a user for auditing reasons.
        /// </summary>
        /// <value>An arbitrary annotation set by a user for auditing reasons.</value>
        [DataMember(Name = "annotation", EmitDefaultValue = true)]
        public string Annotation { get; set; }

        /// <summary>
        /// The property changed by this operation.
        /// </summary>
        /// <value>The property changed by this operation.</value>
        [DataMember(Name = "property", EmitDefaultValue = true)]
        public string Property { get; set; }

        /// <summary>
        /// The original value of the changed property.
        /// </summary>
        /// <value>The original value of the changed property.</value>
        [DataMember(Name = "orgValue", EmitDefaultValue = true)]
        public string OrgValue { get; set; }

        /// <summary>
        /// The new value of the changed property.
        /// </summary>
        /// <value>The new value of the changed property.</value>
        [DataMember(Name = "newValue", EmitDefaultValue = true)]
        public string NewValue { get; set; }

        /// <summary>
        /// If not &#x60;null&#x60;, the operation is restricted to entities in relation to this deployment.
        /// </summary>
        /// <value>If not &#x60;null&#x60;, the operation is restricted to entities in relation to this deployment.</value>
        [DataMember(Name = "deploymentId", EmitDefaultValue = true)]
        public string DeploymentId { get; set; }

        /// <summary>
        /// If not &#x60;null&#x60;, the operation is restricted to entities in relation to this process definition.
        /// </summary>
        /// <value>If not &#x60;null&#x60;, the operation is restricted to entities in relation to this process definition.</value>
        [DataMember(Name = "processDefinitionId", EmitDefaultValue = true)]
        public string ProcessDefinitionId { get; set; }

        /// <summary>
        /// If not &#x60;null&#x60;, the operation is restricted to entities in relation to process definitions with this key.
        /// </summary>
        /// <value>If not &#x60;null&#x60;, the operation is restricted to entities in relation to process definitions with this key.</value>
        [DataMember(Name = "processDefinitionKey", EmitDefaultValue = true)]
        public string ProcessDefinitionKey { get; set; }

        /// <summary>
        /// If not &#x60;null&#x60;, the operation is restricted to entities in relation to this process instance.
        /// </summary>
        /// <value>If not &#x60;null&#x60;, the operation is restricted to entities in relation to this process instance.</value>
        [DataMember(Name = "processInstanceId", EmitDefaultValue = true)]
        public string ProcessInstanceId { get; set; }

        /// <summary>
        /// If not &#x60;null&#x60;, the operation is restricted to entities in relation to this execution.
        /// </summary>
        /// <value>If not &#x60;null&#x60;, the operation is restricted to entities in relation to this execution.</value>
        [DataMember(Name = "executionId", EmitDefaultValue = true)]
        public string ExecutionId { get; set; }

        /// <summary>
        /// If not &#x60;null&#x60;, the operation is restricted to entities in relation to this case definition.
        /// </summary>
        /// <value>If not &#x60;null&#x60;, the operation is restricted to entities in relation to this case definition.</value>
        [DataMember(Name = "caseDefinitionId", EmitDefaultValue = true)]
        public string CaseDefinitionId { get; set; }

        /// <summary>
        /// If not &#x60;null&#x60;, the operation is restricted to entities in relation to this case instance.
        /// </summary>
        /// <value>If not &#x60;null&#x60;, the operation is restricted to entities in relation to this case instance.</value>
        [DataMember(Name = "caseInstanceId", EmitDefaultValue = true)]
        public string CaseInstanceId { get; set; }

        /// <summary>
        /// If not &#x60;null&#x60;, the operation is restricted to entities in relation to this case execution.
        /// </summary>
        /// <value>If not &#x60;null&#x60;, the operation is restricted to entities in relation to this case execution.</value>
        [DataMember(Name = "caseExecutionId", EmitDefaultValue = true)]
        public string CaseExecutionId { get; set; }

        /// <summary>
        /// If not &#x60;null&#x60;, the operation is restricted to entities in relation to this task.
        /// </summary>
        /// <value>If not &#x60;null&#x60;, the operation is restricted to entities in relation to this task.</value>
        [DataMember(Name = "taskId", EmitDefaultValue = true)]
        public string TaskId { get; set; }

        /// <summary>
        /// If not &#x60;null&#x60;, the operation is restricted to entities in relation to this external task.
        /// </summary>
        /// <value>If not &#x60;null&#x60;, the operation is restricted to entities in relation to this external task.</value>
        [DataMember(Name = "externalTaskId", EmitDefaultValue = true)]
        public string ExternalTaskId { get; set; }

        /// <summary>
        /// If not &#x60;null&#x60;, the operation is restricted to entities in relation to this batch.
        /// </summary>
        /// <value>If not &#x60;null&#x60;, the operation is restricted to entities in relation to this batch.</value>
        [DataMember(Name = "batchId", EmitDefaultValue = true)]
        public string BatchId { get; set; }

        /// <summary>
        /// If not &#x60;null&#x60;, the operation is restricted to entities in relation to this job.
        /// </summary>
        /// <value>If not &#x60;null&#x60;, the operation is restricted to entities in relation to this job.</value>
        [DataMember(Name = "jobId", EmitDefaultValue = true)]
        public string JobId { get; set; }

        /// <summary>
        /// If not &#x60;null&#x60;, the operation is restricted to entities in relation to this job definition.
        /// </summary>
        /// <value>If not &#x60;null&#x60;, the operation is restricted to entities in relation to this job definition.</value>
        [DataMember(Name = "jobDefinitionId", EmitDefaultValue = true)]
        public string JobDefinitionId { get; set; }

        /// <summary>
        /// The time after which the entry should be removed by the History Cleanup job. [Default format](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/) &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;.
        /// </summary>
        /// <value>The time after which the entry should be removed by the History Cleanup job. [Default format](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/) &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;.</value>
        [DataMember(Name = "removalTime", EmitDefaultValue = true)]
        public DateTime? RemovalTime { get; set; }

        /// <summary>
        /// The process instance id of the root process instance that initiated the process containing this entry.
        /// </summary>
        /// <value>The process instance id of the root process instance that initiated the process containing this entry.</value>
        [DataMember(Name = "rootProcessInstanceId", EmitDefaultValue = true)]
        public string RootProcessInstanceId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserOperationLogEntryDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  OperationId: ").Append(OperationId).Append("\n");
            sb.Append("  OperationType: ").Append(OperationType).Append("\n");
            sb.Append("  EntityType: ").Append(EntityType).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  Annotation: ").Append(Annotation).Append("\n");
            sb.Append("  Property: ").Append(Property).Append("\n");
            sb.Append("  OrgValue: ").Append(OrgValue).Append("\n");
            sb.Append("  NewValue: ").Append(NewValue).Append("\n");
            sb.Append("  DeploymentId: ").Append(DeploymentId).Append("\n");
            sb.Append("  ProcessDefinitionId: ").Append(ProcessDefinitionId).Append("\n");
            sb.Append("  ProcessDefinitionKey: ").Append(ProcessDefinitionKey).Append("\n");
            sb.Append("  ProcessInstanceId: ").Append(ProcessInstanceId).Append("\n");
            sb.Append("  ExecutionId: ").Append(ExecutionId).Append("\n");
            sb.Append("  CaseDefinitionId: ").Append(CaseDefinitionId).Append("\n");
            sb.Append("  CaseInstanceId: ").Append(CaseInstanceId).Append("\n");
            sb.Append("  CaseExecutionId: ").Append(CaseExecutionId).Append("\n");
            sb.Append("  TaskId: ").Append(TaskId).Append("\n");
            sb.Append("  ExternalTaskId: ").Append(ExternalTaskId).Append("\n");
            sb.Append("  BatchId: ").Append(BatchId).Append("\n");
            sb.Append("  JobId: ").Append(JobId).Append("\n");
            sb.Append("  JobDefinitionId: ").Append(JobDefinitionId).Append("\n");
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
            return this.Equals(input as UserOperationLogEntryDto);
        }

        /// <summary>
        /// Returns true if UserOperationLogEntryDto instances are equal
        /// </summary>
        /// <param name="input">Instance of UserOperationLogEntryDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserOperationLogEntryDto input)
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
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
                ) && 
                (
                    this.OperationId == input.OperationId ||
                    (this.OperationId != null &&
                    this.OperationId.Equals(input.OperationId))
                ) && 
                (
                    this.OperationType == input.OperationType ||
                    (this.OperationType != null &&
                    this.OperationType.Equals(input.OperationType))
                ) && 
                (
                    this.EntityType == input.EntityType ||
                    (this.EntityType != null &&
                    this.EntityType.Equals(input.EntityType))
                ) && 
                (
                    this.Category == input.Category ||
                    (this.Category != null &&
                    this.Category.Equals(input.Category))
                ) && 
                (
                    this.Annotation == input.Annotation ||
                    (this.Annotation != null &&
                    this.Annotation.Equals(input.Annotation))
                ) && 
                (
                    this.Property == input.Property ||
                    (this.Property != null &&
                    this.Property.Equals(input.Property))
                ) && 
                (
                    this.OrgValue == input.OrgValue ||
                    (this.OrgValue != null &&
                    this.OrgValue.Equals(input.OrgValue))
                ) && 
                (
                    this.NewValue == input.NewValue ||
                    (this.NewValue != null &&
                    this.NewValue.Equals(input.NewValue))
                ) && 
                (
                    this.DeploymentId == input.DeploymentId ||
                    (this.DeploymentId != null &&
                    this.DeploymentId.Equals(input.DeploymentId))
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
                    this.ProcessInstanceId == input.ProcessInstanceId ||
                    (this.ProcessInstanceId != null &&
                    this.ProcessInstanceId.Equals(input.ProcessInstanceId))
                ) && 
                (
                    this.ExecutionId == input.ExecutionId ||
                    (this.ExecutionId != null &&
                    this.ExecutionId.Equals(input.ExecutionId))
                ) && 
                (
                    this.CaseDefinitionId == input.CaseDefinitionId ||
                    (this.CaseDefinitionId != null &&
                    this.CaseDefinitionId.Equals(input.CaseDefinitionId))
                ) && 
                (
                    this.CaseInstanceId == input.CaseInstanceId ||
                    (this.CaseInstanceId != null &&
                    this.CaseInstanceId.Equals(input.CaseInstanceId))
                ) && 
                (
                    this.CaseExecutionId == input.CaseExecutionId ||
                    (this.CaseExecutionId != null &&
                    this.CaseExecutionId.Equals(input.CaseExecutionId))
                ) && 
                (
                    this.TaskId == input.TaskId ||
                    (this.TaskId != null &&
                    this.TaskId.Equals(input.TaskId))
                ) && 
                (
                    this.ExternalTaskId == input.ExternalTaskId ||
                    (this.ExternalTaskId != null &&
                    this.ExternalTaskId.Equals(input.ExternalTaskId))
                ) && 
                (
                    this.BatchId == input.BatchId ||
                    (this.BatchId != null &&
                    this.BatchId.Equals(input.BatchId))
                ) && 
                (
                    this.JobId == input.JobId ||
                    (this.JobId != null &&
                    this.JobId.Equals(input.JobId))
                ) && 
                (
                    this.JobDefinitionId == input.JobDefinitionId ||
                    (this.JobDefinitionId != null &&
                    this.JobDefinitionId.Equals(input.JobDefinitionId))
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
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.Timestamp != null)
                    hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
                if (this.OperationId != null)
                    hashCode = hashCode * 59 + this.OperationId.GetHashCode();
                if (this.OperationType != null)
                    hashCode = hashCode * 59 + this.OperationType.GetHashCode();
                if (this.EntityType != null)
                    hashCode = hashCode * 59 + this.EntityType.GetHashCode();
                if (this.Category != null)
                    hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.Annotation != null)
                    hashCode = hashCode * 59 + this.Annotation.GetHashCode();
                if (this.Property != null)
                    hashCode = hashCode * 59 + this.Property.GetHashCode();
                if (this.OrgValue != null)
                    hashCode = hashCode * 59 + this.OrgValue.GetHashCode();
                if (this.NewValue != null)
                    hashCode = hashCode * 59 + this.NewValue.GetHashCode();
                if (this.DeploymentId != null)
                    hashCode = hashCode * 59 + this.DeploymentId.GetHashCode();
                if (this.ProcessDefinitionId != null)
                    hashCode = hashCode * 59 + this.ProcessDefinitionId.GetHashCode();
                if (this.ProcessDefinitionKey != null)
                    hashCode = hashCode * 59 + this.ProcessDefinitionKey.GetHashCode();
                if (this.ProcessInstanceId != null)
                    hashCode = hashCode * 59 + this.ProcessInstanceId.GetHashCode();
                if (this.ExecutionId != null)
                    hashCode = hashCode * 59 + this.ExecutionId.GetHashCode();
                if (this.CaseDefinitionId != null)
                    hashCode = hashCode * 59 + this.CaseDefinitionId.GetHashCode();
                if (this.CaseInstanceId != null)
                    hashCode = hashCode * 59 + this.CaseInstanceId.GetHashCode();
                if (this.CaseExecutionId != null)
                    hashCode = hashCode * 59 + this.CaseExecutionId.GetHashCode();
                if (this.TaskId != null)
                    hashCode = hashCode * 59 + this.TaskId.GetHashCode();
                if (this.ExternalTaskId != null)
                    hashCode = hashCode * 59 + this.ExternalTaskId.GetHashCode();
                if (this.BatchId != null)
                    hashCode = hashCode * 59 + this.BatchId.GetHashCode();
                if (this.JobId != null)
                    hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.JobDefinitionId != null)
                    hashCode = hashCode * 59 + this.JobDefinitionId.GetHashCode();
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
