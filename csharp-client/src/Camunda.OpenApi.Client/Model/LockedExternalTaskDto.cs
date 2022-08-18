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
    /// LockedExternalTaskDto
    /// </summary>
    [DataContract(Name = "LockedExternalTaskDto")]
    public partial class LockedExternalTaskDto : IEquatable<LockedExternalTaskDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LockedExternalTaskDto" /> class.
        /// </summary>
        /// <param name="activityId">The id of the activity that this external task belongs to..</param>
        /// <param name="activityInstanceId">The id of the activity instance that the external task belongs to..</param>
        /// <param name="errorMessage">The full error message submitted with the latest reported failure executing this task;&#x60;null&#x60; if no failure was reported previously or if no error message was submitted.</param>
        /// <param name="errorDetails">The error details submitted with the latest reported failure executing this task.&#x60;null&#x60; if no failure was reported previously or if no error details was submitted.</param>
        /// <param name="executionId">The id of the execution that the external task belongs to..</param>
        /// <param name="id">The id of the external task..</param>
        /// <param name="lockExpirationTime">The date that the task&#39;s most recent lock expires or has expired..</param>
        /// <param name="processDefinitionId">The id of the process definition the external task is defined in..</param>
        /// <param name="processDefinitionKey">The key of the process definition the external task is defined in..</param>
        /// <param name="processDefinitionVersionTag">The version tag of the process definition the external task is defined in..</param>
        /// <param name="processInstanceId">The id of the process instance the external task belongs to..</param>
        /// <param name="tenantId">The id of the tenant the external task belongs to..</param>
        /// <param name="retries">The number of retries the task currently has left..</param>
        /// <param name="suspended">Whether the process instance the external task belongs to is suspended..</param>
        /// <param name="workerId">The id of the worker that posesses or posessed the most recent lock..</param>
        /// <param name="priority">The priority of the external task..</param>
        /// <param name="topicName">The topic name of the external task..</param>
        /// <param name="businessKey">The business key of the process instance the external task belongs to..</param>
        /// <param name="variables">A JSON object containing a property for each of the requested variables. The key is the variable name, the value is a JSON object of serialized variable values with the following properties:.</param>
        public LockedExternalTaskDto(string activityId = default(string), string activityInstanceId = default(string), string errorMessage = default(string), string errorDetails = default(string), string executionId = default(string), string id = default(string), DateTime? lockExpirationTime = default(DateTime?), string processDefinitionId = default(string), string processDefinitionKey = default(string), string processDefinitionVersionTag = default(string), string processInstanceId = default(string), string tenantId = default(string), int? retries = default(int?), bool? suspended = default(bool?), string workerId = default(string), long? priority = default(long?), string topicName = default(string), string businessKey = default(string), Dictionary<string, VariableValueDto> variables = default(Dictionary<string, VariableValueDto>))
        {
            this.ActivityId = activityId;
            this.ActivityInstanceId = activityInstanceId;
            this.ErrorMessage = errorMessage;
            this.ErrorDetails = errorDetails;
            this.ExecutionId = executionId;
            this.Id = id;
            this.LockExpirationTime = lockExpirationTime;
            this.ProcessDefinitionId = processDefinitionId;
            this.ProcessDefinitionKey = processDefinitionKey;
            this.ProcessDefinitionVersionTag = processDefinitionVersionTag;
            this.ProcessInstanceId = processInstanceId;
            this.TenantId = tenantId;
            this.Retries = retries;
            this.Suspended = suspended;
            this.WorkerId = workerId;
            this.Priority = priority;
            this.TopicName = topicName;
            this.BusinessKey = businessKey;
            this.Variables = variables;
        }

        /// <summary>
        /// The id of the activity that this external task belongs to.
        /// </summary>
        /// <value>The id of the activity that this external task belongs to.</value>
        [DataMember(Name = "activityId", EmitDefaultValue = true)]
        public string ActivityId { get; set; }

        /// <summary>
        /// The id of the activity instance that the external task belongs to.
        /// </summary>
        /// <value>The id of the activity instance that the external task belongs to.</value>
        [DataMember(Name = "activityInstanceId", EmitDefaultValue = true)]
        public string ActivityInstanceId { get; set; }

        /// <summary>
        /// The full error message submitted with the latest reported failure executing this task;&#x60;null&#x60; if no failure was reported previously or if no error message was submitted
        /// </summary>
        /// <value>The full error message submitted with the latest reported failure executing this task;&#x60;null&#x60; if no failure was reported previously or if no error message was submitted</value>
        [DataMember(Name = "errorMessage", EmitDefaultValue = true)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The error details submitted with the latest reported failure executing this task.&#x60;null&#x60; if no failure was reported previously or if no error details was submitted
        /// </summary>
        /// <value>The error details submitted with the latest reported failure executing this task.&#x60;null&#x60; if no failure was reported previously or if no error details was submitted</value>
        [DataMember(Name = "errorDetails", EmitDefaultValue = true)]
        public string ErrorDetails { get; set; }

        /// <summary>
        /// The id of the execution that the external task belongs to.
        /// </summary>
        /// <value>The id of the execution that the external task belongs to.</value>
        [DataMember(Name = "executionId", EmitDefaultValue = true)]
        public string ExecutionId { get; set; }

        /// <summary>
        /// The id of the external task.
        /// </summary>
        /// <value>The id of the external task.</value>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// The date that the task&#39;s most recent lock expires or has expired.
        /// </summary>
        /// <value>The date that the task&#39;s most recent lock expires or has expired.</value>
        [DataMember(Name = "lockExpirationTime", EmitDefaultValue = true)]
        public DateTime? LockExpirationTime { get; set; }

        /// <summary>
        /// The id of the process definition the external task is defined in.
        /// </summary>
        /// <value>The id of the process definition the external task is defined in.</value>
        [DataMember(Name = "processDefinitionId", EmitDefaultValue = true)]
        public string ProcessDefinitionId { get; set; }

        /// <summary>
        /// The key of the process definition the external task is defined in.
        /// </summary>
        /// <value>The key of the process definition the external task is defined in.</value>
        [DataMember(Name = "processDefinitionKey", EmitDefaultValue = true)]
        public string ProcessDefinitionKey { get; set; }

        /// <summary>
        /// The version tag of the process definition the external task is defined in.
        /// </summary>
        /// <value>The version tag of the process definition the external task is defined in.</value>
        [DataMember(Name = "processDefinitionVersionTag", EmitDefaultValue = true)]
        public string ProcessDefinitionVersionTag { get; set; }

        /// <summary>
        /// The id of the process instance the external task belongs to.
        /// </summary>
        /// <value>The id of the process instance the external task belongs to.</value>
        [DataMember(Name = "processInstanceId", EmitDefaultValue = true)]
        public string ProcessInstanceId { get; set; }

        /// <summary>
        /// The id of the tenant the external task belongs to.
        /// </summary>
        /// <value>The id of the tenant the external task belongs to.</value>
        [DataMember(Name = "tenantId", EmitDefaultValue = true)]
        public string TenantId { get; set; }

        /// <summary>
        /// The number of retries the task currently has left.
        /// </summary>
        /// <value>The number of retries the task currently has left.</value>
        [DataMember(Name = "retries", EmitDefaultValue = true)]
        public int? Retries { get; set; }

        /// <summary>
        /// Whether the process instance the external task belongs to is suspended.
        /// </summary>
        /// <value>Whether the process instance the external task belongs to is suspended.</value>
        [DataMember(Name = "suspended", EmitDefaultValue = true)]
        public bool? Suspended { get; set; }

        /// <summary>
        /// The id of the worker that posesses or posessed the most recent lock.
        /// </summary>
        /// <value>The id of the worker that posesses or posessed the most recent lock.</value>
        [DataMember(Name = "workerId", EmitDefaultValue = true)]
        public string WorkerId { get; set; }

        /// <summary>
        /// The priority of the external task.
        /// </summary>
        /// <value>The priority of the external task.</value>
        [DataMember(Name = "priority", EmitDefaultValue = true)]
        public long? Priority { get; set; }

        /// <summary>
        /// The topic name of the external task.
        /// </summary>
        /// <value>The topic name of the external task.</value>
        [DataMember(Name = "topicName", EmitDefaultValue = true)]
        public string TopicName { get; set; }

        /// <summary>
        /// The business key of the process instance the external task belongs to.
        /// </summary>
        /// <value>The business key of the process instance the external task belongs to.</value>
        [DataMember(Name = "businessKey", EmitDefaultValue = true)]
        public string BusinessKey { get; set; }

        /// <summary>
        /// A JSON object containing a property for each of the requested variables. The key is the variable name, the value is a JSON object of serialized variable values with the following properties:
        /// </summary>
        /// <value>A JSON object containing a property for each of the requested variables. The key is the variable name, the value is a JSON object of serialized variable values with the following properties:</value>
        [DataMember(Name = "variables", EmitDefaultValue = true)]
        public Dictionary<string, VariableValueDto> Variables { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LockedExternalTaskDto {\n");
            sb.Append("  ActivityId: ").Append(ActivityId).Append("\n");
            sb.Append("  ActivityInstanceId: ").Append(ActivityInstanceId).Append("\n");
            sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
            sb.Append("  ErrorDetails: ").Append(ErrorDetails).Append("\n");
            sb.Append("  ExecutionId: ").Append(ExecutionId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LockExpirationTime: ").Append(LockExpirationTime).Append("\n");
            sb.Append("  ProcessDefinitionId: ").Append(ProcessDefinitionId).Append("\n");
            sb.Append("  ProcessDefinitionKey: ").Append(ProcessDefinitionKey).Append("\n");
            sb.Append("  ProcessDefinitionVersionTag: ").Append(ProcessDefinitionVersionTag).Append("\n");
            sb.Append("  ProcessInstanceId: ").Append(ProcessInstanceId).Append("\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  Retries: ").Append(Retries).Append("\n");
            sb.Append("  Suspended: ").Append(Suspended).Append("\n");
            sb.Append("  WorkerId: ").Append(WorkerId).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  TopicName: ").Append(TopicName).Append("\n");
            sb.Append("  BusinessKey: ").Append(BusinessKey).Append("\n");
            sb.Append("  Variables: ").Append(Variables).Append("\n");
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
            return this.Equals(input as LockedExternalTaskDto);
        }

        /// <summary>
        /// Returns true if LockedExternalTaskDto instances are equal
        /// </summary>
        /// <param name="input">Instance of LockedExternalTaskDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LockedExternalTaskDto input)
        {
            if (input == null)
                return false;

            return 
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
                    this.ErrorMessage == input.ErrorMessage ||
                    (this.ErrorMessage != null &&
                    this.ErrorMessage.Equals(input.ErrorMessage))
                ) && 
                (
                    this.ErrorDetails == input.ErrorDetails ||
                    (this.ErrorDetails != null &&
                    this.ErrorDetails.Equals(input.ErrorDetails))
                ) && 
                (
                    this.ExecutionId == input.ExecutionId ||
                    (this.ExecutionId != null &&
                    this.ExecutionId.Equals(input.ExecutionId))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.LockExpirationTime == input.LockExpirationTime ||
                    (this.LockExpirationTime != null &&
                    this.LockExpirationTime.Equals(input.LockExpirationTime))
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
                    this.ProcessDefinitionVersionTag == input.ProcessDefinitionVersionTag ||
                    (this.ProcessDefinitionVersionTag != null &&
                    this.ProcessDefinitionVersionTag.Equals(input.ProcessDefinitionVersionTag))
                ) && 
                (
                    this.ProcessInstanceId == input.ProcessInstanceId ||
                    (this.ProcessInstanceId != null &&
                    this.ProcessInstanceId.Equals(input.ProcessInstanceId))
                ) && 
                (
                    this.TenantId == input.TenantId ||
                    (this.TenantId != null &&
                    this.TenantId.Equals(input.TenantId))
                ) && 
                (
                    this.Retries == input.Retries ||
                    (this.Retries != null &&
                    this.Retries.Equals(input.Retries))
                ) && 
                (
                    this.Suspended == input.Suspended ||
                    (this.Suspended != null &&
                    this.Suspended.Equals(input.Suspended))
                ) && 
                (
                    this.WorkerId == input.WorkerId ||
                    (this.WorkerId != null &&
                    this.WorkerId.Equals(input.WorkerId))
                ) && 
                (
                    this.Priority == input.Priority ||
                    (this.Priority != null &&
                    this.Priority.Equals(input.Priority))
                ) && 
                (
                    this.TopicName == input.TopicName ||
                    (this.TopicName != null &&
                    this.TopicName.Equals(input.TopicName))
                ) && 
                (
                    this.BusinessKey == input.BusinessKey ||
                    (this.BusinessKey != null &&
                    this.BusinessKey.Equals(input.BusinessKey))
                ) && 
                (
                    this.Variables == input.Variables ||
                    this.Variables != null &&
                    input.Variables != null &&
                    this.Variables.SequenceEqual(input.Variables)
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
                if (this.ActivityId != null)
                    hashCode = hashCode * 59 + this.ActivityId.GetHashCode();
                if (this.ActivityInstanceId != null)
                    hashCode = hashCode * 59 + this.ActivityInstanceId.GetHashCode();
                if (this.ErrorMessage != null)
                    hashCode = hashCode * 59 + this.ErrorMessage.GetHashCode();
                if (this.ErrorDetails != null)
                    hashCode = hashCode * 59 + this.ErrorDetails.GetHashCode();
                if (this.ExecutionId != null)
                    hashCode = hashCode * 59 + this.ExecutionId.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.LockExpirationTime != null)
                    hashCode = hashCode * 59 + this.LockExpirationTime.GetHashCode();
                if (this.ProcessDefinitionId != null)
                    hashCode = hashCode * 59 + this.ProcessDefinitionId.GetHashCode();
                if (this.ProcessDefinitionKey != null)
                    hashCode = hashCode * 59 + this.ProcessDefinitionKey.GetHashCode();
                if (this.ProcessDefinitionVersionTag != null)
                    hashCode = hashCode * 59 + this.ProcessDefinitionVersionTag.GetHashCode();
                if (this.ProcessInstanceId != null)
                    hashCode = hashCode * 59 + this.ProcessInstanceId.GetHashCode();
                if (this.TenantId != null)
                    hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.Retries != null)
                    hashCode = hashCode * 59 + this.Retries.GetHashCode();
                if (this.Suspended != null)
                    hashCode = hashCode * 59 + this.Suspended.GetHashCode();
                if (this.WorkerId != null)
                    hashCode = hashCode * 59 + this.WorkerId.GetHashCode();
                if (this.Priority != null)
                    hashCode = hashCode * 59 + this.Priority.GetHashCode();
                if (this.TopicName != null)
                    hashCode = hashCode * 59 + this.TopicName.GetHashCode();
                if (this.BusinessKey != null)
                    hashCode = hashCode * 59 + this.BusinessKey.GetHashCode();
                if (this.Variables != null)
                    hashCode = hashCode * 59 + this.Variables.GetHashCode();
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
