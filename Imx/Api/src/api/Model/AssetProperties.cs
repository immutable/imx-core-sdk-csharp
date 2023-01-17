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
using OpenAPIDateConverter = api.Client.OpenAPIDateConverter;

namespace api.Model
{
    /// <summary>
    /// AssetProperties
    /// </summary>
    [DataContract(Name = "AssetProperties")]
    public partial class AssetProperties : IEquatable<AssetProperties>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AssetProperties" /> class.
        /// </summary>
        /// <param name="collection">collection.</param>
        /// <param name="imageUrl">Image URL of this asset.</param>
        /// <param name="name">Name of this asset.</param>
        public AssetProperties(CollectionDetails collection = default(CollectionDetails), string imageUrl = default(string), string name = default(string))
        {
            this.Collection = collection;
            this.ImageUrl = imageUrl;
            this.Name = name;
        }

        /// <summary>
        /// Gets or Sets Collection
        /// </summary>
        [DataMember(Name = "collection", EmitDefaultValue = false)]
        public CollectionDetails Collection { get; set; }

        /// <summary>
        /// Image URL of this asset
        /// </summary>
        /// <value>Image URL of this asset</value>
        [DataMember(Name = "image_url", EmitDefaultValue = false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// Name of this asset
        /// </summary>
        /// <value>Name of this asset</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AssetProperties {\n");
            sb.Append("  Collection: ").Append(Collection).Append("\n");
            sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as AssetProperties);
        }

        /// <summary>
        /// Returns true if AssetProperties instances are equal
        /// </summary>
        /// <param name="input">Instance of AssetProperties to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AssetProperties input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Collection == input.Collection ||
                    (this.Collection != null &&
                    this.Collection.Equals(input.Collection))
                ) && 
                (
                    this.ImageUrl == input.ImageUrl ||
                    (this.ImageUrl != null &&
                    this.ImageUrl.Equals(input.ImageUrl))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.Collection != null)
                {
                    hashCode = (hashCode * 59) + this.Collection.GetHashCode();
                }
                if (this.ImageUrl != null)
                {
                    hashCode = (hashCode * 59) + this.ImageUrl.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
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
