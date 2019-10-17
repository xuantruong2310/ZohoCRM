using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ZohoCRM.DB;

namespace ZohoCRM.Models
{
    public class InvestorModel
    {
        
        public Int64 UserID { get; set; }

        public string FullName { get; set; }

        public string UserName { get; set; }

        public Int32? Age { get; set; }

        public string Gender { get; set; }

        public string NRIC_Number { get; set; }

        public string PassportNumber { get; set; }

        public string Nationality { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public string MobileNumber { get; set; }

        public DateTime? DateCreated { get; set; }

        public string AdminVerification { get; set; }

        public DateTime? QualifiedDate { get; set; }

        public DateTime? LastLogin { get; set; }

        public int? NumberOfInvested { get; set; }

        public decimal? TotalInvestedAmount { get; set; }
        public decimal? ActualAmount { get; set; }

        public int? numofdelinquent { get; set; }

        public decimal? outstandingPI { get; set; }

        public int? NumberOfFullyPaidNotes { get; set; }

        public decimal? PaidP { get; set; }

        public decimal? PaidI { get; set; }

        public decimal? TotalAmountReceived { get; set; }
        public decimal? PaidLI { get; set; }

        public int? NumOfCloseOff { get; set; }

        public decimal? Closeoff_PI { get; set; }

        public decimal? CurrentInFunding { get; set; }

        public decimal? outstanding_I { get; set; }

        public decimal? outstanding_P { get; set; }

    }

}
