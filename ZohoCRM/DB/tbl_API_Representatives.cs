namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_API_Representatives
    {
        public int ID { get; set; }

        public int? IssuerID { get; set; }

        public string Name { get; set; }

        [StringLength(100)]
        public string IDNumber { get; set; }

        [StringLength(50)]
        public string Nationality { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateOfAppointment { get; set; }

        [StringLength(100)]
        public string Position { get; set; }

        [StringLength(500)]
        public string Address { get; set; }

        [Column(TypeName = "date")]
        public DateTime? EndDate { get; set; }

        public virtual tbl_API_IssuerRegistration tbl_API_IssuerRegistration { get; set; }
    }
}
