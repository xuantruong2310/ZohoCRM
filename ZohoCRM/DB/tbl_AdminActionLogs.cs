namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_AdminActionLogs
    {
        public long Id { get; set; }

        public string Message { get; set; }

        public DateTime? Timestamp { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        public long? LoanRequestId { get; set; }

        public long? ActionUserId { get; set; }

        [StringLength(20)]
        public string Reference { get; set; }

        [StringLength(100)]
        public string FieldName { get; set; }

        public string OldValue { get; set; }

        public string NewValue { get; set; }
    }
}
