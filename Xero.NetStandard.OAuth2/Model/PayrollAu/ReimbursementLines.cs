/* 
 * Xero Payroll AU
 *
 * This is the Xero Payroll API for orgs in Australia region.
 *
 * The version of the OpenAPI document: 2.5.0
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

namespace Xero.NetStandard.OAuth2.Model.PayrollAu
{
    /// <summary>
    /// The reimbursement type lines
    /// </summary>
    [DataContract]
    public partial class ReimbursementLines :  IEquatable<ReimbursementLines>, IValidatableObject
    {
        
        /// <summary>
        /// Gets or Sets _ReimbursementLines
        /// </summary>
        [DataMember(Name="ReimbursementLines", EmitDefaultValue=false)]
        public List<ReimbursementLine> _ReimbursementLines { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReimbursementLines {\n");
            sb.Append("  _ReimbursementLines: ").Append(_ReimbursementLines).Append("\n");
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
            return this.Equals(input as ReimbursementLines);
        }

        /// <summary>
        /// Returns true if ReimbursementLines instances are equal
        /// </summary>
        /// <param name="input">Instance of ReimbursementLines to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReimbursementLines input)
        {
            if (input == null)
                return false;

            return 
                (
                    this._ReimbursementLines == input._ReimbursementLines ||
                    this._ReimbursementLines != null &&
                    input._ReimbursementLines != null &&
                    this._ReimbursementLines.SequenceEqual(input._ReimbursementLines)
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
                if (this._ReimbursementLines != null)
                    hashCode = hashCode * 59 + this._ReimbursementLines.GetHashCode();
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
