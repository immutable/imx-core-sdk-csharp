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
    /// EncodeAssetResponse
    /// </summary>
    [DataContract(Name = "EncodeAssetResponse")]
    public partial class EncodeAssetResponse : IEquatable<EncodeAssetResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EncodeAssetResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EncodeAssetResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EncodeAssetResponse" /> class.
        /// </summary>
        /// <param name="assetId">Stark encoded asset id (required).</param>
        /// <param name="assetType">Stark encoded asset type (required).</param>
        public EncodeAssetResponse(string assetId = default(string), string assetType = default(string))
        {
            // to ensure "assetId" is required (not null)
            if (assetId == null)
            {
                throw new ArgumentNullException("assetId is a required property for EncodeAssetResponse and cannot be null");
            }
            this.AssetId = assetId;
            // to ensure "assetType" is required (not null)
            if (assetType == null)
            {
                throw new ArgumentNullException("assetType is a required property for EncodeAssetResponse and cannot be null");
            }
            this.AssetType = assetType;
        }

        /// <summary>
        /// Stark encoded asset id
        /// </summary>
        /// <value>Stark encoded asset id</value>
        [DataMember(Name = "asset_id", IsRequired = true, EmitDefaultValue = true)]
        public string AssetId { get; set; }

        /// <summary>
        /// Stark encoded asset type
        /// </summary>
        /// <value>Stark encoded asset type</value>
        [DataMember(Name = "asset_type", IsRequired = true, EmitDefaultValue = true)]
        public string AssetType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EncodeAssetResponse {\n");
            sb.Append("  AssetId: ").Append(AssetId).Append("\n");
            sb.Append("  AssetType: ").Append(AssetType).Append("\n");
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
            return this.Equals(input as EncodeAssetResponse);
        }

        /// <summary>
        /// Returns true if EncodeAssetResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of EncodeAssetResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EncodeAssetResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AssetId == input.AssetId ||
                    (this.AssetId != null &&
                    this.AssetId.Equals(input.AssetId))
                ) && 
                (
                    this.AssetType == input.AssetType ||
                    (this.AssetType != null &&
                    this.AssetType.Equals(input.AssetType))
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
                if (this.AssetId != null)
                {
                    hashCode = (hashCode * 59) + this.AssetId.GetHashCode();
                }
                if (this.AssetType != null)
                {
                    hashCode = (hashCode * 59) + this.AssetType.GetHashCode();
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