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
    /// MintRequest
    /// </summary>
    [DataContract(Name = "MintRequest")]
    public partial class MintRequest : IEquatable<MintRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MintRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MintRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MintRequest" /> class.
        /// </summary>
        /// <param name="authSignature">Signature from authorised minter (required).</param>
        /// <param name="contractAddress">minting contract (required).</param>
        /// <param name="royalties">Global contract-level royalty fees.</param>
        /// <param name="users">Users to mint to (required).</param>
        public MintRequest(string authSignature = default(string), string contractAddress = default(string), List<MintFee> royalties = default(List<MintFee>), List<MintUser> users = default(List<MintUser>))
        {
            // to ensure "authSignature" is required (not null)
            if (authSignature == null)
            {
                throw new ArgumentNullException("authSignature is a required property for MintRequest and cannot be null");
            }
            this.AuthSignature = authSignature;
            // to ensure "contractAddress" is required (not null)
            if (contractAddress == null)
            {
                throw new ArgumentNullException("contractAddress is a required property for MintRequest and cannot be null");
            }
            this.ContractAddress = contractAddress;
            // to ensure "users" is required (not null)
            if (users == null)
            {
                throw new ArgumentNullException("users is a required property for MintRequest and cannot be null");
            }
            this.Users = users;
            this.Royalties = royalties;
        }

        /// <summary>
        /// Signature from authorised minter
        /// </summary>
        /// <value>Signature from authorised minter</value>
        [DataMember(Name = "auth_signature", IsRequired = true, EmitDefaultValue = true)]
        public string AuthSignature { get; set; }

        /// <summary>
        /// minting contract
        /// </summary>
        /// <value>minting contract</value>
        [DataMember(Name = "contract_address", IsRequired = true, EmitDefaultValue = true)]
        public string ContractAddress { get; set; }

        /// <summary>
        /// Global contract-level royalty fees
        /// </summary>
        /// <value>Global contract-level royalty fees</value>
        [DataMember(Name = "royalties", EmitDefaultValue = false)]
        public List<MintFee> Royalties { get; set; }

        /// <summary>
        /// Users to mint to
        /// </summary>
        /// <value>Users to mint to</value>
        [DataMember(Name = "users", IsRequired = true, EmitDefaultValue = true)]
        public List<MintUser> Users { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MintRequest {\n");
            sb.Append("  AuthSignature: ").Append(AuthSignature).Append("\n");
            sb.Append("  ContractAddress: ").Append(ContractAddress).Append("\n");
            sb.Append("  Royalties: ").Append(Royalties).Append("\n");
            sb.Append("  Users: ").Append(Users).Append("\n");
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
            return this.Equals(input as MintRequest);
        }

        /// <summary>
        /// Returns true if MintRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of MintRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MintRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AuthSignature == input.AuthSignature ||
                    (this.AuthSignature != null &&
                    this.AuthSignature.Equals(input.AuthSignature))
                ) && 
                (
                    this.ContractAddress == input.ContractAddress ||
                    (this.ContractAddress != null &&
                    this.ContractAddress.Equals(input.ContractAddress))
                ) && 
                (
                    this.Royalties == input.Royalties ||
                    this.Royalties != null &&
                    input.Royalties != null &&
                    this.Royalties.SequenceEqual(input.Royalties)
                ) && 
                (
                    this.Users == input.Users ||
                    this.Users != null &&
                    input.Users != null &&
                    this.Users.SequenceEqual(input.Users)
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
                if (this.AuthSignature != null)
                {
                    hashCode = (hashCode * 59) + this.AuthSignature.GetHashCode();
                }
                if (this.ContractAddress != null)
                {
                    hashCode = (hashCode * 59) + this.ContractAddress.GetHashCode();
                }
                if (this.Royalties != null)
                {
                    hashCode = (hashCode * 59) + this.Royalties.GetHashCode();
                }
                if (this.Users != null)
                {
                    hashCode = (hashCode * 59) + this.Users.GetHashCode();
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
