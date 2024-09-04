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
    /// RestartProcessInstanceModificationInstructionDto
    /// </summary>
    [DataContract(Name = "RestartProcessInstanceModificationInstructionDto")]
    public partial class RestartProcessInstanceModificationInstructionDto : IValidatableObject
    {
        /// <summary>
        /// **Mandatory**. One of the following values: &#x60;startBeforeActivity&#x60;, &#x60;startAfterActivity&#x60;, &#x60;startTransition&#x60;.  * A &#x60;startBeforeActivity&#x60; instruction requests to enter a given activity. * A &#x60;startAfterActivity&#x60; instruction requests to execute the single outgoing sequence flow of a given activity. * A &#x60;startTransition&#x60; instruction requests to execute a specific sequence flow.
        /// </summary>
        /// <value>**Mandatory**. One of the following values: &#x60;startBeforeActivity&#x60;, &#x60;startAfterActivity&#x60;, &#x60;startTransition&#x60;.  * A &#x60;startBeforeActivity&#x60; instruction requests to enter a given activity. * A &#x60;startAfterActivity&#x60; instruction requests to execute the single outgoing sequence flow of a given activity. * A &#x60;startTransition&#x60; instruction requests to execute a specific sequence flow.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum StartBeforeActivity for value: startBeforeActivity
            /// </summary>
            [EnumMember(Value = "startBeforeActivity")]
            StartBeforeActivity = 1,

            /// <summary>
            /// Enum StartAfterActivity for value: startAfterActivity
            /// </summary>
            [EnumMember(Value = "startAfterActivity")]
            StartAfterActivity = 2,

            /// <summary>
            /// Enum StartTransition for value: startTransition
            /// </summary>
            [EnumMember(Value = "startTransition")]
            StartTransition = 3
        }


        /// <summary>
        /// **Mandatory**. One of the following values: &#x60;startBeforeActivity&#x60;, &#x60;startAfterActivity&#x60;, &#x60;startTransition&#x60;.  * A &#x60;startBeforeActivity&#x60; instruction requests to enter a given activity. * A &#x60;startAfterActivity&#x60; instruction requests to execute the single outgoing sequence flow of a given activity. * A &#x60;startTransition&#x60; instruction requests to execute a specific sequence flow.
        /// </summary>
        /// <value>**Mandatory**. One of the following values: &#x60;startBeforeActivity&#x60;, &#x60;startAfterActivity&#x60;, &#x60;startTransition&#x60;.  * A &#x60;startBeforeActivity&#x60; instruction requests to enter a given activity. * A &#x60;startAfterActivity&#x60; instruction requests to execute the single outgoing sequence flow of a given activity. * A &#x60;startTransition&#x60; instruction requests to execute a specific sequence flow.</value>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RestartProcessInstanceModificationInstructionDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RestartProcessInstanceModificationInstructionDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RestartProcessInstanceModificationInstructionDto" /> class.
        /// </summary>
        /// <param name="type">**Mandatory**. One of the following values: &#x60;startBeforeActivity&#x60;, &#x60;startAfterActivity&#x60;, &#x60;startTransition&#x60;.  * A &#x60;startBeforeActivity&#x60; instruction requests to enter a given activity. * A &#x60;startAfterActivity&#x60; instruction requests to execute the single outgoing sequence flow of a given activity. * A &#x60;startTransition&#x60; instruction requests to execute a specific sequence flow. (required).</param>
        /// <param name="activityId">**Can be used with instructions of types** &#x60;startBeforeActivity&#x60; and &#x60;startAfterActivity&#x60;. Specifies the sequence flow to start..</param>
        /// <param name="transitionId">**Can be used with instructions of types** &#x60;startTransition&#x60;. Specifies the sequence flow to start..</param>
        public RestartProcessInstanceModificationInstructionDto(TypeEnum type = default(TypeEnum), string activityId = default(string), string transitionId = default(string))
        {
            this.Type = type;
            this.ActivityId = activityId;
            this.TransitionId = transitionId;
        }

        /// <summary>
        /// **Can be used with instructions of types** &#x60;startBeforeActivity&#x60; and &#x60;startAfterActivity&#x60;. Specifies the sequence flow to start.
        /// </summary>
        /// <value>**Can be used with instructions of types** &#x60;startBeforeActivity&#x60; and &#x60;startAfterActivity&#x60;. Specifies the sequence flow to start.</value>
        [DataMember(Name = "activityId", EmitDefaultValue = true)]
        public string ActivityId { get; set; }

        /// <summary>
        /// **Can be used with instructions of types** &#x60;startTransition&#x60;. Specifies the sequence flow to start.
        /// </summary>
        /// <value>**Can be used with instructions of types** &#x60;startTransition&#x60;. Specifies the sequence flow to start.</value>
        [DataMember(Name = "transitionId", EmitDefaultValue = true)]
        public string TransitionId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RestartProcessInstanceModificationInstructionDto {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ActivityId: ").Append(ActivityId).Append("\n");
            sb.Append("  TransitionId: ").Append(TransitionId).Append("\n");
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
