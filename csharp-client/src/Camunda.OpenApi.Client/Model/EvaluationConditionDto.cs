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
    /// EvaluationConditionDto
    /// </summary>
    [DataContract(Name = "EvaluationConditionDto")]
    public partial class EvaluationConditionDto : IEquatable<EvaluationConditionDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationConditionDto" /> class.
        /// </summary>
        /// <param name="variables">A map of variables which are used for evaluation of the conditions and are injected into the process instances which have been triggered. Each key is a variable name and each value a JSON variable value object with the following properties..</param>
        /// <param name="businessKey">Used for the process instances that have been triggered after the evaluation..</param>
        /// <param name="tenantId">Used to evaluate a condition for a tenant with the given id. Will only evaluate conditions of process definitions which belong to the tenant..</param>
        /// <param name="withoutTenantId">A Boolean value that indicates whether the conditions should only be evaluated of process definitions which belong to no tenant or not. Value may only be true, as false is the default behavior..</param>
        /// <param name="processDefinitionId">Used to evaluate conditions of the process definition with the given id..</param>
        public EvaluationConditionDto(Dictionary<string, VariableValueDto> variables = default(Dictionary<string, VariableValueDto>), string businessKey = default(string), string tenantId = default(string), bool? withoutTenantId = default(bool?), string processDefinitionId = default(string))
        {
            this.Variables = variables;
            this.BusinessKey = businessKey;
            this.TenantId = tenantId;
            this.WithoutTenantId = withoutTenantId;
            this.ProcessDefinitionId = processDefinitionId;
        }

        /// <summary>
        /// A map of variables which are used for evaluation of the conditions and are injected into the process instances which have been triggered. Each key is a variable name and each value a JSON variable value object with the following properties.
        /// </summary>
        /// <value>A map of variables which are used for evaluation of the conditions and are injected into the process instances which have been triggered. Each key is a variable name and each value a JSON variable value object with the following properties.</value>
        [DataMember(Name = "variables", EmitDefaultValue = true)]
        public Dictionary<string, VariableValueDto> Variables { get; set; }

        /// <summary>
        /// Used for the process instances that have been triggered after the evaluation.
        /// </summary>
        /// <value>Used for the process instances that have been triggered after the evaluation.</value>
        [DataMember(Name = "businessKey", EmitDefaultValue = true)]
        public string BusinessKey { get; set; }

        /// <summary>
        /// Used to evaluate a condition for a tenant with the given id. Will only evaluate conditions of process definitions which belong to the tenant.
        /// </summary>
        /// <value>Used to evaluate a condition for a tenant with the given id. Will only evaluate conditions of process definitions which belong to the tenant.</value>
        [DataMember(Name = "tenantId", EmitDefaultValue = true)]
        public string TenantId { get; set; }

        /// <summary>
        /// A Boolean value that indicates whether the conditions should only be evaluated of process definitions which belong to no tenant or not. Value may only be true, as false is the default behavior.
        /// </summary>
        /// <value>A Boolean value that indicates whether the conditions should only be evaluated of process definitions which belong to no tenant or not. Value may only be true, as false is the default behavior.</value>
        [DataMember(Name = "withoutTenantId", EmitDefaultValue = true)]
        public bool? WithoutTenantId { get; set; }

        /// <summary>
        /// Used to evaluate conditions of the process definition with the given id.
        /// </summary>
        /// <value>Used to evaluate conditions of the process definition with the given id.</value>
        [DataMember(Name = "processDefinitionId", EmitDefaultValue = true)]
        public string ProcessDefinitionId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EvaluationConditionDto {\n");
            sb.Append("  Variables: ").Append(Variables).Append("\n");
            sb.Append("  BusinessKey: ").Append(BusinessKey).Append("\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  WithoutTenantId: ").Append(WithoutTenantId).Append("\n");
            sb.Append("  ProcessDefinitionId: ").Append(ProcessDefinitionId).Append("\n");
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
            return this.Equals(input as EvaluationConditionDto);
        }

        /// <summary>
        /// Returns true if EvaluationConditionDto instances are equal
        /// </summary>
        /// <param name="input">Instance of EvaluationConditionDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EvaluationConditionDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Variables == input.Variables ||
                    this.Variables != null &&
                    input.Variables != null &&
                    this.Variables.SequenceEqual(input.Variables)
                ) && 
                (
                    this.BusinessKey == input.BusinessKey ||
                    (this.BusinessKey != null &&
                    this.BusinessKey.Equals(input.BusinessKey))
                ) && 
                (
                    this.TenantId == input.TenantId ||
                    (this.TenantId != null &&
                    this.TenantId.Equals(input.TenantId))
                ) && 
                (
                    this.WithoutTenantId == input.WithoutTenantId ||
                    (this.WithoutTenantId != null &&
                    this.WithoutTenantId.Equals(input.WithoutTenantId))
                ) && 
                (
                    this.ProcessDefinitionId == input.ProcessDefinitionId ||
                    (this.ProcessDefinitionId != null &&
                    this.ProcessDefinitionId.Equals(input.ProcessDefinitionId))
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
                if (this.Variables != null)
                    hashCode = hashCode * 59 + this.Variables.GetHashCode();
                if (this.BusinessKey != null)
                    hashCode = hashCode * 59 + this.BusinessKey.GetHashCode();
                if (this.TenantId != null)
                    hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.WithoutTenantId != null)
                    hashCode = hashCode * 59 + this.WithoutTenantId.GetHashCode();
                if (this.ProcessDefinitionId != null)
                    hashCode = hashCode * 59 + this.ProcessDefinitionId.GetHashCode();
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
