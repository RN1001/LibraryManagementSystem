using System;
using LibraryManagementSystem.Utility;

namespace LibraryManagementSystem.Models
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="LibraryManagementSystem.Utility.ObservableObject" />
    class Renewals : ObservableObject
    {
        /// <summary>
        /// The renewal identifier
        /// </summary>
        private int renewalID;

        /// <summary>
        /// Gets or sets the renewal identifier.
        /// </summary>
        /// <value>
        /// The renewal identifier.
        /// </value>
        public int RenewalID
        {
            get { return renewalID; }
            set
            {
                renewalID = value;
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// The renewal start date
        /// </summary>
        private DateTime renStart;

        /// <summary>
        /// Gets or sets the renewal start date.
        /// </summary>
        /// <value>
        /// The ren start.
        /// </value>
        public DateTime RenStart
        {
            get { return renStart; }
            set
            {
                renStart = value;
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// The renewal end date
        /// </summary>
        private DateTime renEnd;

        /// <summary>
        /// Gets or sets the renewal end date.
        /// </summary>
        /// <value>
        /// The ren end.
        /// </value>
        public DateTime RenEnd
        {
            get { return renEnd; }
            set
            {
                renEnd = value;
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// The member identifier, foreign key
        /// </summary>
        private int memberId;

        /// <summary>
        /// Gets or sets the member identifier.
        /// </summary>
        /// <value>
        /// The member identifier.
        /// </value>
        public int MemberID
        {
            get { return memberId; }
            set
            {
                memberId = value;
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// The loan identifier foriegn key
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



    }

}
