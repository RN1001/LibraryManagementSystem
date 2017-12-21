using System;

namespace LibraryManagementSystem.Models
{
    class Loan
    {
        public int LoanID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public int CopyID { get; set; }
        public int MemberID { get; set; }
        public int FinesID { get; set; }
    }

}
