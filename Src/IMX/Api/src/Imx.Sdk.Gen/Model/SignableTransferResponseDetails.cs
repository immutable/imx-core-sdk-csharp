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
    /// SignableTransferResponseDetails
    /// </summary>
    [DataContract(Name = "SignableTransferResponseDetails")]
    public partial class SignableTransferResponseDetails : IEquatable<SignableTransferResponseDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SignableTransferResponseDetails" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SignableTransferResponseDetails() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SignableTransferResponseDetails" /> class.
        /// </summary>
        /// <param name="amount">Amount of the asset being transferred (required).</param>
        /// <param name="assetId">ID of the asset being transferred (required).</param>
        /// <param name="expirationTimestamp">Timestamp when this transfer will expire (required).</param>
        /// <param name="nonce">Nonce of the transfer (required).</param>
        /// <param name="payloadHash">Hash of the payload to be signed for transfer (required).</param>
        /// <param name="receiverStarkKey">Receiver of the transfer (required).</param>
        /// <param name="receiverVaultId">ID of the vault being transferred to (required).</param>
        /// <param name="senderVaultId">ID of the vault being transferred from (required).</param>
        /// <param name="token">token (required).</param>
        public SignableTransferResponseDetails(string amount = default(string), string assetId = default(string), int expirationTimestamp = default(int), int nonce = default(int), string payloadHash = default(string), string receiverStarkKey = default(string), int receiverVaultId = default(int), int senderVaultId = default(int), SignableToken token = default(SignableToken))
        {
            // to ensure "amount" is required (not null)
            if (amount == null)
            {
                throw new ArgumentNullException("amount is a required property for SignableTransferResponseDetails and cannot be null");
            }
            this.Amount = amount;
            // to ensure "assetId" is required (not null)
            if (assetId == null)
            {
                throw new ArgumentNullException("assetId is a required property for SignableTransferResponseDetails and cannot be null");
            }
            this.AssetId = assetId;
            this.ExpirationTimestamp = expirationTimestamp;
            this.Nonce = nonce;
            // to ensure "payloadHash" is required (not null)
            if (payloadHash == null)
            {
                throw new ArgumentNullException("payloadHash is a required property for SignableTransferResponseDetails and cannot be null");
            }
            this.PayloadHash = payloadHash;
            // to ensure "receiverStarkKey" is required (not null)
            if (receiverStarkKey == null)
            {
                throw new ArgumentNullException("receiverStarkKey is a required property for SignableTransferResponseDetails and cannot be null");
            }
            this.ReceiverStarkKey = receiverStarkKey;
            this.ReceiverVaultId = receiverVaultId;
            this.SenderVaultId = senderVaultId;
            // to ensure "token" is required (not null)
            if (token == null)
            {
                throw new ArgumentNullException("token is a required property for SignableTransferResponseDetails and cannot be null");
            }
            this.Token = token;
        }

        /// <summary>
        /// Amount of the asset being transferred
        /// </summary>
        /// <value>Amount of the asset being transferred</value>
        [DataMember(Name = "amount", IsRequired = true, EmitDefaultValue = true)]
        public string Amount { get; set; }

        /// <summary>
        /// ID of the asset being transferred
        /// </summary>
        /// <value>ID of the asset being transferred</value>
        [DataMember(Name = "asset_id", IsRequired = true, EmitDefaultValue = true)]
        public string AssetId { get; set; }

        /// <summary>
        /// Timestamp when this transfer will expire
        /// </summary>
        /// <value>Timestamp when this transfer will expire</value>
        [DataMember(Name = "expiration_timestamp", IsRequired = true, EmitDefaultValue = true)]
        public int ExpirationTimestamp { get; set; }

        /// <summary>
        /// Nonce of the transfer
        /// </summary>
        /// <value>Nonce of the transfer</value>
        [DataMember(Name = "nonce", IsRequired = true, EmitDefaultValue = true)]
        public int Nonce { get; set; }

        /// <summary>
        /// Hash of the payload to be signed for transfer
        /// </summary>
        /// <value>Hash of the payload to be signed for transfer</value>
        [DataMember(Name = "payload_hash", IsRequired = true, EmitDefaultValue = true)]
        public string PayloadHash { get; set; }

        /// <summary>
        /// Receiver of the transfer
        /// </summary>
        /// <value>Receiver of the transfer</value>
        [DataMember(Name = "receiver_stark_key", IsRequired = true, EmitDefaultValue = true)]
        public string ReceiverStarkKey { get; set; }

        /// <summary>
        /// ID of the vault being transferred to
        /// </summary>
        /// <value>ID of the vault being transferred to</value>
        [DataMember(Name = "receiver_vault_id", IsRequired = true, EmitDefaultValue = true)]
        public int ReceiverVaultId { get; set; }

        /// <summary>
        /// ID of the vault being transferred from
        /// </summary>
        /// <value>ID of the vault being transferred from</value>
        [DataMember(Name = "sender_vault_id", IsRequired = true, EmitDefaultValue = true)]
        public int SenderVaultId { get; set; }

        /// <summary>
        /// Gets or Sets Token
        /// </summary>
        [DataMember(Name = "token", IsRequired = true, EmitDefaultValue = true)]
        public SignableToken Token { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SignableTransferResponseDetails {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  AssetId: ").Append(AssetId).Append("\n");
            sb.Append("  ExpirationTimestamp: ").Append(ExpirationTimestamp).Append("\n");
            sb.Append("  Nonce: ").Append(Nonce).Append("\n");
            sb.Append("  PayloadHash: ").Append(PayloadHash).Append("\n");
            sb.Append("  ReceiverStarkKey: ").Append(ReceiverStarkKey).Append("\n");
            sb.Append("  ReceiverVaultId: ").Append(ReceiverVaultId).Append("\n");
            sb.Append("  SenderVaultId: ").Append(SenderVaultId).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
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
            return this.Equals(input as SignableTransferResponseDetails);
        }

        /// <summary>
        /// Returns true if SignableTransferResponseDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of SignableTransferResponseDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SignableTransferResponseDetails input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.AssetId == input.AssetId ||
                    (this.AssetId != null &&
                    this.AssetId.Equals(input.AssetId))
                ) && 
                (
                    this.ExpirationTimestamp == input.ExpirationTimestamp ||
                    this.ExpirationTimestamp.Equals(input.ExpirationTimestamp)
                ) && 
                (
                    this.Nonce == input.Nonce ||
                    this.Nonce.Equals(input.Nonce)
                ) && 
                (
                    this.PayloadHash == input.PayloadHash ||
                    (this.PayloadHash != null &&
                    this.PayloadHash.Equals(input.PayloadHash))
                ) && 
                (
                    this.ReceiverStarkKey == input.ReceiverStarkKey ||
                    (this.ReceiverStarkKey != null &&
                    this.ReceiverStarkKey.Equals(input.ReceiverStarkKey))
                ) && 
                (
                    this.ReceiverVaultId == input.ReceiverVaultId ||
                    this.ReceiverVaultId.Equals(input.ReceiverVaultId)
                ) && 
                (
                    this.SenderVaultId == input.SenderVaultId ||
                    this.SenderVaultId.Equals(input.SenderVaultId)
                ) && 
                (
                    this.Token == input.Token ||
                    (this.Token != null &&
                    this.Token.Equals(input.Token))
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
                if (this.Amount != null)
                {
                    hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                }
                if (this.AssetId != null)
                {
                    hashCode = (hashCode * 59) + this.AssetId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ExpirationTimestamp.GetHashCode();
                hashCode = (hashCode * 59) + this.Nonce.GetHashCode();
                if (this.PayloadHash != null)
                {
                    hashCode = (hashCode * 59) + this.PayloadHash.GetHashCode();
                }
                if (this.ReceiverStarkKey != null)
                {
                    hashCode = (hashCode * 59) + this.ReceiverStarkKey.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ReceiverVaultId.GetHashCode();
                hashCode = (hashCode * 59) + this.SenderVaultId.GetHashCode();
                if (this.Token != null)
                {
                    hashCode = (hashCode * 59) + this.Token.GetHashCode();
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