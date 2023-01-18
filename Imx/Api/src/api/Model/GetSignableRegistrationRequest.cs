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
    /// GetSignableRegistrationRequest
    /// </summary>
    [DataContract(Name = "GetSignableRegistrationRequest")]
    public partial class GetSignableRegistrationRequest : IEquatable<GetSignableRegistrationRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetSignableRegistrationRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetSignableRegistrationRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetSignableRegistrationRequest" /> class.
        /// </summary>
        /// <param name="etherKey">Ether key of user (required).</param>
        /// <param name="starkKey">Public stark key of the user (required).</param>
        public GetSignableRegistrationRequest(string etherKey = default(string), string starkKey = default(string))
        {
            // to ensure "etherKey" is required (not null)
            if (etherKey == null)
            {
                throw new ArgumentNullException("etherKey is a required property for GetSignableRegistrationRequest and cannot be null");
            }
            this.EtherKey = etherKey;
            // to ensure "starkKey" is required (not null)
            if (starkKey == null)
            {
                throw new ArgumentNullException("starkKey is a required property for GetSignableRegistrationRequest and cannot be null");
            }
            this.StarkKey = starkKey;
        }

        /// <summary>
        /// Ether key of user
        /// </summary>
        /// <value>Ether key of user</value>
        [DataMember(Name = "ether_key", IsRequired = true, EmitDefaultValue = true)]
        public string EtherKey { get; set; }

        /// <summary>
        /// Public stark key of the user
        /// </summary>
        /// <value>Public stark key of the user</value>
        [DataMember(Name = "stark_key", IsRequired = true, EmitDefaultValue = true)]
        public string StarkKey { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetSignableRegistrationRequest {\n");
            sb.Append("  EtherKey: ").Append(EtherKey).Append("\n");
            sb.Append("  StarkKey: ").Append(StarkKey).Append("\n");
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
            return this.Equals(input as GetSignableRegistrationRequest);
        }

        /// <summary>
        /// Returns true if GetSignableRegistrationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of GetSignableRegistrationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetSignableRegistrationRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.EtherKey == input.EtherKey ||
                    (this.EtherKey != null &&
                    this.EtherKey.Equals(input.EtherKey))
                ) && 
                (
                    this.StarkKey == input.StarkKey ||
                    (this.StarkKey != null &&
                    this.StarkKey.Equals(input.StarkKey))
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
                if (this.EtherKey != null)
                {
                    hashCode = (hashCode * 59) + this.EtherKey.GetHashCode();
                }
                if (this.StarkKey != null)
                {
                    hashCode = (hashCode * 59) + this.StarkKey.GetHashCode();
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
