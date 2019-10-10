namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class b_UOBGroupBranches
    {
        [Key]
        public int UOBID { get; set; }

        [StringLength(50)]
        public string BranchName { get; set; }

        [StringLength(3)]
        public string AccountNumber { get; set; }

        [StringLength(4)]
        public string BankCode { get; set; }

        [StringLength(3)]
        public string BranchCode { get; set; }
    }
}
