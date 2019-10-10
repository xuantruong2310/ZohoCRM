namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_LogESignInfo
    {
        [Key]
        [Column(Order = 0)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ESignInfoID { get; set; }

        public long? RequestID { get; set; }

        public Guid? UserID { get; set; }

        public long? UserInfoID { get; set; }

        public int? FileID { get; set; }

        [StringLength(50)]
        public string ContractType { get; set; }

        [StringLength(500)]
        public string DocumentID { get; set; }

        [StringLength(200)]
        public string DocumentName { get; set; }

        [StringLength(200)]
        public string SignerEmail { get; set; }

        [StringLength(50)]
        public string FileStatus { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string AdminStatus { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GenerationType { get; set; }

        [StringLength(50)]
        public string Title { get; set; }

        [StringLength(200)]
        public string Comment { get; set; }

        [StringLength(100)]
        public string Subject { get; set; }

        [StringLength(200)]
        public string SignURL { get; set; }

        [StringLength(100)]
        public string TinyURL { get; set; }

        public int? FinalContractRevision { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime CreatedDate { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime LastUpdatedTime { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(200)]
        public string LastUpdatedBy { get; set; }

        [StringLength(50)]
        public string Operation { get; set; }

        public virtual tbl_Files tbl_Files { get; set; }

        public virtual tbl_LoanRequests tbl_LoanRequests { get; set; }
    }
}
