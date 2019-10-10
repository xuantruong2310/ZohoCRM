namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_LoanRateChangeLog
    {
        public long Id { get; set; }

        public long? LoanRequestId { get; set; }

        public decimal? OldRate { get; set; }

        public DateTime? ChangeDate { get; set; }
    }
}
