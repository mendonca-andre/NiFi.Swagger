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
    using System.Runtime.Serialization;
    using System.Text;

    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// LineageRequestDTO
    /// </summary>
    [DataContract]
    public partial class LineageRequestDTO :  IEquatable<LineageRequestDTO>, IValidatableObject
    {
        /// <summary>
        /// The type of lineage request. PARENTS will return the lineage for the flowfiles that are parents of the specified event. CHILDREN will return the lineage for the flowfiles that are children of the specified event. FLOWFILE will return the lineage for the specified flowfile.
        /// </summary>
        /// <value>The type of lineage request. PARENTS will return the lineage for the flowfiles that are parents of the specified event. CHILDREN will return the lineage for the flowfiles that are children of the specified event. FLOWFILE will return the lineage for the specified flowfile.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LineageRequestTypeEnum
        {
            
            /// <summary>
            /// Enum PARENTS for value: PARENTS
            /// </summary>
            [EnumMember(Value = "PARENTS")]
            PARENTS = 1,
            
            /// <summary>
            /// Enum CHILDREN for value: CHILDREN
            /// </summary>
            [EnumMember(Value = "CHILDREN")]
            CHILDREN = 2,
            
            /// <summary>
            /// Enum AndFLOWFILE for value: and FLOWFILE
            /// </summary>
            [EnumMember(Value = "and FLOWFILE")]
            AndFLOWFILE = 3
        }

        /// <summary>
        /// The type of lineage request. PARENTS will return the lineage for the flowfiles that are parents of the specified event. CHILDREN will return the lineage for the flowfiles that are children of the specified event. FLOWFILE will return the lineage for the specified flowfile.
        /// </summary>
        /// <value>The type of lineage request. PARENTS will return the lineage for the flowfiles that are parents of the specified event. CHILDREN will return the lineage for the flowfiles that are children of the specified event. FLOWFILE will return the lineage for the specified flowfile.</value>
        [DataMember(Name="lineageRequestType", EmitDefaultValue=false)]
        public LineageRequestTypeEnum? LineageRequestType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="LineageRequestDTO" /> class.
        /// </summary>
        /// <param name="eventId">The event id that was used to generate this lineage, if applicable. The event id is allowed for any type of lineageRequestType. If the lineageRequestType is FLOWFILE and the flowfile uuid is also included in the request, the event id will be ignored..</param>
        /// <param name="lineageRequestType">The type of lineage request. PARENTS will return the lineage for the flowfiles that are parents of the specified event. CHILDREN will return the lineage for the flowfiles that are children of the specified event. FLOWFILE will return the lineage for the specified flowfile..</param>
        /// <param name="uuid">The flowfile uuid that was used to generate the lineage. The flowfile uuid is only allowed when the lineageRequestType is FLOWFILE and will take precedence over event id..</param>
        /// <param name="clusterNodeId">The id of the node where this lineage originated if clustered..</param>
        public LineageRequestDTO(long? eventId = default(long?), LineageRequestTypeEnum? lineageRequestType = default(LineageRequestTypeEnum?), string uuid = default(string), string clusterNodeId = default(string))
        {
            this.EventId = eventId;
            this.LineageRequestType = lineageRequestType;
            this.Uuid = uuid;
            this.ClusterNodeId = clusterNodeId;
        }
        
        /// <summary>
        /// The event id that was used to generate this lineage, if applicable. The event id is allowed for any type of lineageRequestType. If the lineageRequestType is FLOWFILE and the flowfile uuid is also included in the request, the event id will be ignored.
        /// </summary>
        /// <value>The event id that was used to generate this lineage, if applicable. The event id is allowed for any type of lineageRequestType. If the lineageRequestType is FLOWFILE and the flowfile uuid is also included in the request, the event id will be ignored.</value>
        [DataMember(Name="eventId", EmitDefaultValue=false)]
        public long? EventId { get; set; }


        /// <summary>
        /// The flowfile uuid that was used to generate the lineage. The flowfile uuid is only allowed when the lineageRequestType is FLOWFILE and will take precedence over event id.
        /// </summary>
        /// <value>The flowfile uuid that was used to generate the lineage. The flowfile uuid is only allowed when the lineageRequestType is FLOWFILE and will take precedence over event id.</value>
        [DataMember(Name="uuid", EmitDefaultValue=false)]
        public string Uuid { get; set; }

        /// <summary>
        /// The id of the node where this lineage originated if clustered.
        /// </summary>
        /// <value>The id of the node where this lineage originated if clustered.</value>
        [DataMember(Name="clusterNodeId", EmitDefaultValue=false)]
        public string ClusterNodeId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LineageRequestDTO {\n");
            sb.Append("  EventId: ").Append(this.EventId).Append("\n");
            sb.Append("  LineageRequestType: ").Append(this.LineageRequestType).Append("\n");
            sb.Append("  Uuid: ").Append(this.Uuid).Append("\n");
            sb.Append("  ClusterNodeId: ").Append(this.ClusterNodeId).Append("\n");
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
            return this.Equals(input as LineageRequestDTO);
        }

        /// <summary>
        /// Returns true if LineageRequestDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of LineageRequestDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LineageRequestDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EventId == input.EventId ||
                    (this.EventId != null &&
                    this.EventId.Equals(input.EventId))
                ) && 
                (
                    this.LineageRequestType == input.LineageRequestType ||
                    (this.LineageRequestType != null &&
                    this.LineageRequestType.Equals(input.LineageRequestType))
                ) && 
                (
                    this.Uuid == input.Uuid ||
                    (this.Uuid != null &&
                    this.Uuid.Equals(input.Uuid))
                ) && 
                (
                    this.ClusterNodeId == input.ClusterNodeId ||
                    (this.ClusterNodeId != null &&
                    this.ClusterNodeId.Equals(input.ClusterNodeId))
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
                if (this.EventId != null)
                    hashCode = hashCode * 59 + this.EventId.GetHashCode();
                if (this.LineageRequestType != null)
                    hashCode = hashCode * 59 + this.LineageRequestType.GetHashCode();
                if (this.Uuid != null)
                    hashCode = hashCode * 59 + this.Uuid.GetHashCode();
                if (this.ClusterNodeId != null)
                    hashCode = hashCode * 59 + this.ClusterNodeId.GetHashCode();
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
