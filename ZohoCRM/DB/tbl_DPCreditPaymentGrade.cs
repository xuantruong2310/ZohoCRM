namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_DPCreditPaymentGrade
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_DPCreditPaymentGrade()
        {
            tbl_MoolahCore = new HashSet<tbl_MoolahCore>();
            tbl_NewMoolahCore = new HashSet<tbl_NewMoolahCore>();
        }

        public int ID { get; set; }

        [StringLength(10)]
        public string CreditRating { get; set; }

        [StringLength(30)]
        public string Range { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_MoolahCore> tbl_MoolahCore { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_NewMoolahCore> tbl_NewMoolahCore { get; set; }
    }
}
