namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_LaunchTimes
    {
        public int Id { get; set; }

        public TimeSpan? Time { get; set; }

        [StringLength(10)]
        public string Label { get; set; }
    }
}
