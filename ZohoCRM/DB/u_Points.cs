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
    
    public partial class u_Points
    {
        public int PointID { get; set; }
        public Nullable<long> UserID { get; set; }
        public Nullable<decimal> AccruedBalance { get; set; }
        public Nullable<decimal> AvailableBalance { get; set; }
        public Nullable<decimal> RedeemedBalance { get; set; }
    
        public virtual tbl_Users tbl_Users { get; set; }
    }
}
