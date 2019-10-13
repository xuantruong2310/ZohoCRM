namespace ZohoCRM.DB
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DatabaseMS : DbContext
    {
        public DatabaseMS()
            : base("name=db")
        {
        }

        public virtual DbSet<AAContractInvestment> AAContractInvestments { get; set; }
        public virtual DbSet<AAContract> AAContracts { get; set; }
        public virtual DbSet<AAIncompleteSignUpEmail> AAIncompleteSignUpEmails { get; set; }
        public virtual DbSet<AAInsufficientFund> AAInsufficientFunds { get; set; }
        public virtual DbSet<AAPlusCost> AAPlusCosts { get; set; }
        public virtual DbSet<AAPreAllocate> AAPreAllocates { get; set; }
        public virtual DbSet<aspnet_Applications> aspnet_Applications { get; set; }
        public virtual DbSet<aspnet_Membership> aspnet_Membership { get; set; }
        public virtual DbSet<aspnet_Profile> aspnet_Profile { get; set; }
        public virtual DbSet<aspnet_Roles> aspnet_Roles { get; set; }
        public virtual DbSet<aspnet_SchemaVersions> aspnet_SchemaVersions { get; set; }
        public virtual DbSet<aspnet_Users> aspnet_Users { get; set; }
        public virtual DbSet<aspnet_UsersInRoles> aspnet_UsersInRoles { get; set; }
        public virtual DbSet<b_UOBGroupBranches> b_UOBGroupBranches { get; set; }
        public virtual DbSet<BrwInitialNoteRequest> BrwInitialNoteRequests { get; set; }
        public virtual DbSet<CampaignEmailAlert> CampaignEmailAlerts { get; set; }
        public virtual DbSet<DropdownList> DropdownLists { get; set; }
        public virtual DbSet<DropdownListCategory> DropdownListCategories { get; set; }
        public virtual DbSet<EmailScheduler> EmailSchedulers { get; set; }
        public virtual DbSet<EmailTemplate> EmailTemplates { get; set; }
        public virtual DbSet<FundTransferInSlip> FundTransferInSlips { get; set; }
        public virtual DbSet<InvestorLateInterest> InvestorLateInterests { get; set; }
        public virtual DbSet<InvestorRepayment> InvestorRepayments { get; set; }
        public virtual DbSet<InvestorRepaymentPayment> InvestorRepaymentPayments { get; set; }
        public virtual DbSet<IssuerLateInterest> IssuerLateInterests { get; set; }
        public virtual DbSet<IssuerRepayment> IssuerRepayments { get; set; }
        public virtual DbSet<IssuerRepaymentPayment> IssuerRepaymentPayments { get; set; }
        public virtual DbSet<p_ContractTemplate> p_ContractTemplate { get; set; }
        public virtual DbSet<PublicHoliday> PublicHolidays { get; set; }
        public virtual DbSet<Reward> Rewards { get; set; }
        public virtual DbSet<tbl_AACharging> tbl_AACharging { get; set; }
        public virtual DbSet<tbl_AccInt_ApplicationDetails> tbl_AccInt_ApplicationDetails { get; set; }
        public virtual DbSet<tbl_AccInt_RequestFiles> tbl_AccInt_RequestFiles { get; set; }
        public virtual DbSet<tbl_AccInt_RequestMaster> tbl_AccInt_RequestMaster { get; set; }
        public virtual DbSet<tbl_AccInt_ServiceResponse> tbl_AccInt_ServiceResponse { get; set; }
        public virtual DbSet<tbl_AccInt_TokenStore> tbl_AccInt_TokenStore { get; set; }
        public virtual DbSet<tbl_AccountAdjustment> tbl_AccountAdjustment { get; set; }
        public virtual DbSet<tbl_AccountDetails> tbl_AccountDetails { get; set; }
        public virtual DbSet<tbl_AccountDetialsIgnoreList> tbl_AccountDetialsIgnoreList { get; set; }
        public virtual DbSet<tbl_AdminActionLogs> tbl_AdminActionLogs { get; set; }
        public virtual DbSet<tbl_API_ACRA_COMPANY_REGN_DATA> tbl_API_ACRA_COMPANY_REGN_DATA { get; set; }
        public virtual DbSet<tbl_API_Auditors> tbl_API_Auditors { get; set; }
        public virtual DbSet<tbl_API_Bankruptcy> tbl_API_Bankruptcy { get; set; }
        public virtual DbSet<tbl_API_BankruptcyFIling> tbl_API_BankruptcyFIling { get; set; }
        public virtual DbSet<tbl_API_BusinessLitigation> tbl_API_BusinessLitigation { get; set; }
        public virtual DbSet<tbl_API_BusinessLitigationFiling> tbl_API_BusinessLitigationFiling { get; set; }
        public virtual DbSet<tbl_API_CapitalStructure> tbl_API_CapitalStructure { get; set; }
        public virtual DbSet<tbl_API_DPRatingMaster> tbl_API_DPRatingMaster { get; set; }
        public virtual DbSet<tbl_API_Filings> tbl_API_Filings { get; set; }
        public virtual DbSet<tbl_API_Guarantor> tbl_API_Guarantor { get; set; }
        public virtual DbSet<tbl_API_IndividualLitigation> tbl_API_IndividualLitigation { get; set; }
        public virtual DbSet<tbl_API_IndividualLitigationFiling> tbl_API_IndividualLitigationFiling { get; set; }
        public virtual DbSet<tbl_API_IssuerRegistration> tbl_API_IssuerRegistration { get; set; }
        public virtual DbSet<tbl_API_Representatives> tbl_API_Representatives { get; set; }
        public virtual DbSet<tbl_API_Scorto_ApplicationInfo> tbl_API_Scorto_ApplicationInfo { get; set; }
        public virtual DbSet<tbl_API_Scorto_Configuration> tbl_API_Scorto_Configuration { get; set; }
        public virtual DbSet<tbl_API_Scorto_CreditInfo> tbl_API_Scorto_CreditInfo { get; set; }
        public virtual DbSet<tbl_API_Scorto_IssuerInfo> tbl_API_Scorto_IssuerInfo { get; set; }
        public virtual DbSet<tbl_API_SearchCount> tbl_API_SearchCount { get; set; }
        public virtual DbSet<tbl_API_Shareholder> tbl_API_Shareholder { get; set; }
        public virtual DbSet<tbl_API_ShareholderDetails> tbl_API_ShareholderDetails { get; set; }
        public virtual DbSet<tbl_API_WritOfSummons> tbl_API_WritOfSummons { get; set; }
        public virtual DbSet<tbl_AuditLog> tbl_AuditLog { get; set; }
        public virtual DbSet<tbl_AuditTrial> tbl_AuditTrial { get; set; }
        public virtual DbSet<tbl_AuditTwoFAVerification> tbl_AuditTwoFAVerification { get; set; }
        public virtual DbSet<tbl_Balances> tbl_Balances { get; set; }
        public virtual DbSet<tbl_BanksList> tbl_BanksList { get; set; }
        public virtual DbSet<tbl_CampaignMinimumAmounts> tbl_CampaignMinimumAmounts { get; set; }
        public virtual DbSet<tbl_CampaignViewers> tbl_CampaignViewers { get; set; }
        public virtual DbSet<tbl_Comments> tbl_Comments { get; set; }
        public virtual DbSet<tbl_Countries> tbl_Countries { get; set; }
        public virtual DbSet<tbl_DPCreditPaymentGrade> tbl_DPCreditPaymentGrade { get; set; }
        public virtual DbSet<tbl_ErrorLog> tbl_ErrorLog { get; set; }
        public virtual DbSet<tbl_ESignInfo> tbl_ESignInfo { get; set; }
        public virtual DbSet<tbl_Files> tbl_Files { get; set; }
        public virtual DbSet<tbl_FundTransferIN_Raw> tbl_FundTransferIN_Raw { get; set; }
        public virtual DbSet<tbl_FundTransferIN_Staging> tbl_FundTransferIN_Staging { get; set; }
        public virtual DbSet<tbl_FundTransferRef> tbl_FundTransferRef { get; set; }
        public virtual DbSet<tbl_GlobalVariables> tbl_GlobalVariables { get; set; }
        public virtual DbSet<tbl_GoToKnowSource> tbl_GoToKnowSource { get; set; }
        public virtual DbSet<tbl_Group> tbl_Group { get; set; }
        public virtual DbSet<tbl_GroupLoanRequests> tbl_GroupLoanRequests { get; set; }
        public virtual DbSet<tbl_GroupProduct> tbl_GroupProduct { get; set; }
        public virtual DbSet<tbl_GroupUsers> tbl_GroupUsers { get; set; }
        public virtual DbSet<tbl_Investor_Announcement_Groups> tbl_Investor_Announcement_Groups { get; set; }
        public virtual DbSet<tbl_Investor_Announcements> tbl_Investor_Announcements { get; set; }
        public virtual DbSet<tbl_InvestorReferees> tbl_InvestorReferees { get; set; }
        public virtual DbSet<tbl_InvestorServicingFee> tbl_InvestorServicingFee { get; set; }
        public virtual DbSet<tbl_InvestorServicingFeeType> tbl_InvestorServicingFeeType { get; set; }
        public virtual DbSet<tbl_InvoiceFinanceProductDetails> tbl_InvoiceFinanceProductDetails { get; set; }
        public virtual DbSet<tbl_Knowledgeassessment_OptionsList> tbl_Knowledgeassessment_OptionsList { get; set; }
        public virtual DbSet<tbl_Knowledgeassessment_Parentlist> tbl_Knowledgeassessment_Parentlist { get; set; }
        public virtual DbSet<tbl_Knowledgeassessmentdetails_ForUser> tbl_Knowledgeassessmentdetails_ForUser { get; set; }
        public virtual DbSet<tbl_LaunchTimes> tbl_LaunchTimes { get; set; }
        public virtual DbSet<tbl_Loanoffers> tbl_Loanoffers { get; set; }
        public virtual DbSet<tbl_LoanOffersLog> tbl_LoanOffersLog { get; set; }
        public virtual DbSet<tbl_LoanPayments> tbl_LoanPayments { get; set; }
        public virtual DbSet<tbl_LoanPurposesList> tbl_LoanPurposesList { get; set; }
        public virtual DbSet<tbl_LoanRateChangeLog> tbl_LoanRateChangeLog { get; set; }
        public virtual DbSet<tbl_loanRequestReference> tbl_loanRequestReference { get; set; }
        public virtual DbSet<tbl_LoanRequests> tbl_LoanRequests { get; set; }
        public virtual DbSet<tbl_LoanRequestServiceFee> tbl_LoanRequestServiceFee { get; set; }
        public virtual DbSet<tbl_LoanTransactions> tbl_LoanTransactions { get; set; }
        public virtual DbSet<tbl_LogOtherLoanDocuments> tbl_LogOtherLoanDocuments { get; set; }
        public virtual DbSet<tbl_MoolahCore> tbl_MoolahCore { get; set; }
        public virtual DbSet<tbl_MoolahCoreVerification> tbl_MoolahCoreVerification { get; set; }
        public virtual DbSet<tbl_MoolahPeri> tbl_MoolahPeri { get; set; }
        public virtual DbSet<tbl_MoolahPeriVerification> tbl_MoolahPeriVerification { get; set; }
        public virtual DbSet<tbl_MoolahPerksForLenders> tbl_MoolahPerksForLenders { get; set; }
        public virtual DbSet<tbl_NatureofBusinessList> tbl_NatureofBusinessList { get; set; }
        public virtual DbSet<tbl_NewMoolahCore> tbl_NewMoolahCore { get; set; }
        public virtual DbSet<tbl_NewMoolahCoreVerification> tbl_NewMoolahCoreVerification { get; set; }
        public virtual DbSet<tbl_OtherLoanDocuments> tbl_OtherLoanDocuments { get; set; }
        public virtual DbSet<tbl_OutStandingLitigation> tbl_OutStandingLitigation { get; set; }
        public virtual DbSet<tbl_PaidLatePayments> tbl_PaidLatePayments { get; set; }
        public virtual DbSet<tbl_Partners> tbl_Partners { get; set; }
        public virtual DbSet<tbl_PersonalGuaranteeInfo> tbl_PersonalGuaranteeInfo { get; set; }
        public virtual DbSet<tbl_PersonalGuranteeVerification> tbl_PersonalGuranteeVerification { get; set; }
        public virtual DbSet<tbl_PointAudit> tbl_PointAudit { get; set; }
        public virtual DbSet<tbl_Product> tbl_Product { get; set; }
        public virtual DbSet<tbl_ReconData> tbl_ReconData { get; set; }
        public virtual DbSet<tbl_ReconSummary> tbl_ReconSummary { get; set; }
        public virtual DbSet<tbl_RepaymentMessages> tbl_RepaymentMessages { get; set; }
        public virtual DbSet<tbl_RepaymentMessagesTemp> tbl_RepaymentMessagesTemp { get; set; }
        public virtual DbSet<tbl_SecurityQuestions> tbl_SecurityQuestions { get; set; }
        public virtual DbSet<tbl_SecurityQuestionsForUsers> tbl_SecurityQuestionsForUsers { get; set; }
        public virtual DbSet<tbl_TenureMSFees> tbl_TenureMSFees { get; set; }
        public virtual DbSet<tbl_TransactionMapping> tbl_TransactionMapping { get; set; }
        public virtual DbSet<tbl_TransactionType> tbl_TransactionType { get; set; }
        public virtual DbSet<tbl_TwoFAVerification> tbl_TwoFAVerification { get; set; }
        public virtual DbSet<tbl_UserGoToKnowSourceDetails> tbl_UserGoToKnowSourceDetails { get; set; }
        public virtual DbSet<tbl_UserPreferences> tbl_UserPreferences { get; set; }
        public virtual DbSet<tbl_Users> tbl_Users { get; set; }
        public virtual DbSet<tbl_UserVerification> tbl_UserVerification { get; set; }
        public virtual DbSet<tbl_WatchList> tbl_WatchList { get; set; }
        public virtual DbSet<tbl_WithDrawAdminNotes> tbl_WithDrawAdminNotes { get; set; }
        public virtual DbSet<tbl_WithDrawMoney> tbl_WithDrawMoney { get; set; }
        public virtual DbSet<u_Permissions> u_Permissions { get; set; }
        public virtual DbSet<u_Points> u_Points { get; set; }
        public virtual DbSet<u_PromotionCampaigns> u_PromotionCampaigns { get; set; }
        public virtual DbSet<u_Referrars> u_Referrars { get; set; }
        public virtual DbSet<u_VerificationToken> u_VerificationToken { get; set; }
        public virtual DbSet<UserAcknowledgement> UserAcknowledgements { get; set; }
        public virtual DbSet<UserEmployment> UserEmployments { get; set; }
        public virtual DbSet<UserEmploymentVerification> UserEmploymentVerifications { get; set; }
        public virtual DbSet<UserQualification> UserQualifications { get; set; }
        public virtual DbSet<UserQualificationVerification> UserQualificationVerifications { get; set; }
        public virtual DbSet<UserRepaymentMsg> UserRepaymentMsgs { get; set; }
        public virtual DbSet<AggregatedCounter> AggregatedCounters { get; set; }
        public virtual DbSet<Counter> Counters { get; set; }
        public virtual DbSet<Hash> Hashes { get; set; }
        public virtual DbSet<Job> Jobs { get; set; }
        public virtual DbSet<JobParameter> JobParameters { get; set; }
        public virtual DbSet<JobQueue> JobQueues { get; set; }
        public virtual DbSet<List> Lists { get; set; }
        public virtual DbSet<Schema> Schemata { get; set; }
        public virtual DbSet<Server> Servers { get; set; }
        public virtual DbSet<Set> Sets { get; set; }
        public virtual DbSet<State> States { get; set; }
        public virtual DbSet<ActionPermission> ActionPermissions { get; set; }
        public virtual DbSet<PermissionMenu> PermissionMenus { get; set; }
        public virtual DbSet<RolePermissionMenu> RolePermissionMenus { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<UsersRole> UsersRoles { get; set; }
        public virtual DbSet<b_tempUOBGroupBranches> b_tempUOBGroupBranches { get; set; }
        public virtual DbSet<CheckInvestorRepayment> CheckInvestorRepayments { get; set; }
        public virtual DbSet<IndustryType> IndustryTypes { get; set; }
        public virtual DbSet<tbl_AccountDetails1> tbl_AccountDetails1 { get; set; }
        public virtual DbSet<tbl_API_DPOrder> tbl_API_DPOrder { get; set; }
        public virtual DbSet<tbl_AuditRegisterOTPVerification> tbl_AuditRegisterOTPVerification { get; set; }
        public virtual DbSet<tbl_Balances_3> tbl_Balances_3 { get; set; }
        public virtual DbSet<tbl_Balances1> tbl_Balances1 { get; set; }
        public virtual DbSet<tbl_LogESignInfo> tbl_LogESignInfo { get; set; }
        public virtual DbSet<tbl_Product2> tbl_Product2 { get; set; }
        public virtual DbSet<tbl_RegisterOTPVerification> tbl_RegisterOTPVerification { get; set; }
        public virtual DbSet<tbl_RepaymentMessages1> tbl_RepaymentMessages1 { get; set; }
        public virtual DbSet<tbl_RiskAdjustedOfReturn> tbl_RiskAdjustedOfReturn { get; set; }
        public virtual DbSet<tbl_tempBalances> tbl_tempBalances { get; set; }
        public virtual DbSet<tbl_tempLateIssuerRepayment> tbl_tempLateIssuerRepayment { get; set; }
        public virtual DbSet<tbl_tempLoanTransactions> tbl_tempLoanTransactions { get; set; }
        public virtual DbSet<tbl_UserTest> tbl_UserTest { get; set; }
        public virtual DbSet<tempInvestorRepayment> tempInvestorRepayments { get; set; }
        public virtual DbSet<tempScheduledRepayment1> tempScheduledRepayment1 { get; set; }
        public virtual DbSet<u_ReferrarsTest> u_ReferrarsTest { get; set; }
        public virtual DbSet<vw_aspnet_MembershipUsers> vw_aspnet_MembershipUsers { get; set; }
        public virtual DbSet<vw_aspnet_Profiles> vw_aspnet_Profiles { get; set; }
        public virtual DbSet<vw_aspnet_Roles> vw_aspnet_Roles { get; set; }
        public virtual DbSet<vw_aspnet_Users> vw_aspnet_Users { get; set; }
        public virtual DbSet<vw_aspnet_UsersInRoles> vw_aspnet_UsersInRoles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AAContract>()
                .Property(e => e.NoteTypes)
                .IsUnicode(false);

            modelBuilder.Entity<AAContract>()
                .Property(e => e.IndustryPreferences)
                .IsUnicode(false);

            modelBuilder.Entity<AAContract>()
                .Property(e => e.RewardCode)
                .IsUnicode(false);

            modelBuilder.Entity<AAContract>()
                .Property(e => e.Comments)
                .IsUnicode(false);

            modelBuilder.Entity<AAContract>()
                .HasMany(e => e.AAContractInvestments)
                .WithRequired(e => e.AAContract)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AAContract>()
                .HasMany(e => e.AAIncompleteSignUpEmails)
                .WithRequired(e => e.AAContract)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AAContract>()
                .HasMany(e => e.AAInsufficientFunds)
                .WithRequired(e => e.AAContract)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AAContract>()
                .HasMany(e => e.AAPreAllocates)
                .WithRequired(e => e.AAContract)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AAPlusCost>()
                .Property(e => e.Cost)
                .HasPrecision(5, 2);

            modelBuilder.Entity<AAPreAllocate>()
                .Property(e => e.Comments)
                .IsUnicode(false);

            modelBuilder.Entity<aspnet_Roles>()
                .HasMany(e => e.u_Permissions)
                .WithMany(e => e.aspnet_Roles)
                .Map(m => m.ToTable("u_RolePermissions").MapLeftKey("RoleId").MapRightKey("PermissionID"));

            modelBuilder.Entity<aspnet_Users>()
                .HasMany(e => e.tbl_Users)
                .WithRequired(e => e.aspnet_Users)
                .HasForeignKey(e => e.AspnetUserId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<b_UOBGroupBranches>()
                .Property(e => e.BranchName)
                .IsUnicode(false);

            modelBuilder.Entity<b_UOBGroupBranches>()
                .Property(e => e.AccountNumber)
                .IsUnicode(false);

            modelBuilder.Entity<b_UOBGroupBranches>()
                .Property(e => e.BankCode)
                .IsUnicode(false);

            modelBuilder.Entity<b_UOBGroupBranches>()
                .Property(e => e.BranchCode)
                .IsUnicode(false);

            modelBuilder.Entity<BrwInitialNoteRequest>()
                .Property(e => e.NoteAmount)
                .IsUnicode(false);

            modelBuilder.Entity<BrwInitialNoteRequest>()
                .Property(e => e.Tenure)
                .IsUnicode(false);

            modelBuilder.Entity<BrwInitialNoteRequest>()
                .Property(e => e.Purpose)
                .IsUnicode(false);

            modelBuilder.Entity<CampaignEmailAlert>()
                .Property(e => e.Comments)
                .IsUnicode(false);

            modelBuilder.Entity<CampaignEmailAlert>()
                .Property(e => e.HangFireJobID)
                .IsUnicode(false);

            modelBuilder.Entity<DropdownListCategory>()
                .Property(e => e.Category)
                .IsFixedLength();

            modelBuilder.Entity<DropdownListCategory>()
                .HasMany(e => e.DropdownLists)
                .WithRequired(e => e.DropdownListCategory)
                .HasForeignKey(e => e.Category)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EmailScheduler>()
                .Property(e => e.UserNames)
                .IsUnicode(false);

            modelBuilder.Entity<EmailScheduler>()
                .Property(e => e.EmailSubject)
                .IsUnicode(false);

            modelBuilder.Entity<EmailScheduler>()
                .Property(e => e.StatusOfLateRepayment)
                .IsUnicode(false);

            modelBuilder.Entity<EmailScheduler>()
                .Property(e => e.RescheduledRepayment)
                .IsUnicode(false);

            modelBuilder.Entity<EmailScheduler>()
                .Property(e => e.LastEmailNotification)
                .IsUnicode(false);

            modelBuilder.Entity<EmailScheduler>()
                .Property(e => e.Reason)
                .IsUnicode(false);

            modelBuilder.Entity<EmailScheduler>()
                .Property(e => e.Remarks)
                .IsUnicode(false);

            modelBuilder.Entity<EmailScheduler>()
                .Property(e => e.IssuerName)
                .IsUnicode(false);

            modelBuilder.Entity<EmailScheduler>()
                .Property(e => e.NoteType)
                .IsUnicode(false);

            modelBuilder.Entity<EmailScheduler>()
                .Property(e => e.NoteId)
                .IsUnicode(false);

            modelBuilder.Entity<EmailScheduler>()
                .Property(e => e.MailToType)
                .IsUnicode(false);

            modelBuilder.Entity<EmailScheduler>()
                .HasMany(e => e.UserRepaymentMsgs)
                .WithOptional(e => e.EmailScheduler)
                .HasForeignKey(e => e.MailId);

            modelBuilder.Entity<EmailTemplate>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<FundTransferInSlip>()
                .Property(e => e.CreditAmount)
                .HasPrecision(18, 6);

            modelBuilder.Entity<InvestorLateInterest>()
                .Property(e => e.LateInterest)
                .HasPrecision(30, 20);

            modelBuilder.Entity<InvestorRepayment>()
                .Property(e => e.Amount)
                .HasPrecision(30, 20);

            modelBuilder.Entity<InvestorRepayment>()
                .Property(e => e.LateInterest)
                .HasPrecision(30, 20);

            modelBuilder.Entity<InvestorRepayment>()
                .Property(e => e.PaidLateInterest)
                .HasPrecision(30, 20);

            modelBuilder.Entity<InvestorRepayment>()
                .Property(e => e.Balance)
                .HasPrecision(30, 20);

            modelBuilder.Entity<InvestorRepayment>()
                .Property(e => e.Interest)
                .HasPrecision(30, 20);

            modelBuilder.Entity<InvestorRepayment>()
                .Property(e => e.Principal)
                .HasPrecision(30, 20);

            modelBuilder.Entity<InvestorRepayment>()
                .Property(e => e.PaidPrincipal)
                .HasPrecision(30, 20);

            modelBuilder.Entity<InvestorRepayment>()
                .Property(e => e.PaidInterest)
                .HasPrecision(30, 20);

            modelBuilder.Entity<InvestorRepayment>()
                .Property(e => e.PaidAmount)
                .HasPrecision(30, 20);

            modelBuilder.Entity<InvestorRepayment>()
                .HasMany(e => e.InvestorLateInterests)
                .WithRequired(e => e.InvestorRepayment)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<InvestorRepaymentPayment>()
                .Property(e => e.PaidLateInterest)
                .HasPrecision(18, 6);

            modelBuilder.Entity<InvestorRepaymentPayment>()
                .Property(e => e.PaidInterest)
                .HasPrecision(18, 6);

            modelBuilder.Entity<InvestorRepaymentPayment>()
                .Property(e => e.PaidPrincipal)
                .HasPrecision(18, 6);

            modelBuilder.Entity<InvestorRepaymentPayment>()
                .HasOptional(e => e.InvestorRepaymentPayment1)
                .WithRequired(e => e.InvestorRepaymentPayment2);

            modelBuilder.Entity<IssuerLateInterest>()
                .Property(e => e.LateInterest)
                .HasPrecision(30, 20);

            modelBuilder.Entity<IssuerRepayment>()
                .Property(e => e.Amount)
                .HasPrecision(30, 20);

            modelBuilder.Entity<IssuerRepayment>()
                .Property(e => e.LateInterest)
                .HasPrecision(30, 20);

            modelBuilder.Entity<IssuerRepayment>()
                .Property(e => e.LateFees)
                .HasPrecision(30, 20);

            modelBuilder.Entity<IssuerRepayment>()
                .Property(e => e.PaidLateInterest)
                .HasPrecision(30, 20);

            modelBuilder.Entity<IssuerRepayment>()
                .Property(e => e.PaidLateFees)
                .HasPrecision(30, 20);

            modelBuilder.Entity<IssuerRepayment>()
                .Property(e => e.Balance)
                .HasPrecision(30, 20);

            modelBuilder.Entity<IssuerRepayment>()
                .Property(e => e.Interest)
                .HasPrecision(30, 20);

            modelBuilder.Entity<IssuerRepayment>()
                .Property(e => e.Principal)
                .HasPrecision(30, 20);

            modelBuilder.Entity<IssuerRepayment>()
                .Property(e => e.PaidPrincipal)
                .HasPrecision(30, 20);

            modelBuilder.Entity<IssuerRepayment>()
                .Property(e => e.PaidInterest)
                .HasPrecision(30, 20);

            modelBuilder.Entity<IssuerRepayment>()
                .Property(e => e.PaidAmount)
                .HasPrecision(30, 20);

            modelBuilder.Entity<IssuerRepayment>()
                .HasMany(e => e.InvestorRepayments)
                .WithRequired(e => e.IssuerRepayment)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IssuerRepayment>()
                .HasMany(e => e.IssuerRepaymentPayments)
                .WithRequired(e => e.IssuerRepayment)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<p_ContractTemplate>()
                .HasMany(e => e.tbl_Product)
                .WithRequired(e => e.p_ContractTemplate)
                .HasForeignKey(e => e.ContractTemplateID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Reward>()
                .Property(e => e.PromoCode)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_AccInt_ApplicationDetails>()
                .Property(e => e.Amount)
                .HasPrecision(15, 2);

            modelBuilder.Entity<tbl_AccInt_ApplicationDetails>()
                .Property(e => e.Tenor)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_AccInt_ApplicationDetails>()
                .Property(e => e.NumberOfEmployees)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_AccInt_ApplicationDetails>()
                .Property(e => e.ManagementExp)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_AccInt_ApplicationDetails>()
                .Property(e => e.InvoiceNumners)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_AccInt_RequestMaster>()
                .Property(e => e.EmailAddress)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_AccInt_RequestMaster>()
                .Property(e => e.CurrentRequestToken)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_AccInt_RequestMaster>()
                .Property(e => e.LoanAmount)
                .HasPrecision(15, 2);

            modelBuilder.Entity<tbl_AccInt_ServiceResponse>()
                .Property(e => e.Provider)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_AccInt_ServiceResponse>()
                .Property(e => e.EndPoint)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_AccInt_ServiceResponse>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_AccInt_ServiceResponse>()
                .Property(e => e.Response)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_AccInt_TokenStore>()
                .Property(e => e.TokenKey)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_AccInt_TokenStore>()
                .Property(e => e.TokenValue)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_AccInt_TokenStore>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_AccountDetails>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_AccountDetails>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_AccountDetails>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_AccountDetails>()
                .Property(e => e.DisplayName)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_AccountDetails>()
                .Property(e => e.AccountType)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_AccountDetails>()
                .Property(e => e.Nationality)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_AccountDetails>()
                .Property(e => e.Gender)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_AccountDetails>()
                .Property(e => e.ResidentialAddress)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_AccountDetails>()
                .Property(e => e.PostalCode)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_AccountDetails>()
                .Property(e => e.OptionalContactnumber)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_AccountDetails>()
                .Property(e => e.Occupation)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_AccountDetails>()
                .Property(e => e.IncomeRange)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_AccountDetails>()
                .Property(e => e.BankBranch)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_AccountDetails>()
                .Property(e => e.AccountNumber)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_AccountDetails>()
                .Property(e => e.AccountName)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_AccountDetails>()
                .Property(e => e.LevelofEducation)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_AccountDetails>()
                .Property(e => e.FinancialInvestmentProducts)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_AccountDetails>()
                .Property(e => e.MoolahConnectInvestment)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_AccountDetails>()
                .Property(e => e.ReactionOndefaulted)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_AccountDetails>()
                .Property(e => e.RoleJobTitle)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_AccountDetails>()
                .Property(e => e.BusinessName)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_AccountDetails>()
                .Property(e => e.BusinessOrganisation)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_AccountDetails>()
                .Property(e => e.RegisteredAddress)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_AccountDetails>()
                .Property(e => e.BusinessMailingAddress)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_AccountDetails>()
                .Property(e => e.Main_OfficeContactnumber)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_AccountDetails>()
                .Property(e => e.Mobilenumber)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_AccountDetails>()
                .Property(e => e.IC_CompanyRegistrationNumber)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_AccountDetails>()
                .Property(e => e.NRIC_Number)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_AccountDetails>()
                .Property(e => e.PassportNumber)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_AccountDetails>()
                .Property(e => e.SiccCode)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_AccountDetails>()
                .Property(e => e.BranchName)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_AccountDetails>()
                .Property(e => e.BranchNumber)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_AccountDetails>()
                .Property(e => e.BankNumber)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_AccountDetails>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_AccountDetails>()
                .Property(e => e.CallingCode)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_AccountDetails>()
                .Property(e => e.IdentityType)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_AccountDetails>()
                .Property(e => e.BPCallingCode)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_AccountDetails>()
                .HasOptional(e => e.BrwInitialNoteRequest)
                .WithRequired(e => e.tbl_AccountDetails);

            modelBuilder.Entity<tbl_AccountDetialsIgnoreList>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_API_ACRA_COMPANY_REGN_DATA>()
                .Property(e => e.uen)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_API_ACRA_COMPANY_REGN_DATA>()
                .Property(e => e.issuance_agency_id)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_API_ACRA_COMPANY_REGN_DATA>()
                .Property(e => e.uen_status)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_API_ACRA_COMPANY_REGN_DATA>()
                .Property(e => e.entity_name)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_API_ACRA_COMPANY_REGN_DATA>()
                .Property(e => e.entity_type)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_API_ACRA_COMPANY_REGN_DATA>()
                .Property(e => e.uen_issue_date)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_API_ACRA_COMPANY_REGN_DATA>()
                .Property(e => e.reg_street_name)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_API_ACRA_COMPANY_REGN_DATA>()
                .Property(e => e.reg_postal_code)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_API_Auditors>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_API_Bankruptcy>()
                .Property(e => e.Number)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_API_BankruptcyFIling>()
                .Property(e => e.Number)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_API_BankruptcyFIling>()
                .Property(e => e.YearNum)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_API_BankruptcyFIling>()
                .Property(e => e.Petitioner)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_API_BankruptcyFIling>()
                .Property(e => e.CaseStatus)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_API_BankruptcyFIling>()
                .Property(e => e.PartyStatus)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_API_BankruptcyFIling>()
                .Property(e => e.Amount)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_API_BankruptcyFIling>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_API_BankruptcyFIling>()
                .Property(e => e.Amounts)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_API_BusinessLitigation>()
                .Property(e => e.Number)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_API_BusinessLitigationFiling>()
                .Property(e => e.Court)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_API_BusinessLitigationFiling>()
                .Property(e => e.Number)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_API_BusinessLitigationFiling>()
                .Property(e => e.YearNum)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_API_BusinessLitigationFiling>()
                .Property(e => e.Plaintiff)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_API_BusinessLitigationFiling>()
                .Property(e => e.Remarks)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_API_BusinessLitigationFiling>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_API_BusinessLitigationFiling>()
                .Property(e => e.Amounts)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_API_CapitalStructure>()
                .Property(e => e.Currency)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_API_CapitalStructure>()
                .Property(e => e.TypeOfStructure)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_API_DPRatingMaster>()
                .Property(e => e.ReferenceNumber)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_API_DPRatingMaster>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_API_DPRatingMaster>()
                .Property(e => e.RegistrationNumber)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_API_DPRatingMaster>()
                .Property(e => e.FileIds)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_API_DPRatingMaster>()
                .Property(e => e.Rating)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_API_DPRatingMaster>()
                .Property(e => e.ObsInd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tbl_API_Filings>()
                .Property(e => e.SerialNumber)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_API_Filings>()
                .Property(e => e.Court)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_API_Filings>()
                .Property(e => e.CaseNumber)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_API_Filings>()
                .Property(e => e.Plaintiff)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_API_Filings>()
                .Property(e => e.Remarks)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_API_Filings>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_API_Filings>()
                .Property(e => e.Amounts)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_API_Guarantor>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_API_Guarantor>()
                .Property(e => e.NameDP)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_API_Guarantor>()
                .Property(e => e.IDNumber)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_API_Guarantor>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_API_IndividualLitigation>()
                .Property(e => e.Number)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_API_IndividualLitigationFiling>()
                .Property(e => e.Court)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_API_IndividualLitigationFiling>()
                .Property(e => e.Number)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_API_IndividualLitigationFiling>()
                .Property(e => e.YearNum)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_API_IndividualLitigationFiling>()
                .Property(e => e.Plaintiff)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_API_IndividualLitigationFiling>()
                .Property(e => e.Remarks)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_API_IndividualLitigationFiling>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_API_IndividualLitigationFiling>()
                .Property(e => e.Amounts)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_API_IssuerRegistration>()
                .Property(e => e.EntityName)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_API_IssuerRegistration>()
                .Property(e => e.RegistrationNumber)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_API_IssuerRegistration>()
                .Property(e => e.Country)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_API_IssuerRegistration>()
                .Property(e => e.FormerName)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_API_IssuerRegistration>()
                .Property(e => e.BusinessYears)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_API_IssuerRegistration>()
                .Property(e => e.LegalEntity)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_API_IssuerRegistration>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_API_IssuerRegistration>()
                .Property(e => e.Industry)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_API_IssuerRegistration>()
                .Property(e => e.Sector)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_API_IssuerRegistration>()
                .Property(e => e.PrincipalActivities)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_API_IssuerRegistration>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_API_IssuerRegistration>()
                .HasMany(e => e.tbl_API_Auditors)
                .WithOptional(e => e.tbl_API_IssuerRegistration)
                .HasForeignKey(e => e.IssuerID);

            modelBuilder.Entity<tbl_API_IssuerRegistration>()
                .HasMany(e => e.tbl_API_CapitalStructure)
                .WithOptional(e => e.tbl_API_IssuerRegistration)
                .HasForeignKey(e => e.IssuerID);

            modelBuilder.Entity<tbl_API_IssuerRegistration>()
                .HasMany(e => e.tbl_API_Representatives)
                .WithOptional(e => e.tbl_API_IssuerRegistration)
                .HasForeignKey(e => e.IssuerID);

            modelBuilder.Entity<tbl_API_IssuerRegistration>()
                .HasMany(e => e.tbl_API_Shareholder)
                .WithOptional(e => e.tbl_API_IssuerRegistration)
                .HasForeignKey(e => e.IssuerID);

            modelBuilder.Entity<tbl_API_IssuerRegistration>()
                .HasMany(e => e.tbl_API_WritOfSummons)
                .WithOptional(e => e.tbl_API_IssuerRegistration)
                .HasForeignKey(e => e.IssuerID);

            modelBuilder.Entity<tbl_API_Representatives>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_API_Representatives>()
                .Property(e => e.IDNumber)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_API_Representatives>()
                .Property(e => e.Nationality)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_API_Representatives>()
                .Property(e => e.Position)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_API_Representatives>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_API_Scorto_ApplicationInfo>()
                .Property(e => e.AppStatus)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_API_Scorto_ApplicationInfo>()
                .Property(e => e.RequestedAmount)
                .HasPrecision(18, 0);

            modelBuilder.Entity<tbl_API_Scorto_ApplicationInfo>()
                .Property(e => e.ApprovedAmount)
                .HasPrecision(18, 0);

            modelBuilder.Entity<tbl_API_Scorto_ApplicationInfo>()
                .Property(e => e.ApprovedProdType)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_API_Scorto_ApplicationInfo>()
                .Property(e => e.ApprovedInterestRate)
                .HasPrecision(18, 0);

            modelBuilder.Entity<tbl_API_Scorto_ApplicationInfo>()
                .Property(e => e.FlatInterestRate)
                .HasPrecision(18, 0);

            modelBuilder.Entity<tbl_API_Scorto_ApplicationInfo>()
                .Property(e => e.BDMName)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_API_Scorto_Configuration>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_API_Scorto_Configuration>()
                .Property(e => e.Value)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_API_Scorto_CreditInfo>()
                .Property(e => e.OverallScore)
                .HasPrecision(18, 0);

            modelBuilder.Entity<tbl_API_Scorto_CreditInfo>()
                .Property(e => e.FinancialScore)
                .HasPrecision(18, 0);

            modelBuilder.Entity<tbl_API_Scorto_CreditInfo>()
                .Property(e => e.NonFinancialScore)
                .HasPrecision(18, 0);

            modelBuilder.Entity<tbl_API_Scorto_IssuerInfo>()
                .Property(e => e.IssuerName)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_API_Scorto_IssuerInfo>()
                .Property(e => e.Industry)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_API_Scorto_IssuerInfo>()
                .Property(e => e.DPRating)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_API_Scorto_IssuerInfo>()
                .Property(e => e.LeadSource)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_API_Scorto_IssuerInfo>()
                .Property(e => e.PartnerName)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_API_Scorto_IssuerInfo>()
                .Property(e => e.PartnerCompanyName)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_API_Scorto_IssuerInfo>()
                .Property(e => e.PartnerCompanyType)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_API_Scorto_IssuerInfo>()
                .Property(e => e.NetSalesCurrentYear)
                .HasPrecision(18, 0);

            modelBuilder.Entity<tbl_API_Scorto_IssuerInfo>()
                .Property(e => e.NetSalesLastYear)
                .HasPrecision(18, 0);

            modelBuilder.Entity<tbl_API_Scorto_IssuerInfo>()
                .Property(e => e.OPMCurrentYear)
                .HasPrecision(18, 0);

            modelBuilder.Entity<tbl_API_Scorto_IssuerInfo>()
                .Property(e => e.OPMLastYear)
                .HasPrecision(18, 0);

            modelBuilder.Entity<tbl_API_Scorto_IssuerInfo>()
                .Property(e => e.ICRCurrentYear)
                .HasPrecision(18, 0);

            modelBuilder.Entity<tbl_API_Scorto_IssuerInfo>()
                .Property(e => e.ICRLastYear)
                .HasPrecision(18, 0);

            modelBuilder.Entity<tbl_API_Scorto_IssuerInfo>()
                .Property(e => e.DebtToEquityRatioCurrentYear)
                .HasPrecision(18, 0);

            modelBuilder.Entity<tbl_API_Scorto_IssuerInfo>()
                .Property(e => e.DebtToEquityRatioLastYear)
                .HasPrecision(18, 0);

            modelBuilder.Entity<tbl_API_Scorto_IssuerInfo>()
                .Property(e => e.ARDOHCurrentYear)
                .HasPrecision(18, 0);

            modelBuilder.Entity<tbl_API_Scorto_IssuerInfo>()
                .Property(e => e.ARDOHLastYear)
                .HasPrecision(18, 0);

            modelBuilder.Entity<tbl_API_Scorto_IssuerInfo>()
                .Property(e => e.MedianCashBalance)
                .HasPrecision(18, 0);

            modelBuilder.Entity<tbl_API_Scorto_IssuerInfo>()
                .Property(e => e.NumberOfGuarantors)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_API_Scorto_IssuerInfo>()
                .Property(e => e.UEN)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_API_SearchCount>()
                .Property(e => e.Jan)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_API_SearchCount>()
                .Property(e => e.Feb)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_API_SearchCount>()
                .Property(e => e.Mar)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_API_SearchCount>()
                .Property(e => e.Apr)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_API_SearchCount>()
                .Property(e => e.May)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_API_SearchCount>()
                .Property(e => e.Jun)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_API_SearchCount>()
                .Property(e => e.Jul)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_API_SearchCount>()
                .Property(e => e.Aug)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_API_SearchCount>()
                .Property(e => e.Sep)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_API_SearchCount>()
                .Property(e => e.Octo)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_API_SearchCount>()
                .Property(e => e.Nov)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_API_SearchCount>()
                .Property(e => e.Dece)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_API_Shareholder>()
                .Property(e => e.NumberOfShareholders)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_API_Shareholder>()
                .Property(e => e.ShareholderOptions)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_API_Shareholder>()
                .HasMany(e => e.tbl_API_ShareholderDetails)
                .WithOptional(e => e.tbl_API_Shareholder)
                .HasForeignKey(e => e.ShareholderID);

            modelBuilder.Entity<tbl_API_ShareholderDetails>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_API_ShareholderDetails>()
                .Property(e => e.IDNumber)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_API_ShareholderDetails>()
                .Property(e => e.TypeOfID)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_API_ShareholderDetails>()
                .Property(e => e.Nationality)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_API_ShareholderDetails>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_API_ShareholderDetails>()
                .Property(e => e.ShareCurrency)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_AuditTrial>()
                .HasOptional(e => e.tbl_AuditTrial1)
                .WithRequired(e => e.tbl_AuditTrial2);

            modelBuilder.Entity<tbl_AuditTwoFAVerification>()
                .Property(e => e.MobileNo)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_AuditTwoFAVerification>()
                .Property(e => e.CallingCode)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_AuditTwoFAVerification>()
                .Property(e => e.OTP)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_AuditTwoFAVerification>()
                .Property(e => e.Operation)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tbl_BanksList>()
                .Property(e => e.BankName)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_BanksList>()
                .HasMany(e => e.tbl_AccountDetails)
                .WithOptional(e => e.tbl_BanksList)
                .HasForeignKey(e => e.Bank_Id);

            modelBuilder.Entity<tbl_CampaignViewers>()
                .Property(e => e.DigitalSignature)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_CampaignViewers>()
                .Property(e => e.DepositAmount)
                .HasPrecision(18, 0);

            modelBuilder.Entity<tbl_Countries>()
                .Property(e => e.ISO2)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tbl_Countries>()
                .Property(e => e.CountryName)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_Countries>()
                .Property(e => e.LongCountryName)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_Countries>()
                .Property(e => e.ISO3)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tbl_Countries>()
                .Property(e => e.NumCode)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_Countries>()
                .Property(e => e.UNMemberState)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_Countries>()
                .Property(e => e.CallingCode)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_Countries>()
                .Property(e => e.CCTLD)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_Countries>()
                .Property(e => e.CurrencyCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tbl_Countries>()
                .HasMany(e => e.tbl_AccountDetails)
                .WithOptional(e => e.tbl_Countries)
                .HasForeignKey(e => e.RegisteredCountryId);

            modelBuilder.Entity<tbl_Countries>()
                .HasMany(e => e.tbl_AccountDetails1)
                .WithOptional(e => e.tbl_Countries1)
                .HasForeignKey(e => e.BusinessMailingCountryId);

            modelBuilder.Entity<tbl_DPCreditPaymentGrade>()
                .Property(e => e.CreditRating)
                .IsFixedLength();

            modelBuilder.Entity<tbl_DPCreditPaymentGrade>()
                .Property(e => e.Range)
                .IsFixedLength();

            modelBuilder.Entity<tbl_DPCreditPaymentGrade>()
                .HasMany(e => e.tbl_MoolahCore)
                .WithOptional(e => e.tbl_DPCreditPaymentGrade)
                .HasForeignKey(e => e.DPCreditPaymentGrade);

            modelBuilder.Entity<tbl_DPCreditPaymentGrade>()
                .HasMany(e => e.tbl_NewMoolahCore)
                .WithOptional(e => e.tbl_DPCreditPaymentGrade)
                .HasForeignKey(e => e.DPCreditPaymentGrade);

            modelBuilder.Entity<tbl_ESignInfo>()
                .Property(e => e.ContractType)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_ESignInfo>()
                .Property(e => e.DocumentID)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_ESignInfo>()
                .Property(e => e.DocumentName)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_ESignInfo>()
                .Property(e => e.SignerEmail)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_ESignInfo>()
                .Property(e => e.FileStatus)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_ESignInfo>()
                .Property(e => e.AdminStatus)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_ESignInfo>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_ESignInfo>()
                .Property(e => e.Comment)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_ESignInfo>()
                .Property(e => e.Subject)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_ESignInfo>()
                .Property(e => e.SignURL)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_ESignInfo>()
                .Property(e => e.TinyURL)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_ESignInfo>()
                .Property(e => e.LastUpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_Files>()
                .HasMany(e => e.FundTransferInSlips)
                .WithRequired(e => e.tbl_Files)
                .HasForeignKey(e => e.TransferFileId);

            modelBuilder.Entity<tbl_Files>()
                .HasMany(e => e.tbl_ESignInfo)
                .WithOptional(e => e.tbl_Files)
                .HasForeignKey(e => e.FileID);

            modelBuilder.Entity<tbl_Files>()
                .HasMany(e => e.tbl_LogESignInfo)
                .WithOptional(e => e.tbl_Files)
                .HasForeignKey(e => e.FileID);

            modelBuilder.Entity<tbl_Files>()
                .HasMany(e => e.tbl_OtherLoanDocuments)
                .WithOptional(e => e.tbl_Files)
                .HasForeignKey(e => e.FileID);

            modelBuilder.Entity<tbl_FundTransferIN_Raw>()
                .Property(e => e.AccountNo)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_FundTransferIN_Raw>()
                .Property(e => e.Cur)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_FundTransferIN_Raw>()
                .Property(e => e.TransactionTypeCode)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_FundTransferIN_Raw>()
                .Property(e => e.SupplementaryDetails)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_FundTransferIN_Raw>()
                .Property(e => e.StatementDetails)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_FundTransferIN_Raw>()
                .Property(e => e.OurRef)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_FundTransferIN_Raw>()
                .Property(e => e.AdditionalDetails)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_FundTransferIN_Staging>()
                .Property(e => e.AccountNo)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_FundTransferIN_Staging>()
                .Property(e => e.Cur)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_FundTransferIN_Staging>()
                .Property(e => e.TransactionTypeCode)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_FundTransferIN_Staging>()
                .Property(e => e.SupplementaryDetails)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_FundTransferIN_Staging>()
                .Property(e => e.StatementDetails)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_FundTransferIN_Staging>()
                .Property(e => e.OurRef)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_FundTransferIN_Staging>()
                .Property(e => e.AdditionalDetails)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_FundTransferRef>()
                .Property(e => e.AccountNo)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_FundTransferRef>()
                .Property(e => e.Cur)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_FundTransferRef>()
                .Property(e => e.TransactionTypeCode)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_FundTransferRef>()
                .Property(e => e.SupplementaryDetails)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_FundTransferRef>()
                .Property(e => e.StatementDetails)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_FundTransferRef>()
                .Property(e => e.OurRef)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_FundTransferRef>()
                .Property(e => e.AdditionalDetails)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_GoToKnowSource>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_GoToKnowSource>()
                .HasMany(e => e.tbl_UserGoToKnowSourceDetails)
                .WithOptional(e => e.tbl_GoToKnowSource)
                .HasForeignKey(e => e.GoToKnowSourceId);

            modelBuilder.Entity<tbl_Group>()
                .HasMany(e => e.tbl_GroupLoanRequests)
                .WithRequired(e => e.tbl_Group)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_Group>()
                .HasMany(e => e.tbl_GroupProduct)
                .WithRequired(e => e.tbl_Group)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_Group>()
                .HasMany(e => e.tbl_GroupUsers)
                .WithRequired(e => e.tbl_Group)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_Group>()
                .HasMany(e => e.tbl_Investor_Announcement_Groups)
                .WithRequired(e => e.tbl_Group)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_Investor_Announcements>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_Investor_Announcements>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_Investor_Announcements>()
                .HasMany(e => e.tbl_Investor_Announcement_Groups)
                .WithRequired(e => e.tbl_Investor_Announcements)
                .HasForeignKey(e => e.AnnouncementId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_InvestorReferees>()
                .Property(e => e.FriendEmail)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_InvestorServicingFeeType>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_Knowledgeassessment_OptionsList>()
                .Property(e => e.Optiontext)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_Knowledgeassessment_OptionsList>()
                .Property(e => e.Optiontype)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_Knowledgeassessment_OptionsList>()
                .Property(e => e.url)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_Knowledgeassessment_Parentlist>()
                .Property(e => e.Parenttext)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_Knowledgeassessment_Parentlist>()
                .Property(e => e.InvType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tbl_Knowledgeassessment_Parentlist>()
                .HasMany(e => e.tbl_Knowledgeassessment_OptionsList)
                .WithOptional(e => e.tbl_Knowledgeassessment_Parentlist)
                .HasForeignKey(e => e.Parent_Id);

            modelBuilder.Entity<tbl_Knowledgeassessmentdetails_ForUser>()
                .Property(e => e.Option_Value)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_Loanoffers>()
                .Property(e => e.ReasonToReject)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_Loanoffers>()
                .HasMany(e => e.InvestorRepayments)
                .WithRequired(e => e.tbl_Loanoffers)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_LoanOffersLog>()
                .Property(e => e.Reason)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_LoanPayments>()
                .HasMany(e => e.InvestorRepaymentPayments)
                .WithRequired(e => e.tbl_LoanPayments)
                .HasForeignKey(e => e.PaymentID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_LoanPayments>()
                .HasMany(e => e.IssuerRepaymentPayments)
                .WithRequired(e => e.tbl_LoanPayments)
                .HasForeignKey(e => e.IssuerPayID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_LoanPayments>()
                .HasMany(e => e.tbl_AccountAdjustment)
                .WithOptional(e => e.tbl_LoanPayments)
                .HasForeignKey(e => e.PaymentID);

            modelBuilder.Entity<tbl_LoanPurposesList>()
                .Property(e => e.PurposeName)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_LoanPurposesList>()
                .HasMany(e => e.tbl_LoanRequests)
                .WithOptional(e => e.tbl_LoanPurposesList)
                .HasForeignKey(e => e.LoanPurpose_Id);

            modelBuilder.Entity<tbl_LoanRequests>()
                .Property(e => e.Tenure)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_LoanRequests>()
                .Property(e => e.Question)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_LoanRequests>()
                .Property(e => e.MoolahSenseComments)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_LoanRequests>()
                .Property(e => e.ResonReject)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_LoanRequests>()
                .Property(e => e.Headline)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_LoanRequests>()
                .Property(e => e.DefaultCmnt)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_LoanRequests>()
                .Property(e => e.AppID)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_LoanRequests>()
                .HasMany(e => e.AAContractInvestments)
                .WithRequired(e => e.tbl_LoanRequests)
                .HasForeignKey(e => e.NoteId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_LoanRequests>()
                .HasMany(e => e.AAPreAllocates)
                .WithRequired(e => e.tbl_LoanRequests)
                .HasForeignKey(e => e.NoteId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_LoanRequests>()
                .HasMany(e => e.CampaignEmailAlerts)
                .WithRequired(e => e.tbl_LoanRequests)
                .HasForeignKey(e => e.NoteID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_LoanRequests>()
                .HasMany(e => e.IssuerRepayments)
                .WithRequired(e => e.tbl_LoanRequests)
                .HasForeignKey(e => e.LoanRequestID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_LoanRequests>()
                .HasMany(e => e.tbl_CampaignViewers)
                .WithRequired(e => e.tbl_LoanRequests)
                .HasForeignKey(e => e.NoteId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_LoanRequests>()
                .HasMany(e => e.tbl_Comments)
                .WithOptional(e => e.tbl_LoanRequests)
                .HasForeignKey(e => e.Request_Id);

            modelBuilder.Entity<tbl_LoanRequests>()
                .HasMany(e => e.tbl_GroupLoanRequests)
                .WithRequired(e => e.tbl_LoanRequests)
                .HasForeignKey(e => e.LoanRequestID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_LoanRequests>()
                .HasMany(e => e.tbl_InvoiceFinanceProductDetails)
                .WithRequired(e => e.tbl_LoanRequests)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_LoanRequests>()
                .HasMany(e => e.tbl_Loanoffers)
                .WithRequired(e => e.tbl_LoanRequests)
                .HasForeignKey(e => e.LoanRequest_Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_LoanRequests>()
                .HasMany(e => e.tbl_MoolahCore)
                .WithOptional(e => e.tbl_LoanRequests)
                .HasForeignKey(e => e.LoanRequest_Id);

            modelBuilder.Entity<tbl_LoanRequests>()
                .HasMany(e => e.tbl_NewMoolahCore)
                .WithOptional(e => e.tbl_LoanRequests)
                .HasForeignKey(e => e.LoanRequest_Id);

            modelBuilder.Entity<tbl_LoanRequests>()
                .HasMany(e => e.tbl_LoanTransactions)
                .WithOptional(e => e.tbl_LoanRequests)
                .HasForeignKey(e => e.Request_Id);

            modelBuilder.Entity<tbl_LoanRequests>()
                .HasMany(e => e.tbl_MoolahCoreVerification)
                .WithOptional(e => e.tbl_LoanRequests)
                .HasForeignKey(e => e.Request_ID);

            modelBuilder.Entity<tbl_LoanRequests>()
                .HasMany(e => e.tbl_MoolahPeri)
                .WithOptional(e => e.tbl_LoanRequests)
                .HasForeignKey(e => e.Request_ID);

            modelBuilder.Entity<tbl_LoanRequests>()
                .HasMany(e => e.tbl_MoolahPeriVerification)
                .WithOptional(e => e.tbl_LoanRequests)
                .HasForeignKey(e => e.Request_ID);

            modelBuilder.Entity<tbl_LoanRequests>()
                .HasMany(e => e.tbl_NewMoolahCoreVerification)
                .WithOptional(e => e.tbl_LoanRequests)
                .HasForeignKey(e => e.Request_ID);

            modelBuilder.Entity<tbl_LoanRequests>()
                .HasMany(e => e.tbl_PaidLatePayments)
                .WithRequired(e => e.tbl_LoanRequests)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_LoanRequests>()
                .HasMany(e => e.tbl_PersonalGuaranteeInfo)
                .WithOptional(e => e.tbl_LoanRequests)
                .HasForeignKey(e => e.Request_Id);

            modelBuilder.Entity<tbl_LoanRequests>()
                .HasMany(e => e.tbl_RepaymentMessages)
                .WithOptional(e => e.tbl_LoanRequests)
                .HasForeignKey(e => e.LoanRequestId);

            modelBuilder.Entity<tbl_LoanRequests>()
                .HasMany(e => e.tbl_WatchList)
                .WithOptional(e => e.tbl_LoanRequests)
                .HasForeignKey(e => e.Request_ID);

            modelBuilder.Entity<tbl_LoanTransactions>()
                .Property(e => e.PaymentTerms)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_LoanTransactions>()
                .Property(e => e.PaymentMode)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_LogOtherLoanDocuments>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_LogOtherLoanDocuments>()
                .Property(e => e.Comments)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_LogOtherLoanDocuments>()
                .Property(e => e.LastUpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_LogOtherLoanDocuments>()
                .Property(e => e.Operation)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_MoolahCore>()
                .Property(e => e.LatestYear)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_MoolahCore>()
                .Property(e => e.PreiviousYear)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_MoolahCore>()
                .HasMany(e => e.tbl_OutStandingLitigation)
                .WithOptional(e => e.tbl_MoolahCore)
                .HasForeignKey(e => e.MoolahCore_Id);

            modelBuilder.Entity<tbl_MoolahPerksForLenders>()
                .Property(e => e.MoolahPerk)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_NatureofBusinessList>()
                .Property(e => e.NatureofBusinessName)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_NatureofBusinessList>()
                .HasMany(e => e.tbl_AccountDetails)
                .WithOptional(e => e.tbl_NatureofBusinessList)
                .HasForeignKey(e => e.Natureofbusiness_Id);

            modelBuilder.Entity<tbl_OtherLoanDocuments>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_OtherLoanDocuments>()
                .Property(e => e.Comments)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_OtherLoanDocuments>()
                .Property(e => e.LastUpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_OutStandingLitigation>()
                .Property(e => e.RepaymentPeriod)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_OutStandingLitigation>()
                .Property(e => e.LitigationType)
                .IsFixedLength();

            modelBuilder.Entity<tbl_Partners>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_Partners>()
                .HasMany(e => e.tbl_AccountDetails)
                .WithOptional(e => e.tbl_Partners)
                .HasForeignKey(e => e.PartnerId);

            modelBuilder.Entity<tbl_PersonalGuaranteeInfo>()
                .Property(e => e.NameAsinNRIC)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_PersonalGuaranteeInfo>()
                .Property(e => e.Designation)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_PersonalGuaranteeInfo>()
                .Property(e => e.NRIC_Passport)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_PersonalGuaranteeInfo>()
                .Property(e => e.PassportNumber)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_PersonalGuaranteeInfo>()
                .Property(e => e.ResidentialAddress)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_PersonalGuaranteeInfo>()
                .Property(e => e.Telephone)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_PersonalGuaranteeInfo>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_PersonalGuaranteeInfo>()
                .Property(e => e.Postalcode)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_PersonalGuaranteeInfo>()
                .Property(e => e.GuarantorType)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_PersonalGuranteeVerification>()
                .Property(e => e.NameAsinNRICVerification)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_PersonalGuranteeVerification>()
                .Property(e => e.DesignationVerification)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_PersonalGuranteeVerification>()
                .Property(e => e.NRIC_PassportVerification)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_PersonalGuranteeVerification>()
                .Property(e => e.PassportNumber)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_PersonalGuranteeVerification>()
                .Property(e => e.ResidentialAddressVerification)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_PersonalGuranteeVerification>()
                .Property(e => e.TelephoneVerification)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_PersonalGuranteeVerification>()
                .Property(e => e.EmailVerification)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_PersonalGuranteeVerification>()
                .Property(e => e.ReasonsVerification)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_PersonalGuranteeVerification>()
                .Property(e => e.PostalcodeVerification)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_Product>()
                .HasMany(e => e.tbl_GroupProduct)
                .WithRequired(e => e.tbl_Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_ReconData>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_RepaymentMessages>()
                .Property(e => e.Message)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_RepaymentMessages>()
                .Property(e => e.SendToType)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_RepaymentMessages>()
                .Property(e => e.CustomUserNames)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_RepaymentMessages>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_RepaymentMessages>()
                .HasMany(e => e.UserRepaymentMsgs)
                .WithOptional(e => e.tbl_RepaymentMessages)
                .HasForeignKey(e => e.MsgId);

            modelBuilder.Entity<tbl_RepaymentMessagesTemp>()
                .Property(e => e.Message)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_RepaymentMessagesTemp>()
                .Property(e => e.SendToType)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_RepaymentMessagesTemp>()
                .Property(e => e.CustomUserNames)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_RepaymentMessagesTemp>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_SecurityQuestions>()
                .Property(e => e.QuestionName)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_SecurityQuestionsForUsers>()
                .Property(e => e.Answer)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_SecurityQuestionsForUsers>()
                .Property(e => e.IsVerified)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_TenureMSFees>()
                .Property(e => e.MSFeesPrecentage)
                .HasPrecision(9, 3);

            modelBuilder.Entity<tbl_TenureMSFees>()
                .Property(e => e.MinAmount)
                .HasPrecision(9, 2);

            modelBuilder.Entity<tbl_TransactionMapping>()
                .Property(e => e.Criteria)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_TransactionType>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_TransactionType>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_TwoFAVerification>()
                .Property(e => e.MobileNo)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_TwoFAVerification>()
                .Property(e => e.CallingCode)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_TwoFAVerification>()
                .Property(e => e.OTP)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_UserGoToKnowSourceDetails>()
                .Property(e => e.ReferralName)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_UserGoToKnowSourceDetails>()
                .Property(e => e.ReferralEmail)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_UserGoToKnowSourceDetails>()
                .Property(e => e.Other)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_UserGoToKnowSourceDetails>()
                .HasMany(e => e.tbl_Users)
                .WithOptional(e => e.tbl_UserGoToKnowSourceDetails)
                .HasForeignKey(e => e.UserGoToKnowSourceDetailsId);

            modelBuilder.Entity<tbl_UserPreferences>()
                .Property(e => e.PreferenceType)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_Users>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_Users>()
                .Property(e => e.UserRole)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_Users>()
                .Property(e => e.InvestorType)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_Users>()
                .Property(e => e.AdminVerification)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_Users>()
                .Property(e => e.Remarks)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_Users>()
                .HasMany(e => e.AAContracts)
                .WithRequired(e => e.tbl_Users)
                .HasForeignKey(e => e.InvestorId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_Users>()
                .HasMany(e => e.FundTransferInSlips)
                .WithRequired(e => e.tbl_Users)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_Users>()
                .HasOptional(e => e.tbl_AccountDetails)
                .WithRequired(e => e.tbl_Users);

            modelBuilder.Entity<tbl_Users>()
                .HasMany(e => e.tbl_AuditTwoFAVerification)
                .WithRequired(e => e.tbl_Users)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_Users>()
                .HasMany(e => e.tbl_Balances)
                .WithOptional(e => e.tbl_Users)
                .HasForeignKey(e => e.User_ID);

            modelBuilder.Entity<tbl_Users>()
                .HasMany(e => e.tbl_CampaignViewers)
                .WithRequired(e => e.tbl_Users)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_Users>()
                .HasMany(e => e.tbl_Comments)
                .WithOptional(e => e.tbl_Users)
                .HasForeignKey(e => e.Commentor_Id);

            modelBuilder.Entity<tbl_Users>()
                .HasMany(e => e.tbl_GroupUsers)
                .WithRequired(e => e.tbl_Users)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_Users>()
                .HasMany(e => e.tbl_Knowledgeassessmentdetails_ForUser)
                .WithOptional(e => e.tbl_Users)
                .HasForeignKey(e => e.User_ID);

            modelBuilder.Entity<tbl_Users>()
                .HasMany(e => e.tbl_Loanoffers)
                .WithRequired(e => e.tbl_Users)
                .HasForeignKey(e => e.Investor_Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_Users>()
                .HasMany(e => e.tbl_LoanRequests)
                .WithOptional(e => e.tbl_Users)
                .HasForeignKey(e => e.User_ID);

            modelBuilder.Entity<tbl_Users>()
                .HasMany(e => e.tbl_LoanTransactions)
                .WithOptional(e => e.tbl_Users)
                .HasForeignKey(e => e.User_ID);

            modelBuilder.Entity<tbl_Users>()
                .HasMany(e => e.tbl_LoanTransactions1)
                .WithOptional(e => e.tbl_Users1)
                .HasForeignKey(e => e.RefUserID);

            modelBuilder.Entity<tbl_Users>()
                .HasMany(e => e.tbl_MoolahCore)
                .WithOptional(e => e.tbl_Users)
                .HasForeignKey(e => e.User_ID);

            modelBuilder.Entity<tbl_Users>()
                .HasMany(e => e.tbl_MoolahPeri)
                .WithOptional(e => e.tbl_Users)
                .HasForeignKey(e => e.User_ID);

            modelBuilder.Entity<tbl_Users>()
                .HasMany(e => e.tbl_NewMoolahCore)
                .WithOptional(e => e.tbl_Users)
                .HasForeignKey(e => e.User_ID);

            modelBuilder.Entity<tbl_Users>()
                .HasMany(e => e.tbl_OutStandingLitigation)
                .WithOptional(e => e.tbl_Users)
                .HasForeignKey(e => e.User_ID);

            modelBuilder.Entity<tbl_Users>()
                .HasMany(e => e.tbl_PointAudit)
                .WithRequired(e => e.tbl_Users)
                .HasForeignKey(e => e.ReferrerID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_Users>()
                .HasMany(e => e.tbl_PointAudit1)
                .WithRequired(e => e.tbl_Users1)
                .HasForeignKey(e => e.ReferreeID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_Users>()
                .HasMany(e => e.tbl_SecurityQuestionsForUsers)
                .WithOptional(e => e.tbl_Users)
                .HasForeignKey(e => e.User_ID);

            modelBuilder.Entity<tbl_Users>()
                .HasMany(e => e.tbl_TwoFAVerification)
                .WithRequired(e => e.tbl_Users)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_Users>()
                .HasMany(e => e.tbl_UserPreferences)
                .WithRequired(e => e.tbl_Users)
                .HasForeignKey(e => e.User_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_Users>()
                .HasMany(e => e.tbl_WithDrawMoney)
                .WithOptional(e => e.tbl_Users)
                .HasForeignKey(e => e.User_ID);

            modelBuilder.Entity<tbl_Users>()
                .HasMany(e => e.u_Referrars1)
                .WithRequired(e => e.tbl_Users1)
                .HasForeignKey(e => e.UserID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_Users>()
                .HasOptional(e => e.UserAcknowledgement)
                .WithRequired(e => e.tbl_Users);

            modelBuilder.Entity<tbl_Users>()
                .HasOptional(e => e.UserEmployment)
                .WithRequired(e => e.tbl_Users);

            modelBuilder.Entity<tbl_Users>()
                .HasOptional(e => e.UserQualification)
                .WithRequired(e => e.tbl_Users);

            modelBuilder.Entity<tbl_Users>()
                .HasOptional(e => e.UserQualificationVerification)
                .WithRequired(e => e.tbl_Users);

            modelBuilder.Entity<tbl_Users>()
                .HasMany(e => e.UsersRoles)
                .WithRequired(e => e.tbl_Users)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_UserVerification>()
                .Property(e => e.TitleVerification)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_UserVerification>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_UserVerification>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_UserVerification>()
                .Property(e => e.DisplayName)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_UserVerification>()
                .Property(e => e.RoleOrJobTitle)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_UserVerification>()
                .Property(e => e.BussinessName)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_UserVerification>()
                .Property(e => e.BussinessRegistrationNumber)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_UserVerification>()
                .Property(e => e.BussinessOrganisation)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_UserVerification>()
                .Property(e => e.NatureofBussiness)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_UserVerification>()
                .Property(e => e.DateofIncorporation)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_UserVerification>()
                .Property(e => e.RegisteredAddress)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_UserVerification>()
                .Property(e => e.BussinessMailingAddress)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_UserVerification>()
                .Property(e => e.DirectLine)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_UserVerification>()
                .Property(e => e.Mobile)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_UserVerification>()
                .Property(e => e.OptinalContact)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_UserVerification>()
                .Property(e => e.Bank)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_UserVerification>()
                .Property(e => e.BankAccountNumber)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_UserVerification>()
                .Property(e => e.BankAccountName)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_UserVerification>()
                .Property(e => e.PaidUpCapital)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_UserVerification>()
                .Property(e => e.NumOfEmployees)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_UserVerification>()
                .Property(e => e.NricNumber)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_UserVerification>()
                .Property(e => e.PassportNumber)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_UserVerification>()
                .Property(e => e.SiccCode)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_UserVerification>()
                .Property(e => e.BranchName)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_UserVerification>()
                .Property(e => e.BranchNumber)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_UserVerification>()
                .Property(e => e.BankNumber)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_UserVerification>()
                .Property(e => e.Country)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_UserVerification>()
                .Property(e => e.Fullname)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_WithDrawMoney>()
                .Property(e => e.WithDrawAmount)
                .HasPrecision(16, 2);

            modelBuilder.Entity<tbl_WithDrawMoney>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_WithDrawMoney>()
                .HasMany(e => e.tbl_WithDrawAdminNotes)
                .WithRequired(e => e.tbl_WithDrawMoney)
                .HasForeignKey(e => e.WithDraw_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<u_Permissions>()
                .Property(e => e.PermissionName)
                .IsUnicode(false);

            modelBuilder.Entity<u_PromotionCampaigns>()
                .HasMany(e => e.tbl_PointAudit)
                .WithOptional(e => e.u_PromotionCampaigns)
                .HasForeignKey(e => e.PromotionID);

            modelBuilder.Entity<u_PromotionCampaigns>()
                .HasMany(e => e.u_Referrars)
                .WithRequired(e => e.u_PromotionCampaigns)
                .HasForeignKey(e => e.PromotionID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<u_Referrars>()
                .HasMany(e => e.tbl_Users)
                .WithOptional(e => e.u_Referrars)
                .HasForeignKey(e => e.ReferrarID);

            modelBuilder.Entity<UserEmployment>()
                .HasOptional(e => e.UserEmploymentVerification)
                .WithRequired(e => e.UserEmployment);

            modelBuilder.Entity<ActionPermission>()
                .Property(e => e.UniqueMethodName)
                .IsUnicode(false);

            modelBuilder.Entity<ActionPermission>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<PermissionMenu>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<PermissionMenu>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<PermissionMenu>()
                .Property(e => e.UIAttrName)
                .IsUnicode(false);

            modelBuilder.Entity<PermissionMenu>()
                .HasMany(e => e.ActionPermissions)
                .WithRequired(e => e.PermissionMenu)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PermissionMenu>()
                .HasMany(e => e.PermissionMenus1)
                .WithOptional(e => e.PermissionMenu1)
                .HasForeignKey(e => e.ParentId);

            modelBuilder.Entity<PermissionMenu>()
                .HasMany(e => e.RolePermissionMenus)
                .WithRequired(e => e.PermissionMenu)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Role>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Role>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Role>()
                .HasMany(e => e.RolePermissionMenus)
                .WithRequired(e => e.Role)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Role>()
                .HasMany(e => e.UsersRoles)
                .WithRequired(e => e.Role)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<b_tempUOBGroupBranches>()
                .Property(e => e.BranchName)
                .IsUnicode(false);

            modelBuilder.Entity<b_tempUOBGroupBranches>()
                .Property(e => e.AccountNumber)
                .IsUnicode(false);

            modelBuilder.Entity<b_tempUOBGroupBranches>()
                .Property(e => e.BankCode)
                .IsUnicode(false);

            modelBuilder.Entity<b_tempUOBGroupBranches>()
                .Property(e => e.BranchCode)
                .IsUnicode(false);

            modelBuilder.Entity<CheckInvestorRepayment>()
                .Property(e => e.Amount)
                .HasPrecision(30, 20);

            modelBuilder.Entity<CheckInvestorRepayment>()
                .Property(e => e.LateInterest)
                .HasPrecision(30, 20);

            modelBuilder.Entity<CheckInvestorRepayment>()
                .Property(e => e.PaidLateInterest)
                .HasPrecision(30, 20);

            modelBuilder.Entity<CheckInvestorRepayment>()
                .Property(e => e.Balance)
                .HasPrecision(30, 20);

            modelBuilder.Entity<CheckInvestorRepayment>()
                .Property(e => e.Interest)
                .HasPrecision(30, 20);

            modelBuilder.Entity<CheckInvestorRepayment>()
                .Property(e => e.Principal)
                .HasPrecision(30, 20);

            modelBuilder.Entity<CheckInvestorRepayment>()
                .Property(e => e.PaidPrincipal)
                .HasPrecision(30, 20);

            modelBuilder.Entity<CheckInvestorRepayment>()
                .Property(e => e.PaidInterest)
                .HasPrecision(30, 20);

            modelBuilder.Entity<CheckInvestorRepayment>()
                .Property(e => e.PaidAmount)
                .HasPrecision(30, 20);

            modelBuilder.Entity<IndustryType>()
                .Property(e => e.IndustryName)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_AccountDetails1>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_AccountDetails1>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_AccountDetails1>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_AccountDetails1>()
                .Property(e => e.DisplayName)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_AccountDetails1>()
                .Property(e => e.AccountType)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_AccountDetails1>()
                .Property(e => e.Nationality)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_AccountDetails1>()
                .Property(e => e.Gender)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_AccountDetails1>()
                .Property(e => e.ResidentialAddress)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_AccountDetails1>()
                .Property(e => e.PostalCode)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_AccountDetails1>()
                .Property(e => e.OptionalContactnumber)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_AccountDetails1>()
                .Property(e => e.Occupation)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_AccountDetails1>()
                .Property(e => e.IncomeRange)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_AccountDetails1>()
                .Property(e => e.BankBranch)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_AccountDetails1>()
                .Property(e => e.AccountNumber)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_AccountDetails1>()
                .Property(e => e.AccountName)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_AccountDetails1>()
                .Property(e => e.LevelofEducation)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_AccountDetails1>()
                .Property(e => e.FinancialInvestmentProducts)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_AccountDetails1>()
                .Property(e => e.MoolahConnectInvestment)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_AccountDetails1>()
                .Property(e => e.ReactionOndefaulted)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_AccountDetails1>()
                .Property(e => e.RoleJobTitle)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_AccountDetails1>()
                .Property(e => e.BusinessName)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_AccountDetails1>()
                .Property(e => e.BusinessOrganisation)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_AccountDetails1>()
                .Property(e => e.RegisteredAddress)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_AccountDetails1>()
                .Property(e => e.BusinessMailingAddress)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_AccountDetails1>()
                .Property(e => e.Main_OfficeContactnumber)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_AccountDetails1>()
                .Property(e => e.Mobilenumber)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_AccountDetails1>()
                .Property(e => e.IC_CompanyRegistrationNumber)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_AccountDetails1>()
                .Property(e => e.NRIC_Number)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_AccountDetails1>()
                .Property(e => e.PassportNumber)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_AccountDetails1>()
                .Property(e => e.SiccCode)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_AccountDetails1>()
                .Property(e => e.BranchName)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_AccountDetails1>()
                .Property(e => e.BranchNumber)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_AccountDetails1>()
                .Property(e => e.BankNumber)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_AccountDetails1>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_AccountDetails1>()
                .Property(e => e.CallingCode)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_AccountDetails1>()
                .Property(e => e.IdentityType)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_AccountDetails1>()
                .Property(e => e.BPCallingCode)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_API_DPOrder>()
                .Property(e => e.ReferenceNumber)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_API_DPOrder>()
                .Property(e => e.OrderNo)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_AuditRegisterOTPVerification>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_AuditRegisterOTPVerification>()
                .Property(e => e.MobileNo)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_AuditRegisterOTPVerification>()
                .Property(e => e.CallingCode)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_AuditRegisterOTPVerification>()
                .Property(e => e.OTP)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_AuditRegisterOTPVerification>()
                .Property(e => e.Operation)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tbl_LogESignInfo>()
                .Property(e => e.ContractType)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_LogESignInfo>()
                .Property(e => e.DocumentID)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_LogESignInfo>()
                .Property(e => e.DocumentName)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_LogESignInfo>()
                .Property(e => e.SignerEmail)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_LogESignInfo>()
                .Property(e => e.FileStatus)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_LogESignInfo>()
                .Property(e => e.AdminStatus)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_LogESignInfo>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_LogESignInfo>()
                .Property(e => e.Comment)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_LogESignInfo>()
                .Property(e => e.Subject)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_LogESignInfo>()
                .Property(e => e.SignURL)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_LogESignInfo>()
                .Property(e => e.TinyURL)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_LogESignInfo>()
                .Property(e => e.LastUpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_LogESignInfo>()
                .Property(e => e.Operation)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_RegisterOTPVerification>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_RegisterOTPVerification>()
                .Property(e => e.MobileNo)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_RegisterOTPVerification>()
                .Property(e => e.CallingCode)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_RegisterOTPVerification>()
                .Property(e => e.OTP)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_RepaymentMessages1>()
                .Property(e => e.Message)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_RepaymentMessages1>()
                .Property(e => e.SendToType)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_RepaymentMessages1>()
                .Property(e => e.CustomUserNames)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_RepaymentMessages1>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_RiskAdjustedOfReturn>()
                .Property(e => e.RAROC)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_RiskAdjustedOfReturn>()
                .Property(e => e.INVESTOR_OUTSTANDING_DUE)
                .HasPrecision(38, 6);

            modelBuilder.Entity<tbl_RiskAdjustedOfReturn>()
                .Property(e => e.INVESTOR_LOANAMOUNT)
                .HasPrecision(38, 2);

            modelBuilder.Entity<tbl_tempLoanTransactions>()
                .Property(e => e.PaymentTerms)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_tempLoanTransactions>()
                .Property(e => e.PaymentMode)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_UserTest>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_UserTest>()
                .Property(e => e.UserRole)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_UserTest>()
                .Property(e => e.InvestorType)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_UserTest>()
                .Property(e => e.AdminVerification)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_UserTest>()
                .Property(e => e.Remarks)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_UserTest>()
                .Property(e => e.ReferrarCode)
                .IsUnicode(false);

            modelBuilder.Entity<tempInvestorRepayment>()
                .Property(e => e.Amount)
                .HasPrecision(30, 20);

            modelBuilder.Entity<tempInvestorRepayment>()
                .Property(e => e.LateInterest)
                .HasPrecision(30, 20);

            modelBuilder.Entity<tempInvestorRepayment>()
                .Property(e => e.PaidLateInterest)
                .HasPrecision(30, 20);

            modelBuilder.Entity<tempInvestorRepayment>()
                .Property(e => e.Balance)
                .HasPrecision(30, 20);

            modelBuilder.Entity<tempInvestorRepayment>()
                .Property(e => e.Interest)
                .HasPrecision(30, 20);

            modelBuilder.Entity<tempInvestorRepayment>()
                .Property(e => e.Principal)
                .HasPrecision(30, 20);

            modelBuilder.Entity<tempInvestorRepayment>()
                .Property(e => e.PaidPrincipal)
                .HasPrecision(30, 20);

            modelBuilder.Entity<tempInvestorRepayment>()
                .Property(e => e.PaidInterest)
                .HasPrecision(30, 20);

            modelBuilder.Entity<tempInvestorRepayment>()
                .Property(e => e.PaidAmount)
                .HasPrecision(30, 20);

            modelBuilder.Entity<tempScheduledRepayment1>()
                .Property(e => e.Amount)
                .HasPrecision(30, 20);
        }
    }
}
