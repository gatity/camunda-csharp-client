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
    /// HistoryTimeToLiveDto
    /// </summary>
    [DataContract(Name = "HistoryTimeToLiveDto")]
    public partial class HistoryTimeToLiveDto : IEquatable<HistoryTimeToLiveDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HistoryTimeToLiveDto" /> class.
        /// </summary>
        /// <param name="historyTimeToLive">New value for historyTimeToLive field of the definition. Can be &#x60;null&#x60;. Can not be negative..</param>
        public HistoryTimeToLiveDto(int? historyTimeToLive = default(int?))
        {
            this.HistoryTimeToLive = historyTimeToLive;
        }

        /// <summary>
        /// New value for historyTimeToLive field of the definition. Can be &#x60;null&#x60;. Can not be negative.
        /// </summary>
        /// <value>New value for historyTimeToLive field of the definition. Can be &#x60;null&#x60;. Can not be negative.</value>
        [DataMember(Name = "historyTimeToLive", EmitDefaultValue = true)]
        public int? HistoryTimeToLive { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HistoryTimeToLiveDto {\n");
            sb.Append("  HistoryTimeToLive: ").Append(HistoryTimeToLive).Append("\n");
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
            return this.Equals(input as HistoryTimeToLiveDto);
        }

        /// <summary>
        /// Returns true if HistoryTimeToLiveDto instances are equal
        /// </summary>
        /// <param name="input">Instance of HistoryTimeToLiveDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HistoryTimeToLiveDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.HistoryTimeToLive == input.HistoryTimeToLive ||
                    (this.HistoryTimeToLive != null &&
                    this.HistoryTimeToLive.Equals(input.HistoryTimeToLive))
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
                if (this.HistoryTimeToLive != null)
                    hashCode = hashCode * 59 + this.HistoryTimeToLive.GetHashCode();
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
            // HistoryTimeToLive (int?) minimum
            if(this.HistoryTimeToLive < (int?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for HistoryTimeToLive, must be a value greater than or equal to 0.", new [] { "HistoryTimeToLive" });
            }

            yield break;
        }
    }

}
