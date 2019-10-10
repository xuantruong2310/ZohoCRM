namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_API_ShareholderDetails
    {
        public int ID { get; set; }

        public int? ShareholderID { get; set; }

        public string Name { get; set; }

        [StringLength(100)]
        public string IDNumber { get; set; }

        [StringLength(50)]
        public string TypeOfID { get; set; }

        [StringLength(50)]
        public string Nationality { get; set; }

        public string Address { get; set; }

        public int? ShareNumber { get; set; }

        [StringLength(10)]
        public string ShareCurrency { get; set; }

        public virtual tbl_API_Shareholder tbl_API_Shareholder { get; set; }
    }
}
