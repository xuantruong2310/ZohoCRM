namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_Knowledgeassessmentdetails_ForUser
    {
        [Key]
        public int RecId { get; set; }

        public int? Option_Id { get; set; }

        [StringLength(50)]
        public string Option_Value { get; set; }

        public long? User_ID { get; set; }

        public DateTime? DateCreated { get; set; }

        public virtual tbl_Users tbl_Users { get; set; }
    }
}
