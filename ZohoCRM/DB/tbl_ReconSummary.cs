namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_ReconSummary
    {
        public long ID { get; set; }

        public DateTime ReconDate { get; set; }

        public decimal? SystemBalance { get; set; }

        public decimal? ClosingBankBalance { get; set; }

        public decimal? DifferenceAmount { get; set; }

        public decimal? InitialDeposit { get; set; }

        public decimal? CumalativeISF { get; set; }

        public decimal? CumalativeGIROCharges { get; set; }

        public decimal? CumalativeAccAdjustment { get; set; }

        public decimal? CurrentFunding { get; set; }

        public decimal? TransactionBalanceAmount { get; set; }

        public int? IsLatest { get; set; }
    }
}
