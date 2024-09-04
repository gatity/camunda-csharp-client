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
    /// CorrelationMessageAsyncDto
    /// </summary>
    [DataContract(Name = "CorrelationMessageAsyncDto")]
    public partial class CorrelationMessageAsyncDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CorrelationMessageAsyncDto" /> class.
        /// </summary>
        /// <param name="messageName">The name of the message to correlate. Corresponds to the &#39;name&#39; element of the message defined in BPMN 2.0 XML. Can be null to correlate by other criteria only..</param>
        /// <param name="processInstanceIds">A list of process instance ids that define a group of process instances to which the operation will correlate a message.  Please note that if &#x60;processInstanceIds&#x60;, &#x60;processInstanceQuery&#x60; and &#x60;historicProcessInstanceQuery&#x60; are defined, the resulting operation will be performed on the union of these sets..</param>
        /// <param name="processInstanceQuery">processInstanceQuery.</param>
        /// <param name="historicProcessInstanceQuery">historicProcessInstanceQuery.</param>
        /// <param name="variables">All variables the operation will set in the root scope of the process instances the message is correlated to..</param>
        public CorrelationMessageAsyncDto(string messageName = default(string), List<string> processInstanceIds = default(List<string>), ProcessInstanceQueryDto processInstanceQuery = default(ProcessInstanceQueryDto), HistoricProcessInstanceQueryDto historicProcessInstanceQuery = default(HistoricProcessInstanceQueryDto), Dictionary<string, VariableValueDto> variables = default(Dictionary<string, VariableValueDto>))
        {
            this.MessageName = messageName;
            this.ProcessInstanceIds = processInstanceIds;
            this.ProcessInstanceQuery = processInstanceQuery;
            this.HistoricProcessInstanceQuery = historicProcessInstanceQuery;
            this.Variables = variables;
        }

        /// <summary>
        /// The name of the message to correlate. Corresponds to the &#39;name&#39; element of the message defined in BPMN 2.0 XML. Can be null to correlate by other criteria only.
        /// </summary>
        /// <value>The name of the message to correlate. Corresponds to the &#39;name&#39; element of the message defined in BPMN 2.0 XML. Can be null to correlate by other criteria only.</value>
        [DataMember(Name = "messageName", EmitDefaultValue = true)]
        public string MessageName { get; set; }

        /// <summary>
        /// A list of process instance ids that define a group of process instances to which the operation will correlate a message.  Please note that if &#x60;processInstanceIds&#x60;, &#x60;processInstanceQuery&#x60; and &#x60;historicProcessInstanceQuery&#x60; are defined, the resulting operation will be performed on the union of these sets.
        /// </summary>
        /// <value>A list of process instance ids that define a group of process instances to which the operation will correlate a message.  Please note that if &#x60;processInstanceIds&#x60;, &#x60;processInstanceQuery&#x60; and &#x60;historicProcessInstanceQuery&#x60; are defined, the resulting operation will be performed on the union of these sets.</value>
        [DataMember(Name = "processInstanceIds", EmitDefaultValue = true)]
        public List<string> ProcessInstanceIds { get; set; }

        /// <summary>
        /// Gets or Sets ProcessInstanceQuery
        /// </summary>
        [DataMember(Name = "processInstanceQuery", EmitDefaultValue = false)]
        public ProcessInstanceQueryDto ProcessInstanceQuery { get; set; }

        /// <summary>
        /// Gets or Sets HistoricProcessInstanceQuery
        /// </summary>
        [DataMember(Name = "historicProcessInstanceQuery", EmitDefaultValue = false)]
        public HistoricProcessInstanceQueryDto HistoricProcessInstanceQuery { get; set; }

        /// <summary>
        /// All variables the operation will set in the root scope of the process instances the message is correlated to.
        /// </summary>
        /// <value>All variables the operation will set in the root scope of the process instances the message is correlated to.</value>
        [DataMember(Name = "variables", EmitDefaultValue = true)]
        public Dictionary<string, VariableValueDto> Variables { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CorrelationMessageAsyncDto {\n");
            sb.Append("  MessageName: ").Append(MessageName).Append("\n");
            sb.Append("  ProcessInstanceIds: ").Append(ProcessInstanceIds).Append("\n");
            sb.Append("  ProcessInstanceQuery: ").Append(ProcessInstanceQuery).Append("\n");
            sb.Append("  HistoricProcessInstanceQuery: ").Append(HistoricProcessInstanceQuery).Append("\n");
            sb.Append("  Variables: ").Append(Variables).Append("\n");
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
