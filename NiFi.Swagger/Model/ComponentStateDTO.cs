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
    /// ComponentStateDTO
    /// </summary>
    [DataContract]
    public partial class ComponentStateDTO :  IEquatable<ComponentStateDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ComponentStateDTO" /> class.
        /// </summary>
        /// <param name="componentId">The component identifier..</param>
        /// <param name="stateDescription">Description of the state this component persists..</param>
        /// <param name="clusterState">The cluster state for this component, or null if this NiFi is a standalone instance..</param>
        /// <param name="localState">The local state for this component..</param>
        public ComponentStateDTO(string componentId = default(string), string stateDescription = default(string), StateMapDTO clusterState = default(StateMapDTO), StateMapDTO localState = default(StateMapDTO))
        {
            this.ComponentId = componentId;
            this.StateDescription = stateDescription;
            this.ClusterState = clusterState;
            this.LocalState = localState;
        }
        
        /// <summary>
        /// The component identifier.
        /// </summary>
        /// <value>The component identifier.</value>
        [DataMember(Name="componentId", EmitDefaultValue=false)]
        public string ComponentId { get; set; }

        /// <summary>
        /// Description of the state this component persists.
        /// </summary>
        /// <value>Description of the state this component persists.</value>
        [DataMember(Name="stateDescription", EmitDefaultValue=false)]
        public string StateDescription { get; set; }

        /// <summary>
        /// The cluster state for this component, or null if this NiFi is a standalone instance.
        /// </summary>
        /// <value>The cluster state for this component, or null if this NiFi is a standalone instance.</value>
        [DataMember(Name="clusterState", EmitDefaultValue=false)]
        public StateMapDTO ClusterState { get; set; }

        /// <summary>
        /// The local state for this component.
        /// </summary>
        /// <value>The local state for this component.</value>
        [DataMember(Name="localState", EmitDefaultValue=false)]
        public StateMapDTO LocalState { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ComponentStateDTO {\n");
            sb.Append("  ComponentId: ").Append(this.ComponentId).Append("\n");
            sb.Append("  StateDescription: ").Append(this.StateDescription).Append("\n");
            sb.Append("  ClusterState: ").Append(this.ClusterState).Append("\n");
            sb.Append("  LocalState: ").Append(this.LocalState).Append("\n");
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
            return this.Equals(input as ComponentStateDTO);
        }

        /// <summary>
        /// Returns true if ComponentStateDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of ComponentStateDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ComponentStateDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ComponentId == input.ComponentId ||
                    (this.ComponentId != null &&
                    this.ComponentId.Equals(input.ComponentId))
                ) && 
                (
                    this.StateDescription == input.StateDescription ||
                    (this.StateDescription != null &&
                    this.StateDescription.Equals(input.StateDescription))
                ) && 
                (
                    this.ClusterState == input.ClusterState ||
                    (this.ClusterState != null &&
                    this.ClusterState.Equals(input.ClusterState))
                ) && 
                (
                    this.LocalState == input.LocalState ||
                    (this.LocalState != null &&
                    this.LocalState.Equals(input.LocalState))
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
                if (this.ComponentId != null)
                    hashCode = hashCode * 59 + this.ComponentId.GetHashCode();
                if (this.StateDescription != null)
                    hashCode = hashCode * 59 + this.StateDescription.GetHashCode();
                if (this.ClusterState != null)
                    hashCode = hashCode * 59 + this.ClusterState.GetHashCode();
                if (this.LocalState != null)
                    hashCode = hashCode * 59 + this.LocalState.GetHashCode();
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
