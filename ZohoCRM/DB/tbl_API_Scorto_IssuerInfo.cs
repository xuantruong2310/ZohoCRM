namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_API_Scorto_IssuerInfo
    {
        public int Id { get; set; }

        public long? AppId { get; set; }

        [StringLength(500)]
        public string IssuerName { get; set; }

        [StringLength(200)]
        public string Industry { get; set; }

        [StringLength(20)]
        public string DPRating { get; set; }

        [StringLength(500)]
        public string LeadSource { get; set; }

        [StringLength(500)]
        public string PartnerName { get; set; }

        [StringLength(500)]
        public string PartnerCompanyName { get; set; }

        [StringLength(500)]
        public string PartnerCompanyType { get; set; }

        public decimal? NetSalesCurrentYear { get; set; }

        public decimal? NetSalesLastYear { get; set; }

        public decimal? OPMCurrentYear { get; set; }

        public decimal? OPMLastYear { get; set; }

        public decimal? ICRCurrentYear { get; set; }

        public decimal? ICRLastYear { get; set; }

        public decimal? DebtToEquityRatioCurrentYear { get; set; }

        public decimal? DebtToEquityRatioLastYear { get; set; }

        public decimal? ARDOHCurrentYear { get; set; }

        public decimal? ARDOHLastYear { get; set; }

        public decimal? MedianCashBalance { get; set; }

        [StringLength(20)]
        public string NumberOfGuarantors { get; set; }

        [StringLength(100)]
        public string UEN { get; set; }

        public DateTime? LUT { get; set; }
    }
}
