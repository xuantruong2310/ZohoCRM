namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AAContract
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AAContract()
        {
            AAContractInvestments = new HashSet<AAContractInvestment>();
            AAIncompleteSignUpEmails = new HashSet<AAIncompleteSignUpEmail>();
            AAInsufficientFunds = new HashSet<AAInsufficientFund>();
            AAPreAllocates = new HashSet<AAPreAllocate>();
        }

        [Key]
        public long ContractId { get; set; }

        public long InvestorId { get; set; }

        public int ModeOFInvestment { get; set; }

        public int NOFCampaign { get; set; }

        public int CampaignAmount { get; set; }

        public int NOFInvestment { get; set; }

        public int InvestmentFrequency { get; set; }

        public bool? IsConsecutive { get; set; }

        [StringLength(500)]
        public string NoteTypes { get; set; }

        [StringLength(500)]
        public string IndustryPreferences { get; set; }

        public decimal? InterestPreference { get; set; }

        [StringLength(50)]
        public string RewardCode { get; set; }

        public int ContractStatus { get; set; }

        public bool? IsAnnualMembership { get; set; }

        public DateTime? DateCreate { get; set; }

        public DateTime? ContractEndDate { get; set; }

        public bool IsContractArchived { get; set; }

        public DateTime? AnnualSubscriptionEndDate { get; set; }

        public DateTime? AnnualSubscriptionStartDate { get; set; }

        [StringLength(250)]
        public string Comments { get; set; }

        public int RewardStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AAContractInvestment> AAContractInvestments { get; set; }

        public virtual tbl_Users tbl_Users { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AAIncompleteSignUpEmail> AAIncompleteSignUpEmails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AAInsufficientFund> AAInsufficientFunds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AAPreAllocate> AAPreAllocates { get; set; }
    }
}
