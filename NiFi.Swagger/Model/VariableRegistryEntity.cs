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
    /// VariableRegistryEntity
    /// </summary>
    [DataContract]
    public partial class VariableRegistryEntity :  IEquatable<VariableRegistryEntity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VariableRegistryEntity" /> class.
        /// </summary>
        /// <param name="processGroupRevision">The revision of the Process Group that the Variable Registry belongs to.</param>
        /// <param name="variableRegistry">The Variable Registry..</param>
        /// <param name="disconnectedNodeAcknowledged">Acknowledges that this node is disconnected to allow for mutable requests to proceed..</param>
        public VariableRegistryEntity(RevisionDTO processGroupRevision = default(RevisionDTO), VariableRegistryDTO variableRegistry = default(VariableRegistryDTO), bool? disconnectedNodeAcknowledged = default(bool?))
        {
            this.ProcessGroupRevision = processGroupRevision;
            this.VariableRegistry = variableRegistry;
            this.DisconnectedNodeAcknowledged = disconnectedNodeAcknowledged;
        }
        
        /// <summary>
        /// The revision of the Process Group that the Variable Registry belongs to
        /// </summary>
        /// <value>The revision of the Process Group that the Variable Registry belongs to</value>
        [DataMember(Name="processGroupRevision", EmitDefaultValue=false)]
        public RevisionDTO ProcessGroupRevision { get; set; }

        /// <summary>
        /// The Variable Registry.
        /// </summary>
        /// <value>The Variable Registry.</value>
        [DataMember(Name="variableRegistry", EmitDefaultValue=false)]
        public VariableRegistryDTO VariableRegistry { get; set; }

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
            sb.Append("class VariableRegistryEntity {\n");
            sb.Append("  ProcessGroupRevision: ").Append(this.ProcessGroupRevision).Append("\n");
            sb.Append("  VariableRegistry: ").Append(this.VariableRegistry).Append("\n");
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
            return this.Equals(input as VariableRegistryEntity);
        }

        /// <summary>
        /// Returns true if VariableRegistryEntity instances are equal
        /// </summary>
        /// <param name="input">Instance of VariableRegistryEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VariableRegistryEntity input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProcessGroupRevision == input.ProcessGroupRevision ||
                    (this.ProcessGroupRevision != null &&
                    this.ProcessGroupRevision.Equals(input.ProcessGroupRevision))
                ) && 
                (
                    this.VariableRegistry == input.VariableRegistry ||
                    (this.VariableRegistry != null &&
                    this.VariableRegistry.Equals(input.VariableRegistry))
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
                if (this.ProcessGroupRevision != null)
                    hashCode = hashCode * 59 + this.ProcessGroupRevision.GetHashCode();
                if (this.VariableRegistry != null)
                    hashCode = hashCode * 59 + this.VariableRegistry.GetHashCode();
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
