namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AAPlusCost")]
    public partial class AAPlusCost
    {
        public int ID { get; set; }

        public decimal Cost { get; set; }

        public DateTime LastUpdated { get; set; }
    }
}
