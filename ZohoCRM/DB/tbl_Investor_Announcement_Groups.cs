namespace ZohoCRM.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_Investor_Announcement_Groups
    {
        public int Id { get; set; }

        public int AnnouncementId { get; set; }

        public int GroupId { get; set; }

        public DateTime? DateCreate { get; set; }

        public bool IsPublished { get; set; }

        public virtual tbl_Group tbl_Group { get; set; }

        public virtual tbl_Investor_Announcements tbl_Investor_Announcements { get; set; }
    }
}
