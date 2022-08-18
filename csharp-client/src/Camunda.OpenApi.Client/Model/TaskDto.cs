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
    /// TaskDto
    /// </summary>
    [DataContract(Name = "TaskDto")]
    public partial class TaskDto : IEquatable<TaskDto>, IValidatableObject
    {
        /// <summary>
        /// The task&#39;s delegation state. Possible values are &#x60;PENDING&#x60; and &#x60;RESOLVED&#x60;.
        /// </summary>
        /// <value>The task&#39;s delegation state. Possible values are &#x60;PENDING&#x60; and &#x60;RESOLVED&#x60;.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DelegationStateEnum
        {
            /// <summary>
            /// Enum PENDING for value: PENDING
            /// </summary>
            [EnumMember(Value = "PENDING")]
            PENDING = 1,

            /// <summary>
            /// Enum RESOLVED for value: RESOLVED
            /// </summary>
            [EnumMember(Value = "RESOLVED")]
            RESOLVED = 2

        }


        /// <summary>
        /// The task&#39;s delegation state. Possible values are &#x60;PENDING&#x60; and &#x60;RESOLVED&#x60;.
        /// </summary>
        /// <value>The task&#39;s delegation state. Possible values are &#x60;PENDING&#x60; and &#x60;RESOLVED&#x60;.</value>
        [DataMember(Name = "delegationState", EmitDefaultValue = true)]
        public DelegationStateEnum? DelegationState { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskDto" /> class.
        /// </summary>
        /// <param name="id">The task id..</param>
        /// <param name="name">The task name..</param>
        /// <param name="assignee">The assignee&#39;s id..</param>
        /// <param name="owner">The owner&#39;s id..</param>
        /// <param name="created">The date the task was created on. [Default format](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/) &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;..</param>
        /// <param name="due">The task&#39;s due date. [Default format](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/) &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;..</param>
        /// <param name="followUp">The follow-up date for the task. [Default format](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/) &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;..</param>
        /// <param name="delegationState">The task&#39;s delegation state. Possible values are &#x60;PENDING&#x60; and &#x60;RESOLVED&#x60;..</param>
        /// <param name="description">The task&#39;s description..</param>
        /// <param name="executionId">The id of the execution the task belongs to..</param>
        /// <param name="parentTaskId">The id the parent task, if this task is a subtask..</param>
        /// <param name="priority">The task&#39;s priority..</param>
        /// <param name="processDefinitionId">The id of the process definition the task belongs to..</param>
        /// <param name="processInstanceId">The id of the process instance the task belongs to..</param>
        /// <param name="caseExecutionId">The id of the case execution the task belongs to..</param>
        /// <param name="caseDefinitionId">The id of the case definition the task belongs to..</param>
        /// <param name="caseInstanceId">The id of the case instance the task belongs to..</param>
        /// <param name="taskDefinitionKey">The task&#39;s key..</param>
        /// <param name="suspended">Whether the task belongs to a process instance that is suspended..</param>
        /// <param name="formKey">If not &#x60;null&#x60;, the form key for the task..</param>
        /// <param name="camundaFormRef">A reference to a specific version of a Camunda Form..</param>
        /// <param name="tenantId">If not &#x60;null&#x60;, the tenant id of the task..</param>
        public TaskDto(string id = default(string), string name = default(string), string assignee = default(string), string owner = default(string), DateTime? created = default(DateTime?), DateTime? due = default(DateTime?), DateTime? followUp = default(DateTime?), DelegationStateEnum? delegationState = default(DelegationStateEnum?), string description = default(string), string executionId = default(string), string parentTaskId = default(string), int? priority = default(int?), string processDefinitionId = default(string), string processInstanceId = default(string), string caseExecutionId = default(string), string caseDefinitionId = default(string), string caseInstanceId = default(string), string taskDefinitionKey = default(string), bool? suspended = default(bool?), string formKey = default(string), Dictionary<string, CamundaFormRef> camundaFormRef = default(Dictionary<string, CamundaFormRef>), string tenantId = default(string))
        {
            this.Id = id;
            this.Name = name;
            this.Assignee = assignee;
            this.Owner = owner;
            this.Created = created;
            this.Due = due;
            this.FollowUp = followUp;
            this.DelegationState = delegationState;
            this.Description = description;
            this.ExecutionId = executionId;
            this.ParentTaskId = parentTaskId;
            this.Priority = priority;
            this.ProcessDefinitionId = processDefinitionId;
            this.ProcessInstanceId = processInstanceId;
            this.CaseExecutionId = caseExecutionId;
            this.CaseDefinitionId = caseDefinitionId;
            this.CaseInstanceId = caseInstanceId;
            this.TaskDefinitionKey = taskDefinitionKey;
            this.Suspended = suspended;
            this.FormKey = formKey;
            this.CamundaFormRef = camundaFormRef;
            this.TenantId = tenantId;
        }

        /// <summary>
        /// The task id.
        /// </summary>
        /// <value>The task id.</value>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// The task name.
        /// </summary>
        /// <value>The task name.</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The assignee&#39;s id.
        /// </summary>
        /// <value>The assignee&#39;s id.</value>
        [DataMember(Name = "assignee", EmitDefaultValue = true)]
        public string Assignee { get; set; }

        /// <summary>
        /// The owner&#39;s id.
        /// </summary>
        /// <value>The owner&#39;s id.</value>
        [DataMember(Name = "owner", EmitDefaultValue = true)]
        public string Owner { get; set; }

        /// <summary>
        /// The date the task was created on. [Default format](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/) &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;.
        /// </summary>
        /// <value>The date the task was created on. [Default format](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/) &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;.</value>
        [DataMember(Name = "created", EmitDefaultValue = true)]
        public DateTime? Created { get; set; }

        /// <summary>
        /// The task&#39;s due date. [Default format](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/) &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;.
        /// </summary>
        /// <value>The task&#39;s due date. [Default format](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/) &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;.</value>
        [DataMember(Name = "due", EmitDefaultValue = true)]
        public DateTime? Due { get; set; }

        /// <summary>
        /// The follow-up date for the task. [Default format](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/) &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;.
        /// </summary>
        /// <value>The follow-up date for the task. [Default format](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/) &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;.</value>
        [DataMember(Name = "followUp", EmitDefaultValue = true)]
        public DateTime? FollowUp { get; set; }

        /// <summary>
        /// The task&#39;s description.
        /// </summary>
        /// <value>The task&#39;s description.</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// The id of the execution the task belongs to.
        /// </summary>
        /// <value>The id of the execution the task belongs to.</value>
        [DataMember(Name = "executionId", EmitDefaultValue = true)]
        public string ExecutionId { get; set; }

        /// <summary>
        /// The id the parent task, if this task is a subtask.
        /// </summary>
        /// <value>The id the parent task, if this task is a subtask.</value>
        [DataMember(Name = "parentTaskId", EmitDefaultValue = true)]
        public string ParentTaskId { get; set; }

        /// <summary>
        /// The task&#39;s priority.
        /// </summary>
        /// <value>The task&#39;s priority.</value>
        [DataMember(Name = "priority", EmitDefaultValue = true)]
        public int? Priority { get; set; }

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
        /// The id of the case execution the task belongs to.
        /// </summary>
        /// <value>The id of the case execution the task belongs to.</value>
        [DataMember(Name = "caseExecutionId", EmitDefaultValue = true)]
        public string CaseExecutionId { get; set; }

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
        /// The task&#39;s key.
        /// </summary>
        /// <value>The task&#39;s key.</value>
        [DataMember(Name = "taskDefinitionKey", EmitDefaultValue = true)]
        public string TaskDefinitionKey { get; set; }

        /// <summary>
        /// Whether the task belongs to a process instance that is suspended.
        /// </summary>
        /// <value>Whether the task belongs to a process instance that is suspended.</value>
        [DataMember(Name = "suspended", EmitDefaultValue = true)]
        public bool? Suspended { get; set; }

        /// <summary>
        /// If not &#x60;null&#x60;, the form key for the task.
        /// </summary>
        /// <value>If not &#x60;null&#x60;, the form key for the task.</value>
        [DataMember(Name = "formKey", EmitDefaultValue = true)]
        public string FormKey { get; set; }

        /// <summary>
        /// A reference to a specific version of a Camunda Form.
        /// </summary>
        /// <value>A reference to a specific version of a Camunda Form.</value>
        [DataMember(Name = "camundaFormRef", EmitDefaultValue = true)]
        public Dictionary<string, CamundaFormRef> CamundaFormRef { get; set; }

        /// <summary>
        /// If not &#x60;null&#x60;, the tenant id of the task.
        /// </summary>
        /// <value>If not &#x60;null&#x60;, the tenant id of the task.</value>
        [DataMember(Name = "tenantId", EmitDefaultValue = true)]
        public string TenantId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Assignee: ").Append(Assignee).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Due: ").Append(Due).Append("\n");
            sb.Append("  FollowUp: ").Append(FollowUp).Append("\n");
            sb.Append("  DelegationState: ").Append(DelegationState).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ExecutionId: ").Append(ExecutionId).Append("\n");
            sb.Append("  ParentTaskId: ").Append(ParentTaskId).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  ProcessDefinitionId: ").Append(ProcessDefinitionId).Append("\n");
            sb.Append("  ProcessInstanceId: ").Append(ProcessInstanceId).Append("\n");
            sb.Append("  CaseExecutionId: ").Append(CaseExecutionId).Append("\n");
            sb.Append("  CaseDefinitionId: ").Append(CaseDefinitionId).Append("\n");
            sb.Append("  CaseInstanceId: ").Append(CaseInstanceId).Append("\n");
            sb.Append("  TaskDefinitionKey: ").Append(TaskDefinitionKey).Append("\n");
            sb.Append("  Suspended: ").Append(Suspended).Append("\n");
            sb.Append("  FormKey: ").Append(FormKey).Append("\n");
            sb.Append("  CamundaFormRef: ").Append(CamundaFormRef).Append("\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
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
            return this.Equals(input as TaskDto);
        }

        /// <summary>
        /// Returns true if TaskDto instances are equal
        /// </summary>
        /// <param name="input">Instance of TaskDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaskDto input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Assignee == input.Assignee ||
                    (this.Assignee != null &&
                    this.Assignee.Equals(input.Assignee))
                ) && 
                (
                    this.Owner == input.Owner ||
                    (this.Owner != null &&
                    this.Owner.Equals(input.Owner))
                ) && 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && 
                (
                    this.Due == input.Due ||
                    (this.Due != null &&
                    this.Due.Equals(input.Due))
                ) && 
                (
                    this.FollowUp == input.FollowUp ||
                    (this.FollowUp != null &&
                    this.FollowUp.Equals(input.FollowUp))
                ) && 
                (
                    this.DelegationState == input.DelegationState ||
                    this.DelegationState.Equals(input.DelegationState)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.ExecutionId == input.ExecutionId ||
                    (this.ExecutionId != null &&
                    this.ExecutionId.Equals(input.ExecutionId))
                ) && 
                (
                    this.ParentTaskId == input.ParentTaskId ||
                    (this.ParentTaskId != null &&
                    this.ParentTaskId.Equals(input.ParentTaskId))
                ) && 
                (
                    this.Priority == input.Priority ||
                    (this.Priority != null &&
                    this.Priority.Equals(input.Priority))
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
                    this.CaseExecutionId == input.CaseExecutionId ||
                    (this.CaseExecutionId != null &&
                    this.CaseExecutionId.Equals(input.CaseExecutionId))
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
                    this.TaskDefinitionKey == input.TaskDefinitionKey ||
                    (this.TaskDefinitionKey != null &&
                    this.TaskDefinitionKey.Equals(input.TaskDefinitionKey))
                ) && 
                (
                    this.Suspended == input.Suspended ||
                    (this.Suspended != null &&
                    this.Suspended.Equals(input.Suspended))
                ) && 
                (
                    this.FormKey == input.FormKey ||
                    (this.FormKey != null &&
                    this.FormKey.Equals(input.FormKey))
                ) && 
                (
                    this.CamundaFormRef == input.CamundaFormRef ||
                    this.CamundaFormRef != null &&
                    input.CamundaFormRef != null &&
                    this.CamundaFormRef.SequenceEqual(input.CamundaFormRef)
                ) && 
                (
                    this.TenantId == input.TenantId ||
                    (this.TenantId != null &&
                    this.TenantId.Equals(input.TenantId))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Assignee != null)
                    hashCode = hashCode * 59 + this.Assignee.GetHashCode();
                if (this.Owner != null)
                    hashCode = hashCode * 59 + this.Owner.GetHashCode();
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.Due != null)
                    hashCode = hashCode * 59 + this.Due.GetHashCode();
                if (this.FollowUp != null)
                    hashCode = hashCode * 59 + this.FollowUp.GetHashCode();
                hashCode = hashCode * 59 + this.DelegationState.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.ExecutionId != null)
                    hashCode = hashCode * 59 + this.ExecutionId.GetHashCode();
                if (this.ParentTaskId != null)
                    hashCode = hashCode * 59 + this.ParentTaskId.GetHashCode();
                if (this.Priority != null)
                    hashCode = hashCode * 59 + this.Priority.GetHashCode();
                if (this.ProcessDefinitionId != null)
                    hashCode = hashCode * 59 + this.ProcessDefinitionId.GetHashCode();
                if (this.ProcessInstanceId != null)
                    hashCode = hashCode * 59 + this.ProcessInstanceId.GetHashCode();
                if (this.CaseExecutionId != null)
                    hashCode = hashCode * 59 + this.CaseExecutionId.GetHashCode();
                if (this.CaseDefinitionId != null)
                    hashCode = hashCode * 59 + this.CaseDefinitionId.GetHashCode();
                if (this.CaseInstanceId != null)
                    hashCode = hashCode * 59 + this.CaseInstanceId.GetHashCode();
                if (this.TaskDefinitionKey != null)
                    hashCode = hashCode * 59 + this.TaskDefinitionKey.GetHashCode();
                if (this.Suspended != null)
                    hashCode = hashCode * 59 + this.Suspended.GetHashCode();
                if (this.FormKey != null)
                    hashCode = hashCode * 59 + this.FormKey.GetHashCode();
                if (this.CamundaFormRef != null)
                    hashCode = hashCode * 59 + this.CamundaFormRef.GetHashCode();
                if (this.TenantId != null)
                    hashCode = hashCode * 59 + this.TenantId.GetHashCode();
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
