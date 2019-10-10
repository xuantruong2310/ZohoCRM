namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AAPreAllocate
    {
        [Key]
        public long PreAllocationId { get; set; }

        public long ContractId { get; set; }

        public long NoteId { get; set; }

        public DateTime DateCreated { get; set; }

        public int AllocationStatus { get; set; }

        public DateTime? StatusChangedDate { get; set; }

        [StringLength(250)]
        public string Comments { get; set; }

        public virtual AAContract AAContract { get; set; }

        public virtual tbl_LoanRequests tbl_LoanRequests { get; set; }
    }
}
