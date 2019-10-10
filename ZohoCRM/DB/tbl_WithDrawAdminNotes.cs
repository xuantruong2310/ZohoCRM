namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_WithDrawAdminNotes
    {
        [Key]
        public long AdminNoteID { get; set; }

        public long WithDraw_ID { get; set; }

        public string Note { get; set; }

        public DateTime DateCreated { get; set; }

        public long? AdminID { get; set; }

        public virtual tbl_WithDrawMoney tbl_WithDrawMoney { get; set; }
    }
}
