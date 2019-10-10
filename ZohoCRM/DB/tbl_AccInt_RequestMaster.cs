namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_AccInt_RequestMaster
    {
        public long ID { get; set; }

        public Guid RequestID { get; set; }

        [Required]
        [StringLength(50)]
        public string EmailAddress { get; set; }

        [Required]
        [StringLength(500)]
        public string CurrentRequestToken { get; set; }

        public decimal LoanAmount { get; set; }

        public int LoanPurpose { get; set; }

        public byte ApplicationStatus { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateModified { get; set; }
    }
}
