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
    /// AuthorizationCheckResultDto
    /// </summary>
    [DataContract(Name = "AuthorizationCheckResultDto")]
    public partial class AuthorizationCheckResultDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorizationCheckResultDto" /> class.
        /// </summary>
        /// <param name="permissionName">Name of the permission which was checked..</param>
        /// <param name="resourceName">The name of the resource for which the permission check was performed..</param>
        /// <param name="resourceId">The id of the resource for which the permission check was performed..</param>
        /// <param name="authorized">Returns true or false depending on whether the user is authorized or not..</param>
        public AuthorizationCheckResultDto(string permissionName = default(string), string resourceName = default(string), string resourceId = default(string), bool? authorized = default(bool?))
        {
            this.PermissionName = permissionName;
            this.ResourceName = resourceName;
            this.ResourceId = resourceId;
            this.Authorized = authorized;
        }

        /// <summary>
        /// Name of the permission which was checked.
        /// </summary>
        /// <value>Name of the permission which was checked.</value>
        [DataMember(Name = "permissionName", EmitDefaultValue = true)]
        public string PermissionName { get; set; }

        /// <summary>
        /// The name of the resource for which the permission check was performed.
        /// </summary>
        /// <value>The name of the resource for which the permission check was performed.</value>
        [DataMember(Name = "resourceName", EmitDefaultValue = true)]
        public string ResourceName { get; set; }

        /// <summary>
        /// The id of the resource for which the permission check was performed.
        /// </summary>
        /// <value>The id of the resource for which the permission check was performed.</value>
        [DataMember(Name = "resourceId", EmitDefaultValue = true)]
        public string ResourceId { get; set; }

        /// <summary>
        /// Returns true or false depending on whether the user is authorized or not.
        /// </summary>
        /// <value>Returns true or false depending on whether the user is authorized or not.</value>
        [DataMember(Name = "authorized", EmitDefaultValue = true)]
        public bool? Authorized { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AuthorizationCheckResultDto {\n");
            sb.Append("  PermissionName: ").Append(PermissionName).Append("\n");
            sb.Append("  ResourceName: ").Append(ResourceName).Append("\n");
            sb.Append("  ResourceId: ").Append(ResourceId).Append("\n");
            sb.Append("  Authorized: ").Append(Authorized).Append("\n");
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
