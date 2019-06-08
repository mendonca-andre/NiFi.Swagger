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
    /// StateEntryDTO
    /// </summary>
    [DataContract]
    public partial class StateEntryDTO :  IEquatable<StateEntryDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StateEntryDTO" /> class.
        /// </summary>
        /// <param name="key">The key for this state..</param>
        /// <param name="value">The value for this state..</param>
        /// <param name="clusterNodeId">The identifier for the node where the state originated..</param>
        /// <param name="clusterNodeAddress">The label for the node where the state originated..</param>
        public StateEntryDTO(string key = default(string), string value = default(string), string clusterNodeId = default(string), string clusterNodeAddress = default(string))
        {
            this.Key = key;
            this.Value = value;
            this.ClusterNodeId = clusterNodeId;
            this.ClusterNodeAddress = clusterNodeAddress;
        }
        
        /// <summary>
        /// The key for this state.
        /// </summary>
        /// <value>The key for this state.</value>
        [DataMember(Name="key", EmitDefaultValue=false)]
        public string Key { get; set; }

        /// <summary>
        /// The value for this state.
        /// </summary>
        /// <value>The value for this state.</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }

        /// <summary>
        /// The identifier for the node where the state originated.
        /// </summary>
        /// <value>The identifier for the node where the state originated.</value>
        [DataMember(Name="clusterNodeId", EmitDefaultValue=false)]
        public string ClusterNodeId { get; set; }

        /// <summary>
        /// The label for the node where the state originated.
        /// </summary>
        /// <value>The label for the node where the state originated.</value>
        [DataMember(Name="clusterNodeAddress", EmitDefaultValue=false)]
        public string ClusterNodeAddress { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StateEntryDTO {\n");
            sb.Append("  Key: ").Append(this.Key).Append("\n");
            sb.Append("  Value: ").Append(this.Value).Append("\n");
            sb.Append("  ClusterNodeId: ").Append(this.ClusterNodeId).Append("\n");
            sb.Append("  ClusterNodeAddress: ").Append(this.ClusterNodeAddress).Append("\n");
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
            return this.Equals(input as StateEntryDTO);
        }

        /// <summary>
        /// Returns true if StateEntryDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of StateEntryDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StateEntryDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.ClusterNodeId == input.ClusterNodeId ||
                    (this.ClusterNodeId != null &&
                    this.ClusterNodeId.Equals(input.ClusterNodeId))
                ) && 
                (
                    this.ClusterNodeAddress == input.ClusterNodeAddress ||
                    (this.ClusterNodeAddress != null &&
                    this.ClusterNodeAddress.Equals(input.ClusterNodeAddress))
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
                if (this.Key != null)
                    hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.ClusterNodeId != null)
                    hashCode = hashCode * 59 + this.ClusterNodeId.GetHashCode();
                if (this.ClusterNodeAddress != null)
                    hashCode = hashCode * 59 + this.ClusterNodeAddress.GetHashCode();
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