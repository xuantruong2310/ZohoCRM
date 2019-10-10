namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_UserVerification
    {
        [Key]
        public long VerificationID { get; set; }

        public long? UserID { get; set; }

        [StringLength(16)]
        public string TitleVerification { get; set; }

        [StringLength(16)]
        public string FirstName { get; set; }

        [StringLength(16)]
        public string LastName { get; set; }

        [StringLength(16)]
        public string DisplayName { get; set; }

        [StringLength(16)]
        public string RoleOrJobTitle { get; set; }

        [StringLength(16)]
        public string BussinessName { get; set; }

        [StringLength(16)]
        public string BussinessRegistrationNumber { get; set; }

        [StringLength(16)]
        public string BussinessOrganisation { get; set; }

        [StringLength(16)]
        public string NatureofBussiness { get; set; }

        [StringLength(16)]
        public string DateofIncorporation { get; set; }

        [StringLength(16)]
        public string RegisteredAddress { get; set; }

        [StringLength(16)]
        public string BussinessMailingAddress { get; set; }

        [StringLength(16)]
        public string DirectLine { get; set; }

        [StringLength(16)]
        public string Mobile { get; set; }

        [StringLength(16)]
        public string OptinalContact { get; set; }

        [StringLength(16)]
        public string Bank { get; set; }

        [StringLength(16)]
        public string BankAccountNumber { get; set; }

        [StringLength(16)]
        public string BankAccountName { get; set; }

        public DateTime? DateCreated { get; set; }

        public string CommentsOnFieild { get; set; }

        public string CommentsOnDocuments { get; set; }

        [StringLength(16)]
        public string Nationality { get; set; }

        [StringLength(16)]
        public string PRStatus { get; set; }

        [StringLength(16)]
        public string Gender { get; set; }

        [StringLength(16)]
        public string ResidentialAddress { get; set; }

        [StringLength(16)]
        public string PostalCode { get; set; }

        [StringLength(16)]
        public string Ocupation { get; set; }

        [StringLength(16)]
        public string IncomeRane { get; set; }

        [StringLength(16)]
        public string Email { get; set; }

        [StringLength(16)]
        public string DOB { get; set; }

        public string AdminPersonelComment { get; set; }

        [StringLength(16)]
        public string PaidUpCapital { get; set; }

        [StringLength(16)]
        public string NumOfEmployees { get; set; }

        [StringLength(16)]
        public string NricNumber { get; set; }

        [StringLength(16)]
        public string PassportNumber { get; set; }

        [StringLength(16)]
        public string SiccCode { get; set; }

        [StringLength(16)]
        public string BranchName { get; set; }

        [StringLength(16)]
        public string BranchNumber { get; set; }

        [StringLength(16)]
        public string BankNumber { get; set; }

        [StringLength(16)]
        public string Country { get; set; }

        [StringLength(16)]
        public string Fullname { get; set; }
    }
}
