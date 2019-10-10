namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InvestorRepayment")]
    public partial class InvestorRepayment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public InvestorRepayment()
        {
            InvestorLateInterests = new HashSet<InvestorLateInterest>();
        }

        [Key]
        public Guid InvRepID { get; set; }

        public Guid IssuerRepID { get; set; }

        public int OfferID { get; set; }

        public DateTime DueDate { get; set; }

        public decimal? Amount { get; set; }

        public int PayStatus { get; set; }

        public decimal? LateInterest { get; set; }

        public decimal? PaidLateInterest { get; set; }

        public decimal? Balance { get; set; }

        public decimal? Interest { get; set; }

        public decimal? Principal { get; set; }

        public decimal? PaidPrincipal { get; set; }

        public decimal? PaidInterest { get; set; }

        public decimal? PaidAmount { get; set; }

        public decimal? InvestorServiceFee { get; set; }

        public decimal? PaidInvestorServiceFee { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InvestorLateInterest> InvestorLateInterests { get; set; }

        public virtual IssuerRepayment IssuerRepayment { get; set; }

        public virtual tbl_Loanoffers tbl_Loanoffers { get; set; }
    }
}
