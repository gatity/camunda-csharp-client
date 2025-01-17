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
    /// ProcessInstanceSuspensionStateDto
    /// </summary>
    [DataContract(Name = "ProcessInstanceSuspensionStateDto")]
    public partial class ProcessInstanceSuspensionStateDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessInstanceSuspensionStateDto" /> class.
        /// </summary>
        /// <param name="suspended">A Boolean value which indicates whether to activate or suspend a given instance  (e.g. process instance, job, job definition, or batch). When the value is set to true,  the given instance will be suspended and when the value is set to false,  the given instance will be activated..</param>
        /// <param name="processDefinitionId">The process definition id of the process instances to activate or suspend.  **Note**: This parameter can be used only with combination of &#x60;suspended&#x60;..</param>
        /// <param name="processDefinitionKey">The process definition key of the process instances to activate or suspend.  **Note**: This parameter can be used only with combination of &#x60;suspended&#x60;, &#x60;processDefinitionTenantId&#x60;, and &#x60;processDefinitionWithoutTenantId&#x60;..</param>
        /// <param name="processDefinitionTenantId">Only activate or suspend process instances of a process definition which belongs to a tenant with the given id.  **Note**: This parameter can be used only with combination of &#x60;suspended&#x60;, &#x60;processDefinitionKey&#x60;, and &#x60;processDefinitionWithoutTenantId&#x60;..</param>
        /// <param name="processDefinitionWithoutTenantId">Only activate or suspend process instances of a process definition which belongs to no tenant. Value may only be true, as false is the default behavior.  **Note**: This parameter can be used only with combination of &#x60;suspended&#x60;, &#x60;processDefinitionKey&#x60;, and &#x60;processDefinitionTenantId&#x60;..</param>
        /// <param name="processInstanceIds">A list of process instance ids which defines a group of process instances which will be activated or suspended by the operation.  **Note**: This parameter can be used only with combination of &#x60;suspended&#x60;, &#x60;processInstanceQuery&#x60;, and &#x60;historicProcessInstanceQuery&#x60;..</param>
        /// <param name="processInstanceQuery">processInstanceQuery.</param>
        /// <param name="historicProcessInstanceQuery">historicProcessInstanceQuery.</param>
        public ProcessInstanceSuspensionStateDto(bool? suspended = default(bool?), string processDefinitionId = default(string), string processDefinitionKey = default(string), string processDefinitionTenantId = default(string), bool? processDefinitionWithoutTenantId = default(bool?), List<string> processInstanceIds = default(List<string>), ProcessInstanceQueryDto processInstanceQuery = default(ProcessInstanceQueryDto), HistoricProcessInstanceQueryDto historicProcessInstanceQuery = default(HistoricProcessInstanceQueryDto))
        {
            this.Suspended = suspended;
            this.ProcessDefinitionId = processDefinitionId;
            this.ProcessDefinitionKey = processDefinitionKey;
            this.ProcessDefinitionTenantId = processDefinitionTenantId;
            this.ProcessDefinitionWithoutTenantId = processDefinitionWithoutTenantId;
            this.ProcessInstanceIds = processInstanceIds;
            this.ProcessInstanceQuery = processInstanceQuery;
            this.HistoricProcessInstanceQuery = historicProcessInstanceQuery;
        }

        /// <summary>
        /// A Boolean value which indicates whether to activate or suspend a given instance  (e.g. process instance, job, job definition, or batch). When the value is set to true,  the given instance will be suspended and when the value is set to false,  the given instance will be activated.
        /// </summary>
        /// <value>A Boolean value which indicates whether to activate or suspend a given instance  (e.g. process instance, job, job definition, or batch). When the value is set to true,  the given instance will be suspended and when the value is set to false,  the given instance will be activated.</value>
        [DataMember(Name = "suspended", EmitDefaultValue = true)]
        public bool? Suspended { get; set; }

        /// <summary>
        /// The process definition id of the process instances to activate or suspend.  **Note**: This parameter can be used only with combination of &#x60;suspended&#x60;.
        /// </summary>
        /// <value>The process definition id of the process instances to activate or suspend.  **Note**: This parameter can be used only with combination of &#x60;suspended&#x60;.</value>
        [DataMember(Name = "processDefinitionId", EmitDefaultValue = true)]
        public string ProcessDefinitionId { get; set; }

        /// <summary>
        /// The process definition key of the process instances to activate or suspend.  **Note**: This parameter can be used only with combination of &#x60;suspended&#x60;, &#x60;processDefinitionTenantId&#x60;, and &#x60;processDefinitionWithoutTenantId&#x60;.
        /// </summary>
        /// <value>The process definition key of the process instances to activate or suspend.  **Note**: This parameter can be used only with combination of &#x60;suspended&#x60;, &#x60;processDefinitionTenantId&#x60;, and &#x60;processDefinitionWithoutTenantId&#x60;.</value>
        [DataMember(Name = "processDefinitionKey", EmitDefaultValue = true)]
        public string ProcessDefinitionKey { get; set; }

        /// <summary>
        /// Only activate or suspend process instances of a process definition which belongs to a tenant with the given id.  **Note**: This parameter can be used only with combination of &#x60;suspended&#x60;, &#x60;processDefinitionKey&#x60;, and &#x60;processDefinitionWithoutTenantId&#x60;.
        /// </summary>
        /// <value>Only activate or suspend process instances of a process definition which belongs to a tenant with the given id.  **Note**: This parameter can be used only with combination of &#x60;suspended&#x60;, &#x60;processDefinitionKey&#x60;, and &#x60;processDefinitionWithoutTenantId&#x60;.</value>
        [DataMember(Name = "processDefinitionTenantId", EmitDefaultValue = true)]
        public string ProcessDefinitionTenantId { get; set; }

        /// <summary>
        /// Only activate or suspend process instances of a process definition which belongs to no tenant. Value may only be true, as false is the default behavior.  **Note**: This parameter can be used only with combination of &#x60;suspended&#x60;, &#x60;processDefinitionKey&#x60;, and &#x60;processDefinitionTenantId&#x60;.
        /// </summary>
        /// <value>Only activate or suspend process instances of a process definition which belongs to no tenant. Value may only be true, as false is the default behavior.  **Note**: This parameter can be used only with combination of &#x60;suspended&#x60;, &#x60;processDefinitionKey&#x60;, and &#x60;processDefinitionTenantId&#x60;.</value>
        [DataMember(Name = "processDefinitionWithoutTenantId", EmitDefaultValue = true)]
        public bool? ProcessDefinitionWithoutTenantId { get; set; }

        /// <summary>
        /// A list of process instance ids which defines a group of process instances which will be activated or suspended by the operation.  **Note**: This parameter can be used only with combination of &#x60;suspended&#x60;, &#x60;processInstanceQuery&#x60;, and &#x60;historicProcessInstanceQuery&#x60;.
        /// </summary>
        /// <value>A list of process instance ids which defines a group of process instances which will be activated or suspended by the operation.  **Note**: This parameter can be used only with combination of &#x60;suspended&#x60;, &#x60;processInstanceQuery&#x60;, and &#x60;historicProcessInstanceQuery&#x60;.</value>
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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ProcessInstanceSuspensionStateDto {\n");
            sb.Append("  Suspended: ").Append(Suspended).Append("\n");
            sb.Append("  ProcessDefinitionId: ").Append(ProcessDefinitionId).Append("\n");
            sb.Append("  ProcessDefinitionKey: ").Append(ProcessDefinitionKey).Append("\n");
            sb.Append("  ProcessDefinitionTenantId: ").Append(ProcessDefinitionTenantId).Append("\n");
            sb.Append("  ProcessDefinitionWithoutTenantId: ").Append(ProcessDefinitionWithoutTenantId).Append("\n");
            sb.Append("  ProcessInstanceIds: ").Append(ProcessInstanceIds).Append("\n");
            sb.Append("  ProcessInstanceQuery: ").Append(ProcessInstanceQuery).Append("\n");
            sb.Append("  HistoricProcessInstanceQuery: ").Append(HistoricProcessInstanceQuery).Append("\n");
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
