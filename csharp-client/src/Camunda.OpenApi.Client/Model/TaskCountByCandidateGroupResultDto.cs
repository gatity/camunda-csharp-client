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
    /// TaskCountByCandidateGroupResultDto
    /// </summary>
    [DataContract(Name = "TaskCountByCandidateGroupResultDto")]
    public partial class TaskCountByCandidateGroupResultDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskCountByCandidateGroupResultDto" /> class.
        /// </summary>
        /// <param name="groupName">The name of the candidate group. If there are tasks without a group name, the value will be &#x60;null&#x60;.</param>
        /// <param name="taskCount">The number of tasks which have the group name as candidate group..</param>
        public TaskCountByCandidateGroupResultDto(string groupName = default(string), int? taskCount = default(int?))
        {
            this.GroupName = groupName;
            this.TaskCount = taskCount;
        }

        /// <summary>
        /// The name of the candidate group. If there are tasks without a group name, the value will be &#x60;null&#x60;
        /// </summary>
        /// <value>The name of the candidate group. If there are tasks without a group name, the value will be &#x60;null&#x60;</value>
        [DataMember(Name = "groupName", EmitDefaultValue = true)]
        public string GroupName { get; set; }

        /// <summary>
        /// The number of tasks which have the group name as candidate group.
        /// </summary>
        /// <value>The number of tasks which have the group name as candidate group.</value>
        [DataMember(Name = "taskCount", EmitDefaultValue = true)]
        public int? TaskCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TaskCountByCandidateGroupResultDto {\n");
            sb.Append("  GroupName: ").Append(GroupName).Append("\n");
            sb.Append("  TaskCount: ").Append(TaskCount).Append("\n");
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
