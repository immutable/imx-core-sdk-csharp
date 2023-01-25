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
    /// GetSignableRegistrationResponse
    /// </summary>
    [DataContract(Name = "GetSignableRegistrationResponse")]
    public partial class GetSignableRegistrationResponse : IEquatable<GetSignableRegistrationResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetSignableRegistrationResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetSignableRegistrationResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetSignableRegistrationResponse" /> class.
        /// </summary>
        /// <param name="operatorSignature">Signature from authorised operator (required).</param>
        /// <param name="payloadHash">Hash of the payload to be signed for user registration (required).</param>
        public GetSignableRegistrationResponse(string operatorSignature = default(string), string payloadHash = default(string))
        {
            // to ensure "operatorSignature" is required (not null)
            if (operatorSignature == null)
            {
                throw new ArgumentNullException("operatorSignature is a required property for GetSignableRegistrationResponse and cannot be null");
            }
            this.OperatorSignature = operatorSignature;
            // to ensure "payloadHash" is required (not null)
            if (payloadHash == null)
            {
                throw new ArgumentNullException("payloadHash is a required property for GetSignableRegistrationResponse and cannot be null");
            }
            this.PayloadHash = payloadHash;
        }

        /// <summary>
        /// Signature from authorised operator
        /// </summary>
        /// <value>Signature from authorised operator</value>
        [DataMember(Name = "operator_signature", IsRequired = true, EmitDefaultValue = true)]
        public string OperatorSignature { get; set; }

        /// <summary>
        /// Hash of the payload to be signed for user registration
        /// </summary>
        /// <value>Hash of the payload to be signed for user registration</value>
        [DataMember(Name = "payload_hash", IsRequired = true, EmitDefaultValue = true)]
        public string PayloadHash { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetSignableRegistrationResponse {\n");
            sb.Append("  OperatorSignature: ").Append(OperatorSignature).Append("\n");
            sb.Append("  PayloadHash: ").Append(PayloadHash).Append("\n");
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
            return this.Equals(input as GetSignableRegistrationResponse);
        }

        /// <summary>
        /// Returns true if GetSignableRegistrationResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GetSignableRegistrationResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetSignableRegistrationResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.OperatorSignature == input.OperatorSignature ||
                    (this.OperatorSignature != null &&
                    this.OperatorSignature.Equals(input.OperatorSignature))
                ) && 
                (
                    this.PayloadHash == input.PayloadHash ||
                    (this.PayloadHash != null &&
                    this.PayloadHash.Equals(input.PayloadHash))
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
                if (this.OperatorSignature != null)
                {
                    hashCode = (hashCode * 59) + this.OperatorSignature.GetHashCode();
                }
                if (this.PayloadHash != null)
                {
                    hashCode = (hashCode * 59) + this.PayloadHash.GetHashCode();
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