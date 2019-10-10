namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_UserGoToKnowSourceDetails
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_UserGoToKnowSourceDetails()
        {
            tbl_Users = new HashSet<tbl_Users>();
        }

        public Guid Id { get; set; }

        public long? GoToKnowSourceId { get; set; }

        [StringLength(50)]
        public string ReferralName { get; set; }

        [StringLength(50)]
        public string ReferralEmail { get; set; }

        [StringLength(550)]
        public string Other { get; set; }

        public virtual tbl_GoToKnowSource tbl_GoToKnowSource { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Users> tbl_Users { get; set; }
    }
}
