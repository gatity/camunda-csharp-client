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
using OpenAPIDateConverter = Camunda.OpenApi.Client.Client.OpenAPIDateConverter;

namespace Camunda.OpenApi.Client.Model
{
    /// <summary>
    /// FetchExternalTaskTopicDto
    /// </summary>
    [DataContract(Name = "FetchExternalTaskTopicDto")]
    public partial class FetchExternalTaskTopicDto : IEquatable<FetchExternalTaskTopicDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FetchExternalTaskTopicDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FetchExternalTaskTopicDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FetchExternalTaskTopicDto" /> class.
        /// </summary>
        /// <param name="topicName">**Mandatory.** The topic&#39;s name. (required).</param>
        /// <param name="lockDuration">**Mandatory.** The duration to lock the external tasks for in milliseconds. (required).</param>
        /// <param name="variables">A JSON array of &#x60;String&#x60; values that represent variable names. For each result task belonging to this topic, the given variables are returned as well if they are accessible from the external task&#39;s execution. If not provided - all variables will be fetched..</param>
        /// <param name="localVariables">If &#x60;true&#x60; only local variables will be fetched. (default to false).</param>
        /// <param name="businessKey">A &#x60;String&#x60; value which enables the filtering of tasks based on process instance business key..</param>
        /// <param name="processDefinitionId">Filter tasks based on process definition id..</param>
        /// <param name="processDefinitionIdIn">Filter tasks based on process definition ids..</param>
        /// <param name="processDefinitionKey">Filter tasks based on process definition key..</param>
        /// <param name="processDefinitionKeyIn">Filter tasks based on process definition keys..</param>
        /// <param name="processDefinitionVersionTag">Filter tasks based on process definition version tag..</param>
        /// <param name="withoutTenantId">Filter tasks without tenant id. (default to false).</param>
        /// <param name="tenantIdIn">Filter tasks based on tenant ids..</param>
        /// <param name="processVariables">A &#x60;JSON&#x60; object used for filtering tasks based on process instance variable values. A property name of the object represents a process variable name, while the property value represents the process variable value to filter tasks by..</param>
        /// <param name="deserializeValues">Determines whether serializable variable values (typically variables that store custom Java objects) should be deserialized on server side (default &#x60;false&#x60;).  If set to &#x60;true&#x60;, a serializable variable will be deserialized on server side and transformed to JSON using [Jackson&#39;s](https://github.com/FasterXML/jackson) POJO/bean property introspection feature. Note that this requires the Java classes of the variable value to be on the REST API&#39;s classpath.  If set to &#x60;false&#x60;, a serializable variable will be returned in its serialized format. For example, a variable that is serialized as XML will be returned as a JSON string containing XML. (default to false).</param>
        /// <param name="includeExtensionProperties">Determines whether custom extension properties defined in the BPMN activity of the external task (e.g. via the Extensions tab in the Camunda modeler) should be included in the response. Default: false (default to false).</param>
        public FetchExternalTaskTopicDto(string topicName = default(string), long? lockDuration = default(long?), List<string> variables = default(List<string>), bool? localVariables = false, string businessKey = default(string), string processDefinitionId = default(string), List<string> processDefinitionIdIn = default(List<string>), string processDefinitionKey = default(string), List<string> processDefinitionKeyIn = default(List<string>), string processDefinitionVersionTag = default(string), bool? withoutTenantId = false, List<string> tenantIdIn = default(List<string>), Dictionary<string, Object> processVariables = default(Dictionary<string, Object>), bool? deserializeValues = false, bool? includeExtensionProperties = false)
        {
            // to ensure "topicName" is required (not null)
            this.TopicName = topicName ?? throw new ArgumentNullException("topicName is a required property for FetchExternalTaskTopicDto and cannot be null");
            // to ensure "lockDuration" is required (not null)
            this.LockDuration = lockDuration ?? throw new ArgumentNullException("lockDuration is a required property for FetchExternalTaskTopicDto and cannot be null");
            this.Variables = variables;
            // use default value if no "localVariables" provided
            this.LocalVariables = localVariables ?? false;
            this.BusinessKey = businessKey;
            this.ProcessDefinitionId = processDefinitionId;
            this.ProcessDefinitionIdIn = processDefinitionIdIn;
            this.ProcessDefinitionKey = processDefinitionKey;
            this.ProcessDefinitionKeyIn = processDefinitionKeyIn;
            this.ProcessDefinitionVersionTag = processDefinitionVersionTag;
            // use default value if no "withoutTenantId" provided
            this.WithoutTenantId = withoutTenantId ?? false;
            this.TenantIdIn = tenantIdIn;
            this.ProcessVariables = processVariables;
            // use default value if no "deserializeValues" provided
            this.DeserializeValues = deserializeValues ?? false;
            // use default value if no "includeExtensionProperties" provided
            this.IncludeExtensionProperties = includeExtensionProperties ?? false;
        }

        /// <summary>
        /// **Mandatory.** The topic&#39;s name.
        /// </summary>
        /// <value>**Mandatory.** The topic&#39;s name.</value>
        [DataMember(Name = "topicName", IsRequired = true, EmitDefaultValue = false)]
        public string TopicName { get; set; }

        /// <summary>
        /// **Mandatory.** The duration to lock the external tasks for in milliseconds.
        /// </summary>
        /// <value>**Mandatory.** The duration to lock the external tasks for in milliseconds.</value>
        [DataMember(Name = "lockDuration", IsRequired = true, EmitDefaultValue = true)]
        public long? LockDuration { get; set; }

        /// <summary>
        /// A JSON array of &#x60;String&#x60; values that represent variable names. For each result task belonging to this topic, the given variables are returned as well if they are accessible from the external task&#39;s execution. If not provided - all variables will be fetched.
        /// </summary>
        /// <value>A JSON array of &#x60;String&#x60; values that represent variable names. For each result task belonging to this topic, the given variables are returned as well if they are accessible from the external task&#39;s execution. If not provided - all variables will be fetched.</value>
        [DataMember(Name = "variables", EmitDefaultValue = true)]
        public List<string> Variables { get; set; }

        /// <summary>
        /// If &#x60;true&#x60; only local variables will be fetched.
        /// </summary>
        /// <value>If &#x60;true&#x60; only local variables will be fetched.</value>
        [DataMember(Name = "localVariables", EmitDefaultValue = true)]
        public bool? LocalVariables { get; set; }

        /// <summary>
        /// A &#x60;String&#x60; value which enables the filtering of tasks based on process instance business key.
        /// </summary>
        /// <value>A &#x60;String&#x60; value which enables the filtering of tasks based on process instance business key.</value>
        [DataMember(Name = "businessKey", EmitDefaultValue = true)]
        public string BusinessKey { get; set; }

        /// <summary>
        /// Filter tasks based on process definition id.
        /// </summary>
        /// <value>Filter tasks based on process definition id.</value>
        [DataMember(Name = "processDefinitionId", EmitDefaultValue = true)]
        public string ProcessDefinitionId { get; set; }

        /// <summary>
        /// Filter tasks based on process definition ids.
        /// </summary>
        /// <value>Filter tasks based on process definition ids.</value>
        [DataMember(Name = "processDefinitionIdIn", EmitDefaultValue = true)]
        public List<string> ProcessDefinitionIdIn { get; set; }

        /// <summary>
        /// Filter tasks based on process definition key.
        /// </summary>
        /// <value>Filter tasks based on process definition key.</value>
        [DataMember(Name = "processDefinitionKey", EmitDefaultValue = true)]
        public string ProcessDefinitionKey { get; set; }

        /// <summary>
        /// Filter tasks based on process definition keys.
        /// </summary>
        /// <value>Filter tasks based on process definition keys.</value>
        [DataMember(Name = "processDefinitionKeyIn", EmitDefaultValue = true)]
        public List<string> ProcessDefinitionKeyIn { get; set; }

        /// <summary>
        /// Filter tasks based on process definition version tag.
        /// </summary>
        /// <value>Filter tasks based on process definition version tag.</value>
        [DataMember(Name = "processDefinitionVersionTag", EmitDefaultValue = true)]
        public string ProcessDefinitionVersionTag { get; set; }

        /// <summary>
        /// Filter tasks without tenant id.
        /// </summary>
        /// <value>Filter tasks without tenant id.</value>
        [DataMember(Name = "withoutTenantId", EmitDefaultValue = true)]
        public bool? WithoutTenantId { get; set; }

        /// <summary>
        /// Filter tasks based on tenant ids.
        /// </summary>
        /// <value>Filter tasks based on tenant ids.</value>
        [DataMember(Name = "tenantIdIn", EmitDefaultValue = true)]
        public List<string> TenantIdIn { get; set; }

        /// <summary>
        /// A &#x60;JSON&#x60; object used for filtering tasks based on process instance variable values. A property name of the object represents a process variable name, while the property value represents the process variable value to filter tasks by.
        /// </summary>
        /// <value>A &#x60;JSON&#x60; object used for filtering tasks based on process instance variable values. A property name of the object represents a process variable name, while the property value represents the process variable value to filter tasks by.</value>
        [DataMember(Name = "processVariables", EmitDefaultValue = false)]
        public Dictionary<string, Object> ProcessVariables { get; set; }

        /// <summary>
        /// Determines whether serializable variable values (typically variables that store custom Java objects) should be deserialized on server side (default &#x60;false&#x60;).  If set to &#x60;true&#x60;, a serializable variable will be deserialized on server side and transformed to JSON using [Jackson&#39;s](https://github.com/FasterXML/jackson) POJO/bean property introspection feature. Note that this requires the Java classes of the variable value to be on the REST API&#39;s classpath.  If set to &#x60;false&#x60;, a serializable variable will be returned in its serialized format. For example, a variable that is serialized as XML will be returned as a JSON string containing XML.
        /// </summary>
        /// <value>Determines whether serializable variable values (typically variables that store custom Java objects) should be deserialized on server side (default &#x60;false&#x60;).  If set to &#x60;true&#x60;, a serializable variable will be deserialized on server side and transformed to JSON using [Jackson&#39;s](https://github.com/FasterXML/jackson) POJO/bean property introspection feature. Note that this requires the Java classes of the variable value to be on the REST API&#39;s classpath.  If set to &#x60;false&#x60;, a serializable variable will be returned in its serialized format. For example, a variable that is serialized as XML will be returned as a JSON string containing XML.</value>
        [DataMember(Name = "deserializeValues", EmitDefaultValue = true)]
        public bool? DeserializeValues { get; set; }

        /// <summary>
        /// Determines whether custom extension properties defined in the BPMN activity of the external task (e.g. via the Extensions tab in the Camunda modeler) should be included in the response. Default: false
        /// </summary>
        /// <value>Determines whether custom extension properties defined in the BPMN activity of the external task (e.g. via the Extensions tab in the Camunda modeler) should be included in the response. Default: false</value>
        [DataMember(Name = "includeExtensionProperties", EmitDefaultValue = true)]
        public bool? IncludeExtensionProperties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FetchExternalTaskTopicDto {\n");
            sb.Append("  TopicName: ").Append(TopicName).Append("\n");
            sb.Append("  LockDuration: ").Append(LockDuration).Append("\n");
            sb.Append("  Variables: ").Append(Variables).Append("\n");
            sb.Append("  LocalVariables: ").Append(LocalVariables).Append("\n");
            sb.Append("  BusinessKey: ").Append(BusinessKey).Append("\n");
            sb.Append("  ProcessDefinitionId: ").Append(ProcessDefinitionId).Append("\n");
            sb.Append("  ProcessDefinitionIdIn: ").Append(ProcessDefinitionIdIn).Append("\n");
            sb.Append("  ProcessDefinitionKey: ").Append(ProcessDefinitionKey).Append("\n");
            sb.Append("  ProcessDefinitionKeyIn: ").Append(ProcessDefinitionKeyIn).Append("\n");
            sb.Append("  ProcessDefinitionVersionTag: ").Append(ProcessDefinitionVersionTag).Append("\n");
            sb.Append("  WithoutTenantId: ").Append(WithoutTenantId).Append("\n");
            sb.Append("  TenantIdIn: ").Append(TenantIdIn).Append("\n");
            sb.Append("  ProcessVariables: ").Append(ProcessVariables).Append("\n");
            sb.Append("  DeserializeValues: ").Append(DeserializeValues).Append("\n");
            sb.Append("  IncludeExtensionProperties: ").Append(IncludeExtensionProperties).Append("\n");
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
            return this.Equals(input as FetchExternalTaskTopicDto);
        }

        /// <summary>
        /// Returns true if FetchExternalTaskTopicDto instances are equal
        /// </summary>
        /// <param name="input">Instance of FetchExternalTaskTopicDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FetchExternalTaskTopicDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TopicName == input.TopicName ||
                    (this.TopicName != null &&
                    this.TopicName.Equals(input.TopicName))
                ) && 
                (
                    this.LockDuration == input.LockDuration ||
                    (this.LockDuration != null &&
                    this.LockDuration.Equals(input.LockDuration))
                ) && 
                (
                    this.Variables == input.Variables ||
                    this.Variables != null &&
                    input.Variables != null &&
                    this.Variables.SequenceEqual(input.Variables)
                ) && 
                (
                    this.LocalVariables == input.LocalVariables ||
                    (this.LocalVariables != null &&
                    this.LocalVariables.Equals(input.LocalVariables))
                ) && 
                (
                    this.BusinessKey == input.BusinessKey ||
                    (this.BusinessKey != null &&
                    this.BusinessKey.Equals(input.BusinessKey))
                ) && 
                (
                    this.ProcessDefinitionId == input.ProcessDefinitionId ||
                    (this.ProcessDefinitionId != null &&
                    this.ProcessDefinitionId.Equals(input.ProcessDefinitionId))
                ) && 
                (
                    this.ProcessDefinitionIdIn == input.ProcessDefinitionIdIn ||
                    this.ProcessDefinitionIdIn != null &&
                    input.ProcessDefinitionIdIn != null &&
                    this.ProcessDefinitionIdIn.SequenceEqual(input.ProcessDefinitionIdIn)
                ) && 
                (
                    this.ProcessDefinitionKey == input.ProcessDefinitionKey ||
                    (this.ProcessDefinitionKey != null &&
                    this.ProcessDefinitionKey.Equals(input.ProcessDefinitionKey))
                ) && 
                (
                    this.ProcessDefinitionKeyIn == input.ProcessDefinitionKeyIn ||
                    this.ProcessDefinitionKeyIn != null &&
                    input.ProcessDefinitionKeyIn != null &&
                    this.ProcessDefinitionKeyIn.SequenceEqual(input.ProcessDefinitionKeyIn)
                ) && 
                (
                    this.ProcessDefinitionVersionTag == input.ProcessDefinitionVersionTag ||
                    (this.ProcessDefinitionVersionTag != null &&
                    this.ProcessDefinitionVersionTag.Equals(input.ProcessDefinitionVersionTag))
                ) && 
                (
                    this.WithoutTenantId == input.WithoutTenantId ||
                    (this.WithoutTenantId != null &&
                    this.WithoutTenantId.Equals(input.WithoutTenantId))
                ) && 
                (
                    this.TenantIdIn == input.TenantIdIn ||
                    this.TenantIdIn != null &&
                    input.TenantIdIn != null &&
                    this.TenantIdIn.SequenceEqual(input.TenantIdIn)
                ) && 
                (
                    this.ProcessVariables == input.ProcessVariables ||
                    this.ProcessVariables != null &&
                    input.ProcessVariables != null &&
                    this.ProcessVariables.SequenceEqual(input.ProcessVariables)
                ) && 
                (
                    this.DeserializeValues == input.DeserializeValues ||
                    (this.DeserializeValues != null &&
                    this.DeserializeValues.Equals(input.DeserializeValues))
                ) && 
                (
                    this.IncludeExtensionProperties == input.IncludeExtensionProperties ||
                    (this.IncludeExtensionProperties != null &&
                    this.IncludeExtensionProperties.Equals(input.IncludeExtensionProperties))
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
                if (this.TopicName != null)
                    hashCode = hashCode * 59 + this.TopicName.GetHashCode();
                if (this.LockDuration != null)
                    hashCode = hashCode * 59 + this.LockDuration.GetHashCode();
                if (this.Variables != null)
                    hashCode = hashCode * 59 + this.Variables.GetHashCode();
                if (this.LocalVariables != null)
                    hashCode = hashCode * 59 + this.LocalVariables.GetHashCode();
                if (this.BusinessKey != null)
                    hashCode = hashCode * 59 + this.BusinessKey.GetHashCode();
                if (this.ProcessDefinitionId != null)
                    hashCode = hashCode * 59 + this.ProcessDefinitionId.GetHashCode();
                if (this.ProcessDefinitionIdIn != null)
                    hashCode = hashCode * 59 + this.ProcessDefinitionIdIn.GetHashCode();
                if (this.ProcessDefinitionKey != null)
                    hashCode = hashCode * 59 + this.ProcessDefinitionKey.GetHashCode();
                if (this.ProcessDefinitionKeyIn != null)
                    hashCode = hashCode * 59 + this.ProcessDefinitionKeyIn.GetHashCode();
                if (this.ProcessDefinitionVersionTag != null)
                    hashCode = hashCode * 59 + this.ProcessDefinitionVersionTag.GetHashCode();
                if (this.WithoutTenantId != null)
                    hashCode = hashCode * 59 + this.WithoutTenantId.GetHashCode();
                if (this.TenantIdIn != null)
                    hashCode = hashCode * 59 + this.TenantIdIn.GetHashCode();
                if (this.ProcessVariables != null)
                    hashCode = hashCode * 59 + this.ProcessVariables.GetHashCode();
                if (this.DeserializeValues != null)
                    hashCode = hashCode * 59 + this.DeserializeValues.GetHashCode();
                if (this.IncludeExtensionProperties != null)
                    hashCode = hashCode * 59 + this.IncludeExtensionProperties.GetHashCode();
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
