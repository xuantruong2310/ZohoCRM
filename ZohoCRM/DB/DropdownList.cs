namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DropdownList")]
    public partial class DropdownList
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Required]
        [StringLength(150)]
        public string Value { get; set; }

        public int Category { get; set; }

        public int? ValueOrder { get; set; }

        public virtual DropdownListCategory DropdownListCategory { get; set; }
    }
}
