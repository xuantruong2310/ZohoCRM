namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_LoanPayments
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_LoanPayments()
        {
            InvestorRepaymentPayments = new HashSet<InvestorRepaymentPayment>();
            IssuerRepaymentPayments = new HashSet<IssuerRepaymentPayment>();
            tbl_AccountAdjustment = new HashSet<tbl_AccountAdjustment>();
        }

        public int ID { get; set; }

        public long LoanRequestID { get; set; }

        public long? RepaymentID { get; set; }

        public decimal? Amount { get; set; }

        public DateTime PaidDate { get; set; }

        public DateTime TimeStamp { get; set; }

        public decimal? LateFees { get; set; }

        public decimal? AccruedInterest { get; set; }

        public bool? IsRestrctured { get; set; }

        public Guid? IssuerRepID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InvestorRepaymentPayment> InvestorRepaymentPayments { get; set; }

        public virtual IssuerRepayment IssuerRepayment { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IssuerRepaymentPayment> IssuerRepaymentPayments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_AccountAdjustment> tbl_AccountAdjustment { get; set; }
    }
}
