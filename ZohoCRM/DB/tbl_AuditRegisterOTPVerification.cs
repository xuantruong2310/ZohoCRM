namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_AuditRegisterOTPVerification
    {
        [Key]
        [Column(Order = 0)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(250)]
        public string Email { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string MobileNo { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(5)]
        public string CallingCode { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(30)]
        public string OTP { get; set; }

        public byte? UnsuccessfulAttempt { get; set; }

        public DateTime? DateCreated { get; set; }

        [StringLength(1)]
        public string Operation { get; set; }
    }
}
