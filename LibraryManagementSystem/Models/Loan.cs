using System;
using LibraryManagementSystem.Utility;
using MySql.Data.Types;

namespace LibraryManagementSystem.Models
{
    /// <summary>
    ///  Loan model
    /// </summary>
    /// <seealso cref="LibraryManagementSystem.Utility.ObservableObject" />
    class Loan : ObservableObject
    {
        /// <summary>
        /// The loan identifier, primary key
        /// </summary>
        private int loanID;

        /// <summary>
        /// Gets or sets the loan identifier.
        /// </summary>
        /// <value>
        /// The loan identifier.
        /// </value>
        public int LoanID
        {
            get { return loanID; }
            set
            {
                loanID = value;
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// The start date
        /// </summary>
        private MySqlDateTime startDate;

        /// <summary>
        /// Gets or sets the start date.
        /// </summary>
        /// <value>
        /// The start date.
        /// </value>
        public MySqlDateTime StartDate
        {
            get { return startDate; }
            set
            {
                startDate = value;
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// The end date
        /// </summary>
        private MySqlDateTime endDate;

        /// <summary>
        /// Gets or sets the end date.
        /// </summary>
        /// <value>
        /// The end date.
        /// </value>
        public MySqlDateTime EndDate
        {
            get { return endDate; }
            set
            {
                endDate = value;
                NotifyPropertyChanged();
            }

        }

        /// <summary>
        /// The copy identifier, foreign key
        /// </summary>
        private int copyID;

        /// <summary>
        /// Gets or sets the copy identifier.
        /// </summary>
        /// <value>
        /// The copy identifier.
        /// </value>
        public int CopyID
        {
            get { return copyID; }
            set
            {
                copyID = value;
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// The member identifier, foreign key
        /// </summary>
        private int memberID;

        /// <summary>
        /// Gets or sets the member identifier.
        /// </summary>
        /// <value>
        /// The member identifier.
        /// </value>
        public int MemberID
        {
            get { return memberID; }
            set
            {
                memberID = value;
                NotifyPropertyChanged();
            }
        }


        /// <summary>
        /// The fine identifier, foreign key
        /// </summary>
        private int fineId;

        /// <summary>
        /// Gets or sets the fine identifier.
        /// </summary>
        /// <value>
        /// The fine identifier.
        /// </value>
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
