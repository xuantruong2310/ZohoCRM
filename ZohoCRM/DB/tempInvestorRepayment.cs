namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tempInvestorRepayment")]
    public partial class tempInvestorRepayment
    {
        [Key]
        [Column(Order = 0)]
        public Guid InvRepID { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid IssuerRepID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OfferID { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime DueDate { get; set; }

        public decimal? Amount { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PayStatus { get; set; }

        public decimal? LateInterest { get; set; }

        public decimal? PaidLateInterest { get; set; }

        public decimal? Balance { get; set; }

        public decimal? Interest { get; set; }

        public decimal? Principal { get; set; }

        public decimal? PaidPrincipal { get; set; }

        public decimal? PaidInterest { get; set; }

        public decimal? PaidAmount { get; set; }

        public decimal? InvestorServiceFee { get; set; }

        public decimal? PaidInvestorServiceFee { get; set; }
    }
}
