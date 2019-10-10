namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_WatchList
    {
        [Key]
        public long WatchListID { get; set; }

        public long? User_ID { get; set; }

        public long? Request_ID { get; set; }

        public DateTime? Datecreated { get; set; }

        public virtual tbl_LoanRequests tbl_LoanRequests { get; set; }
    }
}
