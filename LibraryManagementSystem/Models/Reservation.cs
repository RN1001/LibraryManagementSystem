using System;
using LibraryManagementSystem.Utility;

namespace LibraryManagementSystem.Models
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="LibraryManagementSystem.Utility.ObservableObject" />
    class Reservation : ObservableObject
    {

        /// <summary>
        /// The reservation identifier
        /// </summary>
        private int reservationID;

        /// <summary>
        /// Gets or sets the reservation identifier.
        /// </summary>
        /// <value>
        /// The reservation identifier.
        /// </value>
        public int ReservationID
        {
            get { return reservationID; }
            set
            {
                reservationID = value;
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// The reserved date
        /// </summary>
        private DateTime reservedDate;

        /// <summary>
        /// Gets or sets the reserved date.
        /// </summary>
        /// <value>
        /// The reserved date.
        /// </value>
        public DateTime ReservedDate
        {
            get { return reservedDate; }
            set
            {
                reservedDate = value;
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// The member identifier
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
        /// The copy identifier
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


    }

}
