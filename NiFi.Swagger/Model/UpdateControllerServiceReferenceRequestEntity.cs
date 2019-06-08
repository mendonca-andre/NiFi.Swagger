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
    using System.Linq;
    using System.Runtime.Serialization;
    using System.Text;

    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// UpdateControllerServiceReferenceRequestEntity
    /// </summary>
    [DataContract]
    public partial class UpdateControllerServiceReferenceRequestEntity :  IEquatable<UpdateControllerServiceReferenceRequestEntity>, IValidatableObject
    {
        /// <summary>
        /// The new state of the references for the controller service.
        /// </summary>
        /// <value>The new state of the references for the controller service.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StateEnum
        {
            
            /// <summary>
            /// Enum ENABLED for value: ENABLED
            /// </summary>
            [EnumMember(Value = "ENABLED")]
            ENABLED = 1,
            
            /// <summary>
            /// Enum DISABLED for value: DISABLED
            /// </summary>
            [EnumMember(Value = "DISABLED")]
            DISABLED = 2,
            
            /// <summary>
            /// Enum RUNNING for value: RUNNING
            /// </summary>
            [EnumMember(Value = "RUNNING")]
            RUNNING = 3,
            
            /// <summary>
            /// Enum STOPPED for value: STOPPED
            /// </summary>
            [EnumMember(Value = "STOPPED")]
            STOPPED = 4
        }

        /// <summary>
        /// The new state of the references for the controller service.
        /// </summary>
        /// <value>The new state of the references for the controller service.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateControllerServiceReferenceRequestEntity" /> class.
        /// </summary>
        /// <param name="id">The identifier of the Controller Service..</param>
        /// <param name="state">The new state of the references for the controller service..</param>
        /// <param name="referencingComponentRevisions">The revisions for all referencing components..</param>
        /// <param name="disconnectedNodeAcknowledged">Acknowledges that this node is disconnected to allow for mutable requests to proceed..</param>
        public UpdateControllerServiceReferenceRequestEntity(string id = default(string), StateEnum? state = default(StateEnum?), Dictionary<string, RevisionDTO> referencingComponentRevisions = default(Dictionary<string, RevisionDTO>), bool? disconnectedNodeAcknowledged = default(bool?))
        {
            this.Id = id;
            this.State = state;
            this.ReferencingComponentRevisions = referencingComponentRevisions;
            this.DisconnectedNodeAcknowledged = disconnectedNodeAcknowledged;
        }
        
        /// <summary>
        /// The identifier of the Controller Service.
        /// </summary>
        /// <value>The identifier of the Controller Service.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }


        /// <summary>
        /// The revisions for all referencing components.
        /// </summary>
        /// <value>The revisions for all referencing components.</value>
        [DataMember(Name="referencingComponentRevisions", EmitDefaultValue=false)]
        public Dictionary<string, RevisionDTO> ReferencingComponentRevisions { get; set; }

        /// <summary>
        /// Acknowledges that this node is disconnected to allow for mutable requests to proceed.
        /// </summary>
        /// <value>Acknowledges that this node is disconnected to allow for mutable requests to proceed.</value>
        [DataMember(Name="disconnectedNodeAcknowledged", EmitDefaultValue=false)]
        public bool? DisconnectedNodeAcknowledged { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateControllerServiceReferenceRequestEntity {\n");
            sb.Append("  Id: ").Append(this.Id).Append("\n");
            sb.Append("  State: ").Append(this.State).Append("\n");
            sb.Append("  ReferencingComponentRevisions: ").Append(this.ReferencingComponentRevisions).Append("\n");
            sb.Append("  DisconnectedNodeAcknowledged: ").Append(this.DisconnectedNodeAcknowledged).Append("\n");
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
            return this.Equals(input as UpdateControllerServiceReferenceRequestEntity);
        }

        /// <summary>
        /// Returns true if UpdateControllerServiceReferenceRequestEntity instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateControllerServiceReferenceRequestEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateControllerServiceReferenceRequestEntity input)
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
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.ReferencingComponentRevisions == input.ReferencingComponentRevisions ||
                    this.ReferencingComponentRevisions != null &&
                    this.ReferencingComponentRevisions.SequenceEqual(input.ReferencingComponentRevisions)
                ) && 
                (
                    this.DisconnectedNodeAcknowledged == input.DisconnectedNodeAcknowledged ||
                    (this.DisconnectedNodeAcknowledged != null &&
                    this.DisconnectedNodeAcknowledged.Equals(input.DisconnectedNodeAcknowledged))
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
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.ReferencingComponentRevisions != null)
                    hashCode = hashCode * 59 + this.ReferencingComponentRevisions.GetHashCode();
                if (this.DisconnectedNodeAcknowledged != null)
                    hashCode = hashCode * 59 + this.DisconnectedNodeAcknowledged.GetHashCode();
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