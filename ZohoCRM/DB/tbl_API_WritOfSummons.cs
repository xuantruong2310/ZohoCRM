namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_API_WritOfSummons
    {
        public int ID { get; set; }

        public int? IssuerID { get; set; }

        public int? NumberOfSuits { get; set; }

        public virtual tbl_API_IssuerRegistration tbl_API_IssuerRegistration { get; set; }
    }
}
