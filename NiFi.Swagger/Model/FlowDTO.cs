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
    /// FlowDTO
    /// </summary>
    [DataContract]
    public partial class FlowDTO :  IEquatable<FlowDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FlowDTO" /> class.
        /// </summary>
        /// <param name="processGroups">The process groups in this flow..</param>
        /// <param name="remoteProcessGroups">The remote process groups in this flow..</param>
        /// <param name="processors">The processors in this flow..</param>
        /// <param name="inputPorts">The input ports in this flow..</param>
        /// <param name="outputPorts">The output ports in this flow..</param>
        /// <param name="connections">The connections in this flow..</param>
        /// <param name="labels">The labels in this flow..</param>
        /// <param name="funnels">The funnels in this flow..</param>
        public FlowDTO(List<ProcessGroupEntity> processGroups = default(List<ProcessGroupEntity>), List<RemoteProcessGroupEntity> remoteProcessGroups = default(List<RemoteProcessGroupEntity>), List<ProcessorEntity> processors = default(List<ProcessorEntity>), List<PortEntity> inputPorts = default(List<PortEntity>), List<PortEntity> outputPorts = default(List<PortEntity>), List<ConnectionEntity> connections = default(List<ConnectionEntity>), List<LabelEntity> labels = default(List<LabelEntity>), List<FunnelEntity> funnels = default(List<FunnelEntity>))
        {
            this.ProcessGroups = processGroups;
            this.RemoteProcessGroups = remoteProcessGroups;
            this.Processors = processors;
            this.InputPorts = inputPorts;
            this.OutputPorts = outputPorts;
            this.Connections = connections;
            this.Labels = labels;
            this.Funnels = funnels;
        }
        
        /// <summary>
        /// The process groups in this flow.
        /// </summary>
        /// <value>The process groups in this flow.</value>
        [DataMember(Name="processGroups", EmitDefaultValue=false)]
        public List<ProcessGroupEntity> ProcessGroups { get; set; }

        /// <summary>
        /// The remote process groups in this flow.
        /// </summary>
        /// <value>The remote process groups in this flow.</value>
        [DataMember(Name="remoteProcessGroups", EmitDefaultValue=false)]
        public List<RemoteProcessGroupEntity> RemoteProcessGroups { get; set; }

        /// <summary>
        /// The processors in this flow.
        /// </summary>
        /// <value>The processors in this flow.</value>
        [DataMember(Name="processors", EmitDefaultValue=false)]
        public List<ProcessorEntity> Processors { get; set; }

        /// <summary>
        /// The input ports in this flow.
        /// </summary>
        /// <value>The input ports in this flow.</value>
        [DataMember(Name="inputPorts", EmitDefaultValue=false)]
        public List<PortEntity> InputPorts { get; set; }

        /// <summary>
        /// The output ports in this flow.
        /// </summary>
        /// <value>The output ports in this flow.</value>
        [DataMember(Name="outputPorts", EmitDefaultValue=false)]
        public List<PortEntity> OutputPorts { get; set; }

        /// <summary>
        /// The connections in this flow.
        /// </summary>
        /// <value>The connections in this flow.</value>
        [DataMember(Name="connections", EmitDefaultValue=false)]
        public List<ConnectionEntity> Connections { get; set; }

        /// <summary>
        /// The labels in this flow.
        /// </summary>
        /// <value>The labels in this flow.</value>
        [DataMember(Name="labels", EmitDefaultValue=false)]
        public List<LabelEntity> Labels { get; set; }

        /// <summary>
        /// The funnels in this flow.
        /// </summary>
        /// <value>The funnels in this flow.</value>
        [DataMember(Name="funnels", EmitDefaultValue=false)]
        public List<FunnelEntity> Funnels { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FlowDTO {\n");
            sb.Append("  ProcessGroups: ").Append(this.ProcessGroups).Append("\n");
            sb.Append("  RemoteProcessGroups: ").Append(this.RemoteProcessGroups).Append("\n");
            sb.Append("  Processors: ").Append(this.Processors).Append("\n");
            sb.Append("  InputPorts: ").Append(this.InputPorts).Append("\n");
            sb.Append("  OutputPorts: ").Append(this.OutputPorts).Append("\n");
            sb.Append("  Connections: ").Append(this.Connections).Append("\n");
            sb.Append("  Labels: ").Append(this.Labels).Append("\n");
            sb.Append("  Funnels: ").Append(this.Funnels).Append("\n");
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
            return this.Equals(input as FlowDTO);
        }

        /// <summary>
        /// Returns true if FlowDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of FlowDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FlowDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProcessGroups == input.ProcessGroups ||
                    this.ProcessGroups != null &&
                    this.ProcessGroups.SequenceEqual(input.ProcessGroups)
                ) && 
                (
                    this.RemoteProcessGroups == input.RemoteProcessGroups ||
                    this.RemoteProcessGroups != null &&
                    this.RemoteProcessGroups.SequenceEqual(input.RemoteProcessGroups)
                ) && 
                (
                    this.Processors == input.Processors ||
                    this.Processors != null &&
                    this.Processors.SequenceEqual(input.Processors)
                ) && 
                (
                    this.InputPorts == input.InputPorts ||
                    this.InputPorts != null &&
                    this.InputPorts.SequenceEqual(input.InputPorts)
                ) && 
                (
                    this.OutputPorts == input.OutputPorts ||
                    this.OutputPorts != null &&
                    this.OutputPorts.SequenceEqual(input.OutputPorts)
                ) && 
                (
                    this.Connections == input.Connections ||
                    this.Connections != null &&
                    this.Connections.SequenceEqual(input.Connections)
                ) && 
                (
                    this.Labels == input.Labels ||
                    this.Labels != null &&
                    this.Labels.SequenceEqual(input.Labels)
                ) && 
                (
                    this.Funnels == input.Funnels ||
                    this.Funnels != null &&
                    this.Funnels.SequenceEqual(input.Funnels)
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
                if (this.ProcessGroups != null)
                    hashCode = hashCode * 59 + this.ProcessGroups.GetHashCode();
                if (this.RemoteProcessGroups != null)
                    hashCode = hashCode * 59 + this.RemoteProcessGroups.GetHashCode();
                if (this.Processors != null)
                    hashCode = hashCode * 59 + this.Processors.GetHashCode();
                if (this.InputPorts != null)
                    hashCode = hashCode * 59 + this.InputPorts.GetHashCode();
                if (this.OutputPorts != null)
                    hashCode = hashCode * 59 + this.OutputPorts.GetHashCode();
                if (this.Connections != null)
                    hashCode = hashCode * 59 + this.Connections.GetHashCode();
                if (this.Labels != null)
                    hashCode = hashCode * 59 + this.Labels.GetHashCode();
                if (this.Funnels != null)
                    hashCode = hashCode * 59 + this.Funnels.GetHashCode();
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
