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
    /// VersionedRemoteProcessGroup
    /// </summary>
    [DataContract]
    public partial class VersionedRemoteProcessGroup :  IEquatable<VersionedRemoteProcessGroup>, IValidatableObject
    {
        /// <summary>
        /// The Transport Protocol that is used for Site-to-Site communications
        /// </summary>
        /// <value>The Transport Protocol that is used for Site-to-Site communications</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TransportProtocolEnum
        {
            
            /// <summary>
            /// Enum RAW for value: RAW
            /// </summary>
            [EnumMember(Value = "RAW")]
            RAW = 1,
            
            /// <summary>
            /// Enum HTTP for value: HTTP
            /// </summary>
            [EnumMember(Value = "HTTP")]
            HTTP = 2
        }

        /// <summary>
        /// The Transport Protocol that is used for Site-to-Site communications
        /// </summary>
        /// <value>The Transport Protocol that is used for Site-to-Site communications</value>
        [DataMember(Name="transportProtocol", EmitDefaultValue=false)]
        public TransportProtocolEnum? TransportProtocol { get; set; }
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
        /// Initializes a new instance of the <see cref="VersionedRemoteProcessGroup" /> class.
        /// </summary>
        /// <param name="identifier">The component&#39;s unique identifier.</param>
        /// <param name="name">The component&#39;s name.</param>
        /// <param name="comments">The user-supplied comments for the component.</param>
        /// <param name="position">The component&#39;s position on the graph.</param>
        /// <param name="targetUri">[DEPRECATED] The target URI of the remote process group. If target uri is not set, but uris are set, then returns the first uri in the uris. If neither target uri nor uris are set, then returns null..</param>
        /// <param name="targetUris">The target URIs of the remote process group. If target uris is not set but target uri is set, then returns the single target uri. If neither target uris nor target uri is set, then returns null..</param>
        /// <param name="communicationsTimeout">The time period used for the timeout when communicating with the target..</param>
        /// <param name="yieldDuration">When yielding, this amount of time must elapse before the remote process group is scheduled again..</param>
        /// <param name="transportProtocol">The Transport Protocol that is used for Site-to-Site communications.</param>
        /// <param name="localNetworkInterface">The local network interface to send/receive data. If not specified, any local address is used. If clustered, all nodes must have an interface with this identifier..</param>
        /// <param name="proxyHost">proxyHost.</param>
        /// <param name="proxyPort">proxyPort.</param>
        /// <param name="proxyUser">proxyUser.</param>
        /// <param name="inputPorts">A Set of Input Ports that can be connected to, in order to send data to the remote NiFi instance.</param>
        /// <param name="outputPorts">A Set of Output Ports that can be connected to, in order to pull data from the remote NiFi instance.</param>
        /// <param name="componentType">componentType.</param>
        /// <param name="groupIdentifier">The ID of the Process Group that this component belongs to.</param>
        public VersionedRemoteProcessGroup(string identifier = default(string), string name = default(string), string comments = default(string), Position position = default(Position), string targetUri = default(string), string targetUris = default(string), string communicationsTimeout = default(string), string yieldDuration = default(string), TransportProtocolEnum? transportProtocol = default(TransportProtocolEnum?), string localNetworkInterface = default(string), string proxyHost = default(string), int? proxyPort = default(int?), string proxyUser = default(string), List<VersionedRemoteGroupPort> inputPorts = default(List<VersionedRemoteGroupPort>), List<VersionedRemoteGroupPort> outputPorts = default(List<VersionedRemoteGroupPort>), ComponentTypeEnum? componentType = default(ComponentTypeEnum?), string groupIdentifier = default(string))
        {
            this.Identifier = identifier;
            this.Name = name;
            this.Comments = comments;
            this.Position = position;
            this.TargetUri = targetUri;
            this.TargetUris = targetUris;
            this.CommunicationsTimeout = communicationsTimeout;
            this.YieldDuration = yieldDuration;
            this.TransportProtocol = transportProtocol;
            this.LocalNetworkInterface = localNetworkInterface;
            this.ProxyHost = proxyHost;
            this.ProxyPort = proxyPort;
            this.ProxyUser = proxyUser;
            this.InputPorts = inputPorts;
            this.OutputPorts = outputPorts;
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
        /// [DEPRECATED] The target URI of the remote process group. If target uri is not set, but uris are set, then returns the first uri in the uris. If neither target uri nor uris are set, then returns null.
        /// </summary>
        /// <value>[DEPRECATED] The target URI of the remote process group. If target uri is not set, but uris are set, then returns the first uri in the uris. If neither target uri nor uris are set, then returns null.</value>
        [DataMember(Name="targetUri", EmitDefaultValue=false)]
        public string TargetUri { get; set; }

        /// <summary>
        /// The target URIs of the remote process group. If target uris is not set but target uri is set, then returns the single target uri. If neither target uris nor target uri is set, then returns null.
        /// </summary>
        /// <value>The target URIs of the remote process group. If target uris is not set but target uri is set, then returns the single target uri. If neither target uris nor target uri is set, then returns null.</value>
        [DataMember(Name="targetUris", EmitDefaultValue=false)]
        public string TargetUris { get; set; }

        /// <summary>
        /// The time period used for the timeout when communicating with the target.
        /// </summary>
        /// <value>The time period used for the timeout when communicating with the target.</value>
        [DataMember(Name="communicationsTimeout", EmitDefaultValue=false)]
        public string CommunicationsTimeout { get; set; }

        /// <summary>
        /// When yielding, this amount of time must elapse before the remote process group is scheduled again.
        /// </summary>
        /// <value>When yielding, this amount of time must elapse before the remote process group is scheduled again.</value>
        [DataMember(Name="yieldDuration", EmitDefaultValue=false)]
        public string YieldDuration { get; set; }


        /// <summary>
        /// The local network interface to send/receive data. If not specified, any local address is used. If clustered, all nodes must have an interface with this identifier.
        /// </summary>
        /// <value>The local network interface to send/receive data. If not specified, any local address is used. If clustered, all nodes must have an interface with this identifier.</value>
        [DataMember(Name="localNetworkInterface", EmitDefaultValue=false)]
        public string LocalNetworkInterface { get; set; }

        /// <summary>
        /// Gets or Sets ProxyHost
        /// </summary>
        [DataMember(Name="proxyHost", EmitDefaultValue=false)]
        public string ProxyHost { get; set; }

        /// <summary>
        /// Gets or Sets ProxyPort
        /// </summary>
        [DataMember(Name="proxyPort", EmitDefaultValue=false)]
        public int? ProxyPort { get; set; }

        /// <summary>
        /// Gets or Sets ProxyUser
        /// </summary>
        [DataMember(Name="proxyUser", EmitDefaultValue=false)]
        public string ProxyUser { get; set; }

        /// <summary>
        /// A Set of Input Ports that can be connected to, in order to send data to the remote NiFi instance
        /// </summary>
        /// <value>A Set of Input Ports that can be connected to, in order to send data to the remote NiFi instance</value>
        [DataMember(Name="inputPorts", EmitDefaultValue=false)]
        public List<VersionedRemoteGroupPort> InputPorts { get; set; }

        /// <summary>
        /// A Set of Output Ports that can be connected to, in order to pull data from the remote NiFi instance
        /// </summary>
        /// <value>A Set of Output Ports that can be connected to, in order to pull data from the remote NiFi instance</value>
        [DataMember(Name="outputPorts", EmitDefaultValue=false)]
        public List<VersionedRemoteGroupPort> OutputPorts { get; set; }


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
            sb.Append("class VersionedRemoteProcessGroup {\n");
            sb.Append("  Identifier: ").Append(this.Identifier).Append("\n");
            sb.Append("  Name: ").Append(this.Name).Append("\n");
            sb.Append("  Comments: ").Append(this.Comments).Append("\n");
            sb.Append("  Position: ").Append(this.Position).Append("\n");
            sb.Append("  TargetUri: ").Append(this.TargetUri).Append("\n");
            sb.Append("  TargetUris: ").Append(this.TargetUris).Append("\n");
            sb.Append("  CommunicationsTimeout: ").Append(this.CommunicationsTimeout).Append("\n");
            sb.Append("  YieldDuration: ").Append(this.YieldDuration).Append("\n");
            sb.Append("  TransportProtocol: ").Append(this.TransportProtocol).Append("\n");
            sb.Append("  LocalNetworkInterface: ").Append(this.LocalNetworkInterface).Append("\n");
            sb.Append("  ProxyHost: ").Append(this.ProxyHost).Append("\n");
            sb.Append("  ProxyPort: ").Append(this.ProxyPort).Append("\n");
            sb.Append("  ProxyUser: ").Append(this.ProxyUser).Append("\n");
            sb.Append("  InputPorts: ").Append(this.InputPorts).Append("\n");
            sb.Append("  OutputPorts: ").Append(this.OutputPorts).Append("\n");
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
            return this.Equals(input as VersionedRemoteProcessGroup);
        }

        /// <summary>
        /// Returns true if VersionedRemoteProcessGroup instances are equal
        /// </summary>
        /// <param name="input">Instance of VersionedRemoteProcessGroup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VersionedRemoteProcessGroup input)
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
                    this.TargetUri == input.TargetUri ||
                    (this.TargetUri != null &&
                    this.TargetUri.Equals(input.TargetUri))
                ) && 
                (
                    this.TargetUris == input.TargetUris ||
                    (this.TargetUris != null &&
                    this.TargetUris.Equals(input.TargetUris))
                ) && 
                (
                    this.CommunicationsTimeout == input.CommunicationsTimeout ||
                    (this.CommunicationsTimeout != null &&
                    this.CommunicationsTimeout.Equals(input.CommunicationsTimeout))
                ) && 
                (
                    this.YieldDuration == input.YieldDuration ||
                    (this.YieldDuration != null &&
                    this.YieldDuration.Equals(input.YieldDuration))
                ) && 
                (
                    this.TransportProtocol == input.TransportProtocol ||
                    (this.TransportProtocol != null &&
                    this.TransportProtocol.Equals(input.TransportProtocol))
                ) && 
                (
                    this.LocalNetworkInterface == input.LocalNetworkInterface ||
                    (this.LocalNetworkInterface != null &&
                    this.LocalNetworkInterface.Equals(input.LocalNetworkInterface))
                ) && 
                (
                    this.ProxyHost == input.ProxyHost ||
                    (this.ProxyHost != null &&
                    this.ProxyHost.Equals(input.ProxyHost))
                ) && 
                (
                    this.ProxyPort == input.ProxyPort ||
                    (this.ProxyPort != null &&
                    this.ProxyPort.Equals(input.ProxyPort))
                ) && 
                (
                    this.ProxyUser == input.ProxyUser ||
                    (this.ProxyUser != null &&
                    this.ProxyUser.Equals(input.ProxyUser))
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
                if (this.TargetUri != null)
                    hashCode = hashCode * 59 + this.TargetUri.GetHashCode();
                if (this.TargetUris != null)
                    hashCode = hashCode * 59 + this.TargetUris.GetHashCode();
                if (this.CommunicationsTimeout != null)
                    hashCode = hashCode * 59 + this.CommunicationsTimeout.GetHashCode();
                if (this.YieldDuration != null)
                    hashCode = hashCode * 59 + this.YieldDuration.GetHashCode();
                if (this.TransportProtocol != null)
                    hashCode = hashCode * 59 + this.TransportProtocol.GetHashCode();
                if (this.LocalNetworkInterface != null)
                    hashCode = hashCode * 59 + this.LocalNetworkInterface.GetHashCode();
                if (this.ProxyHost != null)
                    hashCode = hashCode * 59 + this.ProxyHost.GetHashCode();
                if (this.ProxyPort != null)
                    hashCode = hashCode * 59 + this.ProxyPort.GetHashCode();
                if (this.ProxyUser != null)
                    hashCode = hashCode * 59 + this.ProxyUser.GetHashCode();
                if (this.InputPorts != null)
                    hashCode = hashCode * 59 + this.InputPorts.GetHashCode();
                if (this.OutputPorts != null)
                    hashCode = hashCode * 59 + this.OutputPorts.GetHashCode();
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
