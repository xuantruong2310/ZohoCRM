namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_API_ACRA_COMPANY_REGN_DATA
    {
        [Key]
        [StringLength(500)]
        public string uen { get; set; }

        [StringLength(500)]
        public string issuance_agency_id { get; set; }

        [StringLength(500)]
        public string uen_status { get; set; }

        [StringLength(500)]
        public string entity_name { get; set; }

        [StringLength(500)]
        public string entity_type { get; set; }

        [StringLength(500)]
        public string uen_issue_date { get; set; }

        [StringLength(500)]
        public string reg_street_name { get; set; }

        [StringLength(500)]
        public string reg_postal_code { get; set; }
    }
}
