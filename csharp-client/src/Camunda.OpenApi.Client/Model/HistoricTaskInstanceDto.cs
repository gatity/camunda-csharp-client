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
    /// HistoricTaskInstanceDto
    /// </summary>
    [DataContract(Name = "HistoricTaskInstanceDto")]
    public partial class HistoricTaskInstanceDto : IEquatable<HistoricTaskInstanceDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HistoricTaskInstanceDto" /> class.
        /// </summary>
        /// <param name="id">The task id..</param>
        /// <param name="processDefinitionKey">The key of the process definition the task belongs to..</param>
        /// <param name="processDefinitionId">The id of the process definition the task belongs to..</param>
        /// <param name="processInstanceId">The id of the process instance the task belongs to..</param>
        /// <param name="executionId">The id of the execution the task belongs to..</param>
        /// <param name="caseDefinitionKey">The key of the case definition the task belongs to..</param>
        /// <param name="caseDefinitionId">The id of the case definition the task belongs to..</param>
        /// <param name="caseInstanceId">The id of the case instance the task belongs to..</param>
        /// <param name="caseExecutionId">The id of the case execution the task belongs to..</param>
        /// <param name="activityInstanceId">The id of the activity that this object is an instance of..</param>
        /// <param name="name">The task name..</param>
        /// <param name="description">The task&#39;s description..</param>
        /// <param name="deleteReason">The task&#39;s delete reason..</param>
        /// <param name="owner">The owner&#39;s id..</param>
        /// <param name="assignee">The assignee&#39;s id..</param>
        /// <param name="startTime">The time the task was started. Default [format](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/) &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;..</param>
        /// <param name="endTime">The time the task ended. Default [format](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/) &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;..</param>
        /// <param name="duration">The time the task took to finish (in milliseconds)..</param>
        /// <param name="taskDefinitionKey">The task&#39;s key..</param>
        /// <param name="priority">The task&#39;s priority..</param>
        /// <param name="due">The task&#39;s due date. Default [format](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/) &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;..</param>
        /// <param name="parentTaskId">The id of the parent task, if this task is a subtask..</param>
        /// <param name="followUp">The follow-up date for the task. Default [format](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/) &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;..</param>
        /// <param name="tenantId">The tenant id of the task instance..</param>
        /// <param name="removalTime">The time after which the task should be removed by the History Cleanup job. Default [format](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/) &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;..</param>
        /// <param name="rootProcessInstanceId">The process instance id of the root process instance that initiated the process containing this task..</param>
        public HistoricTaskInstanceDto(string id = default(string), string processDefinitionKey = default(string), string processDefinitionId = default(string), string processInstanceId = default(string), string executionId = default(string), string caseDefinitionKey = default(string), string caseDefinitionId = default(string), string caseInstanceId = default(string), string caseExecutionId = default(string), string activityInstanceId = default(string), string name = default(string), string description = default(string), string deleteReason = default(string), string owner = default(string), string assignee = default(string), DateTime? startTime = default(DateTime?), DateTime? endTime = default(DateTime?), long? duration = default(long?), string taskDefinitionKey = default(string), int? priority = default(int?), DateTime? due = default(DateTime?), string parentTaskId = default(string), DateTime? followUp = default(DateTime?), string tenantId = default(string), DateTime? removalTime = default(DateTime?), string rootProcessInstanceId = default(string))
        {
            this.Id = id;
            this.ProcessDefinitionKey = processDefinitionKey;
            this.ProcessDefinitionId = processDefinitionId;
            this.ProcessInstanceId = processInstanceId;
            this.ExecutionId = executionId;
            this.CaseDefinitionKey = caseDefinitionKey;
            this.CaseDefinitionId = caseDefinitionId;
            this.CaseInstanceId = caseInstanceId;
            this.CaseExecutionId = caseExecutionId;
            this.ActivityInstanceId = activityInstanceId;
            this.Name = name;
            this.Description = description;
            this.DeleteReason = deleteReason;
            this.Owner = owner;
            this.Assignee = assignee;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.Duration = duration;
            this.TaskDefinitionKey = taskDefinitionKey;
            this.Priority = priority;
            this.Due = due;
            this.ParentTaskId = parentTaskId;
            this.FollowUp = followUp;
            this.TenantId = tenantId;
            this.RemovalTime = removalTime;
            this.RootProcessInstanceId = rootProcessInstanceId;
        }

        /// <summary>
        /// The task id.
        /// </summary>
        /// <value>The task id.</value>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// The key of the process definition the task belongs to.
        /// </summary>
        /// <value>The key of the process definition the task belongs to.</value>
        [DataMember(Name = "processDefinitionKey", EmitDefaultValue = true)]
        public string ProcessDefinitionKey { get; set; }

        /// <summary>
        /// The id of the process definition the task belongs to.
        /// </summary>
        /// <value>The id of the process definition the task belongs to.</value>
        [DataMember(Name = "processDefinitionId", EmitDefaultValue = true)]
        public string ProcessDefinitionId { get; set; }

        /// <summary>
        /// The id of the process instance the task belongs to.
        /// </summary>
        /// <value>The id of the process instance the task belongs to.</value>
        [DataMember(Name = "processInstanceId", EmitDefaultValue = true)]
        public string ProcessInstanceId { get; set; }

        /// <summary>
        /// The id of the execution the task belongs to.
        /// </summary>
        /// <value>The id of the execution the task belongs to.</value>
        [DataMember(Name = "executionId", EmitDefaultValue = true)]
        public string ExecutionId { get; set; }

        /// <summary>
        /// The key of the case definition the task belongs to.
        /// </summary>
        /// <value>The key of the case definition the task belongs to.</value>
        [DataMember(Name = "caseDefinitionKey", EmitDefaultValue = true)]
        public string CaseDefinitionKey { get; set; }

        /// <summary>
        /// The id of the case definition the task belongs to.
        /// </summary>
        /// <value>The id of the case definition the task belongs to.</value>
        [DataMember(Name = "caseDefinitionId", EmitDefaultValue = true)]
        public string CaseDefinitionId { get; set; }

        /// <summary>
        /// The id of the case instance the task belongs to.
        /// </summary>
        /// <value>The id of the case instance the task belongs to.</value>
        [DataMember(Name = "caseInstanceId", EmitDefaultValue = true)]
        public string CaseInstanceId { get; set; }

        /// <summary>
        /// The id of the case execution the task belongs to.
        /// </summary>
        /// <value>The id of the case execution the task belongs to.</value>
        [DataMember(Name = "caseExecutionId", EmitDefaultValue = true)]
        public string CaseExecutionId { get; set; }

        /// <summary>
        /// The id of the activity that this object is an instance of.
        /// </summary>
        /// <value>The id of the activity that this object is an instance of.</value>
        [DataMember(Name = "activityInstanceId", EmitDefaultValue = true)]
        public string ActivityInstanceId { get; set; }

        /// <summary>
        /// The task name.
        /// </summary>
        /// <value>The task name.</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The task&#39;s description.
        /// </summary>
        /// <value>The task&#39;s description.</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// The task&#39;s delete reason.
        /// </summary>
        /// <value>The task&#39;s delete reason.</value>
        [DataMember(Name = "deleteReason", EmitDefaultValue = true)]
        public string DeleteReason { get; set; }

        /// <summary>
        /// The owner&#39;s id.
        /// </summary>
        /// <value>The owner&#39;s id.</value>
        [DataMember(Name = "owner", EmitDefaultValue = true)]
        public string Owner { get; set; }

        /// <summary>
        /// The assignee&#39;s id.
        /// </summary>
        /// <value>The assignee&#39;s id.</value>
        [DataMember(Name = "assignee", EmitDefaultValue = true)]
        public string Assignee { get; set; }

        /// <summary>
        /// The time the task was started. Default [format](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/) &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;.
        /// </summary>
        /// <value>The time the task was started. Default [format](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/) &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;.</value>
        [DataMember(Name = "startTime", EmitDefaultValue = true)]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// The time the task ended. Default [format](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/) &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;.
        /// </summary>
        /// <value>The time the task ended. Default [format](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/) &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;.</value>
        [DataMember(Name = "endTime", EmitDefaultValue = true)]
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// The time the task took to finish (in milliseconds).
        /// </summary>
        /// <value>The time the task took to finish (in milliseconds).</value>
        [DataMember(Name = "duration", EmitDefaultValue = true)]
        public long? Duration { get; set; }

        /// <summary>
        /// The task&#39;s key.
        /// </summary>
        /// <value>The task&#39;s key.</value>
        [DataMember(Name = "taskDefinitionKey", EmitDefaultValue = true)]
        public string TaskDefinitionKey { get; set; }

        /// <summary>
        /// The task&#39;s priority.
        /// </summary>
        /// <value>The task&#39;s priority.</value>
        [DataMember(Name = "priority", EmitDefaultValue = true)]
        public int? Priority { get; set; }

        /// <summary>
        /// The task&#39;s due date. Default [format](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/) &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;.
        /// </summary>
        /// <value>The task&#39;s due date. Default [format](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/) &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;.</value>
        [DataMember(Name = "due", EmitDefaultValue = true)]
        public DateTime? Due { get; set; }

        /// <summary>
        /// The id of the parent task, if this task is a subtask.
        /// </summary>
        /// <value>The id of the parent task, if this task is a subtask.</value>
        [DataMember(Name = "parentTaskId", EmitDefaultValue = true)]
        public string ParentTaskId { get; set; }

        /// <summary>
        /// The follow-up date for the task. Default [format](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/) &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;.
        /// </summary>
        /// <value>The follow-up date for the task. Default [format](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/) &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;.</value>
        [DataMember(Name = "followUp", EmitDefaultValue = true)]
        public DateTime? FollowUp { get; set; }

        /// <summary>
        /// The tenant id of the task instance.
        /// </summary>
        /// <value>The tenant id of the task instance.</value>
        [DataMember(Name = "tenantId", EmitDefaultValue = true)]
        public string TenantId { get; set; }

        /// <summary>
        /// The time after which the task should be removed by the History Cleanup job. Default [format](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/) &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;.
        /// </summary>
        /// <value>The time after which the task should be removed by the History Cleanup job. Default [format](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/) &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;.</value>
        [DataMember(Name = "removalTime", EmitDefaultValue = true)]
        public DateTime? RemovalTime { get; set; }

        /// <summary>
        /// The process instance id of the root process instance that initiated the process containing this task.
        /// </summary>
        /// <value>The process instance id of the root process instance that initiated the process containing this task.</value>
        [DataMember(Name = "rootProcessInstanceId", EmitDefaultValue = true)]
        public string RootProcessInstanceId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HistoricTaskInstanceDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ProcessDefinitionKey: ").Append(ProcessDefinitionKey).Append("\n");
            sb.Append("  ProcessDefinitionId: ").Append(ProcessDefinitionId).Append("\n");
            sb.Append("  ProcessInstanceId: ").Append(ProcessInstanceId).Append("\n");
            sb.Append("  ExecutionId: ").Append(ExecutionId).Append("\n");
            sb.Append("  CaseDefinitionKey: ").Append(CaseDefinitionKey).Append("\n");
            sb.Append("  CaseDefinitionId: ").Append(CaseDefinitionId).Append("\n");
            sb.Append("  CaseInstanceId: ").Append(CaseInstanceId).Append("\n");
            sb.Append("  CaseExecutionId: ").Append(CaseExecutionId).Append("\n");
            sb.Append("  ActivityInstanceId: ").Append(ActivityInstanceId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DeleteReason: ").Append(DeleteReason).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  Assignee: ").Append(Assignee).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  TaskDefinitionKey: ").Append(TaskDefinitionKey).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  Due: ").Append(Due).Append("\n");
            sb.Append("  ParentTaskId: ").Append(ParentTaskId).Append("\n");
            sb.Append("  FollowUp: ").Append(FollowUp).Append("\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
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
            return this.Equals(input as HistoricTaskInstanceDto);
        }

        /// <summary>
        /// Returns true if HistoricTaskInstanceDto instances are equal
        /// </summary>
        /// <param name="input">Instance of HistoricTaskInstanceDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HistoricTaskInstanceDto input)
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
                    this.ProcessDefinitionKey == input.ProcessDefinitionKey ||
                    (this.ProcessDefinitionKey != null &&
                    this.ProcessDefinitionKey.Equals(input.ProcessDefinitionKey))
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
                    this.ExecutionId == input.ExecutionId ||
                    (this.ExecutionId != null &&
                    this.ExecutionId.Equals(input.ExecutionId))
                ) && 
                (
                    this.CaseDefinitionKey == input.CaseDefinitionKey ||
                    (this.CaseDefinitionKey != null &&
                    this.CaseDefinitionKey.Equals(input.CaseDefinitionKey))
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
                    this.ActivityInstanceId == input.ActivityInstanceId ||
                    (this.ActivityInstanceId != null &&
                    this.ActivityInstanceId.Equals(input.ActivityInstanceId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.DeleteReason == input.DeleteReason ||
                    (this.DeleteReason != null &&
                    this.DeleteReason.Equals(input.DeleteReason))
                ) && 
                (
                    this.Owner == input.Owner ||
                    (this.Owner != null &&
                    this.Owner.Equals(input.Owner))
                ) && 
                (
                    this.Assignee == input.Assignee ||
                    (this.Assignee != null &&
                    this.Assignee.Equals(input.Assignee))
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
                    this.Duration == input.Duration ||
                    (this.Duration != null &&
                    this.Duration.Equals(input.Duration))
                ) && 
                (
                    this.TaskDefinitionKey == input.TaskDefinitionKey ||
                    (this.TaskDefinitionKey != null &&
                    this.TaskDefinitionKey.Equals(input.TaskDefinitionKey))
                ) && 
                (
                    this.Priority == input.Priority ||
                    (this.Priority != null &&
                    this.Priority.Equals(input.Priority))
                ) && 
                (
                    this.Due == input.Due ||
                    (this.Due != null &&
                    this.Due.Equals(input.Due))
                ) && 
                (
                    this.ParentTaskId == input.ParentTaskId ||
                    (this.ParentTaskId != null &&
                    this.ParentTaskId.Equals(input.ParentTaskId))
                ) && 
                (
                    this.FollowUp == input.FollowUp ||
                    (this.FollowUp != null &&
                    this.FollowUp.Equals(input.FollowUp))
                ) && 
                (
                    this.TenantId == input.TenantId ||
                    (this.TenantId != null &&
                    this.TenantId.Equals(input.TenantId))
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
                if (this.ProcessDefinitionKey != null)
                    hashCode = hashCode * 59 + this.ProcessDefinitionKey.GetHashCode();
                if (this.ProcessDefinitionId != null)
                    hashCode = hashCode * 59 + this.ProcessDefinitionId.GetHashCode();
                if (this.ProcessInstanceId != null)
                    hashCode = hashCode * 59 + this.ProcessInstanceId.GetHashCode();
                if (this.ExecutionId != null)
                    hashCode = hashCode * 59 + this.ExecutionId.GetHashCode();
                if (this.CaseDefinitionKey != null)
                    hashCode = hashCode * 59 + this.CaseDefinitionKey.GetHashCode();
                if (this.CaseDefinitionId != null)
                    hashCode = hashCode * 59 + this.CaseDefinitionId.GetHashCode();
                if (this.CaseInstanceId != null)
                    hashCode = hashCode * 59 + this.CaseInstanceId.GetHashCode();
                if (this.CaseExecutionId != null)
                    hashCode = hashCode * 59 + this.CaseExecutionId.GetHashCode();
                if (this.ActivityInstanceId != null)
                    hashCode = hashCode * 59 + this.ActivityInstanceId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.DeleteReason != null)
                    hashCode = hashCode * 59 + this.DeleteReason.GetHashCode();
                if (this.Owner != null)
                    hashCode = hashCode * 59 + this.Owner.GetHashCode();
                if (this.Assignee != null)
                    hashCode = hashCode * 59 + this.Assignee.GetHashCode();
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null)
                    hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.Duration != null)
                    hashCode = hashCode * 59 + this.Duration.GetHashCode();
                if (this.TaskDefinitionKey != null)
                    hashCode = hashCode * 59 + this.TaskDefinitionKey.GetHashCode();
                if (this.Priority != null)
                    hashCode = hashCode * 59 + this.Priority.GetHashCode();
                if (this.Due != null)
                    hashCode = hashCode * 59 + this.Due.GetHashCode();
                if (this.ParentTaskId != null)
                    hashCode = hashCode * 59 + this.ParentTaskId.GetHashCode();
                if (this.FollowUp != null)
                    hashCode = hashCode * 59 + this.FollowUp.GetHashCode();
                if (this.TenantId != null)
                    hashCode = hashCode * 59 + this.TenantId.GetHashCode();
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
