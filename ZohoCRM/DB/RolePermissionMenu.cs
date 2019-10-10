namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Identity.RolePermissionMenus")]
    public partial class RolePermissionMenu
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RoleId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PermissionMenuId { get; set; }

        public int AccessLevel { get; set; }

        public virtual PermissionMenu PermissionMenu { get; set; }

        public virtual Role Role { get; set; }
    }
}
