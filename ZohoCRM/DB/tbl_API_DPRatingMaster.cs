namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_API_DPRatingMaster
    {
        public long ID { get; set; }

        [StringLength(50)]
        public string ReferenceNumber { get; set; }

        [StringLength(500)]
        public string Name { get; set; }

        [StringLength(50)]
        public string RegistrationNumber { get; set; }

        [StringLength(100)]
        public string FileIds { get; set; }

        public short? Status { get; set; }

        [StringLength(50)]
        public string Rating { get; set; }

        public DateTime? CreatedTime { get; set; }

        public DateTime? LastUpdated { get; set; }

        [StringLength(1)]
        public string ObsInd { get; set; }
    }
}
