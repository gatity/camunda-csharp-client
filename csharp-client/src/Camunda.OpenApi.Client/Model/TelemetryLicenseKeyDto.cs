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
    /// TelemetryLicenseKeyDto
    /// </summary>
    [DataContract(Name = "TelemetryLicenseKeyDto")]
    public partial class TelemetryLicenseKeyDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TelemetryLicenseKeyDto" /> class.
        /// </summary>
        /// <param name="customer">The name of the customer the license was issued for..</param>
        /// <param name="type">The license type..</param>
        /// <param name="validUntil">The expiration date of the license..</param>
        /// <param name="unlimited">Flag that indicates if the license is unlimited..</param>
        /// <param name="features">A map of features included in the license..</param>
        /// <param name="raw">The raw license information..</param>
        public TelemetryLicenseKeyDto(string customer = default(string), string type = default(string), DateTime? validUntil = default(DateTime?), bool? unlimited = default(bool?), Dictionary<string, string> features = default(Dictionary<string, string>), string raw = default(string))
        {
            this.Customer = customer;
            this.Type = type;
            this.ValidUntil = validUntil;
            this.Unlimited = unlimited;
            this.Features = features;
            this.Raw = raw;
        }

        /// <summary>
        /// The name of the customer the license was issued for.
        /// </summary>
        /// <value>The name of the customer the license was issued for.</value>
        [DataMember(Name = "customer", EmitDefaultValue = true)]
        public string Customer { get; set; }

        /// <summary>
        /// The license type.
        /// </summary>
        /// <value>The license type.</value>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// The expiration date of the license.
        /// </summary>
        /// <value>The expiration date of the license.</value>
        [DataMember(Name = "valid-until", EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? ValidUntil { get; set; }

        /// <summary>
        /// Flag that indicates if the license is unlimited.
        /// </summary>
        /// <value>Flag that indicates if the license is unlimited.</value>
        [DataMember(Name = "unlimited", EmitDefaultValue = true)]
        public bool? Unlimited { get; set; }

        /// <summary>
        /// A map of features included in the license.
        /// </summary>
        /// <value>A map of features included in the license.</value>
        [DataMember(Name = "features", EmitDefaultValue = false)]
        public Dictionary<string, string> Features { get; set; }

        /// <summary>
        /// The raw license information.
        /// </summary>
        /// <value>The raw license information.</value>
        [DataMember(Name = "raw", EmitDefaultValue = true)]
        public string Raw { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TelemetryLicenseKeyDto {\n");
            sb.Append("  Customer: ").Append(Customer).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ValidUntil: ").Append(ValidUntil).Append("\n");
            sb.Append("  Unlimited: ").Append(Unlimited).Append("\n");
            sb.Append("  Features: ").Append(Features).Append("\n");
            sb.Append("  Raw: ").Append(Raw).Append("\n");
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
