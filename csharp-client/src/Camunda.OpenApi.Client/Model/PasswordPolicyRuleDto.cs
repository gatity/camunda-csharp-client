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
    /// Describes a rule of a password policy.
    /// </summary>
    [DataContract(Name = "PasswordPolicyRuleDto")]
    public partial class PasswordPolicyRuleDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PasswordPolicyRuleDto" /> class.
        /// </summary>
        /// <param name="placeholder">A placeholder string that contains the name of a password policy rule..</param>
        /// <param name="varParameter">A map that describes the characteristics of a password policy rule, such as the minimum number of digits..</param>
        public PasswordPolicyRuleDto(string placeholder = default(string), Dictionary<string, string> varParameter = default(Dictionary<string, string>))
        {
            this.Placeholder = placeholder;
            this.Parameter = varParameter;
        }

        /// <summary>
        /// A placeholder string that contains the name of a password policy rule.
        /// </summary>
        /// <value>A placeholder string that contains the name of a password policy rule.</value>
        [DataMember(Name = "placeholder", EmitDefaultValue = true)]
        public string Placeholder { get; set; }

        /// <summary>
        /// A map that describes the characteristics of a password policy rule, such as the minimum number of digits.
        /// </summary>
        /// <value>A map that describes the characteristics of a password policy rule, such as the minimum number of digits.</value>
        [DataMember(Name = "parameter", EmitDefaultValue = false)]
        public Dictionary<string, string> Parameter { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PasswordPolicyRuleDto {\n");
            sb.Append("  Placeholder: ").Append(Placeholder).Append("\n");
            sb.Append("  Parameter: ").Append(Parameter).Append("\n");
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
