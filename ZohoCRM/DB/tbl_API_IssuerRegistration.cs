namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_API_IssuerRegistration
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_API_IssuerRegistration()
        {
            tbl_API_Auditors = new HashSet<tbl_API_Auditors>();
            tbl_API_CapitalStructure = new HashSet<tbl_API_CapitalStructure>();
            tbl_API_Representatives = new HashSet<tbl_API_Representatives>();
            tbl_API_Shareholder = new HashSet<tbl_API_Shareholder>();
            tbl_API_WritOfSummons = new HashSet<tbl_API_WritOfSummons>();
        }

        public int ID { get; set; }

        public string EntityName { get; set; }

        [StringLength(50)]
        public string RegistrationNumber { get; set; }

        [StringLength(10)]
        public string Country { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FormerDate { get; set; }

        public string FormerName { get; set; }

        [StringLength(10)]
        public string BusinessYears { get; set; }

        [StringLength(20)]
        public string LegalEntity { get; set; }

        public string Address { get; set; }

        [Column(TypeName = "date")]
        public DateTime? AddressDate { get; set; }

        [StringLength(10)]
        public string Industry { get; set; }

        [StringLength(10)]
        public string Sector { get; set; }

        [StringLength(10)]
        public string PrincipalActivities { get; set; }

        [StringLength(50)]
        public string Status { get; set; }

        [Column(TypeName = "date")]
        public DateTime? StatusDate { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? LastUpdated { get; set; }

        [Column(TypeName = "date")]
        public DateTime? RegistrationDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_API_Auditors> tbl_API_Auditors { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_API_CapitalStructure> tbl_API_CapitalStructure { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_API_Representatives> tbl_API_Representatives { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_API_Shareholder> tbl_API_Shareholder { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_API_WritOfSummons> tbl_API_WritOfSummons { get; set; }
    }
}
