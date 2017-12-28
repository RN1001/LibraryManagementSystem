using System;
using LibraryManagementSystem.Utility;

namespace LibraryManagementSystem.Models
{
    class Renewals : ObservableObject
    {
        private int renewalID;

        public int RenewalID
        {
            get { return renewalID; }
            set
            {
                renewalID = value;
                NotifyPropertyChanged();
            }
        }

        private DateTime renStart;

        public DateTime RenStart
        {
            get { return renStart; }
            set
            {
                renStart = value;
                NotifyPropertyChanged();
            }
        }

        private DateTime renEnd;    

        public DateTime RenEnd
        {
            get { return renEnd; }
            set
            {
                renEnd = value;
                NotifyPropertyChanged();
            }
        }

        private int memberId;

        public int MemberID
        {
            get { return memberId; }
            set
            {
                memberId = value;
                NotifyPropertyChanged();
            }
        }

        private int loanID;

        public int LoanID
        {
            get { return loanID; }
            set
            {
                loanID = value;
                NotifyPropertyChanged();
            }
        }



    }

}
