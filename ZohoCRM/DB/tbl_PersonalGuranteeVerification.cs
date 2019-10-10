namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_PersonalGuranteeVerification
    {
        [Key]
        public int InfoVerificationID { get; set; }

        [StringLength(16)]
        public string NameAsinNRICVerification { get; set; }

        [StringLength(16)]
        public string DesignationVerification { get; set; }

        [StringLength(16)]
        public string NRIC_PassportVerification { get; set; }

        [StringLength(16)]
        public string PassportNumber { get; set; }

        [StringLength(16)]
        public string ResidentialAddressVerification { get; set; }

        [StringLength(16)]
        public string TelephoneVerification { get; set; }

        [StringLength(16)]
        public string EmailVerification { get; set; }

        [StringLength(16)]
        public string ReasonsVerification { get; set; }

        public long? Request_IdInfoVerification { get; set; }

        [StringLength(16)]
        public string PostalcodeVerification { get; set; }

        [StringLength(16)]
        public string NationalityVerification { get; set; }
    }
}
