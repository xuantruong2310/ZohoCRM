namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_Countries
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_Countries()
        {
            tbl_AccountDetails = new HashSet<tbl_AccountDetails>();
            tbl_AccountDetails1 = new HashSet<tbl_AccountDetails>();
            tbl_LoanRequests = new HashSet<tbl_LoanRequests>();
        }

        [Key]
        public int CountryID { get; set; }

        [StringLength(2)]
        public string ISO2 { get; set; }

        [StringLength(128)]
        public string CountryName { get; set; }

        [StringLength(128)]
        public string LongCountryName { get; set; }

        [StringLength(3)]
        public string ISO3 { get; set; }

        [StringLength(8)]
        public string NumCode { get; set; }

        [StringLength(16)]
        public string UNMemberState { get; set; }

        [StringLength(8)]
        public string CallingCode { get; set; }

        [StringLength(8)]
        public string CCTLD { get; set; }

        [StringLength(3)]
        public string CurrencyCode { get; set; }

        [StringLength(50)]
        public string UnicodeDecimal { get; set; }

        [StringLength(50)]
        public string UnicodeHex { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_AccountDetails> tbl_AccountDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_AccountDetails> tbl_AccountDetails1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_LoanRequests> tbl_LoanRequests { get; set; }
    }
}
