namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_AccInt_ApplicationDetails
    {
        public long ID { get; set; }

        public long RequestID { get; set; }

        public int ProductType { get; set; }

        public int RepaymentFrequency { get; set; }

        public int NoteType { get; set; }

        public decimal Amount { get; set; }

        [StringLength(50)]
        public string Tenor { get; set; }

        [StringLength(50)]
        public string NumberOfEmployees { get; set; }

        [StringLength(50)]
        public string ManagementExp { get; set; }

        public int? NoOfGurantors { get; set; }

        public int? AllocationCurrency { get; set; }

        [StringLength(2000)]
        public string InvoiceNumners { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateModified { get; set; }
    }
}
