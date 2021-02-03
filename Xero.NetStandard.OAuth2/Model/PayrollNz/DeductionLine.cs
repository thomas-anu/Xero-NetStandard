/* 
 * Xero Payroll NZ
 *
 * This is the Xero Payroll API for orgs in the NZ region.
 *
 * The version of the OpenAPI document: 2.8.4
 * Contact: api@xero.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Xero.NetStandard.OAuth2.Client.OpenAPIDateConverter;

namespace Xero.NetStandard.OAuth2.Model.PayrollNz
{
    /// <summary>
    /// DeductionLine
    /// </summary>
    [DataContract]
    public partial class DeductionLine :  IEquatable<DeductionLine>, IValidatableObject
    {
        
        /// <summary>
        /// Xero identifier for payroll deduction
        /// </summary>
        /// <value>Xero identifier for payroll deduction</value>
        [DataMember(Name="deductionTypeID", EmitDefaultValue=false)]
        public Guid? DeductionTypeID { get; set; }

        /// <summary>
        /// name of earnings rate for display in UI
        /// </summary>
        /// <value>name of earnings rate for display in UI</value>
        [DataMember(Name="displayName", EmitDefaultValue=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// The amount of the deduction line
        /// </summary>
        /// <value>The amount of the deduction line</value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public decimal? Amount { get; set; }

        /// <summary>
        /// Identifies if the deduction is subject to tax
        /// </summary>
        /// <value>Identifies if the deduction is subject to tax</value>
        [DataMember(Name="subjectToTax", EmitDefaultValue=false)]
        public bool? SubjectToTax { get; set; }

        /// <summary>
        /// Deduction rate percentage
        /// </summary>
        /// <value>Deduction rate percentage</value>
        [DataMember(Name="percentage", EmitDefaultValue=false)]
        public decimal? Percentage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeductionLine {\n");
            sb.Append("  DeductionTypeID: ").Append(DeductionTypeID).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  SubjectToTax: ").Append(SubjectToTax).Append("\n");
            sb.Append("  Percentage: ").Append(Percentage).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeductionLine);
        }

        /// <summary>
        /// Returns true if DeductionLine instances are equal
        /// </summary>
        /// <param name="input">Instance of DeductionLine to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeductionLine input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DeductionTypeID == input.DeductionTypeID ||
                    (this.DeductionTypeID != null &&
                    this.DeductionTypeID.Equals(input.DeductionTypeID))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.Amount == input.Amount ||
                    this.Amount.Equals(input.Amount)
                ) && 
                (
                    this.SubjectToTax == input.SubjectToTax ||
                    this.SubjectToTax.Equals(input.SubjectToTax)
                ) && 
                (
                    this.Percentage == input.Percentage ||
                    this.Percentage.Equals(input.Percentage)
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
                if (this.DeductionTypeID != null)
                    hashCode = hashCode * 59 + this.DeductionTypeID.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                hashCode = hashCode * 59 + this.Amount.GetHashCode();
                hashCode = hashCode * 59 + this.SubjectToTax.GetHashCode();
                hashCode = hashCode * 59 + this.Percentage.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
