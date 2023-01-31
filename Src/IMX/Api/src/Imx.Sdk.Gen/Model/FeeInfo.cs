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
    /// FeeInfo
    /// </summary>
    [DataContract(Name = "FeeInfo")]
    public partial class FeeInfo : IEquatable<FeeInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FeeInfo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FeeInfo() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FeeInfo" /> class.
        /// </summary>
        /// <param name="assetId">ID of the asset these fees relate to (required).</param>
        /// <param name="feeLimit">Fee limit (required).</param>
        /// <param name="sourceVaultId">ID of vault the asset belong to (required).</param>
        public FeeInfo(string assetId = default(string), string feeLimit = default(string), int sourceVaultId = default(int))
        {
            // to ensure "assetId" is required (not null)
            if (assetId == null)
            {
                throw new ArgumentNullException("assetId is a required property for FeeInfo and cannot be null");
            }
            this.AssetId = assetId;
            // to ensure "feeLimit" is required (not null)
            if (feeLimit == null)
            {
                throw new ArgumentNullException("feeLimit is a required property for FeeInfo and cannot be null");
            }
            this.FeeLimit = feeLimit;
            this.SourceVaultId = sourceVaultId;
        }

        /// <summary>
        /// ID of the asset these fees relate to
        /// </summary>
        /// <value>ID of the asset these fees relate to</value>
        [DataMember(Name = "asset_id", IsRequired = true, EmitDefaultValue = true)]
        public string AssetId { get; set; }

        /// <summary>
        /// Fee limit
        /// </summary>
        /// <value>Fee limit</value>
        [DataMember(Name = "fee_limit", IsRequired = true, EmitDefaultValue = true)]
        public string FeeLimit { get; set; }

        /// <summary>
        /// ID of vault the asset belong to
        /// </summary>
        /// <value>ID of vault the asset belong to</value>
        [DataMember(Name = "source_vault_id", IsRequired = true, EmitDefaultValue = true)]
        public int SourceVaultId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FeeInfo {\n");
            sb.Append("  AssetId: ").Append(AssetId).Append("\n");
            sb.Append("  FeeLimit: ").Append(FeeLimit).Append("\n");
            sb.Append("  SourceVaultId: ").Append(SourceVaultId).Append("\n");
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
            return this.Equals(input as FeeInfo);
        }

        /// <summary>
        /// Returns true if FeeInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of FeeInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FeeInfo input)
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
                    this.FeeLimit == input.FeeLimit ||
                    (this.FeeLimit != null &&
                    this.FeeLimit.Equals(input.FeeLimit))
                ) && 
                (
                    this.SourceVaultId == input.SourceVaultId ||
                    this.SourceVaultId.Equals(input.SourceVaultId)
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
                if (this.FeeLimit != null)
                {
                    hashCode = (hashCode * 59) + this.FeeLimit.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SourceVaultId.GetHashCode();
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
