namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BrwInitialNoteRequest")]
    public partial class BrwInitialNoteRequest
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long User_ID { get; set; }

        [StringLength(50)]
        public string NoteAmount { get; set; }

        [StringLength(50)]
        public string Tenure { get; set; }

        public string Purpose { get; set; }

        public virtual tbl_AccountDetails tbl_AccountDetails { get; set; }
    }
}
