namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_LogOtherLoanDocuments
    {
        public int ID { get; set; }

        public int? OtherDocID { get; set; }

        public int? FileID { get; set; }

        [Required]
        [StringLength(50)]
        public string Status { get; set; }

        [StringLength(200)]
        public string Comments { get; set; }

        public DateTime LastUpdatedTime { get; set; }

        [Required]
        [StringLength(200)]
        public string LastUpdatedBy { get; set; }

        [StringLength(50)]
        public string Operation { get; set; }
    }
}
