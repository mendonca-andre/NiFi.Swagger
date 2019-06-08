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
    /// PeerDTO
    /// </summary>
    [DataContract]
    public partial class PeerDTO :  IEquatable<PeerDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PeerDTO" /> class.
        /// </summary>
        /// <param name="hostname">The hostname of this peer..</param>
        /// <param name="port">The port number of this peer..</param>
        /// <param name="secure">Returns if this peer connection is secure..</param>
        /// <param name="flowFileCount">The number of flowFiles this peer holds..</param>
        public PeerDTO(string hostname = default(string), int? port = default(int?), bool? secure = default(bool?), int? flowFileCount = default(int?))
        {
            this.Hostname = hostname;
            this.Port = port;
            this.Secure = secure;
            this.FlowFileCount = flowFileCount;
        }
        
        /// <summary>
        /// The hostname of this peer.
        /// </summary>
        /// <value>The hostname of this peer.</value>
        [DataMember(Name="hostname", EmitDefaultValue=false)]
        public string Hostname { get; set; }

        /// <summary>
        /// The port number of this peer.
        /// </summary>
        /// <value>The port number of this peer.</value>
        [DataMember(Name="port", EmitDefaultValue=false)]
        public int? Port { get; set; }

        /// <summary>
        /// Returns if this peer connection is secure.
        /// </summary>
        /// <value>Returns if this peer connection is secure.</value>
        [DataMember(Name="secure", EmitDefaultValue=false)]
        public bool? Secure { get; set; }

        /// <summary>
        /// The number of flowFiles this peer holds.
        /// </summary>
        /// <value>The number of flowFiles this peer holds.</value>
        [DataMember(Name="flowFileCount", EmitDefaultValue=false)]
        public int? FlowFileCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PeerDTO {\n");
            sb.Append("  Hostname: ").Append(this.Hostname).Append("\n");
            sb.Append("  Port: ").Append(this.Port).Append("\n");
            sb.Append("  Secure: ").Append(this.Secure).Append("\n");
            sb.Append("  FlowFileCount: ").Append(this.FlowFileCount).Append("\n");
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
            return this.Equals(input as PeerDTO);
        }

        /// <summary>
        /// Returns true if PeerDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of PeerDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PeerDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Hostname == input.Hostname ||
                    (this.Hostname != null &&
                    this.Hostname.Equals(input.Hostname))
                ) && 
                (
                    this.Port == input.Port ||
                    (this.Port != null &&
                    this.Port.Equals(input.Port))
                ) && 
                (
                    this.Secure == input.Secure ||
                    (this.Secure != null &&
                    this.Secure.Equals(input.Secure))
                ) && 
                (
                    this.FlowFileCount == input.FlowFileCount ||
                    (this.FlowFileCount != null &&
                    this.FlowFileCount.Equals(input.FlowFileCount))
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
                if (this.Hostname != null)
                    hashCode = hashCode * 59 + this.Hostname.GetHashCode();
                if (this.Port != null)
                    hashCode = hashCode * 59 + this.Port.GetHashCode();
                if (this.Secure != null)
                    hashCode = hashCode * 59 + this.Secure.GetHashCode();
                if (this.FlowFileCount != null)
                    hashCode = hashCode * 59 + this.FlowFileCount.GetHashCode();
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
