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
    
    public partial class tbl_API_Shareholder
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_API_Shareholder()
        {
            this.tbl_API_ShareholderDetails = new HashSet<tbl_API_ShareholderDetails>();
        }
    
        public int ID { get; set; }
        public Nullable<int> IssuerID { get; set; }
        public string NumberOfShareholders { get; set; }
        public string ShareholderOptions { get; set; }
    
        public virtual tbl_API_IssuerRegistration tbl_API_IssuerRegistration { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_API_ShareholderDetails> tbl_API_ShareholderDetails { get; set; }
    }
}
