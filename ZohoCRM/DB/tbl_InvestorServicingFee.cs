namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_InvestorServicingFee
    {
        public int Id { get; set; }

        public int? ProductID { get; set; }

        public int? InvestorServicingFeeTypeID { get; set; }

        public decimal? FeePercentage { get; set; }

        public virtual tbl_InvestorServicingFeeType tbl_InvestorServicingFeeType { get; set; }

        public virtual tbl_Product tbl_Product { get; set; }
    }
}
