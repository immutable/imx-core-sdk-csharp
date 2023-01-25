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
    /// Exchange
    /// </summary>
    [DataContract(Name = "Exchange")]
    public partial class Exchange : IEquatable<Exchange>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Exchange" /> class.
        /// </summary>
        /// <param name="createdAt">Time this transaction was created.</param>
        /// <param name="data">data.</param>
        /// <param name="id">Transaction ID.</param>
        /// <param name="provider">Provider name.</param>
        /// <param name="status">Transaction status.</param>
        /// <param name="type">Transaction type.</param>
        /// <param name="updatedAt">Time this transaction was updates.</param>
        /// <param name="walletAddress">Ethereum address of the user who created transaction.</param>
        public Exchange(string createdAt = default(string), OptionalExchangeData data = default(OptionalExchangeData), int id = default(int), string provider = default(string), string status = default(string), string type = default(string), string updatedAt = default(string), string walletAddress = default(string))
        {
            this.CreatedAt = createdAt;
            this.Data = data;
            this.Id = id;
            this.Provider = provider;
            this.Status = status;
            this.Type = type;
            this.UpdatedAt = updatedAt;
            this.WalletAddress = walletAddress;
        }

        /// <summary>
        /// Time this transaction was created
        /// </summary>
        /// <value>Time this transaction was created</value>
        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        public OptionalExchangeData Data { get; set; }

        /// <summary>
        /// Transaction ID
        /// </summary>
        /// <value>Transaction ID</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Provider name
        /// </summary>
        /// <value>Provider name</value>
        [DataMember(Name = "provider", EmitDefaultValue = false)]
        public string Provider { get; set; }

        /// <summary>
        /// Transaction status
        /// </summary>
        /// <value>Transaction status</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Transaction type
        /// </summary>
        /// <value>Transaction type</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Time this transaction was updates
        /// </summary>
        /// <value>Time this transaction was updates</value>
        [DataMember(Name = "updated_at", EmitDefaultValue = false)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// Ethereum address of the user who created transaction
        /// </summary>
        /// <value>Ethereum address of the user who created transaction</value>
        [DataMember(Name = "wallet_address", EmitDefaultValue = false)]
        public string WalletAddress { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Exchange {\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Provider: ").Append(Provider).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  WalletAddress: ").Append(WalletAddress).Append("\n");
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
            return this.Equals(input as Exchange);
        }

        /// <summary>
        /// Returns true if Exchange instances are equal
        /// </summary>
        /// <param name="input">Instance of Exchange to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Exchange input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.Data == input.Data ||
                    (this.Data != null &&
                    this.Data.Equals(input.Data))
                ) && 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.Provider == input.Provider ||
                    (this.Provider != null &&
                    this.Provider.Equals(input.Provider))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.WalletAddress == input.WalletAddress ||
                    (this.WalletAddress != null &&
                    this.WalletAddress.Equals(input.WalletAddress))
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
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.Data != null)
                {
                    hashCode = (hashCode * 59) + this.Data.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Id.GetHashCode();
                if (this.Provider != null)
                {
                    hashCode = (hashCode * 59) + this.Provider.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
                }
                if (this.UpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
                }
                if (this.WalletAddress != null)
                {
                    hashCode = (hashCode * 59) + this.WalletAddress.GetHashCode();
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