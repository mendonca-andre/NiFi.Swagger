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

    /// <summary>
    /// SubmitReplayRequestEntity
    /// </summary>
    [DataContract]
    public partial class SubmitReplayRequestEntity :  IEquatable<SubmitReplayRequestEntity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitReplayRequestEntity" /> class.
        /// </summary>
        /// <param name="eventId">The event identifier.</param>
        /// <param name="clusterNodeId">The identifier of the node where to submit the replay request..</param>
        public SubmitReplayRequestEntity(long? eventId = default(long?), string clusterNodeId = default(string))
        {
            this.EventId = eventId;
            this.ClusterNodeId = clusterNodeId;
        }
        
        /// <summary>
        /// The event identifier
        /// </summary>
        /// <value>The event identifier</value>
        [DataMember(Name="eventId", EmitDefaultValue=false)]
        public long? EventId { get; set; }

        /// <summary>
        /// The identifier of the node where to submit the replay request.
        /// </summary>
        /// <value>The identifier of the node where to submit the replay request.</value>
        [DataMember(Name="clusterNodeId", EmitDefaultValue=false)]
        public string ClusterNodeId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubmitReplayRequestEntity {\n");
            sb.Append("  EventId: ").Append(this.EventId).Append("\n");
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
            return this.Equals(input as SubmitReplayRequestEntity);
        }

        /// <summary>
        /// Returns true if SubmitReplayRequestEntity instances are equal
        /// </summary>
        /// <param name="input">Instance of SubmitReplayRequestEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubmitReplayRequestEntity input)
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
