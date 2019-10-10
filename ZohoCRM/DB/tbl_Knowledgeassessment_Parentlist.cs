namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_Knowledgeassessment_Parentlist
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_Knowledgeassessment_Parentlist()
        {
            tbl_Knowledgeassessment_OptionsList = new HashSet<tbl_Knowledgeassessment_OptionsList>();
        }

        [Key]
        public int ParentId { get; set; }

        [StringLength(500)]
        public string Parenttext { get; set; }

        public int? Priority { get; set; }

        public bool? Isactive { get; set; }

        [StringLength(1)]
        public string InvType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Knowledgeassessment_OptionsList> tbl_Knowledgeassessment_OptionsList { get; set; }
    }
}
