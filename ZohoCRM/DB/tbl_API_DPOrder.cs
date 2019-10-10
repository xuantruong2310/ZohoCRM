namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_API_DPOrder
    {
        public int ID { get; set; }

        [StringLength(100)]
        public string ReferenceNumber { get; set; }

        [StringLength(100)]
        public string OrderNo { get; set; }

        public DateTime? ScheduleTime { get; set; }

        public short? Status { get; set; }

        public DateTime? CreatedTime { get; set; }

        public DateTime? LastUpdated { get; set; }
    }
}
