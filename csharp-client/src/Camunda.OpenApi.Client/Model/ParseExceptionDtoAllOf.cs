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
    /// ParseExceptionDtoAllOf
    /// </summary>
    [DataContract(Name = "ParseExceptionDto_allOf")]
    public partial class ParseExceptionDtoAllOf : IEquatable<ParseExceptionDtoAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ParseExceptionDtoAllOf" /> class.
        /// </summary>
        /// <param name="details">A JSON Object containing list of errors and warnings occurred during deployment..</param>
        public ParseExceptionDtoAllOf(Dictionary<string, ResourceReportDto> details = default(Dictionary<string, ResourceReportDto>))
        {
            this.Details = details;
        }

        /// <summary>
        /// A JSON Object containing list of errors and warnings occurred during deployment.
        /// </summary>
        /// <value>A JSON Object containing list of errors and warnings occurred during deployment.</value>
        [DataMember(Name = "details", EmitDefaultValue = true)]
        public Dictionary<string, ResourceReportDto> Details { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ParseExceptionDtoAllOf {\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
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
            return this.Equals(input as ParseExceptionDtoAllOf);
        }

        /// <summary>
        /// Returns true if ParseExceptionDtoAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of ParseExceptionDtoAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ParseExceptionDtoAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Details == input.Details ||
                    this.Details != null &&
                    input.Details != null &&
                    this.Details.SequenceEqual(input.Details)
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
                if (this.Details != null)
                    hashCode = hashCode * 59 + this.Details.GetHashCode();
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
