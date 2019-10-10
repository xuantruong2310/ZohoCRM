namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_TenureMSFees
    {
        public Guid Id { get; set; }

        public int? ProductId { get; set; }

        public int? Tenure { get; set; }

        public decimal? MSFeesPrecentage { get; set; }

        public decimal? MinAmount { get; set; }

        public virtual tbl_Product tbl_Product { get; set; }
    }
}
