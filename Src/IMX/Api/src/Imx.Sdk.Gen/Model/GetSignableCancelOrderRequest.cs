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
    /// GetSignableCancelOrderRequest
    /// </summary>
    [DataContract(Name = "GetSignableCancelOrderRequest")]
    public partial class GetSignableCancelOrderRequest : IEquatable<GetSignableCancelOrderRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetSignableCancelOrderRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetSignableCancelOrderRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetSignableCancelOrderRequest" /> class.
        /// </summary>
        /// <param name="orderId">ID of the order to be cancelled (required).</param>
        public GetSignableCancelOrderRequest(int orderId = default(int))
        {
            this.OrderId = orderId;
        }

        /// <summary>
        /// ID of the order to be cancelled
        /// </summary>
        /// <value>ID of the order to be cancelled</value>
        [DataMember(Name = "order_id", IsRequired = true, EmitDefaultValue = true)]
        public int OrderId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetSignableCancelOrderRequest {\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
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
            return this.Equals(input as GetSignableCancelOrderRequest);
        }

        /// <summary>
        /// Returns true if GetSignableCancelOrderRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of GetSignableCancelOrderRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetSignableCancelOrderRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.OrderId == input.OrderId ||
                    this.OrderId.Equals(input.OrderId)
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