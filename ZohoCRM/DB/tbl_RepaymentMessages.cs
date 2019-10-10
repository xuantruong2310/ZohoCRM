namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_RepaymentMessages
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_RepaymentMessages()
        {
            UserRepaymentMsgs = new HashSet<UserRepaymentMsg>();
        }

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

        public virtual tbl_LoanRequests tbl_LoanRequests { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserRepaymentMsg> UserRepaymentMsgs { get; set; }
    }
}
