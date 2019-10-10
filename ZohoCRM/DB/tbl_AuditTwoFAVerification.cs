namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_AuditTwoFAVerification
    {
        public int Id { get; set; }

        public long UserID { get; set; }

        [Required]
        [StringLength(20)]
        public string MobileNo { get; set; }

        [Required]
        [StringLength(5)]
        public string CallingCode { get; set; }

        [Required]
        [StringLength(30)]
        public string OTP { get; set; }

        public byte? UnsuccessfulAttempt { get; set; }

        public DateTime? DateCreated { get; set; }

        [StringLength(1)]
        public string Operation { get; set; }

        public virtual tbl_Users tbl_Users { get; set; }
    }
}
