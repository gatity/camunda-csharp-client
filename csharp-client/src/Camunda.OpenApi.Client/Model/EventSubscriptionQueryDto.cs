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
    /// A event subscription query which retrieves a list of event subscriptions
    /// </summary>
    [DataContract(Name = "EventSubscriptionQueryDto")]
    public partial class EventSubscriptionQueryDto : IEquatable<EventSubscriptionQueryDto>, IValidatableObject
    {
        /// <summary>
        /// The type of the event subscription.
        /// </summary>
        /// <value>The type of the event subscription.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EventTypeEnum
        {
            /// <summary>
            /// Enum Message for value: message
            /// </summary>
            [EnumMember(Value = "message")]
            Message = 1,

            /// <summary>
            /// Enum Signal for value: signal
            /// </summary>
            [EnumMember(Value = "signal")]
            Signal = 2,

            /// <summary>
            /// Enum Compensate for value: compensate
            /// </summary>
            [EnumMember(Value = "compensate")]
            Compensate = 3,

            /// <summary>
            /// Enum Conditional for value: conditional
            /// </summary>
            [EnumMember(Value = "conditional")]
            Conditional = 4

        }


        /// <summary>
        /// The type of the event subscription.
        /// </summary>
        /// <value>The type of the event subscription.</value>
        [DataMember(Name = "eventType", EmitDefaultValue = true)]
        public EventTypeEnum? EventType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="EventSubscriptionQueryDto" /> class.
        /// </summary>
        /// <param name="eventSubscriptionId">The id of the event subscription..</param>
        /// <param name="eventName">The name of the event this subscription belongs to as defined in the process model..</param>
        /// <param name="eventType">The type of the event subscription..</param>
        /// <param name="executionId">The execution that is subscribed on the referenced event..</param>
        /// <param name="processInstanceId">The process instance this subscription belongs to..</param>
        /// <param name="activityId">The identifier of the activity that this event subscription belongs to. This could for example be the id of a receive task..</param>
        /// <param name="tenantIdIn">Filter by a comma-separated list of tenant ids. Only select subscriptions that belong to one of the given tenant ids..</param>
        /// <param name="withoutTenantId">Only select subscriptions which have no tenant id. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior..</param>
        /// <param name="includeEventSubscriptionsWithoutTenantId">Select event subscriptions which have no tenant id. Can be used in combination with tenantIdIn parameter. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior..</param>
        /// <param name="sorting">Apply sorting of the result.</param>
        public EventSubscriptionQueryDto(string eventSubscriptionId = default(string), string eventName = default(string), EventTypeEnum? eventType = default(EventTypeEnum?), string executionId = default(string), string processInstanceId = default(string), string activityId = default(string), List<string> tenantIdIn = default(List<string>), bool? withoutTenantId = default(bool?), bool? includeEventSubscriptionsWithoutTenantId = default(bool?), List<EventSubscriptionQueryDtoSorting> sorting = default(List<EventSubscriptionQueryDtoSorting>))
        {
            this.EventSubscriptionId = eventSubscriptionId;
            this.EventName = eventName;
            this.EventType = eventType;
            this.ExecutionId = executionId;
            this.ProcessInstanceId = processInstanceId;
            this.ActivityId = activityId;
            this.TenantIdIn = tenantIdIn;
            this.WithoutTenantId = withoutTenantId;
            this.IncludeEventSubscriptionsWithoutTenantId = includeEventSubscriptionsWithoutTenantId;
            this.Sorting = sorting;
        }

        /// <summary>
        /// The id of the event subscription.
        /// </summary>
        /// <value>The id of the event subscription.</value>
        [DataMember(Name = "eventSubscriptionId", EmitDefaultValue = true)]
        public string EventSubscriptionId { get; set; }

        /// <summary>
        /// The name of the event this subscription belongs to as defined in the process model.
        /// </summary>
        /// <value>The name of the event this subscription belongs to as defined in the process model.</value>
        [DataMember(Name = "eventName", EmitDefaultValue = true)]
        public string EventName { get; set; }

        /// <summary>
        /// The execution that is subscribed on the referenced event.
        /// </summary>
        /// <value>The execution that is subscribed on the referenced event.</value>
        [DataMember(Name = "executionId", EmitDefaultValue = true)]
        public string ExecutionId { get; set; }

        /// <summary>
        /// The process instance this subscription belongs to.
        /// </summary>
        /// <value>The process instance this subscription belongs to.</value>
        [DataMember(Name = "processInstanceId", EmitDefaultValue = true)]
        public string ProcessInstanceId { get; set; }

        /// <summary>
        /// The identifier of the activity that this event subscription belongs to. This could for example be the id of a receive task.
        /// </summary>
        /// <value>The identifier of the activity that this event subscription belongs to. This could for example be the id of a receive task.</value>
        [DataMember(Name = "activityId", EmitDefaultValue = true)]
        public string ActivityId { get; set; }

        /// <summary>
        /// Filter by a comma-separated list of tenant ids. Only select subscriptions that belong to one of the given tenant ids.
        /// </summary>
        /// <value>Filter by a comma-separated list of tenant ids. Only select subscriptions that belong to one of the given tenant ids.</value>
        [DataMember(Name = "tenantIdIn", EmitDefaultValue = true)]
        public List<string> TenantIdIn { get; set; }

        /// <summary>
        /// Only select subscriptions which have no tenant id. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior.
        /// </summary>
        /// <value>Only select subscriptions which have no tenant id. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior.</value>
        [DataMember(Name = "withoutTenantId", EmitDefaultValue = true)]
        public bool? WithoutTenantId { get; set; }

        /// <summary>
        /// Select event subscriptions which have no tenant id. Can be used in combination with tenantIdIn parameter. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior.
        /// </summary>
        /// <value>Select event subscriptions which have no tenant id. Can be used in combination with tenantIdIn parameter. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior.</value>
        [DataMember(Name = "includeEventSubscriptionsWithoutTenantId", EmitDefaultValue = true)]
        public bool? IncludeEventSubscriptionsWithoutTenantId { get; set; }

        /// <summary>
        /// Apply sorting of the result
        /// </summary>
        /// <value>Apply sorting of the result</value>
        [DataMember(Name = "sorting", EmitDefaultValue = true)]
        public List<EventSubscriptionQueryDtoSorting> Sorting { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EventSubscriptionQueryDto {\n");
            sb.Append("  EventSubscriptionId: ").Append(EventSubscriptionId).Append("\n");
            sb.Append("  EventName: ").Append(EventName).Append("\n");
            sb.Append("  EventType: ").Append(EventType).Append("\n");
            sb.Append("  ExecutionId: ").Append(ExecutionId).Append("\n");
            sb.Append("  ProcessInstanceId: ").Append(ProcessInstanceId).Append("\n");
            sb.Append("  ActivityId: ").Append(ActivityId).Append("\n");
            sb.Append("  TenantIdIn: ").Append(TenantIdIn).Append("\n");
            sb.Append("  WithoutTenantId: ").Append(WithoutTenantId).Append("\n");
            sb.Append("  IncludeEventSubscriptionsWithoutTenantId: ").Append(IncludeEventSubscriptionsWithoutTenantId).Append("\n");
            sb.Append("  Sorting: ").Append(Sorting).Append("\n");
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
            return this.Equals(input as EventSubscriptionQueryDto);
        }

        /// <summary>
        /// Returns true if EventSubscriptionQueryDto instances are equal
        /// </summary>
        /// <param name="input">Instance of EventSubscriptionQueryDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EventSubscriptionQueryDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EventSubscriptionId == input.EventSubscriptionId ||
                    (this.EventSubscriptionId != null &&
                    this.EventSubscriptionId.Equals(input.EventSubscriptionId))
                ) && 
                (
                    this.EventName == input.EventName ||
                    (this.EventName != null &&
                    this.EventName.Equals(input.EventName))
                ) && 
                (
                    this.EventType == input.EventType ||
                    this.EventType.Equals(input.EventType)
                ) && 
                (
                    this.ExecutionId == input.ExecutionId ||
                    (this.ExecutionId != null &&
                    this.ExecutionId.Equals(input.ExecutionId))
                ) && 
                (
                    this.ProcessInstanceId == input.ProcessInstanceId ||
                    (this.ProcessInstanceId != null &&
                    this.ProcessInstanceId.Equals(input.ProcessInstanceId))
                ) && 
                (
                    this.ActivityId == input.ActivityId ||
                    (this.ActivityId != null &&
                    this.ActivityId.Equals(input.ActivityId))
                ) && 
                (
                    this.TenantIdIn == input.TenantIdIn ||
                    this.TenantIdIn != null &&
                    input.TenantIdIn != null &&
                    this.TenantIdIn.SequenceEqual(input.TenantIdIn)
                ) && 
                (
                    this.WithoutTenantId == input.WithoutTenantId ||
                    (this.WithoutTenantId != null &&
                    this.WithoutTenantId.Equals(input.WithoutTenantId))
                ) && 
                (
                    this.IncludeEventSubscriptionsWithoutTenantId == input.IncludeEventSubscriptionsWithoutTenantId ||
                    (this.IncludeEventSubscriptionsWithoutTenantId != null &&
                    this.IncludeEventSubscriptionsWithoutTenantId.Equals(input.IncludeEventSubscriptionsWithoutTenantId))
                ) && 
                (
                    this.Sorting == input.Sorting ||
                    this.Sorting != null &&
                    input.Sorting != null &&
                    this.Sorting.SequenceEqual(input.Sorting)
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
                if (this.EventSubscriptionId != null)
                    hashCode = hashCode * 59 + this.EventSubscriptionId.GetHashCode();
                if (this.EventName != null)
                    hashCode = hashCode * 59 + this.EventName.GetHashCode();
                hashCode = hashCode * 59 + this.EventType.GetHashCode();
                if (this.ExecutionId != null)
                    hashCode = hashCode * 59 + this.ExecutionId.GetHashCode();
                if (this.ProcessInstanceId != null)
                    hashCode = hashCode * 59 + this.ProcessInstanceId.GetHashCode();
                if (this.ActivityId != null)
                    hashCode = hashCode * 59 + this.ActivityId.GetHashCode();
                if (this.TenantIdIn != null)
                    hashCode = hashCode * 59 + this.TenantIdIn.GetHashCode();
                if (this.WithoutTenantId != null)
                    hashCode = hashCode * 59 + this.WithoutTenantId.GetHashCode();
                if (this.IncludeEventSubscriptionsWithoutTenantId != null)
                    hashCode = hashCode * 59 + this.IncludeEventSubscriptionsWithoutTenantId.GetHashCode();
                if (this.Sorting != null)
                    hashCode = hashCode * 59 + this.Sorting.GetHashCode();
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
