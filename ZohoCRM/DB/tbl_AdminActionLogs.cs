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
    
    public partial class tbl_AdminActionLogs
    {
        public long Id { get; set; }
        public string Message { get; set; }
        public Nullable<System.DateTime> Timestamp { get; set; }
        public string UserName { get; set; }
        public Nullable<long> LoanRequestId { get; set; }
        public Nullable<long> ActionUserId { get; set; }
        public string Reference { get; set; }
        public string FieldName { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
    }
}
