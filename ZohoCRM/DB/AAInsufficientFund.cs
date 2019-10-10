namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AAInsufficientFund
    {
        public long Id { get; set; }

        public long ContractId { get; set; }

        public DateTime CreatedDate { get; set; }

        public virtual AAContract AAContract { get; set; }
    }
}
