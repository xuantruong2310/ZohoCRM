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
    
    public partial class tbl_GlobalVariables
    {
        public int VariableId { get; set; }
        public Nullable<decimal> Min_Quantum { get; set; }
        public Nullable<decimal> Min_Lot { get; set; }
        public Nullable<decimal> Min_Threshold { get; set; }
        public Nullable<int> Min_Lenders { get; set; }
        public Nullable<int> AuctionPeriod { get; set; }
        public Nullable<decimal> CurrentRation { get; set; }
        public Nullable<int> RequestCompletionDays { get; set; }
        public Nullable<decimal> LoanProfitability { get; set; }
        public Nullable<decimal> Turnover { get; set; }
        public Nullable<decimal> DebtEquity { get; set; }
        public Nullable<decimal> MinimumOfferRate { get; set; }
        public Nullable<int> MinimumOfferAmount { get; set; }
        public Nullable<int> MinimuAmountToWithdraw { get; set; }
    }
}
