namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EmailTemplate
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        public byte[] TemplateContent { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime? LastUpdate { get; set; }

        public bool IsArchive { get; set; }
    }
}
