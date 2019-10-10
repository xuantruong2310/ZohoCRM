namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_Group
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_Group()
        {
            tbl_GroupLoanRequests = new HashSet<tbl_GroupLoanRequests>();
            tbl_GroupProduct = new HashSet<tbl_GroupProduct>();
            tbl_GroupUsers = new HashSet<tbl_GroupUsers>();
            tbl_Investor_Announcement_Groups = new HashSet<tbl_Investor_Announcement_Groups>();
        }

        [Key]
        public int GroupID { get; set; }

        [Required]
        [StringLength(250)]
        public string GroupName { get; set; }

        public bool? IsDeleted { get; set; }

        public string GroupDescription { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_GroupLoanRequests> tbl_GroupLoanRequests { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_GroupProduct> tbl_GroupProduct { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_GroupUsers> tbl_GroupUsers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Investor_Announcement_Groups> tbl_Investor_Announcement_Groups { get; set; }
    }
}
