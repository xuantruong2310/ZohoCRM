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
    
    public partial class tbl_Countries
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_Countries()
        {
            this.tbl_AccountDetails = new HashSet<tbl_AccountDetails>();
            this.tbl_AccountDetails1 = new HashSet<tbl_AccountDetails>();
            this.tbl_LoanRequests = new HashSet<tbl_LoanRequests>();
        }
    
        public int CountryID { get; set; }
        public string ISO2 { get; set; }
        public string CountryName { get; set; }
        public string LongCountryName { get; set; }
        public string ISO3 { get; set; }
        public string NumCode { get; set; }
        public string UNMemberState { get; set; }
        public string CallingCode { get; set; }
        public string CCTLD { get; set; }
        public string CurrencyCode { get; set; }
        public string UnicodeDecimal { get; set; }
        public string UnicodeHex { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_AccountDetails> tbl_AccountDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_AccountDetails> tbl_AccountDetails1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_LoanRequests> tbl_LoanRequests { get; set; }
    }
}
