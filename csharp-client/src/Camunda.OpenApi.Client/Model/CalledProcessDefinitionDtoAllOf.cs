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
    /// CalledProcessDefinitionDtoAllOf
    /// </summary>
    [DataContract(Name = "CalledProcessDefinitionDto_allOf")]
    public partial class CalledProcessDefinitionDtoAllOf : IEquatable<CalledProcessDefinitionDtoAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CalledProcessDefinitionDtoAllOf" /> class.
        /// </summary>
        /// <param name="calledFromActivityIds">Ids of the CallActivities which call this process..</param>
        /// <param name="callingProcessDefinitionId">The id of the calling process definition.</param>
        public CalledProcessDefinitionDtoAllOf(List<string> calledFromActivityIds = default(List<string>), string callingProcessDefinitionId = default(string))
        {
            this.CalledFromActivityIds = calledFromActivityIds;
            this.CallingProcessDefinitionId = callingProcessDefinitionId;
        }

        /// <summary>
        /// Ids of the CallActivities which call this process.
        /// </summary>
        /// <value>Ids of the CallActivities which call this process.</value>
        [DataMember(Name = "calledFromActivityIds", EmitDefaultValue = true)]
        public List<string> CalledFromActivityIds { get; set; }

        /// <summary>
        /// The id of the calling process definition
        /// </summary>
        /// <value>The id of the calling process definition</value>
        [DataMember(Name = "callingProcessDefinitionId", EmitDefaultValue = true)]
        public string CallingProcessDefinitionId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CalledProcessDefinitionDtoAllOf {\n");
            sb.Append("  CalledFromActivityIds: ").Append(CalledFromActivityIds).Append("\n");
            sb.Append("  CallingProcessDefinitionId: ").Append(CallingProcessDefinitionId).Append("\n");
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
            return this.Equals(input as CalledProcessDefinitionDtoAllOf);
        }

        /// <summary>
        /// Returns true if CalledProcessDefinitionDtoAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of CalledProcessDefinitionDtoAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CalledProcessDefinitionDtoAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CalledFromActivityIds == input.CalledFromActivityIds ||
                    this.CalledFromActivityIds != null &&
                    input.CalledFromActivityIds != null &&
                    this.CalledFromActivityIds.SequenceEqual(input.CalledFromActivityIds)
                ) && 
                (
                    this.CallingProcessDefinitionId == input.CallingProcessDefinitionId ||
                    (this.CallingProcessDefinitionId != null &&
                    this.CallingProcessDefinitionId.Equals(input.CallingProcessDefinitionId))
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
                if (this.CalledFromActivityIds != null)
                    hashCode = hashCode * 59 + this.CalledFromActivityIds.GetHashCode();
                if (this.CallingProcessDefinitionId != null)
                    hashCode = hashCode * 59 + this.CallingProcessDefinitionId.GetHashCode();
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
