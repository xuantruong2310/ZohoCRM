namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_MoolahPeri
    {
        [Key]
        public long MoolahPeriId { get; set; }

        public string BusinessAwards { get; set; }

        public string Accreditation { get; set; }

        public string MTA { get; set; }

        public string DigitalFootPrint { get; set; }

        public string CommunityInitiative { get; set; }

        public string BiodataOfDS { get; set; }

        public long? MoolahPerk_Id { get; set; }

        public string MoolahPerk_Custom { get; set; }

        public long? Request_ID { get; set; }

        public long? User_ID { get; set; }

        public DateTime? DateCreated { get; set; }

        public DateTime? DateUpdated { get; set; }

        public bool? UpdateMoolahPost { get; set; }

        public virtual tbl_LoanRequests tbl_LoanRequests { get; set; }

        public virtual tbl_Users tbl_Users { get; set; }
    }
}
