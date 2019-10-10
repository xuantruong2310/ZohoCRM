namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_MoolahCore
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_MoolahCore()
        {
            tbl_OutStandingLitigation = new HashSet<tbl_OutStandingLitigation>();
        }

        [Key]
        public long MoolahCoreId { get; set; }

        public long? LoanRequest_Id { get; set; }

        public long? User_ID { get; set; }

        public decimal? Turnovers_LY { get; set; }

        public decimal? NetprofitafterTax_LY { get; set; }

        public decimal? CurrentAssests_LY { get; set; }

        public decimal? CurrentLiabilities_LY { get; set; }

        [StringLength(250)]
        public string CurrentRatio_LY { get; set; }

        public decimal? TotalDebt_LY { get; set; }

        public decimal? TotalShareholdersequity_LY { get; set; }

        [StringLength(250)]
        public string Debt_Equity_LY { get; set; }

        public decimal? CashFlowfromOperations_LY { get; set; }

        public DateTime? Datecreated { get; set; }

        public decimal? Turnovers_PY { get; set; }

        public decimal? NetprofitafterTax_PY { get; set; }

        public decimal? CurrentAssests_PY { get; set; }

        public decimal? CurrentLiabilities_PY { get; set; }

        [StringLength(250)]
        public string CurrentRatio_PY { get; set; }

        public decimal? TotalDebt_PY { get; set; }

        public decimal? TotalShareholdersequity_PY { get; set; }

        [StringLength(250)]
        public string Debt_Equity_PY { get; set; }

        public decimal? CashFlowfromOperations_PY { get; set; }

        public bool? IsoutstandingLitigation { get; set; }

        public string LatestYear { get; set; }

        public string PreiviousYear { get; set; }

        public bool? Profitable { get; set; }

        public bool? Profitable_PY { get; set; }

        public int? DPCreditPaymentGrade { get; set; }

        public decimal? Gearing { get; set; }

        public decimal? AvgThreeMntCashBalBankAcc_LY { get; set; }

        public decimal? AvgThreeMntCashBalBankAcc_PY { get; set; }

        public decimal? EBITDA_LY { get; set; }

        public decimal? EBITDA_PY { get; set; }

        [StringLength(250)]
        public string DebtEBITDARatio_LY { get; set; }

        [StringLength(250)]
        public string DebtEBITDARatio_PY { get; set; }

        public decimal? ProfitBeforIntAndTax_LY { get; set; }

        public decimal? ProfitBeforIntAndTax_PY { get; set; }

        public decimal? InterestExpense_LY { get; set; }

        public decimal? InterestExpense_PY { get; set; }

        [StringLength(250)]
        public string InterestCoverageRatio_LY { get; set; }

        [StringLength(250)]
        public string InterestCoverageRatio_PY { get; set; }

        public string IssuerComments { get; set; }

        public virtual tbl_DPCreditPaymentGrade tbl_DPCreditPaymentGrade { get; set; }

        public virtual tbl_LoanRequests tbl_LoanRequests { get; set; }

        public virtual tbl_Users tbl_Users { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_OutStandingLitigation> tbl_OutStandingLitigation { get; set; }
    }
}
