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
    /// RegisterUserResponse
    /// </summary>
    [DataContract(Name = "RegisterUserResponse")]
    public partial class RegisterUserResponse : IEquatable<RegisterUserResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterUserResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RegisterUserResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterUserResponse" /> class.
        /// </summary>
        /// <param name="txHash">Immutable signature authorising registration (required).</param>
        public RegisterUserResponse(string txHash = default(string))
        {
            // to ensure "txHash" is required (not null)
            if (txHash == null)
            {
                throw new ArgumentNullException("txHash is a required property for RegisterUserResponse and cannot be null");
            }
            this.TxHash = txHash;
        }

        /// <summary>
        /// Immutable signature authorising registration
        /// </summary>
        /// <value>Immutable signature authorising registration</value>
        [DataMember(Name = "tx_hash", IsRequired = true, EmitDefaultValue = true)]
        public string TxHash { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RegisterUserResponse {\n");
            sb.Append("  TxHash: ").Append(TxHash).Append("\n");
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
            return this.Equals(input as RegisterUserResponse);
        }

        /// <summary>
        /// Returns true if RegisterUserResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of RegisterUserResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RegisterUserResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.TxHash == input.TxHash ||
                    (this.TxHash != null &&
                    this.TxHash.Equals(input.TxHash))
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
                if (this.TxHash != null)
                {
                    hashCode = (hashCode * 59) + this.TxHash.GetHashCode();
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
