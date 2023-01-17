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
    /// CancelOrderResponse
    /// </summary>
    [DataContract(Name = "CancelOrderResponse")]
    public partial class CancelOrderResponse : IEquatable<CancelOrderResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CancelOrderResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CancelOrderResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CancelOrderResponse" /> class.
        /// </summary>
        /// <param name="orderId">ID of the cancelled order (required).</param>
        /// <param name="status">New status of the order (required).</param>
        public CancelOrderResponse(int orderId = default(int), string status = default(string))
        {
            this.OrderId = orderId;
            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new ArgumentNullException("status is a required property for CancelOrderResponse and cannot be null");
            }
            this.Status = status;
        }

        /// <summary>
        /// ID of the cancelled order
        /// </summary>
        /// <value>ID of the cancelled order</value>
        [DataMember(Name = "order_id", IsRequired = true, EmitDefaultValue = true)]
        public int OrderId { get; set; }

        /// <summary>
        /// New status of the order
        /// </summary>
        /// <value>New status of the order</value>
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = true)]
        public string Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CancelOrderResponse {\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as CancelOrderResponse);
        }

        /// <summary>
        /// Returns true if CancelOrderResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of CancelOrderResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CancelOrderResponse input)
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
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
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
