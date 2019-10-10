namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserQualification")]
    public partial class UserQualification
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long User_ID { get; set; }

        public int? Education { get; set; }

        public int? ProffesionalQualifications { get; set; }

        public int? WorkExperience { get; set; }

        public int? InvestmentExperience { get; set; }

        public bool? InvestSuitablityQuest1 { get; set; }

        public bool? InvestSuitablityQuest2 { get; set; }

        public int? InvestmentPreference { get; set; }

        public int? InvestmentObjective { get; set; }

        public virtual tbl_Users tbl_Users { get; set; }
    }
}
