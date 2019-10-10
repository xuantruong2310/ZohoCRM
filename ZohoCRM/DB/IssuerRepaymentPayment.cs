namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("IssuerRepaymentPayment")]
    public partial class IssuerRepaymentPayment
    {
        [Key]
        public Guid IssuerRepPayID { get; set; }

        public int IssuerPayID { get; set; }

        public Guid IssuerRepID { get; set; }

        public DateTime Date { get; set; }

        public decimal Amount { get; set; }

        public decimal? PaidLateInterest { get; set; }

        public decimal? PaidInterest { get; set; }

        public decimal? PaidPrincipal { get; set; }

        public decimal? PaidLateFees { get; set; }

        public int PayStatus { get; set; }

        public bool? IsLateInterestFullPaid { get; set; }

        public bool? IsInterestFullPaid { get; set; }

        public bool? IsPrincipalFullPaid { get; set; }

        public virtual IssuerRepayment IssuerRepayment { get; set; }

        public virtual tbl_LoanPayments tbl_LoanPayments { get; set; }
    }
}
