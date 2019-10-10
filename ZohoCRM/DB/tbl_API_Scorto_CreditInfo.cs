namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_API_Scorto_CreditInfo
    {
        public int Id { get; set; }

        public long? AppId { get; set; }

        public DateTime? SubmissionDate { get; set; }

        public DateTime? IPADate { get; set; }

        public DateTime? SubmissionForFPA { get; set; }

        public DateTime? FPADate { get; set; }

        public decimal? OverallScore { get; set; }

        public decimal? FinancialScore { get; set; }

        public decimal? NonFinancialScore { get; set; }

        public DateTime? LUT { get; set; }
    }
}
