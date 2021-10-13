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
    /// SetRemovalTimeToHistoricBatchesDtoAllOf
    /// </summary>
    [DataContract(Name = "SetRemovalTimeToHistoricBatchesDto_allOf")]
    public partial class SetRemovalTimeToHistoricBatchesDtoAllOf : IEquatable<SetRemovalTimeToHistoricBatchesDtoAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SetRemovalTimeToHistoricBatchesDtoAllOf" /> class.
        /// </summary>
        /// <param name="historicBatchQuery">Query for the historic batches to set the removal time for..</param>
        /// <param name="historicBatchIds">The ids of the historic batches to set the removal time for..</param>
        public SetRemovalTimeToHistoricBatchesDtoAllOf(Object historicBatchQuery = default(Object), List<string> historicBatchIds = default(List<string>))
        {
            this.HistoricBatchQuery = historicBatchQuery;
            this.HistoricBatchIds = historicBatchIds;
        }

        /// <summary>
        /// Query for the historic batches to set the removal time for.
        /// </summary>
        /// <value>Query for the historic batches to set the removal time for.</value>
        [DataMember(Name = "historicBatchQuery", EmitDefaultValue = true)]
        public Object HistoricBatchQuery { get; set; }

        /// <summary>
        /// The ids of the historic batches to set the removal time for.
        /// </summary>
        /// <value>The ids of the historic batches to set the removal time for.</value>
        [DataMember(Name = "historicBatchIds", EmitDefaultValue = true)]
        public List<string> HistoricBatchIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SetRemovalTimeToHistoricBatchesDtoAllOf {\n");
            sb.Append("  HistoricBatchQuery: ").Append(HistoricBatchQuery).Append("\n");
            sb.Append("  HistoricBatchIds: ").Append(HistoricBatchIds).Append("\n");
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
            return this.Equals(input as SetRemovalTimeToHistoricBatchesDtoAllOf);
        }

        /// <summary>
        /// Returns true if SetRemovalTimeToHistoricBatchesDtoAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of SetRemovalTimeToHistoricBatchesDtoAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SetRemovalTimeToHistoricBatchesDtoAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.HistoricBatchQuery == input.HistoricBatchQuery ||
                    (this.HistoricBatchQuery != null &&
                    this.HistoricBatchQuery.Equals(input.HistoricBatchQuery))
                ) && 
                (
                    this.HistoricBatchIds == input.HistoricBatchIds ||
                    this.HistoricBatchIds != null &&
                    input.HistoricBatchIds != null &&
                    this.HistoricBatchIds.SequenceEqual(input.HistoricBatchIds)
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
                if (this.HistoricBatchQuery != null)
                    hashCode = hashCode * 59 + this.HistoricBatchQuery.GetHashCode();
                if (this.HistoricBatchIds != null)
                    hashCode = hashCode * 59 + this.HistoricBatchIds.GetHashCode();
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
