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
    /// A Execution instance query which defines a list of Execution instances
    /// </summary>
    [DataContract(Name = "ExecutionQueryDto")]
    public partial class ExecutionQueryDto : IEquatable<ExecutionQueryDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExecutionQueryDto" /> class.
        /// </summary>
        /// <param name="businessKey">Filter by the business key of the process instances the executions belong to..</param>
        /// <param name="processDefinitionId">Filter by the process definition the executions run on..</param>
        /// <param name="processDefinitionKey">Filter by the key of the process definition the executions run on..</param>
        /// <param name="processInstanceId">Filter by the id of the process instance the execution belongs to..</param>
        /// <param name="activityId">Filter by the id of the activity the execution currently executes..</param>
        /// <param name="signalEventSubscriptionName">Select only those executions that expect a signal of the given name..</param>
        /// <param name="messageEventSubscriptionName">Select only those executions that expect a message of the given name..</param>
        /// <param name="active">Only include active executions. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior..</param>
        /// <param name="suspended">Only include suspended executions. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior..</param>
        /// <param name="incidentId">Filter by the incident id..</param>
        /// <param name="incidentType">Filter by the incident type. See the [User Guide](/manual/develop/user-guide/process-engine/incidents/#incident-types) for a list of incident types..</param>
        /// <param name="incidentMessage">Filter by the incident message. Exact match..</param>
        /// <param name="incidentMessageLike">Filter by the incident message that the parameter is a substring of..</param>
        /// <param name="tenantIdIn">Filter by a  list of tenant ids. An execution must have one of the given tenant ids..</param>
        /// <param name="variables">An array to only include executions that have variables with certain values.  The array consists of objects with the three properties &#x60;name&#x60;, &#x60;operator&#x60; and &#x60;value&#x60;. &#x60;name (String)&#x60; is the variable name, &#x60;operator (String)&#x60; is the comparison operator to be used and &#x60;value&#x60; the variable value. &#x60;value&#x60; may be &#x60;String&#x60;, &#x60;Number&#x60; or &#x60;Boolean&#x60;.  Valid operator values are: &#x60;eq&#x60; - equal to; &#x60;neq&#x60; - not equal to; &#x60;gt&#x60; - greater than; &#x60;gteq&#x60; - greater than or equal to; &#x60;lt&#x60; - lower than; &#x60;lteq&#x60; - lower than or equal to; &#x60;like&#x60;..</param>
        /// <param name="processVariables">An array to only include executions that belong to a process instance with variables with certain values.  The array consists of objects with the three properties &#x60;name&#x60;, &#x60;operator&#x60; and &#x60;value&#x60;. &#x60;name (String)&#x60; is the variable name, &#x60;operator (String)&#x60; is the comparison operator to be used and &#x60;value&#x60; the variable value. &#x60;value&#x60; may be &#x60;String&#x60;, &#x60;Number&#x60; or &#x60;Boolean&#x60;.  Valid operator values are: &#x60;eq&#x60; - equal to; &#x60;neq&#x60; - not equal to..</param>
        /// <param name="variableNamesIgnoreCase">Match all variable names provided in &#x60;variables&#x60; and &#x60;processVariables&#x60; case- insensitively. If set to &#x60;true&#x60; **variableName** and **variablename** are treated as equal..</param>
        /// <param name="variableValuesIgnoreCase">Match all variable values provided in &#x60;variables&#x60; and &#x60;processVariables&#x60; case- insensitively. If set to &#x60;true&#x60; **variableValue** and **variablevalue** are treated as equal..</param>
        /// <param name="sorting">An array of criteria to sort the result by. Each element of the array is                        an object that specifies one ordering. The position in the array                        identifies the rank of an ordering, i.e., whether it is primary, secondary,                        etc. Has no effect for the &#x60;/count&#x60; endpoint.</param>
        public ExecutionQueryDto(string businessKey = default(string), string processDefinitionId = default(string), string processDefinitionKey = default(string), string processInstanceId = default(string), string activityId = default(string), string signalEventSubscriptionName = default(string), string messageEventSubscriptionName = default(string), bool? active = default(bool?), bool? suspended = default(bool?), string incidentId = default(string), string incidentType = default(string), string incidentMessage = default(string), string incidentMessageLike = default(string), List<string> tenantIdIn = default(List<string>), List<VariableQueryParameterDto> variables = default(List<VariableQueryParameterDto>), List<VariableQueryParameterDto> processVariables = default(List<VariableQueryParameterDto>), bool? variableNamesIgnoreCase = default(bool?), bool? variableValuesIgnoreCase = default(bool?), List<ExecutionQueryDtoSorting> sorting = default(List<ExecutionQueryDtoSorting>))
        {
            this.BusinessKey = businessKey;
            this.ProcessDefinitionId = processDefinitionId;
            this.ProcessDefinitionKey = processDefinitionKey;
            this.ProcessInstanceId = processInstanceId;
            this.ActivityId = activityId;
            this.SignalEventSubscriptionName = signalEventSubscriptionName;
            this.MessageEventSubscriptionName = messageEventSubscriptionName;
            this.Active = active;
            this.Suspended = suspended;
            this.IncidentId = incidentId;
            this.IncidentType = incidentType;
            this.IncidentMessage = incidentMessage;
            this.IncidentMessageLike = incidentMessageLike;
            this.TenantIdIn = tenantIdIn;
            this.Variables = variables;
            this.ProcessVariables = processVariables;
            this.VariableNamesIgnoreCase = variableNamesIgnoreCase;
            this.VariableValuesIgnoreCase = variableValuesIgnoreCase;
            this.Sorting = sorting;
        }

        /// <summary>
        /// Filter by the business key of the process instances the executions belong to.
        /// </summary>
        /// <value>Filter by the business key of the process instances the executions belong to.</value>
        [DataMember(Name = "businessKey", EmitDefaultValue = true)]
        public string BusinessKey { get; set; }

        /// <summary>
        /// Filter by the process definition the executions run on.
        /// </summary>
        /// <value>Filter by the process definition the executions run on.</value>
        [DataMember(Name = "processDefinitionId", EmitDefaultValue = true)]
        public string ProcessDefinitionId { get; set; }

        /// <summary>
        /// Filter by the key of the process definition the executions run on.
        /// </summary>
        /// <value>Filter by the key of the process definition the executions run on.</value>
        [DataMember(Name = "processDefinitionKey", EmitDefaultValue = true)]
        public string ProcessDefinitionKey { get; set; }

        /// <summary>
        /// Filter by the id of the process instance the execution belongs to.
        /// </summary>
        /// <value>Filter by the id of the process instance the execution belongs to.</value>
        [DataMember(Name = "processInstanceId", EmitDefaultValue = true)]
        public string ProcessInstanceId { get; set; }

        /// <summary>
        /// Filter by the id of the activity the execution currently executes.
        /// </summary>
        /// <value>Filter by the id of the activity the execution currently executes.</value>
        [DataMember(Name = "activityId", EmitDefaultValue = true)]
        public string ActivityId { get; set; }

        /// <summary>
        /// Select only those executions that expect a signal of the given name.
        /// </summary>
        /// <value>Select only those executions that expect a signal of the given name.</value>
        [DataMember(Name = "signalEventSubscriptionName", EmitDefaultValue = true)]
        public string SignalEventSubscriptionName { get; set; }

        /// <summary>
        /// Select only those executions that expect a message of the given name.
        /// </summary>
        /// <value>Select only those executions that expect a message of the given name.</value>
        [DataMember(Name = "messageEventSubscriptionName", EmitDefaultValue = true)]
        public string MessageEventSubscriptionName { get; set; }

        /// <summary>
        /// Only include active executions. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior.
        /// </summary>
        /// <value>Only include active executions. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior.</value>
        [DataMember(Name = "active", EmitDefaultValue = true)]
        public bool? Active { get; set; }

        /// <summary>
        /// Only include suspended executions. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior.
        /// </summary>
        /// <value>Only include suspended executions. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior.</value>
        [DataMember(Name = "suspended", EmitDefaultValue = true)]
        public bool? Suspended { get; set; }

        /// <summary>
        /// Filter by the incident id.
        /// </summary>
        /// <value>Filter by the incident id.</value>
        [DataMember(Name = "incidentId", EmitDefaultValue = true)]
        public string IncidentId { get; set; }

        /// <summary>
        /// Filter by the incident type. See the [User Guide](/manual/develop/user-guide/process-engine/incidents/#incident-types) for a list of incident types.
        /// </summary>
        /// <value>Filter by the incident type. See the [User Guide](/manual/develop/user-guide/process-engine/incidents/#incident-types) for a list of incident types.</value>
        [DataMember(Name = "incidentType", EmitDefaultValue = true)]
        public string IncidentType { get; set; }

        /// <summary>
        /// Filter by the incident message. Exact match.
        /// </summary>
        /// <value>Filter by the incident message. Exact match.</value>
        [DataMember(Name = "incidentMessage", EmitDefaultValue = true)]
        public string IncidentMessage { get; set; }

        /// <summary>
        /// Filter by the incident message that the parameter is a substring of.
        /// </summary>
        /// <value>Filter by the incident message that the parameter is a substring of.</value>
        [DataMember(Name = "incidentMessageLike", EmitDefaultValue = true)]
        public string IncidentMessageLike { get; set; }

        /// <summary>
        /// Filter by a  list of tenant ids. An execution must have one of the given tenant ids.
        /// </summary>
        /// <value>Filter by a  list of tenant ids. An execution must have one of the given tenant ids.</value>
        [DataMember(Name = "tenantIdIn", EmitDefaultValue = true)]
        public List<string> TenantIdIn { get; set; }

        /// <summary>
        /// An array to only include executions that have variables with certain values.  The array consists of objects with the three properties &#x60;name&#x60;, &#x60;operator&#x60; and &#x60;value&#x60;. &#x60;name (String)&#x60; is the variable name, &#x60;operator (String)&#x60; is the comparison operator to be used and &#x60;value&#x60; the variable value. &#x60;value&#x60; may be &#x60;String&#x60;, &#x60;Number&#x60; or &#x60;Boolean&#x60;.  Valid operator values are: &#x60;eq&#x60; - equal to; &#x60;neq&#x60; - not equal to; &#x60;gt&#x60; - greater than; &#x60;gteq&#x60; - greater than or equal to; &#x60;lt&#x60; - lower than; &#x60;lteq&#x60; - lower than or equal to; &#x60;like&#x60;.
        /// </summary>
        /// <value>An array to only include executions that have variables with certain values.  The array consists of objects with the three properties &#x60;name&#x60;, &#x60;operator&#x60; and &#x60;value&#x60;. &#x60;name (String)&#x60; is the variable name, &#x60;operator (String)&#x60; is the comparison operator to be used and &#x60;value&#x60; the variable value. &#x60;value&#x60; may be &#x60;String&#x60;, &#x60;Number&#x60; or &#x60;Boolean&#x60;.  Valid operator values are: &#x60;eq&#x60; - equal to; &#x60;neq&#x60; - not equal to; &#x60;gt&#x60; - greater than; &#x60;gteq&#x60; - greater than or equal to; &#x60;lt&#x60; - lower than; &#x60;lteq&#x60; - lower than or equal to; &#x60;like&#x60;.</value>
        [DataMember(Name = "variables", EmitDefaultValue = true)]
        public List<VariableQueryParameterDto> Variables { get; set; }

        /// <summary>
        /// An array to only include executions that belong to a process instance with variables with certain values.  The array consists of objects with the three properties &#x60;name&#x60;, &#x60;operator&#x60; and &#x60;value&#x60;. &#x60;name (String)&#x60; is the variable name, &#x60;operator (String)&#x60; is the comparison operator to be used and &#x60;value&#x60; the variable value. &#x60;value&#x60; may be &#x60;String&#x60;, &#x60;Number&#x60; or &#x60;Boolean&#x60;.  Valid operator values are: &#x60;eq&#x60; - equal to; &#x60;neq&#x60; - not equal to.
        /// </summary>
        /// <value>An array to only include executions that belong to a process instance with variables with certain values.  The array consists of objects with the three properties &#x60;name&#x60;, &#x60;operator&#x60; and &#x60;value&#x60;. &#x60;name (String)&#x60; is the variable name, &#x60;operator (String)&#x60; is the comparison operator to be used and &#x60;value&#x60; the variable value. &#x60;value&#x60; may be &#x60;String&#x60;, &#x60;Number&#x60; or &#x60;Boolean&#x60;.  Valid operator values are: &#x60;eq&#x60; - equal to; &#x60;neq&#x60; - not equal to.</value>
        [DataMember(Name = "processVariables", EmitDefaultValue = true)]
        public List<VariableQueryParameterDto> ProcessVariables { get; set; }

        /// <summary>
        /// Match all variable names provided in &#x60;variables&#x60; and &#x60;processVariables&#x60; case- insensitively. If set to &#x60;true&#x60; **variableName** and **variablename** are treated as equal.
        /// </summary>
        /// <value>Match all variable names provided in &#x60;variables&#x60; and &#x60;processVariables&#x60; case- insensitively. If set to &#x60;true&#x60; **variableName** and **variablename** are treated as equal.</value>
        [DataMember(Name = "variableNamesIgnoreCase", EmitDefaultValue = true)]
        public bool? VariableNamesIgnoreCase { get; set; }

        /// <summary>
        /// Match all variable values provided in &#x60;variables&#x60; and &#x60;processVariables&#x60; case- insensitively. If set to &#x60;true&#x60; **variableValue** and **variablevalue** are treated as equal.
        /// </summary>
        /// <value>Match all variable values provided in &#x60;variables&#x60; and &#x60;processVariables&#x60; case- insensitively. If set to &#x60;true&#x60; **variableValue** and **variablevalue** are treated as equal.</value>
        [DataMember(Name = "variableValuesIgnoreCase", EmitDefaultValue = true)]
        public bool? VariableValuesIgnoreCase { get; set; }

        /// <summary>
        /// An array of criteria to sort the result by. Each element of the array is                        an object that specifies one ordering. The position in the array                        identifies the rank of an ordering, i.e., whether it is primary, secondary,                        etc. Has no effect for the &#x60;/count&#x60; endpoint
        /// </summary>
        /// <value>An array of criteria to sort the result by. Each element of the array is                        an object that specifies one ordering. The position in the array                        identifies the rank of an ordering, i.e., whether it is primary, secondary,                        etc. Has no effect for the &#x60;/count&#x60; endpoint</value>
        [DataMember(Name = "sorting", EmitDefaultValue = true)]
        public List<ExecutionQueryDtoSorting> Sorting { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExecutionQueryDto {\n");
            sb.Append("  BusinessKey: ").Append(BusinessKey).Append("\n");
            sb.Append("  ProcessDefinitionId: ").Append(ProcessDefinitionId).Append("\n");
            sb.Append("  ProcessDefinitionKey: ").Append(ProcessDefinitionKey).Append("\n");
            sb.Append("  ProcessInstanceId: ").Append(ProcessInstanceId).Append("\n");
            sb.Append("  ActivityId: ").Append(ActivityId).Append("\n");
            sb.Append("  SignalEventSubscriptionName: ").Append(SignalEventSubscriptionName).Append("\n");
            sb.Append("  MessageEventSubscriptionName: ").Append(MessageEventSubscriptionName).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  Suspended: ").Append(Suspended).Append("\n");
            sb.Append("  IncidentId: ").Append(IncidentId).Append("\n");
            sb.Append("  IncidentType: ").Append(IncidentType).Append("\n");
            sb.Append("  IncidentMessage: ").Append(IncidentMessage).Append("\n");
            sb.Append("  IncidentMessageLike: ").Append(IncidentMessageLike).Append("\n");
            sb.Append("  TenantIdIn: ").Append(TenantIdIn).Append("\n");
            sb.Append("  Variables: ").Append(Variables).Append("\n");
            sb.Append("  ProcessVariables: ").Append(ProcessVariables).Append("\n");
            sb.Append("  VariableNamesIgnoreCase: ").Append(VariableNamesIgnoreCase).Append("\n");
            sb.Append("  VariableValuesIgnoreCase: ").Append(VariableValuesIgnoreCase).Append("\n");
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
            return this.Equals(input as ExecutionQueryDto);
        }

        /// <summary>
        /// Returns true if ExecutionQueryDto instances are equal
        /// </summary>
        /// <param name="input">Instance of ExecutionQueryDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExecutionQueryDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BusinessKey == input.BusinessKey ||
                    (this.BusinessKey != null &&
                    this.BusinessKey.Equals(input.BusinessKey))
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
                    this.ActivityId == input.ActivityId ||
                    (this.ActivityId != null &&
                    this.ActivityId.Equals(input.ActivityId))
                ) && 
                (
                    this.SignalEventSubscriptionName == input.SignalEventSubscriptionName ||
                    (this.SignalEventSubscriptionName != null &&
                    this.SignalEventSubscriptionName.Equals(input.SignalEventSubscriptionName))
                ) && 
                (
                    this.MessageEventSubscriptionName == input.MessageEventSubscriptionName ||
                    (this.MessageEventSubscriptionName != null &&
                    this.MessageEventSubscriptionName.Equals(input.MessageEventSubscriptionName))
                ) && 
                (
                    this.Active == input.Active ||
                    (this.Active != null &&
                    this.Active.Equals(input.Active))
                ) && 
                (
                    this.Suspended == input.Suspended ||
                    (this.Suspended != null &&
                    this.Suspended.Equals(input.Suspended))
                ) && 
                (
                    this.IncidentId == input.IncidentId ||
                    (this.IncidentId != null &&
                    this.IncidentId.Equals(input.IncidentId))
                ) && 
                (
                    this.IncidentType == input.IncidentType ||
                    (this.IncidentType != null &&
                    this.IncidentType.Equals(input.IncidentType))
                ) && 
                (
                    this.IncidentMessage == input.IncidentMessage ||
                    (this.IncidentMessage != null &&
                    this.IncidentMessage.Equals(input.IncidentMessage))
                ) && 
                (
                    this.IncidentMessageLike == input.IncidentMessageLike ||
                    (this.IncidentMessageLike != null &&
                    this.IncidentMessageLike.Equals(input.IncidentMessageLike))
                ) && 
                (
                    this.TenantIdIn == input.TenantIdIn ||
                    this.TenantIdIn != null &&
                    input.TenantIdIn != null &&
                    this.TenantIdIn.SequenceEqual(input.TenantIdIn)
                ) && 
                (
                    this.Variables == input.Variables ||
                    this.Variables != null &&
                    input.Variables != null &&
                    this.Variables.SequenceEqual(input.Variables)
                ) && 
                (
                    this.ProcessVariables == input.ProcessVariables ||
                    this.ProcessVariables != null &&
                    input.ProcessVariables != null &&
                    this.ProcessVariables.SequenceEqual(input.ProcessVariables)
                ) && 
                (
                    this.VariableNamesIgnoreCase == input.VariableNamesIgnoreCase ||
                    (this.VariableNamesIgnoreCase != null &&
                    this.VariableNamesIgnoreCase.Equals(input.VariableNamesIgnoreCase))
                ) && 
                (
                    this.VariableValuesIgnoreCase == input.VariableValuesIgnoreCase ||
                    (this.VariableValuesIgnoreCase != null &&
                    this.VariableValuesIgnoreCase.Equals(input.VariableValuesIgnoreCase))
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
                if (this.BusinessKey != null)
                    hashCode = hashCode * 59 + this.BusinessKey.GetHashCode();
                if (this.ProcessDefinitionId != null)
                    hashCode = hashCode * 59 + this.ProcessDefinitionId.GetHashCode();
                if (this.ProcessDefinitionKey != null)
                    hashCode = hashCode * 59 + this.ProcessDefinitionKey.GetHashCode();
                if (this.ProcessInstanceId != null)
                    hashCode = hashCode * 59 + this.ProcessInstanceId.GetHashCode();
                if (this.ActivityId != null)
                    hashCode = hashCode * 59 + this.ActivityId.GetHashCode();
                if (this.SignalEventSubscriptionName != null)
                    hashCode = hashCode * 59 + this.SignalEventSubscriptionName.GetHashCode();
                if (this.MessageEventSubscriptionName != null)
                    hashCode = hashCode * 59 + this.MessageEventSubscriptionName.GetHashCode();
                if (this.Active != null)
                    hashCode = hashCode * 59 + this.Active.GetHashCode();
                if (this.Suspended != null)
                    hashCode = hashCode * 59 + this.Suspended.GetHashCode();
                if (this.IncidentId != null)
                    hashCode = hashCode * 59 + this.IncidentId.GetHashCode();
                if (this.IncidentType != null)
                    hashCode = hashCode * 59 + this.IncidentType.GetHashCode();
                if (this.IncidentMessage != null)
                    hashCode = hashCode * 59 + this.IncidentMessage.GetHashCode();
                if (this.IncidentMessageLike != null)
                    hashCode = hashCode * 59 + this.IncidentMessageLike.GetHashCode();
                if (this.TenantIdIn != null)
                    hashCode = hashCode * 59 + this.TenantIdIn.GetHashCode();
                if (this.Variables != null)
                    hashCode = hashCode * 59 + this.Variables.GetHashCode();
                if (this.ProcessVariables != null)
                    hashCode = hashCode * 59 + this.ProcessVariables.GetHashCode();
                if (this.VariableNamesIgnoreCase != null)
                    hashCode = hashCode * 59 + this.VariableNamesIgnoreCase.GetHashCode();
                if (this.VariableValuesIgnoreCase != null)
                    hashCode = hashCode * 59 + this.VariableValuesIgnoreCase.GetHashCode();
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
