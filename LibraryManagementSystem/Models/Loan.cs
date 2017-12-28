using System;
using LibraryManagementSystem.Utility;
using MySql.Data.Types;

namespace LibraryManagementSystem.Models
{
    class Loan : ObservableObject
    {
        private int loanId;

        public int LoandID
        {
            get { return loanID; }
            set
            {
                loanID = value;
                NotifyPropertyChanged();
            }
        }

        private MySqlDateTime startDate;

        public MySqlDateTime StartDate
        {
            get { return startDate; }
            set
            {
                startDate = value;
                NotifyPropertyChanged();
            }
        }

        private MySqlDateTime endDate;

        public MySqlDateTime EndDate
        {
            get { return endDate; }
            set
            {
                endDate = value;
                NotifyPropertyChanged();
            }

        }

        private int copyID;

        public int CopyID
        {
            get { return copyID; }
            set
            {
                copyID = value;
                NotifyPropertyChanged();
            }
        }

        private int memberID;

        public int MemberID
        {
            get { return memberID; }
            set
            {
                memberID = value;
                NotifyPropertyChanged();
            }
        }


        private int fineId;

        public int FineID
        {
            get { return fineId; }
            set
            {
                fineId = value;
                NotifyPropertyChanged();
            }
        }


    }

}
