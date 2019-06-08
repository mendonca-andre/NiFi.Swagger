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
    /// ControllerDTO
    /// </summary>
    [DataContract]
    public partial class ControllerDTO :  IEquatable<ControllerDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ControllerDTO" /> class.
        /// </summary>
        /// <param name="id">The id of the NiFi..</param>
        /// <param name="name">The name of the NiFi..</param>
        /// <param name="comments">The comments for the NiFi..</param>
        /// <param name="runningCount">The number of running components in the NiFi..</param>
        /// <param name="stoppedCount">The number of stopped components in the NiFi..</param>
        /// <param name="invalidCount">The number of invalid components in the NiFi..</param>
        /// <param name="disabledCount">The number of disabled components in the NiFi..</param>
        /// <param name="activeRemotePortCount">The number of active remote ports contained in the NiFi..</param>
        /// <param name="inactiveRemotePortCount">The number of inactive remote ports contained in the NiFi..</param>
        /// <param name="inputPortCount">The number of input ports contained in the NiFi..</param>
        /// <param name="outputPortCount">The number of output ports in the NiFi..</param>
        /// <param name="remoteSiteListeningPort">The Socket Port on which this instance is listening for Remote Transfers of Flow Files. If this instance is not configured to receive Flow Files from remote instances, this will be null..</param>
        /// <param name="remoteSiteHttpListeningPort">The HTTP(S) Port on which this instance is listening for Remote Transfers of Flow Files. If this instance is not configured to receive Flow Files from remote instances, this will be null..</param>
        /// <param name="siteToSiteSecure">Indicates whether or not Site-to-Site communications with this instance is secure (2-way authentication)..</param>
        /// <param name="instanceId">If clustered, the id of the Cluster Manager, otherwise the id of the NiFi..</param>
        /// <param name="inputPorts">The input ports available to send data to for the NiFi..</param>
        /// <param name="outputPorts">The output ports available to received data from the NiFi..</param>
        public ControllerDTO(string id = default(string), string name = default(string), string comments = default(string), int? runningCount = default(int?), int? stoppedCount = default(int?), int? invalidCount = default(int?), int? disabledCount = default(int?), int? activeRemotePortCount = default(int?), int? inactiveRemotePortCount = default(int?), int? inputPortCount = default(int?), int? outputPortCount = default(int?), int? remoteSiteListeningPort = default(int?), int? remoteSiteHttpListeningPort = default(int?), bool? siteToSiteSecure = default(bool?), string instanceId = default(string), List<PortDTO> inputPorts = default(List<PortDTO>), List<PortDTO> outputPorts = default(List<PortDTO>))
        {
            this.Id = id;
            this.Name = name;
            this.Comments = comments;
            this.RunningCount = runningCount;
            this.StoppedCount = stoppedCount;
            this.InvalidCount = invalidCount;
            this.DisabledCount = disabledCount;
            this.ActiveRemotePortCount = activeRemotePortCount;
            this.InactiveRemotePortCount = inactiveRemotePortCount;
            this.InputPortCount = inputPortCount;
            this.OutputPortCount = outputPortCount;
            this.RemoteSiteListeningPort = remoteSiteListeningPort;
            this.RemoteSiteHttpListeningPort = remoteSiteHttpListeningPort;
            this.SiteToSiteSecure = siteToSiteSecure;
            this.InstanceId = instanceId;
            this.InputPorts = inputPorts;
            this.OutputPorts = outputPorts;
        }
        
        /// <summary>
        /// The id of the NiFi.
        /// </summary>
        /// <value>The id of the NiFi.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The name of the NiFi.
        /// </summary>
        /// <value>The name of the NiFi.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The comments for the NiFi.
        /// </summary>
        /// <value>The comments for the NiFi.</value>
        [DataMember(Name="comments", EmitDefaultValue=false)]
        public string Comments { get; set; }

        /// <summary>
        /// The number of running components in the NiFi.
        /// </summary>
        /// <value>The number of running components in the NiFi.</value>
        [DataMember(Name="runningCount", EmitDefaultValue=false)]
        public int? RunningCount { get; set; }

        /// <summary>
        /// The number of stopped components in the NiFi.
        /// </summary>
        /// <value>The number of stopped components in the NiFi.</value>
        [DataMember(Name="stoppedCount", EmitDefaultValue=false)]
        public int? StoppedCount { get; set; }

        /// <summary>
        /// The number of invalid components in the NiFi.
        /// </summary>
        /// <value>The number of invalid components in the NiFi.</value>
        [DataMember(Name="invalidCount", EmitDefaultValue=false)]
        public int? InvalidCount { get; set; }

        /// <summary>
        /// The number of disabled components in the NiFi.
        /// </summary>
        /// <value>The number of disabled components in the NiFi.</value>
        [DataMember(Name="disabledCount", EmitDefaultValue=false)]
        public int? DisabledCount { get; set; }

        /// <summary>
        /// The number of active remote ports contained in the NiFi.
        /// </summary>
        /// <value>The number of active remote ports contained in the NiFi.</value>
        [DataMember(Name="activeRemotePortCount", EmitDefaultValue=false)]
        public int? ActiveRemotePortCount { get; set; }

        /// <summary>
        /// The number of inactive remote ports contained in the NiFi.
        /// </summary>
        /// <value>The number of inactive remote ports contained in the NiFi.</value>
        [DataMember(Name="inactiveRemotePortCount", EmitDefaultValue=false)]
        public int? InactiveRemotePortCount { get; set; }

        /// <summary>
        /// The number of input ports contained in the NiFi.
        /// </summary>
        /// <value>The number of input ports contained in the NiFi.</value>
        [DataMember(Name="inputPortCount", EmitDefaultValue=false)]
        public int? InputPortCount { get; set; }

        /// <summary>
        /// The number of output ports in the NiFi.
        /// </summary>
        /// <value>The number of output ports in the NiFi.</value>
        [DataMember(Name="outputPortCount", EmitDefaultValue=false)]
        public int? OutputPortCount { get; set; }

        /// <summary>
        /// The Socket Port on which this instance is listening for Remote Transfers of Flow Files. If this instance is not configured to receive Flow Files from remote instances, this will be null.
        /// </summary>
        /// <value>The Socket Port on which this instance is listening for Remote Transfers of Flow Files. If this instance is not configured to receive Flow Files from remote instances, this will be null.</value>
        [DataMember(Name="remoteSiteListeningPort", EmitDefaultValue=false)]
        public int? RemoteSiteListeningPort { get; set; }

        /// <summary>
        /// The HTTP(S) Port on which this instance is listening for Remote Transfers of Flow Files. If this instance is not configured to receive Flow Files from remote instances, this will be null.
        /// </summary>
        /// <value>The HTTP(S) Port on which this instance is listening for Remote Transfers of Flow Files. If this instance is not configured to receive Flow Files from remote instances, this will be null.</value>
        [DataMember(Name="remoteSiteHttpListeningPort", EmitDefaultValue=false)]
        public int? RemoteSiteHttpListeningPort { get; set; }

        /// <summary>
        /// Indicates whether or not Site-to-Site communications with this instance is secure (2-way authentication).
        /// </summary>
        /// <value>Indicates whether or not Site-to-Site communications with this instance is secure (2-way authentication).</value>
        [DataMember(Name="siteToSiteSecure", EmitDefaultValue=false)]
        public bool? SiteToSiteSecure { get; set; }

        /// <summary>
        /// If clustered, the id of the Cluster Manager, otherwise the id of the NiFi.
        /// </summary>
        /// <value>If clustered, the id of the Cluster Manager, otherwise the id of the NiFi.</value>
        [DataMember(Name="instanceId", EmitDefaultValue=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The input ports available to send data to for the NiFi.
        /// </summary>
        /// <value>The input ports available to send data to for the NiFi.</value>
        [DataMember(Name="inputPorts", EmitDefaultValue=false)]
        public List<PortDTO> InputPorts { get; set; }

        /// <summary>
        /// The output ports available to received data from the NiFi.
        /// </summary>
        /// <value>The output ports available to received data from the NiFi.</value>
        [DataMember(Name="outputPorts", EmitDefaultValue=false)]
        public List<PortDTO> OutputPorts { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ControllerDTO {\n");
            sb.Append("  Id: ").Append(this.Id).Append("\n");
            sb.Append("  Name: ").Append(this.Name).Append("\n");
            sb.Append("  Comments: ").Append(this.Comments).Append("\n");
            sb.Append("  RunningCount: ").Append(this.RunningCount).Append("\n");
            sb.Append("  StoppedCount: ").Append(this.StoppedCount).Append("\n");
            sb.Append("  InvalidCount: ").Append(this.InvalidCount).Append("\n");
            sb.Append("  DisabledCount: ").Append(this.DisabledCount).Append("\n");
            sb.Append("  ActiveRemotePortCount: ").Append(this.ActiveRemotePortCount).Append("\n");
            sb.Append("  InactiveRemotePortCount: ").Append(this.InactiveRemotePortCount).Append("\n");
            sb.Append("  InputPortCount: ").Append(this.InputPortCount).Append("\n");
            sb.Append("  OutputPortCount: ").Append(this.OutputPortCount).Append("\n");
            sb.Append("  RemoteSiteListeningPort: ").Append(this.RemoteSiteListeningPort).Append("\n");
            sb.Append("  RemoteSiteHttpListeningPort: ").Append(this.RemoteSiteHttpListeningPort).Append("\n");
            sb.Append("  SiteToSiteSecure: ").Append(this.SiteToSiteSecure).Append("\n");
            sb.Append("  InstanceId: ").Append(this.InstanceId).Append("\n");
            sb.Append("  InputPorts: ").Append(this.InputPorts).Append("\n");
            sb.Append("  OutputPorts: ").Append(this.OutputPorts).Append("\n");
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
            return this.Equals(input as ControllerDTO);
        }

        /// <summary>
        /// Returns true if ControllerDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of ControllerDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ControllerDTO input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Comments == input.Comments ||
                    (this.Comments != null &&
                    this.Comments.Equals(input.Comments))
                ) && 
                (
                    this.RunningCount == input.RunningCount ||
                    (this.RunningCount != null &&
                    this.RunningCount.Equals(input.RunningCount))
                ) && 
                (
                    this.StoppedCount == input.StoppedCount ||
                    (this.StoppedCount != null &&
                    this.StoppedCount.Equals(input.StoppedCount))
                ) && 
                (
                    this.InvalidCount == input.InvalidCount ||
                    (this.InvalidCount != null &&
                    this.InvalidCount.Equals(input.InvalidCount))
                ) && 
                (
                    this.DisabledCount == input.DisabledCount ||
                    (this.DisabledCount != null &&
                    this.DisabledCount.Equals(input.DisabledCount))
                ) && 
                (
                    this.ActiveRemotePortCount == input.ActiveRemotePortCount ||
                    (this.ActiveRemotePortCount != null &&
                    this.ActiveRemotePortCount.Equals(input.ActiveRemotePortCount))
                ) && 
                (
                    this.InactiveRemotePortCount == input.InactiveRemotePortCount ||
                    (this.InactiveRemotePortCount != null &&
                    this.InactiveRemotePortCount.Equals(input.InactiveRemotePortCount))
                ) && 
                (
                    this.InputPortCount == input.InputPortCount ||
                    (this.InputPortCount != null &&
                    this.InputPortCount.Equals(input.InputPortCount))
                ) && 
                (
                    this.OutputPortCount == input.OutputPortCount ||
                    (this.OutputPortCount != null &&
                    this.OutputPortCount.Equals(input.OutputPortCount))
                ) && 
                (
                    this.RemoteSiteListeningPort == input.RemoteSiteListeningPort ||
                    (this.RemoteSiteListeningPort != null &&
                    this.RemoteSiteListeningPort.Equals(input.RemoteSiteListeningPort))
                ) && 
                (
                    this.RemoteSiteHttpListeningPort == input.RemoteSiteHttpListeningPort ||
                    (this.RemoteSiteHttpListeningPort != null &&
                    this.RemoteSiteHttpListeningPort.Equals(input.RemoteSiteHttpListeningPort))
                ) && 
                (
                    this.SiteToSiteSecure == input.SiteToSiteSecure ||
                    (this.SiteToSiteSecure != null &&
                    this.SiteToSiteSecure.Equals(input.SiteToSiteSecure))
                ) && 
                (
                    this.InstanceId == input.InstanceId ||
                    (this.InstanceId != null &&
                    this.InstanceId.Equals(input.InstanceId))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Comments != null)
                    hashCode = hashCode * 59 + this.Comments.GetHashCode();
                if (this.RunningCount != null)
                    hashCode = hashCode * 59 + this.RunningCount.GetHashCode();
                if (this.StoppedCount != null)
                    hashCode = hashCode * 59 + this.StoppedCount.GetHashCode();
                if (this.InvalidCount != null)
                    hashCode = hashCode * 59 + this.InvalidCount.GetHashCode();
                if (this.DisabledCount != null)
                    hashCode = hashCode * 59 + this.DisabledCount.GetHashCode();
                if (this.ActiveRemotePortCount != null)
                    hashCode = hashCode * 59 + this.ActiveRemotePortCount.GetHashCode();
                if (this.InactiveRemotePortCount != null)
                    hashCode = hashCode * 59 + this.InactiveRemotePortCount.GetHashCode();
                if (this.InputPortCount != null)
                    hashCode = hashCode * 59 + this.InputPortCount.GetHashCode();
                if (this.OutputPortCount != null)
                    hashCode = hashCode * 59 + this.OutputPortCount.GetHashCode();
                if (this.RemoteSiteListeningPort != null)
                    hashCode = hashCode * 59 + this.RemoteSiteListeningPort.GetHashCode();
                if (this.RemoteSiteHttpListeningPort != null)
                    hashCode = hashCode * 59 + this.RemoteSiteHttpListeningPort.GetHashCode();
                if (this.SiteToSiteSecure != null)
                    hashCode = hashCode * 59 + this.SiteToSiteSecure.GetHashCode();
                if (this.InstanceId != null)
                    hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.InputPorts != null)
                    hashCode = hashCode * 59 + this.InputPorts.GetHashCode();
                if (this.OutputPorts != null)
                    hashCode = hashCode * 59 + this.OutputPorts.GetHashCode();
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
