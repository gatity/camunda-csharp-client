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
    /// VariableQueryParameterDto
    /// </summary>
    [DataContract(Name = "VariableQueryParameterDto")]
    public partial class VariableQueryParameterDto : IValidatableObject
    {
        /// <summary>
        /// Comparison operator to be used. &#x60;notLike&#x60; is not supported by all endpoints.
        /// </summary>
        /// <value>Comparison operator to be used. &#x60;notLike&#x60; is not supported by all endpoints.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OperatorEnum
        {
            /// <summary>
            /// Enum Eq for value: eq
            /// </summary>
            [EnumMember(Value = "eq")]
            Eq = 1,

            /// <summary>
            /// Enum Neq for value: neq
            /// </summary>
            [EnumMember(Value = "neq")]
            Neq = 2,

            /// <summary>
            /// Enum Gt for value: gt
            /// </summary>
            [EnumMember(Value = "gt")]
            Gt = 3,

            /// <summary>
            /// Enum Gteq for value: gteq
            /// </summary>
            [EnumMember(Value = "gteq")]
            Gteq = 4,

            /// <summary>
            /// Enum Lt for value: lt
            /// </summary>
            [EnumMember(Value = "lt")]
            Lt = 5,

            /// <summary>
            /// Enum Lteq for value: lteq
            /// </summary>
            [EnumMember(Value = "lteq")]
            Lteq = 6,

            /// <summary>
            /// Enum Like for value: like
            /// </summary>
            [EnumMember(Value = "like")]
            Like = 7,

            /// <summary>
            /// Enum NotLike for value: notLike
            /// </summary>
            [EnumMember(Value = "notLike")]
            NotLike = 8
        }


        /// <summary>
        /// Comparison operator to be used. &#x60;notLike&#x60; is not supported by all endpoints.
        /// </summary>
        /// <value>Comparison operator to be used. &#x60;notLike&#x60; is not supported by all endpoints.</value>
        [DataMember(Name = "operator", EmitDefaultValue = true)]
        public OperatorEnum? Operator { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="VariableQueryParameterDto" /> class.
        /// </summary>
        /// <param name="varOperator">Comparison operator to be used. &#x60;notLike&#x60; is not supported by all endpoints..</param>
        /// <param name="value">Can be any value - string, number, boolean, array or object.  **Note**: Not every endpoint supports every type..</param>
        /// <param name="name">Variable name.</param>
        public VariableQueryParameterDto(OperatorEnum? varOperator = default(OperatorEnum?), Object value = default(Object), string name = default(string))
        {
            this.Operator = varOperator;
            this.Value = value;
            this.Name = name;
        }

        /// <summary>
        /// Can be any value - string, number, boolean, array or object.  **Note**: Not every endpoint supports every type.
        /// </summary>
        /// <value>Can be any value - string, number, boolean, array or object.  **Note**: Not every endpoint supports every type.</value>
        [DataMember(Name = "value", EmitDefaultValue = true)]
        public Object Value { get; set; }

        /// <summary>
        /// Variable name
        /// </summary>
        /// <value>Variable name</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VariableQueryParameterDto {\n");
            sb.Append("  Operator: ").Append(Operator).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
