namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("IssuerLateInterest")]
    public partial class IssuerLateInterest
    {
        [Key]
        public Guid IssuerLIID { get; set; }

        public Guid IssuerRepID { get; set; }

        public DateTime Timestamp { get; set; }

        public decimal? LateInterest { get; set; }

        public DateTime? CalculatedDate { get; set; }
    }
}
