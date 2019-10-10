namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_Knowledgeassessment_OptionsList
    {
        [Key]
        public int Optionid { get; set; }

        [StringLength(500)]
        public string Optiontext { get; set; }

        public int? Parent_Id { get; set; }

        public bool? Isactive { get; set; }

        [StringLength(50)]
        public string Optiontype { get; set; }

        [StringLength(300)]
        public string url { get; set; }

        public virtual tbl_Knowledgeassessment_Parentlist tbl_Knowledgeassessment_Parentlist { get; set; }
    }
}
