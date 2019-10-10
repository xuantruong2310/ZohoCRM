namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_loanRequestReference
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long RequestId { get; set; }
    }
}
