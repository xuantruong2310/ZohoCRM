namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_GlobalVariables
    {
        [Key]
        public int VariableId { get; set; }

        public decimal? Min_Quantum { get; set; }

        public decimal? Min_Lot { get; set; }

        public decimal? Min_Threshold { get; set; }

        public int? Min_Lenders { get; set; }

        public int? AuctionPeriod { get; set; }

        public decimal? CurrentRation { get; set; }

        public int? RequestCompletionDays { get; set; }

        public decimal? LoanProfitability { get; set; }

        public decimal? Turnover { get; set; }

        public decimal? DebtEquity { get; set; }

        public decimal? MinimumOfferRate { get; set; }

        public int? MinimumOfferAmount { get; set; }

        public int? MinimuAmountToWithdraw { get; set; }
    }
}
