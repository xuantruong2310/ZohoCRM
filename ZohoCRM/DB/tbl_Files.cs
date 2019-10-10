namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_Files
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_Files()
        {
            FundTransferInSlips = new HashSet<FundTransferInSlip>();
            tbl_ESignInfo = new HashSet<tbl_ESignInfo>();
            tbl_LogESignInfo = new HashSet<tbl_LogESignInfo>();
            tbl_OtherLoanDocuments = new HashSet<tbl_OtherLoanDocuments>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(250)]
        public string FileName { get; set; }

        [Required]
        [StringLength(50)]
        public string Type { get; set; }

        public Guid UserId { get; set; }

        public DateTime CreatedDate { get; set; }

        [StringLength(500)]
        public string Comments { get; set; }

        public long? RequestId { get; set; }

        public int? OfferId { get; set; }

        public int? MsgId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FundTransferInSlip> FundTransferInSlips { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_ESignInfo> tbl_ESignInfo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_LogESignInfo> tbl_LogESignInfo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_OtherLoanDocuments> tbl_OtherLoanDocuments { get; set; }
    }
}
