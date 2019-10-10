namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_Product()
        {
            tbl_GroupProduct = new HashSet<tbl_GroupProduct>();
            tbl_InvestorServicingFee = new HashSet<tbl_InvestorServicingFee>();
            tbl_LoanRequests = new HashSet<tbl_LoanRequests>();
            tbl_TenureMSFees = new HashSet<tbl_TenureMSFees>();
        }

        [Key]
        public int ProductID { get; set; }

        [Required]
        [StringLength(250)]
        public string Name { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [Required]
        [StringLength(50)]
        public string Tenure { get; set; }

        public int? RepaymentTerms { get; set; }

        public int? RepaymentAmount { get; set; }

        public bool? EarlyRepayment { get; set; }

        [StringLength(50)]
        public string NoticePeriod { get; set; }

        public int? Availability { get; set; }

        public decimal? DefaulterInterestRate { get; set; }

        [StringLength(50)]
        public string BiddingType { get; set; }

        public bool? IsInterestOnly { get; set; }

        public bool? IsHolidayPeriod { get; set; }

        [StringLength(50)]
        public string HolidayPeriods { get; set; }

        public bool? IsCallable { get; set; }

        public int ContractTemplateID { get; set; }

        public virtual p_ContractTemplate p_ContractTemplate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_GroupProduct> tbl_GroupProduct { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_InvestorServicingFee> tbl_InvestorServicingFee { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_LoanRequests> tbl_LoanRequests { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_TenureMSFees> tbl_TenureMSFees { get; set; }
    }
}
