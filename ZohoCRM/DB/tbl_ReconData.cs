namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_ReconData
    {
        public long ID { get; set; }

        public DateTime ReconDate { get; set; }

        public long? StaggingID { get; set; }

        public long? SystemRefID { get; set; }

        public long? UserID { get; set; }

        public int? TransactionTypeID { get; set; }

        public decimal? Amount { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        public int? DebitOrCredit { get; set; }

        public int? IsRecordMatched { get; set; }

        public int? IsReconMatched { get; set; }

        public int? IsLatest { get; set; }

        public int? IsCarryForward { get; set; }

        public DateTime? CarryForwardDate { get; set; }
    }
}
