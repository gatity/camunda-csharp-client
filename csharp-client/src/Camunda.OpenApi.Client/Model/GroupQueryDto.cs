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
    /// A group instance query which defines a list of group instances
    /// </summary>
    [DataContract(Name = "GroupQueryDto")]
    public partial class GroupQueryDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupQueryDto" /> class.
        /// </summary>
        /// <param name="id">Filter by the id of the group..</param>
        /// <param name="idIn">Filter by a JSON string array of group ids..</param>
        /// <param name="name">Filter by the name of the group..</param>
        /// <param name="nameLike">Filter by the name that the parameter is a substring of..</param>
        /// <param name="type">Filter by the type of the group..</param>
        /// <param name="member">Only retrieve groups where the given user id is a member of..</param>
        /// <param name="memberOfTenant">Only retrieve groups which are members of the given tenant..</param>
        /// <param name="sorting">Apply sorting of the result.</param>
        public GroupQueryDto(string id = default(string), List<string> idIn = default(List<string>), string name = default(string), string nameLike = default(string), string type = default(string), string member = default(string), string memberOfTenant = default(string), List<GroupQueryDtoSortingInner> sorting = default(List<GroupQueryDtoSortingInner>))
        {
            this.Id = id;
            this.IdIn = idIn;
            this.Name = name;
            this.NameLike = nameLike;
            this.Type = type;
            this.Member = member;
            this.MemberOfTenant = memberOfTenant;
            this.Sorting = sorting;
        }

        /// <summary>
        /// Filter by the id of the group.
        /// </summary>
        /// <value>Filter by the id of the group.</value>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Filter by a JSON string array of group ids.
        /// </summary>
        /// <value>Filter by a JSON string array of group ids.</value>
        [DataMember(Name = "idIn", EmitDefaultValue = true)]
        public List<string> IdIn { get; set; }

        /// <summary>
        /// Filter by the name of the group.
        /// </summary>
        /// <value>Filter by the name of the group.</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Filter by the name that the parameter is a substring of.
        /// </summary>
        /// <value>Filter by the name that the parameter is a substring of.</value>
        [DataMember(Name = "nameLike", EmitDefaultValue = true)]
        public string NameLike { get; set; }

        /// <summary>
        /// Filter by the type of the group.
        /// </summary>
        /// <value>Filter by the type of the group.</value>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// Only retrieve groups where the given user id is a member of.
        /// </summary>
        /// <value>Only retrieve groups where the given user id is a member of.</value>
        [DataMember(Name = "member", EmitDefaultValue = true)]
        public string Member { get; set; }

        /// <summary>
        /// Only retrieve groups which are members of the given tenant.
        /// </summary>
        /// <value>Only retrieve groups which are members of the given tenant.</value>
        [DataMember(Name = "memberOfTenant", EmitDefaultValue = true)]
        public string MemberOfTenant { get; set; }

        /// <summary>
        /// Apply sorting of the result
        /// </summary>
        /// <value>Apply sorting of the result</value>
        [DataMember(Name = "sorting", EmitDefaultValue = true)]
        public List<GroupQueryDtoSortingInner> Sorting { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GroupQueryDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdIn: ").Append(IdIn).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  NameLike: ").Append(NameLike).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Member: ").Append(Member).Append("\n");
            sb.Append("  MemberOfTenant: ").Append(MemberOfTenant).Append("\n");
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
