namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_NewMoolahCore
    {
        [Key]
        public long MoolahCoreId { get; set; }

        public long? LoanRequest_Id { get; set; }

        public long? User_ID { get; set; }

        public decimal? Turnover { get; set; }

        public decimal? EarningsBeforeTax { get; set; }

        public decimal? CurrentAssets { get; set; }

        public decimal? CurrentLiabilities { get; set; }

        public decimal? CurrentRatio { get; set; }

        public decimal? TotalLiabilities { get; set; }

        public decimal? TotalShareholdersEquity { get; set; }

        public decimal? TotalLiabilitiesEquityRatio { get; set; }

        public decimal? CashFlowFromOperations { get; set; }

        public DateTime? Timestamp { get; set; }

        public int? FinancialYear { get; set; }

        public decimal? AverageCashBalance { get; set; }

        public decimal? TotalDebtEBIT { get; set; }

        public decimal? ProfitBeforeInterestAndTax { get; set; }

        public decimal? InterestExpense { get; set; }

        public string IssuerComments { get; set; }

        public int? DPCreditPaymentGrade { get; set; }

        public decimal? CostOfGoodsSold { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public int? TimePeriod { get; set; }

        public decimal? OperatingProfitMargin { get; set; }

        public decimal? Inventories { get; set; }

        public decimal? Receivables { get; set; }

        public decimal? TradePayables { get; set; }

        public decimal? NonCurrentLiabilities { get; set; }

        public decimal? QuickRatio { get; set; }

        public decimal? InterestCoverageRatio { get; set; }

        public decimal? ShortTermDebt { get; set; }

        public decimal? LongTermDebt { get; set; }

        public decimal? TotalDebt { get; set; }

        public decimal? TotalDebtLiabilities { get; set; }

        public decimal? ReturnOnCapitalEmployed { get; set; }

        public decimal? AvgDaysOfInventoryOnHand { get; set; }

        public decimal? AccountReceivablesDaysOnHold { get; set; }

        public decimal? AccountPayablesDaysOnHold { get; set; }

        public bool? FinancialStatementSubmitted { get; set; }

        public bool? Audited { get; set; }

        public bool? IsoutstandingLitigation { get; set; }

        public decimal? NetWorkingCapital { get; set; }

        public virtual tbl_DPCreditPaymentGrade tbl_DPCreditPaymentGrade { get; set; }

        public virtual tbl_LoanRequests tbl_LoanRequests { get; set; }

        public virtual tbl_Users tbl_Users { get; set; }
    }
}
