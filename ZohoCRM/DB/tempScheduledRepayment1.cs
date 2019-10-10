namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tempScheduledRepayment1
    {
        public int? ID { get; set; }

        [Key]
        public DateTime DueDate { get; set; }

        public decimal? Amount { get; set; }
    }
}
