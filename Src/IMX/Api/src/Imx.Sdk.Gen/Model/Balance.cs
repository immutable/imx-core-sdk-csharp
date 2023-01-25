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
    /// Balance
    /// </summary>
    [DataContract(Name = "Balance")]
    public partial class Balance : IEquatable<Balance>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Balance" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Balance() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Balance" /> class.
        /// </summary>
        /// <param name="balance">Amount which is currently inside the exchange (required).</param>
        /// <param name="preparingWithdrawal">Amount which is currently preparing withdrawal from the exchange (required).</param>
        /// <param name="symbol">Symbol of the token (e.g. ETH, IMX) (required).</param>
        /// <param name="tokenAddress">Address of the contract that represents this ERC20 token or empty for ETH (required).</param>
        /// <param name="withdrawable">Amount which is currently withdrawable from the exchange (required).</param>
        public Balance(string balance = default(string), string preparingWithdrawal = default(string), string symbol = default(string), string tokenAddress = default(string), string withdrawable = default(string))
        {
            // to ensure "balance" is required (not null)
            if (balance == null)
            {
                throw new ArgumentNullException("balance is a required property for Balance and cannot be null");
            }
            this._Balance = balance;
            // to ensure "preparingWithdrawal" is required (not null)
            if (preparingWithdrawal == null)
            {
                throw new ArgumentNullException("preparingWithdrawal is a required property for Balance and cannot be null");
            }
            this.PreparingWithdrawal = preparingWithdrawal;
            // to ensure "symbol" is required (not null)
            if (symbol == null)
            {
                throw new ArgumentNullException("symbol is a required property for Balance and cannot be null");
            }
            this.Symbol = symbol;
            // to ensure "tokenAddress" is required (not null)
            if (tokenAddress == null)
            {
                throw new ArgumentNullException("tokenAddress is a required property for Balance and cannot be null");
            }
            this.TokenAddress = tokenAddress;
            // to ensure "withdrawable" is required (not null)
            if (withdrawable == null)
            {
                throw new ArgumentNullException("withdrawable is a required property for Balance and cannot be null");
            }
            this.Withdrawable = withdrawable;
        }

        /// <summary>
        /// Amount which is currently inside the exchange
        /// </summary>
        /// <value>Amount which is currently inside the exchange</value>
        [DataMember(Name = "balance", IsRequired = true, EmitDefaultValue = true)]
        public string _Balance { get; set; }

        /// <summary>
        /// Amount which is currently preparing withdrawal from the exchange
        /// </summary>
        /// <value>Amount which is currently preparing withdrawal from the exchange</value>
        [DataMember(Name = "preparing_withdrawal", IsRequired = true, EmitDefaultValue = true)]
        public string PreparingWithdrawal { get; set; }

        /// <summary>
        /// Symbol of the token (e.g. ETH, IMX)
        /// </summary>
        /// <value>Symbol of the token (e.g. ETH, IMX)</value>
        [DataMember(Name = "symbol", IsRequired = true, EmitDefaultValue = true)]
        public string Symbol { get; set; }

        /// <summary>
        /// Address of the contract that represents this ERC20 token or empty for ETH
        /// </summary>
        /// <value>Address of the contract that represents this ERC20 token or empty for ETH</value>
        [DataMember(Name = "token_address", IsRequired = true, EmitDefaultValue = true)]
        public string TokenAddress { get; set; }

        /// <summary>
        /// Amount which is currently withdrawable from the exchange
        /// </summary>
        /// <value>Amount which is currently withdrawable from the exchange</value>
        [DataMember(Name = "withdrawable", IsRequired = true, EmitDefaultValue = true)]
        public string Withdrawable { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Balance {\n");
            sb.Append("  _Balance: ").Append(_Balance).Append("\n");
            sb.Append("  PreparingWithdrawal: ").Append(PreparingWithdrawal).Append("\n");
            sb.Append("  Symbol: ").Append(Symbol).Append("\n");
            sb.Append("  TokenAddress: ").Append(TokenAddress).Append("\n");
            sb.Append("  Withdrawable: ").Append(Withdrawable).Append("\n");
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
            return this.Equals(input as Balance);
        }

        /// <summary>
        /// Returns true if Balance instances are equal
        /// </summary>
        /// <param name="input">Instance of Balance to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Balance input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this._Balance == input._Balance ||
                    (this._Balance != null &&
                    this._Balance.Equals(input._Balance))
                ) && 
                (
                    this.PreparingWithdrawal == input.PreparingWithdrawal ||
                    (this.PreparingWithdrawal != null &&
                    this.PreparingWithdrawal.Equals(input.PreparingWithdrawal))
                ) && 
                (
                    this.Symbol == input.Symbol ||
                    (this.Symbol != null &&
                    this.Symbol.Equals(input.Symbol))
                ) && 
                (
                    this.TokenAddress == input.TokenAddress ||
                    (this.TokenAddress != null &&
                    this.TokenAddress.Equals(input.TokenAddress))
                ) && 
                (
                    this.Withdrawable == input.Withdrawable ||
                    (this.Withdrawable != null &&
                    this.Withdrawable.Equals(input.Withdrawable))
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
                if (this._Balance != null)
                {
                    hashCode = (hashCode * 59) + this._Balance.GetHashCode();
                }
                if (this.PreparingWithdrawal != null)
                {
                    hashCode = (hashCode * 59) + this.PreparingWithdrawal.GetHashCode();
                }
                if (this.Symbol != null)
                {
                    hashCode = (hashCode * 59) + this.Symbol.GetHashCode();
                }
                if (this.TokenAddress != null)
                {
                    hashCode = (hashCode * 59) + this.TokenAddress.GetHashCode();
                }
                if (this.Withdrawable != null)
                {
                    hashCode = (hashCode * 59) + this.Withdrawable.GetHashCode();
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