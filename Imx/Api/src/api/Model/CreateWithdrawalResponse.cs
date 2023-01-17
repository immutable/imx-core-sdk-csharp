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
    /// CreateWithdrawalResponse
    /// </summary>
    [DataContract(Name = "CreateWithdrawalResponse")]
    public partial class CreateWithdrawalResponse : IEquatable<CreateWithdrawalResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWithdrawalResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateWithdrawalResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWithdrawalResponse" /> class.
        /// </summary>
        /// <param name="status">Status of the withdrawal (required).</param>
        /// <param name="time">Time of the withdrawal (required).</param>
        /// <param name="withdrawalId">ID of the withdrawal (required).</param>
        public CreateWithdrawalResponse(string status = default(string), int time = default(int), int withdrawalId = default(int))
        {
            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new ArgumentNullException("status is a required property for CreateWithdrawalResponse and cannot be null");
            }
            this.Status = status;
            this.Time = time;
            this.WithdrawalId = withdrawalId;
        }

        /// <summary>
        /// Status of the withdrawal
        /// </summary>
        /// <value>Status of the withdrawal</value>
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = true)]
        public string Status { get; set; }

        /// <summary>
        /// Time of the withdrawal
        /// </summary>
        /// <value>Time of the withdrawal</value>
        [DataMember(Name = "time", IsRequired = true, EmitDefaultValue = true)]
        public int Time { get; set; }

        /// <summary>
        /// ID of the withdrawal
        /// </summary>
        /// <value>ID of the withdrawal</value>
        [DataMember(Name = "withdrawal_id", IsRequired = true, EmitDefaultValue = true)]
        public int WithdrawalId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateWithdrawalResponse {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
            sb.Append("  WithdrawalId: ").Append(WithdrawalId).Append("\n");
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
            return this.Equals(input as CreateWithdrawalResponse);
        }

        /// <summary>
        /// Returns true if CreateWithdrawalResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateWithdrawalResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateWithdrawalResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Time == input.Time ||
                    this.Time.Equals(input.Time)
                ) && 
                (
                    this.WithdrawalId == input.WithdrawalId ||
                    this.WithdrawalId.Equals(input.WithdrawalId)
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
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Time.GetHashCode();
                hashCode = (hashCode * 59) + this.WithdrawalId.GetHashCode();
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
