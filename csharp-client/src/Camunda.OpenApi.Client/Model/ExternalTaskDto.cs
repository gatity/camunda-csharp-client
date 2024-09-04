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
    /// An External Task object with the following properties
    /// </summary>
    [DataContract(Name = "ExternalTaskDto")]
    public partial class ExternalTaskDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalTaskDto" /> class.
        /// </summary>
        /// <param name="activityId">The id of the activity that this external task belongs to..</param>
        /// <param name="activityInstanceId">The id of the activity instance that the external task belongs to..</param>
        /// <param name="errorMessage">The full error message submitted with the latest reported failure executing this task; &#x60;null&#x60; if no failure was reported previously or if no error message was submitted.</param>
        /// <param name="executionId">The id of the execution that the external task belongs to..</param>
        /// <param name="id">The id of the external task..</param>
        /// <param name="lockExpirationTime">The date that the task&#39;s most recent lock expires or has expired..</param>
        /// <param name="processDefinitionId">The id of the process definition the external task is defined in..</param>
        /// <param name="processDefinitionKey">The key of the process definition the external task is defined in..</param>
        /// <param name="processDefinitionVersionTag">The version tag of the process definition the external task is defined in..</param>
        /// <param name="processInstanceId">The id of the process instance the external task belongs to..</param>
        /// <param name="tenantId">The id of the tenant the external task belongs to..</param>
        /// <param name="retries">The number of retries the task currently has left..</param>
        /// <param name="suspended">A flag indicating whether the external task is suspended or not..</param>
        /// <param name="workerId">The id of the worker that posesses or posessed the most recent lock..</param>
        /// <param name="topicName">The topic name of the external task..</param>
        /// <param name="priority">The priority of the external task..</param>
        /// <param name="businessKey">The business key of the process instance the external task belongs to..</param>
        public ExternalTaskDto(string activityId = default(string), string activityInstanceId = default(string), string errorMessage = default(string), string executionId = default(string), string id = default(string), DateTime? lockExpirationTime = default(DateTime?), string processDefinitionId = default(string), string processDefinitionKey = default(string), string processDefinitionVersionTag = default(string), string processInstanceId = default(string), string tenantId = default(string), int? retries = default(int?), bool? suspended = default(bool?), string workerId = default(string), string topicName = default(string), long? priority = default(long?), string businessKey = default(string))
        {
            this.ActivityId = activityId;
            this.ActivityInstanceId = activityInstanceId;
            this.ErrorMessage = errorMessage;
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
            this.TopicName = topicName;
            this.Priority = priority;
            this.BusinessKey = businessKey;
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
        /// The full error message submitted with the latest reported failure executing this task; &#x60;null&#x60; if no failure was reported previously or if no error message was submitted
        /// </summary>
        /// <value>The full error message submitted with the latest reported failure executing this task; &#x60;null&#x60; if no failure was reported previously or if no error message was submitted</value>
        [DataMember(Name = "errorMessage", EmitDefaultValue = true)]
        public string ErrorMessage { get; set; }

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
        /// A flag indicating whether the external task is suspended or not.
        /// </summary>
        /// <value>A flag indicating whether the external task is suspended or not.</value>
        [DataMember(Name = "suspended", EmitDefaultValue = true)]
        public bool? Suspended { get; set; }

        /// <summary>
        /// The id of the worker that posesses or posessed the most recent lock.
        /// </summary>
        /// <value>The id of the worker that posesses or posessed the most recent lock.</value>
        [DataMember(Name = "workerId", EmitDefaultValue = true)]
        public string WorkerId { get; set; }

        /// <summary>
        /// The topic name of the external task.
        /// </summary>
        /// <value>The topic name of the external task.</value>
        [DataMember(Name = "topicName", EmitDefaultValue = true)]
        public string TopicName { get; set; }

        /// <summary>
        /// The priority of the external task.
        /// </summary>
        /// <value>The priority of the external task.</value>
        [DataMember(Name = "priority", EmitDefaultValue = true)]
        public long? Priority { get; set; }

        /// <summary>
        /// The business key of the process instance the external task belongs to.
        /// </summary>
        /// <value>The business key of the process instance the external task belongs to.</value>
        [DataMember(Name = "businessKey", EmitDefaultValue = true)]
        public string BusinessKey { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ExternalTaskDto {\n");
            sb.Append("  ActivityId: ").Append(ActivityId).Append("\n");
            sb.Append("  ActivityInstanceId: ").Append(ActivityInstanceId).Append("\n");
            sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
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
            sb.Append("  TopicName: ").Append(TopicName).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  BusinessKey: ").Append(BusinessKey).Append("\n");
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
