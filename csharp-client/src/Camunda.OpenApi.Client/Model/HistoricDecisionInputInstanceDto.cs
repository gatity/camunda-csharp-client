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
using FileParameter = Camunda.OpenApi.Client.Client.FileParameter;
using OpenAPIDateConverter = Camunda.OpenApi.Client.Client.OpenAPIDateConverter;

namespace Camunda.OpenApi.Client.Model
{
    /// <summary>
    /// HistoricDecisionInputInstanceDto
    /// </summary>
    [DataContract(Name = "HistoricDecisionInputInstanceDto")]
    public partial class HistoricDecisionInputInstanceDto : IEquatable<HistoricDecisionInputInstanceDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HistoricDecisionInputInstanceDto" /> class.
        /// </summary>
        /// <param name="id">The id of the decision input value..</param>
        /// <param name="decisionInstanceId">The id of the decision instance the input value belongs to..</param>
        /// <param name="clauseId">The id of the clause the input value belongs to..</param>
        /// <param name="clauseName">The name of the clause the input value belongs to..</param>
        /// <param name="errorMessage">An error message in case a Java Serialized Object could not be de-serialized..</param>
        /// <param name="type">The value type of the variable..</param>
        /// <param name="createTime">The time the variable was inserted.  [Default format](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/) &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;..</param>
        /// <param name="removalTime">The time after which the entry should be removed by the History Cleanup job. [Default format](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/) &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;..</param>
        /// <param name="rootProcessInstanceId">The process instance id of the root process instance that initiated the process containing this entry..</param>
        /// <param name="value">The variable&#39;s value. Value differs depending on the variable&#39;s type and on the &#x60;disableCustomObjectDeserialization&#x60; parameter..</param>
        /// <param name="valueInfo">A JSON object containing additional, value-type-dependent properties.  For variables of type &#x60;Object&#x60;, the following properties are returned:  * &#x60;objectTypeName&#x60;: A string representation of the object&#39;s type name.  * &#x60;serializationDataFormat&#x60;: The serialization format used to store the variable..</param>
        public HistoricDecisionInputInstanceDto(string id = default(string), string decisionInstanceId = default(string), string clauseId = default(string), string clauseName = default(string), string errorMessage = default(string), string type = default(string), DateTime? createTime = default(DateTime?), DateTime? removalTime = default(DateTime?), string rootProcessInstanceId = default(string), Object value = default(Object), Dictionary<string, Object> valueInfo = default(Dictionary<string, Object>))
        {
            this.Id = id;
            this.DecisionInstanceId = decisionInstanceId;
            this.ClauseId = clauseId;
            this.ClauseName = clauseName;
            this.ErrorMessage = errorMessage;
            this.Type = type;
            this.CreateTime = createTime;
            this.RemovalTime = removalTime;
            this.RootProcessInstanceId = rootProcessInstanceId;
            this.Value = value;
            this.ValueInfo = valueInfo;
        }

        /// <summary>
        /// The id of the decision input value.
        /// </summary>
        /// <value>The id of the decision input value.</value>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// The id of the decision instance the input value belongs to.
        /// </summary>
        /// <value>The id of the decision instance the input value belongs to.</value>
        [DataMember(Name = "decisionInstanceId", EmitDefaultValue = true)]
        public string DecisionInstanceId { get; set; }

        /// <summary>
        /// The id of the clause the input value belongs to.
        /// </summary>
        /// <value>The id of the clause the input value belongs to.</value>
        [DataMember(Name = "clauseId", EmitDefaultValue = true)]
        public string ClauseId { get; set; }

        /// <summary>
        /// The name of the clause the input value belongs to.
        /// </summary>
        /// <value>The name of the clause the input value belongs to.</value>
        [DataMember(Name = "clauseName", EmitDefaultValue = true)]
        public string ClauseName { get; set; }

        /// <summary>
        /// An error message in case a Java Serialized Object could not be de-serialized.
        /// </summary>
        /// <value>An error message in case a Java Serialized Object could not be de-serialized.</value>
        [DataMember(Name = "errorMessage", EmitDefaultValue = true)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The value type of the variable.
        /// </summary>
        /// <value>The value type of the variable.</value>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// The time the variable was inserted.  [Default format](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/) &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;.
        /// </summary>
        /// <value>The time the variable was inserted.  [Default format](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/) &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;.</value>
        [DataMember(Name = "createTime", EmitDefaultValue = true)]
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// The time after which the entry should be removed by the History Cleanup job. [Default format](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/) &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;.
        /// </summary>
        /// <value>The time after which the entry should be removed by the History Cleanup job. [Default format](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/) &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;.</value>
        [DataMember(Name = "removalTime", EmitDefaultValue = true)]
        public DateTime? RemovalTime { get; set; }

        /// <summary>
        /// The process instance id of the root process instance that initiated the process containing this entry.
        /// </summary>
        /// <value>The process instance id of the root process instance that initiated the process containing this entry.</value>
        [DataMember(Name = "rootProcessInstanceId", EmitDefaultValue = true)]
        public string RootProcessInstanceId { get; set; }

        /// <summary>
        /// The variable&#39;s value. Value differs depending on the variable&#39;s type and on the &#x60;disableCustomObjectDeserialization&#x60; parameter.
        /// </summary>
        /// <value>The variable&#39;s value. Value differs depending on the variable&#39;s type and on the &#x60;disableCustomObjectDeserialization&#x60; parameter.</value>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public Object Value { get; set; }

        /// <summary>
        /// A JSON object containing additional, value-type-dependent properties.  For variables of type &#x60;Object&#x60;, the following properties are returned:  * &#x60;objectTypeName&#x60;: A string representation of the object&#39;s type name.  * &#x60;serializationDataFormat&#x60;: The serialization format used to store the variable.
        /// </summary>
        /// <value>A JSON object containing additional, value-type-dependent properties.  For variables of type &#x60;Object&#x60;, the following properties are returned:  * &#x60;objectTypeName&#x60;: A string representation of the object&#39;s type name.  * &#x60;serializationDataFormat&#x60;: The serialization format used to store the variable.</value>
        [DataMember(Name = "valueInfo", EmitDefaultValue = false)]
        public Dictionary<string, Object> ValueInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HistoricDecisionInputInstanceDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DecisionInstanceId: ").Append(DecisionInstanceId).Append("\n");
            sb.Append("  ClauseId: ").Append(ClauseId).Append("\n");
            sb.Append("  ClauseName: ").Append(ClauseName).Append("\n");
            sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  CreateTime: ").Append(CreateTime).Append("\n");
            sb.Append("  RemovalTime: ").Append(RemovalTime).Append("\n");
            sb.Append("  RootProcessInstanceId: ").Append(RootProcessInstanceId).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as HistoricDecisionInputInstanceDto);
        }

        /// <summary>
        /// Returns true if HistoricDecisionInputInstanceDto instances are equal
        /// </summary>
        /// <param name="input">Instance of HistoricDecisionInputInstanceDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HistoricDecisionInputInstanceDto input)
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
                    this.DecisionInstanceId == input.DecisionInstanceId ||
                    (this.DecisionInstanceId != null &&
                    this.DecisionInstanceId.Equals(input.DecisionInstanceId))
                ) && 
                (
                    this.ClauseId == input.ClauseId ||
                    (this.ClauseId != null &&
                    this.ClauseId.Equals(input.ClauseId))
                ) && 
                (
                    this.ClauseName == input.ClauseName ||
                    (this.ClauseName != null &&
                    this.ClauseName.Equals(input.ClauseName))
                ) && 
                (
                    this.ErrorMessage == input.ErrorMessage ||
                    (this.ErrorMessage != null &&
                    this.ErrorMessage.Equals(input.ErrorMessage))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.DecisionInstanceId != null)
                    hashCode = hashCode * 59 + this.DecisionInstanceId.GetHashCode();
                if (this.ClauseId != null)
                    hashCode = hashCode * 59 + this.ClauseId.GetHashCode();
                if (this.ClauseName != null)
                    hashCode = hashCode * 59 + this.ClauseName.GetHashCode();
                if (this.ErrorMessage != null)
                    hashCode = hashCode * 59 + this.ErrorMessage.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.CreateTime != null)
                    hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.RemovalTime != null)
                    hashCode = hashCode * 59 + this.RemovalTime.GetHashCode();
                if (this.RootProcessInstanceId != null)
                    hashCode = hashCode * 59 + this.RootProcessInstanceId.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
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