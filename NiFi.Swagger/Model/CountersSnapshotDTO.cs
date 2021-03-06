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

    /// <summary>
    /// CountersSnapshotDTO
    /// </summary>
    [DataContract]
    public partial class CountersSnapshotDTO :  IEquatable<CountersSnapshotDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CountersSnapshotDTO" /> class.
        /// </summary>
        /// <param name="generated">The timestamp when the report was generated..</param>
        /// <param name="counters">All counters in the NiFi..</param>
        public CountersSnapshotDTO(string generated = default(string), List<CounterDTO> counters = default(List<CounterDTO>))
        {
            this.Generated = generated;
            this.Counters = counters;
        }
        
        /// <summary>
        /// The timestamp when the report was generated.
        /// </summary>
        /// <value>The timestamp when the report was generated.</value>
        [DataMember(Name="generated", EmitDefaultValue=false)]
        public string Generated { get; set; }

        /// <summary>
        /// All counters in the NiFi.
        /// </summary>
        /// <value>All counters in the NiFi.</value>
        [DataMember(Name="counters", EmitDefaultValue=false)]
        public List<CounterDTO> Counters { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CountersSnapshotDTO {\n");
            sb.Append("  Generated: ").Append(this.Generated).Append("\n");
            sb.Append("  Counters: ").Append(this.Counters).Append("\n");
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
            return this.Equals(input as CountersSnapshotDTO);
        }

        /// <summary>
        /// Returns true if CountersSnapshotDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of CountersSnapshotDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CountersSnapshotDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Generated == input.Generated ||
                    (this.Generated != null &&
                    this.Generated.Equals(input.Generated))
                ) && 
                (
                    this.Counters == input.Counters ||
                    this.Counters != null &&
                    this.Counters.SequenceEqual(input.Counters)
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
                if (this.Generated != null)
                    hashCode = hashCode * 59 + this.Generated.GetHashCode();
                if (this.Counters != null)
                    hashCode = hashCode * 59 + this.Counters.GetHashCode();
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
