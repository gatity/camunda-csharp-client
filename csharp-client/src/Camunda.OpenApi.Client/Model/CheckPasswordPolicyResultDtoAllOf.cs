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
    /// CheckPasswordPolicyResultDtoAllOf
    /// </summary>
    [DataContract(Name = "CheckPasswordPolicyResultDto_allOf")]
    public partial class CheckPasswordPolicyResultDtoAllOf : IEquatable<CheckPasswordPolicyResultDtoAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckPasswordPolicyResultDtoAllOf" /> class.
        /// </summary>
        /// <param name="valid">&#x60;true&#x60; if the password is compliant with the policy, otherwise &#x60;false&#x60;..</param>
        public CheckPasswordPolicyResultDtoAllOf(bool? valid = default(bool?))
        {
            this.Valid = valid;
        }

        /// <summary>
        /// &#x60;true&#x60; if the password is compliant with the policy, otherwise &#x60;false&#x60;.
        /// </summary>
        /// <value>&#x60;true&#x60; if the password is compliant with the policy, otherwise &#x60;false&#x60;.</value>
        [DataMember(Name = "valid", EmitDefaultValue = true)]
        public bool? Valid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CheckPasswordPolicyResultDtoAllOf {\n");
            sb.Append("  Valid: ").Append(Valid).Append("\n");
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
            return this.Equals(input as CheckPasswordPolicyResultDtoAllOf);
        }

        /// <summary>
        /// Returns true if CheckPasswordPolicyResultDtoAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of CheckPasswordPolicyResultDtoAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CheckPasswordPolicyResultDtoAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Valid == input.Valid ||
                    (this.Valid != null &&
                    this.Valid.Equals(input.Valid))
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
                if (this.Valid != null)
                    hashCode = hashCode * 59 + this.Valid.GetHashCode();
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
