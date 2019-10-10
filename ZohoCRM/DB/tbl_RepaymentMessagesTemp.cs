namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_RepaymentMessagesTemp
    {
        public long ID { get; set; }

        public long? LoanRequestId { get; set; }

        public string Message { get; set; }

        public DateTime? CreatedDate { get; set; }

        [StringLength(50)]
        public string SendToType { get; set; }

        public string CustomUserNames { get; set; }

        public int? MsgType { get; set; }

        [StringLength(255)]
        public string Title { get; set; }

        public bool? SysGenerated { get; set; }
    }
}
