namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FundTransferInSlip
    {
        public long Id { get; set; }

        public int TransferFileId { get; set; }

        public long UserId { get; set; }

        public decimal CreditAmount { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime CreatedDate { get; set; }

        public virtual tbl_Files tbl_Files { get; set; }

        public virtual tbl_Users tbl_Users { get; set; }
    }
}
