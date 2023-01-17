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
    /// TradeSide
    /// </summary>
    [DataContract(Name = "TradeSide")]
    public partial class TradeSide : IEquatable<TradeSide>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TradeSide" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TradeSide() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TradeSide" /> class.
        /// </summary>
        /// <param name="orderId">The ID of the order involved in the trade (required).</param>
        /// <param name="sold">The amount of that order&#39;s asset this trade sold (required).</param>
        /// <param name="tokenAddress">The contract address of the token that this trade sold.</param>
        /// <param name="tokenId">The ID of the token that this trade sold.</param>
        /// <param name="tokenType">The type of the token that this trade sold (required).</param>
        public TradeSide(int orderId = default(int), string sold = default(string), string tokenAddress = default(string), string tokenId = default(string), string tokenType = default(string))
        {
            this.OrderId = orderId;
            // to ensure "sold" is required (not null)
            if (sold == null)
            {
                throw new ArgumentNullException("sold is a required property for TradeSide and cannot be null");
            }
            this.Sold = sold;
            // to ensure "tokenType" is required (not null)
            if (tokenType == null)
            {
                throw new ArgumentNullException("tokenType is a required property for TradeSide and cannot be null");
            }
            this.TokenType = tokenType;
            this.TokenAddress = tokenAddress;
            this.TokenId = tokenId;
        }

        /// <summary>
        /// The ID of the order involved in the trade
        /// </summary>
        /// <value>The ID of the order involved in the trade</value>
        [DataMember(Name = "order_id", IsRequired = true, EmitDefaultValue = true)]
        public int OrderId { get; set; }

        /// <summary>
        /// The amount of that order&#39;s asset this trade sold
        /// </summary>
        /// <value>The amount of that order&#39;s asset this trade sold</value>
        [DataMember(Name = "sold", IsRequired = true, EmitDefaultValue = true)]
        public string Sold { get; set; }

        /// <summary>
        /// The contract address of the token that this trade sold
        /// </summary>
        /// <value>The contract address of the token that this trade sold</value>
        [DataMember(Name = "token_address", EmitDefaultValue = false)]
        public string TokenAddress { get; set; }

        /// <summary>
        /// The ID of the token that this trade sold
        /// </summary>
        /// <value>The ID of the token that this trade sold</value>
        [DataMember(Name = "token_id", EmitDefaultValue = false)]
        public string TokenId { get; set; }

        /// <summary>
        /// The type of the token that this trade sold
        /// </summary>
        /// <value>The type of the token that this trade sold</value>
        [DataMember(Name = "token_type", IsRequired = true, EmitDefaultValue = true)]
        public string TokenType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TradeSide {\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  Sold: ").Append(Sold).Append("\n");
            sb.Append("  TokenAddress: ").Append(TokenAddress).Append("\n");
            sb.Append("  TokenId: ").Append(TokenId).Append("\n");
            sb.Append("  TokenType: ").Append(TokenType).Append("\n");
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
            return this.Equals(input as TradeSide);
        }

        /// <summary>
        /// Returns true if TradeSide instances are equal
        /// </summary>
        /// <param name="input">Instance of TradeSide to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TradeSide input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.OrderId == input.OrderId ||
                    this.OrderId.Equals(input.OrderId)
                ) && 
                (
                    this.Sold == input.Sold ||
                    (this.Sold != null &&
                    this.Sold.Equals(input.Sold))
                ) && 
                (
                    this.TokenAddress == input.TokenAddress ||
                    (this.TokenAddress != null &&
                    this.TokenAddress.Equals(input.TokenAddress))
                ) && 
                (
                    this.TokenId == input.TokenId ||
                    (this.TokenId != null &&
                    this.TokenId.Equals(input.TokenId))
                ) && 
                (
                    this.TokenType == input.TokenType ||
                    (this.TokenType != null &&
                    this.TokenType.Equals(input.TokenType))
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
                hashCode = (hashCode * 59) + this.OrderId.GetHashCode();
                if (this.Sold != null)
                {
                    hashCode = (hashCode * 59) + this.Sold.GetHashCode();
                }
                if (this.TokenAddress != null)
                {
                    hashCode = (hashCode * 59) + this.TokenAddress.GetHashCode();
                }
                if (this.TokenId != null)
                {
                    hashCode = (hashCode * 59) + this.TokenId.GetHashCode();
                }
                if (this.TokenType != null)
                {
                    hashCode = (hashCode * 59) + this.TokenType.GetHashCode();
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
