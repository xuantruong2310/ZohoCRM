namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_CampaignViewers
    {
        public long Id { get; set; }

        public long UserId { get; set; }

        public long NoteId { get; set; }

        [Required]
        [StringLength(250)]
        public string DigitalSignature { get; set; }

        public decimal DepositAmount { get; set; }

        public DateTime DateTime { get; set; }

        public short? DepositeStatus { get; set; }

        public DateTime? DepositeStatusChangeDate { get; set; }

        public virtual tbl_LoanRequests tbl_LoanRequests { get; set; }

        public virtual tbl_Users tbl_Users { get; set; }
    }
}
