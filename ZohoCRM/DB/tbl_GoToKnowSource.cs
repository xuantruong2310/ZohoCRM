namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_GoToKnowSource
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_GoToKnowSource()
        {
            tbl_UserGoToKnowSourceDetails = new HashSet<tbl_UserGoToKnowSourceDetails>();
        }

        public long Id { get; set; }

        [Required]
        [StringLength(550)]
        public string Name { get; set; }

        public int? Rate { get; set; }

        public bool IsActive { get; set; }

        public int? Type { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_UserGoToKnowSourceDetails> tbl_UserGoToKnowSourceDetails { get; set; }
    }
}
