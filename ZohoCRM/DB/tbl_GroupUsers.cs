namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_GroupUsers
    {
        public Guid Id { get; set; }

        public int GroupID { get; set; }

        public long UserID { get; set; }

        public virtual tbl_Group tbl_Group { get; set; }

        public virtual tbl_Users tbl_Users { get; set; }
    }
}
