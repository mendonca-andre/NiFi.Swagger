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
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// ProcessorStatusSnapshotDTO
    /// </summary>
    [DataContract]
    public partial class ProcessorStatusSnapshotDTO :  IEquatable<ProcessorStatusSnapshotDTO>, IValidatableObject
    {
        /// <summary>
        /// The state of the processor.
        /// </summary>
        /// <value>The state of the processor.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RunStatusEnum
        {
            
            /// <summary>
            /// Enum Running for value: Running
            /// </summary>
            [EnumMember(Value = "Running")]
            Running = 1,
            
            /// <summary>
            /// Enum Stopped for value: Stopped
            /// </summary>
            [EnumMember(Value = "Stopped")]
            Stopped = 2,
            
            /// <summary>
            /// Enum Validating for value: Validating
            /// </summary>
            [EnumMember(Value = "Validating")]
            Validating = 3,
            
            /// <summary>
            /// Enum Disabled for value: Disabled
            /// </summary>
            [EnumMember(Value = "Disabled")]
            Disabled = 4,
            
            /// <summary>
            /// Enum Invalid for value: Invalid
            /// </summary>
            [EnumMember(Value = "Invalid")]
            Invalid = 5
        }

        /// <summary>
        /// The state of the processor.
        /// </summary>
        /// <value>The state of the processor.</value>
        [DataMember(Name="runStatus", EmitDefaultValue=false)]
        public RunStatusEnum? RunStatus { get; set; }
        /// <summary>
        /// Indicates the node where the process will execute.
        /// </summary>
        /// <value>Indicates the node where the process will execute.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ExecutionNodeEnum
        {
            
            /// <summary>
            /// Enum ALL for value: ALL
            /// </summary>
            [EnumMember(Value = "ALL")]
            ALL = 1,
            
            /// <summary>
            /// Enum PRIMARY for value: PRIMARY
            /// </summary>
            [EnumMember(Value = "PRIMARY")]
            PRIMARY = 2
        }

        /// <summary>
        /// Indicates the node where the process will execute.
        /// </summary>
        /// <value>Indicates the node where the process will execute.</value>
        [DataMember(Name="executionNode", EmitDefaultValue=false)]
        public ExecutionNodeEnum? ExecutionNode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessorStatusSnapshotDTO" /> class.
        /// </summary>
        /// <param name="id">The id of the processor..</param>
        /// <param name="groupId">The id of the parent process group to which the processor belongs..</param>
        /// <param name="name">The name of the prcessor..</param>
        /// <param name="type">The type of the processor..</param>
        /// <param name="runStatus">The state of the processor..</param>
        /// <param name="executionNode">Indicates the node where the process will execute..</param>
        /// <param name="bytesRead">The number of bytes read by this Processor in the last 5 mintues.</param>
        /// <param name="bytesWritten">The number of bytes written by this Processor in the last 5 minutes.</param>
        /// <param name="read">The number of bytes read in the last 5 minutes..</param>
        /// <param name="written">The number of bytes written in the last 5 minutes..</param>
        /// <param name="flowFilesIn">The number of FlowFiles that have been accepted in the last 5 minutes.</param>
        /// <param name="bytesIn">The size of the FlowFiles that have been accepted in the last 5 minutes.</param>
        /// <param name="input">The count/size of flowfiles that have been accepted in the last 5 minutes..</param>
        /// <param name="flowFilesOut">The number of FlowFiles transferred to a Connection in the last 5 minutes.</param>
        /// <param name="bytesOut">The size of the FlowFiles transferred to a Connection in the last 5 minutes.</param>
        /// <param name="output">The count/size of flowfiles that have been processed in the last 5 minutes..</param>
        /// <param name="taskCount">The number of times this Processor has run in the last 5 minutes.</param>
        /// <param name="tasksDurationNanos">The number of nanoseconds that this Processor has spent running in the last 5 minutes.</param>
        /// <param name="tasks">The total number of task this connectable has completed over the last 5 minutes..</param>
        /// <param name="tasksDuration">The total duration of all tasks for this connectable over the last 5 minutes..</param>
        /// <param name="activeThreadCount">The number of threads currently executing in the processor..</param>
        /// <param name="terminatedThreadCount">The number of threads currently terminated for the processor..</param>
        public ProcessorStatusSnapshotDTO(string id = default(string), string groupId = default(string), string name = default(string), string type = default(string), RunStatusEnum? runStatus = default(RunStatusEnum?), ExecutionNodeEnum? executionNode = default(ExecutionNodeEnum?), long? bytesRead = default(long?), long? bytesWritten = default(long?), string read = default(string), string written = default(string), int? flowFilesIn = default(int?), long? bytesIn = default(long?), string input = default(string), int? flowFilesOut = default(int?), long? bytesOut = default(long?), string output = default(string), int? taskCount = default(int?), long? tasksDurationNanos = default(long?), string tasks = default(string), string tasksDuration = default(string), int? activeThreadCount = default(int?), int? terminatedThreadCount = default(int?))
        {
            this.Id = id;
            this.GroupId = groupId;
            this.Name = name;
            this.Type = type;
            this.RunStatus = runStatus;
            this.ExecutionNode = executionNode;
            this.BytesRead = bytesRead;
            this.BytesWritten = bytesWritten;
            this.Read = read;
            this.Written = written;
            this.FlowFilesIn = flowFilesIn;
            this.BytesIn = bytesIn;
            this.Input = input;
            this.FlowFilesOut = flowFilesOut;
            this.BytesOut = bytesOut;
            this.Output = output;
            this.TaskCount = taskCount;
            this.TasksDurationNanos = tasksDurationNanos;
            this.Tasks = tasks;
            this.TasksDuration = tasksDuration;
            this.ActiveThreadCount = activeThreadCount;
            this.TerminatedThreadCount = terminatedThreadCount;
        }
        
        /// <summary>
        /// The id of the processor.
        /// </summary>
        /// <value>The id of the processor.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The id of the parent process group to which the processor belongs.
        /// </summary>
        /// <value>The id of the parent process group to which the processor belongs.</value>
        [DataMember(Name="groupId", EmitDefaultValue=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// The name of the prcessor.
        /// </summary>
        /// <value>The name of the prcessor.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The type of the processor.
        /// </summary>
        /// <value>The type of the processor.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }



        /// <summary>
        /// The number of bytes read by this Processor in the last 5 mintues
        /// </summary>
        /// <value>The number of bytes read by this Processor in the last 5 mintues</value>
        [DataMember(Name="bytesRead", EmitDefaultValue=false)]
        public long? BytesRead { get; set; }

        /// <summary>
        /// The number of bytes written by this Processor in the last 5 minutes
        /// </summary>
        /// <value>The number of bytes written by this Processor in the last 5 minutes</value>
        [DataMember(Name="bytesWritten", EmitDefaultValue=false)]
        public long? BytesWritten { get; set; }

        /// <summary>
        /// The number of bytes read in the last 5 minutes.
        /// </summary>
        /// <value>The number of bytes read in the last 5 minutes.</value>
        [DataMember(Name="read", EmitDefaultValue=false)]
        public string Read { get; set; }

        /// <summary>
        /// The number of bytes written in the last 5 minutes.
        /// </summary>
        /// <value>The number of bytes written in the last 5 minutes.</value>
        [DataMember(Name="written", EmitDefaultValue=false)]
        public string Written { get; set; }

        /// <summary>
        /// The number of FlowFiles that have been accepted in the last 5 minutes
        /// </summary>
        /// <value>The number of FlowFiles that have been accepted in the last 5 minutes</value>
        [DataMember(Name="flowFilesIn", EmitDefaultValue=false)]
        public int? FlowFilesIn { get; set; }

        /// <summary>
        /// The size of the FlowFiles that have been accepted in the last 5 minutes
        /// </summary>
        /// <value>The size of the FlowFiles that have been accepted in the last 5 minutes</value>
        [DataMember(Name="bytesIn", EmitDefaultValue=false)]
        public long? BytesIn { get; set; }

        /// <summary>
        /// The count/size of flowfiles that have been accepted in the last 5 minutes.
        /// </summary>
        /// <value>The count/size of flowfiles that have been accepted in the last 5 minutes.</value>
        [DataMember(Name="input", EmitDefaultValue=false)]
        public string Input { get; set; }

        /// <summary>
        /// The number of FlowFiles transferred to a Connection in the last 5 minutes
        /// </summary>
        /// <value>The number of FlowFiles transferred to a Connection in the last 5 minutes</value>
        [DataMember(Name="flowFilesOut", EmitDefaultValue=false)]
        public int? FlowFilesOut { get; set; }

        /// <summary>
        /// The size of the FlowFiles transferred to a Connection in the last 5 minutes
        /// </summary>
        /// <value>The size of the FlowFiles transferred to a Connection in the last 5 minutes</value>
        [DataMember(Name="bytesOut", EmitDefaultValue=false)]
        public long? BytesOut { get; set; }

        /// <summary>
        /// The count/size of flowfiles that have been processed in the last 5 minutes.
        /// </summary>
        /// <value>The count/size of flowfiles that have been processed in the last 5 minutes.</value>
        [DataMember(Name="output", EmitDefaultValue=false)]
        public string Output { get; set; }

        /// <summary>
        /// The number of times this Processor has run in the last 5 minutes
        /// </summary>
        /// <value>The number of times this Processor has run in the last 5 minutes</value>
        [DataMember(Name="taskCount", EmitDefaultValue=false)]
        public int? TaskCount { get; set; }

        /// <summary>
        /// The number of nanoseconds that this Processor has spent running in the last 5 minutes
        /// </summary>
        /// <value>The number of nanoseconds that this Processor has spent running in the last 5 minutes</value>
        [DataMember(Name="tasksDurationNanos", EmitDefaultValue=false)]
        public long? TasksDurationNanos { get; set; }

        /// <summary>
        /// The total number of task this connectable has completed over the last 5 minutes.
        /// </summary>
        /// <value>The total number of task this connectable has completed over the last 5 minutes.</value>
        [DataMember(Name="tasks", EmitDefaultValue=false)]
        public string Tasks { get; set; }

        /// <summary>
        /// The total duration of all tasks for this connectable over the last 5 minutes.
        /// </summary>
        /// <value>The total duration of all tasks for this connectable over the last 5 minutes.</value>
        [DataMember(Name="tasksDuration", EmitDefaultValue=false)]
        public string TasksDuration { get; set; }

        /// <summary>
        /// The number of threads currently executing in the processor.
        /// </summary>
        /// <value>The number of threads currently executing in the processor.</value>
        [DataMember(Name="activeThreadCount", EmitDefaultValue=false)]
        public int? ActiveThreadCount { get; set; }

        /// <summary>
        /// The number of threads currently terminated for the processor.
        /// </summary>
        /// <value>The number of threads currently terminated for the processor.</value>
        [DataMember(Name="terminatedThreadCount", EmitDefaultValue=false)]
        public int? TerminatedThreadCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProcessorStatusSnapshotDTO {\n");
            sb.Append("  Id: ").Append(this.Id).Append("\n");
            sb.Append("  GroupId: ").Append(this.GroupId).Append("\n");
            sb.Append("  Name: ").Append(this.Name).Append("\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  RunStatus: ").Append(this.RunStatus).Append("\n");
            sb.Append("  ExecutionNode: ").Append(this.ExecutionNode).Append("\n");
            sb.Append("  BytesRead: ").Append(this.BytesRead).Append("\n");
            sb.Append("  BytesWritten: ").Append(this.BytesWritten).Append("\n");
            sb.Append("  Read: ").Append(this.Read).Append("\n");
            sb.Append("  Written: ").Append(this.Written).Append("\n");
            sb.Append("  FlowFilesIn: ").Append(this.FlowFilesIn).Append("\n");
            sb.Append("  BytesIn: ").Append(this.BytesIn).Append("\n");
            sb.Append("  Input: ").Append(this.Input).Append("\n");
            sb.Append("  FlowFilesOut: ").Append(this.FlowFilesOut).Append("\n");
            sb.Append("  BytesOut: ").Append(this.BytesOut).Append("\n");
            sb.Append("  Output: ").Append(this.Output).Append("\n");
            sb.Append("  TaskCount: ").Append(this.TaskCount).Append("\n");
            sb.Append("  TasksDurationNanos: ").Append(this.TasksDurationNanos).Append("\n");
            sb.Append("  Tasks: ").Append(this.Tasks).Append("\n");
            sb.Append("  TasksDuration: ").Append(this.TasksDuration).Append("\n");
            sb.Append("  ActiveThreadCount: ").Append(this.ActiveThreadCount).Append("\n");
            sb.Append("  TerminatedThreadCount: ").Append(this.TerminatedThreadCount).Append("\n");
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
            return this.Equals(input as ProcessorStatusSnapshotDTO);
        }

        /// <summary>
        /// Returns true if ProcessorStatusSnapshotDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of ProcessorStatusSnapshotDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProcessorStatusSnapshotDTO input)
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
                    this.GroupId == input.GroupId ||
                    (this.GroupId != null &&
                    this.GroupId.Equals(input.GroupId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.RunStatus == input.RunStatus ||
                    (this.RunStatus != null &&
                    this.RunStatus.Equals(input.RunStatus))
                ) && 
                (
                    this.ExecutionNode == input.ExecutionNode ||
                    (this.ExecutionNode != null &&
                    this.ExecutionNode.Equals(input.ExecutionNode))
                ) && 
                (
                    this.BytesRead == input.BytesRead ||
                    (this.BytesRead != null &&
                    this.BytesRead.Equals(input.BytesRead))
                ) && 
                (
                    this.BytesWritten == input.BytesWritten ||
                    (this.BytesWritten != null &&
                    this.BytesWritten.Equals(input.BytesWritten))
                ) && 
                (
                    this.Read == input.Read ||
                    (this.Read != null &&
                    this.Read.Equals(input.Read))
                ) && 
                (
                    this.Written == input.Written ||
                    (this.Written != null &&
                    this.Written.Equals(input.Written))
                ) && 
                (
                    this.FlowFilesIn == input.FlowFilesIn ||
                    (this.FlowFilesIn != null &&
                    this.FlowFilesIn.Equals(input.FlowFilesIn))
                ) && 
                (
                    this.BytesIn == input.BytesIn ||
                    (this.BytesIn != null &&
                    this.BytesIn.Equals(input.BytesIn))
                ) && 
                (
                    this.Input == input.Input ||
                    (this.Input != null &&
                    this.Input.Equals(input.Input))
                ) && 
                (
                    this.FlowFilesOut == input.FlowFilesOut ||
                    (this.FlowFilesOut != null &&
                    this.FlowFilesOut.Equals(input.FlowFilesOut))
                ) && 
                (
                    this.BytesOut == input.BytesOut ||
                    (this.BytesOut != null &&
                    this.BytesOut.Equals(input.BytesOut))
                ) && 
                (
                    this.Output == input.Output ||
                    (this.Output != null &&
                    this.Output.Equals(input.Output))
                ) && 
                (
                    this.TaskCount == input.TaskCount ||
                    (this.TaskCount != null &&
                    this.TaskCount.Equals(input.TaskCount))
                ) && 
                (
                    this.TasksDurationNanos == input.TasksDurationNanos ||
                    (this.TasksDurationNanos != null &&
                    this.TasksDurationNanos.Equals(input.TasksDurationNanos))
                ) && 
                (
                    this.Tasks == input.Tasks ||
                    (this.Tasks != null &&
                    this.Tasks.Equals(input.Tasks))
                ) && 
                (
                    this.TasksDuration == input.TasksDuration ||
                    (this.TasksDuration != null &&
                    this.TasksDuration.Equals(input.TasksDuration))
                ) && 
                (
                    this.ActiveThreadCount == input.ActiveThreadCount ||
                    (this.ActiveThreadCount != null &&
                    this.ActiveThreadCount.Equals(input.ActiveThreadCount))
                ) && 
                (
                    this.TerminatedThreadCount == input.TerminatedThreadCount ||
                    (this.TerminatedThreadCount != null &&
                    this.TerminatedThreadCount.Equals(input.TerminatedThreadCount))
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
                if (this.GroupId != null)
                    hashCode = hashCode * 59 + this.GroupId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.RunStatus != null)
                    hashCode = hashCode * 59 + this.RunStatus.GetHashCode();
                if (this.ExecutionNode != null)
                    hashCode = hashCode * 59 + this.ExecutionNode.GetHashCode();
                if (this.BytesRead != null)
                    hashCode = hashCode * 59 + this.BytesRead.GetHashCode();
                if (this.BytesWritten != null)
                    hashCode = hashCode * 59 + this.BytesWritten.GetHashCode();
                if (this.Read != null)
                    hashCode = hashCode * 59 + this.Read.GetHashCode();
                if (this.Written != null)
                    hashCode = hashCode * 59 + this.Written.GetHashCode();
                if (this.FlowFilesIn != null)
                    hashCode = hashCode * 59 + this.FlowFilesIn.GetHashCode();
                if (this.BytesIn != null)
                    hashCode = hashCode * 59 + this.BytesIn.GetHashCode();
                if (this.Input != null)
                    hashCode = hashCode * 59 + this.Input.GetHashCode();
                if (this.FlowFilesOut != null)
                    hashCode = hashCode * 59 + this.FlowFilesOut.GetHashCode();
                if (this.BytesOut != null)
                    hashCode = hashCode * 59 + this.BytesOut.GetHashCode();
                if (this.Output != null)
                    hashCode = hashCode * 59 + this.Output.GetHashCode();
                if (this.TaskCount != null)
                    hashCode = hashCode * 59 + this.TaskCount.GetHashCode();
                if (this.TasksDurationNanos != null)
                    hashCode = hashCode * 59 + this.TasksDurationNanos.GetHashCode();
                if (this.Tasks != null)
                    hashCode = hashCode * 59 + this.Tasks.GetHashCode();
                if (this.TasksDuration != null)
                    hashCode = hashCode * 59 + this.TasksDuration.GetHashCode();
                if (this.ActiveThreadCount != null)
                    hashCode = hashCode * 59 + this.ActiveThreadCount.GetHashCode();
                if (this.TerminatedThreadCount != null)
                    hashCode = hashCode * 59 + this.TerminatedThreadCount.GetHashCode();
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
