//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_API_IssuerRegistration
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_API_IssuerRegistration()
        {
            this.tbl_API_Auditors = new HashSet<tbl_API_Auditors>();
            this.tbl_API_CapitalStructure = new HashSet<tbl_API_CapitalStructure>();
            this.tbl_API_Representatives = new HashSet<tbl_API_Representatives>();
            this.tbl_API_Shareholder = new HashSet<tbl_API_Shareholder>();
            this.tbl_API_WritOfSummons = new HashSet<tbl_API_WritOfSummons>();
        }
    
        public int ID { get; set; }
        public string EntityName { get; set; }
        public string RegistrationNumber { get; set; }
        public string Country { get; set; }
        public Nullable<System.DateTime> FormerDate { get; set; }
        public string FormerName { get; set; }
        public string BusinessYears { get; set; }
        public string LegalEntity { get; set; }
        public string Address { get; set; }
        public Nullable<System.DateTime> AddressDate { get; set; }
        public string Industry { get; set; }
        public string Sector { get; set; }
        public string PrincipalActivities { get; set; }
        public string Status { get; set; }
        public Nullable<System.DateTime> StatusDate { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> LastUpdated { get; set; }
        public Nullable<System.DateTime> RegistrationDate { get; set; }
    
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
