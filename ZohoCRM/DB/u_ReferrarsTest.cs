namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class u_ReferrarsTest
    {
        [Key]
        [Column(Order = 0)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long UserID { get; set; }

        public decimal? CurrentFreshFunds { get; set; }

        public decimal? CurrentAllocatedFunds { get; set; }

        public decimal? CurrentQualifiedFunds { get; set; }

        public decimal? AccruedPoints { get; set; }

        public decimal? AvailablePoints { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PromotionID { get; set; }

        [StringLength(50)]
        public string ReferralCode { get; set; }
    }
}
