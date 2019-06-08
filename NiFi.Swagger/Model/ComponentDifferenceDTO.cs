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
    /// ComponentDifferenceDTO
    /// </summary>
    [DataContract]
    public partial class ComponentDifferenceDTO :  IEquatable<ComponentDifferenceDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ComponentDifferenceDTO" /> class.
        /// </summary>
        /// <param name="componentType">The type of component.</param>
        /// <param name="componentId">The ID of the component.</param>
        /// <param name="componentName">The name of the component.</param>
        /// <param name="processGroupId">The ID of the Process Group that the component belongs to.</param>
        /// <param name="differences">The differences in the component between the two flows.</param>
        public ComponentDifferenceDTO(string componentType = default(string), string componentId = default(string), string componentName = default(string), string processGroupId = default(string), List<DifferenceDTO> differences = default(List<DifferenceDTO>))
        {
            this.ComponentType = componentType;
            this.ComponentId = componentId;
            this.ComponentName = componentName;
            this.ProcessGroupId = processGroupId;
            this.Differences = differences;
        }
        
        /// <summary>
        /// The type of component
        /// </summary>
        /// <value>The type of component</value>
        [DataMember(Name="componentType", EmitDefaultValue=false)]
        public string ComponentType { get; set; }

        /// <summary>
        /// The ID of the component
        /// </summary>
        /// <value>The ID of the component</value>
        [DataMember(Name="componentId", EmitDefaultValue=false)]
        public string ComponentId { get; set; }

        /// <summary>
        /// The name of the component
        /// </summary>
        /// <value>The name of the component</value>
        [DataMember(Name="componentName", EmitDefaultValue=false)]
        public string ComponentName { get; set; }

        /// <summary>
        /// The ID of the Process Group that the component belongs to
        /// </summary>
        /// <value>The ID of the Process Group that the component belongs to</value>
        [DataMember(Name="processGroupId", EmitDefaultValue=false)]
        public string ProcessGroupId { get; set; }

        /// <summary>
        /// The differences in the component between the two flows
        /// </summary>
        /// <value>The differences in the component between the two flows</value>
        [DataMember(Name="differences", EmitDefaultValue=false)]
        public List<DifferenceDTO> Differences { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ComponentDifferenceDTO {\n");
            sb.Append("  ComponentType: ").Append(this.ComponentType).Append("\n");
            sb.Append("  ComponentId: ").Append(this.ComponentId).Append("\n");
            sb.Append("  ComponentName: ").Append(this.ComponentName).Append("\n");
            sb.Append("  ProcessGroupId: ").Append(this.ProcessGroupId).Append("\n");
            sb.Append("  Differences: ").Append(this.Differences).Append("\n");
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
            return this.Equals(input as ComponentDifferenceDTO);
        }

        /// <summary>
        /// Returns true if ComponentDifferenceDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of ComponentDifferenceDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ComponentDifferenceDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ComponentType == input.ComponentType ||
                    (this.ComponentType != null &&
                    this.ComponentType.Equals(input.ComponentType))
                ) && 
                (
                    this.ComponentId == input.ComponentId ||
                    (this.ComponentId != null &&
                    this.ComponentId.Equals(input.ComponentId))
                ) && 
                (
                    this.ComponentName == input.ComponentName ||
                    (this.ComponentName != null &&
                    this.ComponentName.Equals(input.ComponentName))
                ) && 
                (
                    this.ProcessGroupId == input.ProcessGroupId ||
                    (this.ProcessGroupId != null &&
                    this.ProcessGroupId.Equals(input.ProcessGroupId))
                ) && 
                (
                    this.Differences == input.Differences ||
                    this.Differences != null &&
                    this.Differences.SequenceEqual(input.Differences)
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
                if (this.ComponentType != null)
                    hashCode = hashCode * 59 + this.ComponentType.GetHashCode();
                if (this.ComponentId != null)
                    hashCode = hashCode * 59 + this.ComponentId.GetHashCode();
                if (this.ComponentName != null)
                    hashCode = hashCode * 59 + this.ComponentName.GetHashCode();
                if (this.ProcessGroupId != null)
                    hashCode = hashCode * 59 + this.ProcessGroupId.GetHashCode();
                if (this.Differences != null)
                    hashCode = hashCode * 59 + this.Differences.GetHashCode();
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
