namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InvestorRepaymentPayment")]
    public partial class InvestorRepaymentPayment
    {
        [Key]
        public Guid InvRepPayID { get; set; }

        public Guid IssuerRepPayID { get; set; }

        public Guid InvRepID { get; set; }

        public DateTime Date { get; set; }

        public decimal Amount { get; set; }

        public decimal? PaidLateInterest { get; set; }

        public decimal? PaidInterest { get; set; }

        public decimal? PaidPrincipal { get; set; }

        public int PaymentID { get; set; }

        public int? OfferID { get; set; }

        public decimal? PaidInvestorServiceFee { get; set; }

        public virtual InvestorRepaymentPayment InvestorRepaymentPayment1 { get; set; }

        public virtual InvestorRepaymentPayment InvestorRepaymentPayment2 { get; set; }

        public virtual tbl_Loanoffers tbl_Loanoffers { get; set; }

        public virtual tbl_LoanPayments tbl_LoanPayments { get; set; }
    }
}
