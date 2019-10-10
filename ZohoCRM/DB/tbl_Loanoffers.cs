namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_Loanoffers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_Loanoffers()
        {
            InvestorRepayments = new HashSet<InvestorRepayment>();
            InvestorRepaymentPayments = new HashSet<InvestorRepaymentPayment>();
        }

        [Key]
        public int OfferId { get; set; }

        public long Investor_Id { get; set; }

        public long LoanRequest_Id { get; set; }

        public decimal OfferedAmount { get; set; }

        public decimal? AcceptedAmount { get; set; }

        public decimal OfferedRate { get; set; }

        public decimal? AcceptedRate { get; set; }

        public DateTime DateCreated { get; set; }

        public int OfferStatus { get; set; }

        public DateTime? ModifiedDate { get; set; }

        [StringLength(250)]
        public string ReasonToReject { get; set; }

        [StringLength(50)]
        public string ContractId { get; set; }

        public bool? AllowOfferWithdraw { get; set; }

        public DateTime? WithdrawalDate { get; set; }

        public DateTime? OfferResubmittedDate { get; set; }

        [StringLength(50)]
        public string OfferResubmittedDigSignature { get; set; }

        [StringLength(100)]
        public string InvestDigitalSignature { get; set; }

        public int OfferMadeBy { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InvestorRepayment> InvestorRepayments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InvestorRepaymentPayment> InvestorRepaymentPayments { get; set; }

        public virtual tbl_LoanRequests tbl_LoanRequests { get; set; }

        public virtual tbl_Users tbl_Users { get; set; }
    }
}
