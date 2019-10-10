namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class aspnet_Applications
    {
        [Required]
        [StringLength(256)]
        public string ApplicationName { get; set; }

        [Required]
        [StringLength(256)]
        public string LoweredApplicationName { get; set; }

        [Key]
        public Guid ApplicationId { get; set; }

        [StringLength(256)]
        public string Description { get; set; }
    }
}
