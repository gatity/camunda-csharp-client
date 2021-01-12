/*
 * Camunda BPM REST API
 *
 * OpenApi Spec for Camunda BPM REST API.
 *
 * The version of the OpenAPI document: 7.14.0
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
using OpenAPIDateConverter = CamundaClient.Client.OpenAPIDateConverter;

namespace CamundaClient.Model
{
    /// <summary>
    /// SuspensionStateDto
    /// </summary>
    [DataContract(Name = "SuspensionStateDto")]
    public partial class SuspensionStateDto : IEquatable<SuspensionStateDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SuspensionStateDto" /> class.
        /// </summary>
        /// <param name="suspended">A Boolean value which indicates whether to activate or suspend a given process instance. When the value is set to true, the given process instance will be suspended and when the value is set to false, the given process instance will be activated..</param>
        public SuspensionStateDto(bool suspended = default(bool))
        {
            this.Suspended = suspended;
        }

        /// <summary>
        /// A Boolean value which indicates whether to activate or suspend a given process instance. When the value is set to true, the given process instance will be suspended and when the value is set to false, the given process instance will be activated.
        /// </summary>
        /// <value>A Boolean value which indicates whether to activate or suspend a given process instance. When the value is set to true, the given process instance will be suspended and when the value is set to false, the given process instance will be activated.</value>
        [DataMember(Name = "suspended", EmitDefaultValue = false)]
        public bool Suspended { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SuspensionStateDto {\n");
            sb.Append("  Suspended: ").Append(Suspended).Append("\n");
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
            return this.Equals(input as SuspensionStateDto);
        }

        /// <summary>
        /// Returns true if SuspensionStateDto instances are equal
        /// </summary>
        /// <param name="input">Instance of SuspensionStateDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SuspensionStateDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Suspended == input.Suspended ||
                    this.Suspended.Equals(input.Suspended)
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
                hashCode = hashCode * 59 + this.Suspended.GetHashCode();
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
