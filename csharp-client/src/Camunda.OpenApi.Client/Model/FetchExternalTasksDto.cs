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
    /// FetchExternalTasksDto
    /// </summary>
    [DataContract(Name = "FetchExternalTasksDto")]
    public partial class FetchExternalTasksDto : IEquatable<FetchExternalTasksDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FetchExternalTasksDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FetchExternalTasksDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FetchExternalTasksDto" /> class.
        /// </summary>
        /// <param name="workerId">**Mandatory.** The id of the worker on which behalf tasks are fetched. The returned tasks are locked for that worker and can only be completed when providing the same worker id. (required).</param>
        /// <param name="maxTasks">**Mandatory.** The maximum number of tasks to return. (required).</param>
        /// <param name="usePriority">A &#x60;boolean&#x60; value, which indicates whether the task should be fetched based on its priority or arbitrarily..</param>
        /// <param name="asyncResponseTimeout">The [Long Polling](https://docs.camunda.org/manual/7.16/user-guide/process-engine/external-tasks/#long-polling-to-fetch-and-lock-external-tasks) timeout in milliseconds.  **Note:** The value cannot be set larger than 1.800.000 milliseconds (corresponds to 30 minutes)..</param>
        /// <param name="topics">A JSON array of topic objects for which external tasks should be fetched. The returned tasks may be arbitrarily distributed among these topics. Each topic object has the following properties:.</param>
        public FetchExternalTasksDto(string workerId = default(string), int? maxTasks = default(int?), bool? usePriority = default(bool?), long? asyncResponseTimeout = default(long?), List<FetchExternalTaskTopicDto> topics = default(List<FetchExternalTaskTopicDto>))
        {
            // to ensure "workerId" is required (not null)
            this.WorkerId = workerId ?? throw new ArgumentNullException("workerId is a required property for FetchExternalTasksDto and cannot be null");
            // to ensure "maxTasks" is required (not null)
            this.MaxTasks = maxTasks ?? throw new ArgumentNullException("maxTasks is a required property for FetchExternalTasksDto and cannot be null");
            this.UsePriority = usePriority;
            this.AsyncResponseTimeout = asyncResponseTimeout;
            this.Topics = topics;
        }

        /// <summary>
        /// **Mandatory.** The id of the worker on which behalf tasks are fetched. The returned tasks are locked for that worker and can only be completed when providing the same worker id.
        /// </summary>
        /// <value>**Mandatory.** The id of the worker on which behalf tasks are fetched. The returned tasks are locked for that worker and can only be completed when providing the same worker id.</value>
        [DataMember(Name = "workerId", IsRequired = true, EmitDefaultValue = false)]
        public string WorkerId { get; set; }

        /// <summary>
        /// **Mandatory.** The maximum number of tasks to return.
        /// </summary>
        /// <value>**Mandatory.** The maximum number of tasks to return.</value>
        [DataMember(Name = "maxTasks", IsRequired = true, EmitDefaultValue = true)]
        public int? MaxTasks { get; set; }

        /// <summary>
        /// A &#x60;boolean&#x60; value, which indicates whether the task should be fetched based on its priority or arbitrarily.
        /// </summary>
        /// <value>A &#x60;boolean&#x60; value, which indicates whether the task should be fetched based on its priority or arbitrarily.</value>
        [DataMember(Name = "usePriority", EmitDefaultValue = true)]
        public bool? UsePriority { get; set; }

        /// <summary>
        /// The [Long Polling](https://docs.camunda.org/manual/7.16/user-guide/process-engine/external-tasks/#long-polling-to-fetch-and-lock-external-tasks) timeout in milliseconds.  **Note:** The value cannot be set larger than 1.800.000 milliseconds (corresponds to 30 minutes).
        /// </summary>
        /// <value>The [Long Polling](https://docs.camunda.org/manual/7.16/user-guide/process-engine/external-tasks/#long-polling-to-fetch-and-lock-external-tasks) timeout in milliseconds.  **Note:** The value cannot be set larger than 1.800.000 milliseconds (corresponds to 30 minutes).</value>
        [DataMember(Name = "asyncResponseTimeout", EmitDefaultValue = true)]
        public long? AsyncResponseTimeout { get; set; }

        /// <summary>
        /// A JSON array of topic objects for which external tasks should be fetched. The returned tasks may be arbitrarily distributed among these topics. Each topic object has the following properties:
        /// </summary>
        /// <value>A JSON array of topic objects for which external tasks should be fetched. The returned tasks may be arbitrarily distributed among these topics. Each topic object has the following properties:</value>
        [DataMember(Name = "topics", EmitDefaultValue = true)]
        public List<FetchExternalTaskTopicDto> Topics { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FetchExternalTasksDto {\n");
            sb.Append("  WorkerId: ").Append(WorkerId).Append("\n");
            sb.Append("  MaxTasks: ").Append(MaxTasks).Append("\n");
            sb.Append("  UsePriority: ").Append(UsePriority).Append("\n");
            sb.Append("  AsyncResponseTimeout: ").Append(AsyncResponseTimeout).Append("\n");
            sb.Append("  Topics: ").Append(Topics).Append("\n");
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
            return this.Equals(input as FetchExternalTasksDto);
        }

        /// <summary>
        /// Returns true if FetchExternalTasksDto instances are equal
        /// </summary>
        /// <param name="input">Instance of FetchExternalTasksDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FetchExternalTasksDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.WorkerId == input.WorkerId ||
                    (this.WorkerId != null &&
                    this.WorkerId.Equals(input.WorkerId))
                ) && 
                (
                    this.MaxTasks == input.MaxTasks ||
                    (this.MaxTasks != null &&
                    this.MaxTasks.Equals(input.MaxTasks))
                ) && 
                (
                    this.UsePriority == input.UsePriority ||
                    (this.UsePriority != null &&
                    this.UsePriority.Equals(input.UsePriority))
                ) && 
                (
                    this.AsyncResponseTimeout == input.AsyncResponseTimeout ||
                    (this.AsyncResponseTimeout != null &&
                    this.AsyncResponseTimeout.Equals(input.AsyncResponseTimeout))
                ) && 
                (
                    this.Topics == input.Topics ||
                    this.Topics != null &&
                    input.Topics != null &&
                    this.Topics.SequenceEqual(input.Topics)
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
                if (this.WorkerId != null)
                    hashCode = hashCode * 59 + this.WorkerId.GetHashCode();
                if (this.MaxTasks != null)
                    hashCode = hashCode * 59 + this.MaxTasks.GetHashCode();
                if (this.UsePriority != null)
                    hashCode = hashCode * 59 + this.UsePriority.GetHashCode();
                if (this.AsyncResponseTimeout != null)
                    hashCode = hashCode * 59 + this.AsyncResponseTimeout.GetHashCode();
                if (this.Topics != null)
                    hashCode = hashCode * 59 + this.Topics.GetHashCode();
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
