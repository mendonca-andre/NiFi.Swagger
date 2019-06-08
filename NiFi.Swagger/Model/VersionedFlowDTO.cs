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
    /// VersionedFlowDTO
    /// </summary>
    [DataContract]
    public partial class VersionedFlowDTO :  IEquatable<VersionedFlowDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VersionedFlowDTO" /> class.
        /// </summary>
        /// <param name="registryId">The ID of the registry that the flow is tracked to.</param>
        /// <param name="bucketId">The ID of the bucket where the flow is stored.</param>
        /// <param name="flowId">The ID of the flow.</param>
        /// <param name="flowName">The name of the flow.</param>
        /// <param name="description">A description of the flow.</param>
        /// <param name="comments">Comments for the changeset.</param>
        public VersionedFlowDTO(string registryId = default(string), string bucketId = default(string), string flowId = default(string), string flowName = default(string), string description = default(string), string comments = default(string))
        {
            this.RegistryId = registryId;
            this.BucketId = bucketId;
            this.FlowId = flowId;
            this.FlowName = flowName;
            this.Description = description;
            this.Comments = comments;
        }
        
        /// <summary>
        /// The ID of the registry that the flow is tracked to
        /// </summary>
        /// <value>The ID of the registry that the flow is tracked to</value>
        [DataMember(Name="registryId", EmitDefaultValue=false)]
        public string RegistryId { get; set; }

        /// <summary>
        /// The ID of the bucket where the flow is stored
        /// </summary>
        /// <value>The ID of the bucket where the flow is stored</value>
        [DataMember(Name="bucketId", EmitDefaultValue=false)]
        public string BucketId { get; set; }

        /// <summary>
        /// The ID of the flow
        /// </summary>
        /// <value>The ID of the flow</value>
        [DataMember(Name="flowId", EmitDefaultValue=false)]
        public string FlowId { get; set; }

        /// <summary>
        /// The name of the flow
        /// </summary>
        /// <value>The name of the flow</value>
        [DataMember(Name="flowName", EmitDefaultValue=false)]
        public string FlowName { get; set; }

        /// <summary>
        /// A description of the flow
        /// </summary>
        /// <value>A description of the flow</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Comments for the changeset
        /// </summary>
        /// <value>Comments for the changeset</value>
        [DataMember(Name="comments", EmitDefaultValue=false)]
        public string Comments { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VersionedFlowDTO {\n");
            sb.Append("  RegistryId: ").Append(this.RegistryId).Append("\n");
            sb.Append("  BucketId: ").Append(this.BucketId).Append("\n");
            sb.Append("  FlowId: ").Append(this.FlowId).Append("\n");
            sb.Append("  FlowName: ").Append(this.FlowName).Append("\n");
            sb.Append("  Description: ").Append(this.Description).Append("\n");
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
            return this.Equals(input as VersionedFlowDTO);
        }

        /// <summary>
        /// Returns true if VersionedFlowDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of VersionedFlowDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VersionedFlowDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RegistryId == input.RegistryId ||
                    (this.RegistryId != null &&
                    this.RegistryId.Equals(input.RegistryId))
                ) && 
                (
                    this.BucketId == input.BucketId ||
                    (this.BucketId != null &&
                    this.BucketId.Equals(input.BucketId))
                ) && 
                (
                    this.FlowId == input.FlowId ||
                    (this.FlowId != null &&
                    this.FlowId.Equals(input.FlowId))
                ) && 
                (
                    this.FlowName == input.FlowName ||
                    (this.FlowName != null &&
                    this.FlowName.Equals(input.FlowName))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
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
                if (this.RegistryId != null)
                    hashCode = hashCode * 59 + this.RegistryId.GetHashCode();
                if (this.BucketId != null)
                    hashCode = hashCode * 59 + this.BucketId.GetHashCode();
                if (this.FlowId != null)
                    hashCode = hashCode * 59 + this.FlowId.GetHashCode();
                if (this.FlowName != null)
                    hashCode = hashCode * 59 + this.FlowName.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
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