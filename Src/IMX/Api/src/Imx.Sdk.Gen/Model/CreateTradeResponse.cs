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
    /// CreateTradeResponse
    /// </summary>
    [DataContract(Name = "CreateTradeResponse")]
    public partial class CreateTradeResponse : IEquatable<CreateTradeResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTradeResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateTradeResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTradeResponse" /> class.
        /// </summary>
        /// <param name="requestId">Request ID as a reference for an asynchronous trade creation request.</param>
        /// <param name="status">Current status of trade (required).</param>
        /// <param name="tradeId">ID of trade within Immutable X (required).</param>
        public CreateTradeResponse(string requestId = default(string), string status = default(string), int tradeId = default(int))
        {
            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new ArgumentNullException("status is a required property for CreateTradeResponse and cannot be null");
            }
            this.Status = status;
            this.TradeId = tradeId;
            this.RequestId = requestId;
        }

        /// <summary>
        /// Request ID as a reference for an asynchronous trade creation request
        /// </summary>
        /// <value>Request ID as a reference for an asynchronous trade creation request</value>
        [DataMember(Name = "request_id", EmitDefaultValue = false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Current status of trade
        /// </summary>
        /// <value>Current status of trade</value>
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = true)]
        public string Status { get; set; }

        /// <summary>
        /// ID of trade within Immutable X
        /// </summary>
        /// <value>ID of trade within Immutable X</value>
        [DataMember(Name = "trade_id", IsRequired = true, EmitDefaultValue = true)]
        public int TradeId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateTradeResponse {\n");
            sb.Append("  RequestId: ").Append(RequestId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  TradeId: ").Append(TradeId).Append("\n");
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
            return this.Equals(input as CreateTradeResponse);
        }

        /// <summary>
        /// Returns true if CreateTradeResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateTradeResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateTradeResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.RequestId == input.RequestId ||
                    (this.RequestId != null &&
                    this.RequestId.Equals(input.RequestId))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.TradeId == input.TradeId ||
                    this.TradeId.Equals(input.TradeId)
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
                if (this.RequestId != null)
                {
                    hashCode = (hashCode * 59) + this.RequestId.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TradeId.GetHashCode();
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