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
    
    public partial class tbl_RiskAdjustedOfReturn
    {
        public long INVESTOR_ID { get; set; }
        public Nullable<double> INVESTOR_RISKADJRATE { get; set; }
        public string RAROC { get; set; }
        public Nullable<int> INVESTOR_LOANCOUNT { get; set; }
        public Nullable<decimal> INVESTOR_OUTSTANDING_DUE { get; set; }
        public Nullable<decimal> INVESTOR_LOANAMOUNT { get; set; }
    }
}
