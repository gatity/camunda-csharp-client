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
    /// UserCredentialsDto
    /// </summary>
    [DataContract(Name = "UserCredentialsDto")]
    public partial class UserCredentialsDto : IEquatable<UserCredentialsDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserCredentialsDto" /> class.
        /// </summary>
        /// <param name="password">The users new password..</param>
        /// <param name="authenticatedUserPassword">The password of the authenticated user who changes the password of the user (i.e., the user with passed id as path parameter)..</param>
        public UserCredentialsDto(string password = default(string), string authenticatedUserPassword = default(string))
        {
            this.Password = password;
            this.AuthenticatedUserPassword = authenticatedUserPassword;
        }

        /// <summary>
        /// The users new password.
        /// </summary>
        /// <value>The users new password.</value>
        [DataMember(Name = "password", EmitDefaultValue = false)]
        public string Password { get; set; }

        /// <summary>
        /// The password of the authenticated user who changes the password of the user (i.e., the user with passed id as path parameter).
        /// </summary>
        /// <value>The password of the authenticated user who changes the password of the user (i.e., the user with passed id as path parameter).</value>
        [DataMember(Name = "authenticatedUserPassword", EmitDefaultValue = false)]
        public string AuthenticatedUserPassword { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserCredentialsDto {\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  AuthenticatedUserPassword: ").Append(AuthenticatedUserPassword).Append("\n");
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
            return this.Equals(input as UserCredentialsDto);
        }

        /// <summary>
        /// Returns true if UserCredentialsDto instances are equal
        /// </summary>
        /// <param name="input">Instance of UserCredentialsDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserCredentialsDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.AuthenticatedUserPassword == input.AuthenticatedUserPassword ||
                    (this.AuthenticatedUserPassword != null &&
                    this.AuthenticatedUserPassword.Equals(input.AuthenticatedUserPassword))
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
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.AuthenticatedUserPassword != null)
                    hashCode = hashCode * 59 + this.AuthenticatedUserPassword.GetHashCode();
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
