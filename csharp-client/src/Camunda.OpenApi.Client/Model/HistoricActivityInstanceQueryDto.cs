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
    /// A historic activity instance query which defines a group of historic activity instances
    /// </summary>
    [DataContract(Name = "HistoricActivityInstanceQueryDto")]
    public partial class HistoricActivityInstanceQueryDto : IEquatable<HistoricActivityInstanceQueryDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HistoricActivityInstanceQueryDto" /> class.
        /// </summary>
        /// <param name="activityInstanceId">Filter by activity instance id..</param>
        /// <param name="processInstanceId">Filter by process instance id..</param>
        /// <param name="processDefinitionId">Filter by process definition id..</param>
        /// <param name="executionId">Filter by the id of the execution that executed the activity instance..</param>
        /// <param name="activityId">Filter by the activity id (according to BPMN 2.0 XML)..</param>
        /// <param name="activityName">Filter by the activity name (according to BPMN 2.0 XML)..</param>
        /// <param name="activityType">Filter by activity type..</param>
        /// <param name="taskAssignee">Only include activity instances that are user tasks and assigned to a given user..</param>
        /// <param name="finished">Only include finished activity instances. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; behaves the same as when the property is not set..</param>
        /// <param name="unfinished">Only include unfinished activity instances. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; behaves the same as when the property is not set..</param>
        /// <param name="canceled">Only include canceled activity instances. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; behaves the same as when the property is not set..</param>
        /// <param name="completeScope">Only include activity instances which completed a scope. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; behaves the same as when the property is not set..</param>
        /// <param name="startedBefore">Restrict to instances that were started before the given date. By [default](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;..</param>
        /// <param name="startedAfter">Restrict to instances that were started after the given date. By [default](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;..</param>
        /// <param name="finishedBefore">Restrict to instances that were finished before the given date. By [default](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;..</param>
        /// <param name="finishedAfter">Restrict to instances that were finished after the given date. By [default](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;..</param>
        /// <param name="tenantIdIn">Must be a JSON array of Strings. An activity instance must have one of the given tenant ids..</param>
        /// <param name="withoutTenantId">Only include historic activity instances that belong to no tenant. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior..</param>
        /// <param name="sorting">Apply sorting of the result.</param>
        public HistoricActivityInstanceQueryDto(string activityInstanceId = default(string), string processInstanceId = default(string), string processDefinitionId = default(string), string executionId = default(string), string activityId = default(string), string activityName = default(string), string activityType = default(string), string taskAssignee = default(string), bool? finished = default(bool?), bool? unfinished = default(bool?), bool? canceled = default(bool?), bool? completeScope = default(bool?), DateTime? startedBefore = default(DateTime?), DateTime? startedAfter = default(DateTime?), DateTime? finishedBefore = default(DateTime?), DateTime? finishedAfter = default(DateTime?), List<string> tenantIdIn = default(List<string>), bool? withoutTenantId = default(bool?), List<HistoricActivityInstanceQueryDtoSorting> sorting = default(List<HistoricActivityInstanceQueryDtoSorting>))
        {
            this.ActivityInstanceId = activityInstanceId;
            this.ProcessInstanceId = processInstanceId;
            this.ProcessDefinitionId = processDefinitionId;
            this.ExecutionId = executionId;
            this.ActivityId = activityId;
            this.ActivityName = activityName;
            this.ActivityType = activityType;
            this.TaskAssignee = taskAssignee;
            this.Finished = finished;
            this.Unfinished = unfinished;
            this.Canceled = canceled;
            this.CompleteScope = completeScope;
            this.StartedBefore = startedBefore;
            this.StartedAfter = startedAfter;
            this.FinishedBefore = finishedBefore;
            this.FinishedAfter = finishedAfter;
            this.TenantIdIn = tenantIdIn;
            this.WithoutTenantId = withoutTenantId;
            this.Sorting = sorting;
        }

        /// <summary>
        /// Filter by activity instance id.
        /// </summary>
        /// <value>Filter by activity instance id.</value>
        [DataMember(Name = "activityInstanceId", EmitDefaultValue = true)]
        public string ActivityInstanceId { get; set; }

        /// <summary>
        /// Filter by process instance id.
        /// </summary>
        /// <value>Filter by process instance id.</value>
        [DataMember(Name = "processInstanceId", EmitDefaultValue = true)]
        public string ProcessInstanceId { get; set; }

        /// <summary>
        /// Filter by process definition id.
        /// </summary>
        /// <value>Filter by process definition id.</value>
        [DataMember(Name = "processDefinitionId", EmitDefaultValue = true)]
        public string ProcessDefinitionId { get; set; }

        /// <summary>
        /// Filter by the id of the execution that executed the activity instance.
        /// </summary>
        /// <value>Filter by the id of the execution that executed the activity instance.</value>
        [DataMember(Name = "executionId", EmitDefaultValue = true)]
        public string ExecutionId { get; set; }

        /// <summary>
        /// Filter by the activity id (according to BPMN 2.0 XML).
        /// </summary>
        /// <value>Filter by the activity id (according to BPMN 2.0 XML).</value>
        [DataMember(Name = "activityId", EmitDefaultValue = true)]
        public string ActivityId { get; set; }

        /// <summary>
        /// Filter by the activity name (according to BPMN 2.0 XML).
        /// </summary>
        /// <value>Filter by the activity name (according to BPMN 2.0 XML).</value>
        [DataMember(Name = "activityName", EmitDefaultValue = true)]
        public string ActivityName { get; set; }

        /// <summary>
        /// Filter by activity type.
        /// </summary>
        /// <value>Filter by activity type.</value>
        [DataMember(Name = "activityType", EmitDefaultValue = true)]
        public string ActivityType { get; set; }

        /// <summary>
        /// Only include activity instances that are user tasks and assigned to a given user.
        /// </summary>
        /// <value>Only include activity instances that are user tasks and assigned to a given user.</value>
        [DataMember(Name = "taskAssignee", EmitDefaultValue = true)]
        public string TaskAssignee { get; set; }

        /// <summary>
        /// Only include finished activity instances. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; behaves the same as when the property is not set.
        /// </summary>
        /// <value>Only include finished activity instances. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; behaves the same as when the property is not set.</value>
        [DataMember(Name = "finished", EmitDefaultValue = true)]
        public bool? Finished { get; set; }

        /// <summary>
        /// Only include unfinished activity instances. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; behaves the same as when the property is not set.
        /// </summary>
        /// <value>Only include unfinished activity instances. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; behaves the same as when the property is not set.</value>
        [DataMember(Name = "unfinished", EmitDefaultValue = true)]
        public bool? Unfinished { get; set; }

        /// <summary>
        /// Only include canceled activity instances. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; behaves the same as when the property is not set.
        /// </summary>
        /// <value>Only include canceled activity instances. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; behaves the same as when the property is not set.</value>
        [DataMember(Name = "canceled", EmitDefaultValue = true)]
        public bool? Canceled { get; set; }

        /// <summary>
        /// Only include activity instances which completed a scope. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; behaves the same as when the property is not set.
        /// </summary>
        /// <value>Only include activity instances which completed a scope. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; behaves the same as when the property is not set.</value>
        [DataMember(Name = "completeScope", EmitDefaultValue = true)]
        public bool? CompleteScope { get; set; }

        /// <summary>
        /// Restrict to instances that were started before the given date. By [default](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;.
        /// </summary>
        /// <value>Restrict to instances that were started before the given date. By [default](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;.</value>
        [DataMember(Name = "startedBefore", EmitDefaultValue = true)]
        public DateTime? StartedBefore { get; set; }

        /// <summary>
        /// Restrict to instances that were started after the given date. By [default](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;.
        /// </summary>
        /// <value>Restrict to instances that were started after the given date. By [default](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;.</value>
        [DataMember(Name = "startedAfter", EmitDefaultValue = true)]
        public DateTime? StartedAfter { get; set; }

        /// <summary>
        /// Restrict to instances that were finished before the given date. By [default](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;.
        /// </summary>
        /// <value>Restrict to instances that were finished before the given date. By [default](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;.</value>
        [DataMember(Name = "finishedBefore", EmitDefaultValue = true)]
        public DateTime? FinishedBefore { get; set; }

        /// <summary>
        /// Restrict to instances that were finished after the given date. By [default](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;.
        /// </summary>
        /// <value>Restrict to instances that were finished after the given date. By [default](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;.</value>
        [DataMember(Name = "finishedAfter", EmitDefaultValue = true)]
        public DateTime? FinishedAfter { get; set; }

        /// <summary>
        /// Must be a JSON array of Strings. An activity instance must have one of the given tenant ids.
        /// </summary>
        /// <value>Must be a JSON array of Strings. An activity instance must have one of the given tenant ids.</value>
        [DataMember(Name = "tenantIdIn", EmitDefaultValue = true)]
        public List<string> TenantIdIn { get; set; }

        /// <summary>
        /// Only include historic activity instances that belong to no tenant. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior.
        /// </summary>
        /// <value>Only include historic activity instances that belong to no tenant. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior.</value>
        [DataMember(Name = "withoutTenantId", EmitDefaultValue = true)]
        public bool? WithoutTenantId { get; set; }

        /// <summary>
        /// Apply sorting of the result
        /// </summary>
        /// <value>Apply sorting of the result</value>
        [DataMember(Name = "sorting", EmitDefaultValue = true)]
        public List<HistoricActivityInstanceQueryDtoSorting> Sorting { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HistoricActivityInstanceQueryDto {\n");
            sb.Append("  ActivityInstanceId: ").Append(ActivityInstanceId).Append("\n");
            sb.Append("  ProcessInstanceId: ").Append(ProcessInstanceId).Append("\n");
            sb.Append("  ProcessDefinitionId: ").Append(ProcessDefinitionId).Append("\n");
            sb.Append("  ExecutionId: ").Append(ExecutionId).Append("\n");
            sb.Append("  ActivityId: ").Append(ActivityId).Append("\n");
            sb.Append("  ActivityName: ").Append(ActivityName).Append("\n");
            sb.Append("  ActivityType: ").Append(ActivityType).Append("\n");
            sb.Append("  TaskAssignee: ").Append(TaskAssignee).Append("\n");
            sb.Append("  Finished: ").Append(Finished).Append("\n");
            sb.Append("  Unfinished: ").Append(Unfinished).Append("\n");
            sb.Append("  Canceled: ").Append(Canceled).Append("\n");
            sb.Append("  CompleteScope: ").Append(CompleteScope).Append("\n");
            sb.Append("  StartedBefore: ").Append(StartedBefore).Append("\n");
            sb.Append("  StartedAfter: ").Append(StartedAfter).Append("\n");
            sb.Append("  FinishedBefore: ").Append(FinishedBefore).Append("\n");
            sb.Append("  FinishedAfter: ").Append(FinishedAfter).Append("\n");
            sb.Append("  TenantIdIn: ").Append(TenantIdIn).Append("\n");
            sb.Append("  WithoutTenantId: ").Append(WithoutTenantId).Append("\n");
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
            return this.Equals(input as HistoricActivityInstanceQueryDto);
        }

        /// <summary>
        /// Returns true if HistoricActivityInstanceQueryDto instances are equal
        /// </summary>
        /// <param name="input">Instance of HistoricActivityInstanceQueryDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HistoricActivityInstanceQueryDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ActivityInstanceId == input.ActivityInstanceId ||
                    (this.ActivityInstanceId != null &&
                    this.ActivityInstanceId.Equals(input.ActivityInstanceId))
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
                    this.ExecutionId == input.ExecutionId ||
                    (this.ExecutionId != null &&
                    this.ExecutionId.Equals(input.ExecutionId))
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
                    this.TaskAssignee == input.TaskAssignee ||
                    (this.TaskAssignee != null &&
                    this.TaskAssignee.Equals(input.TaskAssignee))
                ) && 
                (
                    this.Finished == input.Finished ||
                    (this.Finished != null &&
                    this.Finished.Equals(input.Finished))
                ) && 
                (
                    this.Unfinished == input.Unfinished ||
                    (this.Unfinished != null &&
                    this.Unfinished.Equals(input.Unfinished))
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
                    this.StartedBefore == input.StartedBefore ||
                    (this.StartedBefore != null &&
                    this.StartedBefore.Equals(input.StartedBefore))
                ) && 
                (
                    this.StartedAfter == input.StartedAfter ||
                    (this.StartedAfter != null &&
                    this.StartedAfter.Equals(input.StartedAfter))
                ) && 
                (
                    this.FinishedBefore == input.FinishedBefore ||
                    (this.FinishedBefore != null &&
                    this.FinishedBefore.Equals(input.FinishedBefore))
                ) && 
                (
                    this.FinishedAfter == input.FinishedAfter ||
                    (this.FinishedAfter != null &&
                    this.FinishedAfter.Equals(input.FinishedAfter))
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
                if (this.ActivityInstanceId != null)
                    hashCode = hashCode * 59 + this.ActivityInstanceId.GetHashCode();
                if (this.ProcessInstanceId != null)
                    hashCode = hashCode * 59 + this.ProcessInstanceId.GetHashCode();
                if (this.ProcessDefinitionId != null)
                    hashCode = hashCode * 59 + this.ProcessDefinitionId.GetHashCode();
                if (this.ExecutionId != null)
                    hashCode = hashCode * 59 + this.ExecutionId.GetHashCode();
                if (this.ActivityId != null)
                    hashCode = hashCode * 59 + this.ActivityId.GetHashCode();
                if (this.ActivityName != null)
                    hashCode = hashCode * 59 + this.ActivityName.GetHashCode();
                if (this.ActivityType != null)
                    hashCode = hashCode * 59 + this.ActivityType.GetHashCode();
                if (this.TaskAssignee != null)
                    hashCode = hashCode * 59 + this.TaskAssignee.GetHashCode();
                if (this.Finished != null)
                    hashCode = hashCode * 59 + this.Finished.GetHashCode();
                if (this.Unfinished != null)
                    hashCode = hashCode * 59 + this.Unfinished.GetHashCode();
                if (this.Canceled != null)
                    hashCode = hashCode * 59 + this.Canceled.GetHashCode();
                if (this.CompleteScope != null)
                    hashCode = hashCode * 59 + this.CompleteScope.GetHashCode();
                if (this.StartedBefore != null)
                    hashCode = hashCode * 59 + this.StartedBefore.GetHashCode();
                if (this.StartedAfter != null)
                    hashCode = hashCode * 59 + this.StartedAfter.GetHashCode();
                if (this.FinishedBefore != null)
                    hashCode = hashCode * 59 + this.FinishedBefore.GetHashCode();
                if (this.FinishedAfter != null)
                    hashCode = hashCode * 59 + this.FinishedAfter.GetHashCode();
                if (this.TenantIdIn != null)
                    hashCode = hashCode * 59 + this.TenantIdIn.GetHashCode();
                if (this.WithoutTenantId != null)
                    hashCode = hashCode * 59 + this.WithoutTenantId.GetHashCode();
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
