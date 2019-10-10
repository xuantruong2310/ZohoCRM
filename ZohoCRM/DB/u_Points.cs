namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class u_Points
    {
        [Key]
        public int PointID { get; set; }

        public long? UserID { get; set; }

        public decimal? AccruedBalance { get; set; }

        public decimal? AvailableBalance { get; set; }

        public decimal? RedeemedBalance { get; set; }

        public virtual tbl_Users tbl_Users { get; set; }
    }
}
