namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserRepaymentMsg")]
    public partial class UserRepaymentMsg
    {
        public long ID { get; set; }

        public long? UserId { get; set; }

        public long? MsgId { get; set; }

        public int? MailId { get; set; }

        public virtual EmailScheduler EmailScheduler { get; set; }

        public virtual tbl_RepaymentMessages tbl_RepaymentMessages { get; set; }

        public virtual tbl_Users tbl_Users { get; set; }
    }
}
