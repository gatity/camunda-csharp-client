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
    /// HistoricActivityInstanceDto
    /// </summary>
    [DataContract(Name = "HistoricActivityInstanceDto")]
    public partial class HistoricActivityInstanceDto : IEquatable<HistoricActivityInstanceDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HistoricActivityInstanceDto" /> class.
        /// </summary>
        /// <param name="id">The id of the activity instance..</param>
        /// <param name="parentActivityInstanceId">The id of the parent activity instance, for example a sub process instance..</param>
        /// <param name="activityId">The id of the activity that this object is an instance of..</param>
        /// <param name="activityName">The name of the activity that this object is an instance of..</param>
        /// <param name="activityType">The type of the activity that this object is an instance of..</param>
        /// <param name="processDefinitionKey">The key of the process definition that this activity instance belongs to..</param>
        /// <param name="processDefinitionId">The id of the process definition that this activity instance belongs to..</param>
        /// <param name="processInstanceId">The id of the process instance that this activity instance belongs to..</param>
        /// <param name="executionId">The id of the execution that executed this activity instance..</param>
        /// <param name="taskId">The id of the task that is associated to this activity instance. Is only set if the activity is a user task..</param>
        /// <param name="assignee">The assignee of the task that is associated to this activity instance. Is only set if the activity is a user task..</param>
        /// <param name="calledProcessInstanceId">The id of the called process instance. Is only set if the activity is a call activity and the called instance a process instance..</param>
        /// <param name="calledCaseInstanceId">The id of the called case instance. Is only set if the activity is a call activity and the called instance a case instance..</param>
        /// <param name="startTime">The time the instance was started. By [default](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;..</param>
        /// <param name="endTime">The time the instance ended. By [default](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;..</param>
        /// <param name="durationInMillis">The time the instance took to finish (in milliseconds)..</param>
        /// <param name="canceled">If &#x60;true&#x60;, this activity instance is canceled..</param>
        /// <param name="completeScope">If &#x60;true&#x60;, this activity instance did complete a BPMN 2.0 scope..</param>
        /// <param name="tenantId">The tenant id of the activity instance..</param>
        /// <param name="removalTime">The time after which the activity instance should be removed by the History Cleanup job. By [default](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;..</param>
        /// <param name="rootProcessInstanceId">The process instance id of the root process instance that initiated the process containing this activity instance..</param>
        public HistoricActivityInstanceDto(string id = default(string), string parentActivityInstanceId = default(string), string activityId = default(string), string activityName = default(string), string activityType = default(string), string processDefinitionKey = default(string), string processDefinitionId = default(string), string processInstanceId = default(string), string executionId = default(string), string taskId = default(string), string assignee = default(string), string calledProcessInstanceId = default(string), string calledCaseInstanceId = default(string), DateTime? startTime = default(DateTime?), DateTime? endTime = default(DateTime?), long? durationInMillis = default(long?), bool? canceled = default(bool?), bool? completeScope = default(bool?), string tenantId = default(string), DateTime? removalTime = default(DateTime?), string rootProcessInstanceId = default(string))
        {
            this.Id = id;
            this.ParentActivityInstanceId = parentActivityInstanceId;
            this.ActivityId = activityId;
            this.ActivityName = activityName;
            this.ActivityType = activityType;
            this.ProcessDefinitionKey = processDefinitionKey;
            this.ProcessDefinitionId = processDefinitionId;
            this.ProcessInstanceId = processInstanceId;
            this.ExecutionId = executionId;
            this.TaskId = taskId;
            this.Assignee = assignee;
            this.CalledProcessInstanceId = calledProcessInstanceId;
            this.CalledCaseInstanceId = calledCaseInstanceId;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.DurationInMillis = durationInMillis;
            this.Canceled = canceled;
            this.CompleteScope = completeScope;
            this.TenantId = tenantId;
            this.RemovalTime = removalTime;
            this.RootProcessInstanceId = rootProcessInstanceId;
        }

        /// <summary>
        /// The id of the activity instance.
        /// </summary>
        /// <value>The id of the activity instance.</value>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// The id of the parent activity instance, for example a sub process instance.
        /// </summary>
        /// <value>The id of the parent activity instance, for example a sub process instance.</value>
        [DataMember(Name = "parentActivityInstanceId", EmitDefaultValue = true)]
        public string ParentActivityInstanceId { get; set; }

        /// <summary>
        /// The id of the activity that this object is an instance of.
        /// </summary>
        /// <value>The id of the activity that this object is an instance of.</value>
        [DataMember(Name = "activityId", EmitDefaultValue = true)]
        public string ActivityId { get; set; }

        /// <summary>
        /// The name of the activity that this object is an instance of.
        /// </summary>
        /// <value>The name of the activity that this object is an instance of.</value>
        [DataMember(Name = "activityName", EmitDefaultValue = true)]
        public string ActivityName { get; set; }

        /// <summary>
        /// The type of the activity that this object is an instance of.
        /// </summary>
        /// <value>The type of the activity that this object is an instance of.</value>
        [DataMember(Name = "activityType", EmitDefaultValue = true)]
        public string ActivityType { get; set; }

        /// <summary>
        /// The key of the process definition that this activity instance belongs to.
        /// </summary>
        /// <value>The key of the process definition that this activity instance belongs to.</value>
        [DataMember(Name = "processDefinitionKey", EmitDefaultValue = true)]
        public string ProcessDefinitionKey { get; set; }

        /// <summary>
        /// The id of the process definition that this activity instance belongs to.
        /// </summary>
        /// <value>The id of the process definition that this activity instance belongs to.</value>
        [DataMember(Name = "processDefinitionId", EmitDefaultValue = true)]
        public string ProcessDefinitionId { get; set; }

        /// <summary>
        /// The id of the process instance that this activity instance belongs to.
        /// </summary>
        /// <value>The id of the process instance that this activity instance belongs to.</value>
        [DataMember(Name = "processInstanceId", EmitDefaultValue = true)]
        public string ProcessInstanceId { get; set; }

        /// <summary>
        /// The id of the execution that executed this activity instance.
        /// </summary>
        /// <value>The id of the execution that executed this activity instance.</value>
        [DataMember(Name = "executionId", EmitDefaultValue = true)]
        public string ExecutionId { get; set; }

        /// <summary>
        /// The id of the task that is associated to this activity instance. Is only set if the activity is a user task.
        /// </summary>
        /// <value>The id of the task that is associated to this activity instance. Is only set if the activity is a user task.</value>
        [DataMember(Name = "taskId", EmitDefaultValue = true)]
        public string TaskId { get; set; }

        /// <summary>
        /// The assignee of the task that is associated to this activity instance. Is only set if the activity is a user task.
        /// </summary>
        /// <value>The assignee of the task that is associated to this activity instance. Is only set if the activity is a user task.</value>
        [DataMember(Name = "assignee", EmitDefaultValue = true)]
        public string Assignee { get; set; }

        /// <summary>
        /// The id of the called process instance. Is only set if the activity is a call activity and the called instance a process instance.
        /// </summary>
        /// <value>The id of the called process instance. Is only set if the activity is a call activity and the called instance a process instance.</value>
        [DataMember(Name = "calledProcessInstanceId", EmitDefaultValue = true)]
        public string CalledProcessInstanceId { get; set; }

        /// <summary>
        /// The id of the called case instance. Is only set if the activity is a call activity and the called instance a case instance.
        /// </summary>
        /// <value>The id of the called case instance. Is only set if the activity is a call activity and the called instance a case instance.</value>
        [DataMember(Name = "calledCaseInstanceId", EmitDefaultValue = true)]
        public string CalledCaseInstanceId { get; set; }

        /// <summary>
        /// The time the instance was started. By [default](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;.
        /// </summary>
        /// <value>The time the instance was started. By [default](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;.</value>
        [DataMember(Name = "startTime", EmitDefaultValue = true)]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// The time the instance ended. By [default](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;.
        /// </summary>
        /// <value>The time the instance ended. By [default](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;.</value>
        [DataMember(Name = "endTime", EmitDefaultValue = true)]
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// The time the instance took to finish (in milliseconds).
        /// </summary>
        /// <value>The time the instance took to finish (in milliseconds).</value>
        [DataMember(Name = "durationInMillis", EmitDefaultValue = true)]
        public long? DurationInMillis { get; set; }

        /// <summary>
        /// If &#x60;true&#x60;, this activity instance is canceled.
        /// </summary>
        /// <value>If &#x60;true&#x60;, this activity instance is canceled.</value>
        [DataMember(Name = "canceled", EmitDefaultValue = true)]
        public bool? Canceled { get; set; }

        /// <summary>
        /// If &#x60;true&#x60;, this activity instance did complete a BPMN 2.0 scope.
        /// </summary>
        /// <value>If &#x60;true&#x60;, this activity instance did complete a BPMN 2.0 scope.</value>
        [DataMember(Name = "completeScope", EmitDefaultValue = true)]
        public bool? CompleteScope { get; set; }

        /// <summary>
        /// The tenant id of the activity instance.
        /// </summary>
        /// <value>The tenant id of the activity instance.</value>
        [DataMember(Name = "tenantId", EmitDefaultValue = true)]
        public string TenantId { get; set; }

        /// <summary>
        /// The time after which the activity instance should be removed by the History Cleanup job. By [default](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;.
        /// </summary>
        /// <value>The time after which the activity instance should be removed by the History Cleanup job. By [default](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;.</value>
        [DataMember(Name = "removalTime", EmitDefaultValue = true)]
        public DateTime? RemovalTime { get; set; }

        /// <summary>
        /// The process instance id of the root process instance that initiated the process containing this activity instance.
        /// </summary>
        /// <value>The process instance id of the root process instance that initiated the process containing this activity instance.</value>
        [DataMember(Name = "rootProcessInstanceId", EmitDefaultValue = true)]
        public string RootProcessInstanceId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HistoricActivityInstanceDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ParentActivityInstanceId: ").Append(ParentActivityInstanceId).Append("\n");
            sb.Append("  ActivityId: ").Append(ActivityId).Append("\n");
            sb.Append("  ActivityName: ").Append(ActivityName).Append("\n");
            sb.Append("  ActivityType: ").Append(ActivityType).Append("\n");
            sb.Append("  ProcessDefinitionKey: ").Append(ProcessDefinitionKey).Append("\n");
            sb.Append("  ProcessDefinitionId: ").Append(ProcessDefinitionId).Append("\n");
            sb.Append("  ProcessInstanceId: ").Append(ProcessInstanceId).Append("\n");
            sb.Append("  ExecutionId: ").Append(ExecutionId).Append("\n");
            sb.Append("  TaskId: ").Append(TaskId).Append("\n");
            sb.Append("  Assignee: ").Append(Assignee).Append("\n");
            sb.Append("  CalledProcessInstanceId: ").Append(CalledProcessInstanceId).Append("\n");
            sb.Append("  CalledCaseInstanceId: ").Append(CalledCaseInstanceId).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  DurationInMillis: ").Append(DurationInMillis).Append("\n");
            sb.Append("  Canceled: ").Append(Canceled).Append("\n");
            sb.Append("  CompleteScope: ").Append(CompleteScope).Append("\n");
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
            return this.Equals(input as HistoricActivityInstanceDto);
        }

        /// <summary>
        /// Returns true if HistoricActivityInstanceDto instances are equal
        /// </summary>
        /// <param name="input">Instance of HistoricActivityInstanceDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HistoricActivityInstanceDto input)
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
                    this.ParentActivityInstanceId == input.ParentActivityInstanceId ||
                    (this.ParentActivityInstanceId != null &&
                    this.ParentActivityInstanceId.Equals(input.ParentActivityInstanceId))
                ) && 
                (
                    this.ActivityId == input.ActivityId ||
                    (this.ActivityId != null &&
                    this.ActivityId.Equals(input.ActivityId))
                ) && 
                (
                    this.ActivityName == input.ActivityName ||
                    (this.ActivityName != null &&
                    this.ActivityName.Equals(input.ActivityName))
                ) && 
                (
                    this.ActivityType == input.ActivityType ||
                    (this.ActivityType != null &&
                    this.ActivityType.Equals(input.ActivityType))
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
                    this.TaskId == input.TaskId ||
                    (this.TaskId != null &&
                    this.TaskId.Equals(input.TaskId))
                ) && 
                (
                    this.Assignee == input.Assignee ||
                    (this.Assignee != null &&
                    this.Assignee.Equals(input.Assignee))
                ) && 
                (
                    this.CalledProcessInstanceId == input.CalledProcessInstanceId ||
                    (this.CalledProcessInstanceId != null &&
                    this.CalledProcessInstanceId.Equals(input.CalledProcessInstanceId))
                ) && 
                (
                    this.CalledCaseInstanceId == input.CalledCaseInstanceId ||
                    (this.CalledCaseInstanceId != null &&
                    this.CalledCaseInstanceId.Equals(input.CalledCaseInstanceId))
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
                    this.DurationInMillis == input.DurationInMillis ||
                    (this.DurationInMillis != null &&
                    this.DurationInMillis.Equals(input.DurationInMillis))
                ) && 
                (
                    this.Canceled == input.Canceled ||
                    (this.Canceled != null &&
                    this.Canceled.Equals(input.Canceled))
                ) && 
                (
                    this.CompleteScope == input.CompleteScope ||
                    (this.CompleteScope != null &&
                    this.CompleteScope.Equals(input.CompleteScope))
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
                if (this.ParentActivityInstanceId != null)
                    hashCode = hashCode * 59 + this.ParentActivityInstanceId.GetHashCode();
                if (this.ActivityId != null)
                    hashCode = hashCode * 59 + this.ActivityId.GetHashCode();
                if (this.ActivityName != null)
                    hashCode = hashCode * 59 + this.ActivityName.GetHashCode();
                if (this.ActivityType != null)
                    hashCode = hashCode * 59 + this.ActivityType.GetHashCode();
                if (this.ProcessDefinitionKey != null)
                    hashCode = hashCode * 59 + this.ProcessDefinitionKey.GetHashCode();
                if (this.ProcessDefinitionId != null)
                    hashCode = hashCode * 59 + this.ProcessDefinitionId.GetHashCode();
                if (this.ProcessInstanceId != null)
                    hashCode = hashCode * 59 + this.ProcessInstanceId.GetHashCode();
                if (this.ExecutionId != null)
                    hashCode = hashCode * 59 + this.ExecutionId.GetHashCode();
                if (this.TaskId != null)
                    hashCode = hashCode * 59 + this.TaskId.GetHashCode();
                if (this.Assignee != null)
                    hashCode = hashCode * 59 + this.Assignee.GetHashCode();
                if (this.CalledProcessInstanceId != null)
                    hashCode = hashCode * 59 + this.CalledProcessInstanceId.GetHashCode();
                if (this.CalledCaseInstanceId != null)
                    hashCode = hashCode * 59 + this.CalledCaseInstanceId.GetHashCode();
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null)
                    hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.DurationInMillis != null)
                    hashCode = hashCode * 59 + this.DurationInMillis.GetHashCode();
                if (this.Canceled != null)
                    hashCode = hashCode * 59 + this.Canceled.GetHashCode();
                if (this.CompleteScope != null)
                    hashCode = hashCode * 59 + this.CompleteScope.GetHashCode();
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
