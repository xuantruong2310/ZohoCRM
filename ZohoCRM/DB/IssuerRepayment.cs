namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("IssuerRepayment")]
    public partial class IssuerRepayment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IssuerRepayment()
        {
            InvestorRepayments = new HashSet<InvestorRepayment>();
            IssuerRepaymentPayments = new HashSet<IssuerRepaymentPayment>();
            tbl_AccountAdjustment = new HashSet<tbl_AccountAdjustment>();
            tbl_LoanPayments = new HashSet<tbl_LoanPayments>();
        }

        [Key]
        public Guid IssuerRepID { get; set; }

        public long LoanRequestID { get; set; }

        public DateTime DueDate { get; set; }

        public decimal? Amount { get; set; }

        public int PayStatus { get; set; }

        public decimal? LateInterest { get; set; }

        public decimal? LateFees { get; set; }

        public decimal? PaidLateInterest { get; set; }

        public decimal? PaidLateFees { get; set; }

        public bool IsStressed { get; set; }

        public DateTime? StressDate { get; set; }

        public decimal? Balance { get; set; }

        public bool? IsReminderSent { get; set; }

        public bool? HasAllowEarlySettle { get; set; }

        public bool? IsCalled { get; set; }

        public DateTime? LastLICalculateDate { get; set; }

        public decimal? Interest { get; set; }

        public decimal? Principal { get; set; }

        public decimal? PaidPrincipal { get; set; }

        public decimal? PaidInterest { get; set; }

        public decimal? PaidAmount { get; set; }

        public DateTime? LateCheckDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? LateStartDate { get; set; }

        public long? AmortizationID { get; set; }

        public bool IsFeeWaiver { get; set; }

        public DateTime? ResolvedDate { get; set; }

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
