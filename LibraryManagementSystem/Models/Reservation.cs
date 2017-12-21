using System;

namespace LibraryManagementSystem.Models
{
    class Reservation
    {
        public int ReservationID { get; set; }
        public DateTime ReservedDate { get; set; }

        public int MemberID { get; set; }
        public int CopyID { get; set; }
    }

}
