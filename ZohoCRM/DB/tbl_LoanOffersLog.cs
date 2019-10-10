namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_LoanOffersLog
    {
        [Key]
        public int OfferLogID { get; set; }

        public int OfferStatus { get; set; }

        public DateTime TimeStamp { get; set; }

        public int OfferID { get; set; }

        [StringLength(200)]
        public string Reason { get; set; }
    }
}
