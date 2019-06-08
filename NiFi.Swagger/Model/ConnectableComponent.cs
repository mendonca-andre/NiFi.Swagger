/* 
 * NiFi Rest Api
 *
 * The Rest Api provides programmatic access to command and control a NiFi instance in real time. Start and                                              stop processors, monitor queues, query provenance data, and more. Each endpoint below includes a description,                                             definitions of the expected input and output, potential response codes, and the authorizations required                                             to invoke each service.
 *
 * OpenAPI spec version: 1.9.1
 * Contact: dev@nifi.apache.org
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

namespace NiFi.Swagger.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.IO;
    using System.Runtime.Serialization;
    using System.Text;

    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// ConnectableComponent
    /// </summary>
    [DataContract]
    public partial class ConnectableComponent :  IEquatable<ConnectableComponent>, IValidatableObject
    {
        /// <summary>
        /// The type of component the connectable is.
        /// </summary>
        /// <value>The type of component the connectable is.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum PROCESSOR for value: PROCESSOR
            /// </summary>
            [EnumMember(Value = "PROCESSOR")]
            PROCESSOR = 1,
            
            /// <summary>
            /// Enum REMOTEINPUTPORT for value: REMOTE_INPUT_PORT
            /// </summary>
            [EnumMember(Value = "REMOTE_INPUT_PORT")]
            REMOTEINPUTPORT = 2,
            
            /// <summary>
            /// Enum REMOTEOUTPUTPORT for value: REMOTE_OUTPUT_PORT
            /// </summary>
            [EnumMember(Value = "REMOTE_OUTPUT_PORT")]
            REMOTEOUTPUTPORT = 3,
            
            /// <summary>
            /// Enum INPUTPORT for value: INPUT_PORT
            /// </summary>
            [EnumMember(Value = "INPUT_PORT")]
            INPUTPORT = 4,
            
            /// <summary>
            /// Enum OUTPUTPORT for value: OUTPUT_PORT
            /// </summary>
            [EnumMember(Value = "OUTPUT_PORT")]
            OUTPUTPORT = 5,
            
            /// <summary>
            /// Enum FUNNEL for value: FUNNEL
            /// </summary>
            [EnumMember(Value = "FUNNEL")]
            FUNNEL = 6
        }

        /// <summary>
        /// The type of component the connectable is.
        /// </summary>
        /// <value>The type of component the connectable is.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectableComponent" /> class.
        /// </summary>
        [JsonConstructor]
        protected ConnectableComponent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectableComponent" /> class.
        /// </summary>
        /// <param name="id">The id of the connectable component. (required).</param>
        /// <param name="type">The type of component the connectable is. (required).</param>
        /// <param name="groupId">The id of the group that the connectable component resides in (required).</param>
        /// <param name="name">The name of the connectable component.</param>
        /// <param name="comments">The comments for the connectable component..</param>
        public ConnectableComponent(string id = default(string), TypeEnum type = default(TypeEnum), string groupId = default(string), string name = default(string), string comments = default(string))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for ConnectableComponent and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for ConnectableComponent and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            // to ensure "groupId" is required (not null)
            if (groupId == null)
            {
                throw new InvalidDataException("groupId is a required property for ConnectableComponent and cannot be null");
            }
            else
            {
                this.GroupId = groupId;
            }
            this.Name = name;
            this.Comments = comments;
        }
        
        /// <summary>
        /// The id of the connectable component.
        /// </summary>
        /// <value>The id of the connectable component.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }


        /// <summary>
        /// The id of the group that the connectable component resides in
        /// </summary>
        /// <value>The id of the group that the connectable component resides in</value>
        [DataMember(Name="groupId", EmitDefaultValue=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// The name of the connectable component
        /// </summary>
        /// <value>The name of the connectable component</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The comments for the connectable component.
        /// </summary>
        /// <value>The comments for the connectable component.</value>
        [DataMember(Name="comments", EmitDefaultValue=false)]
        public string Comments { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConnectableComponent {\n");
            sb.Append("  Id: ").Append(this.Id).Append("\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  GroupId: ").Append(this.GroupId).Append("\n");
            sb.Append("  Name: ").Append(this.Name).Append("\n");
            sb.Append("  Comments: ").Append(this.Comments).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ConnectableComponent);
        }

        /// <summary>
        /// Returns true if ConnectableComponent instances are equal
        /// </summary>
        /// <param name="input">Instance of ConnectableComponent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConnectableComponent input)
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
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.GroupId == input.GroupId ||
                    (this.GroupId != null &&
                    this.GroupId.Equals(input.GroupId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Comments == input.Comments ||
                    (this.Comments != null &&
                    this.Comments.Equals(input.Comments))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.GroupId != null)
                    hashCode = hashCode * 59 + this.GroupId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Comments != null)
                    hashCode = hashCode * 59 + this.Comments.GetHashCode();
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
