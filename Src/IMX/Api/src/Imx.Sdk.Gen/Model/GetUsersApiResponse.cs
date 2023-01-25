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
    /// GetUsersApiResponse
    /// </summary>
    [DataContract(Name = "GetUsersApiResponse")]
    public partial class GetUsersApiResponse : IEquatable<GetUsersApiResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetUsersApiResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetUsersApiResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetUsersApiResponse" /> class.
        /// </summary>
        /// <param name="accounts">Accounts (required).</param>
        public GetUsersApiResponse(List<string> accounts = default(List<string>))
        {
            // to ensure "accounts" is required (not null)
            if (accounts == null)
            {
                throw new ArgumentNullException("accounts is a required property for GetUsersApiResponse and cannot be null");
            }
            this.Accounts = accounts;
        }

        /// <summary>
        /// Accounts
        /// </summary>
        /// <value>Accounts</value>
        [DataMember(Name = "accounts", IsRequired = true, EmitDefaultValue = true)]
        public List<string> Accounts { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetUsersApiResponse {\n");
            sb.Append("  Accounts: ").Append(Accounts).Append("\n");
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
            return this.Equals(input as GetUsersApiResponse);
        }

        /// <summary>
        /// Returns true if GetUsersApiResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GetUsersApiResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetUsersApiResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Accounts == input.Accounts ||
                    this.Accounts != null &&
                    input.Accounts != null &&
                    this.Accounts.SequenceEqual(input.Accounts)
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
                if (this.Accounts != null)
                {
                    hashCode = (hashCode * 59) + this.Accounts.GetHashCode();
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