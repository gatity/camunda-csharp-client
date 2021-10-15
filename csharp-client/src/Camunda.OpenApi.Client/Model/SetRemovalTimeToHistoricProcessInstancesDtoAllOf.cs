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
    /// SetRemovalTimeToHistoricProcessInstancesDtoAllOf
    /// </summary>
    [DataContract(Name = "SetRemovalTimeToHistoricProcessInstancesDto_allOf")]
    public partial class SetRemovalTimeToHistoricProcessInstancesDtoAllOf : IEquatable<SetRemovalTimeToHistoricProcessInstancesDtoAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SetRemovalTimeToHistoricProcessInstancesDtoAllOf" /> class.
        /// </summary>
        /// <param name="historicProcessInstanceIds">The id of the process instance..</param>
        /// <param name="historicProcessInstanceQuery">historicProcessInstanceQuery.</param>
        /// <param name="hierarchical">Sets the removal time to all historic process instances in the hierarchy. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior..</param>
        public SetRemovalTimeToHistoricProcessInstancesDtoAllOf(List<string> historicProcessInstanceIds = default(List<string>), HistoricProcessInstanceQueryDto historicProcessInstanceQuery = default(HistoricProcessInstanceQueryDto), bool? hierarchical = default(bool?))
        {
            this.HistoricProcessInstanceIds = historicProcessInstanceIds;
            this.HistoricProcessInstanceQuery = historicProcessInstanceQuery;
            this.Hierarchical = hierarchical;
        }

        /// <summary>
        /// The id of the process instance.
        /// </summary>
        /// <value>The id of the process instance.</value>
        [DataMember(Name = "historicProcessInstanceIds", EmitDefaultValue = true)]
        public List<string> HistoricProcessInstanceIds { get; set; }

        /// <summary>
        /// Gets or Sets HistoricProcessInstanceQuery
        /// </summary>
        [DataMember(Name = "historicProcessInstanceQuery", EmitDefaultValue = false)]
        public HistoricProcessInstanceQueryDto HistoricProcessInstanceQuery { get; set; }

        /// <summary>
        /// Sets the removal time to all historic process instances in the hierarchy. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior.
        /// </summary>
        /// <value>Sets the removal time to all historic process instances in the hierarchy. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior.</value>
        [DataMember(Name = "hierarchical", EmitDefaultValue = true)]
        public bool? Hierarchical { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SetRemovalTimeToHistoricProcessInstancesDtoAllOf {\n");
            sb.Append("  HistoricProcessInstanceIds: ").Append(HistoricProcessInstanceIds).Append("\n");
            sb.Append("  HistoricProcessInstanceQuery: ").Append(HistoricProcessInstanceQuery).Append("\n");
            sb.Append("  Hierarchical: ").Append(Hierarchical).Append("\n");
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
            return this.Equals(input as SetRemovalTimeToHistoricProcessInstancesDtoAllOf);
        }

        /// <summary>
        /// Returns true if SetRemovalTimeToHistoricProcessInstancesDtoAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of SetRemovalTimeToHistoricProcessInstancesDtoAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SetRemovalTimeToHistoricProcessInstancesDtoAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.HistoricProcessInstanceIds == input.HistoricProcessInstanceIds ||
                    this.HistoricProcessInstanceIds != null &&
                    input.HistoricProcessInstanceIds != null &&
                    this.HistoricProcessInstanceIds.SequenceEqual(input.HistoricProcessInstanceIds)
                ) && 
                (
                    this.HistoricProcessInstanceQuery == input.HistoricProcessInstanceQuery ||
                    (this.HistoricProcessInstanceQuery != null &&
                    this.HistoricProcessInstanceQuery.Equals(input.HistoricProcessInstanceQuery))
                ) && 
                (
                    this.Hierarchical == input.Hierarchical ||
                    (this.Hierarchical != null &&
                    this.Hierarchical.Equals(input.Hierarchical))
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
                if (this.HistoricProcessInstanceIds != null)
                    hashCode = hashCode * 59 + this.HistoricProcessInstanceIds.GetHashCode();
                if (this.HistoricProcessInstanceQuery != null)
                    hashCode = hashCode * 59 + this.HistoricProcessInstanceQuery.GetHashCode();
                if (this.Hierarchical != null)
                    hashCode = hashCode * 59 + this.Hierarchical.GetHashCode();
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
