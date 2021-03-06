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
    
    public partial class tbl_MoolahCoreVerification
    {
        public long MoolahCoreVerificationID { get; set; }
        public Nullable<int> Turnover_LY_Verification { get; set; }
        public Nullable<int> Turnover_PY_Verification { get; set; }
        public Nullable<int> NetProfitAfterTax_LY_Verification { get; set; }
        public Nullable<int> NetProfitAfterTax_PY_Verification { get; set; }
        public Nullable<int> CurrentAssests_LY_Verification { get; set; }
        public Nullable<int> CurrentAssests_PY_Verification { get; set; }
        public Nullable<int> CurrentLiabilities_LY_Verification { get; set; }
        public Nullable<int> CurrentLiabilities_PY_Verification { get; set; }
        public Nullable<int> CurrentRatio_LY_Verification { get; set; }
        public Nullable<int> CurrentRatio_PY_Verification { get; set; }
        public Nullable<int> TotalShareholdersEquity_LY_Verification { get; set; }
        public Nullable<int> TotalShareholdersEquity_PY_Verification { get; set; }
        public Nullable<int> TotalDebt_LY_Verification { get; set; }
        public Nullable<int> TotalDebt_PY_Verification { get; set; }
        public Nullable<int> Debt_Equity_LY_Verification { get; set; }
        public Nullable<int> Debt_Equity_PY_Verification { get; set; }
        public Nullable<int> CashFlowFromOperations_LY_Verification { get; set; }
        public Nullable<int> CashFlowFromOperations_PY_Verification { get; set; }
        public Nullable<int> OutstandingLitigation_Verification_ { get; set; }
        public Nullable<long> Request_ID { get; set; }
        public Nullable<bool> FinancialStatementSubmitted { get; set; }
        public Nullable<bool> FinancialStatementSubmitted_PY_Verification { get; set; }
        public Nullable<bool> Audited { get; set; }
        public Nullable<bool> Audited_PY_Verification { get; set; }
        public Nullable<decimal> AnnualRevenue { get; set; }
        public string NumberOfCreditEnquires { get; set; }
        public Nullable<int> NumberOfCreditEnquires_Verification { get; set; }
        public Nullable<int> LatestYearVerification { get; set; }
        public Nullable<int> PreviousYearVerfication { get; set; }
        public Nullable<int> DPCreditPaymentGrade_Verification { get; set; }
        public Nullable<int> AvgThreeMntCashBalBankAcc_LY_Verification { get; set; }
        public Nullable<int> AvgThreeMntCashBalBankAcc_PY_Verification { get; set; }
        public Nullable<int> EBITDA_LY_Verification { get; set; }
        public Nullable<int> EBITDA_PY_Verification { get; set; }
        public Nullable<int> DebtEBITDARatio_LY_Verification { get; set; }
        public Nullable<int> DebtEBITDARatio_PY_Verification { get; set; }
        public Nullable<int> ProfitBeforIntAndTax_LY_Verification { get; set; }
        public Nullable<int> ProfitBeforIntAndTax_PY_Verification { get; set; }
        public Nullable<int> InterestExpense_LY_Verification { get; set; }
        public Nullable<int> InterestExpense_PY_Verification { get; set; }
        public Nullable<int> InterestCoverageRatio_LY_Verification { get; set; }
        public Nullable<int> InterestCoverageRatio_PY_Verification { get; set; }
    
        public virtual tbl_LoanRequests tbl_LoanRequests { get; set; }
    }
}
