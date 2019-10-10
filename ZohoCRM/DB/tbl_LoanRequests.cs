namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_LoanRequests
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_LoanRequests()
        {
            AAContractInvestments = new HashSet<AAContractInvestment>();
            AAPreAllocates = new HashSet<AAPreAllocate>();
            CampaignEmailAlerts = new HashSet<CampaignEmailAlert>();
            IssuerRepayments = new HashSet<IssuerRepayment>();
            tbl_CampaignViewers = new HashSet<tbl_CampaignViewers>();
            tbl_Comments = new HashSet<tbl_Comments>();
            tbl_ESignInfo = new HashSet<tbl_ESignInfo>();
            tbl_GroupLoanRequests = new HashSet<tbl_GroupLoanRequests>();
            tbl_InvoiceFinanceProductDetails = new HashSet<tbl_InvoiceFinanceProductDetails>();
            tbl_Loanoffers = new HashSet<tbl_Loanoffers>();
            tbl_LoanRequestServiceFee = new HashSet<tbl_LoanRequestServiceFee>();
            tbl_LogESignInfo = new HashSet<tbl_LogESignInfo>();
            tbl_PointAudit = new HashSet<tbl_PointAudit>();
            tbl_MoolahCore = new HashSet<tbl_MoolahCore>();
            tbl_NewMoolahCore = new HashSet<tbl_NewMoolahCore>();
            tbl_LoanTransactions = new HashSet<tbl_LoanTransactions>();
            tbl_MoolahCoreVerification = new HashSet<tbl_MoolahCoreVerification>();
            tbl_MoolahPeri = new HashSet<tbl_MoolahPeri>();
            tbl_MoolahPeriVerification = new HashSet<tbl_MoolahPeriVerification>();
            tbl_NewMoolahCoreVerification = new HashSet<tbl_NewMoolahCoreVerification>();
            tbl_PaidLatePayments = new HashSet<tbl_PaidLatePayments>();
            tbl_PersonalGuaranteeInfo = new HashSet<tbl_PersonalGuaranteeInfo>();
            tbl_RepaymentMessages = new HashSet<tbl_RepaymentMessages>();
            tbl_WatchList = new HashSet<tbl_WatchList>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long RequestId { get; set; }

        public decimal? Amount { get; set; }

        public decimal? FinalAmount { get; set; }

        [StringLength(50)]
        public string Tenure { get; set; }

        public decimal? EIR { get; set; }

        public decimal? Rate { get; set; }

        public bool? IsotherLoanType { get; set; }

        [StringLength(2000)]
        public string Question { get; set; }

        public bool? IsPersonalGuarantee { get; set; }

        public long? User_ID { get; set; }

        public bool? IsApproved { get; set; }

        public string VideoDescription { get; set; }

        public int LoanStatus { get; set; }

        public DateTime? DateCreated { get; set; }

        public int? LoanPurpose_Id { get; set; }

        public DateTime? ApproveDate { get; set; }

        public DateTime? AcceptedDate { get; set; }

        public decimal? MoolahFees { get; set; }

        public string SummaryCompanyPro { get; set; }

        public string DetailedCompanyPro { get; set; }

        public bool? Submitted { get; set; }

        public int? NumberOfEmployees { get; set; }

        public decimal RequestedRate { get; set; }

        public int PreliminaryLoanStatus { get; set; }

        public DateTime? PublishedDate { get; set; }

        public string LoanPurposeDescription { get; set; }

        public string MoolahSenseComments { get; set; }

        public DateTime? TransferDate { get; set; }

        [StringLength(100)]
        public string ResonReject { get; set; }

        [StringLength(200)]
        public string Headline { get; set; }

        public int CampaignPeriod { get; set; }

        [StringLength(128)]
        public string DigitalSignature { get; set; }

        public DateTime? ResubmitOffersStartDate { get; set; }

        public int? ResubmitOffersDuration { get; set; }

        [StringLength(50)]
        public string ResubmitOffersReference { get; set; }

        public int? ProductID { get; set; }

        public bool? AutoAcceptAfterLastResubmitDate { get; set; }

        public bool? AutoShowResubmitOffers { get; set; }

        [StringLength(100)]
        public string ResubmitRequestID { get; set; }

        public DateTime? TargetReachDate { get; set; }

        [StringLength(500)]
        public string PrivateName { get; set; }

        public int? AccessLevel { get; set; }

        public int? BiddingType { get; set; }

        [StringLength(10)]
        public string Sublink { get; set; }

        public int? HolidayPeriod { get; set; }

        public decimal? FundingLimit { get; set; }

        public decimal? LateInterestRate { get; set; }

        public DateTime? RestructureDate { get; set; }

        public int? CountryID { get; set; }

        public DateTime? LaunchDate { get; set; }

        public decimal? MinimumOfferAmount { get; set; }

        public double? DepositeAmount { get; set; }

        public int? ViewerCount { get; set; }

        public bool IsLimitedAccess { get; set; }

        public short ProductID2 { get; set; }

        public bool IsStressed { get; set; }

        public DateTime? StressDate { get; set; }

        public bool IsDefault { get; set; }

        public DateTime? DeafultDate { get; set; }

        public string DefaultCmnt { get; set; }

        public bool? IsCalculateInvestorServiceFee { get; set; }

        public string SecureFreeText { get; set; }

        [StringLength(20)]
        public string AppID { get; set; }

        public DateTime? IssuerPublishedDate { get; set; }

        public int? InvestmentMultiple { get; set; }

        public int? LinkNoteID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AAContractInvestment> AAContractInvestments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AAPreAllocate> AAPreAllocates { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CampaignEmailAlert> CampaignEmailAlerts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IssuerRepayment> IssuerRepayments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_CampaignViewers> tbl_CampaignViewers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Comments> tbl_Comments { get; set; }

        public virtual tbl_Countries tbl_Countries { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_ESignInfo> tbl_ESignInfo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_GroupLoanRequests> tbl_GroupLoanRequests { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_InvoiceFinanceProductDetails> tbl_InvoiceFinanceProductDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Loanoffers> tbl_Loanoffers { get; set; }

        public virtual tbl_LoanPurposesList tbl_LoanPurposesList { get; set; }

        public virtual tbl_Product tbl_Product { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_LoanRequestServiceFee> tbl_LoanRequestServiceFee { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_LogESignInfo> tbl_LogESignInfo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_PointAudit> tbl_PointAudit { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_MoolahCore> tbl_MoolahCore { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_NewMoolahCore> tbl_NewMoolahCore { get; set; }

        public virtual tbl_Users tbl_Users { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_LoanTransactions> tbl_LoanTransactions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_MoolahCoreVerification> tbl_MoolahCoreVerification { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_MoolahPeri> tbl_MoolahPeri { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_MoolahPeriVerification> tbl_MoolahPeriVerification { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_NewMoolahCoreVerification> tbl_NewMoolahCoreVerification { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_PaidLatePayments> tbl_PaidLatePayments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_PersonalGuaranteeInfo> tbl_PersonalGuaranteeInfo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_RepaymentMessages> tbl_RepaymentMessages { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_WatchList> tbl_WatchList { get; set; }
    }
}
