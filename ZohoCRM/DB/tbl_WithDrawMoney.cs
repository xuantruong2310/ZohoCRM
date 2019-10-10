namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_WithDrawMoney
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_WithDrawMoney()
        {
            tbl_WithDrawAdminNotes = new HashSet<tbl_WithDrawAdminNotes>();
        }

        [Key]
        public long WithDrawID { get; set; }

        public long? User_ID { get; set; }

        public decimal? WithDrawAmount { get; set; }

        [StringLength(30)]
        public string Status { get; set; }

        public DateTime? DateCreated { get; set; }

        public DateTime? ActionbyAdmin { get; set; }

        public long? AdminID { get; set; }

        public decimal? CurrentBalance { get; set; }

        public decimal? AfterBalance { get; set; }

        [StringLength(30)]
        public string Type { get; set; }

        public virtual tbl_Users tbl_Users { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_WithDrawAdminNotes> tbl_WithDrawAdminNotes { get; set; }
    }
}
