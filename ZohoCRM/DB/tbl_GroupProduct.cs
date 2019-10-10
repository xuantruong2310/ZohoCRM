namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_GroupProduct
    {
        public Guid Id { get; set; }

        public int GroupID { get; set; }

        public int ProductID { get; set; }

        public virtual tbl_Group tbl_Group { get; set; }

        public virtual tbl_Product tbl_Product { get; set; }
    }
}
