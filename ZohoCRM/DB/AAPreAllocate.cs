//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class AAPreAllocate
    {
        public long PreAllocationId { get; set; }
        public long ContractId { get; set; }
        public long NoteId { get; set; }
        public System.DateTime DateCreated { get; set; }
        public int AllocationStatus { get; set; }
        public Nullable<System.DateTime> StatusChangedDate { get; set; }
        public string Comments { get; set; }
    
        public virtual AAContract AAContract { get; set; }
        public virtual tbl_LoanRequests tbl_LoanRequests { get; set; }
    }
}
