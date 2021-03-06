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
    
    public partial class tbl_LoanPayments
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_LoanPayments()
        {
            this.InvestorRepaymentPayments = new HashSet<InvestorRepaymentPayment>();
            this.IssuerRepaymentPayments = new HashSet<IssuerRepaymentPayment>();
            this.tbl_AccountAdjustment = new HashSet<tbl_AccountAdjustment>();
        }
    
        public int ID { get; set; }
        public long LoanRequestID { get; set; }
        public Nullable<long> RepaymentID { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public System.DateTime PaidDate { get; set; }
        public System.DateTime TimeStamp { get; set; }
        public Nullable<decimal> LateFees { get; set; }
        public Nullable<decimal> AccruedInterest { get; set; }
        public Nullable<bool> IsRestrctured { get; set; }
        public Nullable<System.Guid> IssuerRepID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InvestorRepaymentPayment> InvestorRepaymentPayments { get; set; }
        public virtual IssuerRepayment IssuerRepayment { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IssuerRepaymentPayment> IssuerRepaymentPayments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_AccountAdjustment> tbl_AccountAdjustment { get; set; }
    }
}
