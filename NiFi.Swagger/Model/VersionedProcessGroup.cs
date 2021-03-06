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
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// VersionedProcessGroup
    /// </summary>
    [DataContract]
    public partial class VersionedProcessGroup :  IEquatable<VersionedProcessGroup>, IValidatableObject
    {
        /// <summary>
        /// Defines ComponentType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ComponentTypeEnum
        {
            
            /// <summary>
            /// Enum CONNECTION for value: CONNECTION
            /// </summary>
            [EnumMember(Value = "CONNECTION")]
            CONNECTION = 1,
            
            /// <summary>
            /// Enum PROCESSOR for value: PROCESSOR
            /// </summary>
            [EnumMember(Value = "PROCESSOR")]
            PROCESSOR = 2,
            
            /// <summary>
            /// Enum PROCESSGROUP for value: PROCESS_GROUP
            /// </summary>
            [EnumMember(Value = "PROCESS_GROUP")]
            PROCESSGROUP = 3,
            
            /// <summary>
            /// Enum REMOTEPROCESSGROUP for value: REMOTE_PROCESS_GROUP
            /// </summary>
            [EnumMember(Value = "REMOTE_PROCESS_GROUP")]
            REMOTEPROCESSGROUP = 4,
            
            /// <summary>
            /// Enum INPUTPORT for value: INPUT_PORT
            /// </summary>
            [EnumMember(Value = "INPUT_PORT")]
            INPUTPORT = 5,
            
            /// <summary>
            /// Enum OUTPUTPORT for value: OUTPUT_PORT
            /// </summary>
            [EnumMember(Value = "OUTPUT_PORT")]
            OUTPUTPORT = 6,
            
            /// <summary>
            /// Enum REMOTEINPUTPORT for value: REMOTE_INPUT_PORT
            /// </summary>
            [EnumMember(Value = "REMOTE_INPUT_PORT")]
            REMOTEINPUTPORT = 7,
            
            /// <summary>
            /// Enum REMOTEOUTPUTPORT for value: REMOTE_OUTPUT_PORT
            /// </summary>
            [EnumMember(Value = "REMOTE_OUTPUT_PORT")]
            REMOTEOUTPUTPORT = 8,
            
            /// <summary>
            /// Enum FUNNEL for value: FUNNEL
            /// </summary>
            [EnumMember(Value = "FUNNEL")]
            FUNNEL = 9,
            
            /// <summary>
            /// Enum LABEL for value: LABEL
            /// </summary>
            [EnumMember(Value = "LABEL")]
            LABEL = 10,
            
            /// <summary>
            /// Enum CONTROLLERSERVICE for value: CONTROLLER_SERVICE
            /// </summary>
            [EnumMember(Value = "CONTROLLER_SERVICE")]
            CONTROLLERSERVICE = 11
        }

        /// <summary>
        /// Gets or Sets ComponentType
        /// </summary>
        [DataMember(Name="componentType", EmitDefaultValue=false)]
        public ComponentTypeEnum? ComponentType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="VersionedProcessGroup" /> class.
        /// </summary>
        /// <param name="identifier">The component&#39;s unique identifier.</param>
        /// <param name="name">The component&#39;s name.</param>
        /// <param name="comments">The user-supplied comments for the component.</param>
        /// <param name="position">The component&#39;s position on the graph.</param>
        /// <param name="processGroups">The child Process Groups.</param>
        /// <param name="remoteProcessGroups">The Remote Process Groups.</param>
        /// <param name="processors">The Processors.</param>
        /// <param name="inputPorts">The Input Ports.</param>
        /// <param name="outputPorts">The Output Ports.</param>
        /// <param name="connections">The Connections.</param>
        /// <param name="labels">The Labels.</param>
        /// <param name="funnels">The Funnels.</param>
        /// <param name="controllerServices">The Controller Services.</param>
        /// <param name="versionedFlowCoordinates">The coordinates where the remote flow is stored, or null if the Process Group is not directly under Version Control.</param>
        /// <param name="variables">The Variables in the Variable Registry for this Process Group (not including any ancestor or descendant Process Groups).</param>
        /// <param name="componentType">componentType.</param>
        /// <param name="groupIdentifier">The ID of the Process Group that this component belongs to.</param>
        public VersionedProcessGroup(string identifier = default(string), string name = default(string), string comments = default(string), Position position = default(Position), List<VersionedProcessGroup> processGroups = default(List<VersionedProcessGroup>), List<VersionedRemoteProcessGroup> remoteProcessGroups = default(List<VersionedRemoteProcessGroup>), List<VersionedProcessor> processors = default(List<VersionedProcessor>), List<VersionedPort> inputPorts = default(List<VersionedPort>), List<VersionedPort> outputPorts = default(List<VersionedPort>), List<VersionedConnection> connections = default(List<VersionedConnection>), List<VersionedLabel> labels = default(List<VersionedLabel>), List<VersionedFunnel> funnels = default(List<VersionedFunnel>), List<VersionedControllerService> controllerServices = default(List<VersionedControllerService>), VersionedFlowCoordinates versionedFlowCoordinates = default(VersionedFlowCoordinates), Dictionary<string, string> variables = default(Dictionary<string, string>), ComponentTypeEnum? componentType = default(ComponentTypeEnum?), string groupIdentifier = default(string))
        {
            this.Identifier = identifier;
            this.Name = name;
            this.Comments = comments;
            this.Position = position;
            this.ProcessGroups = processGroups;
            this.RemoteProcessGroups = remoteProcessGroups;
            this.Processors = processors;
            this.InputPorts = inputPorts;
            this.OutputPorts = outputPorts;
            this.Connections = connections;
            this.Labels = labels;
            this.Funnels = funnels;
            this.ControllerServices = controllerServices;
            this.VersionedFlowCoordinates = versionedFlowCoordinates;
            this.Variables = variables;
            this.ComponentType = componentType;
            this.GroupIdentifier = groupIdentifier;
        }
        
        /// <summary>
        /// The component&#39;s unique identifier
        /// </summary>
        /// <value>The component&#39;s unique identifier</value>
        [DataMember(Name="identifier", EmitDefaultValue=false)]
        public string Identifier { get; set; }

        /// <summary>
        /// The component&#39;s name
        /// </summary>
        /// <value>The component&#39;s name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The user-supplied comments for the component
        /// </summary>
        /// <value>The user-supplied comments for the component</value>
        [DataMember(Name="comments", EmitDefaultValue=false)]
        public string Comments { get; set; }

        /// <summary>
        /// The component&#39;s position on the graph
        /// </summary>
        /// <value>The component&#39;s position on the graph</value>
        [DataMember(Name="position", EmitDefaultValue=false)]
        public Position Position { get; set; }

        /// <summary>
        /// The child Process Groups
        /// </summary>
        /// <value>The child Process Groups</value>
        [DataMember(Name="processGroups", EmitDefaultValue=false)]
        public List<VersionedProcessGroup> ProcessGroups { get; set; }

        /// <summary>
        /// The Remote Process Groups
        /// </summary>
        /// <value>The Remote Process Groups</value>
        [DataMember(Name="remoteProcessGroups", EmitDefaultValue=false)]
        public List<VersionedRemoteProcessGroup> RemoteProcessGroups { get; set; }

        /// <summary>
        /// The Processors
        /// </summary>
        /// <value>The Processors</value>
        [DataMember(Name="processors", EmitDefaultValue=false)]
        public List<VersionedProcessor> Processors { get; set; }

        /// <summary>
        /// The Input Ports
        /// </summary>
        /// <value>The Input Ports</value>
        [DataMember(Name="inputPorts", EmitDefaultValue=false)]
        public List<VersionedPort> InputPorts { get; set; }

        /// <summary>
        /// The Output Ports
        /// </summary>
        /// <value>The Output Ports</value>
        [DataMember(Name="outputPorts", EmitDefaultValue=false)]
        public List<VersionedPort> OutputPorts { get; set; }

        /// <summary>
        /// The Connections
        /// </summary>
        /// <value>The Connections</value>
        [DataMember(Name="connections", EmitDefaultValue=false)]
        public List<VersionedConnection> Connections { get; set; }

        /// <summary>
        /// The Labels
        /// </summary>
        /// <value>The Labels</value>
        [DataMember(Name="labels", EmitDefaultValue=false)]
        public List<VersionedLabel> Labels { get; set; }

        /// <summary>
        /// The Funnels
        /// </summary>
        /// <value>The Funnels</value>
        [DataMember(Name="funnels", EmitDefaultValue=false)]
        public List<VersionedFunnel> Funnels { get; set; }

        /// <summary>
        /// The Controller Services
        /// </summary>
        /// <value>The Controller Services</value>
        [DataMember(Name="controllerServices", EmitDefaultValue=false)]
        public List<VersionedControllerService> ControllerServices { get; set; }

        /// <summary>
        /// The coordinates where the remote flow is stored, or null if the Process Group is not directly under Version Control
        /// </summary>
        /// <value>The coordinates where the remote flow is stored, or null if the Process Group is not directly under Version Control</value>
        [DataMember(Name="versionedFlowCoordinates", EmitDefaultValue=false)]
        public VersionedFlowCoordinates VersionedFlowCoordinates { get; set; }

        /// <summary>
        /// The Variables in the Variable Registry for this Process Group (not including any ancestor or descendant Process Groups)
        /// </summary>
        /// <value>The Variables in the Variable Registry for this Process Group (not including any ancestor or descendant Process Groups)</value>
        [DataMember(Name="variables", EmitDefaultValue=false)]
        public Dictionary<string, string> Variables { get; set; }


        /// <summary>
        /// The ID of the Process Group that this component belongs to
        /// </summary>
        /// <value>The ID of the Process Group that this component belongs to</value>
        [DataMember(Name="groupIdentifier", EmitDefaultValue=false)]
        public string GroupIdentifier { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VersionedProcessGroup {\n");
            sb.Append("  Identifier: ").Append(this.Identifier).Append("\n");
            sb.Append("  Name: ").Append(this.Name).Append("\n");
            sb.Append("  Comments: ").Append(this.Comments).Append("\n");
            sb.Append("  Position: ").Append(this.Position).Append("\n");
            sb.Append("  ProcessGroups: ").Append(this.ProcessGroups).Append("\n");
            sb.Append("  RemoteProcessGroups: ").Append(this.RemoteProcessGroups).Append("\n");
            sb.Append("  Processors: ").Append(this.Processors).Append("\n");
            sb.Append("  InputPorts: ").Append(this.InputPorts).Append("\n");
            sb.Append("  OutputPorts: ").Append(this.OutputPorts).Append("\n");
            sb.Append("  Connections: ").Append(this.Connections).Append("\n");
            sb.Append("  Labels: ").Append(this.Labels).Append("\n");
            sb.Append("  Funnels: ").Append(this.Funnels).Append("\n");
            sb.Append("  ControllerServices: ").Append(this.ControllerServices).Append("\n");
            sb.Append("  VersionedFlowCoordinates: ").Append(this.VersionedFlowCoordinates).Append("\n");
            sb.Append("  Variables: ").Append(this.Variables).Append("\n");
            sb.Append("  ComponentType: ").Append(this.ComponentType).Append("\n");
            sb.Append("  GroupIdentifier: ").Append(this.GroupIdentifier).Append("\n");
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
            return this.Equals(input as VersionedProcessGroup);
        }

        /// <summary>
        /// Returns true if VersionedProcessGroup instances are equal
        /// </summary>
        /// <param name="input">Instance of VersionedProcessGroup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VersionedProcessGroup input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Identifier == input.Identifier ||
                    (this.Identifier != null &&
                    this.Identifier.Equals(input.Identifier))
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
                    this.Position == input.Position ||
                    (this.Position != null &&
                    this.Position.Equals(input.Position))
                ) && 
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
                ) && 
                (
                    this.ControllerServices == input.ControllerServices ||
                    this.ControllerServices != null &&
                    this.ControllerServices.SequenceEqual(input.ControllerServices)
                ) && 
                (
                    this.VersionedFlowCoordinates == input.VersionedFlowCoordinates ||
                    (this.VersionedFlowCoordinates != null &&
                    this.VersionedFlowCoordinates.Equals(input.VersionedFlowCoordinates))
                ) && 
                (
                    this.Variables == input.Variables ||
                    this.Variables != null &&
                    this.Variables.SequenceEqual(input.Variables)
                ) && 
                (
                    this.ComponentType == input.ComponentType ||
                    (this.ComponentType != null &&
                    this.ComponentType.Equals(input.ComponentType))
                ) && 
                (
                    this.GroupIdentifier == input.GroupIdentifier ||
                    (this.GroupIdentifier != null &&
                    this.GroupIdentifier.Equals(input.GroupIdentifier))
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
                if (this.Identifier != null)
                    hashCode = hashCode * 59 + this.Identifier.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Comments != null)
                    hashCode = hashCode * 59 + this.Comments.GetHashCode();
                if (this.Position != null)
                    hashCode = hashCode * 59 + this.Position.GetHashCode();
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
                if (this.ControllerServices != null)
                    hashCode = hashCode * 59 + this.ControllerServices.GetHashCode();
                if (this.VersionedFlowCoordinates != null)
                    hashCode = hashCode * 59 + this.VersionedFlowCoordinates.GetHashCode();
                if (this.Variables != null)
                    hashCode = hashCode * 59 + this.Variables.GetHashCode();
                if (this.ComponentType != null)
                    hashCode = hashCode * 59 + this.ComponentType.GetHashCode();
                if (this.GroupIdentifier != null)
                    hashCode = hashCode * 59 + this.GroupIdentifier.GetHashCode();
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
