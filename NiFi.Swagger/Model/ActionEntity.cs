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
    /// ActionEntity
    /// </summary>
    [DataContract]
    public partial class ActionEntity :  IEquatable<ActionEntity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ActionEntity" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="timestamp">The timestamp of the action..</param>
        /// <param name="sourceId">sourceId.</param>
        /// <param name="action">action.</param>
        public ActionEntity(int? id = default(int?), string timestamp = default(string), string sourceId = default(string), ActionDTO action = default(ActionDTO))
        {
            this.Id = id;
            this.Timestamp = timestamp;
            this.SourceId = sourceId;
            this.Action = action;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// The timestamp of the action.
        /// </summary>
        /// <value>The timestamp of the action.</value>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public string Timestamp { get; set; }

        /// <summary>
        /// Gets or Sets SourceId
        /// </summary>
        [DataMember(Name="sourceId", EmitDefaultValue=false)]
        public string SourceId { get; set; }

        /// <summary>
        /// Indicates whether the user can read a given resource.
        /// </summary>
        /// <value>Indicates whether the user can read a given resource.</value>
        [DataMember(Name="canRead", EmitDefaultValue=false)]
        public bool? CanRead { get; private set; }

        /// <summary>
        /// Gets or Sets Action
        /// </summary>
        [DataMember(Name="action", EmitDefaultValue=false)]
        public ActionDTO Action { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ActionEntity {\n");
            sb.Append("  Id: ").Append(this.Id).Append("\n");
            sb.Append("  Timestamp: ").Append(this.Timestamp).Append("\n");
            sb.Append("  SourceId: ").Append(this.SourceId).Append("\n");
            sb.Append("  CanRead: ").Append(this.CanRead).Append("\n");
            sb.Append("  Action: ").Append(this.Action).Append("\n");
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
            return this.Equals(input as ActionEntity);
        }

        /// <summary>
        /// Returns true if ActionEntity instances are equal
        /// </summary>
        /// <param name="input">Instance of ActionEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ActionEntity input)
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
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
                ) && 
                (
                    this.SourceId == input.SourceId ||
                    (this.SourceId != null &&
                    this.SourceId.Equals(input.SourceId))
                ) && 
                (
                    this.CanRead == input.CanRead ||
                    (this.CanRead != null &&
                    this.CanRead.Equals(input.CanRead))
                ) && 
                (
                    this.Action == input.Action ||
                    (this.Action != null &&
                    this.Action.Equals(input.Action))
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
                if (this.Timestamp != null)
                    hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
                if (this.SourceId != null)
                    hashCode = hashCode * 59 + this.SourceId.GetHashCode();
                if (this.CanRead != null)
                    hashCode = hashCode * 59 + this.CanRead.GetHashCode();
                if (this.Action != null)
                    hashCode = hashCode * 59 + this.Action.GetHashCode();
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
