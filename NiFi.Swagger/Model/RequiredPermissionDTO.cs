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
    /// RequiredPermissionDTO
    /// </summary>
    [DataContract]
    public partial class RequiredPermissionDTO :  IEquatable<RequiredPermissionDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RequiredPermissionDTO" /> class.
        /// </summary>
        /// <param name="id">The required sub-permission necessary for this restriction..</param>
        /// <param name="label">The label for the required sub-permission necessary for this restriction..</param>
        public RequiredPermissionDTO(string id = default(string), string label = default(string))
        {
            this.Id = id;
            this.Label = label;
        }
        
        /// <summary>
        /// The required sub-permission necessary for this restriction.
        /// </summary>
        /// <value>The required sub-permission necessary for this restriction.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The label for the required sub-permission necessary for this restriction.
        /// </summary>
        /// <value>The label for the required sub-permission necessary for this restriction.</value>
        [DataMember(Name="label", EmitDefaultValue=false)]
        public string Label { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RequiredPermissionDTO {\n");
            sb.Append("  Id: ").Append(this.Id).Append("\n");
            sb.Append("  Label: ").Append(this.Label).Append("\n");
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
            return this.Equals(input as RequiredPermissionDTO);
        }

        /// <summary>
        /// Returns true if RequiredPermissionDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of RequiredPermissionDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RequiredPermissionDTO input)
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
                    this.Label == input.Label ||
                    (this.Label != null &&
                    this.Label.Equals(input.Label))
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
                if (this.Label != null)
                    hashCode = hashCode * 59 + this.Label.GetHashCode();
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
