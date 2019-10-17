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
    
    public partial class tbl_LoanRequests
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_LoanRequests()
        {
            this.AAContractInvestments = new HashSet<AAContractInvestment>();
            this.AAPreAllocates = new HashSet<AAPreAllocate>();
            this.CampaignEmailAlerts = new HashSet<CampaignEmailAlert>();
            this.IssuerRepayments = new HashSet<IssuerRepayment>();
            this.tbl_CampaignViewers = new HashSet<tbl_CampaignViewers>();
            this.tbl_Comments = new HashSet<tbl_Comments>();
            this.tbl_ESignInfo = new HashSet<tbl_ESignInfo>();
            this.tbl_GroupLoanRequests = new HashSet<tbl_GroupLoanRequests>();
            this.tbl_InvoiceFinanceProductDetails = new HashSet<tbl_InvoiceFinanceProductDetails>();
            this.tbl_Loanoffers = new HashSet<tbl_Loanoffers>();
            this.tbl_LoanRequestServiceFee = new HashSet<tbl_LoanRequestServiceFee>();
            this.tbl_LogESignInfo = new HashSet<tbl_LogESignInfo>();
            this.tbl_PointAudit = new HashSet<tbl_PointAudit>();
            this.tbl_MoolahCore = new HashSet<tbl_MoolahCore>();
            this.tbl_NewMoolahCore = new HashSet<tbl_NewMoolahCore>();
            this.tbl_LoanTransactions = new HashSet<tbl_LoanTransactions>();
            this.tbl_MoolahCoreVerification = new HashSet<tbl_MoolahCoreVerification>();
            this.tbl_MoolahPeri = new HashSet<tbl_MoolahPeri>();
            this.tbl_MoolahPeriVerification = new HashSet<tbl_MoolahPeriVerification>();
            this.tbl_NewMoolahCoreVerification = new HashSet<tbl_NewMoolahCoreVerification>();
            this.tbl_PaidLatePayments = new HashSet<tbl_PaidLatePayments>();
            this.tbl_PersonalGuaranteeInfo = new HashSet<tbl_PersonalGuaranteeInfo>();
            this.tbl_RepaymentMessages = new HashSet<tbl_RepaymentMessages>();
            this.tbl_WatchList = new HashSet<tbl_WatchList>();
        }
    
        public long RequestId { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<decimal> FinalAmount { get; set; }
        public string Tenure { get; set; }
        public Nullable<decimal> EIR { get; set; }
        public Nullable<decimal> Rate { get; set; }
        public Nullable<bool> IsotherLoanType { get; set; }
        public string Question { get; set; }
        public Nullable<bool> IsPersonalGuarantee { get; set; }
        public Nullable<long> User_ID { get; set; }
        public Nullable<bool> IsApproved { get; set; }
        public string VideoDescription { get; set; }
        public int LoanStatus { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public Nullable<int> LoanPurpose_Id { get; set; }
        public Nullable<System.DateTime> ApproveDate { get; set; }
        public Nullable<System.DateTime> AcceptedDate { get; set; }
        public Nullable<decimal> MoolahFees { get; set; }
        public string SummaryCompanyPro { get; set; }
        public string DetailedCompanyPro { get; set; }
        public Nullable<bool> Submitted { get; set; }
        public Nullable<int> NumberOfEmployees { get; set; }
        public decimal RequestedRate { get; set; }
        public int PreliminaryLoanStatus { get; set; }
        public Nullable<System.DateTime> PublishedDate { get; set; }
        public string LoanPurposeDescription { get; set; }
        public string MoolahSenseComments { get; set; }
        public Nullable<System.DateTime> TransferDate { get; set; }
        public string ResonReject { get; set; }
        public string Headline { get; set; }
        public int CampaignPeriod { get; set; }
        public string DigitalSignature { get; set; }
        public Nullable<System.DateTime> ResubmitOffersStartDate { get; set; }
        public Nullable<int> ResubmitOffersDuration { get; set; }
        public string ResubmitOffersReference { get; set; }
        public Nullable<int> ProductID { get; set; }
        public Nullable<bool> AutoAcceptAfterLastResubmitDate { get; set; }
        public Nullable<bool> AutoShowResubmitOffers { get; set; }
        public string ResubmitRequestID { get; set; }
        public Nullable<System.DateTime> TargetReachDate { get; set; }
        public string PrivateName { get; set; }
        public Nullable<int> AccessLevel { get; set; }
        public Nullable<int> BiddingType { get; set; }
        public string Sublink { get; set; }
        public Nullable<int> HolidayPeriod { get; set; }
        public Nullable<decimal> FundingLimit { get; set; }
        public Nullable<decimal> LateInterestRate { get; set; }
        public Nullable<System.DateTime> RestructureDate { get; set; }
        public Nullable<int> CountryID { get; set; }
        public Nullable<System.DateTime> LaunchDate { get; set; }
        public Nullable<decimal> MinimumOfferAmount { get; set; }
        public Nullable<double> DepositeAmount { get; set; }
        public Nullable<int> ViewerCount { get; set; }
        public bool IsLimitedAccess { get; set; }
        public short ProductID2 { get; set; }
        public bool IsStressed { get; set; }
        public Nullable<System.DateTime> StressDate { get; set; }
        public bool IsDefault { get; set; }
        public Nullable<System.DateTime> DeafultDate { get; set; }
        public string DefaultCmnt { get; set; }
        public Nullable<bool> IsCalculateInvestorServiceFee { get; set; }
        public string SecureFreeText { get; set; }
        public string AppID { get; set; }
        public Nullable<System.DateTime> IssuerPublishedDate { get; set; }
        public Nullable<int> InvestmentMultiple { get; set; }
        public Nullable<int> LinkNoteID { get; set; }
    
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
