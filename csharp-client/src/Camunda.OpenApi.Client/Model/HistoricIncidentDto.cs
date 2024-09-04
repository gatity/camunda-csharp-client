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
    /// HistoricIncidentDto
    /// </summary>
    [DataContract(Name = "HistoricIncidentDto")]
    public partial class HistoricIncidentDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HistoricIncidentDto" /> class.
        /// </summary>
        /// <param name="id">The id of the incident..</param>
        /// <param name="processDefinitionKey">The key of the process definition this incident is associated with..</param>
        /// <param name="processDefinitionId">The id of the process definition this incident is associated with..</param>
        /// <param name="processInstanceId">The key of the process definition this incident is associated with..</param>
        /// <param name="executionId">The id of the execution this incident is associated with..</param>
        /// <param name="rootProcessInstanceId">The process instance id of the root process instance that initiated the process containing this incident..</param>
        /// <param name="createTime">The time this incident happened.  [Default format](https://docs.camunda.org/manual/7.21/reference/rest/overview/date-format/) &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;..</param>
        /// <param name="endTime">The time this incident has been deleted or resolved.  [Default format](https://docs.camunda.org/manual/7.21/reference/rest/overview/date-format/) &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;..</param>
        /// <param name="removalTime">The time after which the incident should be removed by the History Cleanup job. [Default format](https://docs.camunda.org/manual/7.21/reference/rest/overview/date-format/) &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;..</param>
        /// <param name="incidentType">The type of incident, for example: &#x60;failedJobs&#x60; will be returned in case of an incident which identified a failed job during the execution of a process instance. See the [User Guide](/manual/develop/user- guide/process-engine/incidents/#incident-types) for a list of incident types..</param>
        /// <param name="activityId">The id of the activity this incident is associated with..</param>
        /// <param name="failedActivityId">The id of the activity on which the last exception occurred..</param>
        /// <param name="causeIncidentId">The id of the associated cause incident which has been triggered..</param>
        /// <param name="rootCauseIncidentId">The id of the associated root cause incident which has been triggered..</param>
        /// <param name="varConfiguration">The payload of this incident..</param>
        /// <param name="historyConfiguration">The payload of this incident at the time when it occurred..</param>
        /// <param name="incidentMessage">The message of this incident..</param>
        /// <param name="tenantId">The id of the tenant this incident is associated with..</param>
        /// <param name="jobDefinitionId">The job definition id the incident is associated with..</param>
        /// <param name="open">If true, this incident is open..</param>
        /// <param name="deleted">If true, this incident has been deleted..</param>
        /// <param name="resolved">If true, this incident has been resolved..</param>
        /// <param name="annotation">The annotation set to the incident..</param>
        public HistoricIncidentDto(string id = default(string), string processDefinitionKey = default(string), string processDefinitionId = default(string), string processInstanceId = default(string), string executionId = default(string), string rootProcessInstanceId = default(string), DateTime? createTime = default(DateTime?), DateTime? endTime = default(DateTime?), DateTime? removalTime = default(DateTime?), string incidentType = default(string), string activityId = default(string), string failedActivityId = default(string), string causeIncidentId = default(string), string rootCauseIncidentId = default(string), string varConfiguration = default(string), string historyConfiguration = default(string), string incidentMessage = default(string), string tenantId = default(string), string jobDefinitionId = default(string), bool? open = default(bool?), bool? deleted = default(bool?), bool? resolved = default(bool?), string annotation = default(string))
        {
            this.Id = id;
            this.ProcessDefinitionKey = processDefinitionKey;
            this.ProcessDefinitionId = processDefinitionId;
            this.ProcessInstanceId = processInstanceId;
            this.ExecutionId = executionId;
            this.RootProcessInstanceId = rootProcessInstanceId;
            this.CreateTime = createTime;
            this.EndTime = endTime;
            this.RemovalTime = removalTime;
            this.IncidentType = incidentType;
            this.ActivityId = activityId;
            this.FailedActivityId = failedActivityId;
            this.CauseIncidentId = causeIncidentId;
            this.RootCauseIncidentId = rootCauseIncidentId;
            this.VarConfiguration = varConfiguration;
            this.HistoryConfiguration = historyConfiguration;
            this.IncidentMessage = incidentMessage;
            this.TenantId = tenantId;
            this.JobDefinitionId = jobDefinitionId;
            this.Open = open;
            this.Deleted = deleted;
            this.Resolved = resolved;
            this.Annotation = annotation;
        }

        /// <summary>
        /// The id of the incident.
        /// </summary>
        /// <value>The id of the incident.</value>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// The key of the process definition this incident is associated with.
        /// </summary>
        /// <value>The key of the process definition this incident is associated with.</value>
        [DataMember(Name = "processDefinitionKey", EmitDefaultValue = true)]
        public string ProcessDefinitionKey { get; set; }

        /// <summary>
        /// The id of the process definition this incident is associated with.
        /// </summary>
        /// <value>The id of the process definition this incident is associated with.</value>
        [DataMember(Name = "processDefinitionId", EmitDefaultValue = true)]
        public string ProcessDefinitionId { get; set; }

        /// <summary>
        /// The key of the process definition this incident is associated with.
        /// </summary>
        /// <value>The key of the process definition this incident is associated with.</value>
        [DataMember(Name = "processInstanceId", EmitDefaultValue = true)]
        public string ProcessInstanceId { get; set; }

        /// <summary>
        /// The id of the execution this incident is associated with.
        /// </summary>
        /// <value>The id of the execution this incident is associated with.</value>
        [DataMember(Name = "executionId", EmitDefaultValue = true)]
        public string ExecutionId { get; set; }

        /// <summary>
        /// The process instance id of the root process instance that initiated the process containing this incident.
        /// </summary>
        /// <value>The process instance id of the root process instance that initiated the process containing this incident.</value>
        [DataMember(Name = "rootProcessInstanceId", EmitDefaultValue = true)]
        public string RootProcessInstanceId { get; set; }

        /// <summary>
        /// The time this incident happened.  [Default format](https://docs.camunda.org/manual/7.21/reference/rest/overview/date-format/) &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;.
        /// </summary>
        /// <value>The time this incident happened.  [Default format](https://docs.camunda.org/manual/7.21/reference/rest/overview/date-format/) &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;.</value>
        [DataMember(Name = "createTime", EmitDefaultValue = true)]
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// The time this incident has been deleted or resolved.  [Default format](https://docs.camunda.org/manual/7.21/reference/rest/overview/date-format/) &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;.
        /// </summary>
        /// <value>The time this incident has been deleted or resolved.  [Default format](https://docs.camunda.org/manual/7.21/reference/rest/overview/date-format/) &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;.</value>
        [DataMember(Name = "endTime", EmitDefaultValue = true)]
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// The time after which the incident should be removed by the History Cleanup job. [Default format](https://docs.camunda.org/manual/7.21/reference/rest/overview/date-format/) &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;.
        /// </summary>
        /// <value>The time after which the incident should be removed by the History Cleanup job. [Default format](https://docs.camunda.org/manual/7.21/reference/rest/overview/date-format/) &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;.</value>
        [DataMember(Name = "removalTime", EmitDefaultValue = true)]
        public DateTime? RemovalTime { get; set; }

        /// <summary>
        /// The type of incident, for example: &#x60;failedJobs&#x60; will be returned in case of an incident which identified a failed job during the execution of a process instance. See the [User Guide](/manual/develop/user- guide/process-engine/incidents/#incident-types) for a list of incident types.
        /// </summary>
        /// <value>The type of incident, for example: &#x60;failedJobs&#x60; will be returned in case of an incident which identified a failed job during the execution of a process instance. See the [User Guide](/manual/develop/user- guide/process-engine/incidents/#incident-types) for a list of incident types.</value>
        [DataMember(Name = "incidentType", EmitDefaultValue = true)]
        public string IncidentType { get; set; }

        /// <summary>
        /// The id of the activity this incident is associated with.
        /// </summary>
        /// <value>The id of the activity this incident is associated with.</value>
        [DataMember(Name = "activityId", EmitDefaultValue = true)]
        public string ActivityId { get; set; }

        /// <summary>
        /// The id of the activity on which the last exception occurred.
        /// </summary>
        /// <value>The id of the activity on which the last exception occurred.</value>
        [DataMember(Name = "failedActivityId", EmitDefaultValue = true)]
        public string FailedActivityId { get; set; }

        /// <summary>
        /// The id of the associated cause incident which has been triggered.
        /// </summary>
        /// <value>The id of the associated cause incident which has been triggered.</value>
        [DataMember(Name = "causeIncidentId", EmitDefaultValue = true)]
        public string CauseIncidentId { get; set; }

        /// <summary>
        /// The id of the associated root cause incident which has been triggered.
        /// </summary>
        /// <value>The id of the associated root cause incident which has been triggered.</value>
        [DataMember(Name = "rootCauseIncidentId", EmitDefaultValue = true)]
        public string RootCauseIncidentId { get; set; }

        /// <summary>
        /// The payload of this incident.
        /// </summary>
        /// <value>The payload of this incident.</value>
        [DataMember(Name = "configuration", EmitDefaultValue = true)]
        public string VarConfiguration { get; set; }

        /// <summary>
        /// The payload of this incident at the time when it occurred.
        /// </summary>
        /// <value>The payload of this incident at the time when it occurred.</value>
        [DataMember(Name = "historyConfiguration", EmitDefaultValue = true)]
        public string HistoryConfiguration { get; set; }

        /// <summary>
        /// The message of this incident.
        /// </summary>
        /// <value>The message of this incident.</value>
        [DataMember(Name = "incidentMessage", EmitDefaultValue = true)]
        public string IncidentMessage { get; set; }

        /// <summary>
        /// The id of the tenant this incident is associated with.
        /// </summary>
        /// <value>The id of the tenant this incident is associated with.</value>
        [DataMember(Name = "tenantId", EmitDefaultValue = true)]
        public string TenantId { get; set; }

        /// <summary>
        /// The job definition id the incident is associated with.
        /// </summary>
        /// <value>The job definition id the incident is associated with.</value>
        [DataMember(Name = "jobDefinitionId", EmitDefaultValue = true)]
        public string JobDefinitionId { get; set; }

        /// <summary>
        /// If true, this incident is open.
        /// </summary>
        /// <value>If true, this incident is open.</value>
        [DataMember(Name = "open", EmitDefaultValue = true)]
        public bool? Open { get; set; }

        /// <summary>
        /// If true, this incident has been deleted.
        /// </summary>
        /// <value>If true, this incident has been deleted.</value>
        [DataMember(Name = "deleted", EmitDefaultValue = true)]
        public bool? Deleted { get; set; }

        /// <summary>
        /// If true, this incident has been resolved.
        /// </summary>
        /// <value>If true, this incident has been resolved.</value>
        [DataMember(Name = "resolved", EmitDefaultValue = true)]
        public bool? Resolved { get; set; }

        /// <summary>
        /// The annotation set to the incident.
        /// </summary>
        /// <value>The annotation set to the incident.</value>
        [DataMember(Name = "annotation", EmitDefaultValue = true)]
        public string Annotation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class HistoricIncidentDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ProcessDefinitionKey: ").Append(ProcessDefinitionKey).Append("\n");
            sb.Append("  ProcessDefinitionId: ").Append(ProcessDefinitionId).Append("\n");
            sb.Append("  ProcessInstanceId: ").Append(ProcessInstanceId).Append("\n");
            sb.Append("  ExecutionId: ").Append(ExecutionId).Append("\n");
            sb.Append("  RootProcessInstanceId: ").Append(RootProcessInstanceId).Append("\n");
            sb.Append("  CreateTime: ").Append(CreateTime).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  RemovalTime: ").Append(RemovalTime).Append("\n");
            sb.Append("  IncidentType: ").Append(IncidentType).Append("\n");
            sb.Append("  ActivityId: ").Append(ActivityId).Append("\n");
            sb.Append("  FailedActivityId: ").Append(FailedActivityId).Append("\n");
            sb.Append("  CauseIncidentId: ").Append(CauseIncidentId).Append("\n");
            sb.Append("  RootCauseIncidentId: ").Append(RootCauseIncidentId).Append("\n");
            sb.Append("  VarConfiguration: ").Append(VarConfiguration).Append("\n");
            sb.Append("  HistoryConfiguration: ").Append(HistoryConfiguration).Append("\n");
            sb.Append("  IncidentMessage: ").Append(IncidentMessage).Append("\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  JobDefinitionId: ").Append(JobDefinitionId).Append("\n");
            sb.Append("  Open: ").Append(Open).Append("\n");
            sb.Append("  Deleted: ").Append(Deleted).Append("\n");
            sb.Append("  Resolved: ").Append(Resolved).Append("\n");
            sb.Append("  Annotation: ").Append(Annotation).Append("\n");
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
