namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_SecurityQuestions
    {
        [Key]
        public int QuestionId { get; set; }

        [StringLength(500)]
        public string QuestionName { get; set; }

        public DateTime? DateCreated { get; set; }

        public bool? Status { get; set; }
    }
}
