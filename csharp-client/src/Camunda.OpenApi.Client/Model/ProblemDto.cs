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
    /// ProblemDto
    /// </summary>
    [DataContract(Name = "ProblemDto")]
    public partial class ProblemDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProblemDto" /> class.
        /// </summary>
        /// <param name="message">The message of the problem..</param>
        /// <param name="line">The line where the problem occurred..</param>
        /// <param name="column">The column where the problem occurred..</param>
        /// <param name="mainElementId">The main element id where the problem occurred..</param>
        /// <param name="elementIds">A list of element id affected by the problem..</param>
        public ProblemDto(string message = default(string), int? line = default(int?), int? column = default(int?), string mainElementId = default(string), List<string> elementIds = default(List<string>))
        {
            this.Message = message;
            this.Line = line;
            this.Column = column;
            this.MainElementId = mainElementId;
            this.ElementIds = elementIds;
        }

        /// <summary>
        /// The message of the problem.
        /// </summary>
        /// <value>The message of the problem.</value>
        [DataMember(Name = "message", EmitDefaultValue = true)]
        public string Message { get; set; }

        /// <summary>
        /// The line where the problem occurred.
        /// </summary>
        /// <value>The line where the problem occurred.</value>
        [DataMember(Name = "line", EmitDefaultValue = true)]
        public int? Line { get; set; }

        /// <summary>
        /// The column where the problem occurred.
        /// </summary>
        /// <value>The column where the problem occurred.</value>
        [DataMember(Name = "column", EmitDefaultValue = true)]
        public int? Column { get; set; }

        /// <summary>
        /// The main element id where the problem occurred.
        /// </summary>
        /// <value>The main element id where the problem occurred.</value>
        [DataMember(Name = "mainElementId", EmitDefaultValue = true)]
        public string MainElementId { get; set; }

        /// <summary>
        /// A list of element id affected by the problem.
        /// </summary>
        /// <value>A list of element id affected by the problem.</value>
        [DataMember(Name = "elementIds", EmitDefaultValue = true)]
        public List<string> ElementIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ProblemDto {\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Line: ").Append(Line).Append("\n");
            sb.Append("  Column: ").Append(Column).Append("\n");
            sb.Append("  MainElementId: ").Append(MainElementId).Append("\n");
            sb.Append("  ElementIds: ").Append(ElementIds).Append("\n");
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
