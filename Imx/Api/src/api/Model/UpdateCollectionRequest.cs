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
    /// UpdateCollectionRequest
    /// </summary>
    [DataContract(Name = "UpdateCollectionRequest")]
    public partial class UpdateCollectionRequest : IEquatable<UpdateCollectionRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCollectionRequest" /> class.
        /// </summary>
        /// <param name="collectionImageUrl">URL of the tile image for this collection.</param>
        /// <param name="description">Description of the collection.</param>
        /// <param name="iconUrl">URL of the icon for this collection.</param>
        /// <param name="metadataApiUrl">URL of the metadata for this collection.</param>
        /// <param name="name">Name of the collection.</param>
        public UpdateCollectionRequest(string collectionImageUrl = default(string), string description = default(string), string iconUrl = default(string), string metadataApiUrl = default(string), string name = default(string))
        {
            this.CollectionImageUrl = collectionImageUrl;
            this.Description = description;
            this.IconUrl = iconUrl;
            this.MetadataApiUrl = metadataApiUrl;
            this.Name = name;
        }

        /// <summary>
        /// URL of the tile image for this collection
        /// </summary>
        /// <value>URL of the tile image for this collection</value>
        [DataMember(Name = "collection_image_url", EmitDefaultValue = false)]
        public string CollectionImageUrl { get; set; }

        /// <summary>
        /// Description of the collection
        /// </summary>
        /// <value>Description of the collection</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// URL of the icon for this collection
        /// </summary>
        /// <value>URL of the icon for this collection</value>
        [DataMember(Name = "icon_url", EmitDefaultValue = false)]
        public string IconUrl { get; set; }

        /// <summary>
        /// URL of the metadata for this collection
        /// </summary>
        /// <value>URL of the metadata for this collection</value>
        [DataMember(Name = "metadata_api_url", EmitDefaultValue = false)]
        public string MetadataApiUrl { get; set; }

        /// <summary>
        /// Name of the collection
        /// </summary>
        /// <value>Name of the collection</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UpdateCollectionRequest {\n");
            sb.Append("  CollectionImageUrl: ").Append(CollectionImageUrl).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  IconUrl: ").Append(IconUrl).Append("\n");
            sb.Append("  MetadataApiUrl: ").Append(MetadataApiUrl).Append("\n");
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
            return this.Equals(input as UpdateCollectionRequest);
        }

        /// <summary>
        /// Returns true if UpdateCollectionRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateCollectionRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateCollectionRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CollectionImageUrl == input.CollectionImageUrl ||
                    (this.CollectionImageUrl != null &&
                    this.CollectionImageUrl.Equals(input.CollectionImageUrl))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.IconUrl == input.IconUrl ||
                    (this.IconUrl != null &&
                    this.IconUrl.Equals(input.IconUrl))
                ) && 
                (
                    this.MetadataApiUrl == input.MetadataApiUrl ||
                    (this.MetadataApiUrl != null &&
                    this.MetadataApiUrl.Equals(input.MetadataApiUrl))
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
                if (this.CollectionImageUrl != null)
                {
                    hashCode = (hashCode * 59) + this.CollectionImageUrl.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.IconUrl != null)
                {
                    hashCode = (hashCode * 59) + this.IconUrl.GetHashCode();
                }
                if (this.MetadataApiUrl != null)
                {
                    hashCode = (hashCode * 59) + this.MetadataApiUrl.GetHashCode();
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
