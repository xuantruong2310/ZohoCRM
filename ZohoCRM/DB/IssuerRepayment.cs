//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class IssuerRepayment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IssuerRepayment()
        {
            this.InvestorRepayments = new HashSet<InvestorRepayment>();
            this.IssuerRepaymentPayments = new HashSet<IssuerRepaymentPayment>();
            this.tbl_AccountAdjustment = new HashSet<tbl_AccountAdjustment>();
            this.tbl_LoanPayments = new HashSet<tbl_LoanPayments>();
        }
    
        public System.Guid IssuerRepID { get; set; }
        public long LoanRequestID { get; set; }
        public System.DateTime DueDate { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public int PayStatus { get; set; }
        public Nullable<decimal> LateInterest { get; set; }
        public Nullable<decimal> LateFees { get; set; }
        public Nullable<decimal> PaidLateInterest { get; set; }
        public Nullable<decimal> PaidLateFees { get; set; }
        public bool IsStressed { get; set; }
        public Nullable<System.DateTime> StressDate { get; set; }
        public Nullable<decimal> Balance { get; set; }
        public Nullable<bool> IsReminderSent { get; set; }
        public Nullable<bool> HasAllowEarlySettle { get; set; }
        public Nullable<bool> IsCalled { get; set; }
        public Nullable<System.DateTime> LastLICalculateDate { get; set; }
        public Nullable<decimal> Interest { get; set; }
        public Nullable<decimal> Principal { get; set; }
        public Nullable<decimal> PaidPrincipal { get; set; }
        public Nullable<decimal> PaidInterest { get; set; }
        public Nullable<decimal> PaidAmount { get; set; }
        public Nullable<System.DateTime> LateCheckDate { get; set; }
        public Nullable<System.DateTime> LateStartDate { get; set; }
        public Nullable<long> AmortizationID { get; set; }
        public bool IsFeeWaiver { get; set; }
        public Nullable<System.DateTime> ResolvedDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InvestorRepayment> InvestorRepayments { get; set; }
        public virtual tbl_LoanRequests tbl_LoanRequests { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IssuerRepaymentPayment> IssuerRepaymentPayments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_AccountAdjustment> tbl_AccountAdjustment { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_LoanPayments> tbl_LoanPayments { get; set; }
    }
}
