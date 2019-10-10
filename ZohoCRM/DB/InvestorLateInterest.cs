namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InvestorLateInterest")]
    public partial class InvestorLateInterest
    {
        [Key]
        public Guid InvLIID { get; set; }

        public Guid InvRepID { get; set; }

        public DateTime Timestamp { get; set; }

        public decimal? LateInterest { get; set; }

        public DateTime? CalculatedDate { get; set; }

        public virtual InvestorRepayment InvestorRepayment { get; set; }
    }
}
