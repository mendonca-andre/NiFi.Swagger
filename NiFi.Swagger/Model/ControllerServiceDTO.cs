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
    /// ControllerServiceDTO
    /// </summary>
    [DataContract]
    public partial class ControllerServiceDTO :  IEquatable<ControllerServiceDTO>, IValidatableObject
    {
        /// <summary>
        /// The state of the controller service.
        /// </summary>
        /// <value>The state of the controller service.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StateEnum
        {
            
            /// <summary>
            /// Enum ENABLED for value: ENABLED
            /// </summary>
            [EnumMember(Value = "ENABLED")]
            ENABLED = 1,
            
            /// <summary>
            /// Enum ENABLING for value: ENABLING
            /// </summary>
            [EnumMember(Value = "ENABLING")]
            ENABLING = 2,
            
            /// <summary>
            /// Enum DISABLED for value: DISABLED
            /// </summary>
            [EnumMember(Value = "DISABLED")]
            DISABLED = 3,
            
            /// <summary>
            /// Enum DISABLING for value: DISABLING
            /// </summary>
            [EnumMember(Value = "DISABLING")]
            DISABLING = 4
        }

        /// <summary>
        /// The state of the controller service.
        /// </summary>
        /// <value>The state of the controller service.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        /// <summary>
        /// Indicates whether the ControllerService is valid, invalid, or still in the process of validating (i.e., it is unknown whether or not the ControllerService is valid)
        /// </summary>
        /// <value>Indicates whether the ControllerService is valid, invalid, or still in the process of validating (i.e., it is unknown whether or not the ControllerService is valid)</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ValidationStatusEnum
        {
            
            /// <summary>
            /// Enum VALID for value: VALID
            /// </summary>
            [EnumMember(Value = "VALID")]
            VALID = 1,
            
            /// <summary>
            /// Enum INVALID for value: INVALID
            /// </summary>
            [EnumMember(Value = "INVALID")]
            INVALID = 2,
            
            /// <summary>
            /// Enum VALIDATING for value: VALIDATING
            /// </summary>
            [EnumMember(Value = "VALIDATING")]
            VALIDATING = 3
        }

        /// <summary>
        /// Indicates whether the ControllerService is valid, invalid, or still in the process of validating (i.e., it is unknown whether or not the ControllerService is valid)
        /// </summary>
        /// <value>Indicates whether the ControllerService is valid, invalid, or still in the process of validating (i.e., it is unknown whether or not the ControllerService is valid)</value>
        [DataMember(Name="validationStatus", EmitDefaultValue=false)]
        public ValidationStatusEnum? ValidationStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ControllerServiceDTO" /> class.
        /// </summary>
        /// <param name="id">The id of the component..</param>
        /// <param name="versionedComponentId">The ID of the corresponding component that is under version control.</param>
        /// <param name="parentGroupId">The id of parent process group of this component if applicable..</param>
        /// <param name="position">The position of this component in the UI if applicable..</param>
        /// <param name="name">The name of the controller service..</param>
        /// <param name="type">The type of the controller service..</param>
        /// <param name="bundle">The details of the artifact that bundled this processor type..</param>
        /// <param name="controllerServiceApis">Lists the APIs this Controller Service implements..</param>
        /// <param name="comments">The comments for the controller service..</param>
        /// <param name="state">The state of the controller service..</param>
        /// <param name="persistsState">Whether the controller service persists state..</param>
        /// <param name="restricted">Whether the controller service requires elevated privileges..</param>
        /// <param name="deprecated">Whether the ontroller service has been deprecated..</param>
        /// <param name="multipleVersionsAvailable">Whether the controller service has multiple versions available..</param>
        /// <param name="properties">The properties of the controller service..</param>
        /// <param name="descriptors">The descriptors for the controller service properties..</param>
        /// <param name="customUiUrl">The URL for the controller services custom configuration UI if applicable..</param>
        /// <param name="annotationData">The annotation for the controller service. This is how the custom UI relays configuration to the controller service..</param>
        /// <param name="referencingComponents">All components referencing this controller service..</param>
        /// <param name="validationErrors">The validation errors from the controller service. These validation errors represent the problems with the controller service that must be resolved before it can be enabled..</param>
        /// <param name="extensionMissing">Whether the underlying extension is missing..</param>
        public ControllerServiceDTO(string id = default(string), string versionedComponentId = default(string), string parentGroupId = default(string), PositionDTO position = default(PositionDTO), string name = default(string), string type = default(string), BundleDTO bundle = default(BundleDTO), List<ControllerServiceApiDTO> controllerServiceApis = default(List<ControllerServiceApiDTO>), string comments = default(string), StateEnum? state = default(StateEnum?), bool? persistsState = default(bool?), bool? restricted = default(bool?), bool? deprecated = default(bool?), bool? multipleVersionsAvailable = default(bool?), Dictionary<string, string> properties = default(Dictionary<string, string>), Dictionary<string, PropertyDescriptorDTO> descriptors = default(Dictionary<string, PropertyDescriptorDTO>), string customUiUrl = default(string), string annotationData = default(string), List<ControllerServiceReferencingComponentEntity> referencingComponents = default(List<ControllerServiceReferencingComponentEntity>), List<string> validationErrors = default(List<string>), bool? extensionMissing = default(bool?))
        {
            this.Id = id;
            this.VersionedComponentId = versionedComponentId;
            this.ParentGroupId = parentGroupId;
            this.Position = position;
            this.Name = name;
            this.Type = type;
            this.Bundle = bundle;
            this.ControllerServiceApis = controllerServiceApis;
            this.Comments = comments;
            this.State = state;
            this.PersistsState = persistsState;
            this.Restricted = restricted;
            this.Deprecated = deprecated;
            this.MultipleVersionsAvailable = multipleVersionsAvailable;
            this.Properties = properties;
            this.Descriptors = descriptors;
            this.CustomUiUrl = customUiUrl;
            this.AnnotationData = annotationData;
            this.ReferencingComponents = referencingComponents;
            this.ValidationErrors = validationErrors;
            this.ExtensionMissing = extensionMissing;
        }
        
        /// <summary>
        /// The id of the component.
        /// </summary>
        /// <value>The id of the component.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The ID of the corresponding component that is under version control
        /// </summary>
        /// <value>The ID of the corresponding component that is under version control</value>
        [DataMember(Name="versionedComponentId", EmitDefaultValue=false)]
        public string VersionedComponentId { get; set; }

        /// <summary>
        /// The id of parent process group of this component if applicable.
        /// </summary>
        /// <value>The id of parent process group of this component if applicable.</value>
        [DataMember(Name="parentGroupId", EmitDefaultValue=false)]
        public string ParentGroupId { get; set; }

        /// <summary>
        /// The position of this component in the UI if applicable.
        /// </summary>
        /// <value>The position of this component in the UI if applicable.</value>
        [DataMember(Name="position", EmitDefaultValue=false)]
        public PositionDTO Position { get; set; }

        /// <summary>
        /// The name of the controller service.
        /// </summary>
        /// <value>The name of the controller service.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The type of the controller service.
        /// </summary>
        /// <value>The type of the controller service.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// The details of the artifact that bundled this processor type.
        /// </summary>
        /// <value>The details of the artifact that bundled this processor type.</value>
        [DataMember(Name="bundle", EmitDefaultValue=false)]
        public BundleDTO Bundle { get; set; }

        /// <summary>
        /// Lists the APIs this Controller Service implements.
        /// </summary>
        /// <value>Lists the APIs this Controller Service implements.</value>
        [DataMember(Name="controllerServiceApis", EmitDefaultValue=false)]
        public List<ControllerServiceApiDTO> ControllerServiceApis { get; set; }

        /// <summary>
        /// The comments for the controller service.
        /// </summary>
        /// <value>The comments for the controller service.</value>
        [DataMember(Name="comments", EmitDefaultValue=false)]
        public string Comments { get; set; }


        /// <summary>
        /// Whether the controller service persists state.
        /// </summary>
        /// <value>Whether the controller service persists state.</value>
        [DataMember(Name="persistsState", EmitDefaultValue=false)]
        public bool? PersistsState { get; set; }

        /// <summary>
        /// Whether the controller service requires elevated privileges.
        /// </summary>
        /// <value>Whether the controller service requires elevated privileges.</value>
        [DataMember(Name="restricted", EmitDefaultValue=false)]
        public bool? Restricted { get; set; }

        /// <summary>
        /// Whether the ontroller service has been deprecated.
        /// </summary>
        /// <value>Whether the ontroller service has been deprecated.</value>
        [DataMember(Name="deprecated", EmitDefaultValue=false)]
        public bool? Deprecated { get; set; }

        /// <summary>
        /// Whether the controller service has multiple versions available.
        /// </summary>
        /// <value>Whether the controller service has multiple versions available.</value>
        [DataMember(Name="multipleVersionsAvailable", EmitDefaultValue=false)]
        public bool? MultipleVersionsAvailable { get; set; }

        /// <summary>
        /// The properties of the controller service.
        /// </summary>
        /// <value>The properties of the controller service.</value>
        [DataMember(Name="properties", EmitDefaultValue=false)]
        public Dictionary<string, string> Properties { get; set; }

        /// <summary>
        /// The descriptors for the controller service properties.
        /// </summary>
        /// <value>The descriptors for the controller service properties.</value>
        [DataMember(Name="descriptors", EmitDefaultValue=false)]
        public Dictionary<string, PropertyDescriptorDTO> Descriptors { get; set; }

        /// <summary>
        /// The URL for the controller services custom configuration UI if applicable.
        /// </summary>
        /// <value>The URL for the controller services custom configuration UI if applicable.</value>
        [DataMember(Name="customUiUrl", EmitDefaultValue=false)]
        public string CustomUiUrl { get; set; }

        /// <summary>
        /// The annotation for the controller service. This is how the custom UI relays configuration to the controller service.
        /// </summary>
        /// <value>The annotation for the controller service. This is how the custom UI relays configuration to the controller service.</value>
        [DataMember(Name="annotationData", EmitDefaultValue=false)]
        public string AnnotationData { get; set; }

        /// <summary>
        /// All components referencing this controller service.
        /// </summary>
        /// <value>All components referencing this controller service.</value>
        [DataMember(Name="referencingComponents", EmitDefaultValue=false)]
        public List<ControllerServiceReferencingComponentEntity> ReferencingComponents { get; set; }

        /// <summary>
        /// The validation errors from the controller service. These validation errors represent the problems with the controller service that must be resolved before it can be enabled.
        /// </summary>
        /// <value>The validation errors from the controller service. These validation errors represent the problems with the controller service that must be resolved before it can be enabled.</value>
        [DataMember(Name="validationErrors", EmitDefaultValue=false)]
        public List<string> ValidationErrors { get; set; }


        /// <summary>
        /// Whether the underlying extension is missing.
        /// </summary>
        /// <value>Whether the underlying extension is missing.</value>
        [DataMember(Name="extensionMissing", EmitDefaultValue=false)]
        public bool? ExtensionMissing { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ControllerServiceDTO {\n");
            sb.Append("  Id: ").Append(this.Id).Append("\n");
            sb.Append("  VersionedComponentId: ").Append(this.VersionedComponentId).Append("\n");
            sb.Append("  ParentGroupId: ").Append(this.ParentGroupId).Append("\n");
            sb.Append("  Position: ").Append(this.Position).Append("\n");
            sb.Append("  Name: ").Append(this.Name).Append("\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  Bundle: ").Append(this.Bundle).Append("\n");
            sb.Append("  ControllerServiceApis: ").Append(this.ControllerServiceApis).Append("\n");
            sb.Append("  Comments: ").Append(this.Comments).Append("\n");
            sb.Append("  State: ").Append(this.State).Append("\n");
            sb.Append("  PersistsState: ").Append(this.PersistsState).Append("\n");
            sb.Append("  Restricted: ").Append(this.Restricted).Append("\n");
            sb.Append("  Deprecated: ").Append(this.Deprecated).Append("\n");
            sb.Append("  MultipleVersionsAvailable: ").Append(this.MultipleVersionsAvailable).Append("\n");
            sb.Append("  Properties: ").Append(this.Properties).Append("\n");
            sb.Append("  Descriptors: ").Append(this.Descriptors).Append("\n");
            sb.Append("  CustomUiUrl: ").Append(this.CustomUiUrl).Append("\n");
            sb.Append("  AnnotationData: ").Append(this.AnnotationData).Append("\n");
            sb.Append("  ReferencingComponents: ").Append(this.ReferencingComponents).Append("\n");
            sb.Append("  ValidationErrors: ").Append(this.ValidationErrors).Append("\n");
            sb.Append("  ValidationStatus: ").Append(this.ValidationStatus).Append("\n");
            sb.Append("  ExtensionMissing: ").Append(this.ExtensionMissing).Append("\n");
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
            return this.Equals(input as ControllerServiceDTO);
        }

        /// <summary>
        /// Returns true if ControllerServiceDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of ControllerServiceDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ControllerServiceDTO input)
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
                    this.VersionedComponentId == input.VersionedComponentId ||
                    (this.VersionedComponentId != null &&
                    this.VersionedComponentId.Equals(input.VersionedComponentId))
                ) && 
                (
                    this.ParentGroupId == input.ParentGroupId ||
                    (this.ParentGroupId != null &&
                    this.ParentGroupId.Equals(input.ParentGroupId))
                ) && 
                (
                    this.Position == input.Position ||
                    (this.Position != null &&
                    this.Position.Equals(input.Position))
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
                    this.Bundle == input.Bundle ||
                    (this.Bundle != null &&
                    this.Bundle.Equals(input.Bundle))
                ) && 
                (
                    this.ControllerServiceApis == input.ControllerServiceApis ||
                    this.ControllerServiceApis != null &&
                    this.ControllerServiceApis.SequenceEqual(input.ControllerServiceApis)
                ) && 
                (
                    this.Comments == input.Comments ||
                    (this.Comments != null &&
                    this.Comments.Equals(input.Comments))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.PersistsState == input.PersistsState ||
                    (this.PersistsState != null &&
                    this.PersistsState.Equals(input.PersistsState))
                ) && 
                (
                    this.Restricted == input.Restricted ||
                    (this.Restricted != null &&
                    this.Restricted.Equals(input.Restricted))
                ) && 
                (
                    this.Deprecated == input.Deprecated ||
                    (this.Deprecated != null &&
                    this.Deprecated.Equals(input.Deprecated))
                ) && 
                (
                    this.MultipleVersionsAvailable == input.MultipleVersionsAvailable ||
                    (this.MultipleVersionsAvailable != null &&
                    this.MultipleVersionsAvailable.Equals(input.MultipleVersionsAvailable))
                ) && 
                (
                    this.Properties == input.Properties ||
                    this.Properties != null &&
                    this.Properties.SequenceEqual(input.Properties)
                ) && 
                (
                    this.Descriptors == input.Descriptors ||
                    this.Descriptors != null &&
                    this.Descriptors.SequenceEqual(input.Descriptors)
                ) && 
                (
                    this.CustomUiUrl == input.CustomUiUrl ||
                    (this.CustomUiUrl != null &&
                    this.CustomUiUrl.Equals(input.CustomUiUrl))
                ) && 
                (
                    this.AnnotationData == input.AnnotationData ||
                    (this.AnnotationData != null &&
                    this.AnnotationData.Equals(input.AnnotationData))
                ) && 
                (
                    this.ReferencingComponents == input.ReferencingComponents ||
                    this.ReferencingComponents != null &&
                    this.ReferencingComponents.SequenceEqual(input.ReferencingComponents)
                ) && 
                (
                    this.ValidationErrors == input.ValidationErrors ||
                    this.ValidationErrors != null &&
                    this.ValidationErrors.SequenceEqual(input.ValidationErrors)
                ) && 
                (
                    this.ValidationStatus == input.ValidationStatus ||
                    (this.ValidationStatus != null &&
                    this.ValidationStatus.Equals(input.ValidationStatus))
                ) && 
                (
                    this.ExtensionMissing == input.ExtensionMissing ||
                    (this.ExtensionMissing != null &&
                    this.ExtensionMissing.Equals(input.ExtensionMissing))
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
                if (this.VersionedComponentId != null)
                    hashCode = hashCode * 59 + this.VersionedComponentId.GetHashCode();
                if (this.ParentGroupId != null)
                    hashCode = hashCode * 59 + this.ParentGroupId.GetHashCode();
                if (this.Position != null)
                    hashCode = hashCode * 59 + this.Position.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Bundle != null)
                    hashCode = hashCode * 59 + this.Bundle.GetHashCode();
                if (this.ControllerServiceApis != null)
                    hashCode = hashCode * 59 + this.ControllerServiceApis.GetHashCode();
                if (this.Comments != null)
                    hashCode = hashCode * 59 + this.Comments.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.PersistsState != null)
                    hashCode = hashCode * 59 + this.PersistsState.GetHashCode();
                if (this.Restricted != null)
                    hashCode = hashCode * 59 + this.Restricted.GetHashCode();
                if (this.Deprecated != null)
                    hashCode = hashCode * 59 + this.Deprecated.GetHashCode();
                if (this.MultipleVersionsAvailable != null)
                    hashCode = hashCode * 59 + this.MultipleVersionsAvailable.GetHashCode();
                if (this.Properties != null)
                    hashCode = hashCode * 59 + this.Properties.GetHashCode();
                if (this.Descriptors != null)
                    hashCode = hashCode * 59 + this.Descriptors.GetHashCode();
                if (this.CustomUiUrl != null)
                    hashCode = hashCode * 59 + this.CustomUiUrl.GetHashCode();
                if (this.AnnotationData != null)
                    hashCode = hashCode * 59 + this.AnnotationData.GetHashCode();
                if (this.ReferencingComponents != null)
                    hashCode = hashCode * 59 + this.ReferencingComponents.GetHashCode();
                if (this.ValidationErrors != null)
                    hashCode = hashCode * 59 + this.ValidationErrors.GetHashCode();
                if (this.ValidationStatus != null)
                    hashCode = hashCode * 59 + this.ValidationStatus.GetHashCode();
                if (this.ExtensionMissing != null)
                    hashCode = hashCode * 59 + this.ExtensionMissing.GetHashCode();
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
