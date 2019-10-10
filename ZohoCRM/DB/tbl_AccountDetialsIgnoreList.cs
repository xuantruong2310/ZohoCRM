namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_AccountDetialsIgnoreList
    {
        public int Id { get; set; }

        [StringLength(250)]
        public string Name { get; set; }
    }
}
