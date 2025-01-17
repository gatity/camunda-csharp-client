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
    /// SchemaLogQueryDto
    /// </summary>
    [DataContract(Name = "SchemaLogQueryDto")]
    public partial class SchemaLogQueryDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SchemaLogQueryDto" /> class.
        /// </summary>
        /// <param name="varVersion">The version of the schema..</param>
        /// <param name="sorting">A JSON array of criteria to sort the result by. Each element of the array is                       a JSON object that specifies one ordering. The position in the array                       identifies the rank of an ordering, i.e., whether it is primary, secondary,                       etc. .</param>
        public SchemaLogQueryDto(string varVersion = default(string), List<SchemaLogQueryDtoSortingInner> sorting = default(List<SchemaLogQueryDtoSortingInner>))
        {
            this.VarVersion = varVersion;
            this.Sorting = sorting;
        }

        /// <summary>
        /// The version of the schema.
        /// </summary>
        /// <value>The version of the schema.</value>
        [DataMember(Name = "version", EmitDefaultValue = true)]
        public string VarVersion { get; set; }

        /// <summary>
        /// A JSON array of criteria to sort the result by. Each element of the array is                       a JSON object that specifies one ordering. The position in the array                       identifies the rank of an ordering, i.e., whether it is primary, secondary,                       etc. 
        /// </summary>
        /// <value>A JSON array of criteria to sort the result by. Each element of the array is                       a JSON object that specifies one ordering. The position in the array                       identifies the rank of an ordering, i.e., whether it is primary, secondary,                       etc. </value>
        [DataMember(Name = "sorting", EmitDefaultValue = true)]
        public List<SchemaLogQueryDtoSortingInner> Sorting { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SchemaLogQueryDto {\n");
            sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
            sb.Append("  Sorting: ").Append(Sorting).Append("\n");
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
