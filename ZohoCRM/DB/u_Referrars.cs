namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class u_Referrars
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public u_Referrars()
        {
            tbl_Users = new HashSet<tbl_Users>();
        }

        public int ID { get; set; }

        public long UserID { get; set; }

        public decimal? CurrentFreshFunds { get; set; }

        public decimal? CurrentAllocatedFunds { get; set; }

        public decimal? CurrentQualifiedFunds { get; set; }

        public decimal? AccruedPoints { get; set; }

        public decimal? AvailablePoints { get; set; }

        public int PromotionID { get; set; }

        [StringLength(50)]
        public string ReferralCode { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Users> tbl_Users { get; set; }

        public virtual tbl_Users tbl_Users1 { get; set; }

        public virtual u_PromotionCampaigns u_PromotionCampaigns { get; set; }
    }
}
