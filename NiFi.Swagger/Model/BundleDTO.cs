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
    /// BundleDTO
    /// </summary>
    [DataContract]
    public partial class BundleDTO :  IEquatable<BundleDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BundleDTO" /> class.
        /// </summary>
        /// <param name="group">The group of the bundle..</param>
        /// <param name="artifact">The artifact of the bundle..</param>
        /// <param name="version">The version of the bundle..</param>
        public BundleDTO(string group = default(string), string artifact = default(string), string version = default(string))
        {
            this.Group = group;
            this.Artifact = artifact;
            this.Version = version;
        }
        
        /// <summary>
        /// The group of the bundle.
        /// </summary>
        /// <value>The group of the bundle.</value>
        [DataMember(Name="group", EmitDefaultValue=false)]
        public string Group { get; set; }

        /// <summary>
        /// The artifact of the bundle.
        /// </summary>
        /// <value>The artifact of the bundle.</value>
        [DataMember(Name="artifact", EmitDefaultValue=false)]
        public string Artifact { get; set; }

        /// <summary>
        /// The version of the bundle.
        /// </summary>
        /// <value>The version of the bundle.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public string Version { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BundleDTO {\n");
            sb.Append("  Group: ").Append(this.Group).Append("\n");
            sb.Append("  Artifact: ").Append(this.Artifact).Append("\n");
            sb.Append("  Version: ").Append(this.Version).Append("\n");
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
            return this.Equals(input as BundleDTO);
        }

        /// <summary>
        /// Returns true if BundleDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of BundleDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BundleDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Group == input.Group ||
                    (this.Group != null &&
                    this.Group.Equals(input.Group))
                ) && 
                (
                    this.Artifact == input.Artifact ||
                    (this.Artifact != null &&
                    this.Artifact.Equals(input.Artifact))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
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
                if (this.Group != null)
                    hashCode = hashCode * 59 + this.Group.GetHashCode();
                if (this.Artifact != null)
                    hashCode = hashCode * 59 + this.Artifact.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
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
