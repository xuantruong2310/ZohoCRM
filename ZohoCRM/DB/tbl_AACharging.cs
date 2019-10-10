namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_AACharging
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NumberOfInvestments { get; set; }

        public int Cost { get; set; }
    }
}
