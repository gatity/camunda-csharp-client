/*
 * Camunda BPM REST API
 *
 * OpenApi Spec for Camunda BPM REST API.
 *
 * The version of the OpenAPI document: 7.14.0
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
using OpenAPIDateConverter = CamundaClient.Client.OpenAPIDateConverter;

namespace CamundaClient.Model
{
    /// <summary>
    /// HistoricProcessInstanceDto
    /// </summary>
    [DataContract(Name = "HistoricProcessInstanceDto")]
    public partial class HistoricProcessInstanceDto : IEquatable<HistoricProcessInstanceDto>, IValidatableObject
    {
        /// <summary>
        /// Last state of the process instance, possible values are:  &#x60;ACTIVE&#x60; - running process instance  &#x60;SUSPENDED&#x60; - suspended process instances  &#x60;COMPLETED&#x60; - completed through normal end event  &#x60;EXTERNALLY_TERMINATED&#x60; - terminated externally, for instance through REST API  &#x60;INTERNALLY_TERMINATED&#x60; - terminated internally, for instance by terminating boundary event
        /// </summary>
        /// <value>Last state of the process instance, possible values are:  &#x60;ACTIVE&#x60; - running process instance  &#x60;SUSPENDED&#x60; - suspended process instances  &#x60;COMPLETED&#x60; - completed through normal end event  &#x60;EXTERNALLY_TERMINATED&#x60; - terminated externally, for instance through REST API  &#x60;INTERNALLY_TERMINATED&#x60; - terminated internally, for instance by terminating boundary event</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StateEnum
        {
            /// <summary>
            /// Enum ACTIVE for value: ACTIVE
            /// </summary>
            [EnumMember(Value = "ACTIVE")]
            ACTIVE = 1,

            /// <summary>
            /// Enum SUSPENDED for value: SUSPENDED
            /// </summary>
            [EnumMember(Value = "SUSPENDED")]
            SUSPENDED = 2,

            /// <summary>
            /// Enum COMPLETED for value: COMPLETED
            /// </summary>
            [EnumMember(Value = "COMPLETED")]
            COMPLETED = 3,

            /// <summary>
            /// Enum EXTERNALLYTERMINATED for value: EXTERNALLY_TERMINATED
            /// </summary>
            [EnumMember(Value = "EXTERNALLY_TERMINATED")]
            EXTERNALLYTERMINATED = 4,

            /// <summary>
            /// Enum INTERNALLYTERMINATED for value: INTERNALLY_TERMINATED
            /// </summary>
            [EnumMember(Value = "INTERNALLY_TERMINATED")]
            INTERNALLYTERMINATED = 5

        }

        /// <summary>
        /// Last state of the process instance, possible values are:  &#x60;ACTIVE&#x60; - running process instance  &#x60;SUSPENDED&#x60; - suspended process instances  &#x60;COMPLETED&#x60; - completed through normal end event  &#x60;EXTERNALLY_TERMINATED&#x60; - terminated externally, for instance through REST API  &#x60;INTERNALLY_TERMINATED&#x60; - terminated internally, for instance by terminating boundary event
        /// </summary>
        /// <value>Last state of the process instance, possible values are:  &#x60;ACTIVE&#x60; - running process instance  &#x60;SUSPENDED&#x60; - suspended process instances  &#x60;COMPLETED&#x60; - completed through normal end event  &#x60;EXTERNALLY_TERMINATED&#x60; - terminated externally, for instance through REST API  &#x60;INTERNALLY_TERMINATED&#x60; - terminated internally, for instance by terminating boundary event</value>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public StateEnum? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="HistoricProcessInstanceDto" /> class.
        /// </summary>
        /// <param name="id">The id of the process instance..</param>
        /// <param name="rootProcessInstanceId">The process instance id of the root process instance that initiated the process..</param>
        /// <param name="superProcessInstanceId">The id of the parent process instance, if it exists..</param>
        /// <param name="superCaseInstanceId">The id of the parent case instance, if it exists..</param>
        /// <param name="caseInstanceId">The id of the parent case instance, if it exists..</param>
        /// <param name="processDefinitionName">The name of the process definition that this process instance belongs to..</param>
        /// <param name="processDefinitionKey">The key of the process definition that this process instance belongs to..</param>
        /// <param name="processDefinitionVersion">The version of the process definition that this process instance belongs to..</param>
        /// <param name="processDefinitionId">The id of the process definition that this process instance belongs to..</param>
        /// <param name="businessKey">The business key of the process instance..</param>
        /// <param name="startTime">The time the instance was started. Default [format](https://docs.camunda.org/manual/7.14/reference/rest/overview/date-format/) &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;..</param>
        /// <param name="endTime">The time the instance ended. Default [format](https://docs.camunda.org/manual/7.14/reference/rest/overview/date-format/) &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;..</param>
        /// <param name="removalTime">The time after which the instance should be removed by the History Cleanup job. Default [format](https://docs.camunda.org/manual/7.14/reference/rest/overview/date-format/) &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;..</param>
        /// <param name="durationInMillis">The time the instance took to finish (in milliseconds)..</param>
        /// <param name="startUserId">The id of the user who started the process instance..</param>
        /// <param name="startActivityId">The id of the initial activity that was executed (e.g., a start event)..</param>
        /// <param name="deleteReason">The provided delete reason in case the process instance was canceled during execution..</param>
        /// <param name="tenantId">The tenant id of the process instance..</param>
        /// <param name="state">Last state of the process instance, possible values are:  &#x60;ACTIVE&#x60; - running process instance  &#x60;SUSPENDED&#x60; - suspended process instances  &#x60;COMPLETED&#x60; - completed through normal end event  &#x60;EXTERNALLY_TERMINATED&#x60; - terminated externally, for instance through REST API  &#x60;INTERNALLY_TERMINATED&#x60; - terminated internally, for instance by terminating boundary event.</param>
        public HistoricProcessInstanceDto(string id = default(string), string rootProcessInstanceId = default(string), string superProcessInstanceId = default(string), string superCaseInstanceId = default(string), string caseInstanceId = default(string), string processDefinitionName = default(string), string processDefinitionKey = default(string), int processDefinitionVersion = default(int), string processDefinitionId = default(string), string businessKey = default(string), DateTime? startTime = default(DateTime?), DateTime? endTime = default(DateTime?), DateTime? removalTime = default(DateTime?), int? durationInMillis = default(int?), string startUserId = default(string), string startActivityId = default(string), string deleteReason = default(string), string tenantId = default(string), StateEnum? state = default(StateEnum?))
        {
            this.Id = id;
            this.RootProcessInstanceId = rootProcessInstanceId;
            this.SuperProcessInstanceId = superProcessInstanceId;
            this.SuperCaseInstanceId = superCaseInstanceId;
            this.CaseInstanceId = caseInstanceId;
            this.ProcessDefinitionName = processDefinitionName;
            this.ProcessDefinitionKey = processDefinitionKey;
            this.ProcessDefinitionVersion = processDefinitionVersion;
            this.ProcessDefinitionId = processDefinitionId;
            this.BusinessKey = businessKey;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.RemovalTime = removalTime;
            this.DurationInMillis = durationInMillis;
            this.StartUserId = startUserId;
            this.StartActivityId = startActivityId;
            this.DeleteReason = deleteReason;
            this.TenantId = tenantId;
            this.State = state;
        }

        /// <summary>
        /// The id of the process instance.
        /// </summary>
        /// <value>The id of the process instance.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The process instance id of the root process instance that initiated the process.
        /// </summary>
        /// <value>The process instance id of the root process instance that initiated the process.</value>
        [DataMember(Name = "rootProcessInstanceId", EmitDefaultValue = false)]
        public string RootProcessInstanceId { get; set; }

        /// <summary>
        /// The id of the parent process instance, if it exists.
        /// </summary>
        /// <value>The id of the parent process instance, if it exists.</value>
        [DataMember(Name = "superProcessInstanceId", EmitDefaultValue = false)]
        public string SuperProcessInstanceId { get; set; }

        /// <summary>
        /// The id of the parent case instance, if it exists.
        /// </summary>
        /// <value>The id of the parent case instance, if it exists.</value>
        [DataMember(Name = "superCaseInstanceId", EmitDefaultValue = false)]
        public string SuperCaseInstanceId { get; set; }

        /// <summary>
        /// The id of the parent case instance, if it exists.
        /// </summary>
        /// <value>The id of the parent case instance, if it exists.</value>
        [DataMember(Name = "caseInstanceId", EmitDefaultValue = false)]
        public string CaseInstanceId { get; set; }

        /// <summary>
        /// The name of the process definition that this process instance belongs to.
        /// </summary>
        /// <value>The name of the process definition that this process instance belongs to.</value>
        [DataMember(Name = "processDefinitionName", EmitDefaultValue = false)]
        public string ProcessDefinitionName { get; set; }

        /// <summary>
        /// The key of the process definition that this process instance belongs to.
        /// </summary>
        /// <value>The key of the process definition that this process instance belongs to.</value>
        [DataMember(Name = "processDefinitionKey", EmitDefaultValue = false)]
        public string ProcessDefinitionKey { get; set; }

        /// <summary>
        /// The version of the process definition that this process instance belongs to.
        /// </summary>
        /// <value>The version of the process definition that this process instance belongs to.</value>
        [DataMember(Name = "processDefinitionVersion", EmitDefaultValue = false)]
        public int ProcessDefinitionVersion { get; set; }

        /// <summary>
        /// The id of the process definition that this process instance belongs to.
        /// </summary>
        /// <value>The id of the process definition that this process instance belongs to.</value>
        [DataMember(Name = "processDefinitionId", EmitDefaultValue = false)]
        public string ProcessDefinitionId { get; set; }

        /// <summary>
        /// The business key of the process instance.
        /// </summary>
        /// <value>The business key of the process instance.</value>
        [DataMember(Name = "businessKey", EmitDefaultValue = false)]
        public string BusinessKey { get; set; }

        /// <summary>
        /// The time the instance was started. Default [format](https://docs.camunda.org/manual/7.14/reference/rest/overview/date-format/) &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;.
        /// </summary>
        /// <value>The time the instance was started. Default [format](https://docs.camunda.org/manual/7.14/reference/rest/overview/date-format/) &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;.</value>
        [DataMember(Name = "startTime", EmitDefaultValue = true)]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// The time the instance ended. Default [format](https://docs.camunda.org/manual/7.14/reference/rest/overview/date-format/) &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;.
        /// </summary>
        /// <value>The time the instance ended. Default [format](https://docs.camunda.org/manual/7.14/reference/rest/overview/date-format/) &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;.</value>
        [DataMember(Name = "endTime", EmitDefaultValue = true)]
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// The time after which the instance should be removed by the History Cleanup job. Default [format](https://docs.camunda.org/manual/7.14/reference/rest/overview/date-format/) &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;.
        /// </summary>
        /// <value>The time after which the instance should be removed by the History Cleanup job. Default [format](https://docs.camunda.org/manual/7.14/reference/rest/overview/date-format/) &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;.</value>
        [DataMember(Name = "removalTime", EmitDefaultValue = true)]
        public DateTime? RemovalTime { get; set; }

        /// <summary>
        /// The time the instance took to finish (in milliseconds).
        /// </summary>
        /// <value>The time the instance took to finish (in milliseconds).</value>
        [DataMember(Name = "durationInMillis", EmitDefaultValue = true)]
        public int? DurationInMillis { get; set; }

        /// <summary>
        /// The id of the user who started the process instance.
        /// </summary>
        /// <value>The id of the user who started the process instance.</value>
        [DataMember(Name = "startUserId", EmitDefaultValue = false)]
        public string StartUserId { get; set; }

        /// <summary>
        /// The id of the initial activity that was executed (e.g., a start event).
        /// </summary>
        /// <value>The id of the initial activity that was executed (e.g., a start event).</value>
        [DataMember(Name = "startActivityId", EmitDefaultValue = false)]
        public string StartActivityId { get; set; }

        /// <summary>
        /// The provided delete reason in case the process instance was canceled during execution.
        /// </summary>
        /// <value>The provided delete reason in case the process instance was canceled during execution.</value>
        [DataMember(Name = "deleteReason", EmitDefaultValue = false)]
        public string DeleteReason { get; set; }

        /// <summary>
        /// The tenant id of the process instance.
        /// </summary>
        /// <value>The tenant id of the process instance.</value>
        [DataMember(Name = "tenantId", EmitDefaultValue = false)]
        public string TenantId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HistoricProcessInstanceDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  RootProcessInstanceId: ").Append(RootProcessInstanceId).Append("\n");
            sb.Append("  SuperProcessInstanceId: ").Append(SuperProcessInstanceId).Append("\n");
            sb.Append("  SuperCaseInstanceId: ").Append(SuperCaseInstanceId).Append("\n");
            sb.Append("  CaseInstanceId: ").Append(CaseInstanceId).Append("\n");
            sb.Append("  ProcessDefinitionName: ").Append(ProcessDefinitionName).Append("\n");
            sb.Append("  ProcessDefinitionKey: ").Append(ProcessDefinitionKey).Append("\n");
            sb.Append("  ProcessDefinitionVersion: ").Append(ProcessDefinitionVersion).Append("\n");
            sb.Append("  ProcessDefinitionId: ").Append(ProcessDefinitionId).Append("\n");
            sb.Append("  BusinessKey: ").Append(BusinessKey).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  RemovalTime: ").Append(RemovalTime).Append("\n");
            sb.Append("  DurationInMillis: ").Append(DurationInMillis).Append("\n");
            sb.Append("  StartUserId: ").Append(StartUserId).Append("\n");
            sb.Append("  StartActivityId: ").Append(StartActivityId).Append("\n");
            sb.Append("  DeleteReason: ").Append(DeleteReason).Append("\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
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
            return this.Equals(input as HistoricProcessInstanceDto);
        }

        /// <summary>
        /// Returns true if HistoricProcessInstanceDto instances are equal
        /// </summary>
        /// <param name="input">Instance of HistoricProcessInstanceDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HistoricProcessInstanceDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.RootProcessInstanceId == input.RootProcessInstanceId ||
                    (this.RootProcessInstanceId != null &&
                    this.RootProcessInstanceId.Equals(input.RootProcessInstanceId))
                ) && 
                (
                    this.SuperProcessInstanceId == input.SuperProcessInstanceId ||
                    (this.SuperProcessInstanceId != null &&
                    this.SuperProcessInstanceId.Equals(input.SuperProcessInstanceId))
                ) && 
                (
                    this.SuperCaseInstanceId == input.SuperCaseInstanceId ||
                    (this.SuperCaseInstanceId != null &&
                    this.SuperCaseInstanceId.Equals(input.SuperCaseInstanceId))
                ) && 
                (
                    this.CaseInstanceId == input.CaseInstanceId ||
                    (this.CaseInstanceId != null &&
                    this.CaseInstanceId.Equals(input.CaseInstanceId))
                ) && 
                (
                    this.ProcessDefinitionName == input.ProcessDefinitionName ||
                    (this.ProcessDefinitionName != null &&
                    this.ProcessDefinitionName.Equals(input.ProcessDefinitionName))
                ) && 
                (
                    this.ProcessDefinitionKey == input.ProcessDefinitionKey ||
                    (this.ProcessDefinitionKey != null &&
                    this.ProcessDefinitionKey.Equals(input.ProcessDefinitionKey))
                ) && 
                (
                    this.ProcessDefinitionVersion == input.ProcessDefinitionVersion ||
                    this.ProcessDefinitionVersion.Equals(input.ProcessDefinitionVersion)
                ) && 
                (
                    this.ProcessDefinitionId == input.ProcessDefinitionId ||
                    (this.ProcessDefinitionId != null &&
                    this.ProcessDefinitionId.Equals(input.ProcessDefinitionId))
                ) && 
                (
                    this.BusinessKey == input.BusinessKey ||
                    (this.BusinessKey != null &&
                    this.BusinessKey.Equals(input.BusinessKey))
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
                ) && 
                (
                    this.RemovalTime == input.RemovalTime ||
                    (this.RemovalTime != null &&
                    this.RemovalTime.Equals(input.RemovalTime))
                ) && 
                (
                    this.DurationInMillis == input.DurationInMillis ||
                    (this.DurationInMillis != null &&
                    this.DurationInMillis.Equals(input.DurationInMillis))
                ) && 
                (
                    this.StartUserId == input.StartUserId ||
                    (this.StartUserId != null &&
                    this.StartUserId.Equals(input.StartUserId))
                ) && 
                (
                    this.StartActivityId == input.StartActivityId ||
                    (this.StartActivityId != null &&
                    this.StartActivityId.Equals(input.StartActivityId))
                ) && 
                (
                    this.DeleteReason == input.DeleteReason ||
                    (this.DeleteReason != null &&
                    this.DeleteReason.Equals(input.DeleteReason))
                ) && 
                (
                    this.TenantId == input.TenantId ||
                    (this.TenantId != null &&
                    this.TenantId.Equals(input.TenantId))
                ) && 
                (
                    this.State == input.State ||
                    this.State.Equals(input.State)
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.RootProcessInstanceId != null)
                    hashCode = hashCode * 59 + this.RootProcessInstanceId.GetHashCode();
                if (this.SuperProcessInstanceId != null)
                    hashCode = hashCode * 59 + this.SuperProcessInstanceId.GetHashCode();
                if (this.SuperCaseInstanceId != null)
                    hashCode = hashCode * 59 + this.SuperCaseInstanceId.GetHashCode();
                if (this.CaseInstanceId != null)
                    hashCode = hashCode * 59 + this.CaseInstanceId.GetHashCode();
                if (this.ProcessDefinitionName != null)
                    hashCode = hashCode * 59 + this.ProcessDefinitionName.GetHashCode();
                if (this.ProcessDefinitionKey != null)
                    hashCode = hashCode * 59 + this.ProcessDefinitionKey.GetHashCode();
                hashCode = hashCode * 59 + this.ProcessDefinitionVersion.GetHashCode();
                if (this.ProcessDefinitionId != null)
                    hashCode = hashCode * 59 + this.ProcessDefinitionId.GetHashCode();
                if (this.BusinessKey != null)
                    hashCode = hashCode * 59 + this.BusinessKey.GetHashCode();
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null)
                    hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.RemovalTime != null)
                    hashCode = hashCode * 59 + this.RemovalTime.GetHashCode();
                if (this.DurationInMillis != null)
                    hashCode = hashCode * 59 + this.DurationInMillis.GetHashCode();
                if (this.StartUserId != null)
                    hashCode = hashCode * 59 + this.StartUserId.GetHashCode();
                if (this.StartActivityId != null)
                    hashCode = hashCode * 59 + this.StartActivityId.GetHashCode();
                if (this.DeleteReason != null)
                    hashCode = hashCode * 59 + this.DeleteReason.GetHashCode();
                if (this.TenantId != null)
                    hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                hashCode = hashCode * 59 + this.State.GetHashCode();
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
