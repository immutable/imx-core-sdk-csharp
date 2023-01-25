/*
 * Immutable X API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 3.0
 * Contact: support@immutable.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Imx.Sdk.Gen.Client.OpenAPIDateConverter;

namespace Imx.Sdk.Gen.Model
{
    /// <summary>
    /// MetadataSchemaProperty
    /// </summary>
    [DataContract(Name = "MetadataSchemaProperty")]
    public partial class MetadataSchemaProperty : IEquatable<MetadataSchemaProperty>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataSchemaProperty" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MetadataSchemaProperty() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataSchemaProperty" /> class.
        /// </summary>
        /// <param name="filterable">Sets the metadata as filterable (required).</param>
        /// <param name="name">Name of the metadata key (required).</param>
        /// <param name="type">Type of the metadata. Values: \&quot;enum\&quot;, \&quot;text\&quot;, \&quot;boolean\&quot;, \&quot;continuous\&quot;, \&quot;discrete\&quot; | Default: \&quot;text\&quot;. Src: https://docs.x.immutable.com/docs/asset-metadata#property-type-mapping (required).</param>
        public MetadataSchemaProperty(bool filterable = default(bool), string name = default(string), string type = default(string))
        {
            this.Filterable = filterable;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for MetadataSchemaProperty and cannot be null");
            }
            this.Name = name;
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new ArgumentNullException("type is a required property for MetadataSchemaProperty and cannot be null");
            }
            this.Type = type;
        }

        /// <summary>
        /// Sets the metadata as filterable
        /// </summary>
        /// <value>Sets the metadata as filterable</value>
        [DataMember(Name = "filterable", IsRequired = true, EmitDefaultValue = true)]
        public bool Filterable { get; set; }

        /// <summary>
        /// Name of the metadata key
        /// </summary>
        /// <value>Name of the metadata key</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Type of the metadata. Values: \&quot;enum\&quot;, \&quot;text\&quot;, \&quot;boolean\&quot;, \&quot;continuous\&quot;, \&quot;discrete\&quot; | Default: \&quot;text\&quot;. Src: https://docs.x.immutable.com/docs/asset-metadata#property-type-mapping
        /// </summary>
        /// <value>Type of the metadata. Values: \&quot;enum\&quot;, \&quot;text\&quot;, \&quot;boolean\&quot;, \&quot;continuous\&quot;, \&quot;discrete\&quot; | Default: \&quot;text\&quot;. Src: https://docs.x.immutable.com/docs/asset-metadata#property-type-mapping</value>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MetadataSchemaProperty {\n");
            sb.Append("  Filterable: ").Append(Filterable).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as MetadataSchemaProperty);
        }

        /// <summary>
        /// Returns true if MetadataSchemaProperty instances are equal
        /// </summary>
        /// <param name="input">Instance of MetadataSchemaProperty to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MetadataSchemaProperty input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Filterable == input.Filterable ||
                    this.Filterable.Equals(input.Filterable)
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
                hashCode = (hashCode * 59) + this.Filterable.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}