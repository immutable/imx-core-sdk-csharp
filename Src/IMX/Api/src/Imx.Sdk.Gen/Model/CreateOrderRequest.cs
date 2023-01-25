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
    /// CreateOrderRequest
    /// </summary>
    [DataContract(Name = "CreateOrderRequest")]
    public partial class CreateOrderRequest : IEquatable<CreateOrderRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrderRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateOrderRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrderRequest" /> class.
        /// </summary>
        /// <param name="amountBuy">Amount to buy (required).</param>
        /// <param name="amountSell">Amount to sell (required).</param>
        /// <param name="assetIdBuy">ID of the asset to buy (required).</param>
        /// <param name="assetIdSell">ID of the asset to sell (required).</param>
        /// <param name="expirationTimestamp">Expiration timestamp for this order (required).</param>
        /// <param name="fees">Fee information.</param>
        /// <param name="includeFees">Whether to include fees in order.</param>
        /// <param name="nonce">Nonce of the order (required).</param>
        /// <param name="starkKey">Public stark key of the user creating order (required).</param>
        /// <param name="starkSignature">Payload signature (required).</param>
        /// <param name="vaultIdBuy">ID of the vault into which the bought asset will be placed (required).</param>
        /// <param name="vaultIdSell">ID of the vault to sell from (required).</param>
        public CreateOrderRequest(string amountBuy = default(string), string amountSell = default(string), string assetIdBuy = default(string), string assetIdSell = default(string), int expirationTimestamp = default(int), List<FeeEntry> fees = default(List<FeeEntry>), bool includeFees = default(bool), int nonce = default(int), string starkKey = default(string), string starkSignature = default(string), int vaultIdBuy = default(int), int vaultIdSell = default(int))
        {
            // to ensure "amountBuy" is required (not null)
            if (amountBuy == null)
            {
                throw new ArgumentNullException("amountBuy is a required property for CreateOrderRequest and cannot be null");
            }
            this.AmountBuy = amountBuy;
            // to ensure "amountSell" is required (not null)
            if (amountSell == null)
            {
                throw new ArgumentNullException("amountSell is a required property for CreateOrderRequest and cannot be null");
            }
            this.AmountSell = amountSell;
            // to ensure "assetIdBuy" is required (not null)
            if (assetIdBuy == null)
            {
                throw new ArgumentNullException("assetIdBuy is a required property for CreateOrderRequest and cannot be null");
            }
            this.AssetIdBuy = assetIdBuy;
            // to ensure "assetIdSell" is required (not null)
            if (assetIdSell == null)
            {
                throw new ArgumentNullException("assetIdSell is a required property for CreateOrderRequest and cannot be null");
            }
            this.AssetIdSell = assetIdSell;
            this.ExpirationTimestamp = expirationTimestamp;
            this.Nonce = nonce;
            // to ensure "starkKey" is required (not null)
            if (starkKey == null)
            {
                throw new ArgumentNullException("starkKey is a required property for CreateOrderRequest and cannot be null");
            }
            this.StarkKey = starkKey;
            // to ensure "starkSignature" is required (not null)
            if (starkSignature == null)
            {
                throw new ArgumentNullException("starkSignature is a required property for CreateOrderRequest and cannot be null");
            }
            this.StarkSignature = starkSignature;
            this.VaultIdBuy = vaultIdBuy;
            this.VaultIdSell = vaultIdSell;
            this.Fees = fees;
            this.IncludeFees = includeFees;
        }

        /// <summary>
        /// Amount to buy
        /// </summary>
        /// <value>Amount to buy</value>
        [DataMember(Name = "amount_buy", IsRequired = true, EmitDefaultValue = true)]
        public string AmountBuy { get; set; }

        /// <summary>
        /// Amount to sell
        /// </summary>
        /// <value>Amount to sell</value>
        [DataMember(Name = "amount_sell", IsRequired = true, EmitDefaultValue = true)]
        public string AmountSell { get; set; }

        /// <summary>
        /// ID of the asset to buy
        /// </summary>
        /// <value>ID of the asset to buy</value>
        [DataMember(Name = "asset_id_buy", IsRequired = true, EmitDefaultValue = true)]
        public string AssetIdBuy { get; set; }

        /// <summary>
        /// ID of the asset to sell
        /// </summary>
        /// <value>ID of the asset to sell</value>
        [DataMember(Name = "asset_id_sell", IsRequired = true, EmitDefaultValue = true)]
        public string AssetIdSell { get; set; }

        /// <summary>
        /// Expiration timestamp for this order
        /// </summary>
        /// <value>Expiration timestamp for this order</value>
        [DataMember(Name = "expiration_timestamp", IsRequired = true, EmitDefaultValue = true)]
        public int ExpirationTimestamp { get; set; }

        /// <summary>
        /// Fee information
        /// </summary>
        /// <value>Fee information</value>
        [DataMember(Name = "fees", EmitDefaultValue = false)]
        public List<FeeEntry> Fees { get; set; }

        /// <summary>
        /// Whether to include fees in order
        /// </summary>
        /// <value>Whether to include fees in order</value>
        [DataMember(Name = "include_fees", EmitDefaultValue = true)]
        public bool IncludeFees { get; set; }

        /// <summary>
        /// Nonce of the order
        /// </summary>
        /// <value>Nonce of the order</value>
        [DataMember(Name = "nonce", IsRequired = true, EmitDefaultValue = true)]
        public int Nonce { get; set; }

        /// <summary>
        /// Public stark key of the user creating order
        /// </summary>
        /// <value>Public stark key of the user creating order</value>
        [DataMember(Name = "stark_key", IsRequired = true, EmitDefaultValue = true)]
        public string StarkKey { get; set; }

        /// <summary>
        /// Payload signature
        /// </summary>
        /// <value>Payload signature</value>
        [DataMember(Name = "stark_signature", IsRequired = true, EmitDefaultValue = true)]
        public string StarkSignature { get; set; }

        /// <summary>
        /// ID of the vault into which the bought asset will be placed
        /// </summary>
        /// <value>ID of the vault into which the bought asset will be placed</value>
        [DataMember(Name = "vault_id_buy", IsRequired = true, EmitDefaultValue = true)]
        public int VaultIdBuy { get; set; }

        /// <summary>
        /// ID of the vault to sell from
        /// </summary>
        /// <value>ID of the vault to sell from</value>
        [DataMember(Name = "vault_id_sell", IsRequired = true, EmitDefaultValue = true)]
        public int VaultIdSell { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateOrderRequest {\n");
            sb.Append("  AmountBuy: ").Append(AmountBuy).Append("\n");
            sb.Append("  AmountSell: ").Append(AmountSell).Append("\n");
            sb.Append("  AssetIdBuy: ").Append(AssetIdBuy).Append("\n");
            sb.Append("  AssetIdSell: ").Append(AssetIdSell).Append("\n");
            sb.Append("  ExpirationTimestamp: ").Append(ExpirationTimestamp).Append("\n");
            sb.Append("  Fees: ").Append(Fees).Append("\n");
            sb.Append("  IncludeFees: ").Append(IncludeFees).Append("\n");
            sb.Append("  Nonce: ").Append(Nonce).Append("\n");
            sb.Append("  StarkKey: ").Append(StarkKey).Append("\n");
            sb.Append("  StarkSignature: ").Append(StarkSignature).Append("\n");
            sb.Append("  VaultIdBuy: ").Append(VaultIdBuy).Append("\n");
            sb.Append("  VaultIdSell: ").Append(VaultIdSell).Append("\n");
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
            return this.Equals(input as CreateOrderRequest);
        }

        /// <summary>
        /// Returns true if CreateOrderRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateOrderRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateOrderRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AmountBuy == input.AmountBuy ||
                    (this.AmountBuy != null &&
                    this.AmountBuy.Equals(input.AmountBuy))
                ) && 
                (
                    this.AmountSell == input.AmountSell ||
                    (this.AmountSell != null &&
                    this.AmountSell.Equals(input.AmountSell))
                ) && 
                (
                    this.AssetIdBuy == input.AssetIdBuy ||
                    (this.AssetIdBuy != null &&
                    this.AssetIdBuy.Equals(input.AssetIdBuy))
                ) && 
                (
                    this.AssetIdSell == input.AssetIdSell ||
                    (this.AssetIdSell != null &&
                    this.AssetIdSell.Equals(input.AssetIdSell))
                ) && 
                (
                    this.ExpirationTimestamp == input.ExpirationTimestamp ||
                    this.ExpirationTimestamp.Equals(input.ExpirationTimestamp)
                ) && 
                (
                    this.Fees == input.Fees ||
                    this.Fees != null &&
                    input.Fees != null &&
                    this.Fees.SequenceEqual(input.Fees)
                ) && 
                (
                    this.IncludeFees == input.IncludeFees ||
                    this.IncludeFees.Equals(input.IncludeFees)
                ) && 
                (
                    this.Nonce == input.Nonce ||
                    this.Nonce.Equals(input.Nonce)
                ) && 
                (
                    this.StarkKey == input.StarkKey ||
                    (this.StarkKey != null &&
                    this.StarkKey.Equals(input.StarkKey))
                ) && 
                (
                    this.StarkSignature == input.StarkSignature ||
                    (this.StarkSignature != null &&
                    this.StarkSignature.Equals(input.StarkSignature))
                ) && 
                (
                    this.VaultIdBuy == input.VaultIdBuy ||
                    this.VaultIdBuy.Equals(input.VaultIdBuy)
                ) && 
                (
                    this.VaultIdSell == input.VaultIdSell ||
                    this.VaultIdSell.Equals(input.VaultIdSell)
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
                if (this.AmountBuy != null)
                {
                    hashCode = (hashCode * 59) + this.AmountBuy.GetHashCode();
                }
                if (this.AmountSell != null)
                {
                    hashCode = (hashCode * 59) + this.AmountSell.GetHashCode();
                }
                if (this.AssetIdBuy != null)
                {
                    hashCode = (hashCode * 59) + this.AssetIdBuy.GetHashCode();
                }
                if (this.AssetIdSell != null)
                {
                    hashCode = (hashCode * 59) + this.AssetIdSell.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ExpirationTimestamp.GetHashCode();
                if (this.Fees != null)
                {
                    hashCode = (hashCode * 59) + this.Fees.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IncludeFees.GetHashCode();
                hashCode = (hashCode * 59) + this.Nonce.GetHashCode();
                if (this.StarkKey != null)
                {
                    hashCode = (hashCode * 59) + this.StarkKey.GetHashCode();
                }
                if (this.StarkSignature != null)
                {
                    hashCode = (hashCode * 59) + this.StarkSignature.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.VaultIdBuy.GetHashCode();
                hashCode = (hashCode * 59) + this.VaultIdSell.GetHashCode();
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