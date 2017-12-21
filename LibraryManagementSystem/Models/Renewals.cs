using System;

namespace LibraryManagementSystem.Models
{
    class Renewals
    {
        public int RenewalID { get; set; }
        public DateTime RenStart { get; set; }
        public DateTime RenEnd { get; set; }

        public int MemberID { get; set; }
        public int LoanID { get; set; }

    }

}
