namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class u_VerificationToken
    {
        [Key]
        public int TokenId { get; set; }

        public Guid Token { get; set; }

        public DateTime CreatedDate { get; set; }

        public Guid UserId { get; set; }
    }
}
