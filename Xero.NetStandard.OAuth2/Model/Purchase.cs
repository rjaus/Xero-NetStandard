/* 
 * Accounting API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 2.0.4
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

namespace Xero.NetStandard.OAuth2.Model
{
    /// <summary>
    /// Purchase
    /// </summary>
    [DataContract]
    public partial class Purchase :  IEquatable<Purchase>, IValidatableObject
    {
        
        /// <summary>
        /// Unit Price of the item. By default UnitPrice is rounded to two decimal places. You can use 4 decimal places by adding the unitdp&#x3D;4 querystring parameter to your request.
        /// </summary>
        /// <value>Unit Price of the item. By default UnitPrice is rounded to two decimal places. You can use 4 decimal places by adding the unitdp&#x3D;4 querystring parameter to your request.</value>
        [DataMember(Name="UnitPrice", EmitDefaultValue=false)]
        public float? UnitPrice { get; set; }

        /// <summary>
        /// Default account code to be used for purchased/sale. Not applicable to the purchase details of tracked items
        /// </summary>
        /// <value>Default account code to be used for purchased/sale. Not applicable to the purchase details of tracked items</value>
        [DataMember(Name="AccountCode", EmitDefaultValue=false)]
        public string AccountCode { get; set; }

        /// <summary>
        /// Cost of goods sold account. Only applicable to the purchase details of tracked items.
        /// </summary>
        /// <value>Cost of goods sold account. Only applicable to the purchase details of tracked items.</value>
        [DataMember(Name="COGSAccountCode", EmitDefaultValue=false)]
        public string COGSAccountCode { get; set; }

        /// <summary>
        /// The tax type from TaxRates
        /// </summary>
        /// <value>The tax type from TaxRates</value>
        [DataMember(Name="TaxType", EmitDefaultValue=false)]
        public string TaxType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Purchase {\n");
            sb.Append("  UnitPrice: ").Append(UnitPrice).Append("\n");
            sb.Append("  AccountCode: ").Append(AccountCode).Append("\n");
            sb.Append("  COGSAccountCode: ").Append(COGSAccountCode).Append("\n");
            sb.Append("  TaxType: ").Append(TaxType).Append("\n");
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
            return this.Equals(input as Purchase);
        }

        /// <summary>
        /// Returns true if Purchase instances are equal
        /// </summary>
        /// <param name="input">Instance of Purchase to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Purchase input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UnitPrice == input.UnitPrice ||
                    this.UnitPrice.Equals(input.UnitPrice)
                ) && 
                (
                    this.AccountCode == input.AccountCode ||
                    (this.AccountCode != null &&
                    this.AccountCode.Equals(input.AccountCode))
                ) && 
                (
                    this.COGSAccountCode == input.COGSAccountCode ||
                    (this.COGSAccountCode != null &&
                    this.COGSAccountCode.Equals(input.COGSAccountCode))
                ) && 
                (
                    this.TaxType == input.TaxType ||
                    (this.TaxType != null &&
                    this.TaxType.Equals(input.TaxType))
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
                hashCode = hashCode * 59 + this.UnitPrice.GetHashCode();
                if (this.AccountCode != null)
                    hashCode = hashCode * 59 + this.AccountCode.GetHashCode();
                if (this.COGSAccountCode != null)
                    hashCode = hashCode * 59 + this.COGSAccountCode.GetHashCode();
                if (this.TaxType != null)
                    hashCode = hashCode * 59 + this.TaxType.GetHashCode();
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