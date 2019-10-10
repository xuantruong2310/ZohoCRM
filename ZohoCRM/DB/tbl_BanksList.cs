namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_BanksList
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_BanksList()
        {
            tbl_AccountDetails = new HashSet<tbl_AccountDetails>();
        }

        [Key]
        public int BankId { get; set; }

        [StringLength(200)]
        public string BankName { get; set; }

        public bool? Isactive { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_AccountDetails> tbl_AccountDetails { get; set; }
    }
}
