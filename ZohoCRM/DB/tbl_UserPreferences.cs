namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_UserPreferences
    {
        [Key]
        public long PreferenceId { get; set; }

        public long User_ID { get; set; }

        [StringLength(500)]
        public string PreferenceType { get; set; }

        public bool? Value { get; set; }

        public virtual tbl_Users tbl_Users { get; set; }
    }
}
