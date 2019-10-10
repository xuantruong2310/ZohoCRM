namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_API_BankruptcyFIling
    {
        public int ID { get; set; }

        public int? BID { get; set; }

        [StringLength(10)]
        public string Number { get; set; }

        [StringLength(10)]
        public string YearNum { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FilingDate { get; set; }

        public string Petitioner { get; set; }

        public string CaseStatus { get; set; }

        public string PartyStatus { get; set; }

        public string Amount { get; set; }

        public string Status { get; set; }

        public string Amounts { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Updated { get; set; }

        public DateTime? CreatedTime { get; set; }

        public DateTime? LastUpdated { get; set; }
    }
}
