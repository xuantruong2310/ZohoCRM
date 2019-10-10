namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_AuditTrial
    {
        [Key]
        public long AuditTrialID { get; set; }

        public long? UserID { get; set; }

        public string ColumnChanged { get; set; }

        public string ColumnOldValue { get; set; }

        public string ColumnNewValue { get; set; }

        public DateTime? DateCreated { get; set; }

        [StringLength(64)]
        public string AdminUserName { get; set; }

        public virtual tbl_AuditTrial tbl_AuditTrial1 { get; set; }

        public virtual tbl_AuditTrial tbl_AuditTrial2 { get; set; }
    }
}
