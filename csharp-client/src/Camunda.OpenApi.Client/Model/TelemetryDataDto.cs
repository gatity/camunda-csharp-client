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
    /// TelemetryDataDto
    /// </summary>
    [DataContract(Name = "TelemetryDataDto")]
    public partial class TelemetryDataDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TelemetryDataDto" /> class.
        /// </summary>
        /// <param name="installation">An id which is unique for each installation of Camunda. It is stored once per database so all engines connected to the same database will have the same installation ID. The ID is used to identify a single installation of Camunda Platform..</param>
        /// <param name="product">product.</param>
        public TelemetryDataDto(string installation = default(string), TelemetryProductDto product = default(TelemetryProductDto))
        {
            this.Installation = installation;
            this.Product = product;
        }

        /// <summary>
        /// An id which is unique for each installation of Camunda. It is stored once per database so all engines connected to the same database will have the same installation ID. The ID is used to identify a single installation of Camunda Platform.
        /// </summary>
        /// <value>An id which is unique for each installation of Camunda. It is stored once per database so all engines connected to the same database will have the same installation ID. The ID is used to identify a single installation of Camunda Platform.</value>
        [DataMember(Name = "installation", EmitDefaultValue = true)]
        public string Installation { get; set; }

        /// <summary>
        /// Gets or Sets Product
        /// </summary>
        [DataMember(Name = "product", EmitDefaultValue = false)]
        public TelemetryProductDto Product { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TelemetryDataDto {\n");
            sb.Append("  Installation: ").Append(Installation).Append("\n");
            sb.Append("  Product: ").Append(Product).Append("\n");
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
