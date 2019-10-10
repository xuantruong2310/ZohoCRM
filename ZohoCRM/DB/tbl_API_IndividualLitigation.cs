namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_API_IndividualLitigation
    {
        [Key]
        public int ILID { get; set; }

        public int? GuarantorID { get; set; }

        [StringLength(10)]
        public string Number { get; set; }

        public DateTime? CreatedTime { get; set; }

        public DateTime? LastUpdated { get; set; }
    }
}
