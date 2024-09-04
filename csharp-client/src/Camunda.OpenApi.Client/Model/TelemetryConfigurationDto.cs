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
    /// TelemetryConfigurationDto
    /// </summary>
    [DataContract(Name = "TelemetryConfigurationDto")]
    public partial class TelemetryConfigurationDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TelemetryConfigurationDto" /> class.
        /// </summary>
        /// <param name="enableTelemetry">Specifies if the telemetry data should be sent or not..</param>
        public TelemetryConfigurationDto(bool? enableTelemetry = default(bool?))
        {
            this.EnableTelemetry = enableTelemetry;
        }

        /// <summary>
        /// Specifies if the telemetry data should be sent or not.
        /// </summary>
        /// <value>Specifies if the telemetry data should be sent or not.</value>
        [DataMember(Name = "enableTelemetry", EmitDefaultValue = true)]
        public bool? EnableTelemetry { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TelemetryConfigurationDto {\n");
            sb.Append("  EnableTelemetry: ").Append(EnableTelemetry).Append("\n");
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
