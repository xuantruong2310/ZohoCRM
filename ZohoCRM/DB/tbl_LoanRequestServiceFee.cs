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
    
    public partial class tbl_LoanRequestServiceFee
    {
        public int Id { get; set; }
        public Nullable<long> RequestID { get; set; }
        public Nullable<int> InvestorServicingFeeTypeID { get; set; }
        public Nullable<decimal> FeePercentage { get; set; }
    
        public virtual tbl_InvestorServicingFeeType tbl_InvestorServicingFeeType { get; set; }
        public virtual tbl_LoanRequests tbl_LoanRequests { get; set; }
    }
}
