namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_UserTest
    {
        [Key]
        [Column(Order = 0)]
        public long UserID { get; set; }

        [StringLength(250)]
        public string UserName { get; set; }

        public bool? Isactive { get; set; }

        [StringLength(50)]
        public string UserRole { get; set; }

        public DateTime? DateCreated { get; set; }

        public bool? SubscribeforUpdates { get; set; }

        [StringLength(32)]
        public string InvestorType { get; set; }

        [StringLength(16)]
        public string AdminVerification { get; set; }

        public bool? IsSubmitted { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid AspnetUserId { get; set; }

        public bool? IsEmailVerified { get; set; }

        [StringLength(128)]
        public string DigitalSignature { get; set; }

        public DateTime? SubmittedDate { get; set; }

        public bool? IsDeleted { get; set; }

        public Guid? UserGoToKnowSourceDetailsId { get; set; }

        public DateTime? LastRefPromoEndDate { get; set; }

        public bool? IsFirstTimeAccessed { get; set; }

        public DateTime? ApprovedDate { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool HasAcknowledgedRisk { get; set; }

        [StringLength(100)]
        public string RiskAcknowledgeSignature { get; set; }

        public DateTime? RiskAcknowledgeDate { get; set; }

        [Key]
        [Column(Order = 3)]
        public bool HasViewUnlock_Video { get; set; }

        [Key]
        [Column(Order = 4)]
        public bool HasView_Auto_Allocate_Video { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TransferSlipStatus { get; set; }

        public string Remarks { get; set; }

        public DateTime? QualifiedDate { get; set; }

        public bool? EmailUnsubscribed { get; set; }

        public bool? MPThreeDayNoActionMailSent { get; set; }

        [Key]
        [Column(Order = 6)]
        public bool IsQualifiedPointsRewared { get; set; }

        public byte? IsTwoFARegistered { get; set; }

        public int? ReferrarID { get; set; }

        public byte? LoginType { get; set; }

        [StringLength(100)]
        public string ReferrarCode { get; set; }
    }
}
