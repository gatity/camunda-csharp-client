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
    /// HistoricDecisionInstanceDto
    /// </summary>
    [DataContract(Name = "HistoricDecisionInstanceDto")]
    public partial class HistoricDecisionInstanceDto : IEquatable<HistoricDecisionInstanceDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HistoricDecisionInstanceDto" /> class.
        /// </summary>
        /// <param name="id">The id of the decision instance..</param>
        /// <param name="decisionDefinitionId">The id of the decision definition that this decision instance belongs to..</param>
        /// <param name="decisionDefinitionKey">The key of the decision definition that this decision instance belongs to..</param>
        /// <param name="decisionDefinitionName">The name of the decision definition that this decision instance belongs to..</param>
        /// <param name="evaluationTime">The time the instance was evaluated.  [Default format](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/) &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;..</param>
        /// <param name="removalTime">The time after which the instance should be removed by the History Cleanup job. [Default format](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/) &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;..</param>
        /// <param name="processDefinitionId">The id of the process definition that this decision instance belongs to..</param>
        /// <param name="processDefinitionKey">The key of the process definition that this decision instance belongs to..</param>
        /// <param name="processInstanceId">The id of the process instance that this decision instance belongs to..</param>
        /// <param name="caseDefinitionId">The id of the case definition that this decision instance belongs to..</param>
        /// <param name="caseDefinitionKey">The key of the case definition that this decision instance belongs to..</param>
        /// <param name="caseInstanceId">The id of the case instance that this decision instance belongs to..</param>
        /// <param name="activityId">The id of the activity that this decision instance belongs to..</param>
        /// <param name="activityInstanceId">The id of the activity instance that this decision instance belongs to..</param>
        /// <param name="tenantId">The tenant id of the historic decision instance..</param>
        /// <param name="userId">The id of the authenticated user that has evaluated this decision instance without a process or case instance..</param>
        /// <param name="inputs">The list of decision input values. **Only exists** if &#x60;includeInputs&#x60; was set to &#x60;true&#x60; in the query..</param>
        /// <param name="ouputs">The list of decision output values. **Only exists** if &#x60;includeOutputs&#x60; was set to &#x60;true&#x60; in the query..</param>
        /// <param name="collectResultValue">The result of the collect aggregation of the decision result if used. &#x60;null&#x60; if no aggregation was used..</param>
        /// <param name="rootDecisionInstanceId">The decision instance id of the evaluated root decision. Can be &#x60;null&#x60; if this instance is the root decision instance of the evaluation..</param>
        /// <param name="rootProcessInstanceId">The process instance id of the root process instance that initiated the evaluation of this decision. Can be &#x60;null&#x60; if this decision instance is not evaluated as part of a BPMN process..</param>
        /// <param name="decisionRequirementsDefinitionId">The id of the decision requirements definition that this decision instance belongs to..</param>
        /// <param name="decisionRequirementsDefinitionKey">The key of the decision requirements definition that this decision instance belongs to..</param>
        public HistoricDecisionInstanceDto(string id = default(string), string decisionDefinitionId = default(string), string decisionDefinitionKey = default(string), string decisionDefinitionName = default(string), DateTime? evaluationTime = default(DateTime?), DateTime? removalTime = default(DateTime?), string processDefinitionId = default(string), string processDefinitionKey = default(string), string processInstanceId = default(string), string caseDefinitionId = default(string), string caseDefinitionKey = default(string), string caseInstanceId = default(string), string activityId = default(string), string activityInstanceId = default(string), string tenantId = default(string), string userId = default(string), List<HistoricDecisionInputInstanceDto> inputs = default(List<HistoricDecisionInputInstanceDto>), List<HistoricDecisionOutputInstanceDto> ouputs = default(List<HistoricDecisionOutputInstanceDto>), double? collectResultValue = default(double?), string rootDecisionInstanceId = default(string), string rootProcessInstanceId = default(string), string decisionRequirementsDefinitionId = default(string), string decisionRequirementsDefinitionKey = default(string))
        {
            this.Id = id;
            this.DecisionDefinitionId = decisionDefinitionId;
            this.DecisionDefinitionKey = decisionDefinitionKey;
            this.DecisionDefinitionName = decisionDefinitionName;
            this.EvaluationTime = evaluationTime;
            this.RemovalTime = removalTime;
            this.ProcessDefinitionId = processDefinitionId;
            this.ProcessDefinitionKey = processDefinitionKey;
            this.ProcessInstanceId = processInstanceId;
            this.CaseDefinitionId = caseDefinitionId;
            this.CaseDefinitionKey = caseDefinitionKey;
            this.CaseInstanceId = caseInstanceId;
            this.ActivityId = activityId;
            this.ActivityInstanceId = activityInstanceId;
            this.TenantId = tenantId;
            this.UserId = userId;
            this.Inputs = inputs;
            this.Ouputs = ouputs;
            this.CollectResultValue = collectResultValue;
            this.RootDecisionInstanceId = rootDecisionInstanceId;
            this.RootProcessInstanceId = rootProcessInstanceId;
            this.DecisionRequirementsDefinitionId = decisionRequirementsDefinitionId;
            this.DecisionRequirementsDefinitionKey = decisionRequirementsDefinitionKey;
        }

        /// <summary>
        /// The id of the decision instance.
        /// </summary>
        /// <value>The id of the decision instance.</value>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// The id of the decision definition that this decision instance belongs to.
        /// </summary>
        /// <value>The id of the decision definition that this decision instance belongs to.</value>
        [DataMember(Name = "decisionDefinitionId", EmitDefaultValue = true)]
        public string DecisionDefinitionId { get; set; }

        /// <summary>
        /// The key of the decision definition that this decision instance belongs to.
        /// </summary>
        /// <value>The key of the decision definition that this decision instance belongs to.</value>
        [DataMember(Name = "decisionDefinitionKey", EmitDefaultValue = true)]
        public string DecisionDefinitionKey { get; set; }

        /// <summary>
        /// The name of the decision definition that this decision instance belongs to.
        /// </summary>
        /// <value>The name of the decision definition that this decision instance belongs to.</value>
        [DataMember(Name = "decisionDefinitionName", EmitDefaultValue = true)]
        public string DecisionDefinitionName { get; set; }

        /// <summary>
        /// The time the instance was evaluated.  [Default format](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/) &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;.
        /// </summary>
        /// <value>The time the instance was evaluated.  [Default format](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/) &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;.</value>
        [DataMember(Name = "evaluationTime", EmitDefaultValue = true)]
        public DateTime? EvaluationTime { get; set; }

        /// <summary>
        /// The time after which the instance should be removed by the History Cleanup job. [Default format](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/) &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;.
        /// </summary>
        /// <value>The time after which the instance should be removed by the History Cleanup job. [Default format](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/) &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;.</value>
        [DataMember(Name = "removalTime", EmitDefaultValue = true)]
        public DateTime? RemovalTime { get; set; }

        /// <summary>
        /// The id of the process definition that this decision instance belongs to.
        /// </summary>
        /// <value>The id of the process definition that this decision instance belongs to.</value>
        [DataMember(Name = "processDefinitionId", EmitDefaultValue = true)]
        public string ProcessDefinitionId { get; set; }

        /// <summary>
        /// The key of the process definition that this decision instance belongs to.
        /// </summary>
        /// <value>The key of the process definition that this decision instance belongs to.</value>
        [DataMember(Name = "processDefinitionKey", EmitDefaultValue = true)]
        public string ProcessDefinitionKey { get; set; }

        /// <summary>
        /// The id of the process instance that this decision instance belongs to.
        /// </summary>
        /// <value>The id of the process instance that this decision instance belongs to.</value>
        [DataMember(Name = "processInstanceId", EmitDefaultValue = true)]
        public string ProcessInstanceId { get; set; }

        /// <summary>
        /// The id of the case definition that this decision instance belongs to.
        /// </summary>
        /// <value>The id of the case definition that this decision instance belongs to.</value>
        [DataMember(Name = "caseDefinitionId", EmitDefaultValue = true)]
        public string CaseDefinitionId { get; set; }

        /// <summary>
        /// The key of the case definition that this decision instance belongs to.
        /// </summary>
        /// <value>The key of the case definition that this decision instance belongs to.</value>
        [DataMember(Name = "caseDefinitionKey", EmitDefaultValue = true)]
        public string CaseDefinitionKey { get; set; }

        /// <summary>
        /// The id of the case instance that this decision instance belongs to.
        /// </summary>
        /// <value>The id of the case instance that this decision instance belongs to.</value>
        [DataMember(Name = "caseInstanceId", EmitDefaultValue = true)]
        public string CaseInstanceId { get; set; }

        /// <summary>
        /// The id of the activity that this decision instance belongs to.
        /// </summary>
        /// <value>The id of the activity that this decision instance belongs to.</value>
        [DataMember(Name = "activityId", EmitDefaultValue = true)]
        public string ActivityId { get; set; }

        /// <summary>
        /// The id of the activity instance that this decision instance belongs to.
        /// </summary>
        /// <value>The id of the activity instance that this decision instance belongs to.</value>
        [DataMember(Name = "activityInstanceId", EmitDefaultValue = true)]
        public string ActivityInstanceId { get; set; }

        /// <summary>
        /// The tenant id of the historic decision instance.
        /// </summary>
        /// <value>The tenant id of the historic decision instance.</value>
        [DataMember(Name = "tenantId", EmitDefaultValue = true)]
        public string TenantId { get; set; }

        /// <summary>
        /// The id of the authenticated user that has evaluated this decision instance without a process or case instance.
        /// </summary>
        /// <value>The id of the authenticated user that has evaluated this decision instance without a process or case instance.</value>
        [DataMember(Name = "userId", EmitDefaultValue = true)]
        public string UserId { get; set; }

        /// <summary>
        /// The list of decision input values. **Only exists** if &#x60;includeInputs&#x60; was set to &#x60;true&#x60; in the query.
        /// </summary>
        /// <value>The list of decision input values. **Only exists** if &#x60;includeInputs&#x60; was set to &#x60;true&#x60; in the query.</value>
        [DataMember(Name = "inputs", EmitDefaultValue = true)]
        public List<HistoricDecisionInputInstanceDto> Inputs { get; set; }

        /// <summary>
        /// The list of decision output values. **Only exists** if &#x60;includeOutputs&#x60; was set to &#x60;true&#x60; in the query.
        /// </summary>
        /// <value>The list of decision output values. **Only exists** if &#x60;includeOutputs&#x60; was set to &#x60;true&#x60; in the query.</value>
        [DataMember(Name = "ouputs", EmitDefaultValue = true)]
        public List<HistoricDecisionOutputInstanceDto> Ouputs { get; set; }

        /// <summary>
        /// The result of the collect aggregation of the decision result if used. &#x60;null&#x60; if no aggregation was used.
        /// </summary>
        /// <value>The result of the collect aggregation of the decision result if used. &#x60;null&#x60; if no aggregation was used.</value>
        [DataMember(Name = "collectResultValue", EmitDefaultValue = true)]
        public double? CollectResultValue { get; set; }

        /// <summary>
        /// The decision instance id of the evaluated root decision. Can be &#x60;null&#x60; if this instance is the root decision instance of the evaluation.
        /// </summary>
        /// <value>The decision instance id of the evaluated root decision. Can be &#x60;null&#x60; if this instance is the root decision instance of the evaluation.</value>
        [DataMember(Name = "rootDecisionInstanceId", EmitDefaultValue = true)]
        public string RootDecisionInstanceId { get; set; }

        /// <summary>
        /// The process instance id of the root process instance that initiated the evaluation of this decision. Can be &#x60;null&#x60; if this decision instance is not evaluated as part of a BPMN process.
        /// </summary>
        /// <value>The process instance id of the root process instance that initiated the evaluation of this decision. Can be &#x60;null&#x60; if this decision instance is not evaluated as part of a BPMN process.</value>
        [DataMember(Name = "rootProcessInstanceId", EmitDefaultValue = true)]
        public string RootProcessInstanceId { get; set; }

        /// <summary>
        /// The id of the decision requirements definition that this decision instance belongs to.
        /// </summary>
        /// <value>The id of the decision requirements definition that this decision instance belongs to.</value>
        [DataMember(Name = "decisionRequirementsDefinitionId", EmitDefaultValue = true)]
        public string DecisionRequirementsDefinitionId { get; set; }

        /// <summary>
        /// The key of the decision requirements definition that this decision instance belongs to.
        /// </summary>
        /// <value>The key of the decision requirements definition that this decision instance belongs to.</value>
        [DataMember(Name = "decisionRequirementsDefinitionKey", EmitDefaultValue = true)]
        public string DecisionRequirementsDefinitionKey { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HistoricDecisionInstanceDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DecisionDefinitionId: ").Append(DecisionDefinitionId).Append("\n");
            sb.Append("  DecisionDefinitionKey: ").Append(DecisionDefinitionKey).Append("\n");
            sb.Append("  DecisionDefinitionName: ").Append(DecisionDefinitionName).Append("\n");
            sb.Append("  EvaluationTime: ").Append(EvaluationTime).Append("\n");
            sb.Append("  RemovalTime: ").Append(RemovalTime).Append("\n");
            sb.Append("  ProcessDefinitionId: ").Append(ProcessDefinitionId).Append("\n");
            sb.Append("  ProcessDefinitionKey: ").Append(ProcessDefinitionKey).Append("\n");
            sb.Append("  ProcessInstanceId: ").Append(ProcessInstanceId).Append("\n");
            sb.Append("  CaseDefinitionId: ").Append(CaseDefinitionId).Append("\n");
            sb.Append("  CaseDefinitionKey: ").Append(CaseDefinitionKey).Append("\n");
            sb.Append("  CaseInstanceId: ").Append(CaseInstanceId).Append("\n");
            sb.Append("  ActivityId: ").Append(ActivityId).Append("\n");
            sb.Append("  ActivityInstanceId: ").Append(ActivityInstanceId).Append("\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  Inputs: ").Append(Inputs).Append("\n");
            sb.Append("  Ouputs: ").Append(Ouputs).Append("\n");
            sb.Append("  CollectResultValue: ").Append(CollectResultValue).Append("\n");
            sb.Append("  RootDecisionInstanceId: ").Append(RootDecisionInstanceId).Append("\n");
            sb.Append("  RootProcessInstanceId: ").Append(RootProcessInstanceId).Append("\n");
            sb.Append("  DecisionRequirementsDefinitionId: ").Append(DecisionRequirementsDefinitionId).Append("\n");
            sb.Append("  DecisionRequirementsDefinitionKey: ").Append(DecisionRequirementsDefinitionKey).Append("\n");
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
            return this.Equals(input as HistoricDecisionInstanceDto);
        }

        /// <summary>
        /// Returns true if HistoricDecisionInstanceDto instances are equal
        /// </summary>
        /// <param name="input">Instance of HistoricDecisionInstanceDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HistoricDecisionInstanceDto input)
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
                    this.DecisionDefinitionId == input.DecisionDefinitionId ||
                    (this.DecisionDefinitionId != null &&
                    this.DecisionDefinitionId.Equals(input.DecisionDefinitionId))
                ) && 
                (
                    this.DecisionDefinitionKey == input.DecisionDefinitionKey ||
                    (this.DecisionDefinitionKey != null &&
                    this.DecisionDefinitionKey.Equals(input.DecisionDefinitionKey))
                ) && 
                (
                    this.DecisionDefinitionName == input.DecisionDefinitionName ||
                    (this.DecisionDefinitionName != null &&
                    this.DecisionDefinitionName.Equals(input.DecisionDefinitionName))
                ) && 
                (
                    this.EvaluationTime == input.EvaluationTime ||
                    (this.EvaluationTime != null &&
                    this.EvaluationTime.Equals(input.EvaluationTime))
                ) && 
                (
                    this.RemovalTime == input.RemovalTime ||
                    (this.RemovalTime != null &&
                    this.RemovalTime.Equals(input.RemovalTime))
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
                    this.CaseDefinitionId == input.CaseDefinitionId ||
                    (this.CaseDefinitionId != null &&
                    this.CaseDefinitionId.Equals(input.CaseDefinitionId))
                ) && 
                (
                    this.CaseDefinitionKey == input.CaseDefinitionKey ||
                    (this.CaseDefinitionKey != null &&
                    this.CaseDefinitionKey.Equals(input.CaseDefinitionKey))
                ) && 
                (
                    this.CaseInstanceId == input.CaseInstanceId ||
                    (this.CaseInstanceId != null &&
                    this.CaseInstanceId.Equals(input.CaseInstanceId))
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
                    this.TenantId == input.TenantId ||
                    (this.TenantId != null &&
                    this.TenantId.Equals(input.TenantId))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.Inputs == input.Inputs ||
                    this.Inputs != null &&
                    input.Inputs != null &&
                    this.Inputs.SequenceEqual(input.Inputs)
                ) && 
                (
                    this.Ouputs == input.Ouputs ||
                    this.Ouputs != null &&
                    input.Ouputs != null &&
                    this.Ouputs.SequenceEqual(input.Ouputs)
                ) && 
                (
                    this.CollectResultValue == input.CollectResultValue ||
                    (this.CollectResultValue != null &&
                    this.CollectResultValue.Equals(input.CollectResultValue))
                ) && 
                (
                    this.RootDecisionInstanceId == input.RootDecisionInstanceId ||
                    (this.RootDecisionInstanceId != null &&
                    this.RootDecisionInstanceId.Equals(input.RootDecisionInstanceId))
                ) && 
                (
                    this.RootProcessInstanceId == input.RootProcessInstanceId ||
                    (this.RootProcessInstanceId != null &&
                    this.RootProcessInstanceId.Equals(input.RootProcessInstanceId))
                ) && 
                (
                    this.DecisionRequirementsDefinitionId == input.DecisionRequirementsDefinitionId ||
                    (this.DecisionRequirementsDefinitionId != null &&
                    this.DecisionRequirementsDefinitionId.Equals(input.DecisionRequirementsDefinitionId))
                ) && 
                (
                    this.DecisionRequirementsDefinitionKey == input.DecisionRequirementsDefinitionKey ||
                    (this.DecisionRequirementsDefinitionKey != null &&
                    this.DecisionRequirementsDefinitionKey.Equals(input.DecisionRequirementsDefinitionKey))
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
                if (this.DecisionDefinitionId != null)
                    hashCode = hashCode * 59 + this.DecisionDefinitionId.GetHashCode();
                if (this.DecisionDefinitionKey != null)
                    hashCode = hashCode * 59 + this.DecisionDefinitionKey.GetHashCode();
                if (this.DecisionDefinitionName != null)
                    hashCode = hashCode * 59 + this.DecisionDefinitionName.GetHashCode();
                if (this.EvaluationTime != null)
                    hashCode = hashCode * 59 + this.EvaluationTime.GetHashCode();
                if (this.RemovalTime != null)
                    hashCode = hashCode * 59 + this.RemovalTime.GetHashCode();
                if (this.ProcessDefinitionId != null)
                    hashCode = hashCode * 59 + this.ProcessDefinitionId.GetHashCode();
                if (this.ProcessDefinitionKey != null)
                    hashCode = hashCode * 59 + this.ProcessDefinitionKey.GetHashCode();
                if (this.ProcessInstanceId != null)
                    hashCode = hashCode * 59 + this.ProcessInstanceId.GetHashCode();
                if (this.CaseDefinitionId != null)
                    hashCode = hashCode * 59 + this.CaseDefinitionId.GetHashCode();
                if (this.CaseDefinitionKey != null)
                    hashCode = hashCode * 59 + this.CaseDefinitionKey.GetHashCode();
                if (this.CaseInstanceId != null)
                    hashCode = hashCode * 59 + this.CaseInstanceId.GetHashCode();
                if (this.ActivityId != null)
                    hashCode = hashCode * 59 + this.ActivityId.GetHashCode();
                if (this.ActivityInstanceId != null)
                    hashCode = hashCode * 59 + this.ActivityInstanceId.GetHashCode();
                if (this.TenantId != null)
                    hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.Inputs != null)
                    hashCode = hashCode * 59 + this.Inputs.GetHashCode();
                if (this.Ouputs != null)
                    hashCode = hashCode * 59 + this.Ouputs.GetHashCode();
                if (this.CollectResultValue != null)
                    hashCode = hashCode * 59 + this.CollectResultValue.GetHashCode();
                if (this.RootDecisionInstanceId != null)
                    hashCode = hashCode * 59 + this.RootDecisionInstanceId.GetHashCode();
                if (this.RootProcessInstanceId != null)
                    hashCode = hashCode * 59 + this.RootProcessInstanceId.GetHashCode();
                if (this.DecisionRequirementsDefinitionId != null)
                    hashCode = hashCode * 59 + this.DecisionRequirementsDefinitionId.GetHashCode();
                if (this.DecisionRequirementsDefinitionKey != null)
                    hashCode = hashCode * 59 + this.DecisionRequirementsDefinitionKey.GetHashCode();
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
