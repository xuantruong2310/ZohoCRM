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
    
    public partial class tbl_Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_Product()
        {
            this.tbl_GroupProduct = new HashSet<tbl_GroupProduct>();
            this.tbl_InvestorServicingFee = new HashSet<tbl_InvestorServicingFee>();
            this.tbl_LoanRequests = new HashSet<tbl_LoanRequests>();
            this.tbl_TenureMSFees = new HashSet<tbl_TenureMSFees>();
        }
    
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Tenure { get; set; }
        public Nullable<int> RepaymentTerms { get; set; }
        public Nullable<int> RepaymentAmount { get; set; }
        public Nullable<bool> EarlyRepayment { get; set; }
        public string NoticePeriod { get; set; }
        public Nullable<int> Availability { get; set; }
        public Nullable<decimal> DefaulterInterestRate { get; set; }
        public string BiddingType { get; set; }
        public Nullable<bool> IsInterestOnly { get; set; }
        public Nullable<bool> IsHolidayPeriod { get; set; }
        public string HolidayPeriods { get; set; }
        public Nullable<bool> IsCallable { get; set; }
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
