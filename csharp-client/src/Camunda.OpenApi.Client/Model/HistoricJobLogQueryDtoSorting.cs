/*
 * Camunda Platform REST API
 *
 * OpenApi Spec for Camunda Platform REST API.
 *
 * The version of the OpenAPI document: 7.17.0
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
    /// HistoricJobLogQueryDtoSorting
    /// </summary>
    [DataContract(Name = "HistoricJobLogQueryDto_sorting")]
    public partial class HistoricJobLogQueryDtoSorting : IEquatable<HistoricJobLogQueryDtoSorting>, IValidatableObject
    {
        /// <summary>
        /// Sort the results lexicographically by a given criterion. Must be used in conjunction with the sortOrder parameter.
        /// </summary>
        /// <value>Sort the results lexicographically by a given criterion. Must be used in conjunction with the sortOrder parameter.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SortByEnum
        {
            /// <summary>
            /// Enum Timestamp for value: timestamp
            /// </summary>
            [EnumMember(Value = "timestamp")]
            Timestamp = 1,

            /// <summary>
            /// Enum JobId for value: jobId
            /// </summary>
            [EnumMember(Value = "jobId")]
            JobId = 2,

            /// <summary>
            /// Enum JobDefinitionId for value: jobDefinitionId
            /// </summary>
            [EnumMember(Value = "jobDefinitionId")]
            JobDefinitionId = 3,

            /// <summary>
            /// Enum JobDueDate for value: jobDueDate
            /// </summary>
            [EnumMember(Value = "jobDueDate")]
            JobDueDate = 4,

            /// <summary>
            /// Enum JobRetries for value: jobRetries
            /// </summary>
            [EnumMember(Value = "jobRetries")]
            JobRetries = 5,

            /// <summary>
            /// Enum JobPriority for value: jobPriority
            /// </summary>
            [EnumMember(Value = "jobPriority")]
            JobPriority = 6,

            /// <summary>
            /// Enum ActivityId for value: activityId
            /// </summary>
            [EnumMember(Value = "activityId")]
            ActivityId = 7,

            /// <summary>
            /// Enum ExecutionId for value: executionId
            /// </summary>
            [EnumMember(Value = "executionId")]
            ExecutionId = 8,

            /// <summary>
            /// Enum ProcessInstanceId for value: processInstanceId
            /// </summary>
            [EnumMember(Value = "processInstanceId")]
            ProcessInstanceId = 9,

            /// <summary>
            /// Enum ProcessDefinitionId for value: processDefinitionId
            /// </summary>
            [EnumMember(Value = "processDefinitionId")]
            ProcessDefinitionId = 10,

            /// <summary>
            /// Enum ProcessDefinitionKey for value: processDefinitionKey
            /// </summary>
            [EnumMember(Value = "processDefinitionKey")]
            ProcessDefinitionKey = 11,

            /// <summary>
            /// Enum DeploymentId for value: deploymentId
            /// </summary>
            [EnumMember(Value = "deploymentId")]
            DeploymentId = 12,

            /// <summary>
            /// Enum Hostname for value: hostname
            /// </summary>
            [EnumMember(Value = "hostname")]
            Hostname = 13,

            /// <summary>
            /// Enum Occurrence for value: occurrence
            /// </summary>
            [EnumMember(Value = "occurrence")]
            Occurrence = 14,

            /// <summary>
            /// Enum TenantId for value: tenantId
            /// </summary>
            [EnumMember(Value = "tenantId")]
            TenantId = 15

        }


        /// <summary>
        /// Sort the results lexicographically by a given criterion. Must be used in conjunction with the sortOrder parameter.
        /// </summary>
        /// <value>Sort the results lexicographically by a given criterion. Must be used in conjunction with the sortOrder parameter.</value>
        [DataMember(Name = "sortBy", EmitDefaultValue = true)]
        public SortByEnum? SortBy { get; set; }
        /// <summary>
        /// Sort the results in a given order. Values may be &#x60;asc&#x60; for ascending order or &#x60;desc&#x60; for descending order. Must be used in conjunction with the sortBy parameter.
        /// </summary>
        /// <value>Sort the results in a given order. Values may be &#x60;asc&#x60; for ascending order or &#x60;desc&#x60; for descending order. Must be used in conjunction with the sortBy parameter.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SortOrderEnum
        {
            /// <summary>
            /// Enum Asc for value: asc
            /// </summary>
            [EnumMember(Value = "asc")]
            Asc = 1,

            /// <summary>
            /// Enum Desc for value: desc
            /// </summary>
            [EnumMember(Value = "desc")]
            Desc = 2

        }


        /// <summary>
        /// Sort the results in a given order. Values may be &#x60;asc&#x60; for ascending order or &#x60;desc&#x60; for descending order. Must be used in conjunction with the sortBy parameter.
        /// </summary>
        /// <value>Sort the results in a given order. Values may be &#x60;asc&#x60; for ascending order or &#x60;desc&#x60; for descending order. Must be used in conjunction with the sortBy parameter.</value>
        [DataMember(Name = "sortOrder", EmitDefaultValue = true)]
        public SortOrderEnum? SortOrder { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="HistoricJobLogQueryDtoSorting" /> class.
        /// </summary>
        /// <param name="sortBy">Sort the results lexicographically by a given criterion. Must be used in conjunction with the sortOrder parameter..</param>
        /// <param name="sortOrder">Sort the results in a given order. Values may be &#x60;asc&#x60; for ascending order or &#x60;desc&#x60; for descending order. Must be used in conjunction with the sortBy parameter..</param>
        public HistoricJobLogQueryDtoSorting(SortByEnum? sortBy = default(SortByEnum?), SortOrderEnum? sortOrder = default(SortOrderEnum?))
        {
            this.SortBy = sortBy;
            this.SortOrder = sortOrder;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HistoricJobLogQueryDtoSorting {\n");
            sb.Append("  SortBy: ").Append(SortBy).Append("\n");
            sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
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
            return this.Equals(input as HistoricJobLogQueryDtoSorting);
        }

        /// <summary>
        /// Returns true if HistoricJobLogQueryDtoSorting instances are equal
        /// </summary>
        /// <param name="input">Instance of HistoricJobLogQueryDtoSorting to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HistoricJobLogQueryDtoSorting input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SortBy == input.SortBy ||
                    this.SortBy.Equals(input.SortBy)
                ) && 
                (
                    this.SortOrder == input.SortOrder ||
                    this.SortOrder.Equals(input.SortOrder)
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
                hashCode = hashCode * 59 + this.SortBy.GetHashCode();
                hashCode = hashCode * 59 + this.SortOrder.GetHashCode();
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
