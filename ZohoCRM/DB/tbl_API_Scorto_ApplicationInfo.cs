namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_API_Scorto_ApplicationInfo
    {
        public int Id { get; set; }

        public DateTime? AppCreationDate { get; set; }

        public DateTime? AppApprovalDate { get; set; }

        public long? AppId { get; set; }

        [StringLength(500)]
        public string AppStatus { get; set; }

        public decimal? RequestedAmount { get; set; }

        public decimal? ApprovedAmount { get; set; }

        [StringLength(500)]
        public string ApprovedProdType { get; set; }

        public decimal? ApprovedInterestRate { get; set; }

        public decimal? FlatInterestRate { get; set; }

        [StringLength(500)]
        public string BDMName { get; set; }

        public DateTime? LUT { get; set; }
    }
}
