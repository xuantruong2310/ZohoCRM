namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_API_Guarantor
    {
        [Key]
        public int GuarantorID { get; set; }

        public int? IssuerID { get; set; }

        public string Name { get; set; }

        public string NameDP { get; set; }

        [StringLength(100)]
        public string IDNumber { get; set; }

        public string Type { get; set; }

        public DateTime? CreatedTime { get; set; }

        public DateTime? LastUpdated { get; set; }
    }
}
