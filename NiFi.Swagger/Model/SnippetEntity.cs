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
    /// SnippetEntity
    /// </summary>
    [DataContract]
    public partial class SnippetEntity :  IEquatable<SnippetEntity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SnippetEntity" /> class.
        /// </summary>
        /// <param name="snippet">The snippet..</param>
        /// <param name="disconnectedNodeAcknowledged">Acknowledges that this node is disconnected to allow for mutable requests to proceed..</param>
        public SnippetEntity(SnippetDTO snippet = default(SnippetDTO), bool? disconnectedNodeAcknowledged = default(bool?))
        {
            this.Snippet = snippet;
            this.DisconnectedNodeAcknowledged = disconnectedNodeAcknowledged;
        }
        
        /// <summary>
        /// The snippet.
        /// </summary>
        /// <value>The snippet.</value>
        [DataMember(Name="snippet", EmitDefaultValue=false)]
        public SnippetDTO Snippet { get; set; }

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
            sb.Append("class SnippetEntity {\n");
            sb.Append("  Snippet: ").Append(this.Snippet).Append("\n");
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
            return this.Equals(input as SnippetEntity);
        }

        /// <summary>
        /// Returns true if SnippetEntity instances are equal
        /// </summary>
        /// <param name="input">Instance of SnippetEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SnippetEntity input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Snippet == input.Snippet ||
                    (this.Snippet != null &&
                    this.Snippet.Equals(input.Snippet))
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
                if (this.Snippet != null)
                    hashCode = hashCode * 59 + this.Snippet.GetHashCode();
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
