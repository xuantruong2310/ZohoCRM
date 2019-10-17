using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ZohoCRM.DB;

namespace ZohoCRM.Models
{
    public class IssuerModel
    {
        
        public string BusinessName { get; set; }

        public string FullName { get; set; }

        public string UserName { get; set; }

        public string MobileNumber { get; set; }

        public decimal? ActualAmount { get; set; }

        public int? daysoverdue { get; set; }

        public decimal? totaldisbursed { get; set; }

        public decimal? overdueamount { get; set; }

        public decimal? outstandinglf { get; set; }
        public decimal? outamountwithlf { get; set; }
        public decimal? outamountwithoutlf { get; set; }

        public DateTime? LastRepaymentDate { get; set; }

        public decimal? paidlatefees { get; set; }

        public decimal? totalpaidprincipal { get; set; }

        public decimal? totalpaidinterest { get; set; }

        public decimal? totalpaidlateinterest { get; set; }
        public decimal? TotalPaidAmount { get; set; }


    }

}
