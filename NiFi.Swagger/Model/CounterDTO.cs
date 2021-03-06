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
    /// CounterDTO
    /// </summary>
    [DataContract]
    public partial class CounterDTO :  IEquatable<CounterDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CounterDTO" /> class.
        /// </summary>
        /// <param name="id">The id of the counter..</param>
        /// <param name="context">The context of the counter..</param>
        /// <param name="name">The name of the counter..</param>
        /// <param name="valueCount">The value count..</param>
        /// <param name="value">The value of the counter..</param>
        public CounterDTO(string id = default(string), string context = default(string), string name = default(string), long? valueCount = default(long?), string value = default(string))
        {
            this.Id = id;
            this.Context = context;
            this.Name = name;
            this.ValueCount = valueCount;
            this.Value = value;
        }
        
        /// <summary>
        /// The id of the counter.
        /// </summary>
        /// <value>The id of the counter.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The context of the counter.
        /// </summary>
        /// <value>The context of the counter.</value>
        [DataMember(Name="context", EmitDefaultValue=false)]
        public string Context { get; set; }

        /// <summary>
        /// The name of the counter.
        /// </summary>
        /// <value>The name of the counter.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The value count.
        /// </summary>
        /// <value>The value count.</value>
        [DataMember(Name="valueCount", EmitDefaultValue=false)]
        public long? ValueCount { get; set; }

        /// <summary>
        /// The value of the counter.
        /// </summary>
        /// <value>The value of the counter.</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CounterDTO {\n");
            sb.Append("  Id: ").Append(this.Id).Append("\n");
            sb.Append("  Context: ").Append(this.Context).Append("\n");
            sb.Append("  Name: ").Append(this.Name).Append("\n");
            sb.Append("  ValueCount: ").Append(this.ValueCount).Append("\n");
            sb.Append("  Value: ").Append(this.Value).Append("\n");
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
            return this.Equals(input as CounterDTO);
        }

        /// <summary>
        /// Returns true if CounterDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of CounterDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CounterDTO input)
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
                    this.Context == input.Context ||
                    (this.Context != null &&
                    this.Context.Equals(input.Context))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ValueCount == input.ValueCount ||
                    (this.ValueCount != null &&
                    this.ValueCount.Equals(input.ValueCount))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                if (this.Context != null)
                    hashCode = hashCode * 59 + this.Context.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ValueCount != null)
                    hashCode = hashCode * 59 + this.ValueCount.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
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
