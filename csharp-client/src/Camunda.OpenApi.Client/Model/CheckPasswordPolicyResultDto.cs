/*
 * Camunda Platform REST API
 *
 * OpenApi Spec for Camunda Platform REST API.
 *
 * The version of the OpenAPI document: 7.21.0
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
    /// CheckPasswordPolicyResultDto
    /// </summary>
    [DataContract(Name = "CheckPasswordPolicyResultDto")]
    public partial class CheckPasswordPolicyResultDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckPasswordPolicyResultDto" /> class.
        /// </summary>
        /// <param name="rules">An array of password policy rules. Each element of the array is representing one rule of the policy..</param>
        /// <param name="valid">&#x60;true&#x60; if the password is compliant with the policy, otherwise &#x60;false&#x60;..</param>
        public CheckPasswordPolicyResultDto(List<PasswordPolicyRuleDto> rules = default(List<PasswordPolicyRuleDto>), bool? valid = default(bool?))
        {
            this.Rules = rules;
            this.Valid = valid;
        }

        /// <summary>
        /// An array of password policy rules. Each element of the array is representing one rule of the policy.
        /// </summary>
        /// <value>An array of password policy rules. Each element of the array is representing one rule of the policy.</value>
        [DataMember(Name = "rules", EmitDefaultValue = true)]
        public List<PasswordPolicyRuleDto> Rules { get; set; }

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
            StringBuilder sb = new StringBuilder();
            sb.Append("class CheckPasswordPolicyResultDto {\n");
            sb.Append("  Rules: ").Append(Rules).Append("\n");
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
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
