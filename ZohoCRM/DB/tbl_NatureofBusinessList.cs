namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_NatureofBusinessList
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_NatureofBusinessList()
        {
            tbl_AccountDetails = new HashSet<tbl_AccountDetails>();
        }

        [Key]
        public int NatureofBusinessId { get; set; }

        [StringLength(500)]
        public string NatureofBusinessName { get; set; }

        public bool? Isactive { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_AccountDetails> tbl_AccountDetails { get; set; }
    }
}
