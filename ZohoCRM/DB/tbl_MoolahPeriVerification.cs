namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_MoolahPeriVerification
    {
        [Key]
        public long MoolahPeriVerification { get; set; }

        public int? BussinessAwardsVerification { get; set; }

        public int? AcrediationVerification { get; set; }

        public int? MTAVerificationVerification { get; set; }

        public int? DigitalFootPrintVerification { get; set; }

        public int? CommunityVerification { get; set; }

        public int? BiodataofDSVerification { get; set; }

        public int? MoolahPerkVerification { get; set; }

        public long? Request_ID { get; set; }

        public DateTime? DateCreated { get; set; }

        public string AdminComments { get; set; }

        public virtual tbl_LoanRequests tbl_LoanRequests { get; set; }
    }
}
