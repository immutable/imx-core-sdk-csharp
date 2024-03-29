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
    /// Order
    /// </summary>
    [DataContract(Name = "Order")]
    public partial class Order : IEquatable<Order>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Order" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Order() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Order" /> class.
        /// </summary>
        /// <param name="amountSold">Amount of the asset already sold by this order (required).</param>
        /// <param name="buy">buy (required).</param>
        /// <param name="expirationTimestamp">Expiration timestamp of this order (required).</param>
        /// <param name="fees">Fee information for the order.</param>
        /// <param name="orderId">ID of the order (required).</param>
        /// <param name="sell">sell (required).</param>
        /// <param name="status">Status of the order (required).</param>
        /// <param name="timestamp">Timestamp this order was created (required).</param>
        /// <param name="updatedTimestamp">Updated timestamp of this order (required).</param>
        /// <param name="user">Ethereum address of the user who submitted the order (required).</param>
        public Order(string amountSold = default(string), Token buy = default(Token), string expirationTimestamp = default(string), List<OrderFeeInfo> fees = default(List<OrderFeeInfo>), int orderId = default(int), Token sell = default(Token), string status = default(string), string timestamp = default(string), string updatedTimestamp = default(string), string user = default(string))
        {
            // to ensure "amountSold" is required (not null)
            if (amountSold == null)
            {
                throw new ArgumentNullException("amountSold is a required property for Order and cannot be null");
            }
            this.AmountSold = amountSold;
            // to ensure "buy" is required (not null)
            if (buy == null)
            {
                throw new ArgumentNullException("buy is a required property for Order and cannot be null");
            }
            this.Buy = buy;
            // to ensure "expirationTimestamp" is required (not null)
            if (expirationTimestamp == null)
            {
                throw new ArgumentNullException("expirationTimestamp is a required property for Order and cannot be null");
            }
            this.ExpirationTimestamp = expirationTimestamp;
            this.OrderId = orderId;
            // to ensure "sell" is required (not null)
            if (sell == null)
            {
                throw new ArgumentNullException("sell is a required property for Order and cannot be null");
            }
            this.Sell = sell;
            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new ArgumentNullException("status is a required property for Order and cannot be null");
            }
            this.Status = status;
            // to ensure "timestamp" is required (not null)
            if (timestamp == null)
            {
                throw new ArgumentNullException("timestamp is a required property for Order and cannot be null");
            }
            this.Timestamp = timestamp;
            // to ensure "updatedTimestamp" is required (not null)
            if (updatedTimestamp == null)
            {
                throw new ArgumentNullException("updatedTimestamp is a required property for Order and cannot be null");
            }
            this.UpdatedTimestamp = updatedTimestamp;
            // to ensure "user" is required (not null)
            if (user == null)
            {
                throw new ArgumentNullException("user is a required property for Order and cannot be null");
            }
            this.User = user;
            this.Fees = fees;
        }

        /// <summary>
        /// Amount of the asset already sold by this order
        /// </summary>
        /// <value>Amount of the asset already sold by this order</value>
        [DataMember(Name = "amount_sold", IsRequired = true, EmitDefaultValue = true)]
        public string AmountSold { get; set; }

        /// <summary>
        /// Gets or Sets Buy
        /// </summary>
        [DataMember(Name = "buy", IsRequired = true, EmitDefaultValue = true)]
        public Token Buy { get; set; }

        /// <summary>
        /// Expiration timestamp of this order
        /// </summary>
        /// <value>Expiration timestamp of this order</value>
        [DataMember(Name = "expiration_timestamp", IsRequired = true, EmitDefaultValue = true)]
        public string ExpirationTimestamp { get; set; }

        /// <summary>
        /// Fee information for the order
        /// </summary>
        /// <value>Fee information for the order</value>
        [DataMember(Name = "fees", EmitDefaultValue = false)]
        public List<OrderFeeInfo> Fees { get; set; }

        /// <summary>
        /// ID of the order
        /// </summary>
        /// <value>ID of the order</value>
        [DataMember(Name = "order_id", IsRequired = true, EmitDefaultValue = true)]
        public int OrderId { get; set; }

        /// <summary>
        /// Gets or Sets Sell
        /// </summary>
        [DataMember(Name = "sell", IsRequired = true, EmitDefaultValue = true)]
        public Token Sell { get; set; }

        /// <summary>
        /// Status of the order
        /// </summary>
        /// <value>Status of the order</value>
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = true)]
        public string Status { get; set; }

        /// <summary>
        /// Timestamp this order was created
        /// </summary>
        /// <value>Timestamp this order was created</value>
        [DataMember(Name = "timestamp", IsRequired = true, EmitDefaultValue = true)]
        public string Timestamp { get; set; }

        /// <summary>
        /// Updated timestamp of this order
        /// </summary>
        /// <value>Updated timestamp of this order</value>
        [DataMember(Name = "updated_timestamp", IsRequired = true, EmitDefaultValue = true)]
        public string UpdatedTimestamp { get; set; }

        /// <summary>
        /// Ethereum address of the user who submitted the order
        /// </summary>
        /// <value>Ethereum address of the user who submitted the order</value>
        [DataMember(Name = "user", IsRequired = true, EmitDefaultValue = true)]
        public string User { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Order {\n");
            sb.Append("  AmountSold: ").Append(AmountSold).Append("\n");
            sb.Append("  Buy: ").Append(Buy).Append("\n");
            sb.Append("  ExpirationTimestamp: ").Append(ExpirationTimestamp).Append("\n");
            sb.Append("  Fees: ").Append(Fees).Append("\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  Sell: ").Append(Sell).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  UpdatedTimestamp: ").Append(UpdatedTimestamp).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
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
            return this.Equals(input as Order);
        }

        /// <summary>
        /// Returns true if Order instances are equal
        /// </summary>
        /// <param name="input">Instance of Order to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Order input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AmountSold == input.AmountSold ||
                    (this.AmountSold != null &&
                    this.AmountSold.Equals(input.AmountSold))
                ) && 
                (
                    this.Buy == input.Buy ||
                    (this.Buy != null &&
                    this.Buy.Equals(input.Buy))
                ) && 
                (
                    this.ExpirationTimestamp == input.ExpirationTimestamp ||
                    (this.ExpirationTimestamp != null &&
                    this.ExpirationTimestamp.Equals(input.ExpirationTimestamp))
                ) && 
                (
                    this.Fees == input.Fees ||
                    this.Fees != null &&
                    input.Fees != null &&
                    this.Fees.SequenceEqual(input.Fees)
                ) && 
                (
                    this.OrderId == input.OrderId ||
                    this.OrderId.Equals(input.OrderId)
                ) && 
                (
                    this.Sell == input.Sell ||
                    (this.Sell != null &&
                    this.Sell.Equals(input.Sell))
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
                    this.UpdatedTimestamp == input.UpdatedTimestamp ||
                    (this.UpdatedTimestamp != null &&
                    this.UpdatedTimestamp.Equals(input.UpdatedTimestamp))
                ) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
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
                if (this.AmountSold != null)
                {
                    hashCode = (hashCode * 59) + this.AmountSold.GetHashCode();
                }
                if (this.Buy != null)
                {
                    hashCode = (hashCode * 59) + this.Buy.GetHashCode();
                }
                if (this.ExpirationTimestamp != null)
                {
                    hashCode = (hashCode * 59) + this.ExpirationTimestamp.GetHashCode();
                }
                if (this.Fees != null)
                {
                    hashCode = (hashCode * 59) + this.Fees.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.OrderId.GetHashCode();
                if (this.Sell != null)
                {
                    hashCode = (hashCode * 59) + this.Sell.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                if (this.Timestamp != null)
                {
                    hashCode = (hashCode * 59) + this.Timestamp.GetHashCode();
                }
                if (this.UpdatedTimestamp != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedTimestamp.GetHashCode();
                }
                if (this.User != null)
                {
                    hashCode = (hashCode * 59) + this.User.GetHashCode();
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
