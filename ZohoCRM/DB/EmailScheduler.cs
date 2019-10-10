namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EmailScheduler")]
    public partial class EmailScheduler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EmailScheduler()
        {
            UserRepaymentMsgs = new HashSet<UserRepaymentMsg>();
        }

        public int id { get; set; }

        public string UserNames { get; set; }

        public string EmailSubject { get; set; }

        public DateTime? ScheduledTime { get; set; }

        [Column(TypeName = "date")]
        public DateTime? SchedulePaymentDate { get; set; }

        [StringLength(255)]
        public string StatusOfLateRepayment { get; set; }

        [StringLength(255)]
        public string RescheduledRepayment { get; set; }

        [StringLength(255)]
        public string LastEmailNotification { get; set; }

        public string Reason { get; set; }

        public string Remarks { get; set; }

        public byte? EmailSent { get; set; }

        [StringLength(255)]
        public string IssuerName { get; set; }

        [StringLength(255)]
        public string NoteType { get; set; }

        [StringLength(255)]
        public string NoteId { get; set; }

        [StringLength(50)]
        public string MailToType { get; set; }

        public byte? IsScheduled { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserRepaymentMsg> UserRepaymentMsgs { get; set; }
    }
}
