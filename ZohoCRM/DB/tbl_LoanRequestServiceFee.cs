namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_LoanRequestServiceFee
    {
        public int Id { get; set; }

        public long? RequestID { get; set; }

        public int? InvestorServicingFeeTypeID { get; set; }

        public decimal? FeePercentage { get; set; }

        public virtual tbl_InvestorServicingFeeType tbl_InvestorServicingFeeType { get; set; }

        public virtual tbl_LoanRequests tbl_LoanRequests { get; set; }
    }
}
