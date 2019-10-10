namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_TransactionMapping
    {
        public int ID { get; set; }

        [Required]
        [StringLength(500)]
        public string Criteria { get; set; }

        public int? TransactionValue { get; set; }
    }
}
