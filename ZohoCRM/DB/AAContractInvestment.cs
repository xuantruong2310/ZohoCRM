namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AAContractInvestment
    {
        public long ID { get; set; }

        public long ContractId { get; set; }

        public long NoteId { get; set; }

        public DateTime InvestmentDate { get; set; }

        public virtual AAContract AAContract { get; set; }

        public virtual tbl_LoanRequests tbl_LoanRequests { get; set; }
    }
}
