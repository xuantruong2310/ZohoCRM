namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_PaidLatePayments
    {
        [Key]
        public int LateAmortizationID { get; set; }

        public long RequestID { get; set; }

        public DateTime LateSince { get; set; }

        public int DaysLate { get; set; }

        public int LateRepaymentsCount { get; set; }

        public decimal AccruedInterest { get; set; }

        public decimal LateFees { get; set; }

        public DateTime PaidDate { get; set; }

        public bool LateFeesPaid { get; set; }

        public virtual tbl_LoanRequests tbl_LoanRequests { get; set; }
    }
}
