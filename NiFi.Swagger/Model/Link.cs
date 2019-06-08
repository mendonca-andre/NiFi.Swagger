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
    /// Link
    /// </summary>
    [DataContract]
    public partial class Link :  IEquatable<Link>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Link" /> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="title">title.</param>
        /// <param name="rel">rel.</param>
        /// <param name="rels">rels.</param>
        /// <param name="uriBuilder">uriBuilder.</param>
        /// <param name="_params">_params.</param>
        /// <param name="uri">uri.</param>
        public Link(string type = default(string), string title = default(string), string rel = default(string), List<string> rels = default(List<string>), UriBuilder uriBuilder = default(UriBuilder), Dictionary<string, string> _params = default(Dictionary<string, string>), string uri = default(string))
        {
            this.Type = type;
            this.Title = title;
            this.Rel = rel;
            this.Rels = rels;
            this.UriBuilder = uriBuilder;
            this.Params = _params;
            this.Uri = uri;
        }
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Rel
        /// </summary>
        [DataMember(Name="rel", EmitDefaultValue=false)]
        public string Rel { get; set; }

        /// <summary>
        /// Gets or Sets Rels
        /// </summary>
        [DataMember(Name="rels", EmitDefaultValue=false)]
        public List<string> Rels { get; set; }

        /// <summary>
        /// Gets or Sets UriBuilder
        /// </summary>
        [DataMember(Name="uriBuilder", EmitDefaultValue=false)]
        public UriBuilder UriBuilder { get; set; }

        /// <summary>
        /// Gets or Sets Params
        /// </summary>
        [DataMember(Name="params", EmitDefaultValue=false)]
        public Dictionary<string, string> Params { get; set; }

        /// <summary>
        /// Gets or Sets Uri
        /// </summary>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Link {\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  Title: ").Append(this.Title).Append("\n");
            sb.Append("  Rel: ").Append(this.Rel).Append("\n");
            sb.Append("  Rels: ").Append(this.Rels).Append("\n");
            sb.Append("  UriBuilder: ").Append(this.UriBuilder).Append("\n");
            sb.Append("  Params: ").Append(this.Params).Append("\n");
            sb.Append("  Uri: ").Append(this.Uri).Append("\n");
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
            return this.Equals(input as Link);
        }

        /// <summary>
        /// Returns true if Link instances are equal
        /// </summary>
        /// <param name="input">Instance of Link to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Link input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Rel == input.Rel ||
                    (this.Rel != null &&
                    this.Rel.Equals(input.Rel))
                ) && 
                (
                    this.Rels == input.Rels ||
                    this.Rels != null &&
                    this.Rels.SequenceEqual(input.Rels)
                ) && 
                (
                    this.UriBuilder == input.UriBuilder ||
                    (this.UriBuilder != null &&
                    this.UriBuilder.Equals(input.UriBuilder))
                ) && 
                (
                    this.Params == input.Params ||
                    this.Params != null &&
                    this.Params.SequenceEqual(input.Params)
                ) && 
                (
                    this.Uri == input.Uri ||
                    (this.Uri != null &&
                    this.Uri.Equals(input.Uri))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Rel != null)
                    hashCode = hashCode * 59 + this.Rel.GetHashCode();
                if (this.Rels != null)
                    hashCode = hashCode * 59 + this.Rels.GetHashCode();
                if (this.UriBuilder != null)
                    hashCode = hashCode * 59 + this.UriBuilder.GetHashCode();
                if (this.Params != null)
                    hashCode = hashCode * 59 + this.Params.GetHashCode();
                if (this.Uri != null)
                    hashCode = hashCode * 59 + this.Uri.GetHashCode();
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
