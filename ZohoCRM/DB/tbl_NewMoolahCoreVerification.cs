namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_NewMoolahCoreVerification
    {
        [Key]
        public long MoolahCoreVerificationID { get; set; }

        public long? Request_ID { get; set; }

        public int? Turnover_Verification { get; set; }

        public int? EarningsBeforeTax_Verification { get; set; }

        public int? CurrentAssets_Verification { get; set; }

        public int? CurrentLiabilities_Verification { get; set; }

        public int? CurrentRatio_Verification { get; set; }

        public int? TotalLiabilities_Verification { get; set; }

        public int? TotalShareholdersEquity_Verification { get; set; }

        public int? TotalLiabilitiesEquityRatio_Verification { get; set; }

        public int? CashFlowFromOperations_Verification { get; set; }

        public int? FinancialYear_Verification { get; set; }

        public int? AverageCashBalance_Verification { get; set; }

        public int? TotalDebtEBIT_Verification { get; set; }

        public int? ProfitBeforeInterestAndTax_Verification { get; set; }

        public int? InterestExpense_Verification { get; set; }

        public int? DPCreditPaymentGrade_Verification { get; set; }

        public int? CostOfGoodsSold_Verification { get; set; }

        public int? StartDate_Verification { get; set; }

        public int? EndDate_Verification { get; set; }

        public int? TimePeriod_Verification { get; set; }

        public int? OperatingProfitMargin_Verification { get; set; }

        public int? Inventories_Verification { get; set; }

        public int? Receivables_Verification { get; set; }

        public int? TradePayables_Verification { get; set; }

        public int? NonCurrentLiabilities_Verification { get; set; }

        public int? QuickRatio_Verification { get; set; }

        public int? InterestCoverageRatio_Verification { get; set; }

        public int? ShortTermDebt_Verification { get; set; }

        public int? LongTermDebt_Verification { get; set; }

        public int? TotalDebt_Verification { get; set; }

        public int? TotalDebtLiabilities_Verification { get; set; }

        public int? ReturnOnCapitalEmployed_Verification { get; set; }

        public int? AvgDaysOfInventoryOnHand_Verification { get; set; }

        public int? AccountReceivablesDaysOnHold_Verification { get; set; }

        public int? AccountPayablesDaysOnHold_Verification { get; set; }

        public int? FinancialStatementSubmitted_Verification { get; set; }

        public int? Audited_Verification { get; set; }

        public int? OutstandingLitigation_Verification { get; set; }

        [StringLength(16)]
        public string NumberOfCreditEnquires { get; set; }

        public int? NumberOfCreditEnquires_Verification { get; set; }

        public int? NetWorkingCapital_Verification { get; set; }

        public virtual tbl_LoanRequests tbl_LoanRequests { get; set; }
    }
}
