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
    
    public partial class tbl_ESignInfo
    {
        public int ID { get; set; }
        public Nullable<long> RequestID { get; set; }
        public Nullable<int> FileID { get; set; }
        public Nullable<System.Guid> UserID { get; set; }
        public Nullable<long> UserInfoID { get; set; }
        public string ContractType { get; set; }
        public string DocumentID { get; set; }
        public string DocumentName { get; set; }
        public string SignerEmail { get; set; }
        public string FileStatus { get; set; }
        public string AdminStatus { get; set; }
        public int GenerationType { get; set; }
        public string Title { get; set; }
        public string Comment { get; set; }
        public string Subject { get; set; }
        public string SignURL { get; set; }
        public string TinyURL { get; set; }
        public Nullable<int> FinalContractRevision { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.DateTime LastUpdatedTime { get; set; }
        public string LastUpdatedBy { get; set; }
    
        public virtual tbl_Files tbl_Files { get; set; }
        public virtual tbl_LoanRequests tbl_LoanRequests { get; set; }
    }
}
