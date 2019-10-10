namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class UserAcknowledgement
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long UserId { get; set; }

        public bool AreCitizenOfUSA { get; set; }

        public bool IsAcknowledgeRiskDisclosure { get; set; }

        public bool IsConfirmInterestInInvesting { get; set; }

        public bool IsUnderstoodPayyeAgreement { get; set; }

        public bool IsCertifyInformation { get; set; }

        public bool IsAcknowledgeMSnotFinAdvise { get; set; }

        public bool IsReceivedMSPrivacyDataProtection { get; set; }

        public virtual tbl_Users tbl_Users { get; set; }
    }
}
