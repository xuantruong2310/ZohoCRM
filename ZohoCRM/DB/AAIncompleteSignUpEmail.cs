namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AAIncompleteSignUpEmail
    {
        public long ID { get; set; }

        public long ContractID { get; set; }

        public DateTime SendDateTime { get; set; }

        public virtual AAContract AAContract { get; set; }
    }
}
