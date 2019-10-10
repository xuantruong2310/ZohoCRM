namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_MoolahPerksForLenders
    {
        [Key]
        public long MoolahPerkId { get; set; }

        [StringLength(500)]
        public string MoolahPerk { get; set; }

        public DateTime? DateCreated { get; set; }

        public bool? Isactive { get; set; }
    }
}
