namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_Users
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_Users()
        {
            AAContracts = new HashSet<AAContract>();
            FundTransferInSlips = new HashSet<FundTransferInSlip>();
            tbl_AuditTwoFAVerification = new HashSet<tbl_AuditTwoFAVerification>();
            tbl_Balances = new HashSet<tbl_Balances>();
            tbl_CampaignViewers = new HashSet<tbl_CampaignViewers>();
            tbl_Comments = new HashSet<tbl_Comments>();
            tbl_FundTransferIN_Staging = new HashSet<tbl_FundTransferIN_Staging>();
            tbl_FundTransferRef = new HashSet<tbl_FundTransferRef>();
            tbl_GroupUsers = new HashSet<tbl_GroupUsers>();
            tbl_InvestorReferees = new HashSet<tbl_InvestorReferees>();
            tbl_Knowledgeassessmentdetails_ForUser = new HashSet<tbl_Knowledgeassessmentdetails_ForUser>();
            tbl_Loanoffers = new HashSet<tbl_Loanoffers>();
            tbl_LoanRequests = new HashSet<tbl_LoanRequests>();
            tbl_LoanTransactions = new HashSet<tbl_LoanTransactions>();
            tbl_LoanTransactions1 = new HashSet<tbl_LoanTransactions>();
            tbl_MoolahCore = new HashSet<tbl_MoolahCore>();
            tbl_MoolahPeri = new HashSet<tbl_MoolahPeri>();
            tbl_NewMoolahCore = new HashSet<tbl_NewMoolahCore>();
            tbl_OutStandingLitigation = new HashSet<tbl_OutStandingLitigation>();
            tbl_PointAudit = new HashSet<tbl_PointAudit>();
            tbl_PointAudit1 = new HashSet<tbl_PointAudit>();
            tbl_SecurityQuestionsForUsers = new HashSet<tbl_SecurityQuestionsForUsers>();
            tbl_TwoFAVerification = new HashSet<tbl_TwoFAVerification>();
            tbl_UserPreferences = new HashSet<tbl_UserPreferences>();
            UserRepaymentMsgs = new HashSet<UserRepaymentMsg>();
            tbl_WithDrawMoney = new HashSet<tbl_WithDrawMoney>();
            u_Points = new HashSet<u_Points>();
            u_Referrars1 = new HashSet<u_Referrars>();
            UsersRoles = new HashSet<UsersRole>();
        }

        [Key]
        public long UserID { get; set; }

        [StringLength(250)]
        public string UserName { get; set; }

        public bool? Isactive { get; set; }

        [StringLength(50)]
        public string UserRole { get; set; }

        public DateTime? DateCreated { get; set; }

        public bool? SubscribeforUpdates { get; set; }

        [StringLength(32)]
        public string InvestorType { get; set; }

        [StringLength(16)]
        public string AdminVerification { get; set; }

        public bool? IsSubmitted { get; set; }

        public Guid AspnetUserId { get; set; }

        public bool? IsEmailVerified { get; set; }

        [StringLength(128)]
        public string DigitalSignature { get; set; }

        public DateTime? SubmittedDate { get; set; }

        public bool? IsDeleted { get; set; }

        public Guid? UserGoToKnowSourceDetailsId { get; set; }

        public DateTime? LastRefPromoEndDate { get; set; }

        public bool? IsFirstTimeAccessed { get; set; }

        public DateTime? ApprovedDate { get; set; }

        public bool HasAcknowledgedRisk { get; set; }

        [StringLength(100)]
        public string RiskAcknowledgeSignature { get; set; }

        public DateTime? RiskAcknowledgeDate { get; set; }

        public bool HasViewUnlock_Video { get; set; }

        public bool HasView_Auto_Allocate_Video { get; set; }

        public int TransferSlipStatus { get; set; }

        public string Remarks { get; set; }

        public DateTime? QualifiedDate { get; set; }

        public bool? EmailUnsubscribed { get; set; }

        public bool? MPThreeDayNoActionMailSent { get; set; }

        public bool IsQualifiedPointsRewared { get; set; }

        public byte? IsTwoFARegistered { get; set; }

        public int? ReferrarID { get; set; }

        public byte? LoginType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AAContract> AAContracts { get; set; }

        public virtual aspnet_Users aspnet_Users { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FundTransferInSlip> FundTransferInSlips { get; set; }

        public virtual tbl_AccountDetails tbl_AccountDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_AuditTwoFAVerification> tbl_AuditTwoFAVerification { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Balances> tbl_Balances { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_CampaignViewers> tbl_CampaignViewers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Comments> tbl_Comments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_FundTransferIN_Staging> tbl_FundTransferIN_Staging { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_FundTransferRef> tbl_FundTransferRef { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_GroupUsers> tbl_GroupUsers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_InvestorReferees> tbl_InvestorReferees { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Knowledgeassessmentdetails_ForUser> tbl_Knowledgeassessmentdetails_ForUser { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Loanoffers> tbl_Loanoffers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_LoanRequests> tbl_LoanRequests { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_LoanTransactions> tbl_LoanTransactions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_LoanTransactions> tbl_LoanTransactions1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_MoolahCore> tbl_MoolahCore { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_MoolahPeri> tbl_MoolahPeri { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_NewMoolahCore> tbl_NewMoolahCore { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_OutStandingLitigation> tbl_OutStandingLitigation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_PointAudit> tbl_PointAudit { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_PointAudit> tbl_PointAudit1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_SecurityQuestionsForUsers> tbl_SecurityQuestionsForUsers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_TwoFAVerification> tbl_TwoFAVerification { get; set; }

        public virtual tbl_UserGoToKnowSourceDetails tbl_UserGoToKnowSourceDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_UserPreferences> tbl_UserPreferences { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserRepaymentMsg> UserRepaymentMsgs { get; set; }

        public virtual u_Referrars u_Referrars { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_WithDrawMoney> tbl_WithDrawMoney { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<u_Points> u_Points { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<u_Referrars> u_Referrars1 { get; set; }

        public virtual UserAcknowledgement UserAcknowledgement { get; set; }

        public virtual UserEmployment UserEmployment { get; set; }

        public virtual UserQualification UserQualification { get; set; }

        public virtual UserQualificationVerification UserQualificationVerification { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UsersRole> UsersRoles { get; set; }
    }
}
