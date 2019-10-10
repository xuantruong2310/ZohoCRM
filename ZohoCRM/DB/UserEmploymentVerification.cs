namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserEmploymentVerification")]
    public partial class UserEmploymentVerification
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long User_ID { get; set; }

        public bool StatusVerification { get; set; }

        public bool CompanyNameVerification { get; set; }

        public bool IndustryVerification { get; set; }

        public bool AnnualIncomeVerifiction { get; set; }

        public bool SavingsAndInvestmentsVerification { get; set; }

        public virtual UserEmployment UserEmployment { get; set; }
    }
}
