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
    
    public partial class tbl_UserPreferences
    {
        public long PreferenceId { get; set; }
        public long User_ID { get; set; }
        public string PreferenceType { get; set; }
        public Nullable<bool> Value { get; set; }
    
        public virtual tbl_Users tbl_Users { get; set; }
    }
}
