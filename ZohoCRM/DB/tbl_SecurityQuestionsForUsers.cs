namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_SecurityQuestionsForUsers
    {
        [Key]
        public long RecId { get; set; }

        public int? Question_Id { get; set; }

        [StringLength(100)]
        public string Answer { get; set; }

        public long? User_ID { get; set; }

        public DateTime? DateCreated { get; set; }

        public DateTime? DateUpdated { get; set; }

        [StringLength(16)]
        public string IsVerified { get; set; }

        public virtual tbl_Users tbl_Users { get; set; }
    }
}
