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
    /// AuthorizationExceptionDto
    /// </summary>
    [DataContract(Name = "AuthorizationExceptionDto")]
    public partial class AuthorizationExceptionDto : IEquatable<AuthorizationExceptionDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorizationExceptionDto" /> class.
        /// </summary>
        /// <param name="userId">The id of the user that does not have expected permissions.</param>
        /// <param name="missingAuthorizations">missingAuthorizations.</param>
        /// <param name="type">An exception class indicating the occurred error..</param>
        /// <param name="message">A detailed message of the error..</param>
        public AuthorizationExceptionDto(string userId = default(string), List<MissingAuthorizationDto> missingAuthorizations = default(List<MissingAuthorizationDto>), string type = default(string), string message = default(string))
        {
            this.UserId = userId;
            this.MissingAuthorizations = missingAuthorizations;
            this.Type = type;
            this.Message = message;
        }

        /// <summary>
        /// The id of the user that does not have expected permissions
        /// </summary>
        /// <value>The id of the user that does not have expected permissions</value>
        [DataMember(Name = "userId", EmitDefaultValue = true)]
        public string UserId { get; set; }

        /// <summary>
        /// Gets or Sets MissingAuthorizations
        /// </summary>
        [DataMember(Name = "missingAuthorizations", EmitDefaultValue = true)]
        public List<MissingAuthorizationDto> MissingAuthorizations { get; set; }

        /// <summary>
        /// An exception class indicating the occurred error.
        /// </summary>
        /// <value>An exception class indicating the occurred error.</value>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// A detailed message of the error.
        /// </summary>
        /// <value>A detailed message of the error.</value>
        [DataMember(Name = "message", EmitDefaultValue = true)]
        public string Message { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuthorizationExceptionDto {\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  MissingAuthorizations: ").Append(MissingAuthorizations).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
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
            return this.Equals(input as AuthorizationExceptionDto);
        }

        /// <summary>
        /// Returns true if AuthorizationExceptionDto instances are equal
        /// </summary>
        /// <param name="input">Instance of AuthorizationExceptionDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuthorizationExceptionDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.MissingAuthorizations == input.MissingAuthorizations ||
                    this.MissingAuthorizations != null &&
                    input.MissingAuthorizations != null &&
                    this.MissingAuthorizations.SequenceEqual(input.MissingAuthorizations)
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
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
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.MissingAuthorizations != null)
                    hashCode = hashCode * 59 + this.MissingAuthorizations.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
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
