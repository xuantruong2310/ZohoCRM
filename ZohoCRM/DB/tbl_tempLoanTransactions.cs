namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_tempLoanTransactions
    {
        [Key]
        [Column(Order = 0)]
        public long TransactionId { get; set; }

        public long? Request_Id { get; set; }

        public decimal? Amount { get; set; }

        [StringLength(64)]
        public string PaymentTerms { get; set; }

        public long? User_ID { get; set; }

        public DateTime? DateCreated { get; set; }

        [StringLength(64)]
        public string PaymentMode { get; set; }

        public decimal? Debted { get; set; }

        public decimal? Credited { get; set; }

        public decimal? Balance { get; set; }

        public string Description { get; set; }

        public long? Withdraw_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(30)]
        public string Reference { get; set; }

        public long? RefUserID { get; set; }

        public long? BalanceID { get; set; }

        public int? Type { get; set; }
    }
}
