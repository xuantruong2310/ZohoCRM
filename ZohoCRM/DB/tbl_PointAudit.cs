namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_PointAudit
    {
        public int ID { get; set; }

        [Required]
        [StringLength(30)]
        public string Reference { get; set; }

        public long ReferrerID { get; set; }

        public long ReferreeID { get; set; }

        public decimal? Credit { get; set; }

        public decimal? Debit { get; set; }

        public long? RequestID { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        public int Type { get; set; }

        public DateTime Timestamp { get; set; }

        public int? PromotionID { get; set; }

        public decimal? AccruedPoints { get; set; }

        public decimal? AvailabledPoints { get; set; }

        public decimal? RedeemedPoints { get; set; }

        public decimal? FreshFunds { get; set; }

        public decimal? AllocatedFunds { get; set; }

        public decimal? Amount { get; set; }

        public long? UserID { get; set; }

        public virtual tbl_LoanRequests tbl_LoanRequests { get; set; }

        public virtual tbl_Users tbl_Users { get; set; }

        public virtual tbl_Users tbl_Users1 { get; set; }

        public virtual u_PromotionCampaigns u_PromotionCampaigns { get; set; }
    }
}
