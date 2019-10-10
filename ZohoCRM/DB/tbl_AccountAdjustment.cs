namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_AccountAdjustment
    {
        public long ID { get; set; }

        public decimal TotalReceivable { get; set; }

        public decimal Difference { get; set; }

        public long? RepaymentID { get; set; }

        public bool? Adjusted { get; set; }

        public DateTime? AdjustedDate { get; set; }

        public DateTime TimeStamp { get; set; }

        public int? PaymentID { get; set; }

        public Guid? IssuerRepID { get; set; }

        public virtual IssuerRepayment IssuerRepayment { get; set; }

        public virtual tbl_LoanPayments tbl_LoanPayments { get; set; }
    }
}
