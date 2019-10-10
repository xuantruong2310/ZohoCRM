namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_FundTransferIN_Raw
    {
        public long ID { get; set; }

        [StringLength(150)]
        public string AccountNo { get; set; }

        [StringLength(150)]
        public string Cur { get; set; }

        public decimal? OpenBalance { get; set; }

        public decimal? ClosingBalance { get; set; }

        public decimal? CosAvailableBalance { get; set; }

        public decimal? TotalCredit { get; set; }

        public int? CreditCount { get; set; }

        public DateTime? StatementDate { get; set; }

        public int? DebitCount { get; set; }

        public decimal? TotalDebit { get; set; }

        public decimal? HoldAmount { get; set; }

        public DateTime? StatementValueDate { get; set; }

        public DateTime? PostDate { get; set; }

        public decimal? DebitAmount { get; set; }

        public decimal? CreditAmount { get; set; }

        [StringLength(150)]
        public string TransactionTypeCode { get; set; }

        [StringLength(150)]
        public string SupplementaryDetails { get; set; }

        [StringLength(150)]
        public string StatementDetails { get; set; }

        [StringLength(150)]
        public string OurRef { get; set; }

        [StringLength(150)]
        public string AdditionalDetails { get; set; }

        public DateTime? CreateDate { get; set; }
    }
}
