using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ZohoCRM.DB;

namespace ZohoCRM.Models
{
    public class InvestorModel
    {
        
        public string UserID { get; set; }

        public string FullName { get; set; }

        public string UserName { get; set; }

        public int Age { get; set; }

        public string Gender { get; set; }

        public string NRIC_Number { get; set; }

        public string PassportNumber { get; set; }

        public string Nationality { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public int? MobileNumber { get; set; }

        public DateTime? SignUpDate { get; set; }

        public bool? AdminVerification { get; set; }

        public DateTime? QualifiedDate { get; set; }

        public DateTime? LatestLogin { get; set; }

        public decimal? SumOfNumInvestNotes { get; set; }

        public decimal? InvestorAmount_TotalInvested { get; set; }
        public decimal? SumOfLedgerAmount { get; set; }

        public int? NumberOfDelinquentNote { get; set; }

        public decimal? TotalDelinquentAmount { get; set; }

        public int? NumberOfFullyPaidNote { get; set; }

        public decimal? InvestorAmount_PrincipalReceived { get; set; }

        public decimal? InvestorAmount_InvestReceived { get; set; }

        public decimal? TotalAmountReceived { get; set; }
        public decimal? SumOftotPaidLateInterest { get; set; }

        public int? NumberOfCloseOffNote { get; set; }

        public decimal? TotalCloseOffPandI { get; set; }

        public decimal? CurrentInFundingAmount { get; set; }

        public decimal? InvestorAmount_OutstandingP { get; set; }

        public decimal? InvestorAmount_OutstandingI { get; set; }

    }

}
