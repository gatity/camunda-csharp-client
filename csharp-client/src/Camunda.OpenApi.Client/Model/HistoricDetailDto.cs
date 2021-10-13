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
    /// HistoricDetailDto
    /// </summary>
    [DataContract(Name = "HistoricDetailDto")]
    public partial class HistoricDetailDto : IEquatable<HistoricDetailDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HistoricDetailDto" /> class.
        /// </summary>
        /// <param name="id">The id of the historic detail..</param>
        /// <param name="type">The type of the historic detail. Either &#x60;formField&#x60; for a submitted form field value or &#x60;variableUpdate&#x60; for variable updates..</param>
        /// <param name="processDefinitionKey">The key of the process definition that this historic detail belongs to..</param>
        /// <param name="processDefinitionId">The id of the process definition that this historic detail belongs to..</param>
        /// <param name="processInstanceId">The id of the process instance the historic detail belongs to..</param>
        /// <param name="activityInstanceId">The id of the activity instance the historic detail belongs to..</param>
        /// <param name="executionId">The id of the execution the historic detail belongs to..</param>
        /// <param name="caseDefinitionKey">The key of the case definition that this historic detail belongs to..</param>
        /// <param name="caseDefinitionId">The id of the case definition that this historic detail belongs to..</param>
        /// <param name="caseInstanceId">The id of the case instance the historic detail belongs to..</param>
        /// <param name="caseExecutionId">The id of the case execution the historic detail belongs to..</param>
        /// <param name="taskId">The id of the task the historic detail belongs to..</param>
        /// <param name="tenantId">The id of the tenant that this historic detail belongs to..</param>
        /// <param name="userOperationId">The id of user operation which links historic detail with [user operation log](https://docs.camunda.org/manual/7.16/reference/rest/history/user-operation-log/) entries..</param>
        /// <param name="time">The time when this historic detail occurred. Default [format](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/) &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;..</param>
        /// <param name="removalTime">The time after which the historic detail should be removed by the History Cleanup job. Default [format](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/) &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;..</param>
        /// <param name="rootProcessInstanceId">The process instance id of the root process instance that initiated the process containing this historic detail..</param>
        /// <param name="fieldId">The id of the form field.  **Note:** This property is only set for a &#x60;HistoricVariableUpdate&#x60; historic details. In these cases, the value of the &#x60;type&#x60; property is &#x60;formField&#x60;..</param>
        /// <param name="fieldValue">The submitted form field value. The value differs depending on the form field&#39;s type and on the &#x60;deserializeValue&#x60; parameter.  **Note:** This property is only set for a &#x60;HistoricVariableUpdate&#x60; historic details. In these cases, the value of the &#x60;type&#x60; property is &#x60;formField&#x60;..</param>
        /// <param name="variableName">The name of the variable which has been updated.  **Note:** This property is only set for a &#x60;HistoricVariableUpdate&#x60; historic details. In these cases, the value of the &#x60;type&#x60; property is &#x60;variableUpdate&#x60;..</param>
        /// <param name="variableInstanceId">The id of the associated variable instance.  **Note:** This property is only set for a &#x60;HistoricVariableUpdate&#x60; historic details. In these cases, the value of the &#x60;type&#x60; property is &#x60;variableUpdate&#x60;..</param>
        /// <param name="variableType">The value type of the variable.  **Note:** This property is only set for a &#x60;HistoricVariableUpdate&#x60; historic details. In these cases, the value of the &#x60;type&#x60; property is &#x60;variableUpdate&#x60;..</param>
        /// <param name="value">The variable&#39;s value. Value differs depending on the variable&#39;s type and on the deserializeValues parameter.  **Note:** This property is only set for a &#x60;HistoricVariableUpdate&#x60; historic details. In these cases, the value of the &#x60;type&#x60; property is &#x60;variableUpdate&#x60;..</param>
        /// <param name="valueInfo">A JSON object containing additional, value-type-dependent properties. For variables of type &#x60;Object&#x60;, the following properties are returned:  * &#x60;objectTypeName&#x60;: A string representation of the object&#39;s type name. * &#x60;serializationDataFormat&#x60;: The serialization format used to store the variable.  **Note:** This property is only set for a &#x60;HistoricVariableUpdate&#x60; historic details. In these cases, the value of the &#x60;type&#x60; property is &#x60;variableUpdate&#x60;..</param>
        /// <param name="initial">Returns &#x60;true&#x60; for variable updates that contains the initial values of the variables.  **Note:** This property is only set for a &#x60;HistoricVariableUpdate&#x60; historic details. In these cases, the value of the &#x60;type&#x60; property is &#x60;variableUpdate&#x60;..</param>
        /// <param name="revision">The revision of the historic variable update.  **Note:** This property is only set for a &#x60;HistoricVariableUpdate&#x60; historic details. In these cases, the value of the &#x60;type&#x60; property is &#x60;variableUpdate&#x60;..</param>
        /// <param name="errorMessage">An error message in case a Java Serialized Object could not be de-serialized.  **Note:** This property is only set for a &#x60;HistoricVariableUpdate&#x60; historic details. In these cases, the value of the &#x60;type&#x60; property is &#x60;variableUpdate&#x60;..</param>
        public HistoricDetailDto(string id = default(string), string type = default(string), string processDefinitionKey = default(string), string processDefinitionId = default(string), string processInstanceId = default(string), string activityInstanceId = default(string), string executionId = default(string), string caseDefinitionKey = default(string), string caseDefinitionId = default(string), string caseInstanceId = default(string), string caseExecutionId = default(string), string taskId = default(string), string tenantId = default(string), string userOperationId = default(string), DateTime? time = default(DateTime?), DateTime? removalTime = default(DateTime?), string rootProcessInstanceId = default(string), string fieldId = default(string), Object fieldValue = default(Object), string variableName = default(string), string variableInstanceId = default(string), string variableType = default(string), Object value = default(Object), Dictionary<string, Object> valueInfo = default(Dictionary<string, Object>), bool? initial = default(bool?), int? revision = default(int?), string errorMessage = default(string))
        {
            this.Id = id;
            this.Type = type;
            this.ProcessDefinitionKey = processDefinitionKey;
            this.ProcessDefinitionId = processDefinitionId;
            this.ProcessInstanceId = processInstanceId;
            this.ActivityInstanceId = activityInstanceId;
            this.ExecutionId = executionId;
            this.CaseDefinitionKey = caseDefinitionKey;
            this.CaseDefinitionId = caseDefinitionId;
            this.CaseInstanceId = caseInstanceId;
            this.CaseExecutionId = caseExecutionId;
            this.TaskId = taskId;
            this.TenantId = tenantId;
            this.UserOperationId = userOperationId;
            this.Time = time;
            this.RemovalTime = removalTime;
            this.RootProcessInstanceId = rootProcessInstanceId;
            this.FieldId = fieldId;
            this.FieldValue = fieldValue;
            this.VariableName = variableName;
            this.VariableInstanceId = variableInstanceId;
            this.VariableType = variableType;
            this.Value = value;
            this.ValueInfo = valueInfo;
            this.Initial = initial;
            this.Revision = revision;
            this.ErrorMessage = errorMessage;
        }

        /// <summary>
        /// The id of the historic detail.
        /// </summary>
        /// <value>The id of the historic detail.</value>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// The type of the historic detail. Either &#x60;formField&#x60; for a submitted form field value or &#x60;variableUpdate&#x60; for variable updates.
        /// </summary>
        /// <value>The type of the historic detail. Either &#x60;formField&#x60; for a submitted form field value or &#x60;variableUpdate&#x60; for variable updates.</value>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// The key of the process definition that this historic detail belongs to.
        /// </summary>
        /// <value>The key of the process definition that this historic detail belongs to.</value>
        [DataMember(Name = "processDefinitionKey", EmitDefaultValue = true)]
        public string ProcessDefinitionKey { get; set; }

        /// <summary>
        /// The id of the process definition that this historic detail belongs to.
        /// </summary>
        /// <value>The id of the process definition that this historic detail belongs to.</value>
        [DataMember(Name = "processDefinitionId", EmitDefaultValue = true)]
        public string ProcessDefinitionId { get; set; }

        /// <summary>
        /// The id of the process instance the historic detail belongs to.
        /// </summary>
        /// <value>The id of the process instance the historic detail belongs to.</value>
        [DataMember(Name = "processInstanceId", EmitDefaultValue = true)]
        public string ProcessInstanceId { get; set; }

        /// <summary>
        /// The id of the activity instance the historic detail belongs to.
        /// </summary>
        /// <value>The id of the activity instance the historic detail belongs to.</value>
        [DataMember(Name = "activityInstanceId", EmitDefaultValue = true)]
        public string ActivityInstanceId { get; set; }

        /// <summary>
        /// The id of the execution the historic detail belongs to.
        /// </summary>
        /// <value>The id of the execution the historic detail belongs to.</value>
        [DataMember(Name = "executionId", EmitDefaultValue = true)]
        public string ExecutionId { get; set; }

        /// <summary>
        /// The key of the case definition that this historic detail belongs to.
        /// </summary>
        /// <value>The key of the case definition that this historic detail belongs to.</value>
        [DataMember(Name = "caseDefinitionKey", EmitDefaultValue = true)]
        public string CaseDefinitionKey { get; set; }

        /// <summary>
        /// The id of the case definition that this historic detail belongs to.
        /// </summary>
        /// <value>The id of the case definition that this historic detail belongs to.</value>
        [DataMember(Name = "caseDefinitionId", EmitDefaultValue = true)]
        public string CaseDefinitionId { get; set; }

        /// <summary>
        /// The id of the case instance the historic detail belongs to.
        /// </summary>
        /// <value>The id of the case instance the historic detail belongs to.</value>
        [DataMember(Name = "caseInstanceId", EmitDefaultValue = true)]
        public string CaseInstanceId { get; set; }

        /// <summary>
        /// The id of the case execution the historic detail belongs to.
        /// </summary>
        /// <value>The id of the case execution the historic detail belongs to.</value>
        [DataMember(Name = "caseExecutionId", EmitDefaultValue = true)]
        public string CaseExecutionId { get; set; }

        /// <summary>
        /// The id of the task the historic detail belongs to.
        /// </summary>
        /// <value>The id of the task the historic detail belongs to.</value>
        [DataMember(Name = "taskId", EmitDefaultValue = true)]
        public string TaskId { get; set; }

        /// <summary>
        /// The id of the tenant that this historic detail belongs to.
        /// </summary>
        /// <value>The id of the tenant that this historic detail belongs to.</value>
        [DataMember(Name = "tenantId", EmitDefaultValue = true)]
        public string TenantId { get; set; }

        /// <summary>
        /// The id of user operation which links historic detail with [user operation log](https://docs.camunda.org/manual/7.16/reference/rest/history/user-operation-log/) entries.
        /// </summary>
        /// <value>The id of user operation which links historic detail with [user operation log](https://docs.camunda.org/manual/7.16/reference/rest/history/user-operation-log/) entries.</value>
        [DataMember(Name = "userOperationId", EmitDefaultValue = true)]
        public string UserOperationId { get; set; }

        /// <summary>
        /// The time when this historic detail occurred. Default [format](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/) &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;.
        /// </summary>
        /// <value>The time when this historic detail occurred. Default [format](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/) &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;.</value>
        [DataMember(Name = "time", EmitDefaultValue = true)]
        public DateTime? Time { get; set; }

        /// <summary>
        /// The time after which the historic detail should be removed by the History Cleanup job. Default [format](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/) &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;.
        /// </summary>
        /// <value>The time after which the historic detail should be removed by the History Cleanup job. Default [format](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/) &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;.</value>
        [DataMember(Name = "removalTime", EmitDefaultValue = true)]
        public DateTime? RemovalTime { get; set; }

        /// <summary>
        /// The process instance id of the root process instance that initiated the process containing this historic detail.
        /// </summary>
        /// <value>The process instance id of the root process instance that initiated the process containing this historic detail.</value>
        [DataMember(Name = "rootProcessInstanceId", EmitDefaultValue = true)]
        public string RootProcessInstanceId { get; set; }

        /// <summary>
        /// The id of the form field.  **Note:** This property is only set for a &#x60;HistoricVariableUpdate&#x60; historic details. In these cases, the value of the &#x60;type&#x60; property is &#x60;formField&#x60;.
        /// </summary>
        /// <value>The id of the form field.  **Note:** This property is only set for a &#x60;HistoricVariableUpdate&#x60; historic details. In these cases, the value of the &#x60;type&#x60; property is &#x60;formField&#x60;.</value>
        [DataMember(Name = "fieldId", EmitDefaultValue = true)]
        public string FieldId { get; set; }

        /// <summary>
        /// The submitted form field value. The value differs depending on the form field&#39;s type and on the &#x60;deserializeValue&#x60; parameter.  **Note:** This property is only set for a &#x60;HistoricVariableUpdate&#x60; historic details. In these cases, the value of the &#x60;type&#x60; property is &#x60;formField&#x60;.
        /// </summary>
        /// <value>The submitted form field value. The value differs depending on the form field&#39;s type and on the &#x60;deserializeValue&#x60; parameter.  **Note:** This property is only set for a &#x60;HistoricVariableUpdate&#x60; historic details. In these cases, the value of the &#x60;type&#x60; property is &#x60;formField&#x60;.</value>
        [DataMember(Name = "fieldValue", EmitDefaultValue = false)]
        public Object FieldValue { get; set; }

        /// <summary>
        /// The name of the variable which has been updated.  **Note:** This property is only set for a &#x60;HistoricVariableUpdate&#x60; historic details. In these cases, the value of the &#x60;type&#x60; property is &#x60;variableUpdate&#x60;.
        /// </summary>
        /// <value>The name of the variable which has been updated.  **Note:** This property is only set for a &#x60;HistoricVariableUpdate&#x60; historic details. In these cases, the value of the &#x60;type&#x60; property is &#x60;variableUpdate&#x60;.</value>
        [DataMember(Name = "variableName", EmitDefaultValue = true)]
        public string VariableName { get; set; }

        /// <summary>
        /// The id of the associated variable instance.  **Note:** This property is only set for a &#x60;HistoricVariableUpdate&#x60; historic details. In these cases, the value of the &#x60;type&#x60; property is &#x60;variableUpdate&#x60;.
        /// </summary>
        /// <value>The id of the associated variable instance.  **Note:** This property is only set for a &#x60;HistoricVariableUpdate&#x60; historic details. In these cases, the value of the &#x60;type&#x60; property is &#x60;variableUpdate&#x60;.</value>
        [DataMember(Name = "variableInstanceId", EmitDefaultValue = true)]
        public string VariableInstanceId { get; set; }

        /// <summary>
        /// The value type of the variable.  **Note:** This property is only set for a &#x60;HistoricVariableUpdate&#x60; historic details. In these cases, the value of the &#x60;type&#x60; property is &#x60;variableUpdate&#x60;.
        /// </summary>
        /// <value>The value type of the variable.  **Note:** This property is only set for a &#x60;HistoricVariableUpdate&#x60; historic details. In these cases, the value of the &#x60;type&#x60; property is &#x60;variableUpdate&#x60;.</value>
        [DataMember(Name = "variableType", EmitDefaultValue = true)]
        public string VariableType { get; set; }

        /// <summary>
        /// The variable&#39;s value. Value differs depending on the variable&#39;s type and on the deserializeValues parameter.  **Note:** This property is only set for a &#x60;HistoricVariableUpdate&#x60; historic details. In these cases, the value of the &#x60;type&#x60; property is &#x60;variableUpdate&#x60;.
        /// </summary>
        /// <value>The variable&#39;s value. Value differs depending on the variable&#39;s type and on the deserializeValues parameter.  **Note:** This property is only set for a &#x60;HistoricVariableUpdate&#x60; historic details. In these cases, the value of the &#x60;type&#x60; property is &#x60;variableUpdate&#x60;.</value>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public Object Value { get; set; }

        /// <summary>
        /// A JSON object containing additional, value-type-dependent properties. For variables of type &#x60;Object&#x60;, the following properties are returned:  * &#x60;objectTypeName&#x60;: A string representation of the object&#39;s type name. * &#x60;serializationDataFormat&#x60;: The serialization format used to store the variable.  **Note:** This property is only set for a &#x60;HistoricVariableUpdate&#x60; historic details. In these cases, the value of the &#x60;type&#x60; property is &#x60;variableUpdate&#x60;.
        /// </summary>
        /// <value>A JSON object containing additional, value-type-dependent properties. For variables of type &#x60;Object&#x60;, the following properties are returned:  * &#x60;objectTypeName&#x60;: A string representation of the object&#39;s type name. * &#x60;serializationDataFormat&#x60;: The serialization format used to store the variable.  **Note:** This property is only set for a &#x60;HistoricVariableUpdate&#x60; historic details. In these cases, the value of the &#x60;type&#x60; property is &#x60;variableUpdate&#x60;.</value>
        [DataMember(Name = "valueInfo", EmitDefaultValue = false)]
        public Dictionary<string, Object> ValueInfo { get; set; }

        /// <summary>
        /// Returns &#x60;true&#x60; for variable updates that contains the initial values of the variables.  **Note:** This property is only set for a &#x60;HistoricVariableUpdate&#x60; historic details. In these cases, the value of the &#x60;type&#x60; property is &#x60;variableUpdate&#x60;.
        /// </summary>
        /// <value>Returns &#x60;true&#x60; for variable updates that contains the initial values of the variables.  **Note:** This property is only set for a &#x60;HistoricVariableUpdate&#x60; historic details. In these cases, the value of the &#x60;type&#x60; property is &#x60;variableUpdate&#x60;.</value>
        [DataMember(Name = "initial", EmitDefaultValue = true)]
        public bool? Initial { get; set; }

        /// <summary>
        /// The revision of the historic variable update.  **Note:** This property is only set for a &#x60;HistoricVariableUpdate&#x60; historic details. In these cases, the value of the &#x60;type&#x60; property is &#x60;variableUpdate&#x60;.
        /// </summary>
        /// <value>The revision of the historic variable update.  **Note:** This property is only set for a &#x60;HistoricVariableUpdate&#x60; historic details. In these cases, the value of the &#x60;type&#x60; property is &#x60;variableUpdate&#x60;.</value>
        [DataMember(Name = "revision", EmitDefaultValue = true)]
        public int? Revision { get; set; }

        /// <summary>
        /// An error message in case a Java Serialized Object could not be de-serialized.  **Note:** This property is only set for a &#x60;HistoricVariableUpdate&#x60; historic details. In these cases, the value of the &#x60;type&#x60; property is &#x60;variableUpdate&#x60;.
        /// </summary>
        /// <value>An error message in case a Java Serialized Object could not be de-serialized.  **Note:** This property is only set for a &#x60;HistoricVariableUpdate&#x60; historic details. In these cases, the value of the &#x60;type&#x60; property is &#x60;variableUpdate&#x60;.</value>
        [DataMember(Name = "errorMessage", EmitDefaultValue = true)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HistoricDetailDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ProcessDefinitionKey: ").Append(ProcessDefinitionKey).Append("\n");
            sb.Append("  ProcessDefinitionId: ").Append(ProcessDefinitionId).Append("\n");
            sb.Append("  ProcessInstanceId: ").Append(ProcessInstanceId).Append("\n");
            sb.Append("  ActivityInstanceId: ").Append(ActivityInstanceId).Append("\n");
            sb.Append("  ExecutionId: ").Append(ExecutionId).Append("\n");
            sb.Append("  CaseDefinitionKey: ").Append(CaseDefinitionKey).Append("\n");
            sb.Append("  CaseDefinitionId: ").Append(CaseDefinitionId).Append("\n");
            sb.Append("  CaseInstanceId: ").Append(CaseInstanceId).Append("\n");
            sb.Append("  CaseExecutionId: ").Append(CaseExecutionId).Append("\n");
            sb.Append("  TaskId: ").Append(TaskId).Append("\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  UserOperationId: ").Append(UserOperationId).Append("\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
            sb.Append("  RemovalTime: ").Append(RemovalTime).Append("\n");
            sb.Append("  RootProcessInstanceId: ").Append(RootProcessInstanceId).Append("\n");
            sb.Append("  FieldId: ").Append(FieldId).Append("\n");
            sb.Append("  FieldValue: ").Append(FieldValue).Append("\n");
            sb.Append("  VariableName: ").Append(VariableName).Append("\n");
            sb.Append("  VariableInstanceId: ").Append(VariableInstanceId).Append("\n");
            sb.Append("  VariableType: ").Append(VariableType).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  ValueInfo: ").Append(ValueInfo).Append("\n");
            sb.Append("  Initial: ").Append(Initial).Append("\n");
            sb.Append("  Revision: ").Append(Revision).Append("\n");
            sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
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
            return this.Equals(input as HistoricDetailDto);
        }

        /// <summary>
        /// Returns true if HistoricDetailDto instances are equal
        /// </summary>
        /// <param name="input">Instance of HistoricDetailDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HistoricDetailDto input)
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
                    this.UserOperationId == input.UserOperationId ||
                    (this.UserOperationId != null &&
                    this.UserOperationId.Equals(input.UserOperationId))
                ) && 
                (
                    this.Time == input.Time ||
                    (this.Time != null &&
                    this.Time.Equals(input.Time))
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
                    this.FieldId == input.FieldId ||
                    (this.FieldId != null &&
                    this.FieldId.Equals(input.FieldId))
                ) && 
                (
                    this.FieldValue == input.FieldValue ||
                    (this.FieldValue != null &&
                    this.FieldValue.Equals(input.FieldValue))
                ) && 
                (
                    this.VariableName == input.VariableName ||
                    (this.VariableName != null &&
                    this.VariableName.Equals(input.VariableName))
                ) && 
                (
                    this.VariableInstanceId == input.VariableInstanceId ||
                    (this.VariableInstanceId != null &&
                    this.VariableInstanceId.Equals(input.VariableInstanceId))
                ) && 
                (
                    this.VariableType == input.VariableType ||
                    (this.VariableType != null &&
                    this.VariableType.Equals(input.VariableType))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.ValueInfo == input.ValueInfo ||
                    this.ValueInfo != null &&
                    input.ValueInfo != null &&
                    this.ValueInfo.SequenceEqual(input.ValueInfo)
                ) && 
                (
                    this.Initial == input.Initial ||
                    (this.Initial != null &&
                    this.Initial.Equals(input.Initial))
                ) && 
                (
                    this.Revision == input.Revision ||
                    (this.Revision != null &&
                    this.Revision.Equals(input.Revision))
                ) && 
                (
                    this.ErrorMessage == input.ErrorMessage ||
                    (this.ErrorMessage != null &&
                    this.ErrorMessage.Equals(input.ErrorMessage))
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
                if (this.ProcessDefinitionKey != null)
                    hashCode = hashCode * 59 + this.ProcessDefinitionKey.GetHashCode();
                if (this.ProcessDefinitionId != null)
                    hashCode = hashCode * 59 + this.ProcessDefinitionId.GetHashCode();
                if (this.ProcessInstanceId != null)
                    hashCode = hashCode * 59 + this.ProcessInstanceId.GetHashCode();
                if (this.ActivityInstanceId != null)
                    hashCode = hashCode * 59 + this.ActivityInstanceId.GetHashCode();
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
                if (this.TaskId != null)
                    hashCode = hashCode * 59 + this.TaskId.GetHashCode();
                if (this.TenantId != null)
                    hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.UserOperationId != null)
                    hashCode = hashCode * 59 + this.UserOperationId.GetHashCode();
                if (this.Time != null)
                    hashCode = hashCode * 59 + this.Time.GetHashCode();
                if (this.RemovalTime != null)
                    hashCode = hashCode * 59 + this.RemovalTime.GetHashCode();
                if (this.RootProcessInstanceId != null)
                    hashCode = hashCode * 59 + this.RootProcessInstanceId.GetHashCode();
                if (this.FieldId != null)
                    hashCode = hashCode * 59 + this.FieldId.GetHashCode();
                if (this.FieldValue != null)
                    hashCode = hashCode * 59 + this.FieldValue.GetHashCode();
                if (this.VariableName != null)
                    hashCode = hashCode * 59 + this.VariableName.GetHashCode();
                if (this.VariableInstanceId != null)
                    hashCode = hashCode * 59 + this.VariableInstanceId.GetHashCode();
                if (this.VariableType != null)
                    hashCode = hashCode * 59 + this.VariableType.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.ValueInfo != null)
                    hashCode = hashCode * 59 + this.ValueInfo.GetHashCode();
                if (this.Initial != null)
                    hashCode = hashCode * 59 + this.Initial.GetHashCode();
                if (this.Revision != null)
                    hashCode = hashCode * 59 + this.Revision.GetHashCode();
                if (this.ErrorMessage != null)
                    hashCode = hashCode * 59 + this.ErrorMessage.GetHashCode();
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
