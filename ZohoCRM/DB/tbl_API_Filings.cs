namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_API_Filings
    {
        public int ID { get; set; }

        public int? WritOfSummonsID { get; set; }

        [StringLength(50)]
        public string SerialNumber { get; set; }

        public string Court { get; set; }

        [StringLength(50)]
        public string CaseNumber { get; set; }

        public int? FilingYear { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FIlingDate { get; set; }

        public string Plaintiff { get; set; }

        public string Remarks { get; set; }

        public string Status { get; set; }

        public string Amounts { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Updated { get; set; }
    }
}
