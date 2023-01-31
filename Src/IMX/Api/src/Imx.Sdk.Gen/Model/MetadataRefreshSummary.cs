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
    /// MetadataRefreshSummary
    /// </summary>
    [DataContract(Name = "MetadataRefreshSummary")]
    public partial class MetadataRefreshSummary : IEquatable<MetadataRefreshSummary>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataRefreshSummary" /> class.
        /// </summary>
        /// <param name="failed">The number of tokens with failed metadata refreshes.</param>
        /// <param name="pending">The number of tokens that has not been refreshed yet.</param>
        /// <param name="succeeded">The number of tokens with successful metadata refreshes.</param>
        public MetadataRefreshSummary(int failed = default(int), int pending = default(int), int succeeded = default(int))
        {
            this.Failed = failed;
            this.Pending = pending;
            this.Succeeded = succeeded;
        }

        /// <summary>
        /// The number of tokens with failed metadata refreshes
        /// </summary>
        /// <value>The number of tokens with failed metadata refreshes</value>
        [DataMember(Name = "failed", EmitDefaultValue = false)]
        public int Failed { get; set; }

        /// <summary>
        /// The number of tokens that has not been refreshed yet
        /// </summary>
        /// <value>The number of tokens that has not been refreshed yet</value>
        [DataMember(Name = "pending", EmitDefaultValue = false)]
        public int Pending { get; set; }

        /// <summary>
        /// The number of tokens with successful metadata refreshes
        /// </summary>
        /// <value>The number of tokens with successful metadata refreshes</value>
        [DataMember(Name = "succeeded", EmitDefaultValue = false)]
        public int Succeeded { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MetadataRefreshSummary {\n");
            sb.Append("  Failed: ").Append(Failed).Append("\n");
            sb.Append("  Pending: ").Append(Pending).Append("\n");
            sb.Append("  Succeeded: ").Append(Succeeded).Append("\n");
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
            return this.Equals(input as MetadataRefreshSummary);
        }

        /// <summary>
        /// Returns true if MetadataRefreshSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of MetadataRefreshSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MetadataRefreshSummary input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Failed == input.Failed ||
                    this.Failed.Equals(input.Failed)
                ) && 
                (
                    this.Pending == input.Pending ||
                    this.Pending.Equals(input.Pending)
                ) && 
                (
                    this.Succeeded == input.Succeeded ||
                    this.Succeeded.Equals(input.Succeeded)
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
                hashCode = (hashCode * 59) + this.Failed.GetHashCode();
                hashCode = (hashCode * 59) + this.Pending.GetHashCode();
                hashCode = (hashCode * 59) + this.Succeeded.GetHashCode();
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
