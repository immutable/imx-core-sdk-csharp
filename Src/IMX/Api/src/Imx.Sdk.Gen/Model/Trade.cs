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
    /// Trade
    /// </summary>
    [DataContract(Name = "Trade")]
    public partial class Trade : IEquatable<Trade>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Trade" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Trade() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Trade" /> class.
        /// </summary>
        /// <param name="a">a (required).</param>
        /// <param name="b">b (required).</param>
        /// <param name="status">Status of this trade (required).</param>
        /// <param name="timestamp">Time this trade occurred (required).</param>
        /// <param name="transactionId">Sequential ID of this trade within Immutable X (required).</param>
        public Trade(TradeSide a = default(TradeSide), TradeSide b = default(TradeSide), string status = default(string), string timestamp = default(string), int transactionId = default(int))
        {
            // to ensure "a" is required (not null)
            if (a == null)
            {
                throw new ArgumentNullException("a is a required property for Trade and cannot be null");
            }
            this.A = a;
            // to ensure "b" is required (not null)
            if (b == null)
            {
                throw new ArgumentNullException("b is a required property for Trade and cannot be null");
            }
            this.B = b;
            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new ArgumentNullException("status is a required property for Trade and cannot be null");
            }
            this.Status = status;
            // to ensure "timestamp" is required (not null)
            if (timestamp == null)
            {
                throw new ArgumentNullException("timestamp is a required property for Trade and cannot be null");
            }
            this.Timestamp = timestamp;
            this.TransactionId = transactionId;
        }

        /// <summary>
        /// Gets or Sets A
        /// </summary>
        [DataMember(Name = "a", IsRequired = true, EmitDefaultValue = true)]
        public TradeSide A { get; set; }

        /// <summary>
        /// Gets or Sets B
        /// </summary>
        [DataMember(Name = "b", IsRequired = true, EmitDefaultValue = true)]
        public TradeSide B { get; set; }

        /// <summary>
        /// Status of this trade
        /// </summary>
        /// <value>Status of this trade</value>
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = true)]
        public string Status { get; set; }

        /// <summary>
        /// Time this trade occurred
        /// </summary>
        /// <value>Time this trade occurred</value>
        [DataMember(Name = "timestamp", IsRequired = true, EmitDefaultValue = true)]
        public string Timestamp { get; set; }

        /// <summary>
        /// Sequential ID of this trade within Immutable X
        /// </summary>
        /// <value>Sequential ID of this trade within Immutable X</value>
        [DataMember(Name = "transaction_id", IsRequired = true, EmitDefaultValue = true)]
        public int TransactionId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Trade {\n");
            sb.Append("  A: ").Append(A).Append("\n");
            sb.Append("  B: ").Append(B).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  TransactionId: ").Append(TransactionId).Append("\n");
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
            return this.Equals(input as Trade);
        }

        /// <summary>
        /// Returns true if Trade instances are equal
        /// </summary>
        /// <param name="input">Instance of Trade to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Trade input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.A == input.A ||
                    (this.A != null &&
                    this.A.Equals(input.A))
                ) && 
                (
                    this.B == input.B ||
                    (this.B != null &&
                    this.B.Equals(input.B))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
                ) && 
                (
                    this.TransactionId == input.TransactionId ||
                    this.TransactionId.Equals(input.TransactionId)
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
                if (this.A != null)
                {
                    hashCode = (hashCode * 59) + this.A.GetHashCode();
                }
                if (this.B != null)
                {
                    hashCode = (hashCode * 59) + this.B.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                if (this.Timestamp != null)
                {
                    hashCode = (hashCode * 59) + this.Timestamp.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TransactionId.GetHashCode();
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
