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
    /// CreateFilterDto
    /// </summary>
    [DataContract(Name = "CreateFilterDto")]
    public partial class CreateFilterDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFilterDto" /> class.
        /// </summary>
        /// <param name="resourceType">The resource type of the filter..</param>
        /// <param name="name">The name of the filter..</param>
        /// <param name="owner">The user id of the owner of the filter..</param>
        /// <param name="query">The query of the filter as a JSON object..</param>
        /// <param name="properties">The properties of a filter as a JSON object..</param>
        public CreateFilterDto(string resourceType = default(string), string name = default(string), string owner = default(string), Object query = default(Object), Object properties = default(Object))
        {
            this.ResourceType = resourceType;
            this.Name = name;
            this.Owner = owner;
            this.Query = query;
            this.Properties = properties;
        }

        /// <summary>
        /// The resource type of the filter.
        /// </summary>
        /// <value>The resource type of the filter.</value>
        [DataMember(Name = "resourceType", EmitDefaultValue = true)]
        public string ResourceType { get; set; }

        /// <summary>
        /// The name of the filter.
        /// </summary>
        /// <value>The name of the filter.</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The user id of the owner of the filter.
        /// </summary>
        /// <value>The user id of the owner of the filter.</value>
        [DataMember(Name = "owner", EmitDefaultValue = true)]
        public string Owner { get; set; }

        /// <summary>
        /// The query of the filter as a JSON object.
        /// </summary>
        /// <value>The query of the filter as a JSON object.</value>
        [DataMember(Name = "query", EmitDefaultValue = false)]
        public Object Query { get; set; }

        /// <summary>
        /// The properties of a filter as a JSON object.
        /// </summary>
        /// <value>The properties of a filter as a JSON object.</value>
        [DataMember(Name = "properties", EmitDefaultValue = false)]
        public Object Properties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateFilterDto {\n");
            sb.Append("  ResourceType: ").Append(ResourceType).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  Query: ").Append(Query).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
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
