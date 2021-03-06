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
    /// VersionedFlowUpdateRequestEntity
    /// </summary>
    [DataContract]
    public partial class VersionedFlowUpdateRequestEntity :  IEquatable<VersionedFlowUpdateRequestEntity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VersionedFlowUpdateRequestEntity" /> class.
        /// </summary>
        /// <param name="request">The Versioned Flow Update Request.</param>
        /// <param name="processGroupRevision">The revision for the Process Group that owns this variable registry..</param>
        public VersionedFlowUpdateRequestEntity(VersionedFlowUpdateRequestDTO request = default(VersionedFlowUpdateRequestDTO), RevisionDTO processGroupRevision = default(RevisionDTO))
        {
            this.Request = request;
            this.ProcessGroupRevision = processGroupRevision;
        }
        
        /// <summary>
        /// The Versioned Flow Update Request
        /// </summary>
        /// <value>The Versioned Flow Update Request</value>
        [DataMember(Name="request", EmitDefaultValue=false)]
        public VersionedFlowUpdateRequestDTO Request { get; set; }

        /// <summary>
        /// The revision for the Process Group that owns this variable registry.
        /// </summary>
        /// <value>The revision for the Process Group that owns this variable registry.</value>
        [DataMember(Name="processGroupRevision", EmitDefaultValue=false)]
        public RevisionDTO ProcessGroupRevision { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VersionedFlowUpdateRequestEntity {\n");
            sb.Append("  Request: ").Append(this.Request).Append("\n");
            sb.Append("  ProcessGroupRevision: ").Append(this.ProcessGroupRevision).Append("\n");
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
            return this.Equals(input as VersionedFlowUpdateRequestEntity);
        }

        /// <summary>
        /// Returns true if VersionedFlowUpdateRequestEntity instances are equal
        /// </summary>
        /// <param name="input">Instance of VersionedFlowUpdateRequestEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VersionedFlowUpdateRequestEntity input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Request == input.Request ||
                    (this.Request != null &&
                    this.Request.Equals(input.Request))
                ) && 
                (
                    this.ProcessGroupRevision == input.ProcessGroupRevision ||
                    (this.ProcessGroupRevision != null &&
                    this.ProcessGroupRevision.Equals(input.ProcessGroupRevision))
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
                if (this.Request != null)
                    hashCode = hashCode * 59 + this.Request.GetHashCode();
                if (this.ProcessGroupRevision != null)
                    hashCode = hashCode * 59 + this.ProcessGroupRevision.GetHashCode();
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
