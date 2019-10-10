namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserQualificationVerification")]
    public partial class UserQualificationVerification
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long User_ID { get; set; }

        public bool? EducationVerification { get; set; }

        public bool? ProffesionalQualificationsVerification { get; set; }

        public bool? WorkExperienceVerification { get; set; }

        public bool? InvestmentExperienceVerification { get; set; }

        public bool? InvestmentPreference { get; set; }

        public bool? InvestmentObjective { get; set; }

        public virtual tbl_Users tbl_Users { get; set; }
    }
}
