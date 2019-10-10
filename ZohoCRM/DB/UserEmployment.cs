namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserEmployment")]
    public partial class UserEmployment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long User_ID { get; set; }

        public int? Status { get; set; }

        [StringLength(250)]
        public string CompanyName { get; set; }

        public int? Industry { get; set; }

        public int? AnnualIncome { get; set; }

        public int? SavingsAndInvestments { get; set; }

        public bool? AccreditedRule1 { get; set; }

        public bool? AccreditedRule2 { get; set; }

        public bool? HaveBankDepositRule3 { get; set; }

        public virtual tbl_Users tbl_Users { get; set; }

        public virtual UserEmploymentVerification UserEmploymentVerification { get; set; }
    }
}
