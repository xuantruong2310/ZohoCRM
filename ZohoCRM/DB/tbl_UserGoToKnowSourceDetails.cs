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
    
    public partial class tbl_UserGoToKnowSourceDetails
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_UserGoToKnowSourceDetails()
        {
            this.tbl_Users = new HashSet<tbl_Users>();
        }
    
        public System.Guid Id { get; set; }
        public Nullable<long> GoToKnowSourceId { get; set; }
        public string ReferralName { get; set; }
        public string ReferralEmail { get; set; }
        public string Other { get; set; }
    
        public virtual tbl_GoToKnowSource tbl_GoToKnowSource { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Users> tbl_Users { get; set; }
    }
}
