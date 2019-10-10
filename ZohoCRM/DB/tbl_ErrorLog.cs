namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_ErrorLog
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Level { get; set; }

        public string Message { get; set; }

        public DateTime Timestamp { get; set; }

        [Required]
        [StringLength(200)]
        public string UserName { get; set; }

        public string StackTrace { get; set; }

        public string InnerMessage { get; set; }
    }
}
