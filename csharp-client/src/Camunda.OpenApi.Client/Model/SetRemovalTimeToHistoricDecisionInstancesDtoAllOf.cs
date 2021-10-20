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
    /// SetRemovalTimeToHistoricDecisionInstancesDtoAllOf
    /// </summary>
    [DataContract(Name = "SetRemovalTimeToHistoricDecisionInstancesDto_allOf")]
    public partial class SetRemovalTimeToHistoricDecisionInstancesDtoAllOf : IEquatable<SetRemovalTimeToHistoricDecisionInstancesDtoAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SetRemovalTimeToHistoricDecisionInstancesDtoAllOf" /> class.
        /// </summary>
        /// <param name="hierarchical">Sets the removal time to all historic decision instances in the hierarchy. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior..</param>
        /// <param name="historicDecisionInstanceQuery">historicDecisionInstanceQuery.</param>
        /// <param name="historicDecisionInstanceIds">The ids of the historic decision instances to set the removal time for..</param>
        public SetRemovalTimeToHistoricDecisionInstancesDtoAllOf(bool? hierarchical = default(bool?), HistoricDecisionInstanceQueryDto historicDecisionInstanceQuery = default(HistoricDecisionInstanceQueryDto), List<string> historicDecisionInstanceIds = default(List<string>))
        {
            this.Hierarchical = hierarchical;
            this.HistoricDecisionInstanceQuery = historicDecisionInstanceQuery;
            this.HistoricDecisionInstanceIds = historicDecisionInstanceIds;
        }

        /// <summary>
        /// Sets the removal time to all historic decision instances in the hierarchy. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior.
        /// </summary>
        /// <value>Sets the removal time to all historic decision instances in the hierarchy. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior.</value>
        [DataMember(Name = "hierarchical", EmitDefaultValue = true)]
        public bool? Hierarchical { get; set; }

        /// <summary>
        /// Gets or Sets HistoricDecisionInstanceQuery
        /// </summary>
        [DataMember(Name = "historicDecisionInstanceQuery", EmitDefaultValue = false)]
        public HistoricDecisionInstanceQueryDto HistoricDecisionInstanceQuery { get; set; }

        /// <summary>
        /// The ids of the historic decision instances to set the removal time for.
        /// </summary>
        /// <value>The ids of the historic decision instances to set the removal time for.</value>
        [DataMember(Name = "historicDecisionInstanceIds", EmitDefaultValue = true)]
        public List<string> HistoricDecisionInstanceIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SetRemovalTimeToHistoricDecisionInstancesDtoAllOf {\n");
            sb.Append("  Hierarchical: ").Append(Hierarchical).Append("\n");
            sb.Append("  HistoricDecisionInstanceQuery: ").Append(HistoricDecisionInstanceQuery).Append("\n");
            sb.Append("  HistoricDecisionInstanceIds: ").Append(HistoricDecisionInstanceIds).Append("\n");
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
            return this.Equals(input as SetRemovalTimeToHistoricDecisionInstancesDtoAllOf);
        }

        /// <summary>
        /// Returns true if SetRemovalTimeToHistoricDecisionInstancesDtoAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of SetRemovalTimeToHistoricDecisionInstancesDtoAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SetRemovalTimeToHistoricDecisionInstancesDtoAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Hierarchical == input.Hierarchical ||
                    (this.Hierarchical != null &&
                    this.Hierarchical.Equals(input.Hierarchical))
                ) && 
                (
                    this.HistoricDecisionInstanceQuery == input.HistoricDecisionInstanceQuery ||
                    (this.HistoricDecisionInstanceQuery != null &&
                    this.HistoricDecisionInstanceQuery.Equals(input.HistoricDecisionInstanceQuery))
                ) && 
                (
                    this.HistoricDecisionInstanceIds == input.HistoricDecisionInstanceIds ||
                    this.HistoricDecisionInstanceIds != null &&
                    input.HistoricDecisionInstanceIds != null &&
                    this.HistoricDecisionInstanceIds.SequenceEqual(input.HistoricDecisionInstanceIds)
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
                if (this.Hierarchical != null)
                    hashCode = hashCode * 59 + this.Hierarchical.GetHashCode();
                if (this.HistoricDecisionInstanceQuery != null)
                    hashCode = hashCode * 59 + this.HistoricDecisionInstanceQuery.GetHashCode();
                if (this.HistoricDecisionInstanceIds != null)
                    hashCode = hashCode * 59 + this.HistoricDecisionInstanceIds.GetHashCode();
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