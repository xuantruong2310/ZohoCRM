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
    
    public partial class UserQualification
    {
        public long User_ID { get; set; }
        public Nullable<int> Education { get; set; }
        public Nullable<int> ProffesionalQualifications { get; set; }
        public Nullable<int> WorkExperience { get; set; }
        public Nullable<int> InvestmentExperience { get; set; }
        public Nullable<bool> InvestSuitablityQuest1 { get; set; }
        public Nullable<bool> InvestSuitablityQuest2 { get; set; }
        public Nullable<int> InvestmentPreference { get; set; }
        public Nullable<int> InvestmentObjective { get; set; }
    
        public virtual tbl_Users tbl_Users { get; set; }
    }
}
