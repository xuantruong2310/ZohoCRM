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
    
    public partial class tbl_API_BusinessLitigationFiling
    {
        public int ID { get; set; }
        public Nullable<int> BLID { get; set; }
        public string Court { get; set; }
        public string Number { get; set; }
        public string YearNum { get; set; }
        public Nullable<System.DateTime> FilingDate { get; set; }
        public string Plaintiff { get; set; }
        public string Remarks { get; set; }
        public string Status { get; set; }
        public string Amounts { get; set; }
        public Nullable<System.DateTime> Updated { get; set; }
        public Nullable<System.DateTime> CreatedTime { get; set; }
        public Nullable<System.DateTime> LastUpdated { get; set; }
    }
}
