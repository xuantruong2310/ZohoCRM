namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_OutStandingLitigation
    {
        [Key]
        public long LitigationId { get; set; }

        public decimal? AmountOutstanding { get; set; }

        public decimal? CreditLimit { get; set; }

        public decimal? UsageinLastMonth { get; set; }

        public DateTime? RenewalDate { get; set; }

        public decimal? RepaymentAmount { get; set; }

        [StringLength(50)]
        public string RepaymentPeriod { get; set; }

        public DateTime? DateofLastPayment { get; set; }

        public string Description { get; set; }

        [StringLength(32)]
        public string LitigationType { get; set; }

        public int? PaymentTerms { get; set; }

        public long? MoolahCore_Id { get; set; }

        public DateTime? DateCreated { get; set; }

        public DateTime? DateUpdated { get; set; }

        public long? User_ID { get; set; }

        public virtual tbl_MoolahCore tbl_MoolahCore { get; set; }

        public virtual tbl_Users tbl_Users { get; set; }
    }
}
