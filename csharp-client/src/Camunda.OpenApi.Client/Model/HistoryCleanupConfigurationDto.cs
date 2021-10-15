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
    /// HistoryCleanupConfigurationDto
    /// </summary>
    [DataContract(Name = "HistoryCleanupConfigurationDto")]
    public partial class HistoryCleanupConfigurationDto : IEquatable<HistoryCleanupConfigurationDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HistoryCleanupConfigurationDto" /> class.
        /// </summary>
        /// <param name="batchWindowStartTime">Start time of the current or next batch window. By [default](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;..</param>
        /// <param name="batchWindowEndTime">End time of the current or next batch window. By [default](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;..</param>
        /// <param name="enabled">Indicates whether the engine node participates in history cleanup or not. The default is &#x60;true&#x60;. Participation can be disabled via [Process Engine Configuration](https://docs.camunda.org/manual/7.16/reference/deployment-descriptors/tags/process-engine/#history-cleanup-enabled).  For more details, see [Cleanup Execution Participation per Node](https://docs.camunda.org/manual/7.16/user-guide/process-engine/history/#cleanup-execution-participation-per-node)..</param>
        public HistoryCleanupConfigurationDto(DateTime? batchWindowStartTime = default(DateTime?), DateTime? batchWindowEndTime = default(DateTime?), bool? enabled = default(bool?))
        {
            this.BatchWindowStartTime = batchWindowStartTime;
            this.BatchWindowEndTime = batchWindowEndTime;
            this.Enabled = enabled;
        }

        /// <summary>
        /// Start time of the current or next batch window. By [default](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;.
        /// </summary>
        /// <value>Start time of the current or next batch window. By [default](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;.</value>
        [DataMember(Name = "batchWindowStartTime", EmitDefaultValue = true)]
        public DateTime? BatchWindowStartTime { get; set; }

        /// <summary>
        /// End time of the current or next batch window. By [default](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;.
        /// </summary>
        /// <value>End time of the current or next batch window. By [default](https://docs.camunda.org/manual/7.16/reference/rest/overview/date-format/), the date must have the format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;, e.g., &#x60;2013-01-23T14:42:45.000+0200&#x60;.</value>
        [DataMember(Name = "batchWindowEndTime", EmitDefaultValue = true)]
        public DateTime? BatchWindowEndTime { get; set; }

        /// <summary>
        /// Indicates whether the engine node participates in history cleanup or not. The default is &#x60;true&#x60;. Participation can be disabled via [Process Engine Configuration](https://docs.camunda.org/manual/7.16/reference/deployment-descriptors/tags/process-engine/#history-cleanup-enabled).  For more details, see [Cleanup Execution Participation per Node](https://docs.camunda.org/manual/7.16/user-guide/process-engine/history/#cleanup-execution-participation-per-node).
        /// </summary>
        /// <value>Indicates whether the engine node participates in history cleanup or not. The default is &#x60;true&#x60;. Participation can be disabled via [Process Engine Configuration](https://docs.camunda.org/manual/7.16/reference/deployment-descriptors/tags/process-engine/#history-cleanup-enabled).  For more details, see [Cleanup Execution Participation per Node](https://docs.camunda.org/manual/7.16/user-guide/process-engine/history/#cleanup-execution-participation-per-node).</value>
        [DataMember(Name = "enabled", EmitDefaultValue = true)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HistoryCleanupConfigurationDto {\n");
            sb.Append("  BatchWindowStartTime: ").Append(BatchWindowStartTime).Append("\n");
            sb.Append("  BatchWindowEndTime: ").Append(BatchWindowEndTime).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
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
            return this.Equals(input as HistoryCleanupConfigurationDto);
        }

        /// <summary>
        /// Returns true if HistoryCleanupConfigurationDto instances are equal
        /// </summary>
        /// <param name="input">Instance of HistoryCleanupConfigurationDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HistoryCleanupConfigurationDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BatchWindowStartTime == input.BatchWindowStartTime ||
                    (this.BatchWindowStartTime != null &&
                    this.BatchWindowStartTime.Equals(input.BatchWindowStartTime))
                ) && 
                (
                    this.BatchWindowEndTime == input.BatchWindowEndTime ||
                    (this.BatchWindowEndTime != null &&
                    this.BatchWindowEndTime.Equals(input.BatchWindowEndTime))
                ) && 
                (
                    this.Enabled == input.Enabled ||
                    (this.Enabled != null &&
                    this.Enabled.Equals(input.Enabled))
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
                if (this.BatchWindowStartTime != null)
                    hashCode = hashCode * 59 + this.BatchWindowStartTime.GetHashCode();
                if (this.BatchWindowEndTime != null)
                    hashCode = hashCode * 59 + this.BatchWindowEndTime.GetHashCode();
                if (this.Enabled != null)
                    hashCode = hashCode * 59 + this.Enabled.GetHashCode();
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
