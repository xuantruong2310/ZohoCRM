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
    
    public partial class CheckInvestorRepayment
    {
        public System.Guid InvRepID { get; set; }
        public System.Guid IssuerRepID { get; set; }
        public int OfferID { get; set; }
        public System.DateTime DueDate { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public int PayStatus { get; set; }
        public Nullable<decimal> LateInterest { get; set; }
        public Nullable<decimal> PaidLateInterest { get; set; }
        public Nullable<decimal> Balance { get; set; }
        public Nullable<decimal> Interest { get; set; }
        public Nullable<decimal> Principal { get; set; }
        public Nullable<decimal> PaidPrincipal { get; set; }
        public Nullable<decimal> PaidInterest { get; set; }
        public Nullable<decimal> PaidAmount { get; set; }
        public Nullable<decimal> InvestorServiceFee { get; set; }
        public Nullable<decimal> PaidInvestorServiceFee { get; set; }
    }
}
