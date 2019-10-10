namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PublicHoliday
    {
        public long ID { get; set; }

        public int Year { get; set; }

        [Column(TypeName = "date")]
        public DateTime Holiday { get; set; }
    }
}
