using System;
using LibraryManagementSystem.Utility;

namespace LibraryManagementSystem.Models
{
    class Reservation : ObservableObject
    {
       
        private int reservationID;

        public int ReservationID
        {
            get { return reservationID; }
            set
            {
                reservationID = value;
                NotifyPropertyChanged();
            }
        }

        private DateTime reservedDate;

        public DateTime ReservedDate
        {
            get { return reservedDate; }
            set
            {
                reservedDate = value;
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


    }

}
