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
    /// AtomLink
    /// </summary>
    [DataContract(Name = "AtomLink")]
    public partial class AtomLink : IEquatable<AtomLink>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AtomLink" /> class.
        /// </summary>
        /// <param name="rel">The relation of the link to the object that belongs to..</param>
        /// <param name="href">The url of the link..</param>
        /// <param name="method">The http method..</param>
        public AtomLink(string rel = default(string), string href = default(string), string method = default(string))
        {
            this.Rel = rel;
            this.Href = href;
            this.Method = method;
        }

        /// <summary>
        /// The relation of the link to the object that belongs to.
        /// </summary>
        /// <value>The relation of the link to the object that belongs to.</value>
        [DataMember(Name = "rel", EmitDefaultValue = true)]
        public string Rel { get; set; }

        /// <summary>
        /// The url of the link.
        /// </summary>
        /// <value>The url of the link.</value>
        [DataMember(Name = "href", EmitDefaultValue = true)]
        public string Href { get; set; }

        /// <summary>
        /// The http method.
        /// </summary>
        /// <value>The http method.</value>
        [DataMember(Name = "method", EmitDefaultValue = true)]
        public string Method { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AtomLink {\n");
            sb.Append("  Rel: ").Append(Rel).Append("\n");
            sb.Append("  Href: ").Append(Href).Append("\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
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
            return this.Equals(input as AtomLink);
        }

        /// <summary>
        /// Returns true if AtomLink instances are equal
        /// </summary>
        /// <param name="input">Instance of AtomLink to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AtomLink input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Rel == input.Rel ||
                    (this.Rel != null &&
                    this.Rel.Equals(input.Rel))
                ) && 
                (
                    this.Href == input.Href ||
                    (this.Href != null &&
                    this.Href.Equals(input.Href))
                ) && 
                (
                    this.Method == input.Method ||
                    (this.Method != null &&
                    this.Method.Equals(input.Method))
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
                if (this.Rel != null)
                    hashCode = hashCode * 59 + this.Rel.GetHashCode();
                if (this.Href != null)
                    hashCode = hashCode * 59 + this.Href.GetHashCode();
                if (this.Method != null)
                    hashCode = hashCode * 59 + this.Method.GetHashCode();
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
