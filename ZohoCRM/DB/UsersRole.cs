namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Identity.UsersRoles")]
    public partial class UsersRole
    {
        public int ID { get; set; }

        public long UserId { get; set; }

        public int RoleId { get; set; }

        public virtual tbl_Users tbl_Users { get; set; }

        public virtual Role Role { get; set; }
    }
}
