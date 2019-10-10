namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_API_SearchCount
    {
        public int ID { get; set; }

        public int? IssuerID { get; set; }

        public int? YearNum { get; set; }

        public int? Total { get; set; }

        [StringLength(10)]
        public string Jan { get; set; }

        [StringLength(10)]
        public string Feb { get; set; }

        [StringLength(10)]
        public string Mar { get; set; }

        [StringLength(10)]
        public string Apr { get; set; }

        [StringLength(10)]
        public string May { get; set; }

        [StringLength(10)]
        public string Jun { get; set; }

        [StringLength(10)]
        public string Jul { get; set; }

        [StringLength(10)]
        public string Aug { get; set; }

        [StringLength(10)]
        public string Sep { get; set; }

        [StringLength(10)]
        public string Octo { get; set; }

        [StringLength(10)]
        public string Nov { get; set; }

        [StringLength(10)]
        public string Dece { get; set; }
    }
}
