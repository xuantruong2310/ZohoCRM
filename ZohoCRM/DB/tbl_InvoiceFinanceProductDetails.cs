namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_InvoiceFinanceProductDetails
    {
        public long ID { get; set; }

        public long RequestId { get; set; }

        public decimal? Turnover { get; set; }

        public int? DebtorIndustry { get; set; }

        public decimal InvoiceFaceValue { get; set; }

        public decimal AdvanceFactor { get; set; }

        public decimal ProcessingFeePercent { get; set; }

        public decimal ProcessingFeeAmount { get; set; }

        public DateTime? InvoiceEndDate { get; set; }

        public virtual tbl_LoanRequests tbl_LoanRequests { get; set; }
    }
}
