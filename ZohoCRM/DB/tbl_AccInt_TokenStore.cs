namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_AccInt_TokenStore
    {
        public long ID { get; set; }

        [Required]
        [StringLength(100)]
        public string TokenKey { get; set; }

        [StringLength(5000)]
        public string TokenValue { get; set; }

        [StringLength(50)]
        public string Type { get; set; }
    }
}
