namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Identity.ActionPermissions")]
    public partial class ActionPermission
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string UniqueMethodName { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

        public int PermissionMenuId { get; set; }

        public int AccessLevel { get; set; }

        public virtual PermissionMenu PermissionMenu { get; set; }
    }
}
