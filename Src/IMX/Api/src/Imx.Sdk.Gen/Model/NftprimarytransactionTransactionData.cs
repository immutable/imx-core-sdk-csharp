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
    /// NftprimarytransactionTransactionData
    /// </summary>
    [DataContract(Name = "nftprimarytransaction.TransactionData")]
    public partial class NftprimarytransactionTransactionData : IEquatable<NftprimarytransactionTransactionData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NftprimarytransactionTransactionData" /> class.
        /// </summary>
        /// <param name="contractAddress">Contract address of the asset.</param>
        /// <param name="createdAt">Timestamp when the transaction was created.</param>
        /// <param name="externalId">External transaction id.</param>
        /// <param name="feesAmount">Fees to pay on this transaction.</param>
        /// <param name="fromAmount">Amount of the currency specified in &#x60;from_currency&#x60; that the buyer paid for the transaction.</param>
        /// <param name="fromCurrency">Currency that the buyer used for the transaction.</param>
        /// <param name="mintId">Minting transaction ID - see mintTokens response.</param>
        /// <param name="mintStatus">Mint status.</param>
        /// <param name="offerId">Temporary asset id. Might be a token id if the token id is known or a generic description if it&#39;s not.</param>
        /// <param name="provider">Provider name.</param>
        /// <param name="sellerWalletAddress">Ethereum address of the seller.</param>
        /// <param name="status">Transaction status enums(created, waitingPayment, pending, completed, failed).</param>
        /// <param name="toAmount">Amount of the currency specified in &#x60;to_currency&#x60; that the seller received from the checkout provider for the transaction.</param>
        /// <param name="toCurrency">Currency (crypto) that the checkout provider sent to the seller for the transaction.</param>
        /// <param name="tokenId">ID of the token that has been successfully minted - should be the same as &#x60;offer_id&#x60;.</param>
        /// <param name="transactionId">Transaction id.</param>
        /// <param name="updatedAt">Timestamp when the transaction was updated.</param>
        /// <param name="userWalletAddress">Wallet address that receives the minted NFT.</param>
        public NftprimarytransactionTransactionData(string contractAddress = default(string), string createdAt = default(string), string externalId = default(string), decimal feesAmount = default(decimal), decimal fromAmount = default(decimal), string fromCurrency = default(string), string mintId = default(string), string mintStatus = default(string), string offerId = default(string), string provider = default(string), string sellerWalletAddress = default(string), string status = default(string), decimal toAmount = default(decimal), string toCurrency = default(string), string tokenId = default(string), string transactionId = default(string), string updatedAt = default(string), string userWalletAddress = default(string))
        {
            this.ContractAddress = contractAddress;
            this.CreatedAt = createdAt;
            this.ExternalId = externalId;
            this.FeesAmount = feesAmount;
            this.FromAmount = fromAmount;
            this.FromCurrency = fromCurrency;
            this.MintId = mintId;
            this.MintStatus = mintStatus;
            this.OfferId = offerId;
            this.Provider = provider;
            this.SellerWalletAddress = sellerWalletAddress;
            this.Status = status;
            this.ToAmount = toAmount;
            this.ToCurrency = toCurrency;
            this.TokenId = tokenId;
            this.TransactionId = transactionId;
            this.UpdatedAt = updatedAt;
            this.UserWalletAddress = userWalletAddress;
        }

        /// <summary>
        /// Contract address of the asset
        /// </summary>
        /// <value>Contract address of the asset</value>
        [DataMember(Name = "contract_address", EmitDefaultValue = false)]
        public string ContractAddress { get; set; }

        /// <summary>
        /// Timestamp when the transaction was created
        /// </summary>
        /// <value>Timestamp when the transaction was created</value>
        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// External transaction id
        /// </summary>
        /// <value>External transaction id</value>
        [DataMember(Name = "external_id", EmitDefaultValue = false)]
        public string ExternalId { get; set; }

        /// <summary>
        /// Fees to pay on this transaction
        /// </summary>
        /// <value>Fees to pay on this transaction</value>
        [DataMember(Name = "fees_amount", EmitDefaultValue = false)]
        public decimal FeesAmount { get; set; }

        /// <summary>
        /// Amount of the currency specified in &#x60;from_currency&#x60; that the buyer paid for the transaction
        /// </summary>
        /// <value>Amount of the currency specified in &#x60;from_currency&#x60; that the buyer paid for the transaction</value>
        [DataMember(Name = "from_amount", EmitDefaultValue = false)]
        public decimal FromAmount { get; set; }

        /// <summary>
        /// Currency that the buyer used for the transaction
        /// </summary>
        /// <value>Currency that the buyer used for the transaction</value>
        [DataMember(Name = "from_currency", EmitDefaultValue = false)]
        public string FromCurrency { get; set; }

        /// <summary>
        /// Minting transaction ID - see mintTokens response
        /// </summary>
        /// <value>Minting transaction ID - see mintTokens response</value>
        [DataMember(Name = "mint_id", EmitDefaultValue = false)]
        public string MintId { get; set; }

        /// <summary>
        /// Mint status
        /// </summary>
        /// <value>Mint status</value>
        [DataMember(Name = "mint_status", EmitDefaultValue = false)]
        public string MintStatus { get; set; }

        /// <summary>
        /// Temporary asset id. Might be a token id if the token id is known or a generic description if it&#39;s not
        /// </summary>
        /// <value>Temporary asset id. Might be a token id if the token id is known or a generic description if it&#39;s not</value>
        [DataMember(Name = "offer_id", EmitDefaultValue = false)]
        public string OfferId { get; set; }

        /// <summary>
        /// Provider name
        /// </summary>
        /// <value>Provider name</value>
        [DataMember(Name = "provider", EmitDefaultValue = false)]
        public string Provider { get; set; }

        /// <summary>
        /// Ethereum address of the seller
        /// </summary>
        /// <value>Ethereum address of the seller</value>
        [DataMember(Name = "seller_wallet_address", EmitDefaultValue = false)]
        public string SellerWalletAddress { get; set; }

        /// <summary>
        /// Transaction status enums(created, waitingPayment, pending, completed, failed)
        /// </summary>
        /// <value>Transaction status enums(created, waitingPayment, pending, completed, failed)</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Amount of the currency specified in &#x60;to_currency&#x60; that the seller received from the checkout provider for the transaction
        /// </summary>
        /// <value>Amount of the currency specified in &#x60;to_currency&#x60; that the seller received from the checkout provider for the transaction</value>
        [DataMember(Name = "to_amount", EmitDefaultValue = false)]
        public decimal ToAmount { get; set; }

        /// <summary>
        /// Currency (crypto) that the checkout provider sent to the seller for the transaction
        /// </summary>
        /// <value>Currency (crypto) that the checkout provider sent to the seller for the transaction</value>
        [DataMember(Name = "to_currency", EmitDefaultValue = false)]
        public string ToCurrency { get; set; }

        /// <summary>
        /// ID of the token that has been successfully minted - should be the same as &#x60;offer_id&#x60;
        /// </summary>
        /// <value>ID of the token that has been successfully minted - should be the same as &#x60;offer_id&#x60;</value>
        [DataMember(Name = "token_id", EmitDefaultValue = false)]
        public string TokenId { get; set; }

        /// <summary>
        /// Transaction id
        /// </summary>
        /// <value>Transaction id</value>
        [DataMember(Name = "transaction_id", EmitDefaultValue = false)]
        public string TransactionId { get; set; }

        /// <summary>
        /// Timestamp when the transaction was updated
        /// </summary>
        /// <value>Timestamp when the transaction was updated</value>
        [DataMember(Name = "updated_at", EmitDefaultValue = false)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// Wallet address that receives the minted NFT
        /// </summary>
        /// <value>Wallet address that receives the minted NFT</value>
        [DataMember(Name = "user_wallet_address", EmitDefaultValue = false)]
        public string UserWalletAddress { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NftprimarytransactionTransactionData {\n");
            sb.Append("  ContractAddress: ").Append(ContractAddress).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  FeesAmount: ").Append(FeesAmount).Append("\n");
            sb.Append("  FromAmount: ").Append(FromAmount).Append("\n");
            sb.Append("  FromCurrency: ").Append(FromCurrency).Append("\n");
            sb.Append("  MintId: ").Append(MintId).Append("\n");
            sb.Append("  MintStatus: ").Append(MintStatus).Append("\n");
            sb.Append("  OfferId: ").Append(OfferId).Append("\n");
            sb.Append("  Provider: ").Append(Provider).Append("\n");
            sb.Append("  SellerWalletAddress: ").Append(SellerWalletAddress).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  ToAmount: ").Append(ToAmount).Append("\n");
            sb.Append("  ToCurrency: ").Append(ToCurrency).Append("\n");
            sb.Append("  TokenId: ").Append(TokenId).Append("\n");
            sb.Append("  TransactionId: ").Append(TransactionId).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  UserWalletAddress: ").Append(UserWalletAddress).Append("\n");
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
            return this.Equals(input as NftprimarytransactionTransactionData);
        }

        /// <summary>
        /// Returns true if NftprimarytransactionTransactionData instances are equal
        /// </summary>
        /// <param name="input">Instance of NftprimarytransactionTransactionData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NftprimarytransactionTransactionData input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ContractAddress == input.ContractAddress ||
                    (this.ContractAddress != null &&
                    this.ContractAddress.Equals(input.ContractAddress))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.ExternalId == input.ExternalId ||
                    (this.ExternalId != null &&
                    this.ExternalId.Equals(input.ExternalId))
                ) && 
                (
                    this.FeesAmount == input.FeesAmount ||
                    this.FeesAmount.Equals(input.FeesAmount)
                ) && 
                (
                    this.FromAmount == input.FromAmount ||
                    this.FromAmount.Equals(input.FromAmount)
                ) && 
                (
                    this.FromCurrency == input.FromCurrency ||
                    (this.FromCurrency != null &&
                    this.FromCurrency.Equals(input.FromCurrency))
                ) && 
                (
                    this.MintId == input.MintId ||
                    (this.MintId != null &&
                    this.MintId.Equals(input.MintId))
                ) && 
                (
                    this.MintStatus == input.MintStatus ||
                    (this.MintStatus != null &&
                    this.MintStatus.Equals(input.MintStatus))
                ) && 
                (
                    this.OfferId == input.OfferId ||
                    (this.OfferId != null &&
                    this.OfferId.Equals(input.OfferId))
                ) && 
                (
                    this.Provider == input.Provider ||
                    (this.Provider != null &&
                    this.Provider.Equals(input.Provider))
                ) && 
                (
                    this.SellerWalletAddress == input.SellerWalletAddress ||
                    (this.SellerWalletAddress != null &&
                    this.SellerWalletAddress.Equals(input.SellerWalletAddress))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.ToAmount == input.ToAmount ||
                    this.ToAmount.Equals(input.ToAmount)
                ) && 
                (
                    this.ToCurrency == input.ToCurrency ||
                    (this.ToCurrency != null &&
                    this.ToCurrency.Equals(input.ToCurrency))
                ) && 
                (
                    this.TokenId == input.TokenId ||
                    (this.TokenId != null &&
                    this.TokenId.Equals(input.TokenId))
                ) && 
                (
                    this.TransactionId == input.TransactionId ||
                    (this.TransactionId != null &&
                    this.TransactionId.Equals(input.TransactionId))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.UserWalletAddress == input.UserWalletAddress ||
                    (this.UserWalletAddress != null &&
                    this.UserWalletAddress.Equals(input.UserWalletAddress))
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
                if (this.ContractAddress != null)
                {
                    hashCode = (hashCode * 59) + this.ContractAddress.GetHashCode();
                }
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.ExternalId != null)
                {
                    hashCode = (hashCode * 59) + this.ExternalId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.FeesAmount.GetHashCode();
                hashCode = (hashCode * 59) + this.FromAmount.GetHashCode();
                if (this.FromCurrency != null)
                {
                    hashCode = (hashCode * 59) + this.FromCurrency.GetHashCode();
                }
                if (this.MintId != null)
                {
                    hashCode = (hashCode * 59) + this.MintId.GetHashCode();
                }
                if (this.MintStatus != null)
                {
                    hashCode = (hashCode * 59) + this.MintStatus.GetHashCode();
                }
                if (this.OfferId != null)
                {
                    hashCode = (hashCode * 59) + this.OfferId.GetHashCode();
                }
                if (this.Provider != null)
                {
                    hashCode = (hashCode * 59) + this.Provider.GetHashCode();
                }
                if (this.SellerWalletAddress != null)
                {
                    hashCode = (hashCode * 59) + this.SellerWalletAddress.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ToAmount.GetHashCode();
                if (this.ToCurrency != null)
                {
                    hashCode = (hashCode * 59) + this.ToCurrency.GetHashCode();
                }
                if (this.TokenId != null)
                {
                    hashCode = (hashCode * 59) + this.TokenId.GetHashCode();
                }
                if (this.TransactionId != null)
                {
                    hashCode = (hashCode * 59) + this.TransactionId.GetHashCode();
                }
                if (this.UpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
                }
                if (this.UserWalletAddress != null)
                {
                    hashCode = (hashCode * 59) + this.UserWalletAddress.GetHashCode();
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