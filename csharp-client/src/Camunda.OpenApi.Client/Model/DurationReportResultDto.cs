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
    /// DurationReportResultDto
    /// </summary>
    [DataContract(Name = "DurationReportResultDto")]
    public partial class DurationReportResultDto : IEquatable<DurationReportResultDto>, IValidatableObject
    {
        /// <summary>
        /// The unit of the given period. Possible values are &#x60;MONTH&#x60; and &#x60;QUARTER&#x60;.
        /// </summary>
        /// <value>The unit of the given period. Possible values are &#x60;MONTH&#x60; and &#x60;QUARTER&#x60;.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PeriodUnitEnum
        {
            /// <summary>
            /// Enum MONTH for value: MONTH
            /// </summary>
            [EnumMember(Value = "MONTH")]
            MONTH = 1,

            /// <summary>
            /// Enum QUARTER for value: QUARTER
            /// </summary>
            [EnumMember(Value = "QUARTER")]
            QUARTER = 2

        }


        /// <summary>
        /// The unit of the given period. Possible values are &#x60;MONTH&#x60; and &#x60;QUARTER&#x60;.
        /// </summary>
        /// <value>The unit of the given period. Possible values are &#x60;MONTH&#x60; and &#x60;QUARTER&#x60;.</value>
        [DataMember(Name = "periodUnit", EmitDefaultValue = true)]
        public PeriodUnitEnum? PeriodUnit { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DurationReportResultDto" /> class.
        /// </summary>
        /// <param name="period">Specifies a timespan within a year. **Note:** The period must be interpreted in conjunction with the returned &#x60;periodUnit&#x60;..</param>
        /// <param name="periodUnit">The unit of the given period. Possible values are &#x60;MONTH&#x60; and &#x60;QUARTER&#x60;..</param>
        /// <param name="minimum">The smallest duration in milliseconds of all completed process instances which were started in the given period..</param>
        /// <param name="maximum">The greatest duration in milliseconds of all completed process instances which were started in the given period..</param>
        /// <param name="average">The average duration in milliseconds of all completed process instances which were started in the given period..</param>
        public DurationReportResultDto(int? period = default(int?), PeriodUnitEnum? periodUnit = default(PeriodUnitEnum?), long? minimum = default(long?), long? maximum = default(long?), long? average = default(long?))
        {
            this.Period = period;
            this.PeriodUnit = periodUnit;
            this.Minimum = minimum;
            this.Maximum = maximum;
            this.Average = average;
        }

        /// <summary>
        /// Specifies a timespan within a year. **Note:** The period must be interpreted in conjunction with the returned &#x60;periodUnit&#x60;.
        /// </summary>
        /// <value>Specifies a timespan within a year. **Note:** The period must be interpreted in conjunction with the returned &#x60;periodUnit&#x60;.</value>
        [DataMember(Name = "period", EmitDefaultValue = true)]
        public int? Period { get; set; }

        /// <summary>
        /// The smallest duration in milliseconds of all completed process instances which were started in the given period.
        /// </summary>
        /// <value>The smallest duration in milliseconds of all completed process instances which were started in the given period.</value>
        [DataMember(Name = "minimum", EmitDefaultValue = true)]
        public long? Minimum { get; set; }

        /// <summary>
        /// The greatest duration in milliseconds of all completed process instances which were started in the given period.
        /// </summary>
        /// <value>The greatest duration in milliseconds of all completed process instances which were started in the given period.</value>
        [DataMember(Name = "maximum", EmitDefaultValue = true)]
        public long? Maximum { get; set; }

        /// <summary>
        /// The average duration in milliseconds of all completed process instances which were started in the given period.
        /// </summary>
        /// <value>The average duration in milliseconds of all completed process instances which were started in the given period.</value>
        [DataMember(Name = "average", EmitDefaultValue = true)]
        public long? Average { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DurationReportResultDto {\n");
            sb.Append("  Period: ").Append(Period).Append("\n");
            sb.Append("  PeriodUnit: ").Append(PeriodUnit).Append("\n");
            sb.Append("  Minimum: ").Append(Minimum).Append("\n");
            sb.Append("  Maximum: ").Append(Maximum).Append("\n");
            sb.Append("  Average: ").Append(Average).Append("\n");
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
            return this.Equals(input as DurationReportResultDto);
        }

        /// <summary>
        /// Returns true if DurationReportResultDto instances are equal
        /// </summary>
        /// <param name="input">Instance of DurationReportResultDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DurationReportResultDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Period == input.Period ||
                    (this.Period != null &&
                    this.Period.Equals(input.Period))
                ) && 
                (
                    this.PeriodUnit == input.PeriodUnit ||
                    this.PeriodUnit.Equals(input.PeriodUnit)
                ) && 
                (
                    this.Minimum == input.Minimum ||
                    (this.Minimum != null &&
                    this.Minimum.Equals(input.Minimum))
                ) && 
                (
                    this.Maximum == input.Maximum ||
                    (this.Maximum != null &&
                    this.Maximum.Equals(input.Maximum))
                ) && 
                (
                    this.Average == input.Average ||
                    (this.Average != null &&
                    this.Average.Equals(input.Average))
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
                if (this.Period != null)
                    hashCode = hashCode * 59 + this.Period.GetHashCode();
                hashCode = hashCode * 59 + this.PeriodUnit.GetHashCode();
                if (this.Minimum != null)
                    hashCode = hashCode * 59 + this.Minimum.GetHashCode();
                if (this.Maximum != null)
                    hashCode = hashCode * 59 + this.Maximum.GetHashCode();
                if (this.Average != null)
                    hashCode = hashCode * 59 + this.Average.GetHashCode();
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
