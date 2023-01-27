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
    /// MetadataRefreshExcludingSummary
    /// </summary>
    [DataContract(Name = "MetadataRefreshExcludingSummary")]
    public partial class MetadataRefreshExcludingSummary : IEquatable<MetadataRefreshExcludingSummary>, IValidatableObject
    {
        /// <summary>
        /// The metadata refresh status
        /// </summary>
        /// <value>The metadata refresh status</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Queued for value: queued
            /// </summary>
            [EnumMember(Value = "queued")]
            Queued = 1,

            /// <summary>
            /// Enum InProgress for value: in_progress
            /// </summary>
            [EnumMember(Value = "in_progress")]
            InProgress = 2,

            /// <summary>
            /// Enum Completed for value: completed
            /// </summary>
            [EnumMember(Value = "completed")]
            Completed = 3

        }


        /// <summary>
        /// The metadata refresh status
        /// </summary>
        /// <value>The metadata refresh status</value>
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = true)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataRefreshExcludingSummary" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MetadataRefreshExcludingSummary() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataRefreshExcludingSummary" /> class.
        /// </summary>
        /// <param name="collectionAddress">The collection address (required).</param>
        /// <param name="completedAt">When the metadata refresh completed.</param>
        /// <param name="refreshId">The metadata refresh ID (required).</param>
        /// <param name="startedAt">When the metadata refresh started (required).</param>
        /// <param name="status">The metadata refresh status (required).</param>
        public MetadataRefreshExcludingSummary(string collectionAddress = default(string), string completedAt = default(string), string refreshId = default(string), string startedAt = default(string), StatusEnum status = default(StatusEnum))
        {
            // to ensure "collectionAddress" is required (not null)
            if (collectionAddress == null)
            {
                throw new ArgumentNullException("collectionAddress is a required property for MetadataRefreshExcludingSummary and cannot be null");
            }
            this.CollectionAddress = collectionAddress;
            // to ensure "refreshId" is required (not null)
            if (refreshId == null)
            {
                throw new ArgumentNullException("refreshId is a required property for MetadataRefreshExcludingSummary and cannot be null");
            }
            this.RefreshId = refreshId;
            // to ensure "startedAt" is required (not null)
            if (startedAt == null)
            {
                throw new ArgumentNullException("startedAt is a required property for MetadataRefreshExcludingSummary and cannot be null");
            }
            this.StartedAt = startedAt;
            this.Status = status;
            this.CompletedAt = completedAt;
        }

        /// <summary>
        /// The collection address
        /// </summary>
        /// <value>The collection address</value>
        [DataMember(Name = "collection_address", IsRequired = true, EmitDefaultValue = true)]
        public string CollectionAddress { get; set; }

        /// <summary>
        /// When the metadata refresh completed
        /// </summary>
        /// <value>When the metadata refresh completed</value>
        [DataMember(Name = "completed_at", EmitDefaultValue = true)]
        public string CompletedAt { get; set; }

        /// <summary>
        /// The metadata refresh ID
        /// </summary>
        /// <value>The metadata refresh ID</value>
        [DataMember(Name = "refresh_id", IsRequired = true, EmitDefaultValue = true)]
        public string RefreshId { get; set; }

        /// <summary>
        /// When the metadata refresh started
        /// </summary>
        /// <value>When the metadata refresh started</value>
        [DataMember(Name = "started_at", IsRequired = true, EmitDefaultValue = true)]
        public string StartedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MetadataRefreshExcludingSummary {\n");
            sb.Append("  CollectionAddress: ").Append(CollectionAddress).Append("\n");
            sb.Append("  CompletedAt: ").Append(CompletedAt).Append("\n");
            sb.Append("  RefreshId: ").Append(RefreshId).Append("\n");
            sb.Append("  StartedAt: ").Append(StartedAt).Append("\n");
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
            return this.Equals(input as MetadataRefreshExcludingSummary);
        }

        /// <summary>
        /// Returns true if MetadataRefreshExcludingSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of MetadataRefreshExcludingSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MetadataRefreshExcludingSummary input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CollectionAddress == input.CollectionAddress ||
                    (this.CollectionAddress != null &&
                    this.CollectionAddress.Equals(input.CollectionAddress))
                ) && 
                (
                    this.CompletedAt == input.CompletedAt ||
                    (this.CompletedAt != null &&
                    this.CompletedAt.Equals(input.CompletedAt))
                ) && 
                (
                    this.RefreshId == input.RefreshId ||
                    (this.RefreshId != null &&
                    this.RefreshId.Equals(input.RefreshId))
                ) && 
                (
                    this.StartedAt == input.StartedAt ||
                    (this.StartedAt != null &&
                    this.StartedAt.Equals(input.StartedAt))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
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
                if (this.CollectionAddress != null)
                {
                    hashCode = (hashCode * 59) + this.CollectionAddress.GetHashCode();
                }
                if (this.CompletedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CompletedAt.GetHashCode();
                }
                if (this.RefreshId != null)
                {
                    hashCode = (hashCode * 59) + this.RefreshId.GetHashCode();
                }
                if (this.StartedAt != null)
                {
                    hashCode = (hashCode * 59) + this.StartedAt.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
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
