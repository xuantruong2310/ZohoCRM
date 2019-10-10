namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_Comments
    {
        [Key]
        public long CommentId { get; set; }

        public long? Request_Id { get; set; }

        public long? Commentor_Id { get; set; }

        public DateTime? DateCreated { get; set; }

        public virtual tbl_LoanRequests tbl_LoanRequests { get; set; }

        public virtual tbl_Users tbl_Users { get; set; }
    }
}
