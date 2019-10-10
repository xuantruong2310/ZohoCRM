using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ZohoCRM.DB;

namespace ZohoCRM.Models
{
    public class IssuerModel
    {
        
        public string CompanyName { get; set; }

        public string FullName { get; set; }

        public string UserName { get; set; }

        public string MobileNumber { get; set; }

        public decimal? IssuerAccountBalance { get; set; }

        public DateTime? OverdueDate { get; set; }

        public decimal? TotalAmountDisbursed { get; set; }

        public decimal? TotalAmountOverdue { get; set; }

        public decimal? OutstandingLateFee { get; set; }

        public decimal? OutstandingAmountNoLateFee { get; set; }

        public decimal? OutstandingAmountWithLateFee { get; set; }

        public DateTime? LastRepaymentDate { get; set; }

        public decimal? TotalFeesPaid { get; set; }

        public decimal? TotalPrincipalPaid { get; set; }

        public decimal? TotalInterestPaid { get; set; }

        public decimal? TotalLateInterestPaid { get; set; }

        
    }

}
