namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_Balances_3
    {
        [Key]
        public int BalanceId { get; set; }

        public decimal? ActualAmount { get; set; }

        public long? User_ID { get; set; }

        public DateTime? DateCreated { get; set; }

        public decimal? LedgerAmount { get; set; }
    }
}
