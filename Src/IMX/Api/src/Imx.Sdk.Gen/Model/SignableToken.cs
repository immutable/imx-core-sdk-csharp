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
    /// SignableToken
    /// </summary>
    [DataContract(Name = "SignableToken")]
    public partial class SignableToken : IEquatable<SignableToken>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SignableToken" /> class.
        /// </summary>
        /// <param name="data">Token data. See https://docs.x.immutable.com/docs/token-data-object.</param>
        /// <param name="type">Type of token.</param>
        public SignableToken(Object data = default(Object), string type = default(string))
        {
            this.Data = data;
            this.Type = type;
        }

        /// <summary>
        /// Token data. See https://docs.x.immutable.com/docs/token-data-object
        /// </summary>
        /// <value>Token data. See https://docs.x.immutable.com/docs/token-data-object</value>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        public Object Data { get; set; }

        /// <summary>
        /// Type of token
        /// </summary>
        /// <value>Type of token</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SignableToken {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as SignableToken);
        }

        /// <summary>
        /// Returns true if SignableToken instances are equal
        /// </summary>
        /// <param name="input">Instance of SignableToken to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SignableToken input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Data == input.Data ||
                    (this.Data != null &&
                    this.Data.Equals(input.Data))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Data != null)
                {
                    hashCode = (hashCode * 59) + this.Data.GetHashCode();
                }
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
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