namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_AccountDetails
    {
        [StringLength(10)]
        public string Title { get; set; }

        [StringLength(100)]
        public string FirstName { get; set; }

        [StringLength(100)]
        public string LastName { get; set; }

        [StringLength(100)]
        public string DisplayName { get; set; }

        [StringLength(50)]
        public string AccountType { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long User_ID { get; set; }

        [StringLength(100)]
        public string Nationality { get; set; }

        public bool? PRstatus { get; set; }

        public DateTime? DateofBirth { get; set; }

        [StringLength(20)]
        public string Gender { get; set; }

        [StringLength(500)]
        public string ResidentialAddress { get; set; }

        [StringLength(10)]
        public string PostalCode { get; set; }

        [StringLength(20)]
        public string OptionalContactnumber { get; set; }

        [StringLength(100)]
        public string Occupation { get; set; }

        [StringLength(50)]
        public string IncomeRange { get; set; }

        [StringLength(100)]
        public string BankBranch { get; set; }

        [StringLength(50)]
        public string AccountNumber { get; set; }

        [StringLength(200)]
        public string AccountName { get; set; }

        [StringLength(500)]
        public string LevelofEducation { get; set; }

        [StringLength(500)]
        public string FinancialInvestmentProducts { get; set; }

        [StringLength(500)]
        public string MoolahConnectInvestment { get; set; }

        public string InvestmentObjectives { get; set; }

        [StringLength(500)]
        public string ReactionOndefaulted { get; set; }

        [StringLength(200)]
        public string RoleJobTitle { get; set; }

        [StringLength(500)]
        public string BusinessName { get; set; }

        [StringLength(200)]
        public string BusinessOrganisation { get; set; }

        public int? Natureofbusiness_Id { get; set; }

        public DateTime? DateofIncorporation { get; set; }

        [StringLength(500)]
        public string RegisteredAddress { get; set; }

        [StringLength(300)]
        public string BusinessMailingAddress { get; set; }

        public int? Bank_Id { get; set; }

        [StringLength(20)]
        public string Main_OfficeContactnumber { get; set; }

        [StringLength(20)]
        public string Mobilenumber { get; set; }

        public string IC_CompanyRegistrationNumber { get; set; }

        public double? PaidUpCapital { get; set; }

        public int? NumOfEmployees { get; set; }

        [StringLength(100)]
        public string NRIC_Number { get; set; }

        [StringLength(100)]
        public string PassportNumber { get; set; }

        [StringLength(50)]
        public string SiccCode { get; set; }

        [StringLength(100)]
        public string BranchName { get; set; }

        [StringLength(100)]
        public string BranchNumber { get; set; }

        [StringLength(100)]
        public string BankNumber { get; set; }

        [StringLength(100)]
        public string AdditionalEmail { get; set; }

        [StringLength(500)]
        public string ContactMethods { get; set; }

        public bool IsEligible { get; set; }

        public int? PartnerId { get; set; }

        [StringLength(50)]
        public string CurrrencyDisplay { get; set; }

        public int? RegisteredCountryId { get; set; }

        public int? BusinessMailingCountryId { get; set; }

        [StringLength(250)]
        public string FullNameAsInBank { get; set; }

        [StringLength(250)]
        public string FullName { get; set; }

        public int? OtherNationalityCountryID { get; set; }

        public int? IndustryType { get; set; }

        [StringLength(5)]
        public string CallingCode { get; set; }

        public bool? Campaing_Alert_Unsubscribe { get; set; }

        [StringLength(50)]
        public string IdentityType { get; set; }

        [StringLength(5)]
        public string BPCallingCode { get; set; }

        public virtual BrwInitialNoteRequest BrwInitialNoteRequest { get; set; }

        public virtual tbl_BanksList tbl_BanksList { get; set; }

        public virtual tbl_Countries tbl_Countries { get; set; }

        public virtual tbl_NatureofBusinessList tbl_NatureofBusinessList { get; set; }

        public virtual tbl_Partners tbl_Partners { get; set; }

        public virtual tbl_Users tbl_Users { get; set; }

        public virtual tbl_Countries tbl_Countries1 { get; set; }
    }
}
