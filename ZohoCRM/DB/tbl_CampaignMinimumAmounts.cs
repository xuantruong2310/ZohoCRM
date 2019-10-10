namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_CampaignMinimumAmounts
    {
        public int Id { get; set; }

        public decimal MinCampaignSize { get; set; }

        public decimal MaxCampaignSize { get; set; }

        public decimal MinimumAmount { get; set; }

        public decimal UnlockFee { get; set; }
    }
}
