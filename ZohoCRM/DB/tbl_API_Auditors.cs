namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_API_Auditors
    {
        public int ID { get; set; }

        public int? IssuerID { get; set; }

        public string Name { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateOfAudit { get; set; }

        public virtual tbl_API_IssuerRegistration tbl_API_IssuerRegistration { get; set; }
    }
}
