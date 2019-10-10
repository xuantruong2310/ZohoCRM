namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_InvestorReferees
    {
        public long Id { get; set; }

        public long? UserId { get; set; }

        [Required]
        [StringLength(250)]
        public string FriendEmail { get; set; }

        public DateTime SendDate { get; set; }

        public int? CampaignID { get; set; }

        public virtual tbl_Users tbl_Users { get; set; }
    }
}
