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
    
    public partial class tbl_ReconData
    {
        public long ID { get; set; }
        public System.DateTime ReconDate { get; set; }
        public Nullable<long> StaggingID { get; set; }
        public Nullable<long> SystemRefID { get; set; }
        public Nullable<long> UserID { get; set; }
        public Nullable<int> TransactionTypeID { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public string Description { get; set; }
        public Nullable<int> DebitOrCredit { get; set; }
        public Nullable<int> IsRecordMatched { get; set; }
        public Nullable<int> IsReconMatched { get; set; }
        public Nullable<int> IsLatest { get; set; }
        public Nullable<int> IsCarryForward { get; set; }
        public Nullable<System.DateTime> CarryForwardDate { get; set; }
    }
}
