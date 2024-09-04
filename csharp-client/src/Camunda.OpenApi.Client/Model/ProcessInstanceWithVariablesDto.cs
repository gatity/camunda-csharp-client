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
    /// ProcessInstanceWithVariablesDto
    /// </summary>
    [DataContract(Name = "ProcessInstanceWithVariablesDto")]
    public partial class ProcessInstanceWithVariablesDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessInstanceWithVariablesDto" /> class.
        /// </summary>
        /// <param name="id">The id of the process instance..</param>
        /// <param name="definitionId">The id of the process definition that this process instance belongs to..</param>
        /// <param name="businessKey">The business key of the process instance..</param>
        /// <param name="caseInstanceId">The id of the case instance associated with the process instance..</param>
        /// <param name="ended">A flag indicating whether the process instance has ended or not. Deprecated: will always be false!.</param>
        /// <param name="suspended">A flag indicating whether the process instance is suspended or not..</param>
        /// <param name="tenantId">The tenant id of the process instance..</param>
        /// <param name="links">The links associated to this resource, with &#x60;method&#x60;, &#x60;href&#x60; and &#x60;rel&#x60;..</param>
        /// <param name="variables">The id of the process instance..</param>
        public ProcessInstanceWithVariablesDto(string id = default(string), string definitionId = default(string), string businessKey = default(string), string caseInstanceId = default(string), bool? ended = default(bool?), bool? suspended = default(bool?), string tenantId = default(string), List<AtomLink> links = default(List<AtomLink>), Dictionary<string, VariableValueDto> variables = default(Dictionary<string, VariableValueDto>))
        {
            this.Id = id;
            this.DefinitionId = definitionId;
            this.BusinessKey = businessKey;
            this.CaseInstanceId = caseInstanceId;
            this.Ended = ended;
            this.Suspended = suspended;
            this.TenantId = tenantId;
            this.Links = links;
            this.Variables = variables;
        }

        /// <summary>
        /// The id of the process instance.
        /// </summary>
        /// <value>The id of the process instance.</value>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// The id of the process definition that this process instance belongs to.
        /// </summary>
        /// <value>The id of the process definition that this process instance belongs to.</value>
        [DataMember(Name = "definitionId", EmitDefaultValue = true)]
        public string DefinitionId { get; set; }

        /// <summary>
        /// The business key of the process instance.
        /// </summary>
        /// <value>The business key of the process instance.</value>
        [DataMember(Name = "businessKey", EmitDefaultValue = true)]
        public string BusinessKey { get; set; }

        /// <summary>
        /// The id of the case instance associated with the process instance.
        /// </summary>
        /// <value>The id of the case instance associated with the process instance.</value>
        [DataMember(Name = "caseInstanceId", EmitDefaultValue = true)]
        public string CaseInstanceId { get; set; }

        /// <summary>
        /// A flag indicating whether the process instance has ended or not. Deprecated: will always be false!
        /// </summary>
        /// <value>A flag indicating whether the process instance has ended or not. Deprecated: will always be false!</value>
        [DataMember(Name = "ended", EmitDefaultValue = true)]
        [Obsolete]
        public bool? Ended { get; set; }

        /// <summary>
        /// A flag indicating whether the process instance is suspended or not.
        /// </summary>
        /// <value>A flag indicating whether the process instance is suspended or not.</value>
        [DataMember(Name = "suspended", EmitDefaultValue = true)]
        public bool? Suspended { get; set; }

        /// <summary>
        /// The tenant id of the process instance.
        /// </summary>
        /// <value>The tenant id of the process instance.</value>
        [DataMember(Name = "tenantId", EmitDefaultValue = true)]
        public string TenantId { get; set; }

        /// <summary>
        /// The links associated to this resource, with &#x60;method&#x60;, &#x60;href&#x60; and &#x60;rel&#x60;.
        /// </summary>
        /// <value>The links associated to this resource, with &#x60;method&#x60;, &#x60;href&#x60; and &#x60;rel&#x60;.</value>
        [DataMember(Name = "links", EmitDefaultValue = true)]
        public List<AtomLink> Links { get; set; }

        /// <summary>
        /// The id of the process instance.
        /// </summary>
        /// <value>The id of the process instance.</value>
        [DataMember(Name = "variables", EmitDefaultValue = true)]
        public Dictionary<string, VariableValueDto> Variables { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ProcessInstanceWithVariablesDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DefinitionId: ").Append(DefinitionId).Append("\n");
            sb.Append("  BusinessKey: ").Append(BusinessKey).Append("\n");
            sb.Append("  CaseInstanceId: ").Append(CaseInstanceId).Append("\n");
            sb.Append("  Ended: ").Append(Ended).Append("\n");
            sb.Append("  Suspended: ").Append(Suspended).Append("\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
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
