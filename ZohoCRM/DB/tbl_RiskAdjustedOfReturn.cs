namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_RiskAdjustedOfReturn
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long INVESTOR_ID { get; set; }

        public double? INVESTOR_RISKADJRATE { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(5)]
        public string RAROC { get; set; }

        public int? INVESTOR_LOANCOUNT { get; set; }

        public decimal? INVESTOR_OUTSTANDING_DUE { get; set; }

        public decimal? INVESTOR_LOANAMOUNT { get; set; }
    }
}
