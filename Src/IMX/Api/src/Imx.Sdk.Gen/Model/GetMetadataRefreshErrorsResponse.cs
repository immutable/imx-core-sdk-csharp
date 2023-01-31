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
    /// GetMetadataRefreshErrorsResponse
    /// </summary>
    [DataContract(Name = "GetMetadataRefreshErrorsResponse")]
    public partial class GetMetadataRefreshErrorsResponse : IEquatable<GetMetadataRefreshErrorsResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetMetadataRefreshErrorsResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetMetadataRefreshErrorsResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetMetadataRefreshErrorsResponse" /> class.
        /// </summary>
        /// <param name="cursor">Generated cursor returned by previous query (required).</param>
        /// <param name="remaining">Remaining results flag. 1: there are remaining results matching this query, 0: no remaining results (required).</param>
        /// <param name="result">Metadata refresh errors matching query parameters (required).</param>
        public GetMetadataRefreshErrorsResponse(string cursor = default(string), int remaining = default(int), List<MetadataRefreshErrors> result = default(List<MetadataRefreshErrors>))
        {
            // to ensure "cursor" is required (not null)
            if (cursor == null)
            {
                throw new ArgumentNullException("cursor is a required property for GetMetadataRefreshErrorsResponse and cannot be null");
            }
            this.Cursor = cursor;
            this.Remaining = remaining;
            // to ensure "result" is required (not null)
            if (result == null)
            {
                throw new ArgumentNullException("result is a required property for GetMetadataRefreshErrorsResponse and cannot be null");
            }
            this.Result = result;
        }

        /// <summary>
        /// Generated cursor returned by previous query
        /// </summary>
        /// <value>Generated cursor returned by previous query</value>
        [DataMember(Name = "cursor", IsRequired = true, EmitDefaultValue = true)]
        public string Cursor { get; set; }

        /// <summary>
        /// Remaining results flag. 1: there are remaining results matching this query, 0: no remaining results
        /// </summary>
        /// <value>Remaining results flag. 1: there are remaining results matching this query, 0: no remaining results</value>
        [DataMember(Name = "remaining", IsRequired = true, EmitDefaultValue = true)]
        public int Remaining { get; set; }

        /// <summary>
        /// Metadata refresh errors matching query parameters
        /// </summary>
        /// <value>Metadata refresh errors matching query parameters</value>
        [DataMember(Name = "result", IsRequired = true, EmitDefaultValue = true)]
        public List<MetadataRefreshErrors> Result { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetMetadataRefreshErrorsResponse {\n");
            sb.Append("  Cursor: ").Append(Cursor).Append("\n");
            sb.Append("  Remaining: ").Append(Remaining).Append("\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
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
            return this.Equals(input as GetMetadataRefreshErrorsResponse);
        }

        /// <summary>
        /// Returns true if GetMetadataRefreshErrorsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GetMetadataRefreshErrorsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetMetadataRefreshErrorsResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Cursor == input.Cursor ||
                    (this.Cursor != null &&
                    this.Cursor.Equals(input.Cursor))
                ) && 
                (
                    this.Remaining == input.Remaining ||
                    this.Remaining.Equals(input.Remaining)
                ) && 
                (
                    this.Result == input.Result ||
                    this.Result != null &&
                    input.Result != null &&
                    this.Result.SequenceEqual(input.Result)
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
                if (this.Cursor != null)
                {
                    hashCode = (hashCode * 59) + this.Cursor.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Remaining.GetHashCode();
                if (this.Result != null)
                {
                    hashCode = (hashCode * 59) + this.Result.GetHashCode();
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
