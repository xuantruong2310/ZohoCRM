namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_InvestorServicingFeeType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_InvestorServicingFeeType()
        {
            tbl_InvestorServicingFee = new HashSet<tbl_InvestorServicingFee>();
            tbl_LoanRequestServiceFee = new HashSet<tbl_LoanRequestServiceFee>();
        }

        [Key]
        public int InvestorServicingFeeTypeID { get; set; }

        [StringLength(500)]
        public string Name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_InvestorServicingFee> tbl_InvestorServicingFee { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_LoanRequestServiceFee> tbl_LoanRequestServiceFee { get; set; }
    }
}
