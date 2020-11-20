/* 
 * Accounting API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
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

namespace Xero.NetStandard.OAuth2.Model.Accounting
{
    /// <summary>
    /// Invoice
    /// </summary>
    [DataContract]
    public partial class Invoice :  IEquatable<Invoice>, IValidatableObject
    {
        /// <summary>
        /// See Invoice Types
        /// </summary>
        /// <value>See Invoice Types</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum ACCPAY for value: ACCPAY
            /// </summary>
            [EnumMember(Value = "ACCPAY")]
            ACCPAY = 1,

            /// <summary>
            /// Enum ACCPAYCREDIT for value: ACCPAYCREDIT
            /// </summary>
            [EnumMember(Value = "ACCPAYCREDIT")]
            ACCPAYCREDIT = 2,

            /// <summary>
            /// Enum APOVERPAYMENT for value: APOVERPAYMENT
            /// </summary>
            [EnumMember(Value = "APOVERPAYMENT")]
            APOVERPAYMENT = 3,

            /// <summary>
            /// Enum APPREPAYMENT for value: APPREPAYMENT
            /// </summary>
            [EnumMember(Value = "APPREPAYMENT")]
            APPREPAYMENT = 4,

            /// <summary>
            /// Enum ACCREC for value: ACCREC
            /// </summary>
            [EnumMember(Value = "ACCREC")]
            ACCREC = 5,

            /// <summary>
            /// Enum ACCRECCREDIT for value: ACCRECCREDIT
            /// </summary>
            [EnumMember(Value = "ACCRECCREDIT")]
            ACCRECCREDIT = 6,

            /// <summary>
            /// Enum AROVERPAYMENT for value: AROVERPAYMENT
            /// </summary>
            [EnumMember(Value = "AROVERPAYMENT")]
            AROVERPAYMENT = 7,

            /// <summary>
            /// Enum ARPREPAYMENT for value: ARPREPAYMENT
            /// </summary>
            [EnumMember(Value = "ARPREPAYMENT")]
            ARPREPAYMENT = 8

        }

        /// <summary>
        /// See Invoice Types
        /// </summary>
        /// <value>See Invoice Types</value>
        [DataMember(Name="Type", EmitDefaultValue=false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Gets or Sets LineAmountTypes
        /// </summary>
        [DataMember(Name="LineAmountTypes", EmitDefaultValue=false)]
        public LineAmountTypes LineAmountTypes { get; set; }
        /// <summary>
        /// Gets or Sets CurrencyCode
        /// </summary>
        [DataMember(Name="CurrencyCode", EmitDefaultValue=false)]
        public CurrencyCode CurrencyCode { get; set; }
        /// <summary>
        /// See Invoice Status Codes
        /// </summary>
        /// <value>See Invoice Status Codes</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum DRAFT for value: DRAFT
            /// </summary>
            [EnumMember(Value = "DRAFT")]
            DRAFT = 1,

            /// <summary>
            /// Enum SUBMITTED for value: SUBMITTED
            /// </summary>
            [EnumMember(Value = "SUBMITTED")]
            SUBMITTED = 2,

            /// <summary>
            /// Enum DELETED for value: DELETED
            /// </summary>
            [EnumMember(Value = "DELETED")]
            DELETED = 3,

            /// <summary>
            /// Enum AUTHORISED for value: AUTHORISED
            /// </summary>
            [EnumMember(Value = "AUTHORISED")]
            AUTHORISED = 4,

            /// <summary>
            /// Enum PAID for value: PAID
            /// </summary>
            [EnumMember(Value = "PAID")]
            PAID = 5,

            /// <summary>
            /// Enum VOIDED for value: VOIDED
            /// </summary>
            [EnumMember(Value = "VOIDED")]
            VOIDED = 6

        }

        /// <summary>
        /// See Invoice Status Codes
        /// </summary>
        /// <value>See Invoice Status Codes</value>
        [DataMember(Name="Status", EmitDefaultValue=false)]
        public StatusEnum Status { get; set; }
        
        /// <summary>
        /// Gets or Sets Contact
        /// </summary>
        [DataMember(Name="Contact", EmitDefaultValue=false)]
        public Contact Contact { get; set; }

        /// <summary>
        /// See LineItems
        /// </summary>
        /// <value>See LineItems</value>
        [DataMember(Name="LineItems", EmitDefaultValue=false)]
        public List<LineItem> LineItems { get; set; }

        /// <summary>
        /// Date invoice was issued – YYYY-MM-DD. If the Date element is not specified it will default to the current date based on the timezone setting of the organisation
        /// </summary>
        /// <value>Date invoice was issued – YYYY-MM-DD. If the Date element is not specified it will default to the current date based on the timezone setting of the organisation</value>
        [DataMember(Name="Date", EmitDefaultValue=false)]
        public DateTime? Date { get; set; }

        /// <summary>
        /// Date invoice is due – YYYY-MM-DD
        /// </summary>
        /// <value>Date invoice is due – YYYY-MM-DD</value>
        [DataMember(Name="DueDate", EmitDefaultValue=false)]
        public DateTime? DueDate { get; set; }

        /// <summary>
        /// ACCREC – Unique alpha numeric code identifying invoice (when missing will auto-generate from your Organisation Invoice Settings) (max length &#x3D; 255)
        /// </summary>
        /// <value>ACCREC – Unique alpha numeric code identifying invoice (when missing will auto-generate from your Organisation Invoice Settings) (max length &#x3D; 255)</value>
        [DataMember(Name="InvoiceNumber", EmitDefaultValue=false)]
        public string InvoiceNumber { get; set; }

        /// <summary>
        /// ACCREC only – additional reference number (max length &#x3D; 255)
        /// </summary>
        /// <value>ACCREC only – additional reference number (max length &#x3D; 255)</value>
        [DataMember(Name="Reference", EmitDefaultValue=false)]
        public string Reference { get; set; }

        /// <summary>
        /// See BrandingThemes
        /// </summary>
        /// <value>See BrandingThemes</value>
        [DataMember(Name="BrandingThemeID", EmitDefaultValue=false)]
        public Guid? BrandingThemeID { get; set; }

        /// <summary>
        /// URL link to a source document – shown as “Go to [appName]” in the Xero app
        /// </summary>
        /// <value>URL link to a source document – shown as “Go to [appName]” in the Xero app</value>
        [DataMember(Name="Url", EmitDefaultValue=false)]
        public string Url { get; set; }

        /// <summary>
        /// The currency rate for a multicurrency invoice. If no rate is specified, the XE.com day rate is used. (max length &#x3D; [18].[6])
        /// </summary>
        /// <value>The currency rate for a multicurrency invoice. If no rate is specified, the XE.com day rate is used. (max length &#x3D; [18].[6])</value>
        [DataMember(Name="CurrencyRate", EmitDefaultValue=false)]
        public decimal? CurrencyRate { get; set; }

        /// <summary>
        /// Boolean to set whether the invoice in the Xero app should be marked as “sent”. This can be set only on invoices that have been approved
        /// </summary>
        /// <value>Boolean to set whether the invoice in the Xero app should be marked as “sent”. This can be set only on invoices that have been approved</value>
        [DataMember(Name="SentToContact", EmitDefaultValue=false)]
        public bool? SentToContact { get; set; }

        /// <summary>
        /// Shown on sales invoices (Accounts Receivable) when this has been set
        /// </summary>
        /// <value>Shown on sales invoices (Accounts Receivable) when this has been set</value>
        [DataMember(Name="ExpectedPaymentDate", EmitDefaultValue=false)]
        public DateTime? ExpectedPaymentDate { get; set; }

        /// <summary>
        /// Shown on bills (Accounts Payable) when this has been set
        /// </summary>
        /// <value>Shown on bills (Accounts Payable) when this has been set</value>
        [DataMember(Name="PlannedPaymentDate", EmitDefaultValue=false)]
        public DateTime? PlannedPaymentDate { get; set; }

        /// <summary>
        /// CIS deduction for UK contractors
        /// </summary>
        /// <value>CIS deduction for UK contractors</value>
        [DataMember(Name="CISDeduction", EmitDefaultValue=false)]
        public decimal? CISDeduction { get; private set; }

        /// <summary>
        /// Total of invoice excluding taxes
        /// </summary>
        /// <value>Total of invoice excluding taxes</value>
        [DataMember(Name="SubTotal", EmitDefaultValue=false)]
        public decimal? SubTotal { get; private set; }

        /// <summary>
        /// Total tax on invoice
        /// </summary>
        /// <value>Total tax on invoice</value>
        [DataMember(Name="TotalTax", EmitDefaultValue=false)]
        public decimal? TotalTax { get; private set; }

        /// <summary>
        /// Total of Invoice tax inclusive (i.e. SubTotal + TotalTax). This will be ignored if it doesn’t equal the sum of the LineAmounts
        /// </summary>
        /// <value>Total of Invoice tax inclusive (i.e. SubTotal + TotalTax). This will be ignored if it doesn’t equal the sum of the LineAmounts</value>
        [DataMember(Name="Total", EmitDefaultValue=false)]
        public decimal? Total { get; private set; }

        /// <summary>
        /// Total of discounts applied on the invoice line items
        /// </summary>
        /// <value>Total of discounts applied on the invoice line items</value>
        [DataMember(Name="TotalDiscount", EmitDefaultValue=false)]
        public decimal? TotalDiscount { get; private set; }

        /// <summary>
        /// Xero generated unique identifier for invoice
        /// </summary>
        /// <value>Xero generated unique identifier for invoice</value>
        [DataMember(Name="InvoiceID", EmitDefaultValue=false)]
        public Guid? InvoiceID { get; set; }

        /// <summary>
        /// Xero generated unique identifier for repeating invoices
        /// </summary>
        /// <value>Xero generated unique identifier for repeating invoices</value>
        [DataMember(Name="RepeatingInvoiceID", EmitDefaultValue=false)]
        public Guid? RepeatingInvoiceID { get; set; }

        /// <summary>
        /// boolean to indicate if an invoice has an attachment
        /// </summary>
        /// <value>boolean to indicate if an invoice has an attachment</value>
        [DataMember(Name="HasAttachments", EmitDefaultValue=false)]
        public bool? HasAttachments { get; private set; }

        /// <summary>
        /// boolean to indicate if an invoice has a discount
        /// </summary>
        /// <value>boolean to indicate if an invoice has a discount</value>
        [DataMember(Name="IsDiscounted", EmitDefaultValue=false)]
        public bool? IsDiscounted { get; private set; }

        /// <summary>
        /// See Payments
        /// </summary>
        /// <value>See Payments</value>
        [DataMember(Name="Payments", EmitDefaultValue=false)]
        public List<Payment> Payments { get; private set; }

        /// <summary>
        /// See Prepayments
        /// </summary>
        /// <value>See Prepayments</value>
        [DataMember(Name="Prepayments", EmitDefaultValue=false)]
        public List<Prepayment> Prepayments { get; private set; }

        /// <summary>
        /// See Overpayments
        /// </summary>
        /// <value>See Overpayments</value>
        [DataMember(Name="Overpayments", EmitDefaultValue=false)]
        public List<Overpayment> Overpayments { get; private set; }

        /// <summary>
        /// Amount remaining to be paid on invoice
        /// </summary>
        /// <value>Amount remaining to be paid on invoice</value>
        [DataMember(Name="AmountDue", EmitDefaultValue=false)]
        public decimal? AmountDue { get; private set; }

        /// <summary>
        /// Sum of payments received for invoice
        /// </summary>
        /// <value>Sum of payments received for invoice</value>
        [DataMember(Name="AmountPaid", EmitDefaultValue=false)]
        public decimal? AmountPaid { get; private set; }

        /// <summary>
        /// The date the invoice was fully paid. Only returned on fully paid invoices
        /// </summary>
        /// <value>The date the invoice was fully paid. Only returned on fully paid invoices</value>
        [DataMember(Name="FullyPaidOnDate", EmitDefaultValue=false)]
        public DateTime? FullyPaidOnDate { get; private set; }

        /// <summary>
        /// Sum of all credit notes, over-payments and pre-payments applied to invoice
        /// </summary>
        /// <value>Sum of all credit notes, over-payments and pre-payments applied to invoice</value>
        [DataMember(Name="AmountCredited", EmitDefaultValue=false)]
        public decimal? AmountCredited { get; private set; }

        /// <summary>
        /// Last modified date UTC format
        /// </summary>
        /// <value>Last modified date UTC format</value>
        [DataMember(Name="UpdatedDateUTC", EmitDefaultValue=false)]
        public DateTime? UpdatedDateUTC { get; private set; }

        /// <summary>
        /// Details of credit notes that have been applied to an invoice
        /// </summary>
        /// <value>Details of credit notes that have been applied to an invoice</value>
        [DataMember(Name="CreditNotes", EmitDefaultValue=false)]
        public List<CreditNote> CreditNotes { get; private set; }

        /// <summary>
        /// Displays array of attachments from the API
        /// </summary>
        /// <value>Displays array of attachments from the API</value>
        [DataMember(Name="Attachments", EmitDefaultValue=false)]
        public List<Attachment> Attachments { get; set; }

        /// <summary>
        /// A boolean to indicate if a invoice has an validation errors
        /// </summary>
        /// <value>A boolean to indicate if a invoice has an validation errors</value>
        [DataMember(Name="HasErrors", EmitDefaultValue=false)]
        public bool? HasErrors { get; set; }

        /// <summary>
        /// A string to indicate if a invoice status
        /// </summary>
        /// <value>A string to indicate if a invoice status</value>
        [DataMember(Name="StatusAttributeString", EmitDefaultValue=false)]
        public string StatusAttributeString { get; set; }

        /// <summary>
        /// Displays array of validation error messages from the API
        /// </summary>
        /// <value>Displays array of validation error messages from the API</value>
        [DataMember(Name="ValidationErrors", EmitDefaultValue=false)]
        public List<ValidationError> ValidationErrors { get; set; }

        /// <summary>
        /// Displays array of warning messages from the API
        /// </summary>
        /// <value>Displays array of warning messages from the API</value>
        [DataMember(Name="Warnings", EmitDefaultValue=false)]
        public List<ValidationError> Warnings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Invoice {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Contact: ").Append(Contact).Append("\n");
            sb.Append("  LineItems: ").Append(LineItems).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  DueDate: ").Append(DueDate).Append("\n");
            sb.Append("  LineAmountTypes: ").Append(LineAmountTypes).Append("\n");
            sb.Append("  InvoiceNumber: ").Append(InvoiceNumber).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  BrandingThemeID: ").Append(BrandingThemeID).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  CurrencyRate: ").Append(CurrencyRate).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  SentToContact: ").Append(SentToContact).Append("\n");
            sb.Append("  ExpectedPaymentDate: ").Append(ExpectedPaymentDate).Append("\n");
            sb.Append("  PlannedPaymentDate: ").Append(PlannedPaymentDate).Append("\n");
            sb.Append("  CISDeduction: ").Append(CISDeduction).Append("\n");
            sb.Append("  SubTotal: ").Append(SubTotal).Append("\n");
            sb.Append("  TotalTax: ").Append(TotalTax).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  TotalDiscount: ").Append(TotalDiscount).Append("\n");
            sb.Append("  InvoiceID: ").Append(InvoiceID).Append("\n");
            sb.Append("  RepeatingInvoiceID: ").Append(RepeatingInvoiceID).Append("\n");
            sb.Append("  HasAttachments: ").Append(HasAttachments).Append("\n");
            sb.Append("  IsDiscounted: ").Append(IsDiscounted).Append("\n");
            sb.Append("  Payments: ").Append(Payments).Append("\n");
            sb.Append("  Prepayments: ").Append(Prepayments).Append("\n");
            sb.Append("  Overpayments: ").Append(Overpayments).Append("\n");
            sb.Append("  AmountDue: ").Append(AmountDue).Append("\n");
            sb.Append("  AmountPaid: ").Append(AmountPaid).Append("\n");
            sb.Append("  FullyPaidOnDate: ").Append(FullyPaidOnDate).Append("\n");
            sb.Append("  AmountCredited: ").Append(AmountCredited).Append("\n");
            sb.Append("  UpdatedDateUTC: ").Append(UpdatedDateUTC).Append("\n");
            sb.Append("  CreditNotes: ").Append(CreditNotes).Append("\n");
            sb.Append("  Attachments: ").Append(Attachments).Append("\n");
            sb.Append("  HasErrors: ").Append(HasErrors).Append("\n");
            sb.Append("  StatusAttributeString: ").Append(StatusAttributeString).Append("\n");
            sb.Append("  ValidationErrors: ").Append(ValidationErrors).Append("\n");
            sb.Append("  Warnings: ").Append(Warnings).Append("\n");
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
            return this.Equals(input as Invoice);
        }

        /// <summary>
        /// Returns true if Invoice instances are equal
        /// </summary>
        /// <param name="input">Instance of Invoice to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Invoice input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.Contact == input.Contact ||
                    (this.Contact != null &&
                    this.Contact.Equals(input.Contact))
                ) && 
                (
                    this.LineItems == input.LineItems ||
                    this.LineItems != null &&
                    input.LineItems != null &&
                    this.LineItems.SequenceEqual(input.LineItems)
                ) && 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.DueDate == input.DueDate ||
                    (this.DueDate != null &&
                    this.DueDate.Equals(input.DueDate))
                ) && 
                (
                    this.LineAmountTypes == input.LineAmountTypes ||
                    this.LineAmountTypes.Equals(input.LineAmountTypes)
                ) && 
                (
                    this.InvoiceNumber == input.InvoiceNumber ||
                    (this.InvoiceNumber != null &&
                    this.InvoiceNumber.Equals(input.InvoiceNumber))
                ) && 
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
                ) && 
                (
                    this.BrandingThemeID == input.BrandingThemeID ||
                    (this.BrandingThemeID != null &&
                    this.BrandingThemeID.Equals(input.BrandingThemeID))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.CurrencyCode == input.CurrencyCode ||
                    this.CurrencyCode.Equals(input.CurrencyCode)
                ) && 
                (
                    this.CurrencyRate == input.CurrencyRate ||
                    this.CurrencyRate.Equals(input.CurrencyRate)
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.SentToContact == input.SentToContact ||
                    this.SentToContact.Equals(input.SentToContact)
                ) && 
                (
                    this.ExpectedPaymentDate == input.ExpectedPaymentDate ||
                    (this.ExpectedPaymentDate != null &&
                    this.ExpectedPaymentDate.Equals(input.ExpectedPaymentDate))
                ) && 
                (
                    this.PlannedPaymentDate == input.PlannedPaymentDate ||
                    (this.PlannedPaymentDate != null &&
                    this.PlannedPaymentDate.Equals(input.PlannedPaymentDate))
                ) && 
                (
                    this.CISDeduction == input.CISDeduction ||
                    this.CISDeduction.Equals(input.CISDeduction)
                ) && 
                (
                    this.SubTotal == input.SubTotal ||
                    this.SubTotal.Equals(input.SubTotal)
                ) && 
                (
                    this.TotalTax == input.TotalTax ||
                    this.TotalTax.Equals(input.TotalTax)
                ) && 
                (
                    this.Total == input.Total ||
                    this.Total.Equals(input.Total)
                ) && 
                (
                    this.TotalDiscount == input.TotalDiscount ||
                    this.TotalDiscount.Equals(input.TotalDiscount)
                ) && 
                (
                    this.InvoiceID == input.InvoiceID ||
                    (this.InvoiceID != null &&
                    this.InvoiceID.Equals(input.InvoiceID))
                ) && 
                (
                    this.RepeatingInvoiceID == input.RepeatingInvoiceID ||
                    (this.RepeatingInvoiceID != null &&
                    this.RepeatingInvoiceID.Equals(input.RepeatingInvoiceID))
                ) && 
                (
                    this.HasAttachments == input.HasAttachments ||
                    this.HasAttachments.Equals(input.HasAttachments)
                ) && 
                (
                    this.IsDiscounted == input.IsDiscounted ||
                    this.IsDiscounted.Equals(input.IsDiscounted)
                ) && 
                (
                    this.Payments == input.Payments ||
                    this.Payments != null &&
                    input.Payments != null &&
                    this.Payments.SequenceEqual(input.Payments)
                ) && 
                (
                    this.Prepayments == input.Prepayments ||
                    this.Prepayments != null &&
                    input.Prepayments != null &&
                    this.Prepayments.SequenceEqual(input.Prepayments)
                ) && 
                (
                    this.Overpayments == input.Overpayments ||
                    this.Overpayments != null &&
                    input.Overpayments != null &&
                    this.Overpayments.SequenceEqual(input.Overpayments)
                ) && 
                (
                    this.AmountDue == input.AmountDue ||
                    this.AmountDue.Equals(input.AmountDue)
                ) && 
                (
                    this.AmountPaid == input.AmountPaid ||
                    this.AmountPaid.Equals(input.AmountPaid)
                ) && 
                (
                    this.FullyPaidOnDate == input.FullyPaidOnDate ||
                    (this.FullyPaidOnDate != null &&
                    this.FullyPaidOnDate.Equals(input.FullyPaidOnDate))
                ) && 
                (
                    this.AmountCredited == input.AmountCredited ||
                    this.AmountCredited.Equals(input.AmountCredited)
                ) && 
                (
                    this.UpdatedDateUTC == input.UpdatedDateUTC ||
                    (this.UpdatedDateUTC != null &&
                    this.UpdatedDateUTC.Equals(input.UpdatedDateUTC))
                ) && 
                (
                    this.CreditNotes == input.CreditNotes ||
                    this.CreditNotes != null &&
                    input.CreditNotes != null &&
                    this.CreditNotes.SequenceEqual(input.CreditNotes)
                ) && 
                (
                    this.Attachments == input.Attachments ||
                    this.Attachments != null &&
                    input.Attachments != null &&
                    this.Attachments.SequenceEqual(input.Attachments)
                ) && 
                (
                    this.HasErrors == input.HasErrors ||
                    this.HasErrors.Equals(input.HasErrors)
                ) && 
                (
                    this.StatusAttributeString == input.StatusAttributeString ||
                    (this.StatusAttributeString != null &&
                    this.StatusAttributeString.Equals(input.StatusAttributeString))
                ) && 
                (
                    this.ValidationErrors == input.ValidationErrors ||
                    this.ValidationErrors != null &&
                    input.ValidationErrors != null &&
                    this.ValidationErrors.SequenceEqual(input.ValidationErrors)
                ) && 
                (
                    this.Warnings == input.Warnings ||
                    this.Warnings != null &&
                    input.Warnings != null &&
                    this.Warnings.SequenceEqual(input.Warnings)
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
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Contact != null)
                    hashCode = hashCode * 59 + this.Contact.GetHashCode();
                if (this.LineItems != null)
                    hashCode = hashCode * 59 + this.LineItems.GetHashCode();
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                if (this.DueDate != null)
                    hashCode = hashCode * 59 + this.DueDate.GetHashCode();
                hashCode = hashCode * 59 + this.LineAmountTypes.GetHashCode();
                if (this.InvoiceNumber != null)
                    hashCode = hashCode * 59 + this.InvoiceNumber.GetHashCode();
                if (this.Reference != null)
                    hashCode = hashCode * 59 + this.Reference.GetHashCode();
                if (this.BrandingThemeID != null)
                    hashCode = hashCode * 59 + this.BrandingThemeID.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                hashCode = hashCode * 59 + this.CurrencyCode.GetHashCode();
                hashCode = hashCode * 59 + this.CurrencyRate.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                hashCode = hashCode * 59 + this.SentToContact.GetHashCode();
                if (this.ExpectedPaymentDate != null)
                    hashCode = hashCode * 59 + this.ExpectedPaymentDate.GetHashCode();
                if (this.PlannedPaymentDate != null)
                    hashCode = hashCode * 59 + this.PlannedPaymentDate.GetHashCode();
                hashCode = hashCode * 59 + this.CISDeduction.GetHashCode();
                hashCode = hashCode * 59 + this.SubTotal.GetHashCode();
                hashCode = hashCode * 59 + this.TotalTax.GetHashCode();
                hashCode = hashCode * 59 + this.Total.GetHashCode();
                hashCode = hashCode * 59 + this.TotalDiscount.GetHashCode();
                if (this.InvoiceID != null)
                    hashCode = hashCode * 59 + this.InvoiceID.GetHashCode();
                if (this.RepeatingInvoiceID != null)
                    hashCode = hashCode * 59 + this.RepeatingInvoiceID.GetHashCode();
                hashCode = hashCode * 59 + this.HasAttachments.GetHashCode();
                hashCode = hashCode * 59 + this.IsDiscounted.GetHashCode();
                if (this.Payments != null)
                    hashCode = hashCode * 59 + this.Payments.GetHashCode();
                if (this.Prepayments != null)
                    hashCode = hashCode * 59 + this.Prepayments.GetHashCode();
                if (this.Overpayments != null)
                    hashCode = hashCode * 59 + this.Overpayments.GetHashCode();
                hashCode = hashCode * 59 + this.AmountDue.GetHashCode();
                hashCode = hashCode * 59 + this.AmountPaid.GetHashCode();
                if (this.FullyPaidOnDate != null)
                    hashCode = hashCode * 59 + this.FullyPaidOnDate.GetHashCode();
                hashCode = hashCode * 59 + this.AmountCredited.GetHashCode();
                if (this.UpdatedDateUTC != null)
                    hashCode = hashCode * 59 + this.UpdatedDateUTC.GetHashCode();
                if (this.CreditNotes != null)
                    hashCode = hashCode * 59 + this.CreditNotes.GetHashCode();
                if (this.Attachments != null)
                    hashCode = hashCode * 59 + this.Attachments.GetHashCode();
                hashCode = hashCode * 59 + this.HasErrors.GetHashCode();
                if (this.StatusAttributeString != null)
                    hashCode = hashCode * 59 + this.StatusAttributeString.GetHashCode();
                if (this.ValidationErrors != null)
                    hashCode = hashCode * 59 + this.ValidationErrors.GetHashCode();
                if (this.Warnings != null)
                    hashCode = hashCode * 59 + this.Warnings.GetHashCode();
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
            // InvoiceNumber (string) maxLength
            if(this.InvoiceNumber != null && this.InvoiceNumber.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for InvoiceNumber, length must be less than 255.", new [] { "InvoiceNumber" });
            }

            // Reference (string) maxLength
            if(this.Reference != null && this.Reference.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Reference, length must be less than 255.", new [] { "Reference" });
            }

            yield break;
        }
    }

}
