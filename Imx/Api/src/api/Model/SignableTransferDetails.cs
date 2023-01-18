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
    /// SignableTransferDetails
    /// </summary>
    [DataContract(Name = "SignableTransferDetails")]
    public partial class SignableTransferDetails : IEquatable<SignableTransferDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SignableTransferDetails" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SignableTransferDetails() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SignableTransferDetails" /> class.
        /// </summary>
        /// <param name="amount">Amount of the token to transfer (required).</param>
        /// <param name="receiver">Ethereum address of the receiving user (required).</param>
        /// <param name="token">token (required).</param>
        public SignableTransferDetails(string amount = default(string), string receiver = default(string), SignableToken token = default(SignableToken))
        {
            // to ensure "amount" is required (not null)
            if (amount == null)
            {
                throw new ArgumentNullException("amount is a required property for SignableTransferDetails and cannot be null");
            }
            this.Amount = amount;
            // to ensure "receiver" is required (not null)
            if (receiver == null)
            {
                throw new ArgumentNullException("receiver is a required property for SignableTransferDetails and cannot be null");
            }
            this.Receiver = receiver;
            // to ensure "token" is required (not null)
            if (token == null)
            {
                throw new ArgumentNullException("token is a required property for SignableTransferDetails and cannot be null");
            }
            this.Token = token;
        }

        /// <summary>
        /// Amount of the token to transfer
        /// </summary>
        /// <value>Amount of the token to transfer</value>
        [DataMember(Name = "amount", IsRequired = true, EmitDefaultValue = true)]
        public string Amount { get; set; }

        /// <summary>
        /// Ethereum address of the receiving user
        /// </summary>
        /// <value>Ethereum address of the receiving user</value>
        [DataMember(Name = "receiver", IsRequired = true, EmitDefaultValue = true)]
        public string Receiver { get; set; }

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
            sb.Append("class SignableTransferDetails {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Receiver: ").Append(Receiver).Append("\n");
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
            return this.Equals(input as SignableTransferDetails);
        }

        /// <summary>
        /// Returns true if SignableTransferDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of SignableTransferDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SignableTransferDetails input)
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
                    this.Receiver == input.Receiver ||
                    (this.Receiver != null &&
                    this.Receiver.Equals(input.Receiver))
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
                if (this.Receiver != null)
                {
                    hashCode = (hashCode * 59) + this.Receiver.GetHashCode();
                }
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
