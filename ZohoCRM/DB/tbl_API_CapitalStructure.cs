namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_API_CapitalStructure
    {
        public int ID { get; set; }

        public int? IssuerID { get; set; }

        public int? Num { get; set; }

        [StringLength(10)]
        public string Currency { get; set; }

        public double? Amount { get; set; }

        [StringLength(100)]
        public string TypeOfStructure { get; set; }

        public virtual tbl_API_IssuerRegistration tbl_API_IssuerRegistration { get; set; }
    }
}
