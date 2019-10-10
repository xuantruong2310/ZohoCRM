namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_PersonalGuaranteeInfo
    {
        [Key]
        public int InfoId { get; set; }

        [StringLength(200)]
        public string NameAsinNRIC { get; set; }

        [StringLength(200)]
        public string Designation { get; set; }

        [StringLength(200)]
        public string NRIC_Passport { get; set; }

        [StringLength(200)]
        public string PassportNumber { get; set; }

        [StringLength(500)]
        public string ResidentialAddress { get; set; }

        [StringLength(20)]
        public string Telephone { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        public string Reasons { get; set; }

        public long? Request_Id { get; set; }

        [StringLength(10)]
        public string Postalcode { get; set; }

        [StringLength(50)]
        public string Nationality { get; set; }

        [StringLength(25)]
        public string GuarantorType { get; set; }

        public virtual tbl_LoanRequests tbl_LoanRequests { get; set; }
    }
}
