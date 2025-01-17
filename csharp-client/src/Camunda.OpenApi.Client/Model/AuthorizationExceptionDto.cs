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
    /// AuthorizationExceptionDto
    /// </summary>
    [DataContract(Name = "AuthorizationExceptionDto")]
    public partial class AuthorizationExceptionDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorizationExceptionDto" /> class.
        /// </summary>
        /// <param name="type">An exception class indicating the occurred error..</param>
        /// <param name="message">A detailed message of the error..</param>
        /// <param name="code">The code allows your client application to identify the error in an automated fashion. You can look up the meaning of all built-in codes and learn how to add custom codes in the [User Guide](https://docs.camunda.org/manual/7.21/user-guide/process-engine/error-handling/#exception-codes)..</param>
        /// <param name="userId">The id of the user that does not have expected permissions.</param>
        /// <param name="missingAuthorizations">missingAuthorizations.</param>
        public AuthorizationExceptionDto(string type = default(string), string message = default(string), decimal code = default(decimal), string userId = default(string), List<MissingAuthorizationDto> missingAuthorizations = default(List<MissingAuthorizationDto>))
        {
            this.Type = type;
            this.Message = message;
            this.Code = code;
            this.UserId = userId;
            this.MissingAuthorizations = missingAuthorizations;
        }

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
        /// The code allows your client application to identify the error in an automated fashion. You can look up the meaning of all built-in codes and learn how to add custom codes in the [User Guide](https://docs.camunda.org/manual/7.21/user-guide/process-engine/error-handling/#exception-codes).
        /// </summary>
        /// <value>The code allows your client application to identify the error in an automated fashion. You can look up the meaning of all built-in codes and learn how to add custom codes in the [User Guide](https://docs.camunda.org/manual/7.21/user-guide/process-engine/error-handling/#exception-codes).</value>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public decimal Code { get; set; }

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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AuthorizationExceptionDto {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  MissingAuthorizations: ").Append(MissingAuthorizations).Append("\n");
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
