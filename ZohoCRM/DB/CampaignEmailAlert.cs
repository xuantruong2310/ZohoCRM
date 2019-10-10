namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CampaignEmailAlert
    {
        public long ID { get; set; }

        public long NoteID { get; set; }

        public DateTime? SchduleDateTime { get; set; }

        public short Status { get; set; }

        public DateTime? StatusChangedDate { get; set; }

        [StringLength(150)]
        public string Comments { get; set; }

        public DateTime CreateDate { get; set; }

        [StringLength(50)]
        public string HangFireJobID { get; set; }

        public long? DependAlertId { get; set; }

        public virtual tbl_LoanRequests tbl_LoanRequests { get; set; }
    }
}
