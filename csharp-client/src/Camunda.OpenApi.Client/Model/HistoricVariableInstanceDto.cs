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
    /// HistoricVariableInstanceDto
    /// </summary>
    [DataContract(Name = "HistoricVariableInstanceDto")]
    public partial class HistoricVariableInstanceDto : IEquatable<HistoricVariableInstanceDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HistoricVariableInstanceDto" /> class.
        /// </summary>
        /// <param name="id">The id of the variable instance..</param>
        /// <param name="name">The name of the variable instance..</param>
        /// <param name="processDefinitionKey">The key of the process definition the variable instance belongs to..</param>
        /// <param name="processDefinitionId">The id of the process definition the variable instance belongs to..</param>
        /// <param name="processInstanceId">The process instance id the variable instance belongs to..</param>
        /// <param name="executionId">The execution id the variable instance belongs to..</param>
        /// <param name="activityInstanceId">The id of the activity instance in which the variable is valid..</param>
        /// <param name="caseDefinitionKey">The key of the case definition the variable instance belongs to..</param>
        /// <param name="caseDefinitionId">The id of the case definition the variable instance belongs to..</param>
        /// <param name="caseInstanceId">The case instance id the variable instance belongs to..</param>
        /// <param name="caseExecutionId">The case execution id the variable instance belongs to..</param>
        /// <param name="taskId">The id of the task the variable instance belongs to..</param>
        /// <param name="tenantId">The id of the tenant that this variable instance belongs to..</param>
        /// <param name="errorMessage">An error message in case a Java Serialized Object could not be de-serialized..</param>
        /// <param name="state">The current state of the variable. Can be &#39;CREATED&#39; or &#39;DELETED&#39;..</param>
        /// <param name="createTime">The time the variable was inserted. [Default format](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/) &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;..</param>
        /// <param name="removalTime">The time after which the variable should be removed by the History Cleanup job. [Default format](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/) &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;..</param>
        /// <param name="rootProcessInstanceId">The process instance id of the root process instance that initiated the process containing this variable..</param>
        /// <param name="value">Can be any value - string, number, boolean, array or object.  **Note**: Not every endpoint supports every type..</param>
        /// <param name="type">The value type of the variable..</param>
        /// <param name="valueInfo">A JSON object containing additional, value-type-dependent properties. For serialized variables of type Object, the following properties can be provided:  * &#x60;objectTypeName&#x60;: A string representation of the object&#39;s type name. * &#x60;serializationDataFormat&#x60;: The serialization format used to store the variable.  For serialized variables of type File, the following properties can be provided:  * &#x60;filename&#x60;: The name of the file. This is not the variable name but the name that will be used when downloading the file again. * &#x60;mimetype&#x60;: The MIME type of the file that is being uploaded. * &#x60;encoding&#x60;: The encoding of the file that is being uploaded.  The following property can be provided for all value types:  * &#x60;transient&#x60;: Indicates whether the variable should be transient or not. See [documentation](https://docs.camunda.org/manual/7.17/user-guide/process-engine/variables#transient-variables) for more informations. (Not applicable for &#x60;decision-definition&#x60;, &#x60; /process-instance/variables-async&#x60;, and &#x60;/migration/executeAsync&#x60; endpoints).</param>
        public HistoricVariableInstanceDto(string id = default(string), string name = default(string), string processDefinitionKey = default(string), string processDefinitionId = default(string), string processInstanceId = default(string), string executionId = default(string), string activityInstanceId = default(string), string caseDefinitionKey = default(string), string caseDefinitionId = default(string), string caseInstanceId = default(string), string caseExecutionId = default(string), string taskId = default(string), string tenantId = default(string), string errorMessage = default(string), string state = default(string), DateTime? createTime = default(DateTime?), DateTime? removalTime = default(DateTime?), string rootProcessInstanceId = default(string), Object value = default(Object), string type = default(string), Dictionary<string, Object> valueInfo = default(Dictionary<string, Object>))
        {
            this.Id = id;
            this.Name = name;
            this.ProcessDefinitionKey = processDefinitionKey;
            this.ProcessDefinitionId = processDefinitionId;
            this.ProcessInstanceId = processInstanceId;
            this.ExecutionId = executionId;
            this.ActivityInstanceId = activityInstanceId;
            this.CaseDefinitionKey = caseDefinitionKey;
            this.CaseDefinitionId = caseDefinitionId;
            this.CaseInstanceId = caseInstanceId;
            this.CaseExecutionId = caseExecutionId;
            this.TaskId = taskId;
            this.TenantId = tenantId;
            this.ErrorMessage = errorMessage;
            this.State = state;
            this.CreateTime = createTime;
            this.RemovalTime = removalTime;
            this.RootProcessInstanceId = rootProcessInstanceId;
            this.Value = value;
            this.Type = type;
            this.ValueInfo = valueInfo;
        }

        /// <summary>
        /// The id of the variable instance.
        /// </summary>
        /// <value>The id of the variable instance.</value>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// The name of the variable instance.
        /// </summary>
        /// <value>The name of the variable instance.</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The key of the process definition the variable instance belongs to.
        /// </summary>
        /// <value>The key of the process definition the variable instance belongs to.</value>
        [DataMember(Name = "processDefinitionKey", EmitDefaultValue = true)]
        public string ProcessDefinitionKey { get; set; }

        /// <summary>
        /// The id of the process definition the variable instance belongs to.
        /// </summary>
        /// <value>The id of the process definition the variable instance belongs to.</value>
        [DataMember(Name = "processDefinitionId", EmitDefaultValue = true)]
        public string ProcessDefinitionId { get; set; }

        /// <summary>
        /// The process instance id the variable instance belongs to.
        /// </summary>
        /// <value>The process instance id the variable instance belongs to.</value>
        [DataMember(Name = "processInstanceId", EmitDefaultValue = true)]
        public string ProcessInstanceId { get; set; }

        /// <summary>
        /// The execution id the variable instance belongs to.
        /// </summary>
        /// <value>The execution id the variable instance belongs to.</value>
        [DataMember(Name = "executionId", EmitDefaultValue = true)]
        public string ExecutionId { get; set; }

        /// <summary>
        /// The id of the activity instance in which the variable is valid.
        /// </summary>
        /// <value>The id of the activity instance in which the variable is valid.</value>
        [DataMember(Name = "activityInstanceId", EmitDefaultValue = true)]
        public string ActivityInstanceId { get; set; }

        /// <summary>
        /// The key of the case definition the variable instance belongs to.
        /// </summary>
        /// <value>The key of the case definition the variable instance belongs to.</value>
        [DataMember(Name = "caseDefinitionKey", EmitDefaultValue = true)]
        public string CaseDefinitionKey { get; set; }

        /// <summary>
        /// The id of the case definition the variable instance belongs to.
        /// </summary>
        /// <value>The id of the case definition the variable instance belongs to.</value>
        [DataMember(Name = "caseDefinitionId", EmitDefaultValue = true)]
        public string CaseDefinitionId { get; set; }

        /// <summary>
        /// The case instance id the variable instance belongs to.
        /// </summary>
        /// <value>The case instance id the variable instance belongs to.</value>
        [DataMember(Name = "caseInstanceId", EmitDefaultValue = true)]
        public string CaseInstanceId { get; set; }

        /// <summary>
        /// The case execution id the variable instance belongs to.
        /// </summary>
        /// <value>The case execution id the variable instance belongs to.</value>
        [DataMember(Name = "caseExecutionId", EmitDefaultValue = true)]
        public string CaseExecutionId { get; set; }

        /// <summary>
        /// The id of the task the variable instance belongs to.
        /// </summary>
        /// <value>The id of the task the variable instance belongs to.</value>
        [DataMember(Name = "taskId", EmitDefaultValue = true)]
        public string TaskId { get; set; }

        /// <summary>
        /// The id of the tenant that this variable instance belongs to.
        /// </summary>
        /// <value>The id of the tenant that this variable instance belongs to.</value>
        [DataMember(Name = "tenantId", EmitDefaultValue = true)]
        public string TenantId { get; set; }

        /// <summary>
        /// An error message in case a Java Serialized Object could not be de-serialized.
        /// </summary>
        /// <value>An error message in case a Java Serialized Object could not be de-serialized.</value>
        [DataMember(Name = "errorMessage", EmitDefaultValue = true)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The current state of the variable. Can be &#39;CREATED&#39; or &#39;DELETED&#39;.
        /// </summary>
        /// <value>The current state of the variable. Can be &#39;CREATED&#39; or &#39;DELETED&#39;.</value>
        [DataMember(Name = "state", EmitDefaultValue = true)]
        public string State { get; set; }

        /// <summary>
        /// The time the variable was inserted. [Default format](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/) &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;.
        /// </summary>
        /// <value>The time the variable was inserted. [Default format](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/) &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;.</value>
        [DataMember(Name = "createTime", EmitDefaultValue = true)]
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// The time after which the variable should be removed by the History Cleanup job. [Default format](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/) &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;.
        /// </summary>
        /// <value>The time after which the variable should be removed by the History Cleanup job. [Default format](https://docs.camunda.org/manual/7.17/reference/rest/overview/date-format/) &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;.</value>
        [DataMember(Name = "removalTime", EmitDefaultValue = true)]
        public DateTime? RemovalTime { get; set; }

        /// <summary>
        /// The process instance id of the root process instance that initiated the process containing this variable.
        /// </summary>
        /// <value>The process instance id of the root process instance that initiated the process containing this variable.</value>
        [DataMember(Name = "rootProcessInstanceId", EmitDefaultValue = true)]
        public string RootProcessInstanceId { get; set; }

        /// <summary>
        /// Can be any value - string, number, boolean, array or object.  **Note**: Not every endpoint supports every type.
        /// </summary>
        /// <value>Can be any value - string, number, boolean, array or object.  **Note**: Not every endpoint supports every type.</value>
        [DataMember(Name = "value", EmitDefaultValue = true)]
        public Object Value { get; set; }

        /// <summary>
        /// The value type of the variable.
        /// </summary>
        /// <value>The value type of the variable.</value>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// A JSON object containing additional, value-type-dependent properties. For serialized variables of type Object, the following properties can be provided:  * &#x60;objectTypeName&#x60;: A string representation of the object&#39;s type name. * &#x60;serializationDataFormat&#x60;: The serialization format used to store the variable.  For serialized variables of type File, the following properties can be provided:  * &#x60;filename&#x60;: The name of the file. This is not the variable name but the name that will be used when downloading the file again. * &#x60;mimetype&#x60;: The MIME type of the file that is being uploaded. * &#x60;encoding&#x60;: The encoding of the file that is being uploaded.  The following property can be provided for all value types:  * &#x60;transient&#x60;: Indicates whether the variable should be transient or not. See [documentation](https://docs.camunda.org/manual/7.17/user-guide/process-engine/variables#transient-variables) for more informations. (Not applicable for &#x60;decision-definition&#x60;, &#x60; /process-instance/variables-async&#x60;, and &#x60;/migration/executeAsync&#x60; endpoints)
        /// </summary>
        /// <value>A JSON object containing additional, value-type-dependent properties. For serialized variables of type Object, the following properties can be provided:  * &#x60;objectTypeName&#x60;: A string representation of the object&#39;s type name. * &#x60;serializationDataFormat&#x60;: The serialization format used to store the variable.  For serialized variables of type File, the following properties can be provided:  * &#x60;filename&#x60;: The name of the file. This is not the variable name but the name that will be used when downloading the file again. * &#x60;mimetype&#x60;: The MIME type of the file that is being uploaded. * &#x60;encoding&#x60;: The encoding of the file that is being uploaded.  The following property can be provided for all value types:  * &#x60;transient&#x60;: Indicates whether the variable should be transient or not. See [documentation](https://docs.camunda.org/manual/7.17/user-guide/process-engine/variables#transient-variables) for more informations. (Not applicable for &#x60;decision-definition&#x60;, &#x60; /process-instance/variables-async&#x60;, and &#x60;/migration/executeAsync&#x60; endpoints)</value>
        [DataMember(Name = "valueInfo", EmitDefaultValue = false)]
        public Dictionary<string, Object> ValueInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HistoricVariableInstanceDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ProcessDefinitionKey: ").Append(ProcessDefinitionKey).Append("\n");
            sb.Append("  ProcessDefinitionId: ").Append(ProcessDefinitionId).Append("\n");
            sb.Append("  ProcessInstanceId: ").Append(ProcessInstanceId).Append("\n");
            sb.Append("  ExecutionId: ").Append(ExecutionId).Append("\n");
            sb.Append("  ActivityInstanceId: ").Append(ActivityInstanceId).Append("\n");
            sb.Append("  CaseDefinitionKey: ").Append(CaseDefinitionKey).Append("\n");
            sb.Append("  CaseDefinitionId: ").Append(CaseDefinitionId).Append("\n");
            sb.Append("  CaseInstanceId: ").Append(CaseInstanceId).Append("\n");
            sb.Append("  CaseExecutionId: ").Append(CaseExecutionId).Append("\n");
            sb.Append("  TaskId: ").Append(TaskId).Append("\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  CreateTime: ").Append(CreateTime).Append("\n");
            sb.Append("  RemovalTime: ").Append(RemovalTime).Append("\n");
            sb.Append("  RootProcessInstanceId: ").Append(RootProcessInstanceId).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ValueInfo: ").Append(ValueInfo).Append("\n");
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
            return this.Equals(input as HistoricVariableInstanceDto);
        }

        /// <summary>
        /// Returns true if HistoricVariableInstanceDto instances are equal
        /// </summary>
        /// <param name="input">Instance of HistoricVariableInstanceDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HistoricVariableInstanceDto input)
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
                    this.ActivityInstanceId == input.ActivityInstanceId ||
                    (this.ActivityInstanceId != null &&
                    this.ActivityInstanceId.Equals(input.ActivityInstanceId))
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
                    this.TaskId == input.TaskId ||
                    (this.TaskId != null &&
                    this.TaskId.Equals(input.TaskId))
                ) && 
                (
                    this.TenantId == input.TenantId ||
                    (this.TenantId != null &&
                    this.TenantId.Equals(input.TenantId))
                ) && 
                (
                    this.ErrorMessage == input.ErrorMessage ||
                    (this.ErrorMessage != null &&
                    this.ErrorMessage.Equals(input.ErrorMessage))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.CreateTime == input.CreateTime ||
                    (this.CreateTime != null &&
                    this.CreateTime.Equals(input.CreateTime))
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
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.ValueInfo == input.ValueInfo ||
                    this.ValueInfo != null &&
                    input.ValueInfo != null &&
                    this.ValueInfo.SequenceEqual(input.ValueInfo)
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
                if (this.ProcessDefinitionKey != null)
                    hashCode = hashCode * 59 + this.ProcessDefinitionKey.GetHashCode();
                if (this.ProcessDefinitionId != null)
                    hashCode = hashCode * 59 + this.ProcessDefinitionId.GetHashCode();
                if (this.ProcessInstanceId != null)
                    hashCode = hashCode * 59 + this.ProcessInstanceId.GetHashCode();
                if (this.ExecutionId != null)
                    hashCode = hashCode * 59 + this.ExecutionId.GetHashCode();
                if (this.ActivityInstanceId != null)
                    hashCode = hashCode * 59 + this.ActivityInstanceId.GetHashCode();
                if (this.CaseDefinitionKey != null)
                    hashCode = hashCode * 59 + this.CaseDefinitionKey.GetHashCode();
                if (this.CaseDefinitionId != null)
                    hashCode = hashCode * 59 + this.CaseDefinitionId.GetHashCode();
                if (this.CaseInstanceId != null)
                    hashCode = hashCode * 59 + this.CaseInstanceId.GetHashCode();
                if (this.CaseExecutionId != null)
                    hashCode = hashCode * 59 + this.CaseExecutionId.GetHashCode();
                if (this.TaskId != null)
                    hashCode = hashCode * 59 + this.TaskId.GetHashCode();
                if (this.TenantId != null)
                    hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.ErrorMessage != null)
                    hashCode = hashCode * 59 + this.ErrorMessage.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.CreateTime != null)
                    hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.RemovalTime != null)
                    hashCode = hashCode * 59 + this.RemovalTime.GetHashCode();
                if (this.RootProcessInstanceId != null)
                    hashCode = hashCode * 59 + this.RootProcessInstanceId.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.ValueInfo != null)
                    hashCode = hashCode * 59 + this.ValueInfo.GetHashCode();
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
