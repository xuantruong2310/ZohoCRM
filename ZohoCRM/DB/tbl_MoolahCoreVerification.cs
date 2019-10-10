namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_MoolahCoreVerification
    {
        [Key]
        public long MoolahCoreVerificationID { get; set; }

        public int? Turnover_LY_Verification { get; set; }

        public int? Turnover_PY_Verification { get; set; }

        public int? NetProfitAfterTax_LY_Verification { get; set; }

        public int? NetProfitAfterTax_PY_Verification { get; set; }

        public int? CurrentAssests_LY_Verification { get; set; }

        public int? CurrentAssests_PY_Verification { get; set; }

        public int? CurrentLiabilities_LY_Verification { get; set; }

        public int? CurrentLiabilities_PY_Verification { get; set; }

        public int? CurrentRatio_LY_Verification { get; set; }

        public int? CurrentRatio_PY_Verification { get; set; }

        public int? TotalShareholdersEquity_LY_Verification { get; set; }

        public int? TotalShareholdersEquity_PY_Verification { get; set; }

        public int? TotalDebt_LY_Verification { get; set; }

        public int? TotalDebt_PY_Verification { get; set; }

        public int? Debt_Equity_LY_Verification { get; set; }

        public int? Debt_Equity_PY_Verification { get; set; }

        public int? CashFlowFromOperations_LY_Verification { get; set; }

        public int? CashFlowFromOperations_PY_Verification { get; set; }

        [Column("OutstandingLitigation_Verification ")]
        public int? OutstandingLitigation_Verification_ { get; set; }

        public long? Request_ID { get; set; }

        public bool? FinancialStatementSubmitted { get; set; }

        public bool? FinancialStatementSubmitted_PY_Verification { get; set; }

        public bool? Audited { get; set; }

        public bool? Audited_PY_Verification { get; set; }

        public decimal? AnnualRevenue { get; set; }

        [StringLength(16)]
        public string NumberOfCreditEnquires { get; set; }

        public int? NumberOfCreditEnquires_Verification { get; set; }

        public int? LatestYearVerification { get; set; }

        public int? PreviousYearVerfication { get; set; }

        public int? DPCreditPaymentGrade_Verification { get; set; }

        public int? AvgThreeMntCashBalBankAcc_LY_Verification { get; set; }

        public int? AvgThreeMntCashBalBankAcc_PY_Verification { get; set; }

        public int? EBITDA_LY_Verification { get; set; }

        public int? EBITDA_PY_Verification { get; set; }

        public int? DebtEBITDARatio_LY_Verification { get; set; }

        public int? DebtEBITDARatio_PY_Verification { get; set; }

        public int? ProfitBeforIntAndTax_LY_Verification { get; set; }

        public int? ProfitBeforIntAndTax_PY_Verification { get; set; }

        public int? InterestExpense_LY_Verification { get; set; }

        public int? InterestExpense_PY_Verification { get; set; }

        public int? InterestCoverageRatio_LY_Verification { get; set; }

        public int? InterestCoverageRatio_PY_Verification { get; set; }

        public virtual tbl_LoanRequests tbl_LoanRequests { get; set; }
    }
}
