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
    /// ProcessDefinitionDiagramDto
    /// </summary>
    [DataContract(Name = "ProcessDefinitionDiagramDto")]
    public partial class ProcessDefinitionDiagramDto : IEquatable<ProcessDefinitionDiagramDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessDefinitionDiagramDto" /> class.
        /// </summary>
        /// <param name="id">The id of the process definition..</param>
        /// <param name="bpmn20Xml">An escaped XML string containing the XML that this definition was deployed with. Carriage returns, line feeds and quotation marks are escaped..</param>
        public ProcessDefinitionDiagramDto(string id = default(string), string bpmn20Xml = default(string))
        {
            this.Id = id;
            this.Bpmn20Xml = bpmn20Xml;
        }

        /// <summary>
        /// The id of the process definition.
        /// </summary>
        /// <value>The id of the process definition.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// An escaped XML string containing the XML that this definition was deployed with. Carriage returns, line feeds and quotation marks are escaped.
        /// </summary>
        /// <value>An escaped XML string containing the XML that this definition was deployed with. Carriage returns, line feeds and quotation marks are escaped.</value>
        [DataMember(Name = "bpmn20Xml", EmitDefaultValue = false)]
        public string Bpmn20Xml { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProcessDefinitionDiagramDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Bpmn20Xml: ").Append(Bpmn20Xml).Append("\n");
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
            return this.Equals(input as ProcessDefinitionDiagramDto);
        }

        /// <summary>
        /// Returns true if ProcessDefinitionDiagramDto instances are equal
        /// </summary>
        /// <param name="input">Instance of ProcessDefinitionDiagramDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProcessDefinitionDiagramDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Bpmn20Xml == input.Bpmn20Xml ||
                    (this.Bpmn20Xml != null &&
                    this.Bpmn20Xml.Equals(input.Bpmn20Xml))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Bpmn20Xml != null)
                    hashCode = hashCode * 59 + this.Bpmn20Xml.GetHashCode();
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
