namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_API_Shareholder
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_API_Shareholder()
        {
            tbl_API_ShareholderDetails = new HashSet<tbl_API_ShareholderDetails>();
        }

        public int ID { get; set; }

        public int? IssuerID { get; set; }

        [StringLength(10)]
        public string NumberOfShareholders { get; set; }

        [StringLength(100)]
        public string ShareholderOptions { get; set; }

        public virtual tbl_API_IssuerRegistration tbl_API_IssuerRegistration { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_API_ShareholderDetails> tbl_API_ShareholderDetails { get; set; }
    }
}
