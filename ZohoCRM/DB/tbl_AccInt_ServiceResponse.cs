namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_AccInt_ServiceResponse
    {
        public long ID { get; set; }

        public long RequestID { get; set; }

        [StringLength(100)]
        public string Provider { get; set; }

        [StringLength(200)]
        public string EndPoint { get; set; }

        [StringLength(50)]
        public string Type { get; set; }

        public string Response { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateModified { get; set; }
    }
}
